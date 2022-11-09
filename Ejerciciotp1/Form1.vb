Public Class Form1
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Txt2.TextChanged

    End Sub

    Private Sub Btncalcular_Click(sender As Object, e As EventArgs) Handles Btncalcular.Click
        Dim num1 As Integer
        Dim num2 As Integer
        Dim num3 As Integer


        num1 = Val(Txt1.Text)
        num2 = Val(Txt2.Text)
        num3 = Val(Txt3.Text)

        If num1 > num2 And num1 > num3 Then
            Txt1.Text = num1
            Txt2.Text = 0
            Txt3.Text = 0
        Else

            If num2 > num1 And num2 > num3 Then
                Txt1.Text = num2
                Txt2.Text = 0
                Txt3.Text = 0
            Else
                If num3 > num1 And num3 > num2 Then
                    Txt1.Text = num3
                    Txt2.Text = 0
                    Txt3.Text = 0
                End If

            End If


        End If

    End Sub

    Private Sub Txt1_TextChanged(sender As Object, e As EventArgs) Handles Txt1.TextChanged

    End Sub
End Class
