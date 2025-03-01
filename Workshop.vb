Imports System.Text.RegularExpressions
Imports PvZHomeAPI

Public Class Workshop

    '打开超链接
    Public Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hWnd As Long, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Long) As Long
    Public hWndOpenLink As Long

    '核心：刷新获取关卡
    Private Sub WSRefresh_Click(sender As Object, e As EventArgs) Handles WSRefresh.Click

        Try

            Dim rr As ResourcesResponse = Api.GetResources(19, "BQUa7-AM1DRB8eJi6S3p-tlB7W4VVVxQ")

            WorkshopListView.Items.Clear()
            WorkshopListView.BeginUpdate()


            Dim index As Integer = 0

            For Each ferrs In rr.Resources

                '1列 序号
                WorkshopListView.Items.Add(index + 1)

                '2列 标题
                WorkshopListView.Items(index).SubItems.Add(ferrs.Title)

                '3列 作者
                WorkshopListView.Items(index).SubItems.Add(ferrs.Username)

                '4列 难度
                Dim difftext As String = ""
                Select Case ferrs.CustomFields("difficulty")
                    Case 1
                        difftext = "简单"
                    Case 2
                        difftext = "普通"
                    Case 3
                        difftext = "困难"
                    Case 4
                        difftext = "极难"
                    Case Else
                        difftext = ""
                End Select
                WorkshopListView.Items(index).SubItems.Add(difftext)

                '5列 评分
                WorkshopListView.Items(index).SubItems.Add(ferrs.RatingAvg)

                '6列 发布日期
                Dim localTime As DateTime = DateTimeOffset.FromUnixTimeSeconds(ferrs.ResourceDate).DateTime.ToLocalTime()

                WorkshopListView.Items(index).SubItems.Add(ExchangeTime(localTime))

                '7列 ID
                WorkshopListView.Items(index).SubItems.Add(ferrs.ResourceId)

                index += 1

            Next

            WorkshopListView.EndUpdate()

            '刷新指示器状态
            WSStateInfo.ForeColor = Color.Indigo
            WSStateInfo.Text = "刷新成功"
            WSCleaner.Enabled = False
            WSCleaner.Enabled = True

        Catch ex As Exception

            WSStateInfo.ForeColor = Color.Red
            WSStateInfo.Text = "网络错误"
            WSCleaner.Enabled = False
            WSCleaner.Enabled = True

        End Try

    End Sub

    '核心：切换关卡刷新信息
    Private Sub WorkshopListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles WorkshopListView.SelectedIndexChanged

        Try

            If WorkshopListView.SelectedItems.Count > 0 Then

                Dim selectID As Integer = WorkshopListView.SelectedItems(0).SubItems(6).Text

                Dim getResourceDetail As ResourceDetailResponse = Api.GetResourceDetail(selectID, "BQUa7-AM1DRB8eJi6S3p-tlB7W4VVVxQ")

                WorkshopDescription.Text = getResourceDetail.TagLine

                WorkshopLevelCode.Text = getResourceDetail.CustomFields("level")

            End If

        Catch ex As Exception

            WSStateInfo.ForeColor = Color.Red
            WSStateInfo.Text = "网络错误"
        WSCleaner.Enabled = False
        WSCleaner.Enabled = True

        End Try


    End Sub

    '核心：关卡查找（移除）
    Private Sub SearchLevel_Click(sender As Object, e As EventArgs) Handles SearchLevel.Click

        If SearchTextbox.Text = "" Then

            '只刷新关卡库
            WSRefresh_Click(sender, e)

        Else

            '先刷新关卡库
            WSRefresh_Click(sender, e)

            '再移除不正确关卡
            For Each level As ListViewItem In WorkshopListView.Items

                Dim levelname As String = level.SubItems(1).Text
                Dim creatorname As String = level.SubItems(2).Text

                If Not levelname.Contains(SearchTextbox.Text) AndAlso Not creatorname.Contains(SearchTextbox.Text) Then
                    WorkshopListView.Items.Remove(level)
                End If
            Next

        End If
    End Sub

    '去论坛发布关卡
    Private Sub UpdateMyLevel_Click(sender As Object, e As EventArgs) Handles UpdateMyLevel.Click
        Call ShellExecute(hWndOpenLink, "open", "https://www.pvz.moe/resources/categories/19/add", vbNullString, vbNullString, &H0)
    End Sub

    '打开关卡的论坛
    Private Sub OpenSelectedWSLevel_Click(sender As Object, e As EventArgs) Handles OpenSelectedWSLevel.Click
        If WorkshopListView.SelectedItems.Count > 0 Then

            Dim LevelWSLink As String = “https://www.pvz.moe/resources/”
            LevelWSLink += WorkshopListView.SelectedItems(0).SubItems(6).Text
            Call ShellExecute(hWndOpenLink, "open", LevelWSLink, vbNullString, vbNullString, &H0)
        End If

    End Sub

    '复制关卡代码
    Private Sub CopyWSCode_Click(sender As Object, e As EventArgs) Handles CopyWSCode.Click
        Clipboard.SetData(DataFormats.Text, WorkshopLevelCode.Text)
        WSStateInfo.ForeColor = Color.Indigo
        WSStateInfo.Text = "已复制"
        WSCleaner.Enabled = False
        WSCleaner.Enabled = True
    End Sub

