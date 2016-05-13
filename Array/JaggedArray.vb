Option Explicit
Imports System
Module JaggedArray
	Sub main()
		Dim a As Integer()()=New Integer(4)(){}

		a(0)=New Integer(){0,1,2}
		a(1)=New Integer(){0,1,2,3,4}
		a(2)=New Integer(){0,1,2,3}
		a(3)=New Integer(){0,1}
		a(4)=New Integer(){0,1,2,3,4,5}
		
		For i=0 To a.length-1
			For j=0 To a(i).length-1
				Console.write(a(i)(j))
			Next j
			Console.writeLine("")
		Next i
	End Sub
End Module	