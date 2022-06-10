<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuAdmin
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
        Me.btnAlta = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblUserLogin = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAlta
        '
        Me.btnAlta.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAlta.Location = New System.Drawing.Point(67, 48)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(140, 55)
        Me.btnAlta.TabIndex = 11
        Me.btnAlta.Text = "Dar de alta un préstamo"
        Me.btnAlta.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(67, 109)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 55)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Ver préstamos"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblUserLogin
        '
        Me.lblUserLogin.AutoSize = True
        Me.lblUserLogin.BackColor = System.Drawing.Color.Transparent
        Me.lblUserLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblUserLogin.Location = New System.Drawing.Point(12, 9)
        Me.lblUserLogin.Name = "lblUserLogin"
        Me.lblUserLogin.Size = New System.Drawing.Size(15, 13)
        Me.lblUserLogin.TabIndex = 13
        Me.lblUserLogin.Text = "--"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(67, 170)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(140, 55)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'MenuAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.proyectomutualista.My.Resources.Resources._282_2828323_fondos_de_pantalla_degradados
        Me.ClientSize = New System.Drawing.Size(277, 241)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lblUserLogin)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnAlta)
        Me.Name = "MenuAdmin"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAlta As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lblUserLogin As Label
    Friend WithEvents Button2 As Button
End Class
