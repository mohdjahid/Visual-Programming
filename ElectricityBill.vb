Imports System
Module ElectricityBill
 Sub main()
	Dim unit,bill as Integer
	Console.writeLine("Enter your unit which has consumed")
	unit=Console.readLine()
		If ( unit<=200 ) Then
			bill=unit*3.20
		Else If ( unit>=400 ) Then
				bill=unit*4.90
			 Else
				bill=unit*7.00
		End If
		Console.writeLine("Amount to be paid={0}",bill)
 End Sub
End Module