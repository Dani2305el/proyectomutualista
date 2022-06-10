Public Class MenuAdmin
    Public nombre As String

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        AltaCliente.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Prestamos.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
        Me.Close()
    End Sub

    Private Sub MenuAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUserLogin.Text = "Hola " & nombre
    End Sub
End Class