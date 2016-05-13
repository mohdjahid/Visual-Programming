Imports System.IO
Module WriteReadChar
	Sub main()
		Dim f1 as FileStream=New FileStream("test.dat",FileMode.OpenOrCreate,FileAccess.ReadWrite)
		
		For i=0 To 20
			f1.WriteByte(CByte(i))
		Next i
		f1.Position=0
		For i=0 To 20
			Console.write("{0} ",f1.ReadByte())
		Next i
		f1.close()

	End Sub
End Module