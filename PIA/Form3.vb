Public Class Form3
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtMedioRefraccion.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnmenu.Click
        Form2.Show()
        Me.Close()

    End Sub

    Private Sub txtAnguloIncidente_TextChanged(sender As Object, e As EventArgs) Handles txtAnguloIncidente.TextChanged

    End Sub

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        Dim AnguloI As Double
        Dim MedioI As Double
        Dim MedioR As Double
        Dim Senrefraccion As Double
        Dim AnguloRefraccion As Double
        txtResultado.Clear()
        AnguloI = Double.Parse(txtAnguloIncidente.Text)
        MedioI = Double.Parse(txtMedioIncidente.Text)
        MedioR = Double.Parse(txtMedioRefraccion.Text)
        Senrefraccion = (Math.Sin(AnguloI) * MedioI) / MedioR
        AnguloRefraccion = Math.Sinh(Senrefraccion)
        txtResultado.Text = "El angulo de Refraccion correspondiente es: " & AnguloRefraccion





    End Sub
End Class