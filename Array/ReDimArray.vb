Option Explicit
Imports System
Module ReDimArray
	Sub main()
		Dim marks() As Integer
		ReDim marks(2)
		marks(0)=85
		marks(1)=75
		marks(2)=90
		ReDim Preserve marks(10)
		marks(3)=80
		marks(4)=76
		marks(5)=92
		marks(6)=99
		marks(7)=79
		marks(8)=75

		For i=0 To 10
			Console.writeLine(i & vbTab &marks(i))
		Next i

		Console.readkey()
	End Sub
End Module	