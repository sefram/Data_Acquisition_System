<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmMain
#Region "Code généré par le Concepteur Windows Form "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'Cet appel est requis par le Concepteur Windows Form.
		InitializeComponent()
	End Sub
	'Form remplace la méthode Dispose pour nettoyer la liste des composants.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Requise par le Concepteur Windows Form
	Private components As System.ComponentModel.IContainer
    Public WithEvents txtEmission As System.Windows.Forms.RichTextBox
	Public WithEvents CmdReception As System.Windows.Forms.Button
	Public WithEvents cmdEmission As System.Windows.Forms.Button
	Public WithEvents tmrTimeout As System.Windows.Forms.Timer
    Public WithEvents txtReception As System.Windows.Forms.RichTextBox
	Public WithEvents cmdTransfert As System.Windows.Forms.Button
    Public WithEvents chanq_btn As System.Windows.Forms.Button
    Public WithEvents cmdStop As System.Windows.Forms.Button
    Public WithEvents mnuOuvrir As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuEnregistrer As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuQuitter As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents munFichier As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuConfig As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.txtEmission = New System.Windows.Forms.RichTextBox()
        Me.CmdReception = New System.Windows.Forms.Button()
        Me.cmdEmission = New System.Windows.Forms.Button()
        Me.tmrTimeout = New System.Windows.Forms.Timer(Me.components)
        Me.txtReception = New System.Windows.Forms.RichTextBox()
        Me.cmdTransfert = New System.Windows.Forms.Button()
        Me.chanq_btn = New System.Windows.Forms.Button()
        Me.cmdStop = New System.Windows.Forms.Button()
        Me.MainMenu1 = New System.Windows.Forms.MenuStrip()
        Me.munFichier = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOuvrir = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEnregistrer = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuQuitter = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConfig = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.cmdREM = New System.Windows.Forms.Button()
        Me.cmdLOC = New System.Windows.Forms.Button()
        Me.range_btn = New System.Windows.Forms.Button()
        Me.cmdIDN = New System.Windows.Forms.Button()
        Me.type_btn = New System.Windows.Forms.Button()
        Me.valid_btn = New System.Windows.Forms.Button()
        Me.Channel_combobox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.type_combobox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.range_zero = New System.Windows.Forms.NumericUpDown()
        Me.range_pos = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.val_range = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Device_combobox = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox_OLD_DAS = New System.Windows.Forms.GroupBox()
        Me.GroupBoxdas1800 = New System.Windows.Forms.GroupBox()
        Me.btnd18_recoff = New System.Windows.Forms.Button()
        Me.btnd18_rectrig = New System.Windows.Forms.Button()
        Me.btnd18_recon = New System.Windows.Forms.Button()
        Me.btnd18_recq = New System.Windows.Forms.Button()
        Me.btnd18_rdcq = New System.Windows.Forms.Button()
        Me.MainMenu1.SuspendLayout()
        CType(Me.range_zero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.range_pos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.val_range, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_OLD_DAS.SuspendLayout()
        Me.GroupBoxdas1800.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtEmission
        '
        Me.txtEmission.Location = New System.Drawing.Point(8, 27)
        Me.txtEmission.Name = "txtEmission"
        Me.txtEmission.Size = New System.Drawing.Size(321, 454)
        Me.txtEmission.TabIndex = 5
        Me.txtEmission.Text = ""
        '
        'CmdReception
        '
        Me.CmdReception.BackColor = System.Drawing.SystemColors.Control
        Me.CmdReception.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdReception.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdReception.Image = CType(resources.GetObject("CmdReception.Image"), System.Drawing.Image)
        Me.CmdReception.Location = New System.Drawing.Point(336, 488)
        Me.CmdReception.Name = "CmdReception"
        Me.CmdReception.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdReception.Size = New System.Drawing.Size(321, 49)
        Me.CmdReception.TabIndex = 4
        Me.CmdReception.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdReception.UseVisualStyleBackColor = False
        '
        'cmdEmission
        '
        Me.cmdEmission.BackColor = System.Drawing.SystemColors.Control
        Me.cmdEmission.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdEmission.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdEmission.Image = CType(resources.GetObject("cmdEmission.Image"), System.Drawing.Image)
        Me.cmdEmission.Location = New System.Drawing.Point(8, 488)
        Me.cmdEmission.Name = "cmdEmission"
        Me.cmdEmission.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdEmission.Size = New System.Drawing.Size(321, 49)
        Me.cmdEmission.TabIndex = 3
        Me.cmdEmission.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdEmission.UseVisualStyleBackColor = False
        '
        'tmrTimeout
        '
        Me.tmrTimeout.Interval = 1000
        '
        'txtReception
        '
        Me.txtReception.Location = New System.Drawing.Point(336, 27)
        Me.txtReception.Name = "txtReception"
        Me.txtReception.ReadOnly = True
        Me.txtReception.Size = New System.Drawing.Size(321, 454)
        Me.txtReception.TabIndex = 5
        Me.txtReception.Text = ""
        '
        'cmdTransfert
        '
        Me.cmdTransfert.BackColor = System.Drawing.SystemColors.Control
        Me.cmdTransfert.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdTransfert.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdTransfert.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdTransfert.Location = New System.Drawing.Point(663, 92)
        Me.cmdTransfert.Name = "cmdTransfert"
        Me.cmdTransfert.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdTransfert.Size = New System.Drawing.Size(57, 57)
        Me.cmdTransfert.TabIndex = 0
        Me.cmdTransfert.Text = "RUN"
        Me.cmdTransfert.UseVisualStyleBackColor = False
        '
        'chanq_btn
        '
        Me.chanq_btn.BackColor = System.Drawing.SystemColors.Control
        Me.chanq_btn.Cursor = System.Windows.Forms.Cursors.Default
        Me.chanq_btn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chanq_btn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chanq_btn.Location = New System.Drawing.Point(6, 208)
        Me.chanq_btn.Name = "chanq_btn"
        Me.chanq_btn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chanq_btn.Size = New System.Drawing.Size(57, 57)
        Me.chanq_btn.TabIndex = 2
        Me.chanq_btn.Text = "CHAN ?"
        Me.chanq_btn.UseVisualStyleBackColor = False
        '
        'cmdStop
        '
        Me.cmdStop.BackColor = System.Drawing.SystemColors.Control
        Me.cmdStop.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdStop.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdStop.Image = CType(resources.GetObject("cmdStop.Image"), System.Drawing.Image)
        Me.cmdStop.Location = New System.Drawing.Point(726, 92)
        Me.cmdStop.Name = "cmdStop"
        Me.cmdStop.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdStop.Size = New System.Drawing.Size(57, 57)
        Me.cmdStop.TabIndex = 1
        Me.cmdStop.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdStop.UseVisualStyleBackColor = False
        '
        'MainMenu1
        '
        Me.MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.munFichier, Me.mnuConfig})
        Me.MainMenu1.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu1.Name = "MainMenu1"
        Me.MainMenu1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MainMenu1.Size = New System.Drawing.Size(931, 24)
        Me.MainMenu1.TabIndex = 7
        '
        'munFichier
        '
        Me.munFichier.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOuvrir, Me.mnuEnregistrer, Me.mnuQuitter})
        Me.munFichier.Name = "munFichier"
        Me.munFichier.Size = New System.Drawing.Size(42, 20)
        Me.munFichier.Text = "&Files"
        '
        'mnuOuvrir
        '
        Me.mnuOuvrir.Name = "mnuOuvrir"
        Me.mnuOuvrir.Size = New System.Drawing.Size(103, 22)
        Me.mnuOuvrir.Text = "&Open"
        '
        'mnuEnregistrer
        '
        Me.mnuEnregistrer.Name = "mnuEnregistrer"
        Me.mnuEnregistrer.Size = New System.Drawing.Size(103, 22)
        Me.mnuEnregistrer.Text = "&Save"
        '
        'mnuQuitter
        '
        Me.mnuQuitter.Name = "mnuQuitter"
        Me.mnuQuitter.Size = New System.Drawing.Size(103, 22)
        Me.mnuQuitter.Text = "&Quit"
        '
        'mnuConfig
        '
        Me.mnuConfig.Name = "mnuConfig"
        Me.mnuConfig.Size = New System.Drawing.Size(54, 20)
        Me.mnuConfig.Text = "&DAS IP"
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'cmdREM
        '
        Me.cmdREM.BackColor = System.Drawing.SystemColors.Control
        Me.cmdREM.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdREM.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdREM.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdREM.Location = New System.Drawing.Point(726, 155)
        Me.cmdREM.Name = "cmdREM"
        Me.cmdREM.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdREM.Size = New System.Drawing.Size(57, 57)
        Me.cmdREM.TabIndex = 8
        Me.cmdREM.Text = "*REM"
        Me.cmdREM.UseVisualStyleBackColor = False
        '
        'cmdLOC
        '
        Me.cmdLOC.BackColor = System.Drawing.SystemColors.Control
        Me.cmdLOC.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLOC.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdLOC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdLOC.Location = New System.Drawing.Point(789, 155)
        Me.cmdLOC.Name = "cmdLOC"
        Me.cmdLOC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdLOC.Size = New System.Drawing.Size(57, 57)
        Me.cmdLOC.TabIndex = 9
        Me.cmdLOC.Text = "*LOC"
        Me.cmdLOC.UseVisualStyleBackColor = False
        '
        'range_btn
        '
        Me.range_btn.BackColor = System.Drawing.SystemColors.Control
        Me.range_btn.Cursor = System.Windows.Forms.Cursors.Default
        Me.range_btn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.range_btn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.range_btn.Location = New System.Drawing.Point(6, 145)
        Me.range_btn.Name = "range_btn"
        Me.range_btn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.range_btn.Size = New System.Drawing.Size(57, 57)
        Me.range_btn.TabIndex = 10
        Me.range_btn.Text = "RANGE"
        Me.range_btn.UseVisualStyleBackColor = False
        '
        'cmdIDN
        '
        Me.cmdIDN.BackColor = System.Drawing.SystemColors.Control
        Me.cmdIDN.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdIDN.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdIDN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdIDN.Location = New System.Drawing.Point(663, 155)
        Me.cmdIDN.Name = "cmdIDN"
        Me.cmdIDN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdIDN.Size = New System.Drawing.Size(57, 57)
        Me.cmdIDN.TabIndex = 11
        Me.cmdIDN.Text = "*IDN ?"
        Me.cmdIDN.UseVisualStyleBackColor = False
        '
        'type_btn
        '
        Me.type_btn.BackColor = System.Drawing.SystemColors.Control
        Me.type_btn.Cursor = System.Windows.Forms.Cursors.Default
        Me.type_btn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.type_btn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.type_btn.Location = New System.Drawing.Point(6, 82)
        Me.type_btn.Name = "type_btn"
        Me.type_btn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.type_btn.Size = New System.Drawing.Size(57, 57)
        Me.type_btn.TabIndex = 10
        Me.type_btn.Text = "TYPE:"
        Me.type_btn.UseVisualStyleBackColor = False
        '
        'valid_btn
        '
        Me.valid_btn.BackColor = System.Drawing.SystemColors.Control
        Me.valid_btn.Cursor = System.Windows.Forms.Cursors.Default
        Me.valid_btn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.valid_btn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.valid_btn.Location = New System.Drawing.Point(6, 19)
        Me.valid_btn.Name = "valid_btn"
        Me.valid_btn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.valid_btn.Size = New System.Drawing.Size(57, 57)
        Me.valid_btn.TabIndex = 10
        Me.valid_btn.Text = "VALID"
        Me.valid_btn.UseVisualStyleBackColor = False
        '
        'Channel_combobox
        '
        Me.Channel_combobox.FormattingEnabled = True
        Me.Channel_combobox.Location = New System.Drawing.Point(69, 38)
        Me.Channel_combobox.Name = "Channel_combobox"
        Me.Channel_combobox.Size = New System.Drawing.Size(121, 21)
        Me.Channel_combobox.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "CHANNEL:"
        '
        'type_combobox
        '
        Me.type_combobox.FormattingEnabled = True
        Me.type_combobox.Location = New System.Drawing.Point(69, 82)
        Me.type_combobox.Name = "type_combobox"
        Me.type_combobox.Size = New System.Drawing.Size(121, 21)
        Me.type_combobox.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "TYPE:"
        '
        'range_zero
        '
        Me.range_zero.Location = New System.Drawing.Point(16, 76)
        Me.range_zero.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.range_zero.Name = "range_zero"
        Me.range_zero.Size = New System.Drawing.Size(120, 20)
        Me.range_zero.TabIndex = 14
        '
        'range_pos
        '
        Me.range_pos.Location = New System.Drawing.Point(16, 115)
        Me.range_pos.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.range_pos.Name = "range_pos"
        Me.range_pos.Size = New System.Drawing.Size(120, 20)
        Me.range_pos.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.val_range)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.range_pos)
        Me.GroupBox1.Controls.Add(Me.range_zero)
        Me.GroupBox1.Location = New System.Drawing.Point(73, 121)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(160, 144)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "RANGE:"
        '
        'val_range
        '
        Me.val_range.Location = New System.Drawing.Point(16, 37)
        Me.val_range.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.val_range.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.val_range.Name = "val_range"
        Me.val_range.Size = New System.Drawing.Size(120, 20)
        Me.val_range.TabIndex = 15
        Me.val_range.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Position"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Center Zero"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Range"
        '
        'Device_combobox
        '
        Me.Device_combobox.FormattingEnabled = True
        Me.Device_combobox.Location = New System.Drawing.Point(714, 55)
        Me.Device_combobox.Name = "Device_combobox"
        Me.Device_combobox.Size = New System.Drawing.Size(121, 21)
        Me.Device_combobox.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(711, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "DEVICE:"
        '
        'GroupBox_OLD_DAS
        '
        Me.GroupBox_OLD_DAS.Controls.Add(Me.valid_btn)
        Me.GroupBox_OLD_DAS.Controls.Add(Me.Label2)
        Me.GroupBox_OLD_DAS.Controls.Add(Me.Label1)
        Me.GroupBox_OLD_DAS.Controls.Add(Me.GroupBox1)
        Me.GroupBox_OLD_DAS.Controls.Add(Me.chanq_btn)
        Me.GroupBox_OLD_DAS.Controls.Add(Me.range_btn)
        Me.GroupBox_OLD_DAS.Controls.Add(Me.type_combobox)
        Me.GroupBox_OLD_DAS.Controls.Add(Me.type_btn)
        Me.GroupBox_OLD_DAS.Controls.Add(Me.Channel_combobox)
        Me.GroupBox_OLD_DAS.Location = New System.Drawing.Point(663, 218)
        Me.GroupBox_OLD_DAS.Name = "GroupBox_OLD_DAS"
        Me.GroupBox_OLD_DAS.Size = New System.Drawing.Size(253, 290)
        Me.GroupBox_OLD_DAS.TabIndex = 15
        Me.GroupBox_OLD_DAS.TabStop = False
        Me.GroupBox_OLD_DAS.Text = "Command"
        '
        'GroupBoxdas1800
        '
        Me.GroupBoxdas1800.Controls.Add(Me.btnd18_recoff)
        Me.GroupBoxdas1800.Controls.Add(Me.btnd18_rectrig)
        Me.GroupBoxdas1800.Controls.Add(Me.btnd18_recon)
        Me.GroupBoxdas1800.Controls.Add(Me.btnd18_recq)
        Me.GroupBoxdas1800.Controls.Add(Me.btnd18_rdcq)
        Me.GroupBoxdas1800.Location = New System.Drawing.Point(663, 218)
        Me.GroupBoxdas1800.Name = "GroupBoxdas1800"
        Me.GroupBoxdas1800.Size = New System.Drawing.Size(253, 290)
        Me.GroupBoxdas1800.TabIndex = 15
        Me.GroupBoxdas1800.TabStop = False
        Me.GroupBoxdas1800.Text = "Command"
        '
        'btnd18_recoff
        '
        Me.btnd18_recoff.BackColor = System.Drawing.SystemColors.Control
        Me.btnd18_recoff.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnd18_recoff.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnd18_recoff.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnd18_recoff.Location = New System.Drawing.Point(136, 156)
        Me.btnd18_recoff.Name = "btnd18_recoff"
        Me.btnd18_recoff.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnd18_recoff.Size = New System.Drawing.Size(57, 57)
        Me.btnd18_recoff.TabIndex = 10
        Me.btnd18_recoff.Text = "REC OFF"
        Me.btnd18_recoff.UseVisualStyleBackColor = False
        '
        'btnd18_rectrig
        '
        Me.btnd18_rectrig.BackColor = System.Drawing.SystemColors.Control
        Me.btnd18_rectrig.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnd18_rectrig.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnd18_rectrig.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnd18_rectrig.Location = New System.Drawing.Point(136, 93)
        Me.btnd18_rectrig.Name = "btnd18_rectrig"
        Me.btnd18_rectrig.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnd18_rectrig.Size = New System.Drawing.Size(57, 57)
        Me.btnd18_rectrig.TabIndex = 10
        Me.btnd18_rectrig.Text = "REC TRIG"
        Me.btnd18_rectrig.UseVisualStyleBackColor = False
        '
        'btnd18_recon
        '
        Me.btnd18_recon.BackColor = System.Drawing.SystemColors.Control
        Me.btnd18_recon.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnd18_recon.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnd18_recon.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnd18_recon.Location = New System.Drawing.Point(136, 19)
        Me.btnd18_recon.Name = "btnd18_recon"
        Me.btnd18_recon.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnd18_recon.Size = New System.Drawing.Size(57, 57)
        Me.btnd18_recon.TabIndex = 10
        Me.btnd18_recon.Text = "REC ON"
        Me.btnd18_recon.UseVisualStyleBackColor = False
        '
        'btnd18_recq
        '
        Me.btnd18_recq.BackColor = System.Drawing.SystemColors.Control
        Me.btnd18_recq.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnd18_recq.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnd18_recq.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnd18_recq.Location = New System.Drawing.Point(6, 19)
        Me.btnd18_recq.Name = "btnd18_recq"
        Me.btnd18_recq.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnd18_recq.Size = New System.Drawing.Size(57, 57)
        Me.btnd18_recq.TabIndex = 10
        Me.btnd18_recq.Text = "REC ?"
        Me.btnd18_recq.UseVisualStyleBackColor = False
        '
        'btnd18_rdcq
        '
        Me.btnd18_rdcq.BackColor = System.Drawing.SystemColors.Control
        Me.btnd18_rdcq.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnd18_rdcq.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnd18_rdcq.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnd18_rdcq.Location = New System.Drawing.Point(6, 82)
        Me.btnd18_rdcq.Name = "btnd18_rdcq"
        Me.btnd18_rdcq.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnd18_rdcq.Size = New System.Drawing.Size(57, 57)
        Me.btnd18_rdcq.TabIndex = 10
        Me.btnd18_rdcq.Text = "RDC ?"
        Me.btnd18_rdcq.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(931, 543)
        Me.Controls.Add(Me.GroupBoxdas1800)
        Me.Controls.Add(Me.GroupBox_OLD_DAS)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Device_combobox)
        Me.Controls.Add(Me.cmdIDN)
        Me.Controls.Add(Me.cmdLOC)
        Me.Controls.Add(Me.cmdREM)
        Me.Controls.Add(Me.txtEmission)
        Me.Controls.Add(Me.CmdReception)
        Me.Controls.Add(Me.cmdEmission)
        Me.Controls.Add(Me.txtReception)
        Me.Controls.Add(Me.cmdTransfert)
        Me.Controls.Add(Me.cmdStop)
        Me.Controls.Add(Me.MainMenu1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(3, 35)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DAS SCPI"
        Me.MainMenu1.ResumeLayout(False)
        Me.MainMenu1.PerformLayout()
        CType(Me.range_zero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.range_pos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.val_range, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_OLD_DAS.ResumeLayout(False)
        Me.GroupBox_OLD_DAS.PerformLayout()
        Me.GroupBoxdas1800.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
    Public WithEvents cmdREM As System.Windows.Forms.Button
    Public WithEvents cmdLOC As System.Windows.Forms.Button
    Public WithEvents range_btn As System.Windows.Forms.Button
    Public WithEvents cmdIDN As System.Windows.Forms.Button
    Public WithEvents type_btn As System.Windows.Forms.Button
    Public WithEvents valid_btn As System.Windows.Forms.Button
    Friend WithEvents Channel_combobox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents type_combobox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents range_zero As System.Windows.Forms.NumericUpDown
    Friend WithEvents range_pos As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Device_combobox As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents val_range As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox_OLD_DAS As GroupBox
    Friend WithEvents GroupBoxdas1800 As GroupBox
    Public WithEvents btnd18_recoff As Button
    Public WithEvents btnd18_rectrig As Button
    Public WithEvents btnd18_recon As Button
    Public WithEvents btnd18_recq As Button
    Public WithEvents btnd18_rdcq As Button
#End Region
End Class