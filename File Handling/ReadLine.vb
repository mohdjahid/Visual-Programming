Imports System.IO
Module ReadLine
	Sub main()
		Try
			Using sr As StreamReader=New StreamReader("Jamaica.txt")
			Dim line As String
			line=sr.ReadLine()
			While(line<>Nothing)
				Console.writeLine(line)
				line=sr.ReadLine()
			End While
			End Using
		Catch e as Exception
			Console.writeLine("Error")
		End Try

	End Sub
End Module