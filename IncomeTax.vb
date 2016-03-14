Imports System
Module IncomeTax
	Sub main()
	Dim gender as String
	Dim bill,salary as Double

	Console.writeLine("Enter your category")
	Console.writeLine("men")
	Console.writeLine("women")
	Console.writeLine("senior")

	gender=Console.readLine()

	Console.writeLine("Enter Your salary in lakhs")
	salary=Console.readLine()

	If (gender.equals("men")) Then
			If ( salary>=6 ) Then
					Console.writeLine("men & 6")
					bill=(salary*30)/100
			Else If( salary>=4 ) Then
					Console.writeLine("men & 4")
					bill=(salary*20)/100
			Else If ( salary>=2.5 ) Then
					Console.writeLine("men & 2.5")
					bill=(salary*10)/100
			End If

	Else If (gender.equals("women")) Then
			If ( salary>=8 ) Then
					Console.writeLine("women & 8")
					bill=(salary*15)/100
			Else If( salary>=5 ) Then
					Console.writeLine("women & 5")
					bill=(salary*10)/100
			Else If ( salary>=3 )Then
					Console.writeLine("women & 3")
					bill=(salary*8)/100
			End If

	Else If (gender.equals("senior")) Then
			If ( salary>=15 ) Then
					Console.writeLine("senior & 15")
					bill=(salary*15)/100
			Else If( salary>=12 ) Then
					Console.writeLine("senior & 12")
					bill=(salary*15)/100
			Else If ( salary>=10 ) Then
					Console.writeLine("senior & 10")
					bill=(salary*10)/100
			End If
	End If
	
	Console.writeLine("Your Income tax bill is={0} lakh ",bill)

	End Sub
End Module	