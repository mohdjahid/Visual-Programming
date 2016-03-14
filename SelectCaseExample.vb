Imports System
Module SelectCaseExample
	Sub main()
		Dim mon as String
		mon=Console.readLine()

		Select mon
			Case "jan"
					Console.writeLine("JANUARY")
			Case "fab"
					Console.writeLine("FEBRUARY")
			Case Else
					Console.writeLine("INVALID MONTH")
		End Select
	End Sub
End Module	