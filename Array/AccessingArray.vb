Option explicit
Imports System
Module AccessingArray
	Sub main()
		Dim n(10) As Integer

		For i=0 To 10
			n(i)=i+100
		Next i

		For i=0 To 10
			Console.writeLine("Element({0})={1}",i,n(i))
		Next i

		Console.Readkey()
	End Sub
End Module