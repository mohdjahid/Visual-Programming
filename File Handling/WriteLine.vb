Imports System.IO
Module WriteLine
	Sub main()
		Dim names As String()=New String(){"JAHID","RAHIL","JAY","UZMA"}
		Using sw as StreamWriter=New StreamWriter("names.txt")

		For Each s In names
			sw.writeLine(s)
		Next s
		End Using
	End Sub
End Module	