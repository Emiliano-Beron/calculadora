Module main
    Public Sub Main()
        Dim calc As New Calculadora
        Dim op As Integer = 0

        Do
            Console.Write("Ingrese el primer numero: ")
            Dim num1 = Integer.Parse(Console.ReadLine())
            Console.Write("Ingrese el segundo numero: ")
            Dim num2 = Integer.Parse(Console.ReadLine())
            calc.setNumeros(num1, num2)

            Console.WriteLine("Eliga una operacion (1-4)")
            Console.WriteLine("1.Suma")
            Console.WriteLine("2.Resta")
            Console.WriteLine("3.Multiplicacion")
            Console.WriteLine("4.Division")
            Console.Write("Opcion: ")
            op = Integer.Parse(Console.ReadLine())

            Select Case op
                Case 1
                    Console.WriteLine(calc.suma())

                Case 2
                    Console.WriteLine(calc.resta())

                Case 3
                    Console.WriteLine(calc.multiplicacion())

                Case 4
                    Console.WriteLine(calc.division())

                Case Else
                    Console.WriteLine("Elija una opcion correcta (1,2,3,4)")
            End Select

        Loop While (op <> 0)

    End Sub

End Module