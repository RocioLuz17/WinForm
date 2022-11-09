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
        Me.Txt1 = New System.Windows.Forms.TextBox()
        Me.Txt2 = New System.Windows.Forms.TextBox()
        Me.Txt3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Btncalcular = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Txt1
        '
        Me.Txt1.Location = New System.Drawing.Point(279, 91)
        Me.Txt1.Name = "Txt1"
        Me.Txt1.Size = New System.Drawing.Size(142, 20)
        Me.Txt1.TabIndex = 0
        '
        'Txt2
        '
        Me.Txt2.Location = New System.Drawing.Point(279, 138)
        Me.Txt2.Name = "Txt2"
        Me.Txt2.Size = New System.Drawing.Size(142, 20)
        Me.Txt2.TabIndex = 1
        '
        'Txt3
        '
        Me.Txt3.Location = New System.Drawing.Point(279, 192)
        Me.Txt3.Name = "Txt3"
        Me.Txt3.Size = New System.Drawing.Size(142, 20)
        Me.Txt3.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(200, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Dato 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(200, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Dato 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(200, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Dato 3"
        '
        'Btncalcular
        '
        Me.Btncalcular.Location = New System.Drawing.Point(279, 269)
        Me.Btncalcular.Name = "Btncalcular"
        Me.Btncalcular.Size = New System.Drawing.Size(127, 23)
        Me.Btncalcular.TabIndex = 6
        Me.Btncalcular.Text = "Calcular"
        Me.Btncalcular.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(233, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Calcula cual de los 3 datos ingresados es mayor"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 403)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Btncalcular)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt3)
        Me.Controls.Add(Me.Txt2)
        Me.Controls.Add(Me.Txt1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txt1 As TextBox
    Friend WithEvents Txt2 As TextBox
    Friend WithEvents Txt3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Btncalcular As Button
    Friend WithEvents Label4 As Label
End Class
