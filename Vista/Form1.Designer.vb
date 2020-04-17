<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnResultado = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.TxtNumero1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNumero2 = New System.Windows.Forms.TextBox()
        Me.TxtResultado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CbOperacion = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "1er Numero"
        '
        'BtnResultado
        '
        Me.BtnResultado.Location = New System.Drawing.Point(15, 190)
        Me.BtnResultado.Name = "BtnResultado"
        Me.BtnResultado.Size = New System.Drawing.Size(100, 25)
        Me.BtnResultado.TabIndex = 1
        Me.BtnResultado.Text = "Resultado"
        Me.BtnResultado.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(121, 190)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(100, 25)
        Me.BtnLimpiar.TabIndex = 2
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'TxtNumero1
        '
        Me.TxtNumero1.Location = New System.Drawing.Point(14, 33)
        Me.TxtNumero1.Name = "TxtNumero1"
        Me.TxtNumero1.Size = New System.Drawing.Size(101, 20)
        Me.TxtNumero1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(118, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "2do Numero"
        '
        'TxtNumero2
        '
        Me.TxtNumero2.Location = New System.Drawing.Point(121, 33)
        Me.TxtNumero2.Name = "TxtNumero2"
        Me.TxtNumero2.Size = New System.Drawing.Size(101, 20)
        Me.TxtNumero2.TabIndex = 3
        '
        'TxtResultado
        '
        Me.TxtResultado.Location = New System.Drawing.Point(14, 144)
        Me.TxtResultado.Name = "TxtResultado"
        Me.TxtResultado.Size = New System.Drawing.Size(208, 20)
        Me.TxtResultado.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(89, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Resultado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(89, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Operacion"
        '
        'CbOperacion
        '
        Me.CbOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbOperacion.FormattingEnabled = True
        Me.CbOperacion.Items.AddRange(New Object() {"Suma", "Resta", "Multiplicacion", "Division", "Potencia"})
        Me.CbOperacion.Location = New System.Drawing.Point(14, 79)
        Me.CbOperacion.Name = "CbOperacion"
        Me.CbOperacion.Size = New System.Drawing.Size(202, 21)
        Me.CbOperacion.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(228, 239)
        Me.Controls.Add(Me.CbOperacion)
        Me.Controls.Add(Me.TxtResultado)
        Me.Controls.Add(Me.TxtNumero2)
        Me.Controls.Add(Me.TxtNumero1)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnResultado)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnResultado As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents TxtNumero1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNumero2 As TextBox
    Friend WithEvents TxtResultado As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CbOperacion As ComboBox
End Class
