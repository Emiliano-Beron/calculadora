﻿Class Calculadora

    Private numero1 As Double
    Private numero2 As Double
    Private resultado As Double

    Public Sub Calculadora(numero1 As Double, numero2 As Double)

        Me.numero1 = numero1
        Me.numero2 = numero2

    End Sub

    Function setNumeros(numero1 As Double, numero2 As Double)
        Me.numero1 = numero1
        Me.numero2 = numero2
    End Function

    Function suma(num1 As Double, num2 As Double) As Double
        resultado = numero1 + numero2
        Return resultado
    End Function

    Function resta(numero1 As Double, numero2 As Double) As Double
        resultado = numero1 - numero2
        Return resultado
    End Function

    Function multiplicacion(numero1 As Double, numero2 As Double) As Double
        resultado = (numero1 * numero2)
        Return resultado
    End Function

    Public Function division(numero1 As Double, numero2 As Double)
        resultado = numero1 / numero2
    End Function

End Class
