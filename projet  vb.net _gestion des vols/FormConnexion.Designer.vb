<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormConnexion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormConnexion))
        lblUsername = New Label()
        lblPassword = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        btnConnexion = New Button()
        lblMessage = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.BackColor = Color.Transparent
        lblUsername.Font = New Font("Arial Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUsername.ForeColor = Color.Black
        lblUsername.Location = New Point(1, 135)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(193, 26)
        lblUsername.TabIndex = 0
        lblUsername.Text = "Nom d'utilisateur :"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.BackColor = Color.Transparent
        lblPassword.Font = New Font("Arial Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPassword.Location = New Point(1, 194)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(155, 26)
        lblPassword.TabIndex = 1
        lblPassword.Text = "Mot de passe :"
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.DarkSalmon
        txtUsername.BorderStyle = BorderStyle.None
        txtUsername.Font = New Font("Arial Narrow", 10.2F, FontStyle.Bold)
        txtUsername.ForeColor = Color.Black
        txtUsername.Location = New Point(278, 134)
        txtUsername.Multiline = True
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(200, 27)
        txtUsername.TabIndex = 2
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.DarkSalmon
        txtPassword.BorderStyle = BorderStyle.None
        txtPassword.Font = New Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPassword.ForeColor = Color.Black
        txtPassword.Location = New Point(278, 194)
        txtPassword.Multiline = True
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(200, 27)
        txtPassword.TabIndex = 3
        ' 
        ' btnConnexion
        ' 
        btnConnexion.BackColor = Color.DarkSalmon
        btnConnexion.FlatStyle = FlatStyle.Popup
        btnConnexion.Font = New Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnConnexion.Location = New Point(268, 288)
        btnConnexion.Name = "btnConnexion"
        btnConnexion.Size = New Size(137, 38)
        btnConnexion.TabIndex = 4
        btnConnexion.Text = "Connexion"
        btnConnexion.UseVisualStyleBackColor = False
        ' 
        ' lblMessage
        ' 
        lblMessage.AutoSize = True
        lblMessage.Location = New Point(194, 385)
        lblMessage.Name = "lblMessage"
        lblMessage.Size = New Size(0, 20)
        lblMessage.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Monotype Corsiva", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(51, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(417, 49)
        Label1.TabIndex = 6
        Label1.Text = " Connexion à l'application"
        ' 
        ' FormConnexion
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(541, 466)
        Controls.Add(Label1)
        Controls.Add(lblMessage)
        Controls.Add(btnConnexion)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(lblPassword)
        Controls.Add(lblUsername)
        DoubleBuffered = True
        Name = "FormConnexion"
        Text = "adminForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnConnexion As Button
    Friend WithEvents lblMessage As Label
    Friend WithEvents Label1 As Label

End Class
