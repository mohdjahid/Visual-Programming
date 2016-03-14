Imports System
Module ForEachExample
	Sub main()
		Dim arr() as Integer={1,2,3,4,5}

		For Each i In arr
			Console.writeLine(i)
		Next
	End Sub
End Module		
		