Option Strict Off
Option Explicit On
'UPGRADE_NOTE: Menu was upgraded to Menu_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
Friend Class Menu_Renamed
	Inherits System.Windows.Forms.Form
	
	
	Private Sub Command10_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command10.Click
        ShellExecute(0, vbNullString, "http://auto-clicker.googlecode.com", "", "", 1)
		End
	End Sub
	
	Private Sub Command11_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command11.Click
		Autoclicker.Show()
	End Sub
	
    Private Sub Command1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AboutBox1.ShowDialog()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()





    End Sub
End Class