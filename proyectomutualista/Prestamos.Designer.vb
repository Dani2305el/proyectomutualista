<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prestamos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dataPrestamos = New System.Windows.Forms.DataGridView()
        Me.btnEliminar = New System.Windows.Forms.Button()
        CType(Me.dataPrestamos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataPrestamos
        '
        Me.dataPrestamos.AllowUserToAddRows = False
        Me.dataPrestamos.AllowUserToDeleteRows = False
        Me.dataPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataPrestamos.Location = New System.Drawing.Point(12, 35)
        Me.dataPrestamos.Name = "dataPrestamos"
        Me.dataPrestamos.ReadOnly = True
        Me.dataPrestamos.Size = New System.Drawing.Size(1050, 150)
        Me.dataPrestamos.TabIndex = 0
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(12, 199)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 1
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'Prestamos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.proyectomutualista.My.Resources.Resources._282_2828323_fondos_de_pantalla_degradados
        Me.ClientSize = New System.Drawing.Size(1074, 234)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.dataPrestamos)
        Me.Name = "Prestamos"
        Me.Text = "Prestamos"
        CType(Me.dataPrestamos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dataPrestamos As DataGridView
    Friend WithEvents btnEliminar As Button
End Class
