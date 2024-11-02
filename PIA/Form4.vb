Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim velocidad As Double

        Dim resultado As Double
        velocidad = Double.Parse(txtvelocidad.Text)
        resultado = (3 * Math.Pow(10, 8)) / velocidad
        txtresultado.Text = resultado



    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Close()

    End Sub
End Class