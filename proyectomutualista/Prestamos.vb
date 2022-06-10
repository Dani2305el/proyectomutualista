Imports System.Configuration
Imports MySqlConnector

Public Class Prestamos
    Private Sub Prestamos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dataPrestamos.Columns.Add("id", "Id")
        dataPrestamos.Columns.Add("nombres", "Nombres")
        dataPrestamos.Columns.Add("apellidos", "Apellidos")
        dataPrestamos.Columns.Add("correo", "Correo")
        dataPrestamos.Columns.Add("telefono", "Teléfono")
        dataPrestamos.Columns.Add("fecha", "Fecha")
        dataPrestamos.Columns.Add("monto", "Monto")
        dataPrestamos.Columns.Add("periodo", "Período")
        dataPrestamos.Columns.Add("plazo", "Plazo")
        dataPrestamos.Columns.Add("interes", "Interés")
        dataPrestamos.Columns.Add("pago_fijo", "Pago fijo")
        dataPrestamos.Columns.Add("total", "Total")

        'cadena de conexion del archivo App.config
        Dim settings = ConfigurationManager.ConnectionStrings
        Dim cadenaConexion As String = (From s In settings Where s.Name = "cadenaDeConexionMySql" Select s.connectionString).Take(1).First()

        Dim conn As New MySqlConnection(cadenaConexion)

        'query
        Dim sql As String = "select*from clientes"

        'lector de datos
        Dim reader As MySqlDataReader
        Dim comando As MySqlCommand = New MySqlCommand(sql, conn)

        conn.Open()

        'obtener lectura
        reader = comando.ExecuteReader

        'si hay datos
        If reader.HasRows Then
            'recorrer cada fila
            While reader.Read()
                'insertar datos en el dataGrid
                dataPrestamos.Rows.Add(reader.GetInt16("id"), reader.GetString("nombres"), reader.GetString("apellidos"),
                    reader.GetString("correo"), reader.GetString("telefono"), reader.GetString("fecha"),
                    "$" & reader.GetDecimal("monto"), reader.GetString("periodo"), reader.GetInt16("plazo"), reader.GetDecimal("interes") & "%",
                    "$" & reader.GetDecimal("pago_fijo"), "$" & reader.GetDecimal("total"))
            End While
        End If

    End Sub

    Private Sub dataPrestamos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataPrestamos.CellContentClick

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dataPrestamos.Rows.Count > 0 Then

            Dim id As String = Convert.ToString(dataPrestamos.CurrentRow.Cells(0).Value)

            Dim result As DialogResult = MessageBox.Show("Seguro que sea eliminar el registro?",
                                  "Eliminar",
                                  MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then

                'cadena de conexion del archivo App.config
                Dim settings = ConfigurationManager.ConnectionStrings
                Dim cadenaConexion As String = (From s In settings Where s.Name = "cadenaDeConexionMySql" Select s.connectionString).Take(1).First()

                Dim conn As New MySqlConnection(cadenaConexion)

                'query
                Dim sql As String = "delete from clientes where id =" & id

                Dim comando As MySqlCommand = New MySqlCommand(sql, conn)

                conn.Open()
                comando.ExecuteNonQuery()
                conn.Close()
                dataPrestamos.Rows.Remove(dataPrestamos.CurrentRow)
            End If
        Else
            MsgBox("No hay datos")
        End If


    End Sub
End Class