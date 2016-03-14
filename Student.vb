Imports System
Class Student
	Private name as String
	Private roll as Integer
	Private marks as Double

	Public Sub GetDetail()
		Console.writeLine("Enter YOUR name")
		name=Console.readLine()
		Console.writeLine("Enter YOUR roll")
		roll=Console.readLine()
		Console.writeLine("Enter YOUR marks")
		marks=Console.readLine()
	End Sub
	
	Public Sub Result()
		If (marks>=80) Then
			Console.writeLine("PASSED WITH FIRST CLASS")
		Else If (marks>=70)
				Console.writeLine("PASSED WITH SECOND CLASS")
			Else
				Console.writeLine("FAILED")
		End If
	End Sub
	
	Public Function Display() as Double
		Display=marks
	End Function

	shared Sub main()
		Dim s as new Student()
 		s.GetDetail()
		s.Result()
		Console.writeLine("Your marks is : {0}",s.Display())
	End Sub
End Class	