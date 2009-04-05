Option Strict Off
Option Explicit On
Module Module1
	Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short
	Declare Function ShellExecute Lib "shell32.dll"  Alias "ShellExecuteA"(ByVal hWnd As Integer, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Integer) As Integer
	
	Public Const Author As String = "GXSLKGKSD"
	
	'UPGRADE_WARNING: Structure PointAPI may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Declare Function GetCursorPos Lib "user32" (ByRef lpPoint As PointAPI) As Integer
	Structure PointAPI
		Dim X As Integer
		Dim Y As Integer
	End Structure
	
	Declare Function SetCursorPos Lib "user32" (ByVal X As Integer, ByVal Y As Integer) As Integer
	Declare Sub mouse_event Lib "user32" (ByVal dwFlags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cButtons As Integer, ByVal dwExtraInfo As Integer)
	Public Const MOUSEEVENTF_LEFTDOWN As Integer = &H2
	Public Const MOUSEEVENTF_LEFTUP As Integer = &H4
	
	
	Sub MouseMove(ByRef xP As Integer, ByRef yP As Integer)
		Dim move As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object move. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		move = SetCursorPos(xP, yP)
	End Sub
	
	
	Sub LeftClick(ByRef xP As Integer, ByRef yP As Integer)
		mouse_event(MOUSEEVENTF_LEFTDOWN, xP, yP, 0, 0)
		mouse_event(MOUSEEVENTF_LEFTUP, xP, yP, 0, 0)
	End Sub
End Module