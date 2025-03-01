<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Workshop
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Workshop))
        Me.WSRefresh = New System.Windows.Forms.Button()
        Me.OpenSelectedWSLevel = New System.Windows.Forms.Button()
        Me.UpdateMyLevel = New System.Windows.Forms.Button()
        Me.WorkshopListView = New System.Windows.Forms.ListView()
        Me.WSIndex = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.WSName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.WSCreator = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.WSDifficulty = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.WSScore = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.WSReleaseDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.WSID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.WorkshopDescription = New System.Windows.Forms.TextBox()
        Me.WorkshopLevelCode = New System.Windows.Forms.TextBox()
        Me.GenerateWSLevel = New System.Windows.Forms.Button()
        Me.SearchLevel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WSStateInfo = New System.Windows.Forms.Label()
        Me.CopyWSCode = New System.Windows.Forms.Button()
        Me.WSLogoLink = New System.Windows.Forms.PictureBox()
        Me.WSCleaner = New System.Windows.Forms.Timer(Me.components)
        Me.SearchTextbox = New System.Windows.Forms.TextBox()
        CType(Me.WSLogoLink, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WSRefresh
        '
        Me.WSRefresh.BackColor = System.Drawing.Color.Indigo
        Me.WSRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.WSRefresh.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.WSRefresh.ForeColor = System.Drawing.Color.White
        Me.WSRefresh.Location = New System.Drawing.Point(12, 12)
        Me.WSRefresh.Name = "WSRefresh"
        Me.WSRefresh.Size = New System.Drawing.Size(70, 36)
        Me.WSRefresh.TabIndex = 101
        Me.WSRefresh.Text = "刷新"
        Me.WSRefresh.UseVisualStyleBackColor = False
        '
        'OpenSelectedWSLevel
        '
        Me.OpenSelectedWSLevel.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.OpenSelectedWSLevel.ForeColor = System.Drawing.Color.Black
        Me.OpenSelectedWSLevel.Location = New System.Drawing.Point(336, 383)
        Me.OpenSelectedWSLevel.Name = "OpenSelectedWSLevel"
        Me.OpenSelectedWSLevel.Size = New System.Drawing.Size(107, 36)
        Me.OpenSelectedWSLevel.TabIndex = 107
        Me.OpenSelectedWSLevel.Text = "打开帖子"
        Me.OpenSelectedWSLevel.UseVisualStyleBackColor = True
        '
        'UpdateMyLevel
        '
        Me.UpdateMyLevel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.UpdateMyLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateMyLevel.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.UpdateMyLevel.ForeColor = System.Drawing.Color.Indigo
        Me.UpdateMyLevel.Location = New System.Drawing.Point(12, 383)
        Me.UpdateMyLevel.Name = "UpdateMyLevel"
        Me.UpdateMyLevel.Size = New System.Drawing.Size(138, 36)
        Me.UpdateMyLevel.TabIndex = 109
        Me.UpdateMyLevel.Text = "去论坛发布关卡"
        Me.UpdateMyLevel.UseVisualStyleBackColor = False
        '
        'WorkshopListView
        '
        Me.WorkshopListView.Alignment = System.Windows.Forms.ListViewAlignment.Left
        Me.WorkshopListView.AllowColumnReorder = True
        Me.WorkshopListView.AutoArrange = False
        Me.WorkshopListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.WSIndex, Me.WSName, Me.WSCreator, Me.WSDifficulty, Me.WSScore, Me.WSReleaseDate, Me.WSID})
        Me.WorkshopListView.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.WorkshopListView.FullRowSelect = True
        Me.WorkshopListView.GridLines = True
        Me.WorkshopListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.WorkshopListView.HideSelection = False
        Me.WorkshopListView.LabelWrap = False
        Me.WorkshopListView.Location = New System.Drawing.Point(12, 58)
        Me.WorkshopListView.MultiSelect = False
        Me.WorkshopListView.Name = "WorkshopListView"
        Me.WorkshopListView.ShowGroups = False
        Me.WorkshopListView.Size = New System.Drawing.Size(551, 242)
        Me.WorkshopListView.TabIndex = 111
        Me.WorkshopListView.UseCompatibleStateImageBehavior = False
        Me.WorkshopListView.View = System.Windows.Forms.View.Details
        '
        'WSIndex
        '
        Me.WSIndex.Text = "序号"
        Me.WSIndex.Width = 44
        '
        'WSName
        '
        Me.WSName.Text = "关卡名"
        Me.WSName.Width = 100
        '
        'WSCreator
        '
        Me.WSCreator.Text = "上传者"
        Me.WSCreator.Width = 100
        '
        'WSDifficulty
        '
        Me.WSDifficulty.Text = "难度"
        Me.WSDifficulty.Width = 44
        '
        'WSScore
        '
        Me.WSScore.Text = "评分"
        Me.WSScore.Width = 44
        '
        'WSReleaseDate
        '
        Me.WSReleaseDate.Text = "发布于"
        Me.WSReleaseDate.Width = 140
        '
        'WSID
        '
        Me.WSID.Text = "ID"
        Me.WSID.Width = 54
        '
        'WorkshopDescription
        '
        Me.WorkshopDescription.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.WorkshopDescription.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.WorkshopDescription.Location = New System.Drawing.Point(12, 309)
        Me.WorkshopDescription.MaxLength = 2000
        Me.WorkshopDescription.Name = "WorkshopDescription"
        Me.WorkshopDescription.ReadOnly = True
        Me.WorkshopDescription.Size = New System.Drawing.Size(551, 27)
        Me.WorkshopDescription.TabIndex = 113
        '
        'WorkshopLevelCode
        '
        Me.WorkshopLevelCode.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.WorkshopLevelCode.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.WorkshopLevelCode.Location = New System.Drawing.Point(12, 346)
        Me.WorkshopLevelCode.MaxLength = 2000
        Me.WorkshopLevelCode.Name = "WorkshopLevelCode"
        Me.WorkshopLevelCode.ReadOnly = True
        Me.WorkshopLevelCode.Size = New System.Drawing.Size(523, 27)
        Me.WorkshopLevelCode.TabIndex = 114
        '
        'GenerateWSLevel
        '
        Me.GenerateWSLevel.BackColor = System.Drawing.Color.Indigo
        Me.GenerateWSLevel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GenerateWSLevel.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.GenerateWSLevel.ForeColor = System.Drawing.Color.White
        Me.GenerateWSLevel.Location = New System.Drawing.Point(456, 383)
        Me.GenerateWSLevel.Name = "GenerateWSLevel"
        Me.GenerateWSLevel.Size = New System.Drawing.Size(107, 36)
        Me.GenerateWSLevel.TabIndex = 115
        Me.GenerateWSLevel.Text = "生成关卡"
        Me.GenerateWSLevel.UseVisualStyleBackColor = False
        '
        'SearchLevel
        '
        Me.SearchLevel.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.SearchLevel.ForeColor = System.Drawing.Color.Black
        Me.SearchLevel.Location = New System.Drawing.Point(236, 12)
        Me.SearchLevel.Name = "SearchLevel"
        Me.SearchLevel.Size = New System.Drawing.Size(70, 36)
        Me.SearchLevel.TabIndex = 116
        Me.SearchLevel.Text = "搜索"
        Me.SearchLevel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(474, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 20)
        Me.Label1.TabIndex = 118
        Me.Label1.Text = "提供技术支持"
        '
        'WSStateInfo
        '
        Me.WSStateInfo.AutoSize = True
        Me.WSStateInfo.Font = New System.Drawing.Font("微软雅黑", 11.0!, System.Drawing.FontStyle.Bold)
        Me.WSStateInfo.ForeColor = System.Drawing.Color.Indigo
        Me.WSStateInfo.Location = New System.Drawing.Point(168, 393)
        Me.WSStateInfo.Name = "WSStateInfo"
        Me.WSStateInfo.Size = New System.Drawing.Size(0, 19)
        Me.WSStateInfo.TabIndex = 120
        '
        'CopyWSCode
        '
        Me.CopyWSCode.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources.Copy
        Me.CopyWSCode.Location = New System.Drawing.Point(535, 345)
        Me.CopyWSCode.Name = "CopyWSCode"
        Me.CopyWSCode.Size = New System.Drawing.Size(29, 29)
        Me.CopyWSCode.TabIndex = 119
        Me.CopyWSCode.UseVisualStyleBackColor = True
        '
        'WSLogoLink
        '
        Me.WSLogoLink.BackColor = System.Drawing.Color.Transparent
        Me.WSLogoLink.BackgroundImage = CType(resources.GetObject("WSLogoLink.BackgroundImage"), System.Drawing.Image)
        Me.WSLogoLink.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WSLogoLink.Location = New System.Drawing.Point(322, 14)
        Me.WSLogoLink.Name = "WSLogoLink"
        Me.WSLogoLink.Size = New System.Drawing.Size(146, 33)
        Me.WSLogoLink.TabIndex = 121
        Me.WSLogoLink.TabStop = False
        '
        'WSCleaner
        '
        Me.WSCleaner.Interval = 3000
        '
        'SearchTextbox
        '
        Me.SearchTextbox.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.SearchTextbox.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.SearchTextbox.Location = New System.Drawing.Point(100, 17)
        Me.SearchTextbox.MaxLength = 100
        Me.SearchTextbox.Name = "SearchTextbox"
        Me.SearchTextbox.Size = New System.Drawing.Size(117, 27)
        Me.SearchTextbox.TabIndex = 122
        '
        'Workshop
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(579, 429)
        Me.Controls.Add(Me.SearchTextbox)
        Me.Controls.Add(Me.WSLogoLink)
        Me.Controls.Add(Me.WSStateInfo)
        Me.Controls.Add(Me.CopyWSCode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SearchLevel)
        Me.Controls.Add(Me.GenerateWSLevel)
        Me.Controls.Add(Me.WorkshopLevelCode)
        Me.Controls.Add(Me.WorkshopDescription)
        Me.Controls.Add(Me.WorkshopListView)
        Me.Controls.Add(Me.UpdateMyLevel)
        Me.Controls.Add(Me.OpenSelectedWSLevel)
        Me.Controls.Add(Me.WSRefresh)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Workshop"
        Me.Text = "布阵器创意工坊"
        CType(Me.WSLogoLink, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WSRefresh As Button
    Friend WithEvents OpenSelectedWSLevel As Button
    Friend WithEvents UpdateMyLevel As Button
    Friend WithEvents WorkshopListView As ListView
    Friend WithEvents WSName As ColumnHeader
    Friend WithEvents WSDifficulty As ColumnHeader
    Friend WithEvents WSScore As ColumnHeader
    Friend WithEvents WSIndex As ColumnHeader
    Friend WithEvents WorkshopDescription As TextBox
    Friend WithEvents WorkshopLevelCode As TextBox
    Friend WithEvents WSID As ColumnHeader
    Friend WithEvents WSReleaseDate As ColumnHeader
    Friend WithEvents WSCreator As ColumnHeader
    Friend WithEvents GenerateWSLevel As Button
    Friend WithEvents SearchLevel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CopyWSCode As Button
    Friend WithEvents WSStateInfo As Label
    Friend WithEvents WSLogoLink As PictureBox
    Friend WithEvents WSCleaner As Timer
    Friend WithEvents SearchTextbox As TextBox
End Class
