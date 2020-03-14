Public Class Class1
    Private numero1 As Double
    Private numero2 As Double
    Private resultado As Double

    Public Sub New()

    End Sub
    Public Sub New(numero1 As Double, numero2 As Double, resultado As Double)
        Me.numero1 = numero1
        Me.numero2 = numero2
        Me.resultado = resultado
    End Sub

    Public Sub setNumeros(numero1 As Double, numero2 As Double)
        Me.numero1 = numero1
        Me.numero2 = numero2
    End Sub

    Public Function suma() As Double
        resultado = numero1 + numero2
        Return resultado
    End Function

    Public Function resta() As Double
        resultado = numero1 - numero2
        Return resultado
    End Function

    Public Function multiplicacion() As Double
        resultado = (numero1 * numero2)
        Return resultado
    End Function

    Public Function division() As Double
        resultado = numero1 / numero2
        Return resultado
    End Function

End Class
