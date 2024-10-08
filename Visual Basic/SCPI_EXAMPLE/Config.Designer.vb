<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmConfig
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
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents _txtIP_0 As System.Windows.Forms.TextBox
	Public WithEvents _txtIP_1 As System.Windows.Forms.TextBox
	Public WithEvents _txtIP_2 As System.Windows.Forms.TextBox
	Public WithEvents _txtIP_3 As System.Windows.Forms.TextBox
	Public WithEvents fraIP As System.Windows.Forms.GroupBox
    Public WithEvents cmdValider As System.Windows.Forms.Button

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfig))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.fraIP = New System.Windows.Forms.GroupBox()
        Me._txtIP_0 = New System.Windows.Forms.TextBox()
        Me._txtIP_1 = New System.Windows.Forms.TextBox()
        Me._txtIP_2 = New System.Windows.Forms.TextBox()
        Me._txtIP_3 = New System.Windows.Forms.TextBox()
        Me.cmdValider = New System.Windows.Forms.Button()
        Me.fraIP.SuspendLayout()
        Me.SuspendLayout()
        '
        'fraIP
        '
        Me.fraIP.BackColor = System.Drawing.SystemColors.Control
        Me.fraIP.Controls.Add(Me._txtIP_0)
        Me.fraIP.Controls.Add(Me._txtIP_1)
        Me.fraIP.Controls.Add(Me._txtIP_2)
        Me.fraIP.Controls.Add(Me._txtIP_3)
        Me.fraIP.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraIP.Location = New System.Drawing.Point(8, 8)
        Me.fraIP.Name = "fraIP"
        Me.fraIP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraIP.Size = New System.Drawing.Size(272, 57)
        Me.fraIP.TabIndex = 2
        Me.fraIP.TabStop = False
        Me.fraIP.Text = "IP address"
        '
        '_txtIP_0
        '
        Me._txtIP_0.AcceptsReturn = True
        Me._txtIP_0.BackColor = System.Drawing.SystemColors.Window
        Me._txtIP_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtIP_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtIP_0.Location = New System.Drawing.Point(8, 24)
        Me._txtIP_0.MaxLength = 0
        Me._txtIP_0.Name = "_txtIP_0"
        Me._txtIP_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtIP_0.Size = New System.Drawing.Size(57, 20)
        Me._txtIP_0.TabIndex = 6
        Me._txtIP_0.Text = "192"
        Me._txtIP_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtIP_1
        '
        Me._txtIP_1.AcceptsReturn = True
        Me._txtIP_1.BackColor = System.Drawing.SystemColors.Window
        Me._txtIP_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtIP_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtIP_1.Location = New System.Drawing.Point(72, 24)
        Me._txtIP_1.MaxLength = 0
        Me._txtIP_1.Name = "_txtIP_1"
        Me._txtIP_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtIP_1.Size = New System.Drawing.Size(57, 20)
        Me._txtIP_1.TabIndex = 5
        Me._txtIP_1.Text = "168"
        Me._txtIP_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtIP_2
        '
        Me._txtIP_2.AcceptsReturn = True
        Me._txtIP_2.BackColor = System.Drawing.SystemColors.Window
        Me._txtIP_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtIP_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtIP_2.Location = New System.Drawing.Point(136, 24)
        Me._txtIP_2.MaxLength = 0
        Me._txtIP_2.Name = "_txtIP_2"
        Me._txtIP_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtIP_2.Size = New System.Drawing.Size(57, 20)
        Me._txtIP_2.TabIndex = 4
        Me._txtIP_2.Text = "0"
        Me._txtIP_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtIP_3
        '
        Me._txtIP_3.AcceptsReturn = True
        Me._txtIP_3.BackColor = System.Drawing.SystemColors.Window
        Me._txtIP_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtIP_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtIP_3.Location = New System.Drawing.Point(200, 24)
        Me._txtIP_3.MaxLength = 0
        Me._txtIP_3.Name = "_txtIP_3"
        Me._txtIP_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtIP_3.Size = New System.Drawing.Size(57, 20)
        Me._txtIP_3.TabIndex = 3
        Me._txtIP_3.Text = "50"
        Me._txtIP_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdValider
        '
        Me.cmdValider.BackColor = System.Drawing.SystemColors.Control
        Me.cmdValider.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdValider.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdValider.Location = New System.Drawing.Point(8, 72)
        Me.cmdValider.Name = "cmdValider"
        Me.cmdValider.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdValider.Size = New System.Drawing.Size(270, 33)
        Me.cmdValider.TabIndex = 0
        Me.cmdValider.Text = "OK"
        Me.cmdValider.UseVisualStyleBackColor = False
        '
        'frmConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(290, 117)
        Me.Controls.Add(Me.fraIP)
        Me.Controls.Add(Me.cmdValider)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(103, 110)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConfig"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "#"
        Me.fraIP.ResumeLayout(False)
        Me.fraIP.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
#End Region
End Class