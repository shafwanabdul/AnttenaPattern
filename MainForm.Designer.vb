<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDirect
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDirect))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TS_ETH_TX = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSrtxstat = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSLSeparator = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Statusbarcon = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSLTTStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveSettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadDemoDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConnectTCPIPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RFMeasUnitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AntennaUnitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisconnectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GBSpecControl = New System.Windows.Forms.GroupBox()
        Me.GBOffset = New System.Windows.Forms.GroupBox()
        Me.BSetCorr = New System.Windows.Forms.Button()
        Me.BNormalize = New System.Windows.Forms.Button()
        Me.LAF = New System.Windows.Forms.Label()
        Me.TBAF = New System.Windows.Forms.TextBox()
        Me.LAntennaCorr = New System.Windows.Forms.Label()
        Me.BSetCor = New System.Windows.Forms.Button()
        Me.TBAntCorr = New System.Windows.Forms.TextBox()
        Me.TBAmpCorr = New System.Windows.Forms.TextBox()
        Me.LCableCorr = New System.Windows.Forms.Label()
        Me.TBUserCorr = New System.Windows.Forms.TextBox()
        Me.TBCableCorr = New System.Windows.Forms.TextBox()
        Me.LAmplifierCorr = New System.Windows.Forms.Label()
        Me.LUserCorr = New System.Windows.Forms.Label()
        Me.GBSAControl = New System.Windows.Forms.GroupBox()
        Me.CBBFStep = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBFStart = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBFStop = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBAttenuatorInt = New System.Windows.Forms.ComboBox()
        Me.LAtt = New System.Windows.Forms.Label()
        Me.LRBW = New System.Windows.Forms.Label()
        Me.CBRBW = New System.Windows.Forms.ComboBox()
        Me.CBTG = New System.Windows.Forms.CheckBox()
        Me.BSetSPACtrl = New System.Windows.Forms.Button()
        Me.CBRL = New System.Windows.Forms.ComboBox()
        Me.CBTGLvl = New System.Windows.Forms.ComboBox()
        Me.LRL = New System.Windows.Forms.Label()
        Me.LTGLvl = New System.Windows.Forms.Label()
        Me.GBControl = New System.Windows.Forms.GroupBox()
        Me.BReleaseMotor = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBStepSize = New System.Windows.Forms.ComboBox()
        Me.LAngleAP = New System.Windows.Forms.Label()
        Me.LAngle = New System.Windows.Forms.Label()
        Me.BTTSetCent = New System.Windows.Forms.Button()
        Me.BTT180 = New System.Windows.Forms.Button()
        Me.BTTCW = New System.Windows.Forms.Button()
        Me.BTT0 = New System.Windows.Forms.Button()
        Me.BTTCCW = New System.Windows.Forms.Button()
        Me.TimerAntennaPattern = New System.Windows.Forms.Timer(Me.components)
        Me.BConnect = New System.Windows.Forms.Button()
        Me.TextPort = New System.Windows.Forms.TextBox()
        Me.TextIP = New System.Windows.Forms.TextBox()
        Me.LIP = New System.Windows.Forms.Label()
        Me.LPort = New System.Windows.Forms.Label()
        Me.LMeasReceiver = New System.Windows.Forms.Label()
        Me.LDFAntenna = New System.Windows.Forms.Label()
        Me.LCOM = New System.Windows.Forms.Label()
        Me.GBComm = New System.Windows.Forms.GroupBox()
        Me.BScanPort = New System.Windows.Forms.Button()
        Me.CBComPort = New System.Windows.Forms.ComboBox()
        Me.BConTT = New System.Windows.Forms.Button()
        Me.TimerCheck = New System.Windows.Forms.Timer(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.BAPRport = New System.Windows.Forms.Button()
        Me.CLIncludeTable = New System.Windows.Forms.CheckBox()
        Me.BSaveReport = New System.Windows.Forms.Button()
        Me.BRptClr = New System.Windows.Forms.Button()
        Me.TAPolar = New System.Windows.Forms.TabPage()
        Me.GBLog = New System.Windows.Forms.GroupBox()
        Me.BAutoscalePol = New System.Windows.Forms.Button()
        Me.APTB = New System.Windows.Forms.TextBox()
        Me.CBPolAPYmax = New System.Windows.Forms.ComboBox()
        Me.LYminPolar = New System.Windows.Forms.Label()
        Me.CBPolAPYmin = New System.Windows.Forms.ComboBox()
        Me.LYmaxPolar = New System.Windows.Forms.Label()
        Me.GBAPPolar = New System.Windows.Forms.GroupBox()
        Me.CHAPP = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TXYAP = New System.Windows.Forms.TabPage()
        Me.CBmaxYax = New System.Windows.Forms.ComboBox()
        Me.LYmin = New System.Windows.Forms.Label()
        Me.CBminYax = New System.Windows.Forms.ComboBox()
        Me.LYmax = New System.Windows.Forms.Label()
        Me.GBBarChartLvlDF = New System.Windows.Forms.GroupBox()
        Me.CBTTH = New System.Windows.Forms.CheckBox()
        Me.ZedGraphAP = New ZedGraph.ZedGraphControl()
        Me.Func_tab = New System.Windows.Forms.TabControl()
        Me.Setting = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BStopAP = New System.Windows.Forms.Button()
        Me.BAntPattern = New System.Windows.Forms.Button()
        Me.GBAF = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CBBFreq = New System.Windows.Forms.ComboBox()
        Me.LPEIRP = New System.Windows.Forms.Label()
        Me.TBEIRPow = New System.Windows.Forms.TextBox()
        Me.TBDUTAG = New System.Windows.Forms.TextBox()
        Me.LDUTAG = New System.Windows.Forms.Label()
        Me.TBDUTAF = New System.Windows.Forms.TextBox()
        Me.TBFSL = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TBAFList = New System.Windows.Forms.TextBox()
        Me.BClearAFlist = New System.Windows.Forms.Button()
        Me.BSaveToCSvAFList = New System.Windows.Forms.Button()
        Me.BAddToListAPList = New System.Windows.Forms.Button()
        Me.LcalFSL = New System.Windows.Forms.Label()
        Me.LCorFac = New System.Windows.Forms.Label()
        Me.LMeasAF = New System.Windows.Forms.Label()
        Me.TBCorFac = New System.Windows.Forms.TextBox()
        Me.LPwrdBm = New System.Windows.Forms.Label()
        Me.TBPowerdBm = New System.Windows.Forms.TextBox()
        Me.LMeasDistance = New System.Windows.Forms.Label()
        Me.TBMeasDistance = New System.Windows.Forms.TextBox()
        Me.GBReport = New System.Windows.Forms.GroupBox()
        Me.LNamaDut = New System.Windows.Forms.Label()
        Me.LMerekDUT = New System.Windows.Forms.Label()
        Me.TBMerekDUT = New System.Windows.Forms.TextBox()
        Me.TBKomentar = New System.Windows.Forms.TextBox()
        Me.TBNamaDUT = New System.Windows.Forms.TextBox()
        Me.LOperator = New System.Windows.Forms.Label()
        Me.TBTipeDUT = New System.Windows.Forms.TextBox()
        Me.LTipeDUT = New System.Windows.Forms.Label()
        Me.TBOperator = New System.Windows.Forms.TextBox()
        Me.LKomentar = New System.Windows.Forms.Label()
        Me.LNoSeri = New System.Windows.Forms.Label()
        Me.TBNoSeri = New System.Windows.Forms.TextBox()
        Me.TXYFAF = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CBYmaxFAF = New System.Windows.Forms.ComboBox()
        Me.CBYminFAF = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ZedFAF = New ZedGraph.ZedGraphControl()
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.GBSpecControl.SuspendLayout()
        Me.GBOffset.SuspendLayout()
        Me.GBSAControl.SuspendLayout()
        Me.GBControl.SuspendLayout()
        Me.GBComm.SuspendLayout()
        Me.TAPolar.SuspendLayout()
        Me.GBLog.SuspendLayout()
        Me.GBAPPolar.SuspendLayout()
        CType(Me.CHAPP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TXYAP.SuspendLayout()
        Me.GBBarChartLvlDF.SuspendLayout()
        Me.Func_tab.SuspendLayout()
        Me.Setting.SuspendLayout()
        Me.GBAF.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GBReport.SuspendLayout()
        Me.TXYFAF.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.AllowItemReorder = True
        Me.StatusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TS_ETH_TX, Me.TSrtxstat, Me.TSSLSeparator, Me.Statusbarcon, Me.ToolStripStatusLabel4, Me.TSSLTTStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 554)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(828, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TS_ETH_TX
        '
        Me.TS_ETH_TX.Name = "TS_ETH_TX"
        Me.TS_ETH_TX.Size = New System.Drawing.Size(93, 17)
        Me.TS_ETH_TX.Text = "Send Command"
        '
        'TSrtxstat
        '
        Me.TSrtxstat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TSrtxstat.Name = "TSrtxstat"
        Me.TSrtxstat.Size = New System.Drawing.Size(134, 17)
        Me.TSrtxstat.Text = "SPA Link Status: Waiting"
        '
        'TSSLSeparator
        '
        Me.TSSLSeparator.Name = "TSSLSeparator"
        Me.TSSLSeparator.Size = New System.Drawing.Size(10, 17)
        Me.TSSLSeparator.Text = "|"
        '
        'Statusbarcon
        '
        Me.Statusbarcon.Name = "Statusbarcon"
        Me.Statusbarcon.Size = New System.Drawing.Size(72, 17)
        Me.Statusbarcon.Text = "Disconected"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(0, 17)
        '
        'TSSLTTStatus
        '
        Me.TSSLTTStatus.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSSLTTStatus.Name = "TSSLTTStatus"
        Me.TSSLTTStatus.Size = New System.Drawing.Size(151, 17)
        Me.TSSLTTStatus.Text = "                                                "
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(79, 17)
        Me.ToolStripStatusLabel1.Text = "Disconnected"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(45, 17)
        Me.ToolStripStatusLabel2.Text = "Device:"
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem1, Me.ToolsToolStripMenuItem, Me.TSMAbout})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip.Size = New System.Drawing.Size(828, 24)
        Me.MenuStrip.TabIndex = 1
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem1
        '
        Me.FileToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveSettingToolStripMenuItem, Me.ExitToolStripMenuItem2})
        Me.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1"
        Me.FileToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem1.Text = "File"
        '
        'SaveSettingToolStripMenuItem
        '
        Me.SaveSettingToolStripMenuItem.Name = "SaveSettingToolStripMenuItem"
        Me.SaveSettingToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.SaveSettingToolStripMenuItem.Text = "Save Setting"
        '
        'ExitToolStripMenuItem2
        '
        Me.ExitToolStripMenuItem2.Name = "ExitToolStripMenuItem2"
        Me.ExitToolStripMenuItem2.Size = New System.Drawing.Size(138, 22)
        Me.ExitToolStripMenuItem2.Text = "Exit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadDemoDataToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'LoadDemoDataToolStripMenuItem
        '
        Me.LoadDemoDataToolStripMenuItem.Name = "LoadDemoDataToolStripMenuItem"
        Me.LoadDemoDataToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.LoadDemoDataToolStripMenuItem.Text = "Load Demo data"
        '
        'TSMAbout
        '
        Me.TSMAbout.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem3})
        Me.TSMAbout.Name = "TSMAbout"
        Me.TSMAbout.Size = New System.Drawing.Size(52, 20)
        Me.TSMAbout.Text = "About"
        '
        'AboutToolStripMenuItem3
        '
        Me.AboutToolStripMenuItem3.Name = "AboutToolStripMenuItem3"
        Me.AboutToolStripMenuItem3.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem3.Text = "About"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartLogToolStripMenuItem, Me.SaveLogToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'StartLogToolStripMenuItem
        '
        Me.StartLogToolStripMenuItem.Name = "StartLogToolStripMenuItem"
        Me.StartLogToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.StartLogToolStripMenuItem.Text = "Start Log"
        '
        'SaveLogToolStripMenuItem
        '
        Me.SaveLogToolStripMenuItem.Name = "SaveLogToolStripMenuItem"
        Me.SaveLogToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.SaveLogToolStripMenuItem.Text = "Save Log"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(118, 6)
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(121, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'SetupToolStripMenuItem
        '
        Me.SetupToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConnectTCPIPToolStripMenuItem, Me.DisconnectToolStripMenuItem})
        Me.SetupToolStripMenuItem.Name = "SetupToolStripMenuItem"
        Me.SetupToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.SetupToolStripMenuItem.Text = "Setup"
        '
        'ConnectTCPIPToolStripMenuItem
        '
        Me.ConnectTCPIPToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RFMeasUnitToolStripMenuItem, Me.AntennaUnitToolStripMenuItem})
        Me.ConnectTCPIPToolStripMenuItem.Name = "ConnectTCPIPToolStripMenuItem"
        Me.ConnectTCPIPToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ConnectTCPIPToolStripMenuItem.Text = "Connect TCP-IP"
        '
        'RFMeasUnitToolStripMenuItem
        '
        Me.RFMeasUnitToolStripMenuItem.Name = "RFMeasUnitToolStripMenuItem"
        Me.RFMeasUnitToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.RFMeasUnitToolStripMenuItem.Text = "RF Meas unit"
        '
        'AntennaUnitToolStripMenuItem
        '
        Me.AntennaUnitToolStripMenuItem.Name = "AntennaUnitToolStripMenuItem"
        Me.AntennaUnitToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.AntennaUnitToolStripMenuItem.Text = "Antenna Unit"
        '
        'DisconnectToolStripMenuItem
        '
        Me.DisconnectToolStripMenuItem.Name = "DisconnectToolStripMenuItem"
        Me.DisconnectToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.DisconnectToolStripMenuItem.Text = "Disconnect "
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem, Me.ToolStripSeparator2, Me.AboutToolStripMenuItem1})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(104, 6)
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'GBSpecControl
        '
        Me.GBSpecControl.Controls.Add(Me.GBOffset)
        Me.GBSpecControl.Controls.Add(Me.GBSAControl)
        Me.GBSpecControl.Location = New System.Drawing.Point(14, 93)
        Me.GBSpecControl.Name = "GBSpecControl"
        Me.GBSpecControl.Size = New System.Drawing.Size(338, 276)
        Me.GBSpecControl.TabIndex = 25
        Me.GBSpecControl.TabStop = False
        Me.GBSpecControl.Text = "Spectrum Control"
        '
        'GBOffset
        '
        Me.GBOffset.Controls.Add(Me.BSetCorr)
        Me.GBOffset.Controls.Add(Me.BNormalize)
        Me.GBOffset.Controls.Add(Me.LAF)
        Me.GBOffset.Controls.Add(Me.TBAF)
        Me.GBOffset.Controls.Add(Me.LAntennaCorr)
        Me.GBOffset.Controls.Add(Me.BSetCor)
        Me.GBOffset.Controls.Add(Me.TBAntCorr)
        Me.GBOffset.Controls.Add(Me.TBAmpCorr)
        Me.GBOffset.Controls.Add(Me.LCableCorr)
        Me.GBOffset.Controls.Add(Me.TBUserCorr)
        Me.GBOffset.Controls.Add(Me.TBCableCorr)
        Me.GBOffset.Controls.Add(Me.LAmplifierCorr)
        Me.GBOffset.Controls.Add(Me.LUserCorr)
        Me.GBOffset.Location = New System.Drawing.Point(6, 163)
        Me.GBOffset.Name = "GBOffset"
        Me.GBOffset.Size = New System.Drawing.Size(326, 106)
        Me.GBOffset.TabIndex = 29
        Me.GBOffset.TabStop = False
        Me.GBOffset.Text = "Correction(Offset)"
        '
        'BSetCorr
        '
        Me.BSetCorr.Location = New System.Drawing.Point(211, 68)
        Me.BSetCorr.Name = "BSetCorr"
        Me.BSetCorr.Size = New System.Drawing.Size(106, 29)
        Me.BSetCorr.TabIndex = 57
        Me.BSetCorr.Text = "Set Setting"
        Me.BSetCorr.UseVisualStyleBackColor = True
        '
        'BNormalize
        '
        Me.BNormalize.BackColor = System.Drawing.Color.Bisque
        Me.BNormalize.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BNormalize.Location = New System.Drawing.Point(141, 69)
        Me.BNormalize.Name = "BNormalize"
        Me.BNormalize.Size = New System.Drawing.Size(64, 31)
        Me.BNormalize.TabIndex = 55
        Me.BNormalize.Text = "Normalize"
        Me.BNormalize.UseVisualStyleBackColor = False
        '
        'LAF
        '
        Me.LAF.AutoSize = True
        Me.LAF.Location = New System.Drawing.Point(1, 21)
        Me.LAF.Name = "LAF"
        Me.LAF.Size = New System.Drawing.Size(52, 13)
        Me.LAF.TabIndex = 55
        Me.LAF.Text = "AF(dB/m)"
        '
        'TBAF
        '
        Me.TBAF.Location = New System.Drawing.Point(83, 18)
        Me.TBAF.Name = "TBAF"
        Me.TBAF.Size = New System.Drawing.Size(52, 20)
        Me.TBAF.TabIndex = 56
        Me.TBAF.Text = " "
        '
        'LAntennaCorr
        '
        Me.LAntennaCorr.AutoSize = True
        Me.LAntennaCorr.Location = New System.Drawing.Point(182, 22)
        Me.LAntennaCorr.Name = "LAntennaCorr"
        Me.LAntennaCorr.Size = New System.Drawing.Size(69, 13)
        Me.LAntennaCorr.TabIndex = 47
        Me.LAntennaCorr.Text = "Ant Gain(dBi)"
        '
        'BSetCor
        '
        Me.BSetCor.Location = New System.Drawing.Point(4, 176)
        Me.BSetCor.Name = "BSetCor"
        Me.BSetCor.Size = New System.Drawing.Size(130, 28)
        Me.BSetCor.TabIndex = 29
        Me.BSetCor.Text = "Set Correction"
        Me.BSetCor.UseVisualStyleBackColor = True
        '
        'TBAntCorr
        '
        Me.TBAntCorr.Location = New System.Drawing.Point(264, 19)
        Me.TBAntCorr.Name = "TBAntCorr"
        Me.TBAntCorr.Size = New System.Drawing.Size(52, 20)
        Me.TBAntCorr.TabIndex = 48
        '
        'TBAmpCorr
        '
        Me.TBAmpCorr.Location = New System.Drawing.Point(83, 68)
        Me.TBAmpCorr.Name = "TBAmpCorr"
        Me.TBAmpCorr.Size = New System.Drawing.Size(52, 20)
        Me.TBAmpCorr.TabIndex = 52
        '
        'LCableCorr
        '
        Me.LCableCorr.AutoSize = True
        Me.LCableCorr.Location = New System.Drawing.Point(183, 46)
        Me.LCableCorr.Name = "LCableCorr"
        Me.LCableCorr.Size = New System.Drawing.Size(78, 13)
        Me.LCableCorr.TabIndex = 51
        Me.LCableCorr.Text = "Cable Loss(dB)"
        '
        'TBUserCorr
        '
        Me.TBUserCorr.Location = New System.Drawing.Point(83, 44)
        Me.TBUserCorr.Name = "TBUserCorr"
        Me.TBUserCorr.Size = New System.Drawing.Size(52, 20)
        Me.TBUserCorr.TabIndex = 54
        '
        'TBCableCorr
        '
        Me.TBCableCorr.Location = New System.Drawing.Point(264, 45)
        Me.TBCableCorr.Name = "TBCableCorr"
        Me.TBCableCorr.Size = New System.Drawing.Size(52, 20)
        Me.TBCableCorr.TabIndex = 50
        '
        'LAmplifierCorr
        '
        Me.LAmplifierCorr.AutoSize = True
        Me.LAmplifierCorr.Location = New System.Drawing.Point(2, 72)
        Me.LAmplifierCorr.Name = "LAmplifierCorr"
        Me.LAmplifierCorr.Size = New System.Drawing.Size(72, 13)
        Me.LAmplifierCorr.TabIndex = 53
        Me.LAmplifierCorr.Text = "LNA Gain(dB)"
        '
        'LUserCorr
        '
        Me.LUserCorr.AutoSize = True
        Me.LUserCorr.Location = New System.Drawing.Point(2, 46)
        Me.LUserCorr.Name = "LUserCorr"
        Me.LUserCorr.Size = New System.Drawing.Size(70, 13)
        Me.LUserCorr.TabIndex = 49
        Me.LUserCorr.Text = "User Corr(dB)"
        '
        'GBSAControl
        '
        Me.GBSAControl.Controls.Add(Me.CBBFStep)
        Me.GBSAControl.Controls.Add(Me.Label7)
        Me.GBSAControl.Controls.Add(Me.TBFStart)
        Me.GBSAControl.Controls.Add(Me.Label4)
        Me.GBSAControl.Controls.Add(Me.TBFStop)
        Me.GBSAControl.Controls.Add(Me.Label3)
        Me.GBSAControl.Controls.Add(Me.CBAttenuatorInt)
        Me.GBSAControl.Controls.Add(Me.LAtt)
        Me.GBSAControl.Controls.Add(Me.LRBW)
        Me.GBSAControl.Controls.Add(Me.CBRBW)
        Me.GBSAControl.Controls.Add(Me.CBTG)
        Me.GBSAControl.Controls.Add(Me.BSetSPACtrl)
        Me.GBSAControl.Controls.Add(Me.CBRL)
        Me.GBSAControl.Controls.Add(Me.CBTGLvl)
        Me.GBSAControl.Controls.Add(Me.LRL)
        Me.GBSAControl.Controls.Add(Me.LTGLvl)
        Me.GBSAControl.Location = New System.Drawing.Point(6, 25)
        Me.GBSAControl.Name = "GBSAControl"
        Me.GBSAControl.Size = New System.Drawing.Size(326, 132)
        Me.GBSAControl.TabIndex = 43
        Me.GBSAControl.TabStop = False
        Me.GBSAControl.Text = "Device Setting"
        '
        'CBBFStep
        '
        Me.CBBFStep.FormattingEnabled = True
        Me.CBBFStep.Location = New System.Drawing.Point(73, 46)
        Me.CBBFStep.Name = "CBBFStep"
        Me.CBBFStep.Size = New System.Drawing.Size(87, 21)
        Me.CBBFStep.TabIndex = 60
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "FStep (MHz)"
        '
        'TBFStart
        '
        Me.TBFStart.Location = New System.Drawing.Point(73, 20)
        Me.TBFStart.Name = "TBFStart"
        Me.TBFStart.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TBFStart.Size = New System.Drawing.Size(87, 20)
        Me.TBFStart.TabIndex = 58
        Me.TBFStart.Text = "1,000,000.00"
        Me.TBFStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "FStart (MHz)"
        '
        'TBFStop
        '
        Me.TBFStop.Location = New System.Drawing.Point(230, 18)
        Me.TBFStop.Name = "TBFStop"
        Me.TBFStop.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TBFStop.Size = New System.Drawing.Size(87, 20)
        Me.TBFStop.TabIndex = 56
        Me.TBFStop.Text = "1,000,000.00"
        Me.TBFStop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(165, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "FStop (MHz)"
        '
        'CBAttenuatorInt
        '
        Me.CBAttenuatorInt.FormattingEnabled = True
        Me.CBAttenuatorInt.Items.AddRange(New Object() {"0 dBm", "1 dBm", "2 dBm", "3 dBm", "4 dBm", "5 dBm", "6 dBm", "7 dBm", "8 dBm", "9 dBm", "10 dBm", "11 dBm", "12 dBm", "13 dBm", "14 dBm", "15 dBm", "16 dBm", "17 dBm", "18 dBm", "19 dBm", "20 dBm", "21 dBm", "22 dBm", "23 dBm", "24 dBm", "25 dBm", "26 dBm", "27 dBm", "28 dBm", "29 dBm", "30 dBm"})
        Me.CBAttenuatorInt.Location = New System.Drawing.Point(230, 42)
        Me.CBAttenuatorInt.Name = "CBAttenuatorInt"
        Me.CBAttenuatorInt.Size = New System.Drawing.Size(87, 21)
        Me.CBAttenuatorInt.TabIndex = 54
        '
        'LAtt
        '
        Me.LAtt.AutoSize = True
        Me.LAtt.Location = New System.Drawing.Point(165, 46)
        Me.LAtt.Name = "LAtt"
        Me.LAtt.Size = New System.Drawing.Size(56, 13)
        Me.LAtt.TabIndex = 53
        Me.LAtt.Text = "Attenuator"
        '
        'LRBW
        '
        Me.LRBW.AutoSize = True
        Me.LRBW.Location = New System.Drawing.Point(165, 72)
        Me.LRBW.Name = "LRBW"
        Me.LRBW.Size = New System.Drawing.Size(33, 13)
        Me.LRBW.TabIndex = 52
        Me.LRBW.Text = "RBW"
        '
        'CBRBW
        '
        Me.CBRBW.FormattingEnabled = True
        Me.CBRBW.Items.AddRange(New Object() {"1 MHz", "300 kHz", "100 kHz", "30 kHz", "10 kHz", "3 kHz", "1 kHz"})
        Me.CBRBW.Location = New System.Drawing.Point(230, 68)
        Me.CBRBW.Name = "CBRBW"
        Me.CBRBW.Size = New System.Drawing.Size(87, 21)
        Me.CBRBW.TabIndex = 51
        '
        'CBTG
        '
        Me.CBTG.AutoSize = True
        Me.CBTG.Location = New System.Drawing.Point(165, 101)
        Me.CBTG.Name = "CBTG"
        Me.CBTG.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CBTG.Size = New System.Drawing.Size(60, 17)
        Me.CBTG.TabIndex = 50
        Me.CBTG.Text = "TG ON"
        Me.CBTG.UseVisualStyleBackColor = True
        '
        'BSetSPACtrl
        '
        Me.BSetSPACtrl.Location = New System.Drawing.Point(244, 94)
        Me.BSetSPACtrl.Name = "BSetSPACtrl"
        Me.BSetSPACtrl.Size = New System.Drawing.Size(73, 29)
        Me.BSetSPACtrl.TabIndex = 49
        Me.BSetSPACtrl.Text = "Set Setting"
        Me.BSetSPACtrl.UseVisualStyleBackColor = True
        '
        'CBRL
        '
        Me.CBRL.FormattingEnabled = True
        Me.CBRL.Items.AddRange(New Object() {"20 dBm", "19 dBm", "18 dBm", "17 dBm", "16 dBm", "15 dBm", "14 dBm", "13 dBm", "12 dBm", "11 dBm", "10 dBm", "9 dBm", "8 dBm", "7 dBm", "6 dBm", "5 dBm", "4 dBm", "3 dBm", "2 dBm", "1 dBm", "0 dBm", "-1 dBm", "-2 dBm", "-3 dBm", "-4 dBm", "-5 dBm", "-6 dBm", "-7 dBm", "-8 dBm", "-9 dBm", "-10 dBm", "-11 dBm", "-12 dBm", "-13 dBm", "-14 dBm", "-15 dBm", "-16 dBm", "-17 dBm", "-18 dBm", "-19 dBm", "-20 dBm", "-21 dBm", "-22 dBm", "-23 dBm", "-24 dBm", "-25 dBm", "-26 dBm", "-27 dBm", "-28 dBm", "-29 dBm", "-30 dBm", "-31 dBm", "-32 dBm", "-33 dBm", "-34 dBm", "-35 dBm", "-36 dBm", "-37 dBm", "-38 dBm", "-39 dBm", "-40 dBm", "-41 dBm", "-42 dBm", "-43 dBm", "-44 dBm", "-45 dBm", "-46 dBm", "-47 dBm", "-48 dBm", "-49 dBm", "-50 dBm", "-51 dBm", "-52 dBm", "-53 dBm", "-54 dBm", "-55 dBm", "-56 dBm", "-57 dBm", "-58 dBm", "-59 dBm", "-60 dBm", "-61 dBm", "-62 dBm", "-63 dBm", "-64 dBm", "-65 dBm", "-66 dBm", "-67 dBm", "-68 dBm", "-69 dBm", "-70 dBm", "-71 dBm", "-72 dBm", "-73 dBm", "-74 dBm", "-75 dBm", "-76 dBm", "-77 dBm", "-78 dBm", "-79 dBm", "-80 dBm", "-81 dBm", "-82 dBm", "-83 dBm", "-84 dBm", "-85 dBm", "-86 dBm", "-87 dBm", "-88 dBm", "-89 dBm", "-90 dBm", "-91 dBm", "-92 dBm", "-93 dBm", "-94 dBm", "-95 dBm", "-96 dBm", "-97 dBm", "-98 dBm", "-99 dBm", "-100 dBm"})
        Me.CBRL.Location = New System.Drawing.Point(73, 73)
        Me.CBRL.Name = "CBRL"
        Me.CBRL.Size = New System.Drawing.Size(87, 21)
        Me.CBRL.TabIndex = 43
        '
        'CBTGLvl
        '
        Me.CBTGLvl.FormattingEnabled = True
        Me.CBTGLvl.Items.AddRange(New Object() {"0 dBm", "-1 dBm", "-2 dBm", "-3 dBm", "-4 dBm", "-5 dBm", "-6 dBm", "-7 dBm", "-8 dBm", "-9 dBm", "-10 dBm", "-11 dBm", "-12 dBm", "-13 dBm", "-14 dBm", "-15 dBm", "-16 dBm", "-17 dBm", "-18 dBm", "-19 dBm", "-20 dBm", "-21 dBm", "-22 dBm", "-23 dBm", "-24 dBm", "-25 dBm", "-26 dBm", "-27 dBm", "-28 dBm", "-29 dBm", "-30 dBm", "-31 dBm", "-32 dBm", "-33 dBm", "-34 dBm", "-35 dBm", "-36 dBm", "-37 dBm", "-38 dBm", "-39 dBm", "-40 dBm"})
        Me.CBTGLvl.Location = New System.Drawing.Point(73, 104)
        Me.CBTGLvl.Name = "CBTGLvl"
        Me.CBTGLvl.Size = New System.Drawing.Size(87, 21)
        Me.CBTGLvl.TabIndex = 48
        '
        'LRL
        '
        Me.LRL.AutoSize = True
        Me.LRL.Location = New System.Drawing.Point(8, 76)
        Me.LRL.Name = "LRL"
        Me.LRL.Size = New System.Drawing.Size(21, 13)
        Me.LRL.TabIndex = 44
        Me.LRL.Text = "RL"
        '
        'LTGLvl
        '
        Me.LTGLvl.AutoSize = True
        Me.LTGLvl.Location = New System.Drawing.Point(8, 110)
        Me.LTGLvl.Name = "LTGLvl"
        Me.LTGLvl.Size = New System.Drawing.Size(51, 13)
        Me.LTGLvl.TabIndex = 46
        Me.LTGLvl.Text = "TG Level"
        '
        'GBControl
        '
        Me.GBControl.Controls.Add(Me.BReleaseMotor)
        Me.GBControl.Controls.Add(Me.Label1)
        Me.GBControl.Controls.Add(Me.CBStepSize)
        Me.GBControl.Controls.Add(Me.LAngleAP)
        Me.GBControl.Controls.Add(Me.LAngle)
        Me.GBControl.Controls.Add(Me.BTTSetCent)
        Me.GBControl.Controls.Add(Me.BTT180)
        Me.GBControl.Controls.Add(Me.BTTCW)
        Me.GBControl.Controls.Add(Me.BTT0)
        Me.GBControl.Controls.Add(Me.BTTCCW)
        Me.GBControl.Location = New System.Drawing.Point(13, 375)
        Me.GBControl.Name = "GBControl"
        Me.GBControl.Size = New System.Drawing.Size(340, 106)
        Me.GBControl.TabIndex = 7
        Me.GBControl.TabStop = False
        Me.GBControl.Text = "Turn Table Control"
        '
        'BReleaseMotor
        '
        Me.BReleaseMotor.Location = New System.Drawing.Point(150, 49)
        Me.BReleaseMotor.Name = "BReleaseMotor"
        Me.BReleaseMotor.Size = New System.Drawing.Size(65, 24)
        Me.BReleaseMotor.TabIndex = 63
        Me.BReleaseMotor.Text = "Release"
        Me.BReleaseMotor.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "STEP(deg)"
        '
        'CBStepSize
        '
        Me.CBStepSize.FormattingEnabled = True
        Me.CBStepSize.Items.AddRange(New Object() {"1  Degree", "5  Degree"})
        Me.CBStepSize.Location = New System.Drawing.Point(81, 19)
        Me.CBStepSize.Name = "CBStepSize"
        Me.CBStepSize.Size = New System.Drawing.Size(134, 21)
        Me.CBStepSize.TabIndex = 43
        '
        'LAngleAP
        '
        Me.LAngleAP.AutoSize = True
        Me.LAngleAP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAngleAP.Location = New System.Drawing.Point(218, 19)
        Me.LAngleAP.Name = "LAngleAP"
        Me.LAngleAP.Size = New System.Drawing.Size(122, 20)
        Me.LAngleAP.TabIndex = 38
        Me.LAngleAP.Text = "MAST ANGLE"
        '
        'LAngle
        '
        Me.LAngle.AutoSize = True
        Me.LAngle.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAngle.ForeColor = System.Drawing.Color.Maroon
        Me.LAngle.Location = New System.Drawing.Point(237, 45)
        Me.LAngle.Name = "LAngle"
        Me.LAngle.Size = New System.Drawing.Size(57, 42)
        Me.LAngle.TabIndex = 37
        Me.LAngle.Text = "---"
        '
        'BTTSetCent
        '
        Me.BTTSetCent.Location = New System.Drawing.Point(150, 75)
        Me.BTTSetCent.Name = "BTTSetCent"
        Me.BTTSetCent.Size = New System.Drawing.Size(65, 24)
        Me.BTTSetCent.TabIndex = 32
        Me.BTTSetCent.Text = "Set Center"
        Me.BTTSetCent.UseVisualStyleBackColor = True
        '
        'BTT180
        '
        Me.BTT180.Location = New System.Drawing.Point(81, 75)
        Me.BTT180.Name = "BTT180"
        Me.BTT180.Size = New System.Drawing.Size(65, 24)
        Me.BTT180.TabIndex = 31
        Me.BTT180.Text = "Set 180"
        Me.BTT180.UseVisualStyleBackColor = True
        '
        'BTTCW
        '
        Me.BTTCW.Location = New System.Drawing.Point(12, 49)
        Me.BTTCW.Name = "BTTCW"
        Me.BTTCW.Size = New System.Drawing.Size(65, 24)
        Me.BTTCW.TabIndex = 30
        Me.BTTCW.Text = "CW"
        Me.BTTCW.UseVisualStyleBackColor = True
        '
        'BTT0
        '
        Me.BTT0.Location = New System.Drawing.Point(12, 75)
        Me.BTT0.Name = "BTT0"
        Me.BTT0.Size = New System.Drawing.Size(65, 24)
        Me.BTT0.TabIndex = 29
        Me.BTT0.Text = "Set 0"
        Me.BTT0.UseVisualStyleBackColor = True
        '
        'BTTCCW
        '
        Me.BTTCCW.Location = New System.Drawing.Point(81, 49)
        Me.BTTCCW.Name = "BTTCCW"
        Me.BTTCCW.Size = New System.Drawing.Size(65, 24)
        Me.BTTCCW.TabIndex = 28
        Me.BTTCCW.Text = "CCW"
        Me.BTTCCW.UseVisualStyleBackColor = True
        '
        'TimerAntennaPattern
        '
        Me.TimerAntennaPattern.Interval = 2000
        '
        'BConnect
        '
        Me.BConnect.Location = New System.Drawing.Point(242, 15)
        Me.BConnect.Name = "BConnect"
        Me.BConnect.Size = New System.Drawing.Size(79, 40)
        Me.BConnect.TabIndex = 0
        Me.BConnect.Text = "Connect SPA"
        Me.BConnect.UseVisualStyleBackColor = True
        '
        'TextPort
        '
        Me.TextPort.Location = New System.Drawing.Point(150, 35)
        Me.TextPort.Name = "TextPort"
        Me.TextPort.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextPort.Size = New System.Drawing.Size(90, 20)
        Me.TextPort.TabIndex = 2
        Me.TextPort.Text = "5555"
        '
        'TextIP
        '
        Me.TextIP.Location = New System.Drawing.Point(150, 15)
        Me.TextIP.Name = "TextIP"
        Me.TextIP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextIP.Size = New System.Drawing.Size(90, 20)
        Me.TextIP.TabIndex = 4
        Me.TextIP.Text = "192.168.1.25"
        '
        'LIP
        '
        Me.LIP.AutoSize = True
        Me.LIP.Location = New System.Drawing.Point(119, 17)
        Me.LIP.Name = "LIP"
        Me.LIP.Size = New System.Drawing.Size(17, 13)
        Me.LIP.TabIndex = 20
        Me.LIP.Text = "IP"
        '
        'LPort
        '
        Me.LPort.AutoSize = True
        Me.LPort.Location = New System.Drawing.Point(119, 38)
        Me.LPort.Name = "LPort"
        Me.LPort.Size = New System.Drawing.Size(26, 13)
        Me.LPort.TabIndex = 21
        Me.LPort.Text = "Port"
        '
        'LMeasReceiver
        '
        Me.LMeasReceiver.AutoSize = True
        Me.LMeasReceiver.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMeasReceiver.Location = New System.Drawing.Point(6, 16)
        Me.LMeasReceiver.Name = "LMeasReceiver"
        Me.LMeasReceiver.Size = New System.Drawing.Size(112, 13)
        Me.LMeasReceiver.TabIndex = 26
        Me.LMeasReceiver.Text = "Spectrum Analyzer"
        '
        'LDFAntenna
        '
        Me.LDFAntenna.AutoSize = True
        Me.LDFAntenna.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDFAntenna.Location = New System.Drawing.Point(9, 44)
        Me.LDFAntenna.Name = "LDFAntenna"
        Me.LDFAntenna.Size = New System.Drawing.Size(69, 13)
        Me.LDFAntenna.TabIndex = 27
        Me.LDFAntenna.Text = "Turn Table"
        '
        'LCOM
        '
        Me.LCOM.AutoSize = True
        Me.LCOM.Location = New System.Drawing.Point(91, 67)
        Me.LCOM.Name = "LCOM"
        Me.LCOM.Size = New System.Drawing.Size(53, 13)
        Me.LCOM.TabIndex = 30
        Me.LCOM.Text = "COM Port"
        '
        'GBComm
        '
        Me.GBComm.Controls.Add(Me.BScanPort)
        Me.GBComm.Controls.Add(Me.CBComPort)
        Me.GBComm.Controls.Add(Me.BConTT)
        Me.GBComm.Controls.Add(Me.LCOM)
        Me.GBComm.Controls.Add(Me.LDFAntenna)
        Me.GBComm.Controls.Add(Me.LMeasReceiver)
        Me.GBComm.Controls.Add(Me.LPort)
        Me.GBComm.Controls.Add(Me.LIP)
        Me.GBComm.Controls.Add(Me.TextIP)
        Me.GBComm.Controls.Add(Me.TextPort)
        Me.GBComm.Controls.Add(Me.BConnect)
        Me.GBComm.Location = New System.Drawing.Point(14, 3)
        Me.GBComm.Name = "GBComm"
        Me.GBComm.Size = New System.Drawing.Size(338, 91)
        Me.GBComm.TabIndex = 28
        Me.GBComm.TabStop = False
        Me.GBComm.Text = "Connection Setting"
        '
        'BScanPort
        '
        Me.BScanPort.Location = New System.Drawing.Point(11, 61)
        Me.BScanPort.Name = "BScanPort"
        Me.BScanPort.Size = New System.Drawing.Size(81, 22)
        Me.BScanPort.TabIndex = 33
        Me.BScanPort.Text = "Scan Port"
        Me.BScanPort.UseVisualStyleBackColor = True
        '
        'CBComPort
        '
        Me.CBComPort.FormattingEnabled = True
        Me.CBComPort.Location = New System.Drawing.Point(150, 61)
        Me.CBComPort.Name = "CBComPort"
        Me.CBComPort.Size = New System.Drawing.Size(90, 21)
        Me.CBComPort.TabIndex = 32
        '
        'BConTT
        '
        Me.BConTT.Location = New System.Drawing.Point(242, 60)
        Me.BConTT.Name = "BConTT"
        Me.BConTT.Size = New System.Drawing.Size(81, 23)
        Me.BConTT.TabIndex = 31
        Me.BConTT.Text = "Connect TT"
        Me.BConTT.UseVisualStyleBackColor = True
        '
        'TimerCheck
        '
        Me.TimerCheck.Enabled = True
        Me.TimerCheck.Interval = 500
        '
        'BAPRport
        '
        Me.BAPRport.Location = New System.Drawing.Point(261, 321)
        Me.BAPRport.Name = "BAPRport"
        Me.BAPRport.Size = New System.Drawing.Size(113, 35)
        Me.BAPRport.TabIndex = 50
        Me.BAPRport.Text = "Antenna Pattern Report As Word"
        Me.BAPRport.UseVisualStyleBackColor = True
        '
        'CLIncludeTable
        '
        Me.CLIncludeTable.AutoSize = True
        Me.CLIncludeTable.Location = New System.Drawing.Point(261, 372)
        Me.CLIncludeTable.Name = "CLIncludeTable"
        Me.CLIncludeTable.Size = New System.Drawing.Size(91, 17)
        Me.CLIncludeTable.TabIndex = 49
        Me.CLIncludeTable.Text = "Include Table"
        Me.CLIncludeTable.UseVisualStyleBackColor = True
        '
        'BSaveReport
        '
        Me.BSaveReport.Location = New System.Drawing.Point(14, 321)
        Me.BSaveReport.Name = "BSaveReport"
        Me.BSaveReport.Size = New System.Drawing.Size(113, 35)
        Me.BSaveReport.TabIndex = 35
        Me.BSaveReport.Text = "Save Text Report"
        Me.BSaveReport.UseVisualStyleBackColor = True
        '
        'BRptClr
        '
        Me.BRptClr.Location = New System.Drawing.Point(133, 321)
        Me.BRptClr.Name = "BRptClr"
        Me.BRptClr.Size = New System.Drawing.Size(113, 35)
        Me.BRptClr.TabIndex = 34
        Me.BRptClr.Text = "Clear Log"
        Me.BRptClr.UseVisualStyleBackColor = True
        '
        'TAPolar
        '
        Me.TAPolar.Controls.Add(Me.GBLog)
        Me.TAPolar.Controls.Add(Me.GBAPPolar)
        Me.TAPolar.Location = New System.Drawing.Point(4, 22)
        Me.TAPolar.Name = "TAPolar"
        Me.TAPolar.Padding = New System.Windows.Forms.Padding(3)
        Me.TAPolar.Size = New System.Drawing.Size(932, 586)
        Me.TAPolar.TabIndex = 1
        Me.TAPolar.Text = "Antenna Pattern (Polar)"
        Me.TAPolar.UseVisualStyleBackColor = True
        '
        'GBLog
        '
        Me.GBLog.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GBLog.Controls.Add(Me.BAutoscalePol)
        Me.GBLog.Controls.Add(Me.APTB)
        Me.GBLog.Controls.Add(Me.BAPRport)
        Me.GBLog.Controls.Add(Me.CLIncludeTable)
        Me.GBLog.Controls.Add(Me.CBPolAPYmax)
        Me.GBLog.Controls.Add(Me.BRptClr)
        Me.GBLog.Controls.Add(Me.LYminPolar)
        Me.GBLog.Controls.Add(Me.BSaveReport)
        Me.GBLog.Controls.Add(Me.CBPolAPYmin)
        Me.GBLog.Controls.Add(Me.LYmaxPolar)
        Me.GBLog.Location = New System.Drawing.Point(437, 6)
        Me.GBLog.Name = "GBLog"
        Me.GBLog.Size = New System.Drawing.Size(380, 442)
        Me.GBLog.TabIndex = 51
        Me.GBLog.TabStop = False
        Me.GBLog.Text = "Antenna Pattern Log"
        '
        'BAutoscalePol
        '
        Me.BAutoscalePol.Location = New System.Drawing.Point(14, 372)
        Me.BAutoscalePol.Name = "BAutoscalePol"
        Me.BAutoscalePol.Size = New System.Drawing.Size(113, 35)
        Me.BAutoscalePol.TabIndex = 51
        Me.BAutoscalePol.Text = "Autoscale"
        Me.BAutoscalePol.UseVisualStyleBackColor = True
        '
        'APTB
        '
        Me.APTB.Location = New System.Drawing.Point(6, 19)
        Me.APTB.Multiline = True
        Me.APTB.Name = "APTB"
        Me.APTB.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.APTB.Size = New System.Drawing.Size(368, 296)
        Me.APTB.TabIndex = 33
        '
        'CBPolAPYmax
        '
        Me.CBPolAPYmax.FormattingEnabled = True
        Me.CBPolAPYmax.Items.AddRange(New Object() {"+20 dB", "+10 dB", "     0 dB", " -10 dB", " -20 dB", " -30 dB", " -40 dB", " -50 dB", " -60 dB", " -70 dB", " -80 dB", " -90 dB", "-100 dB", "-110 dB", "-120 dB", "-130 dB", "-140 dB", "-150 dB", "-160 dB", "-170 dB", "-180 dB"})
        Me.CBPolAPYmax.Location = New System.Drawing.Point(181, 370)
        Me.CBPolAPYmax.Name = "CBPolAPYmax"
        Me.CBPolAPYmax.Size = New System.Drawing.Size(65, 21)
        Me.CBPolAPYmax.TabIndex = 39
        '
        'LYminPolar
        '
        Me.LYminPolar.AutoSize = True
        Me.LYminPolar.Location = New System.Drawing.Point(137, 407)
        Me.LYminPolar.Name = "LYminPolar"
        Me.LYminPolar.Size = New System.Drawing.Size(36, 13)
        Me.LYminPolar.TabIndex = 38
        Me.LYminPolar.Text = "Y(min)"
        '
        'CBPolAPYmin
        '
        Me.CBPolAPYmin.FormattingEnabled = True
        Me.CBPolAPYmin.Items.AddRange(New Object() {"+20 dB", "+10 dB", "     0 dB", " -10 dB", " -20 dB", " -30 dB", " -40 dB", " -50 dB", " -60 dB", " -70 dB", " -80 dB", " -90 dB", "-100 dB", "-110 dB", "-120 dB", "-130 dB", "-140 dB", "-150 dB", "-160 dB", "-170 dB", "-180 dB"})
        Me.CBPolAPYmin.Location = New System.Drawing.Point(181, 401)
        Me.CBPolAPYmin.Name = "CBPolAPYmin"
        Me.CBPolAPYmin.Size = New System.Drawing.Size(65, 21)
        Me.CBPolAPYmin.TabIndex = 40
        '
        'LYmaxPolar
        '
        Me.LYmaxPolar.AutoSize = True
        Me.LYmaxPolar.Location = New System.Drawing.Point(137, 376)
        Me.LYmaxPolar.Name = "LYmaxPolar"
        Me.LYmaxPolar.Size = New System.Drawing.Size(39, 13)
        Me.LYmaxPolar.TabIndex = 37
        Me.LYmaxPolar.Text = "Y(max)"
        '
        'GBAPPolar
        '
        Me.GBAPPolar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GBAPPolar.Controls.Add(Me.CHAPP)
        Me.GBAPPolar.Location = New System.Drawing.Point(8, 6)
        Me.GBAPPolar.Name = "GBAPPolar"
        Me.GBAPPolar.Size = New System.Drawing.Size(423, 606)
        Me.GBAPPolar.TabIndex = 42
        Me.GBAPPolar.TabStop = False
        Me.GBAPPolar.Text = "Antenna Pattern Polar Plot"
        '
        'CHAPP
        '
        ChartArea1.Area3DStyle.Enable3D = True
        ChartArea1.Name = "ChartArea1"
        Me.CHAPP.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.CHAPP.Legends.Add(Legend1)
        Me.CHAPP.Location = New System.Drawing.Point(6, 19)
        Me.CHAPP.Name = "CHAPP"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.CHAPP.Series.Add(Series1)
        Me.CHAPP.Size = New System.Drawing.Size(410, 410)
        Me.CHAPP.TabIndex = 5
        Me.CHAPP.Text = "Antenna Pattern"
        Me.CHAPP.UseWaitCursor = True
        '
        'TXYAP
        '
        Me.TXYAP.Controls.Add(Me.CBmaxYax)
        Me.TXYAP.Controls.Add(Me.LYmin)
        Me.TXYAP.Controls.Add(Me.CBminYax)
        Me.TXYAP.Controls.Add(Me.LYmax)
        Me.TXYAP.Controls.Add(Me.GBBarChartLvlDF)
        Me.TXYAP.Location = New System.Drawing.Point(4, 22)
        Me.TXYAP.Name = "TXYAP"
        Me.TXYAP.Padding = New System.Windows.Forms.Padding(3)
        Me.TXYAP.Size = New System.Drawing.Size(932, 586)
        Me.TXYAP.TabIndex = 0
        Me.TXYAP.Text = "Power Vs Angle (XY chart)"
        Me.TXYAP.UseVisualStyleBackColor = True
        '
        'CBmaxYax
        '
        Me.CBmaxYax.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBmaxYax.FormattingEnabled = True
        Me.CBmaxYax.Items.AddRange(New Object() {"+100 dB", "+90 dB", "+80 dB", "+70 dB", "+60 dB", "+50 dB", "+40 dB", "+30 dB", "+20 dB", "+10 dB", "     0 dB", " -10 dB", " -20 dB", " -30 dB", " -40 dB", " -50 dB", " -60 dB", " -70 dB", " -80 dB", " -90 dB", "-100 dB", "-110 dB", "-120 dB", "-130 dB", "-140 dB", "-150 dB", "-160 dB", "-170 dB", "-180 dB"})
        Me.CBmaxYax.Location = New System.Drawing.Point(752, 360)
        Me.CBmaxYax.Name = "CBmaxYax"
        Me.CBmaxYax.Size = New System.Drawing.Size(65, 21)
        Me.CBmaxYax.TabIndex = 35
        '
        'LYmin
        '
        Me.LYmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LYmin.AutoSize = True
        Me.LYmin.Location = New System.Drawing.Point(749, 384)
        Me.LYmin.Name = "LYmin"
        Me.LYmin.Size = New System.Drawing.Size(36, 13)
        Me.LYmin.TabIndex = 34
        Me.LYmin.Text = "Y(min)"
        '
        'CBminYax
        '
        Me.CBminYax.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBminYax.FormattingEnabled = True
        Me.CBminYax.Items.AddRange(New Object() {"+20 dB", "+10 dB", "     0 dB", " -10 dB", " -20 dB", " -30 dB", " -40 dB", " -50 dB", " -60 dB", " -70 dB", " -80 dB", " -90 dB", "-100 dB", "-110 dB", "-120 dB", "-130 dB", "-140 dB", "-150 dB", "-160 dB", "-170 dB", "-180 dB"})
        Me.CBminYax.Location = New System.Drawing.Point(752, 400)
        Me.CBminYax.Name = "CBminYax"
        Me.CBminYax.Size = New System.Drawing.Size(65, 21)
        Me.CBminYax.TabIndex = 36
        '
        'LYmax
        '
        Me.LYmax.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LYmax.AutoSize = True
        Me.LYmax.Location = New System.Drawing.Point(749, 332)
        Me.LYmax.Name = "LYmax"
        Me.LYmax.Size = New System.Drawing.Size(39, 13)
        Me.LYmax.TabIndex = 33
        Me.LYmax.Text = "Y(max)"
        '
        'GBBarChartLvlDF
        '
        Me.GBBarChartLvlDF.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GBBarChartLvlDF.Controls.Add(Me.CBTTH)
        Me.GBBarChartLvlDF.Controls.Add(Me.ZedGraphAP)
        Me.GBBarChartLvlDF.Location = New System.Drawing.Point(9, 22)
        Me.GBBarChartLvlDF.Name = "GBBarChartLvlDF"
        Me.GBBarChartLvlDF.Size = New System.Drawing.Size(732, 545)
        Me.GBBarChartLvlDF.TabIndex = 14
        Me.GBBarChartLvlDF.TabStop = False
        Me.GBBarChartLvlDF.Text = "AP Caertesian Plot"
        '
        'CBTTH
        '
        Me.CBTTH.AutoSize = True
        Me.CBTTH.Checked = True
        Me.CBTTH.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBTTH.Location = New System.Drawing.Point(692, 418)
        Me.CBTTH.Name = "CBTTH"
        Me.CBTTH.Size = New System.Drawing.Size(122, 17)
        Me.CBTTH.TabIndex = 62
        Me.CBTTH.Text = "Tool tip Help Enable"
        Me.CBTTH.UseVisualStyleBackColor = True
        '
        'ZedGraphAP
        '
        Me.ZedGraphAP.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.ZedGraphAP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ZedGraphAP.BackColor = System.Drawing.Color.White
        Me.ZedGraphAP.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ZedGraphAP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZedGraphAP.IsShowPointValues = True
        Me.ZedGraphAP.Location = New System.Drawing.Point(13, 19)
        Me.ZedGraphAP.Name = "ZedGraphAP"
        Me.ZedGraphAP.PointValueFormat = "G"
        Me.ZedGraphAP.Size = New System.Drawing.Size(650, 412)
        Me.ZedGraphAP.TabIndex = 8
        '
        'Func_tab
        '
        Me.Func_tab.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Func_tab.Controls.Add(Me.Setting)
        Me.Func_tab.Controls.Add(Me.TXYAP)
        Me.Func_tab.Controls.Add(Me.TAPolar)
        Me.Func_tab.Controls.Add(Me.TXYFAF)
        Me.Func_tab.Location = New System.Drawing.Point(0, 28)
        Me.Func_tab.Name = "Func_tab"
        Me.Func_tab.SelectedIndex = 0
        Me.Func_tab.Size = New System.Drawing.Size(940, 627)
        Me.Func_tab.TabIndex = 3
        '
        'Setting
        '
        Me.Setting.Controls.Add(Me.CheckBox2)
        Me.Setting.Controls.Add(Me.Label2)
        Me.Setting.Controls.Add(Me.BStopAP)
        Me.Setting.Controls.Add(Me.BAntPattern)
        Me.Setting.Controls.Add(Me.GBAF)
        Me.Setting.Controls.Add(Me.GBReport)
        Me.Setting.Controls.Add(Me.GBSpecControl)
        Me.Setting.Controls.Add(Me.GBComm)
        Me.Setting.Controls.Add(Me.GBControl)
        Me.Setting.Location = New System.Drawing.Point(4, 22)
        Me.Setting.Name = "Setting"
        Me.Setting.Size = New System.Drawing.Size(932, 601)
        Me.Setting.TabIndex = 4
        Me.Setting.Text = "Setting"
        Me.Setting.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(492, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 20)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "START TESTING"
        '
        'BStopAP
        '
        Me.BStopAP.BackColor = System.Drawing.Color.LightCoral
        Me.BStopAP.Location = New System.Drawing.Point(733, 8)
        Me.BStopAP.Name = "BStopAP"
        Me.BStopAP.Size = New System.Drawing.Size(82, 24)
        Me.BStopAP.TabIndex = 68
        Me.BStopAP.Text = "STOP"
        Me.BStopAP.UseVisualStyleBackColor = False
        '
        'BAntPattern
        '
        Me.BAntPattern.BackColor = System.Drawing.Color.GreenYellow
        Me.BAntPattern.Location = New System.Drawing.Point(645, 9)
        Me.BAntPattern.Name = "BAntPattern"
        Me.BAntPattern.Size = New System.Drawing.Size(82, 23)
        Me.BAntPattern.TabIndex = 67
        Me.BAntPattern.Text = "START"
        Me.BAntPattern.UseVisualStyleBackColor = False
        '
        'GBAF
        '
        Me.GBAF.Controls.Add(Me.Label8)
        Me.GBAF.Controls.Add(Me.CBBFreq)
        Me.GBAF.Controls.Add(Me.LPEIRP)
        Me.GBAF.Controls.Add(Me.TBEIRPow)
        Me.GBAF.Controls.Add(Me.TBDUTAG)
        Me.GBAF.Controls.Add(Me.LDUTAG)
        Me.GBAF.Controls.Add(Me.TBDUTAF)
        Me.GBAF.Controls.Add(Me.TBFSL)
        Me.GBAF.Controls.Add(Me.GroupBox1)
        Me.GBAF.Controls.Add(Me.LcalFSL)
        Me.GBAF.Controls.Add(Me.LCorFac)
        Me.GBAF.Controls.Add(Me.LMeasAF)
        Me.GBAF.Controls.Add(Me.TBCorFac)
        Me.GBAF.Controls.Add(Me.LPwrdBm)
        Me.GBAF.Controls.Add(Me.TBPowerdBm)
        Me.GBAF.Controls.Add(Me.LMeasDistance)
        Me.GBAF.Controls.Add(Me.TBMeasDistance)
        Me.GBAF.Location = New System.Drawing.Point(358, 197)
        Me.GBAF.Name = "GBAF"
        Me.GBAF.Size = New System.Drawing.Size(461, 284)
        Me.GBAF.TabIndex = 50
        Me.GBAF.TabStop = False
        Me.GBAF.Text = "Antenna Factor and Gain"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 13)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "Frequency (MHz)"
        '
        'CBBFreq
        '
        Me.CBBFreq.FormattingEnabled = True
        Me.CBBFreq.Location = New System.Drawing.Point(130, 19)
        Me.CBBFreq.Name = "CBBFreq"
        Me.CBBFreq.Size = New System.Drawing.Size(69, 21)
        Me.CBBFreq.TabIndex = 63
        '
        'LPEIRP
        '
        Me.LPEIRP.AutoSize = True
        Me.LPEIRP.Location = New System.Drawing.Point(12, 96)
        Me.LPEIRP.Name = "LPEIRP"
        Me.LPEIRP.Size = New System.Drawing.Size(92, 13)
        Me.LPEIRP.TabIndex = 61
        Me.LPEIRP.Text = "Power EIRP(dBm)"
        '
        'TBEIRPow
        '
        Me.TBEIRPow.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBEIRPow.ForeColor = System.Drawing.Color.Red
        Me.TBEIRPow.Location = New System.Drawing.Point(130, 93)
        Me.TBEIRPow.Name = "TBEIRPow"
        Me.TBEIRPow.ReadOnly = True
        Me.TBEIRPow.Size = New System.Drawing.Size(69, 20)
        Me.TBEIRPow.TabIndex = 62
        '
        'TBDUTAG
        '
        Me.TBDUTAG.Location = New System.Drawing.Point(375, 70)
        Me.TBDUTAG.Name = "TBDUTAG"
        Me.TBDUTAG.ReadOnly = True
        Me.TBDUTAG.Size = New System.Drawing.Size(59, 20)
        Me.TBDUTAG.TabIndex = 60
        '
        'LDUTAG
        '
        Me.LDUTAG.AutoSize = True
        Me.LDUTAG.Location = New System.Drawing.Point(210, 70)
        Me.LDUTAG.Name = "LDUTAG"
        Me.LDUTAG.Size = New System.Drawing.Size(126, 13)
        Me.LDUTAG.TabIndex = 59
        Me.LDUTAG.Text = "Measured DUT Gain(dBi)"
        '
        'TBDUTAF
        '
        Me.TBDUTAF.Location = New System.Drawing.Point(375, 93)
        Me.TBDUTAF.Name = "TBDUTAF"
        Me.TBDUTAF.ReadOnly = True
        Me.TBDUTAF.Size = New System.Drawing.Size(59, 20)
        Me.TBDUTAF.TabIndex = 58
        '
        'TBFSL
        '
        Me.TBFSL.Location = New System.Drawing.Point(375, 46)
        Me.TBFSL.Name = "TBFSL"
        Me.TBFSL.ReadOnly = True
        Me.TBFSL.Size = New System.Drawing.Size(59, 20)
        Me.TBFSL.TabIndex = 57
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TBAFList)
        Me.GroupBox1.Controls.Add(Me.BClearAFlist)
        Me.GroupBox1.Controls.Add(Me.BSaveToCSvAFList)
        Me.GroupBox1.Controls.Add(Me.BAddToListAPList)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 127)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(449, 147)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "One Position Antenna Factor Result"
        '
        'TBAFList
        '
        Me.TBAFList.Location = New System.Drawing.Point(9, 19)
        Me.TBAFList.Multiline = True
        Me.TBAFList.Name = "TBAFList"
        Me.TBAFList.Size = New System.Drawing.Size(346, 123)
        Me.TBAFList.TabIndex = 48
        Me.TBAFList.Text = "Frequency,(Hz) ),Antenna Factor(dB/m),Antenna Gain(dBi)"
        '
        'BClearAFlist
        '
        Me.BClearAFlist.Location = New System.Drawing.Point(361, 70)
        Me.BClearAFlist.Name = "BClearAFlist"
        Me.BClearAFlist.Size = New System.Drawing.Size(82, 32)
        Me.BClearAFlist.TabIndex = 35
        Me.BClearAFlist.Text = "Clear List"
        Me.BClearAFlist.UseVisualStyleBackColor = True
        '
        'BSaveToCSvAFList
        '
        Me.BSaveToCSvAFList.Location = New System.Drawing.Point(360, 107)
        Me.BSaveToCSvAFList.Name = "BSaveToCSvAFList"
        Me.BSaveToCSvAFList.Size = New System.Drawing.Size(82, 33)
        Me.BSaveToCSvAFList.TabIndex = 49
        Me.BSaveToCSvAFList.Text = "Save to CSV"
        Me.BSaveToCSvAFList.UseVisualStyleBackColor = True
        '
        'BAddToListAPList
        '
        Me.BAddToListAPList.BackColor = System.Drawing.Color.PaleGreen
        Me.BAddToListAPList.Location = New System.Drawing.Point(361, 19)
        Me.BAddToListAPList.Name = "BAddToListAPList"
        Me.BAddToListAPList.Size = New System.Drawing.Size(82, 45)
        Me.BAddToListAPList.TabIndex = 50
        Me.BAddToListAPList.Text = "Measure and Add to List"
        Me.BAddToListAPList.UseVisualStyleBackColor = False
        '
        'LcalFSL
        '
        Me.LcalFSL.AutoSize = True
        Me.LcalFSL.Location = New System.Drawing.Point(210, 46)
        Me.LcalFSL.Name = "LcalFSL"
        Me.LcalFSL.Size = New System.Drawing.Size(159, 13)
        Me.LcalFSL.TabIndex = 54
        Me.LcalFSL.Text = "Calculated Free Space Loss(dB)"
        '
        'LCorFac
        '
        Me.LCorFac.AutoSize = True
        Me.LCorFac.Location = New System.Drawing.Point(10, 44)
        Me.LCorFac.Name = "LCorFac"
        Me.LCorFac.Size = New System.Drawing.Size(107, 13)
        Me.LCorFac.TabIndex = 54
        Me.LCorFac.Text = "Correction Factor(dB)"
        '
        'LMeasAF
        '
        Me.LMeasAF.AutoSize = True
        Me.LMeasAF.Location = New System.Drawing.Point(210, 92)
        Me.LMeasAF.Name = "LMeasAF"
        Me.LMeasAF.Size = New System.Drawing.Size(128, 13)
        Me.LMeasAF.TabIndex = 52
        Me.LMeasAF.Text = "Measured DUT AF(dB/m)"
        '
        'TBCorFac
        '
        Me.TBCorFac.Location = New System.Drawing.Point(130, 44)
        Me.TBCorFac.Name = "TBCorFac"
        Me.TBCorFac.ReadOnly = True
        Me.TBCorFac.Size = New System.Drawing.Size(69, 20)
        Me.TBCorFac.TabIndex = 55
        '
        'LPwrdBm
        '
        Me.LPwrdBm.AutoSize = True
        Me.LPwrdBm.Location = New System.Drawing.Point(12, 70)
        Me.LPwrdBm.Name = "LPwrdBm"
        Me.LPwrdBm.Size = New System.Drawing.Size(99, 13)
        Me.LPwrdBm.TabIndex = 52
        Me.LPwrdBm.Text = "Power in SPA(dBm)"
        '
        'TBPowerdBm
        '
        Me.TBPowerdBm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBPowerdBm.ForeColor = System.Drawing.Color.Red
        Me.TBPowerdBm.Location = New System.Drawing.Point(130, 68)
        Me.TBPowerdBm.Name = "TBPowerdBm"
        Me.TBPowerdBm.ReadOnly = True
        Me.TBPowerdBm.Size = New System.Drawing.Size(69, 20)
        Me.TBPowerdBm.TabIndex = 53
        '
        'LMeasDistance
        '
        Me.LMeasDistance.AutoSize = True
        Me.LMeasDistance.Location = New System.Drawing.Point(210, 24)
        Me.LMeasDistance.Name = "LMeasDistance"
        Me.LMeasDistance.Size = New System.Drawing.Size(133, 13)
        Me.LMeasDistance.TabIndex = 37
        Me.LMeasDistance.Text = "Measurement Distance(m) "
        '
        'TBMeasDistance
        '
        Me.TBMeasDistance.Location = New System.Drawing.Point(375, 22)
        Me.TBMeasDistance.Name = "TBMeasDistance"
        Me.TBMeasDistance.Size = New System.Drawing.Size(59, 20)
        Me.TBMeasDistance.TabIndex = 38
        '
        'GBReport
        '
        Me.GBReport.Controls.Add(Me.LNamaDut)
        Me.GBReport.Controls.Add(Me.LMerekDUT)
        Me.GBReport.Controls.Add(Me.TBMerekDUT)
        Me.GBReport.Controls.Add(Me.TBKomentar)
        Me.GBReport.Controls.Add(Me.TBNamaDUT)
        Me.GBReport.Controls.Add(Me.LOperator)
        Me.GBReport.Controls.Add(Me.TBTipeDUT)
        Me.GBReport.Controls.Add(Me.LTipeDUT)
        Me.GBReport.Controls.Add(Me.TBOperator)
        Me.GBReport.Controls.Add(Me.LKomentar)
        Me.GBReport.Controls.Add(Me.LNoSeri)
        Me.GBReport.Controls.Add(Me.TBNoSeri)
        Me.GBReport.Location = New System.Drawing.Point(358, 38)
        Me.GBReport.Name = "GBReport"
        Me.GBReport.Size = New System.Drawing.Size(461, 153)
        Me.GBReport.TabIndex = 49
        Me.GBReport.TabStop = False
        Me.GBReport.Text = "Report Information"
        '
        'LNamaDut
        '
        Me.LNamaDut.AutoSize = True
        Me.LNamaDut.Location = New System.Drawing.Point(6, 22)
        Me.LNamaDut.Name = "LNamaDut"
        Me.LNamaDut.Size = New System.Drawing.Size(44, 13)
        Me.LNamaDut.TabIndex = 37
        Me.LNamaDut.Text = "Device "
        '
        'LMerekDUT
        '
        Me.LMerekDUT.AutoSize = True
        Me.LMerekDUT.Location = New System.Drawing.Point(6, 48)
        Me.LMerekDUT.Name = "LMerekDUT"
        Me.LMerekDUT.Size = New System.Drawing.Size(35, 13)
        Me.LMerekDUT.TabIndex = 43
        Me.LMerekDUT.Text = "Brand"
        '
        'TBMerekDUT
        '
        Me.TBMerekDUT.Location = New System.Drawing.Point(58, 45)
        Me.TBMerekDUT.Name = "TBMerekDUT"
        Me.TBMerekDUT.Size = New System.Drawing.Size(142, 20)
        Me.TBMerekDUT.TabIndex = 40
        '
        'TBKomentar
        '
        Me.TBKomentar.Location = New System.Drawing.Point(208, 42)
        Me.TBKomentar.Multiline = True
        Me.TBKomentar.Name = "TBKomentar"
        Me.TBKomentar.Size = New System.Drawing.Size(232, 102)
        Me.TBKomentar.TabIndex = 48
        '
        'TBNamaDUT
        '
        Me.TBNamaDUT.Location = New System.Drawing.Point(58, 19)
        Me.TBNamaDUT.Name = "TBNamaDUT"
        Me.TBNamaDUT.Size = New System.Drawing.Size(142, 20)
        Me.TBNamaDUT.TabIndex = 38
        '
        'LOperator
        '
        Me.LOperator.AutoSize = True
        Me.LOperator.Location = New System.Drawing.Point(8, 127)
        Me.LOperator.Name = "LOperator"
        Me.LOperator.Size = New System.Drawing.Size(48, 13)
        Me.LOperator.TabIndex = 41
        Me.LOperator.Text = "Operator"
        '
        'TBTipeDUT
        '
        Me.TBTipeDUT.Location = New System.Drawing.Point(58, 98)
        Me.TBTipeDUT.Name = "TBTipeDUT"
        Me.TBTipeDUT.Size = New System.Drawing.Size(142, 20)
        Me.TBTipeDUT.TabIndex = 46
        '
        'LTipeDUT
        '
        Me.LTipeDUT.AutoSize = True
        Me.LTipeDUT.Location = New System.Drawing.Point(6, 101)
        Me.LTipeDUT.Name = "LTipeDUT"
        Me.LTipeDUT.Size = New System.Drawing.Size(31, 13)
        Me.LTipeDUT.TabIndex = 45
        Me.LTipeDUT.Text = "Type"
        '
        'TBOperator
        '
        Me.TBOperator.Location = New System.Drawing.Point(58, 124)
        Me.TBOperator.Name = "TBOperator"
        Me.TBOperator.Size = New System.Drawing.Size(142, 20)
        Me.TBOperator.TabIndex = 42
        '
        'LKomentar
        '
        Me.LKomentar.AutoSize = True
        Me.LKomentar.Location = New System.Drawing.Point(206, 19)
        Me.LKomentar.Name = "LKomentar"
        Me.LKomentar.Size = New System.Drawing.Size(51, 13)
        Me.LKomentar.TabIndex = 47
        Me.LKomentar.Text = "Comment"
        '
        'LNoSeri
        '
        Me.LNoSeri.AutoSize = True
        Me.LNoSeri.Location = New System.Drawing.Point(6, 75)
        Me.LNoSeri.Name = "LNoSeri"
        Me.LNoSeri.Size = New System.Drawing.Size(33, 13)
        Me.LNoSeri.TabIndex = 39
        Me.LNoSeri.Text = "Serial"
        '
        'TBNoSeri
        '
        Me.TBNoSeri.Location = New System.Drawing.Point(58, 72)
        Me.TBNoSeri.Name = "TBNoSeri"
        Me.TBNoSeri.Size = New System.Drawing.Size(142, 20)
        Me.TBNoSeri.TabIndex = 44
        '
        'TXYFAF
        '
        Me.TXYFAF.Controls.Add(Me.CheckBox1)
        Me.TXYFAF.Controls.Add(Me.Label6)
        Me.TXYFAF.Controls.Add(Me.CBYmaxFAF)
        Me.TXYFAF.Controls.Add(Me.CBYminFAF)
        Me.TXYFAF.Controls.Add(Me.Label5)
        Me.TXYFAF.Controls.Add(Me.GroupBox2)
        Me.TXYFAF.Location = New System.Drawing.Point(4, 22)
        Me.TXYFAF.Margin = New System.Windows.Forms.Padding(2)
        Me.TXYFAF.Name = "TXYFAF"
        Me.TXYFAF.Padding = New System.Windows.Forms.Padding(2)
        Me.TXYFAF.Size = New System.Drawing.Size(932, 586)
        Me.TXYFAF.TabIndex = 5
        Me.TXYFAF.Text = "Antenna Factor Vs Frequency (XY chart)"
        Me.TXYFAF.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(746, 300)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Y(min)"
        '
        'CBYmaxFAF
        '
        Me.CBYmaxFAF.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBYmaxFAF.FormattingEnabled = True
        Me.CBYmaxFAF.Items.AddRange(New Object() {"+100 dB", "+90 dB", "+80 dB", "+70 dB", "+60 dB", "+50 dB", "+40 dB", "+30 dB", "+20 dB", "+10 dB", "     0 dB", " -10 dB", " -20 dB", " -30 dB", " -40 dB", " -50 dB", " -60 dB", " -70 dB", " -80 dB", " -90 dB", "-100 dB", "-110 dB", "-120 dB", "-130 dB", "-140 dB", "-150 dB", "-160 dB", "-170 dB", "-180 dB"})
        Me.CBYmaxFAF.Location = New System.Drawing.Point(749, 276)
        Me.CBYmaxFAF.Name = "CBYmaxFAF"
        Me.CBYmaxFAF.Size = New System.Drawing.Size(65, 21)
        Me.CBYmaxFAF.TabIndex = 38
        '
        'CBYminFAF
        '
        Me.CBYminFAF.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBYminFAF.FormattingEnabled = True
        Me.CBYminFAF.Items.AddRange(New Object() {"+100 dB", "+90 dB", "+80 dB", "+70 dB", "+60 dB", "+50 dB", "+40 dB", "+30 dB", "+20 dB", "+10 dB", "     0 dB", " -10 dB", " -20 dB", " -30 dB", " -40 dB", " -50 dB", " -60 dB", " -70 dB", " -80 dB", " -90 dB", "-100 dB", "-110 dB", "-120 dB", "-130 dB", "-140 dB", "-150 dB", "-160 dB", "-170 dB", "-180 dB"})
        Me.CBYminFAF.Location = New System.Drawing.Point(749, 316)
        Me.CBYminFAF.Name = "CBYminFAF"
        Me.CBYminFAF.Size = New System.Drawing.Size(65, 21)
        Me.CBYminFAF.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(746, 249)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Y(max)"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.ZedFAF)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(732, 545)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "AP Caertesian Plot"
        '
        'ZedFAF
        '
        Me.ZedFAF.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.ZedFAF.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ZedFAF.BackColor = System.Drawing.Color.White
        Me.ZedFAF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZedFAF.IsShowPointValues = True
        Me.ZedFAF.Location = New System.Drawing.Point(16, 19)
        Me.ZedFAF.Name = "ZedFAF"
        Me.ZedFAF.PointValueFormat = "G"
        Me.ZedFAF.Size = New System.Drawing.Size(696, 448)
        Me.ZedFAF.TabIndex = 8
        '
        'SerialPort
        '
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(702, 469)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(122, 17)
        Me.CheckBox1.TabIndex = 65
        Me.CheckBox1.Text = "Tool tip Help Enable"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Location = New System.Drawing.Point(697, 484)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(122, 17)
        Me.CheckBox2.TabIndex = 67
        Me.CheckBox2.Text = "Tool tip Help Enable"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'FormDirect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(828, 576)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Func_tab)
        Me.Controls.Add(Me.MenuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(850, 658)
        Me.MinimizeBox = False
        Me.Name = "FormDirect"
        Me.Text = "Antenna Pattern Measurement Software"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.GBSpecControl.ResumeLayout(False)
        Me.GBOffset.ResumeLayout(False)
        Me.GBOffset.PerformLayout()
        Me.GBSAControl.ResumeLayout(False)
        Me.GBSAControl.PerformLayout()
        Me.GBControl.ResumeLayout(False)
        Me.GBControl.PerformLayout()
        Me.GBComm.ResumeLayout(False)
        Me.GBComm.PerformLayout()
        Me.TAPolar.ResumeLayout(False)
        Me.GBLog.ResumeLayout(False)
        Me.GBLog.PerformLayout()
        Me.GBAPPolar.ResumeLayout(False)
        CType(Me.CHAPP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TXYAP.ResumeLayout(False)
        Me.TXYAP.PerformLayout()
        Me.GBBarChartLvlDF.ResumeLayout(False)
        Me.GBBarChartLvlDF.PerformLayout()
        Me.Func_tab.ResumeLayout(False)
        Me.Setting.ResumeLayout(False)
        Me.Setting.PerformLayout()
        Me.GBAF.ResumeLayout(False)
        Me.GBAF.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GBReport.ResumeLayout(False)
        Me.GBReport.PerformLayout()
        Me.TXYFAF.ResumeLayout(False)
        Me.TXYFAF.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartLogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveLogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConnectTCPIPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisconnectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RFMeasUnitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AntennaUnitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GBSpecControl As System.Windows.Forms.GroupBox
    Friend WithEvents Statusbarcon As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents FileToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GBControl As System.Windows.Forms.GroupBox
    Friend WithEvents TS_ETH_TX As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TimerAntennaPattern As System.Windows.Forms.Timer
    Friend WithEvents BTTCW As System.Windows.Forms.Button
    Friend WithEvents BTT0 As System.Windows.Forms.Button
    Friend WithEvents BTTCCW As System.Windows.Forms.Button
    Friend WithEvents BConnect As System.Windows.Forms.Button
    Friend WithEvents TextPort As System.Windows.Forms.TextBox
    Friend WithEvents TextIP As System.Windows.Forms.TextBox
    Friend WithEvents LIP As System.Windows.Forms.Label
    Friend WithEvents LPort As System.Windows.Forms.Label
    Friend WithEvents LMeasReceiver As System.Windows.Forms.Label
    Friend WithEvents LDFAntenna As System.Windows.Forms.Label
    Friend WithEvents LCOM As System.Windows.Forms.Label
    Friend WithEvents GBComm As System.Windows.Forms.GroupBox
    Friend WithEvents TimerCheck As System.Windows.Forms.Timer
    Friend WithEvents SaveSettingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Protected Friend WithEvents BTTSetCent As System.Windows.Forms.Button
    Friend WithEvents BTT180 As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents BConTT As System.Windows.Forms.Button
    Friend WithEvents LAngleAP As System.Windows.Forms.Label
    Friend WithEvents LAngle As System.Windows.Forms.Label
    Friend WithEvents TSrtxstat As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TSSLTTStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents BAPRport As System.Windows.Forms.Button
    Friend WithEvents CLIncludeTable As System.Windows.Forms.CheckBox
    Friend WithEvents BSaveReport As System.Windows.Forms.Button
    Friend WithEvents BRptClr As System.Windows.Forms.Button
    Friend WithEvents TAPolar As System.Windows.Forms.TabPage
    Friend WithEvents TXYAP As System.Windows.Forms.TabPage
    Friend WithEvents Func_tab As System.Windows.Forms.TabControl
    Friend WithEvents GBOffset As System.Windows.Forms.GroupBox
    Friend WithEvents BSetCor As System.Windows.Forms.Button
    Friend WithEvents GBBarChartLvlDF As System.Windows.Forms.GroupBox
    Friend WithEvents ZedGraphAP As ZedGraph.ZedGraphControl
    Friend WithEvents CHAPP As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Setting As System.Windows.Forms.TabPage
    Friend WithEvents CBmaxYax As System.Windows.Forms.ComboBox
    Friend WithEvents LYmin As System.Windows.Forms.Label
    Friend WithEvents CBminYax As System.Windows.Forms.ComboBox
    Friend WithEvents LYmax As System.Windows.Forms.Label
    Friend WithEvents GBAPPolar As System.Windows.Forms.GroupBox
    Friend WithEvents CBPolAPYmax As System.Windows.Forms.ComboBox
    Friend WithEvents LYminPolar As System.Windows.Forms.Label
    Friend WithEvents CBPolAPYmin As System.Windows.Forms.ComboBox
    Friend WithEvents LYmaxPolar As System.Windows.Forms.Label
    Friend WithEvents APTB As System.Windows.Forms.TextBox
    Friend WithEvents TBKomentar As System.Windows.Forms.TextBox
    Friend WithEvents TBTipeDUT As System.Windows.Forms.TextBox
    Friend WithEvents LNamaDut As System.Windows.Forms.Label
    Friend WithEvents TBNoSeri As System.Windows.Forms.TextBox
    Friend WithEvents LNoSeri As System.Windows.Forms.Label
    Friend WithEvents LKomentar As System.Windows.Forms.Label
    Friend WithEvents TBOperator As System.Windows.Forms.TextBox
    Friend WithEvents LTipeDUT As System.Windows.Forms.Label
    Friend WithEvents LOperator As System.Windows.Forms.Label
    Friend WithEvents TBNamaDUT As System.Windows.Forms.TextBox
    Friend WithEvents TBMerekDUT As System.Windows.Forms.TextBox
    Friend WithEvents LMerekDUT As System.Windows.Forms.Label
    Friend WithEvents GBLog As System.Windows.Forms.GroupBox
    Friend WithEvents GBReport As System.Windows.Forms.GroupBox
    Friend WithEvents BClearAFlist As System.Windows.Forms.Button
    Friend WithEvents GBAF As System.Windows.Forms.GroupBox
    Friend WithEvents BAddToListAPList As System.Windows.Forms.Button
    Friend WithEvents BSaveToCSvAFList As System.Windows.Forms.Button
    Friend WithEvents LMeasDistance As System.Windows.Forms.Label
    Friend WithEvents TBAFList As System.Windows.Forms.TextBox
    Friend WithEvents TBMeasDistance As System.Windows.Forms.TextBox
    Friend WithEvents LCorFac As System.Windows.Forms.Label
    Friend WithEvents TBCorFac As System.Windows.Forms.TextBox
    Friend WithEvents LPwrdBm As System.Windows.Forms.Label
    Friend WithEvents TBPowerdBm As System.Windows.Forms.TextBox
    Friend WithEvents LAntennaCorr As System.Windows.Forms.Label
    Friend WithEvents TBAntCorr As System.Windows.Forms.TextBox
    Friend WithEvents TBAmpCorr As System.Windows.Forms.TextBox
    Friend WithEvents LCableCorr As System.Windows.Forms.Label
    Friend WithEvents TBUserCorr As System.Windows.Forms.TextBox
    Friend WithEvents TBCableCorr As System.Windows.Forms.TextBox
    Friend WithEvents LAmplifierCorr As System.Windows.Forms.Label
    Friend WithEvents LUserCorr As System.Windows.Forms.Label
    Friend WithEvents BAutoscalePol As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TBDUTAF As System.Windows.Forms.TextBox
    Friend WithEvents TBFSL As System.Windows.Forms.TextBox
    Friend WithEvents LcalFSL As System.Windows.Forms.Label
    Friend WithEvents LMeasAF As System.Windows.Forms.Label
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadDemoDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LAF As System.Windows.Forms.Label
    Friend WithEvents TBAF As System.Windows.Forms.TextBox
    Friend WithEvents TBDUTAG As System.Windows.Forms.TextBox
    Friend WithEvents LDUTAG As System.Windows.Forms.Label
    Friend WithEvents LPEIRP As System.Windows.Forms.Label
    Friend WithEvents TBEIRPow As System.Windows.Forms.TextBox
    Friend WithEvents CBComPort As System.Windows.Forms.ComboBox
    Friend WithEvents BScanPort As System.Windows.Forms.Button
    Friend WithEvents SerialPort As System.IO.Ports.SerialPort
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CBStepSize As System.Windows.Forms.ComboBox
    Friend WithEvents GBSAControl As System.Windows.Forms.GroupBox
    Friend WithEvents BNormalize As System.Windows.Forms.Button
    Friend WithEvents CBAttenuatorInt As System.Windows.Forms.ComboBox
    Friend WithEvents LAtt As System.Windows.Forms.Label
    Friend WithEvents CBTG As System.Windows.Forms.CheckBox
    Friend WithEvents BSetSPACtrl As System.Windows.Forms.Button
    Friend WithEvents CBRL As System.Windows.Forms.ComboBox
    Friend WithEvents LRL As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BStopAP As System.Windows.Forms.Button
    Friend WithEvents BAntPattern As System.Windows.Forms.Button
    Friend WithEvents CBTTH As System.Windows.Forms.CheckBox
    Protected Friend WithEvents BReleaseMotor As System.Windows.Forms.Button
    Friend WithEvents TSSLSeparator As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TBFStop As Windows.Forms.TextBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents TBFStart As Windows.Forms.TextBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents LRBW As Windows.Forms.Label
    Friend WithEvents CBRBW As Windows.Forms.ComboBox
    Friend WithEvents CBTGLvl As Windows.Forms.ComboBox
    Friend WithEvents LTGLvl As Windows.Forms.Label
    Friend WithEvents TXYFAF As Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents ZedFAF As ZedGraph.ZedGraphControl
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents CBYmaxFAF As Windows.Forms.ComboBox
    Friend WithEvents CBYminFAF As Windows.Forms.ComboBox
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents CBBFreq As Windows.Forms.ComboBox
    Friend WithEvents CBBFStep As Windows.Forms.ComboBox
    Friend WithEvents BSetCorr As Windows.Forms.Button
    Friend WithEvents CheckBox1 As Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As Windows.Forms.CheckBox
End Class
