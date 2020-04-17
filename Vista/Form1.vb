Imports Logica
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnResultado_Click(sender As Object, e As EventArgs) Handles BtnResultado.Click
        Try
            Dim _num1 As Integer = Integer.Parse(TxtNumero1.Text)
            Dim _num2 As Integer = Integer.Parse(TxtNumero2.Text)
            Dim _oper As String = CbOperacion.Text
            Dim calc As Calculadora = New Calculadora(_num1, _num2)
            Select Case _oper
                Case "Suma"
                    TxtResultado.Text = calc.Suma()
                Case "Resta"
                    TxtResultado.Text = calc.Resta()
                Case "Multiplicacion"
                    TxtResultado.Text = calc.Multiplicacion()
                Case "Division"
                    If _num2 <> 0 Then
                        TxtResultado.Text = calc.Division()
                    Else
                        MsgBox("El 2do Numero no puede ser 0")
                    End If
                Case "Potencia"
                    If _num2 <= 13 Then
                        TxtResultado.Text = calc.Potencia()
                    Else
                        MsgBox("El exponente (2do Numero) no puede ser mayor a 13")
                    End If
                Case Else
                    MsgBox("Seleccione una Operacion")
            End Select
        Catch ex As Exception
            MsgBox("Ingrese los Numeros para operar")
        End Try
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtNumero1.Text = ""
        TxtNumero2.Text = ""
        TxtResultado.Text = ""
    End Sub
End Class
