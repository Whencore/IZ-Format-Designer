<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.RightClickEnterCode = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.粘贴CtrlVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.粘贴并生成ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.复制内容ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.清空ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MagnetT = New System.Windows.Forms.Timer(Me.components)
        Me.FinderMagnet = New System.Windows.Forms.Timer(Me.components)
        Me.CleanStateText = New System.Windows.Forms.Timer(Me.components)
        Me.PlantDeltaTime = New System.Windows.Forms.Timer(Me.components)
        Me.MouseMoveDetector = New System.Windows.Forms.Timer(Me.components)
        Me.DeleteReset = New System.Windows.Forms.Timer(Me.components)
        Me.Tips = New System.Windows.Forms.ToolTip(Me.components)
        Me.PlantSwitchText = New System.Windows.Forms.Label()
        Me.SwitchintoIZE = New System.Windows.Forms.Button()
        Me.Fail = New System.Windows.Forms.Button()
        Me.ManualCtrl = New System.Windows.Forms.CheckBox()
        Me.AllowPlants = New System.Windows.Forms.CheckBox()
        Me.QLoad = New System.Windows.Forms.Button()
        Me.Randomizer = New System.Windows.Forms.Button()
        Me.RandomEndless = New System.Windows.Forms.CheckBox()
        Me.SpeedUp = New System.Windows.Forms.CheckBox()
        Me.OpenSaveFold = New System.Windows.Forms.Button()
        Me.Clear = New System.Windows.Forms.Button()
        Me.KillAll = New System.Windows.Forms.Button()
        Me.CreateCodeAndCopy = New System.Windows.Forms.Button()
        Me.CobNoCD = New System.Windows.Forms.CheckBox()
        Me.LockKernel = New System.Windows.Forms.CheckBox()
        Me.AutoColletct = New System.Windows.Forms.CheckBox()
        Me.LockShovel = New System.Windows.Forms.CheckBox()
        Me.CodeState = New System.Windows.Forms.Label()
        Me.SunRefresher = New System.Windows.Forms.Timer(Me.components)
        Me.Settings = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.UpdateInfoButton = New System.Windows.Forms.Button()
        Me.VideoButton = New System.Windows.Forms.Button()
        Me.KeyingGB = New System.Windows.Forms.GroupBox()
        Me.LabelSpeedUp = New System.Windows.Forms.Label()
        Me.LabelChangeKeyPlant = New System.Windows.Forms.Label()
        Me.ResetKeySet = New System.Windows.Forms.Button()
        Me.PlantKeyEdit = New System.Windows.Forms.ComboBox()
        Me.SpeedUpKeyEdit = New System.Windows.Forms.ComboBox()
        Me.LabelOnce = New System.Windows.Forms.Label()
        Me.ExchangeKeys = New System.Windows.Forms.Button()
        Me.ShovelOnceKeyEdit = New System.Windows.Forms.ComboBox()
        Me.About = New System.Windows.Forms.GroupBox()
        Me.WinkleLogo = New System.Windows.Forms.PictureBox()
        Me.TipsNumber = New System.Windows.Forms.Label()
        Me.LabelTips = New System.Windows.Forms.Label()
        Me.StatisticsInfo = New System.Windows.Forms.Button()
        Me.LabelVersion = New System.Windows.Forms.Label()
        Me.LabelWarn = New System.Windows.Forms.Label()
        Me.LabelWelcome = New System.Windows.Forms.Label()
        Me.AboutUs = New System.Windows.Forms.Label()
        Me.FormingGB = New System.Windows.Forms.GroupBox()
        Me.AutoFillPortalPos = New System.Windows.Forms.CheckBox()
        Me.IZECardOnly = New System.Windows.Forms.CheckBox()
        Me.RealPlants = New System.Windows.Forms.CheckBox()
        Me.NormalizeGB = New System.Windows.Forms.GroupBox()
        Me.SpeedIndexText = New System.Windows.Forms.Label()
        Me.SpeedIndex = New System.Windows.Forms.TrackBar()
        Me.SpeedIndexLabel = New System.Windows.Forms.Label()
        Me.AutoPaste = New System.Windows.Forms.CheckBox()
        Me.MagnetTimerSwitch = New System.Windows.Forms.CheckBox()
        Me.ResetProgramme = New System.Windows.Forms.Button()
        Me.Levels = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RandIZEScore = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DownloadWSLevel = New System.Windows.Forms.Button()
        Me.WSLevelID = New System.Windows.Forms.TextBox()
        Me.OpenWS = New System.Windows.Forms.Button()
        Me.LabelLevelWSID = New System.Windows.Forms.Label()
        Me.GBLevelCollection = New System.Windows.Forms.GroupBox()
        Me.CopyMyCode = New System.Windows.Forms.Button()
        Me.LevelCollectionListBox = New System.Windows.Forms.ListBox()
        Me.LevelStateinInformation = New System.Windows.Forms.Label()
        Me.LevelListView = New System.Windows.Forms.ListView()
        Me.ColumnLevelIndex = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnLevelName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnLevelDesigner = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnLevelDifficulty = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CopyYourLevelInfo = New System.Windows.Forms.Button()
        Me.SaveYourLevel = New System.Windows.Forms.Button()
        Me.YourLevelCode = New System.Windows.Forms.TextBox()
        Me.ResetYourLevel_ConfirmT = New System.Windows.Forms.Button()
        Me.LabelLevelCodeinInformation = New System.Windows.Forms.Label()
        Me.ResetYourLevel_ConfirmF = New System.Windows.Forms.Button()
        Me.YourLevelDescription = New System.Windows.Forms.TextBox()
        Me.ResetYourLevel = New System.Windows.Forms.Button()
        Me.CBLevelDifficulty = New System.Windows.Forms.ComboBox()
        Me.GenerateThisLevel = New System.Windows.Forms.Button()
        Me.LabelLevelDescription = New System.Windows.Forms.Label()
        Me.LabelLevelName = New System.Windows.Forms.Label()
        Me.LabelDifficulty = New System.Windows.Forms.Label()
        Me.YourLevelName = New System.Windows.Forms.TextBox()
        Me.LabelLevelDesigner = New System.Windows.Forms.Label()
        Me.YourName = New System.Windows.Forms.TextBox()
        Me.Design = New System.Windows.Forms.TabPage()
        Me.PlantsTransform = New System.Windows.Forms.GroupBox()
        Me.PlantXY = New System.Windows.Forms.Button()
        Me.PlantY = New System.Windows.Forms.ComboBox()
        Me.PlantX = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelCol = New System.Windows.Forms.Label()
        Me.LabelRow = New System.Windows.Forms.Label()
        Me.SwCol2 = New System.Windows.Forms.ComboBox()
        Me.SwCol1 = New System.Windows.Forms.ComboBox()
        Me.SwRow2 = New System.Windows.Forms.ComboBox()
        Me.SwRow1 = New System.Windows.Forms.ComboBox()
        Me.SwitchCol = New System.Windows.Forms.Button()
        Me.SwitchRow = New System.Windows.Forms.Button()
        Me.PortalDesign = New System.Windows.Forms.GroupBox()
        Me.PBBY = New System.Windows.Forms.ComboBox()
        Me.PBBX = New System.Windows.Forms.ComboBox()
        Me.PBAY = New System.Windows.Forms.ComboBox()
        Me.PBAX = New System.Windows.Forms.ComboBox()
        Me.PWBY = New System.Windows.Forms.ComboBox()
        Me.ActivePortal = New System.Windows.Forms.CheckBox()
        Me.LabelPBBY = New System.Windows.Forms.Label()
        Me.PWBX = New System.Windows.Forms.ComboBox()
        Me.LabelPBBX = New System.Windows.Forms.Label()
        Me.LabelPBAY = New System.Windows.Forms.Label()
        Me.PWAY = New System.Windows.Forms.ComboBox()
        Me.LabelPBAX = New System.Windows.Forms.Label()
        Me.PicturePBA = New System.Windows.Forms.PictureBox()
        Me.PWAX = New System.Windows.Forms.ComboBox()
        Me.CreatePortalButton = New System.Windows.Forms.Button()
        Me.PicturePBB = New System.Windows.Forms.PictureBox()
        Me.LabelPWAY = New System.Windows.Forms.Label()
        Me.LabelPWBX = New System.Windows.Forms.Label()
        Me.LabelPWAX = New System.Windows.Forms.Label()
        Me.PicturePWA = New System.Windows.Forms.PictureBox()
        Me.LabelPWBY = New System.Windows.Forms.Label()
        Me.PicturePWB = New System.Windows.Forms.PictureBox()
        Me.PlantMode = New System.Windows.Forms.GroupBox()
        Me.PlantSwitch = New System.Windows.Forms.CheckBox()
        Me.ChoosePlant = New System.Windows.Forms.GroupBox()
        Me.SelectedPlantName = New System.Windows.Forms.Label()
        Me.Selected = New System.Windows.Forms.PictureBox()
        Me.Card49 = New System.Windows.Forms.PictureBox()
        Me.Card50 = New System.Windows.Forms.PictureBox()
        Me.Card51 = New System.Windows.Forms.PictureBox()
        Me.Card52 = New System.Windows.Forms.PictureBox()
        Me.Card53 = New System.Windows.Forms.PictureBox()
        Me.Card54 = New System.Windows.Forms.PictureBox()
        Me.Card55 = New System.Windows.Forms.PictureBox()
        Me.Card56 = New System.Windows.Forms.PictureBox()
        Me.Card41 = New System.Windows.Forms.PictureBox()
        Me.Card42 = New System.Windows.Forms.PictureBox()
        Me.Card43 = New System.Windows.Forms.PictureBox()
        Me.Card44 = New System.Windows.Forms.PictureBox()
        Me.Card45 = New System.Windows.Forms.PictureBox()
        Me.Card46 = New System.Windows.Forms.PictureBox()
        Me.Card47 = New System.Windows.Forms.PictureBox()
        Me.Card48 = New System.Windows.Forms.PictureBox()
        Me.Card33 = New System.Windows.Forms.PictureBox()
        Me.Card34 = New System.Windows.Forms.PictureBox()
        Me.Card35 = New System.Windows.Forms.PictureBox()
        Me.Card36 = New System.Windows.Forms.PictureBox()
        Me.Card37 = New System.Windows.Forms.PictureBox()
        Me.Card38 = New System.Windows.Forms.PictureBox()
        Me.Card39 = New System.Windows.Forms.PictureBox()
        Me.Card40 = New System.Windows.Forms.PictureBox()
        Me.Card25 = New System.Windows.Forms.PictureBox()
        Me.Card26 = New System.Windows.Forms.PictureBox()
        Me.Card27 = New System.Windows.Forms.PictureBox()
        Me.Card28 = New System.Windows.Forms.PictureBox()
        Me.Card29 = New System.Windows.Forms.PictureBox()
        Me.Card30 = New System.Windows.Forms.PictureBox()
        Me.Card31 = New System.Windows.Forms.PictureBox()
        Me.Card32 = New System.Windows.Forms.PictureBox()
        Me.Card17 = New System.Windows.Forms.PictureBox()
        Me.Card18 = New System.Windows.Forms.PictureBox()
        Me.Card19 = New System.Windows.Forms.PictureBox()
        Me.Card20 = New System.Windows.Forms.PictureBox()
        Me.Card21 = New System.Windows.Forms.PictureBox()
        Me.Card22 = New System.Windows.Forms.PictureBox()
        Me.Card23 = New System.Windows.Forms.PictureBox()
        Me.Card24 = New System.Windows.Forms.PictureBox()
        Me.Card9 = New System.Windows.Forms.PictureBox()
        Me.Card10 = New System.Windows.Forms.PictureBox()
        Me.Card11 = New System.Windows.Forms.PictureBox()
        Me.Card12 = New System.Windows.Forms.PictureBox()
        Me.Card13 = New System.Windows.Forms.PictureBox()
        Me.Card14 = New System.Windows.Forms.PictureBox()
        Me.Card15 = New System.Windows.Forms.PictureBox()
        Me.Card16 = New System.Windows.Forms.PictureBox()
        Me.Card1 = New System.Windows.Forms.PictureBox()
        Me.Card2 = New System.Windows.Forms.PictureBox()
        Me.Card3 = New System.Windows.Forms.PictureBox()
        Me.Card4 = New System.Windows.Forms.PictureBox()
        Me.Card5 = New System.Windows.Forms.PictureBox()
        Me.Card6 = New System.Windows.Forms.PictureBox()
        Me.Card7 = New System.Windows.Forms.PictureBox()
        Me.Card8 = New System.Windows.Forms.PictureBox()
        Me.Basic = New System.Windows.Forms.TabPage()
        Me.QuickClick = New System.Windows.Forms.GroupBox()
        Me.FindWindowAgain = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.QSave = New System.Windows.Forms.Button()
        Me.NoCD = New System.Windows.Forms.CheckBox()
        Me.LockButter = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ZombieCardEditGB = New System.Windows.Forms.GroupBox()
        Me.ResetZombieCardProperty = New System.Windows.Forms.Button()
        Me.ZombieSunConfirm = New System.Windows.Forms.Button()
        Me.ZombieCardSun = New System.Windows.Forms.TextBox()
        Me.ZombieCardSunType = New System.Windows.Forms.ComboBox()
        Me.LabelZombieCardSun = New System.Windows.Forms.Label()
        Me.ReplaceConfirm = New System.Windows.Forms.Button()
        Me.ReplaceA = New System.Windows.Forms.ComboBox()
        Me.ReplaceB = New System.Windows.Forms.ComboBox()
        Me.LabelSwitchZombieTo = New System.Windows.Forms.Label()
        Me.LevelCodeOutPut = New System.Windows.Forms.GroupBox()
        Me.EnterCode = New System.Windows.Forms.RichTextBox()
        Me.ClearText = New System.Windows.Forms.Button()
        Me.ReadCode = New System.Windows.Forms.Button()
        Me.MagTimer = New System.Windows.Forms.GroupBox()
        Me.M5XY = New System.Windows.Forms.Label()
        Me.M4XY = New System.Windows.Forms.Label()
        Me.M3XY = New System.Windows.Forms.Label()
        Me.M2XY = New System.Windows.Forms.Label()
        Me.M1XY = New System.Windows.Forms.Label()
        Me.Mtimer5 = New System.Windows.Forms.Label()
        Me.Mtimer4 = New System.Windows.Forms.Label()
        Me.Mtimer3 = New System.Windows.Forms.Label()
        Me.Mtimer2 = New System.Windows.Forms.Label()
        Me.Mtimer1 = New System.Windows.Forms.Label()
        Me.BasicSetting = New System.Windows.Forms.GroupBox()
        Me.SunToMax = New System.Windows.Forms.Button()
        Me.RedLineInfo = New System.Windows.Forms.Label()
        Me.ZomCard = New System.Windows.Forms.ComboBox()
        Me.LableSetCard = New System.Windows.Forms.Label()
        Me.CardSlotInfo = New System.Windows.Forms.Label()
        Me.SunConfirm = New System.Windows.Forms.Button()
        Me.ModifySun = New System.Windows.Forms.TextBox()
        Me.RedLineBar = New System.Windows.Forms.TrackBar()
        Me.SunTo2K = New System.Windows.Forms.Button()
        Me.LableSun = New System.Windows.Forms.Label()
        Me.CardSlotBar = New System.Windows.Forms.TrackBar()
        Me.ZombieType = New System.Windows.Forms.ComboBox()
        Me.LableCardSlot = New System.Windows.Forms.Label()
        Me.LableRedLine = New System.Windows.Forms.Label()
        Me.StateInfo = New System.Windows.Forms.GroupBox()
        Me.GameState = New System.Windows.Forms.Label()
        Me.MyTab = New System.Windows.Forms.TabControl()
        Me.IZEStateChecker = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RightClickEnterCode.SuspendLayout()
        Me.Settings.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.KeyingGB.SuspendLayout()
        Me.About.SuspendLayout()
        CType(Me.WinkleLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FormingGB.SuspendLayout()
        Me.NormalizeGB.SuspendLayout()
        CType(Me.SpeedIndex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Levels.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GBLevelCollection.SuspendLayout()
        Me.Design.SuspendLayout()
        Me.PlantsTransform.SuspendLayout()
        Me.PortalDesign.SuspendLayout()
        CType(Me.PicturePBA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicturePBB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicturePWA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicturePWB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PlantMode.SuspendLayout()
        Me.ChoosePlant.SuspendLayout()
        CType(Me.Selected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card49, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card50, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card51, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card52, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card53, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card54, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card55, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card56, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card45, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card46, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card47, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card48, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Basic.SuspendLayout()
        Me.QuickClick.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ZombieCardEditGB.SuspendLayout()
        Me.LevelCodeOutPut.SuspendLayout()
        Me.MagTimer.SuspendLayout()
        Me.BasicSetting.SuspendLayout()
        CType(Me.RedLineBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CardSlotBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StateInfo.SuspendLayout()
        Me.MyTab.SuspendLayout()
        Me.SuspendLayout()
        '
        'RightClickEnterCode
        '
        Me.RightClickEnterCode.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.RightClickEnterCode.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.粘贴CtrlVToolStripMenuItem, Me.粘贴并生成ToolStripMenuItem, Me.复制内容ToolStripMenuItem, Me.清空ToolStripMenuItem})
        Me.RightClickEnterCode.Name = "ContextMenuStrip1"
        Me.RightClickEnterCode.Size = New System.Drawing.Size(145, 124)
        '
        '粘贴CtrlVToolStripMenuItem
        '
        Me.粘贴CtrlVToolStripMenuItem.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources.Paste
        Me.粘贴CtrlVToolStripMenuItem.Name = "粘贴CtrlVToolStripMenuItem"
        Me.粘贴CtrlVToolStripMenuItem.Size = New System.Drawing.Size(144, 30)
        Me.粘贴CtrlVToolStripMenuItem.Text = "粘贴"
        '
        '粘贴并生成ToolStripMenuItem
        '
        Me.粘贴并生成ToolStripMenuItem.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources.PasteAndCreate
        Me.粘贴并生成ToolStripMenuItem.Name = "粘贴并生成ToolStripMenuItem"
        Me.粘贴并生成ToolStripMenuItem.Size = New System.Drawing.Size(144, 30)
        Me.粘贴并生成ToolStripMenuItem.Text = "粘贴并生成"
        '
        '复制内容ToolStripMenuItem
        '
        Me.复制内容ToolStripMenuItem.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources.Copy
        Me.复制内容ToolStripMenuItem.Name = "复制内容ToolStripMenuItem"
        Me.复制内容ToolStripMenuItem.Size = New System.Drawing.Size(144, 30)
        Me.复制内容ToolStripMenuItem.Text = "复制内容"
        '
        '清空ToolStripMenuItem
        '
        Me.清空ToolStripMenuItem.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources.Cross
        Me.清空ToolStripMenuItem.Name = "清空ToolStripMenuItem"
        Me.清空ToolStripMenuItem.Size = New System.Drawing.Size(144, 30)
        Me.清空ToolStripMenuItem.Text = "清空"
        '
        'MagnetT
        '
        '
        'FinderMagnet
        '
        Me.FinderMagnet.Enabled = True
        '
        'CleanStateText
        '
        Me.CleanStateText.Interval = 3000
        '
        'PlantDeltaTime
        '
        Me.PlantDeltaTime.Interval = 200
        '
        'MouseMoveDetector
        '
        Me.MouseMoveDetector.Enabled = True
        '
        'DeleteReset
        '
        Me.DeleteReset.Interval = 5000
        '
        'PlantSwitchText
        '
        Me.PlantSwitchText.AutoSize = True
        Me.PlantSwitchText.BackColor = System.Drawing.Color.Transparent
        Me.PlantSwitchText.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.PlantSwitchText.ForeColor = System.Drawing.Color.SlateBlue
        Me.PlantSwitchText.Location = New System.Drawing.Point(31, 24)
        Me.PlantSwitchText.Name = "PlantSwitchText"
        Me.PlantSwitchText.Size = New System.Drawing.Size(90, 21)
        Me.PlantSwitchText.TabIndex = 49
        Me.PlantSwitchText.Text = "种植已关闭"
        Me.Tips.SetToolTip(Me.PlantSwitchText, "当鼠标处于游戏内时，按下种植键即可种植选择的植物")
        '
        'SwitchintoIZE
        '
        Me.SwitchintoIZE.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SwitchintoIZE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SwitchintoIZE.Font = New System.Drawing.Font("微软雅黑", 9.75!)
        Me.SwitchintoIZE.Location = New System.Drawing.Point(292, 66)
        Me.SwitchintoIZE.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.SwitchintoIZE.Name = "SwitchintoIZE"
        Me.SwitchintoIZE.Size = New System.Drawing.Size(75, 28)
        Me.SwitchintoIZE.TabIndex = 37
        Me.SwitchintoIZE.Text = "IZE卡槽"
        Me.Tips.SetToolTip(Me.SwitchintoIZE, "将卡槽切换成标准IZE模式下的配置")
        Me.SwitchintoIZE.UseVisualStyleBackColor = False
        '
        'Fail
        '
        Me.Fail.Font = New System.Drawing.Font("微软雅黑", 10.0!)
        Me.Fail.ForeColor = System.Drawing.Color.Black
        Me.Fail.Location = New System.Drawing.Point(207, 23)
        Me.Fail.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Fail.Name = "Fail"
        Me.Fail.Size = New System.Drawing.Size(82, 41)
        Me.Fail.TabIndex = 34
        Me.Fail.Text = "直接失败"
        Me.Tips.SetToolTip(Me.Fail, "秒杀场上所有僵尸，把阳光数归零，并移除场上所有未拾取的阳光")
        Me.Fail.UseVisualStyleBackColor = True
        '
        'ManualCtrl
        '
        Me.ManualCtrl.AutoSize = True
        Me.ManualCtrl.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.ManualCtrl.ForeColor = System.Drawing.Color.Black
        Me.ManualCtrl.Location = New System.Drawing.Point(13, 81)
        Me.ManualCtrl.Name = "ManualCtrl"
        Me.ManualCtrl.Size = New System.Drawing.Size(178, 24)
        Me.ManualCtrl.TabIndex = 110
        Me.ManualCtrl.Text = "手动控制开启种植模式"
        Me.Tips.SetToolTip(Me.ManualCtrl, "有时，自动识别窗口种植可能会失效。开启此选项后，您需要手动点击""布阵""中的种植模式按钮来控制种植模式")
        Me.ManualCtrl.UseVisualStyleBackColor = True
        '
        'AllowPlants
        '
        Me.AllowPlants.AutoSize = True
        Me.AllowPlants.BackColor = System.Drawing.Color.Transparent
        Me.AllowPlants.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.AllowPlants.ForeColor = System.Drawing.Color.Black
        Me.AllowPlants.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.AllowPlants.Location = New System.Drawing.Point(14, 158)
        Me.AllowPlants.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.AllowPlants.Name = "AllowPlants"
        Me.AllowPlants.Size = New System.Drawing.Size(133, 24)
        Me.AllowPlants.TabIndex = 63
        Me.AllowPlants.Text = "允许卡槽种植物"
        Me.Tips.SetToolTip(Me.AllowPlants, "当卡槽为植物时，种下后不会变成僵尸")
        Me.AllowPlants.UseVisualStyleBackColor = False
        '
        'QLoad
        '
        Me.QLoad.BackColor = System.Drawing.Color.WhiteSmoke
        Me.QLoad.Cursor = System.Windows.Forms.Cursors.Default
        Me.QLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.QLoad.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.QLoad.ForeColor = System.Drawing.Color.Indigo
        Me.QLoad.Location = New System.Drawing.Point(88, 216)
        Me.QLoad.Name = "QLoad"
        Me.QLoad.Size = New System.Drawing.Size(65, 30)
        Me.QLoad.TabIndex = 135
        Me.QLoad.Text = "读档"
        Me.Tips.SetToolTip(Me.QLoad, "这是一个高概率崩溃的功能")
        Me.QLoad.UseVisualStyleBackColor = False
        '
        'Randomizer
        '
        Me.Randomizer.BackColor = System.Drawing.Color.Transparent
        Me.Randomizer.Font = New System.Drawing.Font("微软雅黑", 11.5!)
        Me.Randomizer.ForeColor = System.Drawing.Color.Black
        Me.Randomizer.Location = New System.Drawing.Point(8, 19)
        Me.Randomizer.Name = "Randomizer"
        Me.Randomizer.Size = New System.Drawing.Size(102, 38)
        Me.Randomizer.TabIndex = 105
        Me.Randomizer.Text = "随机关卡"
        Me.Tips.SetToolTip(Me.Randomizer, "由系统随机制作一个关卡，不保证有解！")
        Me.Randomizer.UseVisualStyleBackColor = False
        '
        'RandomEndless
        '
        Me.RandomEndless.AutoSize = True
        Me.RandomEndless.BackColor = System.Drawing.Color.Transparent
        Me.RandomEndless.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.RandomEndless.ForeColor = System.Drawing.Color.Black
        Me.RandomEndless.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.RandomEndless.Location = New System.Drawing.Point(122, 17)
        Me.RandomEndless.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.RandomEndless.Name = "RandomEndless"
        Me.RandomEndless.Size = New System.Drawing.Size(79, 24)
        Me.RandomEndless.TabIndex = 107
        Me.RandomEndless.Text = "随机IZE"
        Me.Tips.SetToolTip(Me.RandomEndless, "这是一个高概率崩溃的功能")
        Me.RandomEndless.UseVisualStyleBackColor = False
        '
        'SpeedUp
        '
        Me.SpeedUp.AutoSize = True
        Me.SpeedUp.BackColor = System.Drawing.Color.Transparent
        Me.SpeedUp.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.SpeedUp.ForeColor = System.Drawing.Color.Black
        Me.SpeedUp.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.SpeedUp.Location = New System.Drawing.Point(14, 185)
        Me.SpeedUp.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.SpeedUp.Name = "SpeedUp"
        Me.SpeedUp.Size = New System.Drawing.Size(73, 24)
        Me.SpeedUp.TabIndex = 51
        Me.SpeedUp.Text = "二倍速"
        Me.Tips.SetToolTip(Me.SpeedUp, "如遇倍速功能失效，请重新打开游戏")
        Me.SpeedUp.UseVisualStyleBackColor = False
        '
        'OpenSaveFold
        '
        Me.OpenSaveFold.Cursor = System.Windows.Forms.Cursors.Default
        Me.OpenSaveFold.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.OpenSaveFold.ForeColor = System.Drawing.Color.Black
        Me.OpenSaveFold.Location = New System.Drawing.Point(254, 143)
        Me.OpenSaveFold.Name = "OpenSaveFold"
        Me.OpenSaveFold.Size = New System.Drawing.Size(112, 35)
        Me.OpenSaveFold.TabIndex = 134
        Me.OpenSaveFold.Text = "打开存档目录"
        Me.Tips.SetToolTip(Me.OpenSaveFold, "如遇因存档错误导致关卡无法进入，请打开存档目录自行删除关卡存档")
        Me.OpenSaveFold.UseVisualStyleBackColor = True
        '
        'Clear
        '
        Me.Clear.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Clear.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Clear.ForeColor = System.Drawing.Color.Indigo
        Me.Clear.Location = New System.Drawing.Point(11, 24)
        Me.Clear.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(89, 39)
        Me.Clear.TabIndex = 35
        Me.Clear.Text = "清空草坪"
        Me.Clear.UseVisualStyleBackColor = False
        '
        'KillAll
        '
        Me.KillAll.BackColor = System.Drawing.Color.WhiteSmoke
        Me.KillAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KillAll.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.KillAll.ForeColor = System.Drawing.Color.Indigo
        Me.KillAll.Location = New System.Drawing.Point(109, 24)
        Me.KillAll.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.KillAll.Name = "KillAll"
        Me.KillAll.Size = New System.Drawing.Size(89, 39)
        Me.KillAll.TabIndex = 36
        Me.KillAll.Text = "秒杀僵尸"
        Me.KillAll.UseVisualStyleBackColor = False
        '
        'CreateCodeAndCopy
        '
        Me.CreateCodeAndCopy.BackColor = System.Drawing.Color.Indigo
        Me.CreateCodeAndCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CreateCodeAndCopy.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.CreateCodeAndCopy.ForeColor = System.Drawing.Color.White
        Me.CreateCodeAndCopy.Location = New System.Drawing.Point(422, 23)
        Me.CreateCodeAndCopy.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CreateCodeAndCopy.Name = "CreateCodeAndCopy"
        Me.CreateCodeAndCopy.Size = New System.Drawing.Size(118, 41)
        Me.CreateCodeAndCopy.TabIndex = 38
        Me.CreateCodeAndCopy.Text = "复制阵型代码"
        Me.CreateCodeAndCopy.UseVisualStyleBackColor = False
        '
        'CobNoCD
        '
        Me.CobNoCD.AutoSize = True
        Me.CobNoCD.BackColor = System.Drawing.Color.Transparent
        Me.CobNoCD.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.CobNoCD.ForeColor = System.Drawing.Color.Black
        Me.CobNoCD.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.CobNoCD.Location = New System.Drawing.Point(14, 104)
        Me.CobNoCD.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.CobNoCD.Name = "CobNoCD"
        Me.CobNoCD.Size = New System.Drawing.Size(118, 24)
        Me.CobNoCD.TabIndex = 65
        Me.CobNoCD.Text = "玉米炮无冷却"
        Me.CobNoCD.UseVisualStyleBackColor = False
        '
        'LockKernel
        '
        Me.LockKernel.AutoSize = True
        Me.LockKernel.BackColor = System.Drawing.Color.Transparent
        Me.LockKernel.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.LockKernel.ForeColor = System.Drawing.Color.Black
        Me.LockKernel.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.LockKernel.Location = New System.Drawing.Point(14, 50)
        Me.LockKernel.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.LockKernel.Name = "LockKernel"
        Me.LockKernel.Size = New System.Drawing.Size(103, 24)
        Me.LockKernel.TabIndex = 64
        Me.LockKernel.Text = "锁定玉米粒"
        Me.LockKernel.UseVisualStyleBackColor = False
        '
        'AutoColletct
        '
        Me.AutoColletct.AutoSize = True
        Me.AutoColletct.BackColor = System.Drawing.Color.Transparent
        Me.AutoColletct.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.AutoColletct.ForeColor = System.Drawing.Color.Black
        Me.AutoColletct.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.AutoColletct.Location = New System.Drawing.Point(14, 23)
        Me.AutoColletct.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.AutoColletct.Name = "AutoColletct"
        Me.AutoColletct.Size = New System.Drawing.Size(88, 24)
        Me.AutoColletct.TabIndex = 40
        Me.AutoColletct.Text = "自动收集"
        Me.AutoColletct.UseVisualStyleBackColor = False
        '
        'LockShovel
        '
        Me.LockShovel.AutoSize = True
        Me.LockShovel.BackColor = System.Drawing.Color.Transparent
        Me.LockShovel.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.LockShovel.ForeColor = System.Drawing.Color.Black
        Me.LockShovel.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.LockShovel.Location = New System.Drawing.Point(306, 32)
        Me.LockShovel.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.LockShovel.Name = "LockShovel"
        Me.LockShovel.Size = New System.Drawing.Size(93, 25)
        Me.LockShovel.TabIndex = 41
        Me.LockShovel.Text = "铲子锁定"
        Me.LockShovel.UseVisualStyleBackColor = False
        '
        'CodeState
        '
        Me.CodeState.AutoSize = True
        Me.CodeState.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Bold)
        Me.CodeState.Location = New System.Drawing.Point(74, 0)
        Me.CodeState.Name = "CodeState"
        Me.CodeState.Size = New System.Drawing.Size(0, 19)
        Me.CodeState.TabIndex = 42
        '
        'SunRefresher
        '
        Me.SunRefresher.Interval = 250
        '
        'Settings
        '
        Me.Settings.Controls.Add(Me.GroupBox1)
        Me.Settings.Controls.Add(Me.KeyingGB)
        Me.Settings.Controls.Add(Me.About)
        Me.Settings.Controls.Add(Me.FormingGB)
        Me.Settings.Controls.Add(Me.NormalizeGB)
        Me.Settings.Controls.Add(Me.ResetProgramme)
        Me.Settings.Location = New System.Drawing.Point(4, 36)
        Me.Settings.Margin = New System.Windows.Forms.Padding(4)
        Me.Settings.Name = "Settings"
        Me.Settings.Padding = New System.Windows.Forms.Padding(4)
        Me.Settings.Size = New System.Drawing.Size(571, 481)
        Me.Settings.TabIndex = 4
        Me.Settings.Text = " 设置"
        Me.Settings.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.UpdateInfoButton)
        Me.GroupBox1.Controls.Add(Me.VideoButton)
        Me.GroupBox1.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Indigo
        Me.GroupBox1.Location = New System.Drawing.Point(319, 185)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(241, 91)
        Me.GroupBox1.TabIndex = 121
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "打开"
        '
        'UpdateInfoButton
        '
        Me.UpdateInfoButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.UpdateInfoButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.UpdateInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateInfoButton.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.UpdateInfoButton.ForeColor = System.Drawing.Color.Indigo
        Me.UpdateInfoButton.Location = New System.Drawing.Point(127, 34)
        Me.UpdateInfoButton.Name = "UpdateInfoButton"
        Me.UpdateInfoButton.Size = New System.Drawing.Size(88, 33)
        Me.UpdateInfoButton.TabIndex = 122
        Me.UpdateInfoButton.Text = "更新日志"
        Me.UpdateInfoButton.UseVisualStyleBackColor = False
        '
        'VideoButton
        '
        Me.VideoButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.VideoButton.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.VideoButton.ForeColor = System.Drawing.Color.Black
        Me.VideoButton.Location = New System.Drawing.Point(23, 34)
        Me.VideoButton.Name = "VideoButton"
        Me.VideoButton.Size = New System.Drawing.Size(88, 33)
        Me.VideoButton.TabIndex = 121
        Me.VideoButton.Text = "使用说明"
        Me.VideoButton.UseVisualStyleBackColor = True
        '
        'KeyingGB
        '
        Me.KeyingGB.Controls.Add(Me.LabelSpeedUp)
        Me.KeyingGB.Controls.Add(Me.LabelChangeKeyPlant)
        Me.KeyingGB.Controls.Add(Me.ResetKeySet)
        Me.KeyingGB.Controls.Add(Me.PlantKeyEdit)
        Me.KeyingGB.Controls.Add(Me.SpeedUpKeyEdit)
        Me.KeyingGB.Controls.Add(Me.LabelOnce)
        Me.KeyingGB.Controls.Add(Me.ExchangeKeys)
        Me.KeyingGB.Controls.Add(Me.ShovelOnceKeyEdit)
        Me.KeyingGB.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.KeyingGB.ForeColor = System.Drawing.Color.Indigo
        Me.KeyingGB.Location = New System.Drawing.Point(319, 7)
        Me.KeyingGB.Name = "KeyingGB"
        Me.KeyingGB.Size = New System.Drawing.Size(241, 172)
        Me.KeyingGB.TabIndex = 120
        Me.KeyingGB.TabStop = False
        Me.KeyingGB.Text = "快捷键"
        '
        'LabelSpeedUp
        '
        Me.LabelSpeedUp.AutoSize = True
        Me.LabelSpeedUp.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.LabelSpeedUp.ForeColor = System.Drawing.Color.Indigo
        Me.LabelSpeedUp.Location = New System.Drawing.Point(39, 89)
        Me.LabelSpeedUp.Name = "LabelSpeedUp"
        Me.LabelSpeedUp.Size = New System.Drawing.Size(69, 20)
        Me.LabelSpeedUp.TabIndex = 115
        Me.LabelSpeedUp.Text = "倍速按键"
        '
        'LabelChangeKeyPlant
        '
        Me.LabelChangeKeyPlant.AutoSize = True
        Me.LabelChangeKeyPlant.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.LabelChangeKeyPlant.ForeColor = System.Drawing.Color.Indigo
        Me.LabelChangeKeyPlant.Location = New System.Drawing.Point(55, 22)
        Me.LabelChangeKeyPlant.Name = "LabelChangeKeyPlant"
        Me.LabelChangeKeyPlant.Size = New System.Drawing.Size(54, 20)
        Me.LabelChangeKeyPlant.TabIndex = 111
        Me.LabelChangeKeyPlant.Text = "种植键"
        '
        'ResetKeySet
        '
        Me.ResetKeySet.Cursor = System.Windows.Forms.Cursors.Default
        Me.ResetKeySet.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.ResetKeySet.ForeColor = System.Drawing.Color.Black
        Me.ResetKeySet.Location = New System.Drawing.Point(23, 123)
        Me.ResetKeySet.Name = "ResetKeySet"
        Me.ResetKeySet.Size = New System.Drawing.Size(88, 33)
        Me.ResetKeySet.TabIndex = 118
        Me.ResetKeySet.Text = "默认键位"
        Me.ResetKeySet.UseVisualStyleBackColor = True
        '
        'PlantKeyEdit
        '
        Me.PlantKeyEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PlantKeyEdit.Font = New System.Drawing.Font("微软雅黑", 9.75!)
        Me.PlantKeyEdit.FormattingEnabled = True
        Me.PlantKeyEdit.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "Q", "W", "E", "R", "T", "A", "S", "D", "F", "G", "Z", "X", "C", "V", "B", "Tab", "空格键"})
        Me.PlantKeyEdit.Location = New System.Drawing.Point(127, 18)
        Me.PlantKeyEdit.Name = "PlantKeyEdit"
        Me.PlantKeyEdit.Size = New System.Drawing.Size(88, 27)
        Me.PlantKeyEdit.TabIndex = 112
        '
        'SpeedUpKeyEdit
        '
        Me.SpeedUpKeyEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SpeedUpKeyEdit.Font = New System.Drawing.Font("微软雅黑", 9.75!)
        Me.SpeedUpKeyEdit.FormattingEnabled = True
        Me.SpeedUpKeyEdit.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "Q", "W", "E", "R", "T", "A", "S", "D", "F", "G", "Z", "X", "C", "V", "B", "Tab", "空格键"})
        Me.SpeedUpKeyEdit.Location = New System.Drawing.Point(127, 87)
        Me.SpeedUpKeyEdit.Name = "SpeedUpKeyEdit"
        Me.SpeedUpKeyEdit.Size = New System.Drawing.Size(88, 27)
        Me.SpeedUpKeyEdit.TabIndex = 116
        '
        'LabelOnce
        '
        Me.LabelOnce.AutoSize = True
        Me.LabelOnce.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.LabelOnce.ForeColor = System.Drawing.Color.Indigo
        Me.LabelOnce.Location = New System.Drawing.Point(25, 57)
        Me.LabelOnce.Name = "LabelOnce"
        Me.LabelOnce.Size = New System.Drawing.Size(84, 20)
        Me.LabelOnce.TabIndex = 113
        Me.LabelOnce.Text = "一次性铲子"
        '
        'ExchangeKeys
        '
        Me.ExchangeKeys.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ExchangeKeys.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExchangeKeys.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExchangeKeys.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.ExchangeKeys.ForeColor = System.Drawing.Color.Indigo
        Me.ExchangeKeys.Location = New System.Drawing.Point(127, 123)
        Me.ExchangeKeys.Name = "ExchangeKeys"
        Me.ExchangeKeys.Size = New System.Drawing.Size(88, 33)
        Me.ExchangeKeys.TabIndex = 117
        Me.ExchangeKeys.Text = "修改键位"
        Me.ExchangeKeys.UseVisualStyleBackColor = False
        '
        'ShovelOnceKeyEdit
        '
        Me.ShovelOnceKeyEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ShovelOnceKeyEdit.Font = New System.Drawing.Font("微软雅黑", 9.75!)
        Me.ShovelOnceKeyEdit.FormattingEnabled = True
        Me.ShovelOnceKeyEdit.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "Q", "W", "E", "R", "T", "A", "S", "D", "F", "G", "Z", "X", "C", "V", "B", "Tab", "空格键"})
        Me.ShovelOnceKeyEdit.Location = New System.Drawing.Point(127, 53)
        Me.ShovelOnceKeyEdit.Name = "ShovelOnceKeyEdit"
        Me.ShovelOnceKeyEdit.Size = New System.Drawing.Size(88, 27)
        Me.ShovelOnceKeyEdit.TabIndex = 114
        '
        'About
        '
        Me.About.Controls.Add(Me.Button1)
        Me.About.Controls.Add(Me.OpenSaveFold)
        Me.About.Controls.Add(Me.WinkleLogo)
        Me.About.Controls.Add(Me.TipsNumber)
        Me.About.Controls.Add(Me.LabelTips)
        Me.About.Controls.Add(Me.StatisticsInfo)
        Me.About.Controls.Add(Me.LabelVersion)
        Me.About.Controls.Add(Me.LabelWarn)
        Me.About.Controls.Add(Me.LabelWelcome)
        Me.About.Controls.Add(Me.AboutUs)
        Me.About.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Bold)
        Me.About.ForeColor = System.Drawing.Color.Indigo
        Me.About.Location = New System.Drawing.Point(10, 282)
        Me.About.Name = "About"
        Me.About.Size = New System.Drawing.Size(550, 194)
        Me.About.TabIndex = 119
        Me.About.TabStop = False
        Me.About.Text = "关于"
        '
        'WinkleLogo
        '
        Me.WinkleLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.WinkleLogo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WinkleLogo.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources.WinkleLogo
        Me.WinkleLogo.Location = New System.Drawing.Point(487, 146)
        Me.WinkleLogo.Name = "WinkleLogo"
        Me.WinkleLogo.Size = New System.Drawing.Size(42, 30)
        Me.WinkleLogo.TabIndex = 132
        Me.WinkleLogo.TabStop = False
        '
        'TipsNumber
        '
        Me.TipsNumber.AutoSize = True
        Me.TipsNumber.Font = New System.Drawing.Font("微软雅黑", 9.75!)
        Me.TipsNumber.ForeColor = System.Drawing.Color.Black
        Me.TipsNumber.Location = New System.Drawing.Point(13, 89)
        Me.TipsNumber.Name = "TipsNumber"
        Me.TipsNumber.Size = New System.Drawing.Size(131, 19)
        Me.TipsNumber.TabIndex = 131
        Me.TipsNumber.Text = "LabelNumbers Here"
        '
        'LabelTips
        '
        Me.LabelTips.AutoSize = True
        Me.LabelTips.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.LabelTips.ForeColor = System.Drawing.Color.Indigo
        Me.LabelTips.Location = New System.Drawing.Point(13, 64)
        Me.LabelTips.Name = "LabelTips"
        Me.LabelTips.Size = New System.Drawing.Size(121, 21)
        Me.LabelTips.TabIndex = 125
        Me.LabelTips.Text = "LabelTips Here"
        '
        'StatisticsInfo
        '
        Me.StatisticsInfo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.StatisticsInfo.Cursor = System.Windows.Forms.Cursors.Default
        Me.StatisticsInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StatisticsInfo.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.StatisticsInfo.ForeColor = System.Drawing.Color.Indigo
        Me.StatisticsInfo.Location = New System.Drawing.Point(379, 144)
        Me.StatisticsInfo.Name = "StatisticsInfo"
        Me.StatisticsInfo.Size = New System.Drawing.Size(88, 33)
        Me.StatisticsInfo.TabIndex = 130
        Me.StatisticsInfo.Text = "统计数据"
        Me.StatisticsInfo.UseVisualStyleBackColor = False
        '
        'LabelVersion
        '
        Me.LabelVersion.AutoSize = True
        Me.LabelVersion.Font = New System.Drawing.Font("微软雅黑", 9.75!)
        Me.LabelVersion.ForeColor = System.Drawing.Color.Indigo
        Me.LabelVersion.Location = New System.Drawing.Point(82, 133)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(86, 19)
        Me.LabelVersion.TabIndex = 128
        Me.LabelVersion.Text = "版本号  2.2.1"
        '
        'LabelWarn
        '
        Me.LabelWarn.AutoSize = True
        Me.LabelWarn.Font = New System.Drawing.Font("微软雅黑", 9.75!)
        Me.LabelWarn.ForeColor = System.Drawing.Color.Black
        Me.LabelWarn.Location = New System.Drawing.Point(13, 27)
        Me.LabelWarn.Name = "LabelWarn"
        Me.LabelWarn.Size = New System.Drawing.Size(394, 19)
        Me.LabelWarn.TabIndex = 124
        Me.LabelWarn.Text = "使用方法：选择要种植的植物，当鼠标处于游戏内时，按下Z键种植"
        '
        'LabelWelcome
        '
        Me.LabelWelcome.AutoSize = True
        Me.LabelWelcome.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.LabelWelcome.ForeColor = System.Drawing.Color.Black
        Me.LabelWelcome.Location = New System.Drawing.Point(13, 132)
        Me.LabelWelcome.Name = "LabelWelcome"
        Me.LabelWelcome.Size = New System.Drawing.Size(69, 20)
        Me.LabelWelcome.TabIndex = 126
        Me.LabelWelcome.Text = "欢迎使用"
        '
        'AboutUs
        '
        Me.AboutUs.AutoSize = True
        Me.AboutUs.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold)
        Me.AboutUs.ForeColor = System.Drawing.Color.Indigo
        Me.AboutUs.Location = New System.Drawing.Point(13, 157)
        Me.AboutUs.Name = "AboutUs"
        Me.AboutUs.Size = New System.Drawing.Size(202, 22)
        Me.AboutUs.TabIndex = 127
        Me.AboutUs.Text = "我是僵尸布阵器（第二代）"
        '
        'FormingGB
        '
        Me.FormingGB.Controls.Add(Me.AutoFillPortalPos)
        Me.FormingGB.Controls.Add(Me.IZECardOnly)
        Me.FormingGB.Controls.Add(Me.RealPlants)
        Me.FormingGB.Controls.Add(Me.ManualCtrl)
        Me.FormingGB.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Bold)
        Me.FormingGB.ForeColor = System.Drawing.Color.Indigo
        Me.FormingGB.Location = New System.Drawing.Point(10, 134)
        Me.FormingGB.Name = "FormingGB"
        Me.FormingGB.Size = New System.Drawing.Size(297, 143)
        Me.FormingGB.TabIndex = 107
        Me.FormingGB.TabStop = False
        Me.FormingGB.Text = " 布阵"
        '
        'AutoFillPortalPos
        '
        Me.AutoFillPortalPos.AutoSize = True
        Me.AutoFillPortalPos.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.AutoFillPortalPos.ForeColor = System.Drawing.Color.Black
        Me.AutoFillPortalPos.Location = New System.Drawing.Point(13, 110)
        Me.AutoFillPortalPos.Name = "AutoFillPortalPos"
        Me.AutoFillPortalPos.Size = New System.Drawing.Size(253, 24)
        Me.AutoFillPortalPos.TabIndex = 122
        Me.AutoFillPortalPos.Text = "生成传送门后自动更新传送门坐标"
        Me.AutoFillPortalPos.UseVisualStyleBackColor = True
        '
        'IZECardOnly
        '
        Me.IZECardOnly.AutoSize = True
        Me.IZECardOnly.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.IZECardOnly.ForeColor = System.Drawing.Color.Black
        Me.IZECardOnly.Location = New System.Drawing.Point(13, 52)
        Me.IZECardOnly.Name = "IZECardOnly"
        Me.IZECardOnly.Size = New System.Drawing.Size(124, 24)
        Me.IZECardOnly.TabIndex = 109
        Me.IZECardOnly.Text = "只显示IZE植物"
        Me.IZECardOnly.UseVisualStyleBackColor = True
        '
        'RealPlants
        '
        Me.RealPlants.AutoSize = True
        Me.RealPlants.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.RealPlants.ForeColor = System.Drawing.Color.Black
        Me.RealPlants.Location = New System.Drawing.Point(13, 23)
        Me.RealPlants.Name = "RealPlants"
        Me.RealPlants.Size = New System.Drawing.Size(133, 24)
        Me.RealPlants.TabIndex = 108
        Me.RealPlants.Text = "种植会动的植物"
        Me.RealPlants.UseVisualStyleBackColor = True
        '
        'NormalizeGB
        '
        Me.NormalizeGB.Controls.Add(Me.SpeedIndexText)
        Me.NormalizeGB.Controls.Add(Me.SpeedIndex)
        Me.NormalizeGB.Controls.Add(Me.SpeedIndexLabel)
        Me.NormalizeGB.Controls.Add(Me.AutoPaste)
        Me.NormalizeGB.Controls.Add(Me.MagnetTimerSwitch)
        Me.NormalizeGB.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Bold)
        Me.NormalizeGB.ForeColor = System.Drawing.Color.Indigo
        Me.NormalizeGB.Location = New System.Drawing.Point(10, 7)
        Me.NormalizeGB.Name = "NormalizeGB"
        Me.NormalizeGB.Size = New System.Drawing.Size(297, 121)
        Me.NormalizeGB.TabIndex = 102
        Me.NormalizeGB.TabStop = False
        Me.NormalizeGB.Text = "常规"
        '
        'SpeedIndexText
        '
        Me.SpeedIndexText.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SpeedIndexText.AutoSize = True
        Me.SpeedIndexText.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.SpeedIndexText.Location = New System.Drawing.Point(82, 85)
        Me.SpeedIndexText.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.SpeedIndexText.Name = "SpeedIndexText"
        Me.SpeedIndexText.Size = New System.Drawing.Size(29, 22)
        Me.SpeedIndexText.TabIndex = 119
        Me.SpeedIndexText.Text = "2x"
        '
        'SpeedIndex
        '
        Me.SpeedIndex.AutoSize = False
        Me.SpeedIndex.BackColor = System.Drawing.Color.White
        Me.SpeedIndex.LargeChange = 1
        Me.SpeedIndex.Location = New System.Drawing.Point(123, 84)
        Me.SpeedIndex.Maximum = 5
        Me.SpeedIndex.Name = "SpeedIndex"
        Me.SpeedIndex.Size = New System.Drawing.Size(159, 25)
        Me.SpeedIndex.TabIndex = 117
        '
        'SpeedIndexLabel
        '
        Me.SpeedIndexLabel.AutoSize = True
        Me.SpeedIndexLabel.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.SpeedIndexLabel.ForeColor = System.Drawing.Color.Indigo
        Me.SpeedIndexLabel.Location = New System.Drawing.Point(10, 86)
        Me.SpeedIndexLabel.Name = "SpeedIndexLabel"
        Me.SpeedIndexLabel.Size = New System.Drawing.Size(69, 20)
        Me.SpeedIndexLabel.TabIndex = 116
        Me.SpeedIndexLabel.Text = "倍速倍率"
        '
        'AutoPaste
        '
        Me.AutoPaste.AutoSize = True
        Me.AutoPaste.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.AutoPaste.ForeColor = System.Drawing.Color.Black
        Me.AutoPaste.Location = New System.Drawing.Point(13, 56)
        Me.AutoPaste.Name = "AutoPaste"
        Me.AutoPaste.Size = New System.Drawing.Size(253, 24)
        Me.AutoPaste.TabIndex = 104
        Me.AutoPaste.Text = "复制阵型代码后自动粘贴到输入框"
        Me.AutoPaste.UseVisualStyleBackColor = True
        '
        'MagnetTimerSwitch
        '
        Me.MagnetTimerSwitch.AutoSize = True
        Me.MagnetTimerSwitch.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.MagnetTimerSwitch.ForeColor = System.Drawing.Color.Black
        Me.MagnetTimerSwitch.Location = New System.Drawing.Point(13, 26)
        Me.MagnetTimerSwitch.Name = "MagnetTimerSwitch"
        Me.MagnetTimerSwitch.Size = New System.Drawing.Size(133, 24)
        Me.MagnetTimerSwitch.TabIndex = 103
        Me.MagnetTimerSwitch.Text = "关闭磁铁倒计时"
        Me.MagnetTimerSwitch.UseVisualStyleBackColor = True
        '
        'ResetProgramme
        '
        Me.ResetProgramme.Cursor = System.Windows.Forms.Cursors.Default
        Me.ResetProgramme.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.ResetProgramme.ForeColor = System.Drawing.Color.Black
        Me.ResetProgramme.Location = New System.Drawing.Point(19, 494)
        Me.ResetProgramme.Name = "ResetProgramme"
        Me.ResetProgramme.Size = New System.Drawing.Size(109, 32)
        Me.ResetProgramme.TabIndex = 3
        Me.ResetProgramme.Text = "清空注册表"
        Me.ResetProgramme.UseVisualStyleBackColor = True
        '
        'Levels
        '
        Me.Levels.Controls.Add(Me.GroupBox4)
        Me.Levels.Controls.Add(Me.GroupBox3)
        Me.Levels.Controls.Add(Me.GBLevelCollection)
        Me.Levels.Location = New System.Drawing.Point(4, 36)
        Me.Levels.Margin = New System.Windows.Forms.Padding(0)
        Me.Levels.Name = "Levels"
        Me.Levels.Size = New System.Drawing.Size(571, 481)
        Me.Levels.TabIndex = 3
        Me.Levels.Text = " 关卡"
        Me.Levels.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RandIZEScore)
        Me.GroupBox4.Controls.Add(Me.RandomEndless)
        Me.GroupBox4.Controls.Add(Me.Randomizer)
        Me.GroupBox4.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Indigo
        Me.GroupBox4.Location = New System.Drawing.Point(358, 5)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(202, 65)
        Me.GroupBox4.TabIndex = 123
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "随机关卡"
        '
        'RandIZEScore
        '
        Me.RandIZEScore.AutoSize = True
        Me.RandIZEScore.Font = New System.Drawing.Font("微软雅黑", 10.5!)
        Me.RandIZEScore.Location = New System.Drawing.Point(118, 36)
        Me.RandIZEScore.Name = "RandIZEScore"
        Me.RandIZEScore.Size = New System.Drawing.Size(41, 20)
        Me.RandIZEScore.TabIndex = 108
        Me.RandIZEScore.Text = "得分 "
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DownloadWSLevel)
        Me.GroupBox3.Controls.Add(Me.WSLevelID)
        Me.GroupBox3.Controls.Add(Me.OpenWS)
        Me.GroupBox3.Controls.Add(Me.LabelLevelWSID)
        Me.GroupBox3.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Indigo
        Me.GroupBox3.Location = New System.Drawing.Point(10, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(342, 65)
        Me.GroupBox3.TabIndex = 122
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "创意工坊"
        '
        'DownloadWSLevel
        '
        Me.DownloadWSLevel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DownloadWSLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DownloadWSLevel.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.DownloadWSLevel.ForeColor = System.Drawing.Color.Indigo
        Me.DownloadWSLevel.Location = New System.Drawing.Point(117, 20)
        Me.DownloadWSLevel.Name = "DownloadWSLevel"
        Me.DownloadWSLevel.Size = New System.Drawing.Size(100, 36)
        Me.DownloadWSLevel.TabIndex = 102
        Me.DownloadWSLevel.Text = "获取关卡"
        Me.DownloadWSLevel.UseVisualStyleBackColor = False
        '
        'WSLevelID
        '
        Me.WSLevelID.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.WSLevelID.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.WSLevelID.Location = New System.Drawing.Point(41, 25)
        Me.WSLevelID.MaxLength = 5
        Me.WSLevelID.Name = "WSLevelID"
        Me.WSLevelID.Size = New System.Drawing.Size(63, 27)
        Me.WSLevelID.TabIndex = 102
        '
        'OpenWS
        '
        Me.OpenWS.BackColor = System.Drawing.Color.Transparent
        Me.OpenWS.Font = New System.Drawing.Font("微软雅黑", 11.5!)
        Me.OpenWS.ForeColor = System.Drawing.Color.Black
        Me.OpenWS.Location = New System.Drawing.Point(231, 19)
        Me.OpenWS.Name = "OpenWS"
        Me.OpenWS.Size = New System.Drawing.Size(102, 38)
        Me.OpenWS.TabIndex = 103
        Me.OpenWS.Text = "创意工坊"
        Me.OpenWS.UseVisualStyleBackColor = False
        '
        'LabelLevelWSID
        '
        Me.LabelLevelWSID.AutoSize = True
        Me.LabelLevelWSID.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.LabelLevelWSID.Location = New System.Drawing.Point(10, 27)
        Me.LabelLevelWSID.Name = "LabelLevelWSID"
        Me.LabelLevelWSID.Size = New System.Drawing.Size(27, 21)
        Me.LabelLevelWSID.TabIndex = 104
        Me.LabelLevelWSID.Text = "ID"
        '
        'GBLevelCollection
        '
        Me.GBLevelCollection.Controls.Add(Me.CopyMyCode)
        Me.GBLevelCollection.Controls.Add(Me.LevelCollectionListBox)
        Me.GBLevelCollection.Controls.Add(Me.LevelStateinInformation)
        Me.GBLevelCollection.Controls.Add(Me.LevelListView)
        Me.GBLevelCollection.Controls.Add(Me.CopyYourLevelInfo)
        Me.GBLevelCollection.Controls.Add(Me.SaveYourLevel)
        Me.GBLevelCollection.Controls.Add(Me.YourLevelCode)
        Me.GBLevelCollection.Controls.Add(Me.ResetYourLevel_ConfirmT)
        Me.GBLevelCollection.Controls.Add(Me.LabelLevelCodeinInformation)
        Me.GBLevelCollection.Controls.Add(Me.ResetYourLevel_ConfirmF)
        Me.GBLevelCollection.Controls.Add(Me.YourLevelDescription)
        Me.GBLevelCollection.Controls.Add(Me.ResetYourLevel)
        Me.GBLevelCollection.Controls.Add(Me.CBLevelDifficulty)
        Me.GBLevelCollection.Controls.Add(Me.GenerateThisLevel)
        Me.GBLevelCollection.Controls.Add(Me.LabelLevelDescription)
        Me.GBLevelCollection.Controls.Add(Me.LabelLevelName)
        Me.GBLevelCollection.Controls.Add(Me.LabelDifficulty)
        Me.GBLevelCollection.Controls.Add(Me.YourLevelName)
        Me.GBLevelCollection.Controls.Add(Me.LabelLevelDesigner)
        Me.GBLevelCollection.Controls.Add(Me.YourName)
        Me.GBLevelCollection.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GBLevelCollection.ForeColor = System.Drawing.Color.Indigo
        Me.GBLevelCollection.Location = New System.Drawing.Point(10, 72)
        Me.GBLevelCollection.Name = "GBLevelCollection"
        Me.GBLevelCollection.Size = New System.Drawing.Size(550, 404)
        Me.GBLevelCollection.TabIndex = 81
        Me.GBLevelCollection.TabStop = False
        Me.GBLevelCollection.Text = "预设关卡"
        '
        'CopyMyCode
        '
        Me.CopyMyCode.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources.Copy
        Me.CopyMyCode.Location = New System.Drawing.Point(508, 322)
        Me.CopyMyCode.Name = "CopyMyCode"
        Me.CopyMyCode.Size = New System.Drawing.Size(29, 29)
        Me.CopyMyCode.TabIndex = 95
        Me.CopyMyCode.UseVisualStyleBackColor = True
        '
        'LevelCollectionListBox
        '
        Me.LevelCollectionListBox.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.LevelCollectionListBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.LevelCollectionListBox.FormattingEnabled = True
        Me.LevelCollectionListBox.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.LevelCollectionListBox.ItemHeight = 20
        Me.LevelCollectionListBox.Items.AddRange(New Object() {"萌新友好", "雪线精选集", "控磁大师", "残局", "植物的奇妙冒险", "高负载阵型", "保护传送门", "比赛用图", "IZE珍珑", "自定义关卡"})
        Me.LevelCollectionListBox.Location = New System.Drawing.Point(6, 23)
        Me.LevelCollectionListBox.Name = "LevelCollectionListBox"
        Me.LevelCollectionListBox.Size = New System.Drawing.Size(151, 184)
        Me.LevelCollectionListBox.TabIndex = 82
        '
        'LevelStateinInformation
        '
        Me.LevelStateinInformation.AutoSize = True
        Me.LevelStateinInformation.Font = New System.Drawing.Font("微软雅黑", 11.0!, System.Drawing.FontStyle.Bold)
        Me.LevelStateinInformation.Location = New System.Drawing.Point(10, 370)
        Me.LevelStateinInformation.Name = "LevelStateinInformation"
        Me.LevelStateinInformation.Size = New System.Drawing.Size(0, 19)
        Me.LevelStateinInformation.TabIndex = 60
        '
        'LevelListView
        '
        Me.LevelListView.Alignment = System.Windows.Forms.ListViewAlignment.Left
        Me.LevelListView.AllowColumnReorder = True
        Me.LevelListView.AutoArrange = False
        Me.LevelListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnLevelIndex, Me.ColumnLevelName, Me.ColumnLevelDesigner, Me.ColumnLevelDifficulty})
        Me.LevelListView.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.LevelListView.FullRowSelect = True
        Me.LevelListView.GridLines = True
        Me.LevelListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.LevelListView.HideSelection = False
        Me.LevelListView.LabelWrap = False
        Me.LevelListView.Location = New System.Drawing.Point(163, 23)
        Me.LevelListView.MultiSelect = False
        Me.LevelListView.Name = "LevelListView"
        Me.LevelListView.ShowGroups = False
        Me.LevelListView.Size = New System.Drawing.Size(380, 184)
        Me.LevelListView.TabIndex = 83
        Me.LevelListView.UseCompatibleStateImageBehavior = False
        Me.LevelListView.View = System.Windows.Forms.View.Details
        '
        'ColumnLevelIndex
        '
        Me.ColumnLevelIndex.Text = "序号"
        Me.ColumnLevelIndex.Width = 45
        '
        'ColumnLevelName
        '
        Me.ColumnLevelName.Text = "关卡名"
        Me.ColumnLevelName.Width = 147
        '
        'ColumnLevelDesigner
        '
        Me.ColumnLevelDesigner.Text = "作者"
        Me.ColumnLevelDesigner.Width = 109
        '
        'ColumnLevelDifficulty
        '
        Me.ColumnLevelDifficulty.Text = "难度"
        Me.ColumnLevelDifficulty.Width = 49
        '
        'CopyYourLevelInfo
        '
        Me.CopyYourLevelInfo.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.CopyYourLevelInfo.ForeColor = System.Drawing.Color.Black
        Me.CopyYourLevelInfo.Location = New System.Drawing.Point(306, 360)
        Me.CopyYourLevelInfo.Name = "CopyYourLevelInfo"
        Me.CopyYourLevelInfo.Size = New System.Drawing.Size(110, 36)
        Me.CopyYourLevelInfo.TabIndex = 101
        Me.CopyYourLevelInfo.Text = "复制关卡信息"
        Me.CopyYourLevelInfo.UseVisualStyleBackColor = True
        '
        'SaveYourLevel
        '
        Me.SaveYourLevel.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.SaveYourLevel.ForeColor = System.Drawing.Color.Black
        Me.SaveYourLevel.Location = New System.Drawing.Point(101, 360)
        Me.SaveYourLevel.Name = "SaveYourLevel"
        Me.SaveYourLevel.Size = New System.Drawing.Size(92, 36)
        Me.SaveYourLevel.TabIndex = 96
        Me.SaveYourLevel.Text = "保存"
        Me.SaveYourLevel.UseVisualStyleBackColor = True
        '
        'YourLevelCode
        '
        Me.YourLevelCode.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.YourLevelCode.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.YourLevelCode.Location = New System.Drawing.Point(97, 323)
        Me.YourLevelCode.MaxLength = 2000
        Me.YourLevelCode.Name = "YourLevelCode"
        Me.YourLevelCode.Size = New System.Drawing.Size(411, 27)
        Me.YourLevelCode.TabIndex = 94
        '
        'ResetYourLevel_ConfirmT
        '
        Me.ResetYourLevel_ConfirmT.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.ResetYourLevel_ConfirmT.ForeColor = System.Drawing.Color.Black
        Me.ResetYourLevel_ConfirmT.Location = New System.Drawing.Point(202, 360)
        Me.ResetYourLevel_ConfirmT.Name = "ResetYourLevel_ConfirmT"
        Me.ResetYourLevel_ConfirmT.Size = New System.Drawing.Size(48, 36)
        Me.ResetYourLevel_ConfirmT.TabIndex = 98
        Me.ResetYourLevel_ConfirmT.Text = "删除"
        Me.ResetYourLevel_ConfirmT.UseVisualStyleBackColor = True
        Me.ResetYourLevel_ConfirmT.Visible = False
        '
        'LabelLevelCodeinInformation
        '
        Me.LabelLevelCodeinInformation.AutoSize = True
        Me.LabelLevelCodeinInformation.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.LabelLevelCodeinInformation.Location = New System.Drawing.Point(10, 324)
        Me.LabelLevelCodeinInformation.Name = "LabelLevelCodeinInformation"
        Me.LabelLevelCodeinInformation.Size = New System.Drawing.Size(74, 21)
        Me.LabelLevelCodeinInformation.TabIndex = 93
        Me.LabelLevelCodeinInformation.Text = "关卡代码"
        '
        'ResetYourLevel_ConfirmF
        '
        Me.ResetYourLevel_ConfirmF.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.ResetYourLevel_ConfirmF.ForeColor = System.Drawing.Color.Black
        Me.ResetYourLevel_ConfirmF.Location = New System.Drawing.Point(249, 360)
        Me.ResetYourLevel_ConfirmF.Name = "ResetYourLevel_ConfirmF"
        Me.ResetYourLevel_ConfirmF.Size = New System.Drawing.Size(48, 36)
        Me.ResetYourLevel_ConfirmF.TabIndex = 99
        Me.ResetYourLevel_ConfirmF.Text = "取消"
        Me.ResetYourLevel_ConfirmF.UseVisualStyleBackColor = True
        Me.ResetYourLevel_ConfirmF.Visible = False
        '
        'YourLevelDescription
        '
        Me.YourLevelDescription.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.YourLevelDescription.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.YourLevelDescription.Location = New System.Drawing.Point(97, 256)
        Me.YourLevelDescription.MaxLength = 2000
        Me.YourLevelDescription.Multiline = True
        Me.YourLevelDescription.Name = "YourLevelDescription"
        Me.YourLevelDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.YourLevelDescription.Size = New System.Drawing.Size(439, 55)
        Me.YourLevelDescription.TabIndex = 92
        '
        'ResetYourLevel
        '
        Me.ResetYourLevel.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.ResetYourLevel.ForeColor = System.Drawing.Color.Black
        Me.ResetYourLevel.Location = New System.Drawing.Point(203, 360)
        Me.ResetYourLevel.Name = "ResetYourLevel"
        Me.ResetYourLevel.Size = New System.Drawing.Size(93, 36)
        Me.ResetYourLevel.TabIndex = 97
        Me.ResetYourLevel.Text = "删除"
        Me.ResetYourLevel.UseVisualStyleBackColor = True
        '
        'CBLevelDifficulty
        '
        Me.CBLevelDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBLevelDifficulty.Font = New System.Drawing.Font("微软雅黑", 9.75!)
        Me.CBLevelDifficulty.FormattingEnabled = True
        Me.CBLevelDifficulty.Items.AddRange(New Object() {"简单 1", "简单 2", "普通 3", "普通 4", "普通 5", "困难 6", "困难 7", "困难 8", "极难 9", "极难 10", "极难 10+"})
        Me.CBLevelDifficulty.Location = New System.Drawing.Point(442, 218)
        Me.CBLevelDifficulty.Name = "CBLevelDifficulty"
        Me.CBLevelDifficulty.Size = New System.Drawing.Size(94, 27)
        Me.CBLevelDifficulty.TabIndex = 90
        '
        'GenerateThisLevel
        '
        Me.GenerateThisLevel.BackColor = System.Drawing.Color.Indigo
        Me.GenerateThisLevel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GenerateThisLevel.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.GenerateThisLevel.ForeColor = System.Drawing.Color.White
        Me.GenerateThisLevel.Location = New System.Drawing.Point(426, 360)
        Me.GenerateThisLevel.Name = "GenerateThisLevel"
        Me.GenerateThisLevel.Size = New System.Drawing.Size(110, 36)
        Me.GenerateThisLevel.TabIndex = 100
        Me.GenerateThisLevel.Text = "生成关卡"
        Me.GenerateThisLevel.UseVisualStyleBackColor = False
        '
        'LabelLevelDescription
        '
        Me.LabelLevelDescription.AutoSize = True
        Me.LabelLevelDescription.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.LabelLevelDescription.Location = New System.Drawing.Point(10, 255)
        Me.LabelLevelDescription.Name = "LabelLevelDescription"
        Me.LabelLevelDescription.Size = New System.Drawing.Size(74, 21)
        Me.LabelLevelDescription.TabIndex = 91
        Me.LabelLevelDescription.Text = "关卡描述"
        '
        'LabelLevelName
        '
        Me.LabelLevelName.AutoSize = True
        Me.LabelLevelName.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.LabelLevelName.Location = New System.Drawing.Point(10, 220)
        Me.LabelLevelName.Name = "LabelLevelName"
        Me.LabelLevelName.Size = New System.Drawing.Size(58, 21)
        Me.LabelLevelName.TabIndex = 85
        Me.LabelLevelName.Text = "关卡名"
        '
        'LabelDifficulty
        '
        Me.LabelDifficulty.AutoSize = True
        Me.LabelDifficulty.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.LabelDifficulty.Location = New System.Drawing.Point(391, 220)
        Me.LabelDifficulty.Name = "LabelDifficulty"
        Me.LabelDifficulty.Size = New System.Drawing.Size(42, 21)
        Me.LabelDifficulty.TabIndex = 89
        Me.LabelDifficulty.Text = "难度"
        '
        'YourLevelName
        '
        Me.YourLevelName.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.YourLevelName.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.YourLevelName.Location = New System.Drawing.Point(77, 218)
        Me.YourLevelName.MaxLength = 100
        Me.YourLevelName.Name = "YourLevelName"
        Me.YourLevelName.Size = New System.Drawing.Size(146, 27)
        Me.YourLevelName.TabIndex = 86
        '
        'LabelLevelDesigner
        '
        Me.LabelLevelDesigner.AutoSize = True
        Me.LabelLevelDesigner.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.LabelLevelDesigner.Location = New System.Drawing.Point(236, 220)
        Me.LabelLevelDesigner.Name = "LabelLevelDesigner"
        Me.LabelLevelDesigner.Size = New System.Drawing.Size(42, 21)
        Me.LabelLevelDesigner.TabIndex = 87
        Me.LabelLevelDesigner.Text = "作者"
        '
        'YourName
        '
        Me.YourName.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.YourName.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.YourName.Location = New System.Drawing.Point(286, 218)
        Me.YourName.MaxLength = 100
        Me.YourName.Name = "YourName"
        Me.YourName.Size = New System.Drawing.Size(93, 27)
        Me.YourName.TabIndex = 88
        '
        'Design
        '
        Me.Design.BackColor = System.Drawing.Color.White
        Me.Design.Controls.Add(Me.PlantsTransform)
        Me.Design.Controls.Add(Me.PortalDesign)
        Me.Design.Controls.Add(Me.PlantMode)
        Me.Design.Controls.Add(Me.ChoosePlant)
        Me.Design.Controls.Add(Me.Selected)
        Me.Design.Controls.Add(Me.Card49)
        Me.Design.Controls.Add(Me.Card50)
        Me.Design.Controls.Add(Me.Card51)
        Me.Design.Controls.Add(Me.Card52)
        Me.Design.Controls.Add(Me.Card53)
        Me.Design.Controls.Add(Me.Card54)
        Me.Design.Controls.Add(Me.Card55)
        Me.Design.Controls.Add(Me.Card56)
        Me.Design.Controls.Add(Me.Card41)
        Me.Design.Controls.Add(Me.Card42)
        Me.Design.Controls.Add(Me.Card43)
        Me.Design.Controls.Add(Me.Card44)
        Me.Design.Controls.Add(Me.Card45)
        Me.Design.Controls.Add(Me.Card46)
        Me.Design.Controls.Add(Me.Card47)
        Me.Design.Controls.Add(Me.Card48)
        Me.Design.Controls.Add(Me.Card33)
        Me.Design.Controls.Add(Me.Card34)
        Me.Design.Controls.Add(Me.Card35)
        Me.Design.Controls.Add(Me.Card36)
        Me.Design.Controls.Add(Me.Card37)
        Me.Design.Controls.Add(Me.Card38)
        Me.Design.Controls.Add(Me.Card39)
        Me.Design.Controls.Add(Me.Card40)
        Me.Design.Controls.Add(Me.Card25)
        Me.Design.Controls.Add(Me.Card26)
        Me.Design.Controls.Add(Me.Card27)
        Me.Design.Controls.Add(Me.Card28)
        Me.Design.Controls.Add(Me.Card29)
        Me.Design.Controls.Add(Me.Card30)
        Me.Design.Controls.Add(Me.Card31)
        Me.Design.Controls.Add(Me.Card32)
        Me.Design.Controls.Add(Me.Card17)
        Me.Design.Controls.Add(Me.Card18)
        Me.Design.Controls.Add(Me.Card19)
        Me.Design.Controls.Add(Me.Card20)
        Me.Design.Controls.Add(Me.Card21)
        Me.Design.Controls.Add(Me.Card22)
        Me.Design.Controls.Add(Me.Card23)
        Me.Design.Controls.Add(Me.Card24)
        Me.Design.Controls.Add(Me.Card9)
        Me.Design.Controls.Add(Me.Card10)
        Me.Design.Controls.Add(Me.Card11)
        Me.Design.Controls.Add(Me.Card12)
        Me.Design.Controls.Add(Me.Card13)
        Me.Design.Controls.Add(Me.Card14)
        Me.Design.Controls.Add(Me.Card15)
        Me.Design.Controls.Add(Me.Card16)
        Me.Design.Controls.Add(Me.Card1)
        Me.Design.Controls.Add(Me.Card2)
        Me.Design.Controls.Add(Me.Card3)
        Me.Design.Controls.Add(Me.Card4)
        Me.Design.Controls.Add(Me.Card5)
        Me.Design.Controls.Add(Me.Card6)
        Me.Design.Controls.Add(Me.Card7)
        Me.Design.Controls.Add(Me.Card8)
        Me.Design.Location = New System.Drawing.Point(4, 36)
        Me.Design.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Design.Name = "Design"
        Me.Design.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Design.Size = New System.Drawing.Size(571, 481)
        Me.Design.TabIndex = 2
        Me.Design.Text = " 布阵"
        '
        'PlantsTransform
        '
        Me.PlantsTransform.Controls.Add(Me.PlantXY)
        Me.PlantsTransform.Controls.Add(Me.PlantY)
        Me.PlantsTransform.Controls.Add(Me.PlantX)
        Me.PlantsTransform.Controls.Add(Me.Label2)
        Me.PlantsTransform.Controls.Add(Me.LabelCol)
        Me.PlantsTransform.Controls.Add(Me.LabelRow)
        Me.PlantsTransform.Controls.Add(Me.SwCol2)
        Me.PlantsTransform.Controls.Add(Me.SwCol1)
        Me.PlantsTransform.Controls.Add(Me.SwRow2)
        Me.PlantsTransform.Controls.Add(Me.SwRow1)
        Me.PlantsTransform.Controls.Add(Me.SwitchCol)
        Me.PlantsTransform.Controls.Add(Me.SwitchRow)
        Me.PlantsTransform.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.PlantsTransform.ForeColor = System.Drawing.Color.Indigo
        Me.PlantsTransform.Location = New System.Drawing.Point(378, 319)
        Me.PlantsTransform.Name = "PlantsTransform"
        Me.PlantsTransform.Size = New System.Drawing.Size(182, 157)
        Me.PlantsTransform.TabIndex = 52
        Me.PlantsTransform.TabStop = False
        Me.PlantsTransform.Text = "坐标变换种植"
        '
        'PlantXY
        '
        Me.PlantXY.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PlantXY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PlantXY.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.PlantXY.Location = New System.Drawing.Point(123, 118)
        Me.PlantXY.Name = "PlantXY"
        Me.PlantXY.Size = New System.Drawing.Size(49, 30)
        Me.PlantXY.TabIndex = 117
        Me.PlantXY.Text = "种植"
        Me.PlantXY.UseVisualStyleBackColor = False
        '
        'PlantY
        '
        Me.PlantY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PlantY.Font = New System.Drawing.Font("微软雅黑", 9.75!)
        Me.PlantY.FormattingEnabled = True
        Me.PlantY.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.PlantY.Location = New System.Drawing.Point(123, 83)
        Me.PlantY.Name = "PlantY"
        Me.PlantY.Size = New System.Drawing.Size(48, 27)
        Me.PlantY.TabIndex = 116
        '
        'PlantX
        '
        Me.PlantX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PlantX.Font = New System.Drawing.Font("微软雅黑", 9.75!)
        Me.PlantX.FormattingEnabled = True
        Me.PlantX.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.PlantX.Location = New System.Drawing.Point(123, 48)
        Me.PlantX.Name = "PlantX"
        Me.PlantX.Size = New System.Drawing.Size(48, 27)
        Me.PlantX.TabIndex = 115
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.Indigo
        Me.Label2.Location = New System.Drawing.Point(118, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 19)
        Me.Label2.TabIndex = 114
        Me.Label2.Text = "坐标种植"
        '
        'LabelCol
        '
        Me.LabelCol.AutoSize = True
        Me.LabelCol.Font = New System.Drawing.Font("微软雅黑", 9.75!)
        Me.LabelCol.ForeColor = System.Drawing.Color.Indigo
        Me.LabelCol.Location = New System.Drawing.Point(62, 23)
        Me.LabelCol.Name = "LabelCol"
        Me.LabelCol.Size = New System.Drawing.Size(35, 19)
        Me.LabelCol.TabIndex = 113
        Me.LabelCol.Text = "换列"
        '
        'LabelRow
        '
        Me.LabelRow.AutoSize = True
        Me.LabelRow.Font = New System.Drawing.Font("微软雅黑", 9.75!)
        Me.LabelRow.ForeColor = System.Drawing.Color.Indigo
        Me.LabelRow.Location = New System.Drawing.Point(6, 23)
        Me.LabelRow.Name = "LabelRow"
        Me.LabelRow.Size = New System.Drawing.Size(35, 19)
        Me.LabelRow.TabIndex = 52
        Me.LabelRow.Text = "换行"
        '
        'SwCol2
        '
        Me.SwCol2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SwCol2.Font = New System.Drawing.Font("微软雅黑", 9.75!)
        Me.SwCol2.FormattingEnabled = True
        Me.SwCol2.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.SwCol2.Location = New System.Drawing.Point(66, 83)
        Me.SwCol2.Name = "SwCol2"
        Me.SwCol2.Size = New System.Drawing.Size(48, 27)
        Me.SwCol2.TabIndex = 112
        '
        'SwCol1
        '
        Me.SwCol1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SwCol1.Font = New System.Drawing.Font("微软雅黑", 9.75!)
        Me.SwCol1.FormattingEnabled = True
        Me.SwCol1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.SwCol1.Location = New System.Drawing.Point(66, 48)
        Me.SwCol1.Name = "SwCol1"
        Me.SwCol1.Size = New System.Drawing.Size(48, 27)
        Me.SwCol1.TabIndex = 111
        '
        'SwRow2
        '
        Me.SwRow2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SwRow2.Font = New System.Drawing.Font("微软雅黑", 9.75!)
        Me.SwRow2.FormattingEnabled = True
        Me.SwRow2.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.SwRow2.Location = New System.Drawing.Point(9, 84)
        Me.SwRow2.Name = "SwRow2"
        Me.SwRow2.Size = New System.Drawing.Size(48, 27)
        Me.SwRow2.TabIndex = 110
        '
        'SwRow1
        '
        Me.SwRow1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SwRow1.Font = New System.Drawing.Font("微软雅黑", 9.75!)
        Me.SwRow1.FormattingEnabled = True
        Me.SwRow1.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.SwRow1.Location = New System.Drawing.Point(9, 48)
        Me.SwRow1.Name = "SwRow1"
        Me.SwRow1.Size = New System.Drawing.Size(48, 27)
        Me.SwRow1.TabIndex = 81
        '
        'SwitchCol
        '
        Me.SwitchCol.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SwitchCol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SwitchCol.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.SwitchCol.Location = New System.Drawing.Point(66, 118)
        Me.SwitchCol.Name = "SwitchCol"
        Me.SwitchCol.Size = New System.Drawing.Size(49, 30)
        Me.SwitchCol.TabIndex = 109
        Me.SwitchCol.Text = "换列"
        Me.SwitchCol.UseVisualStyleBackColor = False
        '
        'SwitchRow
        '
        Me.SwitchRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SwitchRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SwitchRow.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.SwitchRow.Location = New System.Drawing.Point(9, 118)
        Me.SwitchRow.Name = "SwitchRow"
        Me.SwitchRow.Size = New System.Drawing.Size(49, 30)
        Me.SwitchRow.TabIndex = 108
        Me.SwitchRow.Text = "换行"
        Me.SwitchRow.UseVisualStyleBackColor = False
        '
        'PortalDesign
        '
        Me.PortalDesign.Controls.Add(Me.PBBY)
        Me.PortalDesign.Controls.Add(Me.PBBX)
        Me.PortalDesign.Controls.Add(Me.PBAY)
        Me.PortalDesign.Controls.Add(Me.PBAX)
        Me.PortalDesign.Controls.Add(Me.PWBY)
        Me.PortalDesign.Controls.Add(Me.ActivePortal)
        Me.PortalDesign.Controls.Add(Me.LabelPBBY)
        Me.PortalDesign.Controls.Add(Me.PWBX)
        Me.PortalDesign.Controls.Add(Me.LabelPBBX)
        Me.PortalDesign.Controls.Add(Me.LabelPBAY)
        Me.PortalDesign.Controls.Add(Me.PWAY)
        Me.PortalDesign.Controls.Add(Me.LabelPBAX)
        Me.PortalDesign.Controls.Add(Me.PicturePBA)
        Me.PortalDesign.Controls.Add(Me.PWAX)
        Me.PortalDesign.Controls.Add(Me.CreatePortalButton)
        Me.PortalDesign.Controls.Add(Me.PicturePBB)
        Me.PortalDesign.Controls.Add(Me.LabelPWAY)
        Me.PortalDesign.Controls.Add(Me.LabelPWBX)
        Me.PortalDesign.Controls.Add(Me.LabelPWAX)
        Me.PortalDesign.Controls.Add(Me.PicturePWA)
        Me.PortalDesign.Controls.Add(Me.LabelPWBY)
        Me.PortalDesign.Controls.Add(Me.PicturePWB)
        Me.PortalDesign.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.PortalDesign.ForeColor = System.Drawing.Color.Indigo
        Me.PortalDesign.Location = New System.Drawing.Point(378, 117)
        Me.PortalDesign.Name = "PortalDesign"
        Me.PortalDesign.Size = New System.Drawing.Size(182, 202)
        Me.PortalDesign.TabIndex = 52
        Me.PortalDesign.TabStop = False
        Me.PortalDesign.Text = "传送门"
        '
        'PBBY
        '
        Me.PBBY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PBBY.Enabled = False
        Me.PBBY.Font = New System.Drawing.Font("微软雅黑", 9.75!)
        Me.PBBY.FormattingEnabled = True
        Me.PBBY.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.PBBY.Location = New System.Drawing.Point(114, 58)
        Me.PBBY.Name = "PBBY"
        Me.PBBY.Size = New System.Drawing.Size(41, 27)
        Me.PBBY.TabIndex = 78
        '
        'PBBX
        '
        Me.PBBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PBBX.Enabled = False
        Me.PBBX.Font = New System.Drawing.Font("微软雅黑", 9.75!)
        Me.PBBX.FormattingEnabled = True
        Me.PBBX.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.PBBX.Location = New System.Drawing.Point(42, 58)
        Me.PBBX.Name = "PBBX"
        Me.PBBX.Size = New System.Drawing.Size(41, 27)
        Me.PBBX.TabIndex = 76
        '
        'PBAY
        '
        Me.PBAY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PBAY.Enabled = False
        Me.PBAY.Font = New System.Drawing.Font("微软雅黑", 9.75!)
        Me.PBAY.FormattingEnabled = True
        Me.PBAY.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.PBAY.Location = New System.Drawing.Point(114, 24)
        Me.PBAY.Name = "PBAY"
        Me.PBAY.Size = New System.Drawing.Size(41, 27)
        Me.PBAY.TabIndex = 74
        '
        'PBAX
        '
        Me.PBAX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PBAX.Enabled = False
        Me.PBAX.Font = New System.Drawing.Font("微软雅黑", 9.75!)
        Me.PBAX.FormattingEnabled = True
        Me.PBAX.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.PBAX.Location = New System.Drawing.Point(42, 24)
        Me.PBAX.Name = "PBAX"
        Me.PBAX.Size = New System.Drawing.Size(41, 27)
        Me.PBAX.TabIndex = 72
        '
        'PWBY
        '
        Me.PWBY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PWBY.Enabled = False
        Me.PWBY.Font = New System.Drawing.Font("微软雅黑", 9.75!)
        Me.PWBY.FormattingEnabled = True
        Me.PWBY.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.PWBY.Location = New System.Drawing.Point(114, 126)
        Me.PWBY.Name = "PWBY"
        Me.PWBY.Size = New System.Drawing.Size(41, 27)
        Me.PWBY.TabIndex = 70
        '
        'ActivePortal
        '
        Me.ActivePortal.AutoSize = True
        Me.ActivePortal.BackColor = System.Drawing.Color.Transparent
        Me.ActivePortal.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.ActivePortal.ForeColor = System.Drawing.Color.Black
        Me.ActivePortal.Location = New System.Drawing.Point(122, 166)
        Me.ActivePortal.Name = "ActivePortal"
        Me.ActivePortal.Size = New System.Drawing.Size(58, 24)
        Me.ActivePortal.TabIndex = 63
        Me.ActivePortal.Text = "启动"
        Me.ActivePortal.UseVisualStyleBackColor = False
        '
        'LabelPBBY
        '
        Me.LabelPBBY.AutoSize = True
        Me.LabelPBBY.Font = New System.Drawing.Font("微软雅黑", 9.75!)
        Me.LabelPBBY.ForeColor = System.Drawing.Color.Black
        Me.LabelPBBY.Location = New System.Drawing.Point(156, 63)
        Me.LabelPBBY.Name = "LabelPBBY"
        Me.LabelPBBY.Size = New System.Drawing.Size(22, 19)
        Me.LabelPBBY.TabIndex = 79
        Me.LabelPBBY.Text = "列"
        '
        'PWBX
        '
        Me.PWBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PWBX.Enabled = False
        Me.PWBX.Font = New System.Drawing.Font("微软雅黑", 9.75!)
        Me.PWBX.FormattingEnabled = True
        Me.PWBX.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.PWBX.Location = New System.Drawing.Point(42, 126)
        Me.PWBX.Name = "PWBX"
        Me.PWBX.Size = New System.Drawing.Size(41, 27)
        Me.PWBX.TabIndex = 68
        '
        'LabelPBBX
        '
        Me.LabelPBBX.AutoSize = True
        Me.LabelPBBX.Font = New System.Drawing.Font("微软雅黑", 9.75!)
        Me.LabelPBBX.ForeColor = System.Drawing.Color.Black
        Me.LabelPBBX.Location = New System.Drawing.Point(86, 63)
        Me.LabelPBBX.Name = "LabelPBBX"
        Me.LabelPBBX.Size = New System.Drawing.Size(22, 19)
        Me.LabelPBBX.TabIndex = 77
        Me.LabelPBBX.Text = "行"
        '
        'LabelPBAY
        '
        Me.LabelPBAY.AutoSize = True
        Me.LabelPBAY.Font = New System.Drawing.Font("微软雅黑", 9.75!)
        Me.LabelPBAY.ForeColor = System.Drawing.Color.Black
        Me.LabelPBAY.Location = New System.Drawing.Point(156, 29)
        Me.LabelPBAY.Name = "LabelPBAY"
        Me.LabelPBAY.Size = New System.Drawing.Size(22, 19)
        Me.LabelPBAY.TabIndex = 75
        Me.LabelPBAY.Text = "列"
        '
        'PWAY
        '
        Me.PWAY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PWAY.Enabled = False
        Me.PWAY.Font = New System.Drawing.Font("微软雅黑", 9.75!)
        Me.PWAY.FormattingEnabled = True
        Me.PWAY.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.PWAY.Location = New System.Drawing.Point(114, 92)
        Me.PWAY.Name = "PWAY"
        Me.PWAY.Size = New System.Drawing.Size(41, 27)
        Me.PWAY.TabIndex = 66
        '
        'LabelPBAX
        '
        Me.LabelPBAX.AutoSize = True
        Me.LabelPBAX.Font = New System.Drawing.Font("微软雅黑", 9.75!)
        Me.LabelPBAX.ForeColor = System.Drawing.Color.Black
        Me.LabelPBAX.Location = New System.Drawing.Point(86, 29)
        Me.LabelPBAX.Name = "LabelPBAX"
        Me.LabelPBAX.Size = New System.Drawing.Size(22, 19)
        Me.LabelPBAX.TabIndex = 73
        Me.LabelPBAX.Text = "行"
        '
        'PicturePBA
        '
        Me.PicturePBA.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources.PortalBlackA
        Me.PicturePBA.Location = New System.Drawing.Point(12, 26)
        Me.PicturePBA.Name = "PicturePBA"
        Me.PicturePBA.Size = New System.Drawing.Size(21, 25)
        Me.PicturePBA.TabIndex = 7
        Me.PicturePBA.TabStop = False
        '
        'PWAX
        '
        Me.PWAX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PWAX.Enabled = False
        Me.PWAX.Font = New System.Drawing.Font("微软雅黑", 9.75!)
        Me.PWAX.FormattingEnabled = True
        Me.PWAX.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.PWAX.Location = New System.Drawing.Point(42, 92)
        Me.PWAX.Name = "PWAX"
        Me.PWAX.Size = New System.Drawing.Size(41, 27)
        Me.PWAX.TabIndex = 64
        '
        'CreatePortalButton
        '
        Me.CreatePortalButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CreatePortalButton.Enabled = False
        Me.CreatePortalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CreatePortalButton.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.CreatePortalButton.ForeColor = System.Drawing.Color.Indigo
        Me.CreatePortalButton.Location = New System.Drawing.Point(11, 160)
        Me.CreatePortalButton.Name = "CreatePortalButton"
        Me.CreatePortalButton.Size = New System.Drawing.Size(97, 33)
        Me.CreatePortalButton.TabIndex = 80
        Me.CreatePortalButton.Text = "创建"
        Me.CreatePortalButton.UseVisualStyleBackColor = False
        '
        'PicturePBB
        '
        Me.PicturePBB.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources.PortalBlackB
        Me.PicturePBB.Location = New System.Drawing.Point(12, 60)
        Me.PicturePBB.Name = "PicturePBB"
        Me.PicturePBB.Size = New System.Drawing.Size(21, 25)
        Me.PicturePBB.TabIndex = 10
        Me.PicturePBB.TabStop = False
        '
        'LabelPWAY
        '
        Me.LabelPWAY.AutoSize = True
        Me.LabelPWAY.Font = New System.Drawing.Font("微软雅黑", 9.75!)
        Me.LabelPWAY.ForeColor = System.Drawing.Color.Black
        Me.LabelPWAY.Location = New System.Drawing.Point(156, 97)
        Me.LabelPWAY.Name = "LabelPWAY"
        Me.LabelPWAY.Size = New System.Drawing.Size(22, 19)
        Me.LabelPWAY.TabIndex = 67
        Me.LabelPWAY.Text = "列"
        '
        'LabelPWBX
        '
        Me.LabelPWBX.AutoSize = True
        Me.LabelPWBX.Font = New System.Drawing.Font("微软雅黑", 9.75!)
        Me.LabelPWBX.ForeColor = System.Drawing.Color.Black
        Me.LabelPWBX.Location = New System.Drawing.Point(86, 131)
        Me.LabelPWBX.Name = "LabelPWBX"
        Me.LabelPWBX.Size = New System.Drawing.Size(22, 19)
        Me.LabelPWBX.TabIndex = 69
        Me.LabelPWBX.Text = "行"
        '
        'LabelPWAX
        '
        Me.LabelPWAX.AutoSize = True
        Me.LabelPWAX.Font = New System.Drawing.Font("微软雅黑", 9.75!)
        Me.LabelPWAX.ForeColor = System.Drawing.Color.Black
        Me.LabelPWAX.Location = New System.Drawing.Point(86, 97)
        Me.LabelPWAX.Name = "LabelPWAX"
        Me.LabelPWAX.Size = New System.Drawing.Size(22, 19)
        Me.LabelPWAX.TabIndex = 65
        Me.LabelPWAX.Text = "行"
        '
        'PicturePWA
        '
        Me.PicturePWA.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources.PortalWhiteA
        Me.PicturePWA.Location = New System.Drawing.Point(12, 94)
        Me.PicturePWA.Name = "PicturePWA"
        Me.PicturePWA.Size = New System.Drawing.Size(21, 25)
        Me.PicturePWA.TabIndex = 6
        Me.PicturePWA.TabStop = False
        '
        'LabelPWBY
        '
        Me.LabelPWBY.AutoSize = True
        Me.LabelPWBY.Font = New System.Drawing.Font("微软雅黑", 9.75!)
        Me.LabelPWBY.ForeColor = System.Drawing.Color.Black
        Me.LabelPWBY.Location = New System.Drawing.Point(156, 131)
        Me.LabelPWBY.Name = "LabelPWBY"
        Me.LabelPWBY.Size = New System.Drawing.Size(22, 19)
        Me.LabelPWBY.TabIndex = 71
        Me.LabelPWBY.Text = "列"
        '
        'PicturePWB
        '
        Me.PicturePWB.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources.PortalWhiteB
        Me.PicturePWB.Location = New System.Drawing.Point(12, 128)
        Me.PicturePWB.Name = "PicturePWB"
        Me.PicturePWB.Size = New System.Drawing.Size(21, 25)
        Me.PicturePWB.TabIndex = 9
        Me.PicturePWB.TabStop = False
        '
        'PlantMode
        '
        Me.PlantMode.Controls.Add(Me.PlantSwitchText)
        Me.PlantMode.Controls.Add(Me.PlantSwitch)
        Me.PlantMode.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.PlantMode.ForeColor = System.Drawing.Color.Indigo
        Me.PlantMode.Location = New System.Drawing.Point(378, 4)
        Me.PlantMode.Name = "PlantMode"
        Me.PlantMode.Size = New System.Drawing.Size(182, 56)
        Me.PlantMode.TabIndex = 47
        Me.PlantMode.TabStop = False
        Me.PlantMode.Text = "种植模式"
        '
        'PlantSwitch
        '
        Me.PlantSwitch.AutoSize = True
        Me.PlantSwitch.BackColor = System.Drawing.Color.Transparent
        Me.PlantSwitch.Enabled = False
        Me.PlantSwitch.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.PlantSwitch.ForeColor = System.Drawing.Color.SlateBlue
        Me.PlantSwitch.Location = New System.Drawing.Point(13, 24)
        Me.PlantSwitch.Name = "PlantSwitch"
        Me.PlantSwitch.Size = New System.Drawing.Size(154, 25)
        Me.PlantSwitch.TabIndex = 48
        Me.PlantSwitch.Text = "                         "
        Me.PlantSwitch.UseVisualStyleBackColor = False
        '
        'ChoosePlant
        '
        Me.ChoosePlant.Controls.Add(Me.SelectedPlantName)
        Me.ChoosePlant.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ChoosePlant.ForeColor = System.Drawing.Color.Indigo
        Me.ChoosePlant.Location = New System.Drawing.Point(378, 60)
        Me.ChoosePlant.Name = "ChoosePlant"
        Me.ChoosePlant.Size = New System.Drawing.Size(182, 57)
        Me.ChoosePlant.TabIndex = 50
        Me.ChoosePlant.TabStop = False
        Me.ChoosePlant.Text = "选择植物"
        '
        'SelectedPlantName
        '
        Me.SelectedPlantName.AutoSize = True
        Me.SelectedPlantName.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.SelectedPlantName.ForeColor = System.Drawing.Color.DarkGreen
        Me.SelectedPlantName.Location = New System.Drawing.Point(9, 25)
        Me.SelectedPlantName.Name = "SelectedPlantName"
        Me.SelectedPlantName.Size = New System.Drawing.Size(74, 22)
        Me.SelectedPlantName.TabIndex = 51
        Me.SelectedPlantName.Text = "豌豆射手"
        '
        'Selected
        '
        Me.Selected.Enabled = False
        Me.Selected.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources.Selected
        Me.Selected.Location = New System.Drawing.Point(11, 5)
        Me.Selected.Name = "Selected"
        Me.Selected.Size = New System.Drawing.Size(40, 14)
        Me.Selected.TabIndex = 61
        Me.Selected.TabStop = False
        '
        'Card49
        '
        Me.Card49.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card49.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources.Red
        Me.Card49.Location = New System.Drawing.Point(11, 420)
        Me.Card49.Name = "Card49"
        Me.Card49.Size = New System.Drawing.Size(40, 56)
        Me.Card49.TabIndex = 48
        Me.Card49.TabStop = False
        '
        'Card50
        '
        Me.Card50.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card50.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources.BigNut
        Me.Card50.Location = New System.Drawing.Point(56, 420)
        Me.Card50.Name = "Card50"
        Me.Card50.Size = New System.Drawing.Size(40, 56)
        Me.Card50.TabIndex = 49
        Me.Card50.TabStop = False
        '
        'Card51
        '
        Me.Card51.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card51.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources.Ya
        Me.Card51.Location = New System.Drawing.Point(101, 420)
        Me.Card51.Name = "Card51"
        Me.Card51.Size = New System.Drawing.Size(40, 56)
        Me.Card51.TabIndex = 50
        Me.Card51.TabStop = False
        '
        'Card52
        '
        Me.Card52.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card52.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources.BackRepeater
        Me.Card52.Location = New System.Drawing.Point(146, 420)
        Me.Card52.Name = "Card52"
        Me.Card52.Size = New System.Drawing.Size(40, 56)
        Me.Card52.TabIndex = 51
        Me.Card52.TabStop = False
        '
        'Card53
        '
        Me.Card53.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card53.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources.Ladder
        Me.Card53.Location = New System.Drawing.Point(191, 420)
        Me.Card53.Name = "Card53"
        Me.Card53.Size = New System.Drawing.Size(40, 56)
        Me.Card53.TabIndex = 52
        Me.Card53.TabStop = False
        '
        'Card54
        '
        Me.Card54.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card54.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources.Rake
        Me.Card54.Location = New System.Drawing.Point(236, 420)
        Me.Card54.Name = "Card54"
        Me.Card54.Size = New System.Drawing.Size(40, 56)
        Me.Card54.TabIndex = 53
        Me.Card54.TabStop = False
        '
        'Card55
        '
        Me.Card55.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card55.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources.Grave
        Me.Card55.Location = New System.Drawing.Point(281, 420)
        Me.Card55.Name = "Card55"
        Me.Card55.Size = New System.Drawing.Size(40, 56)
        Me.Card55.TabIndex = 54
        Me.Card55.TabStop = False
        '
        'Card56
        '
        Me.Card56.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card56.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources.Hole
        Me.Card56.Location = New System.Drawing.Point(326, 420)
        Me.Card56.Name = "Card56"
        Me.Card56.Size = New System.Drawing.Size(40, 56)
        Me.Card56.TabIndex = 55
        Me.Card56.TabStop = False
        '
        'Card41
        '
        Me.Card41.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card41.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources._40
        Me.Card41.Location = New System.Drawing.Point(11, 352)
        Me.Card41.Name = "Card41"
        Me.Card41.Size = New System.Drawing.Size(40, 56)
        Me.Card41.TabIndex = 40
        Me.Card41.TabStop = False
        '
        'Card42
        '
        Me.Card42.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card42.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources._41
        Me.Card42.Location = New System.Drawing.Point(56, 352)
        Me.Card42.Name = "Card42"
        Me.Card42.Size = New System.Drawing.Size(40, 56)
        Me.Card42.TabIndex = 41
        Me.Card42.TabStop = False
        '
        'Card43
        '
        Me.Card43.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card43.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources._42
        Me.Card43.Location = New System.Drawing.Point(101, 352)
        Me.Card43.Name = "Card43"
        Me.Card43.Size = New System.Drawing.Size(40, 56)
        Me.Card43.TabIndex = 42
        Me.Card43.TabStop = False
        '
        'Card44
        '
        Me.Card44.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card44.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources._43
        Me.Card44.Location = New System.Drawing.Point(146, 352)
        Me.Card44.Name = "Card44"
        Me.Card44.Size = New System.Drawing.Size(40, 56)
        Me.Card44.TabIndex = 43
        Me.Card44.TabStop = False
        '
        'Card45
        '
        Me.Card45.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card45.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources._44
        Me.Card45.Location = New System.Drawing.Point(191, 352)
        Me.Card45.Name = "Card45"
        Me.Card45.Size = New System.Drawing.Size(40, 56)
        Me.Card45.TabIndex = 44
        Me.Card45.TabStop = False
        '
        'Card46
        '
        Me.Card46.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card46.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources._45
        Me.Card46.Location = New System.Drawing.Point(236, 352)
        Me.Card46.Name = "Card46"
        Me.Card46.Size = New System.Drawing.Size(40, 56)
        Me.Card46.TabIndex = 45
        Me.Card46.TabStop = False
        '
        'Card47
        '
        Me.Card47.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card47.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources._46
        Me.Card47.Location = New System.Drawing.Point(281, 352)
        Me.Card47.Name = "Card47"
        Me.Card47.Size = New System.Drawing.Size(40, 56)
        Me.Card47.TabIndex = 46
        Me.Card47.TabStop = False
        '
        'Card48
        '
        Me.Card48.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card48.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources._47
        Me.Card48.Location = New System.Drawing.Point(326, 352)
        Me.Card48.Name = "Card48"
        Me.Card48.Size = New System.Drawing.Size(40, 56)
        Me.Card48.TabIndex = 47
        Me.Card48.TabStop = False
        '
        'Card33
        '
        Me.Card33.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card33.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources._32
        Me.Card33.Location = New System.Drawing.Point(11, 284)
        Me.Card33.Name = "Card33"
        Me.Card33.Size = New System.Drawing.Size(40, 56)
        Me.Card33.TabIndex = 32
        Me.Card33.TabStop = False
        '
        'Card34
        '
        Me.Card34.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card34.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources._33
        Me.Card34.Location = New System.Drawing.Point(56, 284)
        Me.Card34.Name = "Card34"
        Me.Card34.Size = New System.Drawing.Size(40, 56)
        Me.Card34.TabIndex = 33
        Me.Card34.TabStop = False
        '
        'Card35
        '
        Me.Card35.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card35.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources._34
        Me.Card35.Location = New System.Drawing.Point(101, 284)
        Me.Card35.Name = "Card35"
        Me.Card35.Size = New System.Drawing.Size(40, 56)
        Me.Card35.TabIndex = 34
        Me.Card35.TabStop = False
        '
        'Card36
        '
        Me.Card36.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card36.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources._35
        Me.Card36.Location = New System.Drawing.Point(146, 284)
        Me.Card36.Name = "Card36"
        Me.Card36.Size = New System.Drawing.Size(40, 56)
        Me.Card36.TabIndex = 35
        Me.Card36.TabStop = False
        '
        'Card37
        '
        Me.Card37.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card37.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources._36
        Me.Card37.Location = New System.Drawing.Point(191, 284)
        Me.Card37.Name = "Card37"
        Me.Card37.Size = New System.Drawing.Size(40, 56)
        Me.Card37.TabIndex = 36
        Me.Card37.TabStop = False
        '
        'Card38
        '
        Me.Card38.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card38.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources._37
        Me.Card38.Location = New System.Drawing.Point(236, 284)
        Me.Card38.Name = "Card38"
        Me.Card38.Size = New System.Drawing.Size(40, 56)
        Me.Card38.TabIndex = 37
        Me.Card38.TabStop = False
        '
        'Card39
        '
        Me.Card39.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card39.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources._38
        Me.Card39.Location = New System.Drawing.Point(281, 284)
        Me.Card39.Name = "Card39"
        Me.Card39.Size = New System.Drawing.Size(40, 56)
        Me.Card39.TabIndex = 38
        Me.Card39.TabStop = False
        '
        'Card40
        '
        Me.Card40.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card40.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources._39
        Me.Card40.Location = New System.Drawing.Point(326, 284)
        Me.Card40.Name = "Card40"
        Me.Card40.Size = New System.Drawing.Size(40, 56)
        Me.Card40.TabIndex = 39
        Me.Card40.TabStop = False
        '
        'Card25
        '
        Me.Card25.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card25.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources._24
        Me.Card25.Location = New System.Drawing.Point(11, 216)
        Me.Card25.Name = "Card25"
        Me.Card25.Size = New System.Drawing.Size(40, 56)
        Me.Card25.TabIndex = 24
        Me.Card25.TabStop = False
        '
        'Card26
        '
        Me.Card26.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card26.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources._25
        Me.Card26.Location = New System.Drawing.Point(56, 216)
        Me.Card26.Name = "Card26"
        Me.Card26.Size = New System.Drawing.Size(40, 56)
        Me.Card26.TabIndex = 25
        Me.Card26.TabStop = False
        '
        'Card27
        '
        Me.Card27.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card27.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources._26
        Me.Card27.Location = New System.Drawing.Point(101, 216)
        Me.Card27.Name = "Card27"
        Me.Card27.Size = New System.Drawing.Size(40, 56)
        Me.Card27.TabIndex = 26
        Me.Card27.TabStop = False
        '
        'Card28
        '
        Me.Card28.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card28.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources._27
        Me.Card28.Location = New System.Drawing.Point(146, 216)
        Me.Card28.Name = "Card28"
        Me.Card28.Size = New System.Drawing.Size(40, 56)
        Me.Card28.TabIndex = 27
        Me.Card28.TabStop = False
        '
        'Card29
        '
        Me.Card29.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card29.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources._28
        Me.Card29.Location = New System.Drawing.Point(191, 216)
        Me.Card29.Name = "Card29"
        Me.Card29.Size = New System.Drawing.Size(40, 56)
        Me.Card29.TabIndex = 28
        Me.Card29.TabStop = False
        '
        'Card30
        '
        Me.Card30.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card30.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources._29
        Me.Card30.Location = New System.Drawing.Point(236, 216)
        Me.Card30.Name = "Card30"
        Me.Card30.Size = New System.Drawing.Size(40, 56)
        Me.Card30.TabIndex = 29
        Me.Card30.TabStop = False
        '
        'Card31
        '
        Me.Card31.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card31.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources._30
        Me.Card31.Location = New System.Drawing.Point(281, 216)
        Me.Card31.Name = "Card31"
        Me.Card31.Size = New System.Drawing.Size(40, 56)
        Me.Card31.TabIndex = 30
        Me.Card31.TabStop = False
        '
        'Card32
        '
        Me.Card32.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card32.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources._31
        Me.Card32.Location = New System.Drawing.Point(326, 216)
        Me.Card32.Name = "Card32"
        Me.Card32.Size = New System.Drawing.Size(40, 56)
        Me.Card32.TabIndex = 31
        Me.Card32.TabStop = False
        '
        'Card17
        '
        Me.Card17.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card17.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources._16
        Me.Card17.Location = New System.Drawing.Point(11, 148)
        Me.Card17.Name = "Card17"
        Me.Card17.Size = New System.Drawing.Size(40, 56)
        Me.Card17.TabIndex = 16
        Me.Card17.TabStop = False
        '
        'Card18
        '
        Me.Card18.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card18.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources._17
        Me.Card18.Location = New System.Drawing.Point(56, 148)
        Me.Card18.Name = "Card18"
        Me.Card18.Size = New System.Drawing.Size(40, 56)
        Me.Card18.TabIndex = 17
        Me.Card18.TabStop = False
        '
        'Card19
        '
        Me.Card19.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card19.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources._18
        Me.Card19.Location = New System.Drawing.Point(101, 148)
        Me.Card19.Name = "Card19"
        Me.Card19.Size = New System.Drawing.Size(40, 56)
        Me.Card19.TabIndex = 18
        Me.Card19.TabStop = False
        '
        'Card20
        '
        Me.Card20.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card20.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources._19
        Me.Card20.Location = New System.Drawing.Point(146, 148)
        Me.Card20.Name = "Card20"
        Me.Card20.Size = New System.Drawing.Size(40, 56)
        Me.Card20.TabIndex = 19
        Me.Card20.TabStop = False
        '
        'Card21
        '
        Me.Card21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card21.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources._20
        Me.Card21.Location = New System.Drawing.Point(191, 148)
        Me.Card21.Name = "Card21"
        Me.Card21.Size = New System.Drawing.Size(40, 56)
        Me.Card21.TabIndex = 20
        Me.Card21.TabStop = False
        '
        'Card22
        '
        Me.Card22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card22.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources._21
        Me.Card22.Location = New System.Drawing.Point(236, 148)
        Me.Card22.Name = "Card22"
        Me.Card22.Size = New System.Drawing.Size(40, 56)
        Me.Card22.TabIndex = 21
        Me.Card22.TabStop = False
        '
        'Card23
        '
        Me.Card23.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card23.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources._22
        Me.Card23.Location = New System.Drawing.Point(281, 148)
        Me.Card23.Name = "Card23"
        Me.Card23.Size = New System.Drawing.Size(40, 56)
        Me.Card23.TabIndex = 22
        Me.Card23.TabStop = False
        '
        'Card24
        '
        Me.Card24.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card24.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources._23
        Me.Card24.Location = New System.Drawing.Point(326, 148)
        Me.Card24.Name = "Card24"
        Me.Card24.Size = New System.Drawing.Size(40, 56)
        Me.Card24.TabIndex = 23
        Me.Card24.TabStop = False
        '
        'Card9
        '
        Me.Card9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card9.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources._8
        Me.Card9.Location = New System.Drawing.Point(11, 80)
        Me.Card9.Name = "Card9"
        Me.Card9.Size = New System.Drawing.Size(40, 56)
        Me.Card9.TabIndex = 8
        Me.Card9.TabStop = False
        '
        'Card10
        '
        Me.Card10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card10.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources._9
        Me.Card10.Location = New System.Drawing.Point(56, 80)
        Me.Card10.Name = "Card10"
        Me.Card10.Size = New System.Drawing.Size(40, 56)
        Me.Card10.TabIndex = 9
        Me.Card10.TabStop = False
        '
        'Card11
        '
        Me.Card11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card11.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources._10
        Me.Card11.Location = New System.Drawing.Point(101, 80)
        Me.Card11.Name = "Card11"
        Me.Card11.Size = New System.Drawing.Size(40, 56)
        Me.Card11.TabIndex = 10
        Me.Card11.TabStop = False
        '
        'Card12
        '
        Me.Card12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card12.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources._11
        Me.Card12.Location = New System.Drawing.Point(146, 80)
        Me.Card12.Name = "Card12"
        Me.Card12.Size = New System.Drawing.Size(40, 56)
        Me.Card12.TabIndex = 11
        Me.Card12.TabStop = False
        '
        'Card13
        '
        Me.Card13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card13.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources._12
        Me.Card13.Location = New System.Drawing.Point(191, 80)
        Me.Card13.Name = "Card13"
        Me.Card13.Size = New System.Drawing.Size(40, 56)
        Me.Card13.TabIndex = 12
        Me.Card13.TabStop = False
        '
        'Card14
        '
        Me.Card14.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card14.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources._13
        Me.Card14.Location = New System.Drawing.Point(236, 80)
        Me.Card14.Name = "Card14"
        Me.Card14.Size = New System.Drawing.Size(40, 56)
        Me.Card14.TabIndex = 13
        Me.Card14.TabStop = False
        '
        'Card15
        '
        Me.Card15.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card15.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources._14
        Me.Card15.Location = New System.Drawing.Point(281, 80)
        Me.Card15.Name = "Card15"
        Me.Card15.Size = New System.Drawing.Size(40, 56)
        Me.Card15.TabIndex = 14
        Me.Card15.TabStop = False
        '
        'Card16
        '
        Me.Card16.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card16.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources._15
        Me.Card16.Location = New System.Drawing.Point(326, 80)
        Me.Card16.Name = "Card16"
        Me.Card16.Size = New System.Drawing.Size(40, 56)
        Me.Card16.TabIndex = 15
        Me.Card16.TabStop = False
        '
        'Card1
        '
        Me.Card1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card1.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources._0
        Me.Card1.Location = New System.Drawing.Point(11, 12)
        Me.Card1.Name = "Card1"
        Me.Card1.Size = New System.Drawing.Size(40, 56)
        Me.Card1.TabIndex = 0
        Me.Card1.TabStop = False
        '
        'Card2
        '
        Me.Card2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card2.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources._1
        Me.Card2.Location = New System.Drawing.Point(56, 12)
        Me.Card2.Name = "Card2"
        Me.Card2.Size = New System.Drawing.Size(40, 56)
        Me.Card2.TabIndex = 1
        Me.Card2.TabStop = False
        '
        'Card3
        '
        Me.Card3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card3.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources._2
        Me.Card3.Location = New System.Drawing.Point(101, 12)
        Me.Card3.Name = "Card3"
        Me.Card3.Size = New System.Drawing.Size(40, 56)
        Me.Card3.TabIndex = 2
        Me.Card3.TabStop = False
        '
        'Card4
        '
        Me.Card4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card4.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources._3
        Me.Card4.Location = New System.Drawing.Point(146, 12)
        Me.Card4.Name = "Card4"
        Me.Card4.Size = New System.Drawing.Size(40, 56)
        Me.Card4.TabIndex = 3
        Me.Card4.TabStop = False
        '
        'Card5
        '
        Me.Card5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card5.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources._4
        Me.Card5.Location = New System.Drawing.Point(191, 12)
        Me.Card5.Name = "Card5"
        Me.Card5.Size = New System.Drawing.Size(40, 56)
        Me.Card5.TabIndex = 4
        Me.Card5.TabStop = False
        '
        'Card6
        '
        Me.Card6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card6.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources._5
        Me.Card6.Location = New System.Drawing.Point(236, 12)
        Me.Card6.Name = "Card6"
        Me.Card6.Size = New System.Drawing.Size(40, 56)
        Me.Card6.TabIndex = 5
        Me.Card6.TabStop = False
        '
        'Card7
        '
        Me.Card7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card7.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources._6
        Me.Card7.Location = New System.Drawing.Point(281, 12)
        Me.Card7.Name = "Card7"
        Me.Card7.Size = New System.Drawing.Size(40, 56)
        Me.Card7.TabIndex = 6
        Me.Card7.TabStop = False
        '
        'Card8
        '
        Me.Card8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Card8.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources._7
        Me.Card8.Location = New System.Drawing.Point(326, 12)
        Me.Card8.Name = "Card8"
        Me.Card8.Size = New System.Drawing.Size(40, 56)
        Me.Card8.TabIndex = 7
        Me.Card8.TabStop = False
        '
        'Basic
        '
        Me.Basic.BackColor = System.Drawing.Color.White
        Me.Basic.Controls.Add(Me.QuickClick)
        Me.Basic.Controls.Add(Me.FindWindowAgain)
        Me.Basic.Controls.Add(Me.GroupBox2)
        Me.Basic.Controls.Add(Me.ZombieCardEditGB)
        Me.Basic.Controls.Add(Me.LevelCodeOutPut)
        Me.Basic.Controls.Add(Me.MagTimer)
        Me.Basic.Controls.Add(Me.BasicSetting)
        Me.Basic.Controls.Add(Me.StateInfo)
        Me.Basic.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Basic.ForeColor = System.Drawing.Color.Black
        Me.Basic.ImageKey = "(无)"
        Me.Basic.Location = New System.Drawing.Point(4, 36)
        Me.Basic.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Basic.Name = "Basic"
        Me.Basic.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Basic.Size = New System.Drawing.Size(571, 481)
        Me.Basic.TabIndex = 0
        Me.Basic.Text = " 常规"
        '
        'QuickClick
        '
        Me.QuickClick.Controls.Add(Me.Fail)
        Me.QuickClick.Controls.Add(Me.CreateCodeAndCopy)
        Me.QuickClick.Controls.Add(Me.KillAll)
        Me.QuickClick.Controls.Add(Me.Clear)
        Me.QuickClick.Controls.Add(Me.LockShovel)
        Me.QuickClick.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.QuickClick.ForeColor = System.Drawing.Color.Indigo
        Me.QuickClick.Location = New System.Drawing.Point(10, 332)
        Me.QuickClick.Margin = New System.Windows.Forms.Padding(5, 8, 5, 8)
        Me.QuickClick.Name = "QuickClick"
        Me.QuickClick.Padding = New System.Windows.Forms.Padding(5, 8, 5, 8)
        Me.QuickClick.Size = New System.Drawing.Size(550, 74)
        Me.QuickClick.TabIndex = 10
        Me.QuickClick.TabStop = False
        Me.QuickClick.Text = "快捷按钮"
        '
        'FindWindowAgain
        '
        Me.FindWindowAgain.BackColor = System.Drawing.Color.Indigo
        Me.FindWindowAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FindWindowAgain.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.FindWindowAgain.ForeColor = System.Drawing.Color.White
        Me.FindWindowAgain.Location = New System.Drawing.Point(10, 12)
        Me.FindWindowAgain.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.FindWindowAgain.Name = "FindWindowAgain"
        Me.FindWindowAgain.Size = New System.Drawing.Size(106, 52)
        Me.FindWindowAgain.TabIndex = 4
        Me.FindWindowAgain.Text = "寻找游戏"
        Me.FindWindowAgain.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SpeedUp)
        Me.GroupBox2.Controls.Add(Me.QLoad)
        Me.GroupBox2.Controls.Add(Me.QSave)
        Me.GroupBox2.Controls.Add(Me.NoCD)
        Me.GroupBox2.Controls.Add(Me.LockButter)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.CobNoCD)
        Me.GroupBox2.Controls.Add(Me.LockKernel)
        Me.GroupBox2.Controls.Add(Me.AutoColletct)
        Me.GroupBox2.Controls.Add(Me.AllowPlants)
        Me.GroupBox2.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Indigo
        Me.GroupBox2.Location = New System.Drawing.Point(395, 71)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(165, 257)
        Me.GroupBox2.TabIndex = 47
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "功能"
        '
        'QSave
        '
        Me.QSave.BackColor = System.Drawing.Color.WhiteSmoke
        Me.QSave.Cursor = System.Windows.Forms.Cursors.Default
        Me.QSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.QSave.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.QSave.ForeColor = System.Drawing.Color.Indigo
        Me.QSave.Location = New System.Drawing.Point(14, 216)
        Me.QSave.Name = "QSave"
        Me.QSave.Size = New System.Drawing.Size(65, 30)
        Me.QSave.TabIndex = 134
        Me.QSave.Text = "存档"
        Me.QSave.UseVisualStyleBackColor = False
        '
        'NoCD
        '
        Me.NoCD.AutoSize = True
        Me.NoCD.BackColor = System.Drawing.Color.Transparent
        Me.NoCD.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.NoCD.ForeColor = System.Drawing.Color.Black
        Me.NoCD.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.NoCD.Location = New System.Drawing.Point(14, 131)
        Me.NoCD.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.NoCD.Name = "NoCD"
        Me.NoCD.Size = New System.Drawing.Size(103, 24)
        Me.NoCD.TabIndex = 69
        Me.NoCD.Text = "卡槽无冷却"
        Me.NoCD.UseVisualStyleBackColor = False
        '
        'LockButter
        '
        Me.LockButter.AutoSize = True
        Me.LockButter.BackColor = System.Drawing.Color.Transparent
        Me.LockButter.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.LockButter.ForeColor = System.Drawing.Color.Black
        Me.LockButter.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.LockButter.Location = New System.Drawing.Point(14, 77)
        Me.LockButter.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.LockButter.Name = "LockButter"
        Me.LockButter.Size = New System.Drawing.Size(88, 24)
        Me.LockButter.TabIndex = 68
        Me.LockButter.Text = "锁定黄油"
        Me.LockButter.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(74, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 19)
        Me.Label1.TabIndex = 42
        '
        'ZombieCardEditGB
        '
        Me.ZombieCardEditGB.Controls.Add(Me.ResetZombieCardProperty)
        Me.ZombieCardEditGB.Controls.Add(Me.ZombieSunConfirm)
        Me.ZombieCardEditGB.Controls.Add(Me.ZombieCardSun)
        Me.ZombieCardEditGB.Controls.Add(Me.ZombieCardSunType)
        Me.ZombieCardEditGB.Controls.Add(Me.LabelZombieCardSun)
        Me.ZombieCardEditGB.Controls.Add(Me.ReplaceConfirm)
        Me.ZombieCardEditGB.Controls.Add(Me.ReplaceA)
        Me.ZombieCardEditGB.Controls.Add(Me.ReplaceB)
        Me.ZombieCardEditGB.Controls.Add(Me.LabelSwitchZombieTo)
        Me.ZombieCardEditGB.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ZombieCardEditGB.ForeColor = System.Drawing.Color.Indigo
        Me.ZombieCardEditGB.Location = New System.Drawing.Point(10, 218)
        Me.ZombieCardEditGB.Margin = New System.Windows.Forms.Padding(5, 8, 5, 8)
        Me.ZombieCardEditGB.Name = "ZombieCardEditGB"
        Me.ZombieCardEditGB.Padding = New System.Windows.Forms.Padding(5, 8, 5, 8)
        Me.ZombieCardEditGB.Size = New System.Drawing.Size(376, 110)
        Me.ZombieCardEditGB.TabIndex = 23
        Me.ZombieCardEditGB.TabStop = False
        Me.ZombieCardEditGB.Text = "僵尸卡槽修改 (改动不会保存到代码中)"
        '
        'ResetZombieCardProperty
        '
        Me.ResetZombieCardProperty.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ResetZombieCardProperty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ResetZombieCardProperty.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.ResetZombieCardProperty.Location = New System.Drawing.Point(315, 30)
        Me.ResetZombieCardProperty.Name = "ResetZombieCardProperty"
        Me.ResetZombieCardProperty.Size = New System.Drawing.Size(52, 28)
        Me.ResetZombieCardProperty.TabIndex = 32
        Me.ResetZombieCardProperty.Text = "重置"
        Me.ResetZombieCardProperty.UseVisualStyleBackColor = False
        '
        'ZombieSunConfirm
        '
        Me.ZombieSunConfirm.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.ZombieSunConfirm.ForeColor = System.Drawing.Color.Black
        Me.ZombieSunConfirm.Location = New System.Drawing.Point(282, 69)
        Me.ZombieSunConfirm.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.ZombieSunConfirm.Name = "ZombieSunConfirm"
        Me.ZombieSunConfirm.Size = New System.Drawing.Size(86, 30)
        Me.ZombieSunConfirm.TabIndex = 31
        Me.ZombieSunConfirm.Text = "修改"
        Me.ZombieSunConfirm.UseVisualStyleBackColor = True
        '
        'ZombieCardSun
        '
        Me.ZombieCardSun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ZombieCardSun.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ZombieCardSun.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.ZombieCardSun.Location = New System.Drawing.Point(209, 72)
        Me.ZombieCardSun.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.ZombieCardSun.MaxLength = 4
        Me.ZombieCardSun.Name = "ZombieCardSun"
        Me.ZombieCardSun.ShortcutsEnabled = False
        Me.ZombieCardSun.Size = New System.Drawing.Size(64, 25)
        Me.ZombieCardSun.TabIndex = 30
        '
        'ZombieCardSunType
        '
        Me.ZombieCardSunType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ZombieCardSunType.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ZombieCardSunType.FormattingEnabled = True
        Me.ZombieCardSunType.Items.AddRange(New Object() {"普僵/小鬼", "路障/撑杆", "舞王", "铁桶/矿工/蹦极", "扶梯/气球", "橄榄/冰车", "巨人", "铁门", "跳跳"})
        Me.ZombieCardSunType.Location = New System.Drawing.Point(89, 70)
        Me.ZombieCardSunType.Name = "ZombieCardSunType"
        Me.ZombieCardSunType.Size = New System.Drawing.Size(110, 27)
        Me.ZombieCardSunType.TabIndex = 29
        '
        'LabelZombieCardSun
        '
        Me.LabelZombieCardSun.AutoSize = True
        Me.LabelZombieCardSun.BackColor = System.Drawing.Color.Transparent
        Me.LabelZombieCardSun.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.LabelZombieCardSun.ForeColor = System.Drawing.Color.Indigo
        Me.LabelZombieCardSun.Location = New System.Drawing.Point(9, 72)
        Me.LabelZombieCardSun.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LabelZombieCardSun.Name = "LabelZombieCardSun"
        Me.LabelZombieCardSun.Size = New System.Drawing.Size(74, 21)
        Me.LabelZombieCardSun.TabIndex = 28
        Me.LabelZombieCardSun.Text = "僵尸阳光"
        '
        'ReplaceConfirm
        '
        Me.ReplaceConfirm.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.ReplaceConfirm.ForeColor = System.Drawing.Color.Black
        Me.ReplaceConfirm.Location = New System.Drawing.Point(255, 29)
        Me.ReplaceConfirm.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.ReplaceConfirm.Name = "ReplaceConfirm"
        Me.ReplaceConfirm.Size = New System.Drawing.Size(50, 30)
        Me.ReplaceConfirm.TabIndex = 27
        Me.ReplaceConfirm.Text = "替换"
        Me.ReplaceConfirm.UseVisualStyleBackColor = True
        '
        'ReplaceA
        '
        Me.ReplaceA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ReplaceA.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ReplaceA.FormattingEnabled = True
        Me.ReplaceA.Items.AddRange(New Object() {"普僵", "路障", "撑杆", "铁桶", "扶梯", "矿工", "蹦极僵", "橄榄", "气球", "铁门", "冰车", "跳跳", "舞王", "巨人", "小鬼"})
        Me.ReplaceA.Location = New System.Drawing.Point(55, 30)
        Me.ReplaceA.Name = "ReplaceA"
        Me.ReplaceA.Size = New System.Drawing.Size(60, 27)
        Me.ReplaceA.TabIndex = 25
        '
        'ReplaceB
        '
        Me.ReplaceB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ReplaceB.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ReplaceB.FormattingEnabled = True
        Me.ReplaceB.Items.AddRange(New Object() {"普僵", "旗帜", "路障", "撑杆", "铁桶", "读报", "铁门", "橄榄", "舞王", "伴舞", "鸭子", "潜水", "冰车", "雪橇小队", "海豚", "小丑", "气球", "矿工", "跳跳", "雪人", "蹦极", "扶梯", "投石车", "巨人", "小鬼", "僵王", "豌豆僵尸", "坚果僵尸", "辣椒僵尸", "机枪僵尸", "窝瓜僵尸", "高坚果僵尸", "红眼巨人"})
        Me.ReplaceB.Location = New System.Drawing.Point(153, 30)
        Me.ReplaceB.Name = "ReplaceB"
        Me.ReplaceB.Size = New System.Drawing.Size(90, 27)
        Me.ReplaceB.TabIndex = 26
        '
        'LabelSwitchZombieTo
        '
        Me.LabelSwitchZombieTo.AutoSize = True
        Me.LabelSwitchZombieTo.BackColor = System.Drawing.Color.Transparent
        Me.LabelSwitchZombieTo.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.LabelSwitchZombieTo.ForeColor = System.Drawing.Color.Indigo
        Me.LabelSwitchZombieTo.Location = New System.Drawing.Point(9, 32)
        Me.LabelSwitchZombieTo.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LabelSwitchZombieTo.Name = "LabelSwitchZombieTo"
        Me.LabelSwitchZombieTo.Size = New System.Drawing.Size(138, 21)
        Me.LabelSwitchZombieTo.TabIndex = 24
        Me.LabelSwitchZombieTo.Text = "替换                为"
        '
        'LevelCodeOutPut
        '
        Me.LevelCodeOutPut.Controls.Add(Me.EnterCode)
        Me.LevelCodeOutPut.Controls.Add(Me.ClearText)
        Me.LevelCodeOutPut.Controls.Add(Me.ReadCode)
        Me.LevelCodeOutPut.Controls.Add(Me.CodeState)
        Me.LevelCodeOutPut.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LevelCodeOutPut.ForeColor = System.Drawing.Color.Indigo
        Me.LevelCodeOutPut.Location = New System.Drawing.Point(10, 411)
        Me.LevelCodeOutPut.Name = "LevelCodeOutPut"
        Me.LevelCodeOutPut.Size = New System.Drawing.Size(550, 65)
        Me.LevelCodeOutPut.TabIndex = 43
        Me.LevelCodeOutPut.TabStop = False
        Me.LevelCodeOutPut.Text = "关卡代码      "
        '
        'EnterCode
        '
        Me.EnterCode.BackColor = System.Drawing.Color.WhiteSmoke
        Me.EnterCode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EnterCode.ContextMenuStrip = Me.RightClickEnterCode
        Me.EnterCode.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.EnterCode.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.EnterCode.Location = New System.Drawing.Point(14, 26)
        Me.EnterCode.MaxLength = 2000
        Me.EnterCode.Multiline = False
        Me.EnterCode.Name = "EnterCode"
        Me.EnterCode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.EnterCode.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.EnterCode.Size = New System.Drawing.Size(441, 25)
        Me.EnterCode.TabIndex = 44
        Me.EnterCode.Text = ""
        '
        'ClearText
        '
        Me.ClearText.BackColor = System.Drawing.Color.Transparent
        Me.ClearText.Cursor = System.Windows.Forms.Cursors.Default
        Me.ClearText.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearText.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.ClearText.ForeColor = System.Drawing.Color.Indigo
        Me.ClearText.Image = Global.IZ_Format_Designer_V2.My.Resources.Resources.Cross
        Me.ClearText.Location = New System.Drawing.Point(455, 26)
        Me.ClearText.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ClearText.Name = "ClearText"
        Me.ClearText.Size = New System.Drawing.Size(25, 25)
        Me.ClearText.TabIndex = 45
        Me.ClearText.UseVisualStyleBackColor = False
        '
        'ReadCode
        '
        Me.ReadCode.BackColor = System.Drawing.Color.Indigo
        Me.ReadCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReadCode.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.ReadCode.ForeColor = System.Drawing.Color.White
        Me.ReadCode.Location = New System.Drawing.Point(483, 18)
        Me.ReadCode.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ReadCode.Name = "ReadCode"
        Me.ReadCode.Size = New System.Drawing.Size(58, 39)
        Me.ReadCode.TabIndex = 46
        Me.ReadCode.Text = "生成"
        Me.ReadCode.UseVisualStyleBackColor = False
        '
        'MagTimer
        '
        Me.MagTimer.Controls.Add(Me.M5XY)
        Me.MagTimer.Controls.Add(Me.M4XY)
        Me.MagTimer.Controls.Add(Me.M3XY)
        Me.MagTimer.Controls.Add(Me.M2XY)
        Me.MagTimer.Controls.Add(Me.M1XY)
        Me.MagTimer.Controls.Add(Me.Mtimer5)
        Me.MagTimer.Controls.Add(Me.Mtimer4)
        Me.MagTimer.Controls.Add(Me.Mtimer3)
        Me.MagTimer.Controls.Add(Me.Mtimer2)
        Me.MagTimer.Controls.Add(Me.Mtimer1)
        Me.MagTimer.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.MagTimer.ForeColor = System.Drawing.Color.Indigo
        Me.MagTimer.Location = New System.Drawing.Point(250, 8)
        Me.MagTimer.Margin = New System.Windows.Forms.Padding(5, 8, 5, 8)
        Me.MagTimer.Name = "MagTimer"
        Me.MagTimer.Padding = New System.Windows.Forms.Padding(5, 8, 5, 8)
        Me.MagTimer.Size = New System.Drawing.Size(310, 56)
        Me.MagTimer.TabIndex = 5
        Me.MagTimer.TabStop = False
        Me.MagTimer.Text = "磁铁倒计时"
        '
        'M5XY
        '
        Me.M5XY.AutoSize = True
        Me.M5XY.BackColor = System.Drawing.Color.Transparent
        Me.M5XY.Font = New System.Drawing.Font("微软雅黑", 7.0!)
        Me.M5XY.ForeColor = System.Drawing.Color.Indigo
        Me.M5XY.Location = New System.Drawing.Point(264, 36)
        Me.M5XY.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.M5XY.Name = "M5XY"
        Me.M5XY.Size = New System.Drawing.Size(23, 16)
        Me.M5XY.TabIndex = 15
        Me.M5XY.Text = "X-Y"
        '
        'M4XY
        '
        Me.M4XY.AutoSize = True
        Me.M4XY.BackColor = System.Drawing.Color.Transparent
        Me.M4XY.Font = New System.Drawing.Font("微软雅黑", 7.0!)
        Me.M4XY.ForeColor = System.Drawing.Color.Indigo
        Me.M4XY.Location = New System.Drawing.Point(201, 36)
        Me.M4XY.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.M4XY.Name = "M4XY"
        Me.M4XY.Size = New System.Drawing.Size(23, 16)
        Me.M4XY.TabIndex = 14
        Me.M4XY.Text = "X-Y"
        '
        'M3XY
        '
        Me.M3XY.AutoSize = True
        Me.M3XY.BackColor = System.Drawing.Color.Transparent
        Me.M3XY.Font = New System.Drawing.Font("微软雅黑", 7.0!)
        Me.M3XY.ForeColor = System.Drawing.Color.Indigo
        Me.M3XY.Location = New System.Drawing.Point(138, 36)
        Me.M3XY.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.M3XY.Name = "M3XY"
        Me.M3XY.Size = New System.Drawing.Size(23, 16)
        Me.M3XY.TabIndex = 13
        Me.M3XY.Text = "X-Y"
        '
        'M2XY
        '
        Me.M2XY.AutoSize = True
        Me.M2XY.BackColor = System.Drawing.Color.Transparent
        Me.M2XY.Font = New System.Drawing.Font("微软雅黑", 7.0!)
        Me.M2XY.ForeColor = System.Drawing.Color.Indigo
        Me.M2XY.Location = New System.Drawing.Point(75, 36)
        Me.M2XY.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.M2XY.Name = "M2XY"
        Me.M2XY.Size = New System.Drawing.Size(23, 16)
        Me.M2XY.TabIndex = 12
        Me.M2XY.Text = "X-Y"
        '
        'M1XY
        '
        Me.M1XY.AutoSize = True
        Me.M1XY.BackColor = System.Drawing.Color.Transparent
        Me.M1XY.Font = New System.Drawing.Font("微软雅黑", 7.0!)
        Me.M1XY.ForeColor = System.Drawing.Color.Indigo
        Me.M1XY.Location = New System.Drawing.Point(12, 36)
        Me.M1XY.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.M1XY.Name = "M1XY"
        Me.M1XY.Size = New System.Drawing.Size(23, 16)
        Me.M1XY.TabIndex = 11
        Me.M1XY.Text = "X-Y"
        '
        'Mtimer5
        '
        Me.Mtimer5.AutoSize = True
        Me.Mtimer5.Font = New System.Drawing.Font("微软雅黑", 11.5!)
        Me.Mtimer5.ForeColor = System.Drawing.Color.Black
        Me.Mtimer5.Location = New System.Drawing.Point(262, 18)
        Me.Mtimer5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Mtimer5.Name = "Mtimer5"
        Me.Mtimer5.Size = New System.Drawing.Size(31, 21)
        Me.Mtimer5.TabIndex = 10
        Me.Mtimer5.Text = "---"
        '
        'Mtimer4
        '
        Me.Mtimer4.AutoSize = True
        Me.Mtimer4.Font = New System.Drawing.Font("微软雅黑", 11.5!)
        Me.Mtimer4.ForeColor = System.Drawing.Color.Black
        Me.Mtimer4.Location = New System.Drawing.Point(199, 18)
        Me.Mtimer4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Mtimer4.Name = "Mtimer4"
        Me.Mtimer4.Size = New System.Drawing.Size(31, 21)
        Me.Mtimer4.TabIndex = 9
        Me.Mtimer4.Text = "---"
        '
        'Mtimer3
        '
        Me.Mtimer3.AutoSize = True
        Me.Mtimer3.Font = New System.Drawing.Font("微软雅黑", 11.5!)
        Me.Mtimer3.ForeColor = System.Drawing.Color.Black
        Me.Mtimer3.Location = New System.Drawing.Point(136, 18)
        Me.Mtimer3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Mtimer3.Name = "Mtimer3"
        Me.Mtimer3.Size = New System.Drawing.Size(31, 21)
        Me.Mtimer3.TabIndex = 8
        Me.Mtimer3.Text = "---"
        '
        'Mtimer2
        '
        Me.Mtimer2.AutoSize = True
        Me.Mtimer2.Font = New System.Drawing.Font("微软雅黑", 11.5!)
        Me.Mtimer2.ForeColor = System.Drawing.Color.Black
        Me.Mtimer2.Location = New System.Drawing.Point(73, 18)
        Me.Mtimer2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Mtimer2.Name = "Mtimer2"
        Me.Mtimer2.Size = New System.Drawing.Size(31, 21)
        Me.Mtimer2.TabIndex = 7
        Me.Mtimer2.Text = "---"
        '
        'Mtimer1
        '
        Me.Mtimer1.AutoSize = True
        Me.Mtimer1.Font = New System.Drawing.Font("微软雅黑", 11.5!)
        Me.Mtimer1.ForeColor = System.Drawing.Color.Black
        Me.Mtimer1.Location = New System.Drawing.Point(10, 18)
        Me.Mtimer1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Mtimer1.Name = "Mtimer1"
        Me.Mtimer1.Size = New System.Drawing.Size(31, 21)
        Me.Mtimer1.TabIndex = 6
        Me.Mtimer1.Text = "---"
        '
        'BasicSetting
        '
        Me.BasicSetting.Controls.Add(Me.SunToMax)
        Me.BasicSetting.Controls.Add(Me.RedLineInfo)
        Me.BasicSetting.Controls.Add(Me.SwitchintoIZE)
        Me.BasicSetting.Controls.Add(Me.ZomCard)
        Me.BasicSetting.Controls.Add(Me.LableSetCard)
        Me.BasicSetting.Controls.Add(Me.CardSlotInfo)
        Me.BasicSetting.Controls.Add(Me.SunConfirm)
        Me.BasicSetting.Controls.Add(Me.ModifySun)
        Me.BasicSetting.Controls.Add(Me.RedLineBar)
        Me.BasicSetting.Controls.Add(Me.SunTo2K)
        Me.BasicSetting.Controls.Add(Me.LableSun)
        Me.BasicSetting.Controls.Add(Me.CardSlotBar)
        Me.BasicSetting.Controls.Add(Me.ZombieType)
        Me.BasicSetting.Controls.Add(Me.LableCardSlot)
        Me.BasicSetting.Controls.Add(Me.LableRedLine)
        Me.BasicSetting.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BasicSetting.ForeColor = System.Drawing.Color.Indigo
        Me.BasicSetting.Location = New System.Drawing.Point(10, 71)
        Me.BasicSetting.Margin = New System.Windows.Forms.Padding(5, 8, 5, 8)
        Me.BasicSetting.Name = "BasicSetting"
        Me.BasicSetting.Padding = New System.Windows.Forms.Padding(5, 8, 5, 8)
        Me.BasicSetting.Size = New System.Drawing.Size(376, 141)
        Me.BasicSetting.TabIndex = 9
        Me.BasicSetting.TabStop = False
        Me.BasicSetting.Text = "基础设置"
        '
        'SunToMax
        '
        Me.SunToMax.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SunToMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SunToMax.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.SunToMax.Location = New System.Drawing.Point(292, 25)
        Me.SunToMax.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.SunToMax.Name = "SunToMax"
        Me.SunToMax.Size = New System.Drawing.Size(75, 28)
        Me.SunToMax.TabIndex = 23
        Me.SunToMax.Text = "10000"
        Me.SunToMax.UseVisualStyleBackColor = False
        '
        'RedLineInfo
        '
        Me.RedLineInfo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RedLineInfo.AutoSize = True
        Me.RedLineInfo.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.RedLineInfo.Location = New System.Drawing.Point(238, 107)
        Me.RedLineInfo.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.RedLineInfo.Name = "RedLineInfo"
        Me.RedLineInfo.Size = New System.Drawing.Size(0, 22)
        Me.RedLineInfo.TabIndex = 21
        '
        'ZomCard
        '
        Me.ZomCard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ZomCard.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ZomCard.FormattingEnabled = True
        Me.ZomCard.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.ZomCard.Location = New System.Drawing.Point(58, 67)
        Me.ZomCard.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.ZomCard.Name = "ZomCard"
        Me.ZomCard.Size = New System.Drawing.Size(42, 27)
        Me.ZomCard.TabIndex = 18
        '
        'LableSetCard
        '
        Me.LableSetCard.AutoSize = True
        Me.LableSetCard.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.LableSetCard.Location = New System.Drawing.Point(9, 69)
        Me.LableSetCard.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LableSetCard.Name = "LableSetCard"
        Me.LableSetCard.Size = New System.Drawing.Size(144, 21)
        Me.LableSetCard.TabIndex = 17
        Me.LableSetCard.Text = "卡槽              改为"
        '
        'CardSlotInfo
        '
        Me.CardSlotInfo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CardSlotInfo.AutoSize = True
        Me.CardSlotInfo.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CardSlotInfo.Location = New System.Drawing.Point(45, 108)
        Me.CardSlotInfo.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.CardSlotInfo.Name = "CardSlotInfo"
        Me.CardSlotInfo.Size = New System.Drawing.Size(0, 22)
        Me.CardSlotInfo.TabIndex = 15
        '
        'SunConfirm
        '
        Me.SunConfirm.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.SunConfirm.ForeColor = System.Drawing.Color.Black
        Me.SunConfirm.Location = New System.Drawing.Point(145, 24)
        Me.SunConfirm.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.SunConfirm.Name = "SunConfirm"
        Me.SunConfirm.Size = New System.Drawing.Size(62, 30)
        Me.SunConfirm.TabIndex = 12
        Me.SunConfirm.Text = "修改"
        Me.SunConfirm.UseVisualStyleBackColor = True
        '
        'ModifySun
        '
        Me.ModifySun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ModifySun.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ModifySun.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.ModifySun.Location = New System.Drawing.Point(58, 26)
        Me.ModifySun.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.ModifySun.MaxLength = 5
        Me.ModifySun.Name = "ModifySun"
        Me.ModifySun.ShortcutsEnabled = False
        Me.ModifySun.Size = New System.Drawing.Size(77, 25)
        Me.ModifySun.TabIndex = 11
        Me.ModifySun.Text = "150"
        '
        'RedLineBar
        '
        Me.RedLineBar.AutoSize = False
        Me.RedLineBar.BackColor = System.Drawing.Color.White
        Me.RedLineBar.LargeChange = 1
        Me.RedLineBar.Location = New System.Drawing.Point(253, 104)
        Me.RedLineBar.Maximum = 9
        Me.RedLineBar.Name = "RedLineBar"
        Me.RedLineBar.Size = New System.Drawing.Size(120, 29)
        Me.RedLineBar.TabIndex = 22
        Me.RedLineBar.Value = 5
        '
        'SunTo2K
        '
        Me.SunTo2K.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SunTo2K.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SunTo2K.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.SunTo2K.Location = New System.Drawing.Point(217, 25)
        Me.SunTo2K.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.SunTo2K.Name = "SunTo2K"
        Me.SunTo2K.Size = New System.Drawing.Size(65, 28)
        Me.SunTo2K.TabIndex = 13
        Me.SunTo2K.Text = "2000"
        Me.SunTo2K.UseVisualStyleBackColor = False
        '
        'LableSun
        '
        Me.LableSun.AutoSize = True
        Me.LableSun.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.LableSun.ForeColor = System.Drawing.Color.Indigo
        Me.LableSun.Location = New System.Drawing.Point(9, 28)
        Me.LableSun.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LableSun.Name = "LableSun"
        Me.LableSun.Size = New System.Drawing.Size(42, 21)
        Me.LableSun.TabIndex = 10
        Me.LableSun.Text = "阳光"
        '
        'CardSlotBar
        '
        Me.CardSlotBar.AutoSize = False
        Me.CardSlotBar.BackColor = System.Drawing.Color.White
        Me.CardSlotBar.LargeChange = 1
        Me.CardSlotBar.Location = New System.Drawing.Point(67, 104)
        Me.CardSlotBar.Name = "CardSlotBar"
        Me.CardSlotBar.Size = New System.Drawing.Size(131, 29)
        Me.CardSlotBar.TabIndex = 16
        Me.CardSlotBar.Value = 6
        '
        'ZombieType
        '
        Me.ZombieType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ZombieType.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ZombieType.FormattingEnabled = True
        Me.ZombieType.Items.AddRange(New Object() {"", "小鬼", "普僵", "路障", "撑杆", "铁门", "铁桶", "矿工", "蹦极", "扶梯", "气球", "橄榄", "舞王", "巨人", "冰车", "跳跳", "", "豌豆/普僵", "向日葵/摇旗", "樱桃/路障", "坚果/撑杆", "土豆雷/铁桶", "寒冰/读报", "大嘴/铁门", "双发/橄榄", "小喷/舞王", "阳光菇/伴舞", "大喷/救生圈", "墓碑吞/潜水", "魅惑/冰车", "胆小/雪橇小队", "寒冰菇/海豚", "毁灭菇/小丑", "睡莲/气球", "窝瓜/矿工", "三线/跳跳", "海草/雪人", "辣椒/蹦极", "地刺/扶梯", "火炬/投石车", "高坚果/巨人", "海蘑菇/小鬼", "路灯花/僵王", "仙人掌/豌豆僵尸", "三叶草/坚果墙僵尸", "裂荚/辣椒僵尸", "杨桃/机枪僵尸", "南瓜头/窝瓜僵尸", "磁力菇/高坚果僵尸", "卷心菜/红眼"})
        Me.ZombieType.Location = New System.Drawing.Point(162, 66)
        Me.ZombieType.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.ZombieType.Name = "ZombieType"
        Me.ZombieType.Size = New System.Drawing.Size(120, 27)
        Me.ZombieType.TabIndex = 19
        '
        'LableCardSlot
        '
        Me.LableCardSlot.AutoSize = True
        Me.LableCardSlot.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.LableCardSlot.Location = New System.Drawing.Point(9, 107)
        Me.LableCardSlot.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LableCardSlot.Name = "LableCardSlot"
        Me.LableCardSlot.Size = New System.Drawing.Size(42, 21)
        Me.LableCardSlot.TabIndex = 14
        Me.LableCardSlot.Text = "卡槽"
        '
        'LableRedLine
        '
        Me.LableRedLine.AutoSize = True
        Me.LableRedLine.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.LableRedLine.Location = New System.Drawing.Point(199, 107)
        Me.LableRedLine.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LableRedLine.Name = "LableRedLine"
        Me.LableRedLine.Size = New System.Drawing.Size(42, 21)
        Me.LableRedLine.TabIndex = 20
        Me.LableRedLine.Text = "红线"
        '
        'StateInfo
        '
        Me.StateInfo.Controls.Add(Me.GameState)
        Me.StateInfo.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.StateInfo.ForeColor = System.Drawing.Color.Indigo
        Me.StateInfo.Location = New System.Drawing.Point(125, 8)
        Me.StateInfo.Margin = New System.Windows.Forms.Padding(5, 8, 5, 8)
        Me.StateInfo.Name = "StateInfo"
        Me.StateInfo.Padding = New System.Windows.Forms.Padding(5, 8, 5, 8)
        Me.StateInfo.Size = New System.Drawing.Size(115, 56)
        Me.StateInfo.TabIndex = 2
        Me.StateInfo.TabStop = False
        Me.StateInfo.Text = "游戏状态"
        '
        'GameState
        '
        Me.GameState.AutoSize = True
        Me.GameState.BackColor = System.Drawing.Color.Transparent
        Me.GameState.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GameState.ForeColor = System.Drawing.Color.SlateBlue
        Me.GameState.Location = New System.Drawing.Point(13, 24)
        Me.GameState.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.GameState.Name = "GameState"
        Me.GameState.Size = New System.Drawing.Size(90, 21)
        Me.GameState.TabIndex = 3
        Me.GameState.Text = "未找到游戏"
        '
        'MyTab
        '
        Me.MyTab.Controls.Add(Me.Basic)
        Me.MyTab.Controls.Add(Me.Design)
        Me.MyTab.Controls.Add(Me.Levels)
        Me.MyTab.Controls.Add(Me.Settings)
        Me.MyTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyTab.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.MyTab.HotTrack = True
        Me.MyTab.Location = New System.Drawing.Point(0, 0)
        Me.MyTab.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MyTab.Name = "MyTab"
        Me.MyTab.Padding = New System.Drawing.Point(48, 6)
        Me.MyTab.SelectedIndex = 0
        Me.MyTab.Size = New System.Drawing.Size(579, 521)
        Me.MyTab.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.MyTab.TabIndex = 1
        '
        'IZEStateChecker
        '
        Me.IZEStateChecker.Interval = 300
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button1.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(379, 89)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 35)
        Me.Button1.TabIndex = 135
        Me.Button1.Text = "测试按钮"
        Me.Tips.SetToolTip(Me.Button1, "如遇因存档错误导致关卡无法进入，请打开存档目录自行删除关卡存档")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(579, 521)
        Me.Controls.Add(Me.MyTab)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.Text = "我是僵尸布阵器"
        Me.RightClickEnterCode.ResumeLayout(False)
        Me.Settings.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.KeyingGB.ResumeLayout(False)
        Me.KeyingGB.PerformLayout()
        Me.About.ResumeLayout(False)
        Me.About.PerformLayout()
        CType(Me.WinkleLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FormingGB.ResumeLayout(False)
        Me.FormingGB.PerformLayout()
        Me.NormalizeGB.ResumeLayout(False)
        Me.NormalizeGB.PerformLayout()
        CType(Me.SpeedIndex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Levels.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GBLevelCollection.ResumeLayout(False)
        Me.GBLevelCollection.PerformLayout()
        Me.Design.ResumeLayout(False)
        Me.PlantsTransform.ResumeLayout(False)
        Me.PlantsTransform.PerformLayout()
        Me.PortalDesign.ResumeLayout(False)
        Me.PortalDesign.PerformLayout()
        CType(Me.PicturePBA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicturePBB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicturePWA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicturePWB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PlantMode.ResumeLayout(False)
        Me.PlantMode.PerformLayout()
        Me.ChoosePlant.ResumeLayout(False)
        Me.ChoosePlant.PerformLayout()
        CType(Me.Selected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card49, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card50, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card51, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card52, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card53, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card54, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card55, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card56, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card46, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card47, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card48, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Basic.ResumeLayout(False)
        Me.QuickClick.ResumeLayout(False)
        Me.QuickClick.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ZombieCardEditGB.ResumeLayout(False)
        Me.ZombieCardEditGB.PerformLayout()
        Me.LevelCodeOutPut.ResumeLayout(False)
        Me.LevelCodeOutPut.PerformLayout()
        Me.MagTimer.ResumeLayout(False)
        Me.MagTimer.PerformLayout()
        Me.BasicSetting.ResumeLayout(False)
        Me.BasicSetting.PerformLayout()
        CType(Me.RedLineBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CardSlotBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StateInfo.ResumeLayout(False)
        Me.StateInfo.PerformLayout()
        Me.MyTab.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MagnetT As Timer
    Friend WithEvents FinderMagnet As Timer
    Friend WithEvents CleanStateText As Timer
    Friend WithEvents RightClickEnterCode As ContextMenuStrip
    Friend WithEvents 粘贴CtrlVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 复制内容ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 清空ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 粘贴并生成ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlantDeltaTime As Timer
    Friend WithEvents MouseMoveDetector As Timer
    Friend WithEvents DeleteReset As Timer
    Friend WithEvents Tips As ToolTip
    Friend WithEvents SunRefresher As Timer
    Friend WithEvents Settings As TabPage
    Friend WithEvents About As GroupBox
    Friend WithEvents LabelTips As Label
    Friend WithEvents UpdateInfoButton As Button
    Friend WithEvents VideoButton As Button
    Friend WithEvents LabelVersion As Label
    Friend WithEvents LabelWarn As Label
    Friend WithEvents LabelWelcome As Label
    Friend WithEvents AboutUs As Label
    Friend WithEvents FormingGB As GroupBox
    Friend WithEvents IZECardOnly As CheckBox
    Friend WithEvents ResetKeySet As Button
    Friend WithEvents SpeedUpKeyEdit As ComboBox
    Friend WithEvents LabelSpeedUp As Label
    Friend WithEvents ShovelOnceKeyEdit As ComboBox
    Friend WithEvents ExchangeKeys As Button
    Friend WithEvents LabelOnce As Label
    Friend WithEvents PlantKeyEdit As ComboBox
    Friend WithEvents LabelChangeKeyPlant As Label
    Friend WithEvents RealPlants As CheckBox
    Friend WithEvents ManualCtrl As CheckBox
    Friend WithEvents NormalizeGB As GroupBox
    Friend WithEvents AutoPaste As CheckBox
    Friend WithEvents MagnetTimerSwitch As CheckBox
    Friend WithEvents ResetProgramme As Button
    Friend WithEvents Levels As TabPage
    Friend WithEvents CopyMyCode As Button
    Friend WithEvents LevelStateinInformation As Label
    Friend WithEvents CopyYourLevelInfo As Button
    Friend WithEvents YourLevelCode As TextBox
    Friend WithEvents LabelLevelCodeinInformation As Label
    Friend WithEvents YourLevelDescription As TextBox
    Friend WithEvents CBLevelDifficulty As ComboBox
    Friend WithEvents LabelLevelDescription As Label
    Friend WithEvents LabelDifficulty As Label
    Friend WithEvents SaveYourLevel As Button
    Friend WithEvents YourName As TextBox
    Friend WithEvents LabelLevelDesigner As Label
    Friend WithEvents YourLevelName As TextBox
    Friend WithEvents LabelLevelName As Label
    Friend WithEvents GenerateThisLevel As Button
    Friend WithEvents ResetYourLevel As Button
    Friend WithEvents ResetYourLevel_ConfirmF As Button
    Friend WithEvents ResetYourLevel_ConfirmT As Button
    Friend WithEvents GBLevelCollection As GroupBox
    Friend WithEvents LevelCollectionListBox As ListBox
    Friend WithEvents LevelListView As ListView
    Friend WithEvents ColumnLevelIndex As ColumnHeader
    Friend WithEvents ColumnLevelName As ColumnHeader
    Friend WithEvents ColumnLevelDesigner As ColumnHeader
    Friend WithEvents ColumnLevelDifficulty As ColumnHeader
    Friend WithEvents Design As TabPage
    Friend WithEvents Selected As PictureBox
    Friend WithEvents PortalDesign As GroupBox
    Friend WithEvents PBBY As ComboBox
    Friend WithEvents PBBX As ComboBox
    Friend WithEvents PBAY As ComboBox
    Friend WithEvents PBAX As ComboBox
    Friend WithEvents PWBY As ComboBox
    Friend WithEvents PWBX As ComboBox
    Friend WithEvents ActivePortal As CheckBox
    Friend WithEvents LabelPBBY As Label
    Friend WithEvents LabelPBBX As Label
    Friend WithEvents LabelPBAY As Label
    Friend WithEvents LabelPBAX As Label
    Friend WithEvents PicturePBA As PictureBox
    Friend WithEvents CreatePortalButton As Button
    Friend WithEvents PicturePWB As PictureBox
    Friend WithEvents PicturePBB As PictureBox
    Friend WithEvents LabelPWBY As Label
    Friend WithEvents LabelPWBX As Label
    Friend WithEvents PlantMode As GroupBox
    Friend WithEvents PlantSwitchText As Label
    Friend WithEvents PlantSwitch As CheckBox
    Friend WithEvents ChoosePlant As GroupBox
    Friend WithEvents SelectedPlantName As Label
    Friend WithEvents Card49 As PictureBox
    Friend WithEvents Card50 As PictureBox
    Friend WithEvents Card51 As PictureBox
    Friend WithEvents Card52 As PictureBox
    Friend WithEvents Card53 As PictureBox
    Friend WithEvents Card54 As PictureBox
    Friend WithEvents Card55 As PictureBox
    Friend WithEvents Card56 As PictureBox
    Friend WithEvents Card41 As PictureBox
    Friend WithEvents Card42 As PictureBox
    Friend WithEvents Card43 As PictureBox
    Friend WithEvents Card44 As PictureBox
    Friend WithEvents Card45 As PictureBox
    Friend WithEvents Card46 As PictureBox
    Friend WithEvents Card47 As PictureBox
    Friend WithEvents Card48 As PictureBox
    Friend WithEvents Card33 As PictureBox
    Friend WithEvents Card34 As PictureBox
    Friend WithEvents Card35 As PictureBox
    Friend WithEvents Card36 As PictureBox
    Friend WithEvents Card37 As PictureBox
    Friend WithEvents Card38 As PictureBox
    Friend WithEvents Card39 As PictureBox
    Friend WithEvents Card40 As PictureBox
    Friend WithEvents Card25 As PictureBox
    Friend WithEvents Card26 As PictureBox
    Friend WithEvents Card27 As PictureBox
    Friend WithEvents Card28 As PictureBox
    Friend WithEvents Card29 As PictureBox
    Friend WithEvents Card30 As PictureBox
    Friend WithEvents Card31 As PictureBox
    Friend WithEvents Card32 As PictureBox
    Friend WithEvents Card17 As PictureBox
    Friend WithEvents Card18 As PictureBox
    Friend WithEvents Card19 As PictureBox
    Friend WithEvents Card20 As PictureBox
    Friend WithEvents Card21 As PictureBox
    Friend WithEvents Card22 As PictureBox
    Friend WithEvents Card23 As PictureBox
    Friend WithEvents Card24 As PictureBox
    Friend WithEvents Card9 As PictureBox
    Friend WithEvents Card10 As PictureBox
    Friend WithEvents Card11 As PictureBox
    Friend WithEvents Card12 As PictureBox
    Friend WithEvents Card13 As PictureBox
    Friend WithEvents Card14 As PictureBox
    Friend WithEvents Card15 As PictureBox
    Friend WithEvents Card16 As PictureBox
    Friend WithEvents Card1 As PictureBox
    Friend WithEvents Card2 As PictureBox
    Friend WithEvents Card3 As PictureBox
    Friend WithEvents Card4 As PictureBox
    Friend WithEvents Card5 As PictureBox
    Friend WithEvents Card6 As PictureBox
    Friend WithEvents Card7 As PictureBox
    Friend WithEvents Card8 As PictureBox
    Friend WithEvents Basic As TabPage
    Friend WithEvents ZombieCardEditGB As GroupBox
    Friend WithEvents ResetZombieCardProperty As Button
    Friend WithEvents ZombieSunConfirm As Button
    Friend WithEvents ZombieCardSun As TextBox
    Friend WithEvents ZombieCardSunType As ComboBox
    Friend WithEvents LabelZombieCardSun As Label
    Friend WithEvents ReplaceConfirm As Button
    Friend WithEvents ReplaceA As ComboBox
    Friend WithEvents ReplaceB As ComboBox
    Friend WithEvents LabelSwitchZombieTo As Label
    Friend WithEvents LevelCodeOutPut As GroupBox
    Friend WithEvents EnterCode As RichTextBox
    Friend WithEvents ClearText As Button
    Friend WithEvents ReadCode As Button
    Friend WithEvents CodeState As Label
    Friend WithEvents AutoColletct As CheckBox
    Friend WithEvents Clear As Button
    Friend WithEvents CreateCodeAndCopy As Button
    Friend WithEvents KillAll As Button
    Friend WithEvents Fail As Button
    Friend WithEvents LockShovel As CheckBox
    Friend WithEvents MagTimer As GroupBox
    Friend WithEvents Mtimer3 As Label
    Friend WithEvents Mtimer2 As Label
    Friend WithEvents Mtimer1 As Label
    Friend WithEvents BasicSetting As GroupBox
    Friend WithEvents RedLineInfo As Label
    Friend WithEvents ZomCard As ComboBox
    Friend WithEvents LableSetCard As Label
    Friend WithEvents CardSlotInfo As Label
    Friend WithEvents SunConfirm As Button
    Friend WithEvents SwitchintoIZE As Button
    Friend WithEvents ModifySun As TextBox
    Friend WithEvents RedLineBar As TrackBar
    Friend WithEvents SunTo2K As Button
    Friend WithEvents LableSun As Label
    Friend WithEvents CardSlotBar As TrackBar
    Friend WithEvents ZombieType As ComboBox
    Friend WithEvents LableCardSlot As Label
    Friend WithEvents LableRedLine As Label
    Friend WithEvents StateInfo As GroupBox
    Friend WithEvents GameState As Label
    Friend WithEvents FindWindowAgain As Button
    Public WithEvents MyTab As TabControl
    Friend WithEvents CobNoCD As CheckBox
    Friend WithEvents LockKernel As CheckBox
    Friend WithEvents AllowPlants As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LockButter As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Mtimer5 As Label
    Friend WithEvents Mtimer4 As Label
    Friend WithEvents PWAY As ComboBox
    Friend WithEvents PWAX As ComboBox
    Friend WithEvents PicturePWA As PictureBox
    Friend WithEvents LabelPWAX As Label
    Friend WithEvents LabelPWAY As Label
    Friend WithEvents QuickClick As GroupBox
    Friend WithEvents SunToMax As Button
    Friend WithEvents NoCD As CheckBox
    Friend WithEvents PlantsTransform As GroupBox
    Friend WithEvents AutoFillPortalPos As CheckBox
    Friend WithEvents StatisticsInfo As Button
    Friend WithEvents SwCol2 As ComboBox
    Friend WithEvents SwCol1 As ComboBox
    Friend WithEvents SwRow2 As ComboBox
    Friend WithEvents SwRow1 As ComboBox
    Friend WithEvents SwitchCol As Button
    Friend WithEvents SwitchRow As Button
    Friend WithEvents LabelCol As Label
    Friend WithEvents LabelRow As Label
    Friend WithEvents KeyingGB As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents WinkleLogo As PictureBox
    Friend WithEvents TipsNumber As Label
    Friend WithEvents QLoad As Button
    Friend WithEvents QSave As Button
    Friend WithEvents PlantXY As Button
    Friend WithEvents PlantY As ComboBox
    Friend WithEvents PlantX As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents OpenWS As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DownloadWSLevel As Button
    Friend WithEvents WSLevelID As TextBox
    Friend WithEvents LabelLevelWSID As Label
    Friend WithEvents M1XY As Label
    Friend WithEvents M5XY As Label
    Friend WithEvents M4XY As Label
    Friend WithEvents M3XY As Label
    Friend WithEvents M2XY As Label
    Friend WithEvents SpeedUp As CheckBox
    Friend WithEvents Randomizer As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents RandomEndless As CheckBox
    Friend WithEvents IZEStateChecker As Timer
    Friend WithEvents RandIZEScore As Label
    Friend WithEvents SpeedIndexText As Label
    Friend WithEvents SpeedIndex As TrackBar
    Friend WithEvents SpeedIndexLabel As Label
    Friend WithEvents OpenSaveFold As Button
    Friend WithEvents Button1 As Button
End Class
