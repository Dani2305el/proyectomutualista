Imports System.Configuration

Imports MySqlConnector
Public Class AltaCliente
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles txtPeriodo.TextChanged

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim nombres As String = txtNombre.Text
        Dim apellidos As String = txtApellido.Text
        Dim correo As String = txtCorreo.Text
        Dim telefono As String = txtTelefono.Text
        Dim monto As String = txtMonto.Text
        Dim periodo As String = txtPeriodo.Text
        Dim plazo As String = txtPlazo.Text
        Dim interes As String = txtInteres.Text
        'interes_por_pagar = (monto * (interés/100))* plazo
        'total = monto + interes_por_pagar
        If Not String.IsNullOrEmpty(nombres) And Not String.IsNullOrEmpty(apellidos) And
            Not String.IsNullOrEmpty(correo) And Not String.IsNullOrEmpty(telefono) And
            Not String.IsNullOrEmpty(monto) And Not String.IsNullOrEmpty(periodo) And
            Not String.IsNullOrEmpty(plazo) And Not String.IsNullOrEmpty(interes) Then

            'cadena de conexion del archivo App.config
            Dim settings = ConfigurationManager.ConnectionStrings
            Dim cadenaConexion As String = (From s In settings Where s.Name = "cadenaDeConexionMySql" Select s.connectionString).Take(1).First()

            Dim conn As New MySqlConnection(cadenaConexion)

            Dim interes_por_pagar = (monto * (interes / 100)) * plazo
            Dim total = monto + interes_por_pagar
            Dim pago_fijo = total / plazo
            Dim fecha = DateTime.Now.ToString
            Dim cadena As String = "insert into clientes(nombres,apellidos,correo,telefono,fecha,monto,periodo,plazo,interes,pago_fijo,total) values 
               ('" & nombres & "','" & apellidos & "','" & correo & "','" & telefono & "','" & fecha & "','" & monto & "','" & periodo & "','" & plazo & "','" & interes & "','" & pago_fijo & "','" & total & "')"

            Dim comando As MySqlCommand = New MySqlCommand(cadena, conn)
            conn.Open()
            comando.ExecuteNonQuery()
            Prestamos.Close()
            MessageBox.Show("Los datos se guardaron correctamente")
            conn.Close()
            'limpiar campos
            txtNombre.Text = ""
            txtApellido.Text = ""
            txtCorreo.Text = ""
            txtTelefono.Text = ""
            txtMonto.Text = ""
            txtPlazo.Text = ""
            txtInteres.Text = ""
            '
            Prestamos.Show()
            Me.Hide()
        Else
            MessageBox.Show("Debes completar los campos")
        End If




    End Sub
End Class