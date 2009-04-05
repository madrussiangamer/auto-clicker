Option Strict Off
Option Explicit On
Friend Class Autoclicker
	Inherits System.Windows.Forms.Form
	
	Private Sub Command1_Click()
		Dim Text5 As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object Text5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Text5 = Text5 - -1
	End Sub
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		Timer2.Enabled = True
		If Text3.Text = "" Then Text3.Text = "0"
		If Text4.Text = "" Then Text4.Text = "0"
		'UPGRADE_WARNING: Timer property Timer2.Interval cannot have a value of 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="169ECF4A-1968-402D-B243-16603CC08604"'
		Timer2.Interval = (CDbl(Text3.Text) * 1000) - CDbl(-(Text4).Text)
	End Sub
	
	Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
		Timer2.Enabled = False
	End Sub
	
	Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
		Dim pos As Object
		Dim pt As PointAPI
		'UPGRADE_WARNING: Couldn't resolve default property of object pos. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		pos = GetCursorPos(pt)
		Text1.Text = CStr(pt.X)
		Text2.Text = CStr(pt.Y)
    End Sub

	
    Private Sub Timer2_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer2.Tick

        Dim xP As Integer
        Dim yP As Integer
        xP = CInt(Text1.Text)
        yP = CInt(Text2.Text)
        'MouseMove((xP), (yP))
        'RaiseEvent MouseMove(xP, yP)
        LeftClick((xP), (yP))
    End Sub
	
	Private Sub Timer3_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer3.Tick
		If GetAsyncKeyState(System.Windows.Forms.Keys.F1) < 0 Or GetAsyncKeyState(System.Windows.Forms.Keys.F6) < 0 Then
			Call Command2_Click(Command2, New System.EventArgs())
		End If
		If GetAsyncKeyState(System.Windows.Forms.Keys.F2) Or GetAsyncKeyState(System.Windows.Forms.Keys.F7) < 0 Then
			Call Command3_Click(Command3, New System.EventArgs())
		End If
	End Sub
End Class