Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Double
        a = TextBox1.Text
        If (a < 60) Then
            TextBox2.Text = "Reprobado"
        End If

        If (a > 61 And a < 70) Then
            TextBox2.Text = "Aprobado"
        End If

        If (a > 71 And a < 80) Then
            TextBox2.Text = "Notable"
        End If

        If (a > 81 And a < 90) Then
            TextBox2.Text = "Sobresaliente"
        End If

        If (a > 91 And a < 100) Then
            TextBox2.Text = "Excelente"
        End If

    End Sub
End Class
