Imports System.Exception
Module DivideByZero
	Sub division(ByVal num1 As Integer,ByVal num2 As Integer)
		Dim result As Integer
		Try
			result=num1\num2
		Catch e As DivideByZeroException
			Console.writeLine("Exception caught: {0}",e)
		Finally
			Console.writeLine("Result: {0}",result)
		End Try
	End Sub
	Sub main()
		division(25,0)
	End Sub
End Module	