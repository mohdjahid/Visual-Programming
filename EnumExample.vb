Imports System
Module EnumExample
	
	Enum StudentCAT
			Regular
			CR
			DI
			ExRegular
	End Enum
	
	Sub main()
		Dim stud as Integer=StudentCAT.Regular
		Console.writeLine("Category is : {0}",stud)
	End Sub
End Module	
