Option explicit
Imports System
Module MatrixMul
	Sub main()
		Dim m1(10,10) as Integer
		Dim m2(10,10) as Integer
		Dim m3(10,10) as Integer

		Dim r1,r2,c1,c2 as Integer
		Console.writeLine("Enter the number of row and column for matrix 1 :")
		r1=Console.readLine()
		c1=Console.readLine()
		Console.writeLine("Enter the number of row and column for matrix 2 :")
		r2=Console.readLine()
		c2=Console.readLine()

		IF r1<>c2 Then
			Console.writeLine("Multiplication not possible")
		
		Else
		Console.writeLine("Enter elements for matrix 1 :")
		For i=0 To r1-1
			For j=0 To c1-1
				m1(i,j)=Console.readLine()
			Next j
		Next i

		Console.writeLine("Enter elements for matrix 2 :")
		For i=0 To r2-1
			For j=0 To c2-1
				m2(i,j)=Console.readLine()
			Next j
		Next i
		
		For i=0 To r1-1
			For j=0 To c1-1
				Console.write(m1(i,j))
			Next j
			Console.writeLine()
		Next i

		For i=0 To r2-1
			For j=0 To c2-1
				Console.write(m2(i,j))
			Next j
			Console.writeLine()
		Next i
		
		Console.writeLine("Multiplication of matrix")
		For i=0 To r1-1
			For j=0 To c2-1
				For k=0 To r2-1
					m3(i,j)+=m1(i,k)*m2(k,j)
				Next k
			Next j
		Next i
		
		For i=0 To r1-1
			For j=0 To c2-1
				Console.write(m3(i,j))
			Next j
			Console.writeLine()
		Next i

		End If
	End Sub
End Module	