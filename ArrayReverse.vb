Imports System
Module ArrayReverse
 Sub main()
	Dim arr as Integer()={1,2,3,4,5}
	Console.writeLine("Your Array is")
		For i=0 To arr.length-1
			Console.write("{0} ",arr(i))
		Next 
		Console.writeLine()
		Console.writeLine("Array in reverse order is")
		Dim j as Integer=arr.length-1
		Dim temp
		
		For i=0 To arr.length/2
			temp=arr(i)
			arr(i)=arr(j)
			arr(j)=temp
            j=j-1
		Next i

		For i=0 To arr.length-1
			Console.write("{0} ",arr(i))
		Next i
	End Sub
End Module