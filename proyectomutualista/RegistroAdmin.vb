Imports System.Configuration
Imports MySqlConnector

Public Class RegistroAdmin

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim nombres As String = txtNombre.Text
        Dim apellidos As String = txtApellido.Text
        Dim correo As String = txtCorreo.Text
        Dim contrasenia As String = txtPass.Text
        Dim confirPass As String = txtConfPass.Text

        If Not String.IsNullOrEmpty(nombres) And Not String.IsNullOrEmpty(apellidos) And
            Not String.IsNullOrEmpty(correo) And Not String.IsNullOrEmpty(contrasenia) And
            Not String.IsNullOrEmpty(confirPass) Then

            If Not contrasenia = confirPass Then
                txtPass.Focus()
                MessageBox.Show("Las contraseñas no coinciden")
            Else
                'cadena de conexion del archivo App.config
                Dim settings = ConfigurationManager.ConnectionStrings
                Dim cadenaConexion As String = (From s In settings Where s.Name = "cadenaDeConexionMySql" Select s.connectionString).Take(1).First()

                Dim conn As New MySqlConnection(cadenaConexion)

                Dim cadena As String = "insert into administradores(nombres,apellidos,correo,contrasenia) values ('" & nombres & "','" & apellidos & "','" & correo & "','" & contrasenia & "')"

                Dim comando As MySqlCommand = New MySqlCommand(cadena, conn)
                conn.Open()
                comando.ExecuteNonQuery()
                MessageBox.Show("Los datos se guardaron correctamente")
                conn.Close()
                'limpiar campos
                txtNombre.Text = ""
                txtApellido.Text = ""
                txtCorreo.Text = ""
                txtPass.Text = ""
                txtConfPass.Text = ""
                '
                Me.Hide()
                LoginAdmin.Show()
            End If
        Else
            MessageBox.Show("Debes completar los campos")
        End If
    End Sub
End Class