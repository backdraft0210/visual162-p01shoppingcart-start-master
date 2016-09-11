Public Class MainForm
    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel2.Paint

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles ButtonHombre.Click
        ButtonHombre.ForeColor = Color.SteelBlue
        ButtonMujer.ForeColor = Color.Black
        ButtonCalzado.ForeColor = Color.Black
        ButtonAccsesorio.ForeColor = Color.Black
    End Sub

    Private Sub ButtonMujer_Click(sender As Object, e As EventArgs) Handles ButtonMujer.Click
        ButtonMujer.ForeColor = Color.SteelBlue
        ButtonHombre.ForeColor = Color.Black
        ButtonCalzado.ForeColor = Color.Black
        ButtonAccsesorio.ForeColor = Color.Black

    End Sub

    Private Sub ButtonCalzado_Click(sender As Object, e As EventArgs) Handles ButtonCalzado.Click
        ButtonMujer.ForeColor = Color.Black
        ButtonCalzado.ForeColor = Color.SteelBlue
        ButtonAccsesorio.ForeColor = Color.Black
        ButtonHombre.ForeColor = Color.Black

    End Sub

    Private Sub ButtonAccsesorio_Click(sender As Object, e As EventArgs) Handles ButtonAccsesorio.Click
        ButtonAccsesorio.ForeColor = Color.SteelBlue
        ButtonMujer.ForeColor = Color.Black
        ButtonHombre.ForeColor = Color.Black
        ButtonCalzado.ForeColor = Color.Black
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click

    End Sub
End Class