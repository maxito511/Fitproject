<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class w_login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(w_login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_user = New System.Windows.Forms.TextBox()
        Me.tb_pass = New System.Windows.Forms.TextBox()
        Me.bt_ingresar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cb_mostrarpass = New System.Windows.Forms.CheckBox()
        Me.SkinEngine1 = New Sunisoft.IrisSkin.SkinEngine(CType(Me, System.ComponentModel.Component))
        Me.pb_login = New System.Windows.Forms.PictureBox()
        CType(Me.pb_login, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "USUARIO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 247)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CONTRASEÑA"
        '
        'tb_user
        '
        Me.tb_user.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tb_user.Location = New System.Drawing.Point(49, 216)
        Me.tb_user.Name = "tb_user"
        Me.tb_user.Size = New System.Drawing.Size(184, 20)
        Me.tb_user.TabIndex = 1
        '
        'tb_pass
        '
        Me.tb_pass.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tb_pass.Location = New System.Drawing.Point(49, 271)
        Me.tb_pass.Name = "tb_pass"
        Me.tb_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.tb_pass.Size = New System.Drawing.Size(184, 20)
        Me.tb_pass.TabIndex = 3
        '
        'bt_ingresar
        '
        Me.bt_ingresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bt_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_ingresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_ingresar.Location = New System.Drawing.Point(138, 320)
        Me.bt_ingresar.Name = "bt_ingresar"
        Me.bt_ingresar.Size = New System.Drawing.Size(95, 31)
        Me.bt_ingresar.TabIndex = 5
        Me.bt_ingresar.Text = "INGRESAR"
        Me.bt_ingresar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(233, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 26)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cb_mostrarpass
        '
        Me.cb_mostrarpass.AutoSize = True
        Me.cb_mostrarpass.Location = New System.Drawing.Point(49, 297)
        Me.cb_mostrarpass.Name = "cb_mostrarpass"
        Me.cb_mostrarpass.Size = New System.Drawing.Size(118, 17)
        Me.cb_mostrarpass.TabIndex = 4
        Me.cb_mostrarpass.Text = "Mostrar Contraseña"
        Me.cb_mostrarpass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cb_mostrarpass.UseVisualStyleBackColor = True
        '
        'SkinEngine1
        '
        Me.SkinEngine1.ResSysMenuClose = "Salir"
        Me.SkinEngine1.ResSysMenuMax = "Maximizar"
        Me.SkinEngine1.ResSysMenuMin = "Minimizar"
        Me.SkinEngine1.SerialNumber = "U4N2UjLguUZs33UR+Vy47JAZ81t2fjIFvut28vc5oHiVeivGb/NZMA=="
        Me.SkinEngine1.SkinFile = Nothing
        Me.SkinEngine1.SkinStreamMain = CType(resources.GetObject("SkinEngine1.SkinStreamMain"), System.IO.Stream)
        '
        'pb_login
        '
        Me.pb_login.Image = CType(resources.GetObject("pb_login.Image"), System.Drawing.Image)
        Me.pb_login.Location = New System.Drawing.Point(82, 46)
        Me.pb_login.Name = "pb_login"
        Me.pb_login.Size = New System.Drawing.Size(132, 133)
        Me.pb_login.TabIndex = 8
        Me.pb_login.TabStop = False
        '
        'w_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(278, 388)
        Me.Controls.Add(Me.pb_login)
        Me.Controls.Add(Me.cb_mostrarpass)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.bt_ingresar)
        Me.Controls.Add(Me.tb_pass)
        Me.Controls.Add(Me.tb_user)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "w_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "0"
        CType(Me.pb_login, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_user As TextBox
    Friend WithEvents tb_pass As TextBox
    Friend WithEvents bt_ingresar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents cb_mostrarpass As CheckBox
    Friend WithEvents SkinEngine1 As Sunisoft.IrisSkin.SkinEngine
    Friend WithEvents pb_login As PictureBox
End Class
