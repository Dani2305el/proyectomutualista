Imports MySqlConnector

Public Class LoginAdmin

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        RegistroAdmin.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtEmail.Focus()
        txtPass.Focus()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btbAcceder_Click(sender As Object, e As EventArgs) Handles btbAcceder.Click

        Dim correo As String = txtEmail.Text
        Dim contrasenia As String = txtPass.Text

        If Not String.IsNullOrEmpty(correo) And Not String.IsNullOrEmpty(contrasenia) Then
            'cadena de conexion
            Dim cadenaConexion As String = "server=localhost;database=db_mutualista;user id=root;password=2305;port=3306;"
            Dim conn As New MySqlConnection(cadenaConexion)

            'query
            Dim sql As String = "select*from administradores where correo = '" & correo & "' and contrasenia = '" & contrasenia & "'"

            'lector de datos
            Dim reader As MySqlDataReader
            Dim comando As MySqlCommand = New MySqlCommand(sql, conn)

            conn.Open()

            reader = comando.ExecuteReader

            Dim nombre As String
            If reader.HasRows Then
                While reader.Read()
                    nombre = reader.GetString("nombres")
                End While
                MessageBox.Show("Bienvenido " & nombre)
                MenuAdmin.nombre = nombre
                'limpiar campos
                txtEmail.Text = ""
                txtPass.Text = ""
                '
                Me.Hide()
                MenuAdmin.Show()

            Else
                MessageBox.Show("Correo o contraseña incorrectos")
            End If

            conn.Close()
        Else
        MessageBox.Show("Debes completar los campos")
        End If

    End Sub
End Class
