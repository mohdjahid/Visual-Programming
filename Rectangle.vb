Imports System
Class Rectangle
	Private length as Double
	Private width as Double

	Public Sub GetDetail()
		length=4.0
		width=3.0
	End Sub
	
	Public Function GetArea() as Double
		GetArea=length*width
	End Function

	Public Sub Display()
		Console.writeLine("Length={0}",length)
		Console.writeLine("Widthh={0}",width)
		Console.writeLine("Area={0}",GetArea())
	End Sub
	
	shared Sub main()
		Dim r as new Rectangle()
		r.GetDetail()
		r.GetArea()
		r.Display()
		Console.readKey()
	End Sub
End class	

