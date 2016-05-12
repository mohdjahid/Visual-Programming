Option explicit
Imports System
Module MatrixMul
	Sub main()
		Dim m1(10,10) as Integer
		Dim r,c as Integer
		Console.writeLine("Enter the number of row and column for matrix :")
		r=Console.readLine()
		c=Console.readLine()
		Console.writeLine("Enter Elements")
		
		For i=0 To r-1
			For j=0 To c-1
				m1(i,j)=Console.readLine()
			Next j
		Next i
		
		Console.writeLine("Matrix is:")
		
		For i=0 To r-1
			For j=0 To c-1
				Console.write(m1(i,j))
			Next j
			Console.writeLine()
		Next i
		

		Console.writeLine("Transpose of matrix :")
		
		For i=0 To c-1
			For j=0 To r-1
				Console.write(m1(j,i))
			Next j
			Console.writeLine()
		Next i
	End Sub
End Module