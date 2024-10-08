Option Strict Off
Option Explicit On
Friend Class frmConfig
	Inherits System.Windows.Forms.Form


	Private Sub frmConfig_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

		Dim ip_string
		ip_string = AdresseIP.Split(".")
		Text = "Configuration TCPIP"
		cmdValider.Text = "Valider"
		_txtIP_0.Text = ip_string(0)
		_txtIP_1.Text = ip_string(1)
		_txtIP_2.Text = ip_string(2)
		_txtIP_3.Text = ip_string(3)
	End Sub
	
	Private Sub frmConfig_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		
		frmMain.Enabled = True

	End Sub

	Private Sub cmdValider_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdValider.Click
		
		ErreurRemote = False
        AdresseIP = _txtIP_0.Text.Trim & "." & _txtIP_1.Text.Trim & "." & _txtIP_2.Text.Trim & "." & _txtIP_3.Text.Trim

        frmMain.Enabled = True
        Me.Close()

    End Sub

	Private Sub fraIP_Enter(sender As Object, e As EventArgs) Handles fraIP.Enter

	End Sub




	'Private Sub txtIP_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtIP.TextChanged
	'Dim Index As Short = txtIP.GetIndex(eventSender)

	'   AdresseIP = _txtIP_0.Text.Trim & "." & _txtIP_1.Text.Trim & "." & _txtIP_2.Text.Trim & "." & _txtIP_3.Text.Trim

	'End Sub

End Class