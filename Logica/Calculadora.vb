Public Class Calculadora
    Property _numero1 As Integer
    Property _numero2 As Integer

    Public Sub New()

    End Sub
    Public Sub New(_numero1 As Integer, _numero2 As Integer)
        Me._numero1 = _numero1
        Me._numero2 = _numero2
    End Sub
    Public Function Suma() As Integer
        Dim resultado As Integer = _numero1 + _numero2
        Return resultado
    End Function

    Public Function Resta() As Integer
        Dim resultado As Integer = _numero1 - _numero2
        Return resultado
    End Function

    Public Function Multiplicacion() As Integer
        Dim resultado As Integer = (_numero1 * _numero2)
        Return resultado
    End Function

    Public Function Division() As Double
        Dim resultado As Double = _numero1 / _numero2
        Return resultado
    End Function
    Public Function Potencia() As Integer
        Dim resultado As Integer = (_numero1 ^ _numero2)
        Return resultado
    End Function

End Class