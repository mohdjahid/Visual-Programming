Option explicit
Imports System
Module MatrixMul
	Sub main()
		Dim m1(,) as Integer={
								{1,2,3},
								{4,5,6},
								{7,8,9}
							 }
		Dim m2(,) as Integer={
								{1,2,3},
								{4,5,6},
								{7,8,9}
							 }
		Dim m3(2,2) as Integer

		For i=0 To 2
			For j=0 To 2
				For k=0 To 2
					m3(i,j)+=m1(i,k)*m2(k,j)
				Next k
			Next j
		Next i

		Console.writeLine("Multiplication of matrix")

		For i=0 To 2
			For j=0 To 2
				Console.write("{0} ",m3(i,j))
			Next j
			Console.writeLine()
		Next i
	End Sub
End Module	