#Region "在新窗口生产关卡"

    '生成关卡
    Private Sub GenerateWSLevel_Click(sender As Object, e As EventArgs) Handles GenerateWSLevel.Click

        If Not WorkshopLevelCode.Text = "" Then

            Dim WSInLevelCode As String = WorkshopLevelCode.Text

            Dim portal_code As String

            '去掉所有的空格
            WSInLevelCode = WSInLevelCode.Replace(" ", "")

            '有传送门吗

            Dim find_char As Integer = WSInLevelCode.IndexOf("|")  '没找到为-1

            '有
            If find_char <> -1 AndAlso find_char < WSInLevelCode.Length - 1 Then

                '获取传送门代码
                portal_code = Main.GetPortalCode(WSInLevelCode)

                '删除传送门代码
                WSInLevelCode = Main.RemoveSlash(WSInLevelCode, find_char)

            Else portal_code = "" '没有传送门代码

            End If

            If PVZ.LevelState = PVZ.GameState.Playing Then

                Select Case Main.StrToPla(WSInLevelCode, portal_code)
                    Case 1
                        WSStateInfo.ForeColor = Color.Indigo
                        WSStateInfo.Text = "关卡已生成"
                        WSCleaner.Enabled = False
                        WSCleaner.Enabled = True
                    Case 2
                        WSStateInfo.ForeColor = Color.Red
                        WSStateInfo.Text = "错误的代码"
                        WSCleaner.Enabled = False
                        WSCleaner.Enabled = True
                    Case 3
                        WSStateInfo.ForeColor = Color.Red
                        WSStateInfo.Text = "代码异常"
                        WSCleaner.Enabled = False
                        WSCleaner.Enabled = True
                    Case 4
                        WSStateInfo.ForeColor = Color.Red
                        WSStateInfo.Text = "传送门错误"
                        WSCleaner.Enabled = False
                        WSCleaner.Enabled = True
                End Select

            Else WSStateInfo.ForeColor = Color.Red
                WSStateInfo.Text = "不在关卡中"
                WSCleaner.Enabled = False
                WSCleaner.Enabled = True

            End If


        End If



    End Sub

#End Region

    '时间转换器
    Function ExchangeTime(inputDateTime As DateTime) As String

        Dim now As DateTime = DateTime.Now
        Dim timeDifference As TimeSpan = now - inputDateTime

        If timeDifference.TotalMinutes <= 60 Then
            ' 1小时以内
            Return $"{CInt(timeDifference.TotalMinutes)}分钟前"

        ElseIf timeDifference.TotalHours <= 24 Then
            ' 24小时以内
            Return $"{CInt(timeDifference.TotalHours)}小时{timeDifference.Minutes}分钟前"

        ElseIf timeDifference.TotalHours <= 48 Then
            ' 24~48小时
            Return $"昨天 {inputDateTime:HH:mm}"

        ElseIf timeDifference.TotalHours <= 72 Then
            ' 48~72小时
            Return $"前天 {inputDateTime:HH:mm}"

        Else
            ' 其他情况
            Return inputDateTime.ToString("yy/MM/dd HH:mm")
        End If
    End Function

    'logo跳转论坛首页
    Private Sub WSLogoLink_Click(sender As Object, e As EventArgs) Handles WSLogoLink.Click
        Call ShellExecute(hWndOpenLink, "open", "https://www.pvz.moe/", vbNullString, vbNullString, &H0)
    End Sub

    '信息文本刷新器
    Private Sub WSCleaner_Tick(sender As Object, e As EventArgs) Handles WSCleaner.Tick
        WSStateInfo.Text = ""
        WSCleaner.Enabled = False
    End Sub


End Class