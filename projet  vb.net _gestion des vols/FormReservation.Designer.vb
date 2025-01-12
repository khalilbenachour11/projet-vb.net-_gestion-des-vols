<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReservation
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblRechercheDestination = New Label()
        lblRechercheDate = New Label()
        btnRechercherVols = New Button()
        txtRechercheDestination = New ComboBox()
        dtpRechercheDate = New DateTimePicker()
        dgvRechercheVols = New DataGridView()
        lblNomClient = New Label()
        lblPrenomClient = New Label()
        lblTelephoneClient = New Label()
        txtNomClient = New TextBox()
        txtPrenomClient = New TextBox()
        txtTelephoneClient = New TextBox()
        btnReserver = New Button()
        btnGenererRecu = New Button()
        Label1 = New Label()
        CType(dgvRechercheVols, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblRechercheDestination
        ' 
        lblRechercheDestination.AutoSize = True
        lblRechercheDestination.BackColor = Color.LightBlue
        lblRechercheDestination.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRechercheDestination.ForeColor = Color.Black
        lblRechercheDestination.Location = New Point(15, 145)
        lblRechercheDestination.Name = "lblRechercheDestination"
        lblRechercheDestination.Size = New Size(130, 24)
        lblRechercheDestination.TabIndex = 0
        lblRechercheDestination.Text = "Destination :"
        ' 
        ' lblRechercheDate
        ' 
        lblRechercheDate.AutoSize = True
        lblRechercheDate.BackColor = Color.LightBlue
        lblRechercheDate.Font = New Font("Arial", 12F, FontStyle.Bold)
        lblRechercheDate.ForeColor = Color.Black
        lblRechercheDate.Location = New Point(452, 145)
        lblRechercheDate.Name = "lblRechercheDate"
        lblRechercheDate.Size = New Size(66, 24)
        lblRechercheDate.TabIndex = 1
        lblRechercheDate.Text = "Date :"
        ' 
        ' btnRechercherVols
        ' 
        btnRechercherVols.BackColor = Color.DarkCyan
        btnRechercherVols.FlatStyle = FlatStyle.Popup
        btnRechercherVols.Font = New Font("Arial", 12F)
        btnRechercherVols.Location = New Point(704, 197)
        btnRechercherVols.Name = "btnRechercherVols"
        btnRechercherVols.Size = New Size(122, 28)
        btnRechercherVols.TabIndex = 2
        btnRechercherVols.Text = "Rechercher"
        btnRechercherVols.UseVisualStyleBackColor = False
        ' 
        ' txtRechercheDestination
        ' 
        txtRechercheDestination.FormattingEnabled = True
        txtRechercheDestination.Items.AddRange(New Object() {"france", "allemagne", "maroc", "algérie ", "egypte ", " etats-unis "})
        txtRechercheDestination.Location = New Point(208, 142)
        txtRechercheDestination.Name = "txtRechercheDestination"
        txtRechercheDestination.Size = New Size(169, 27)
        txtRechercheDestination.TabIndex = 3
        ' 
        ' dtpRechercheDate
        ' 
        dtpRechercheDate.Format = DateTimePickerFormat.Short
        dtpRechercheDate.Location = New Point(594, 142)
        dtpRechercheDate.Name = "dtpRechercheDate"
        dtpRechercheDate.Size = New Size(169, 27)
        dtpRechercheDate.TabIndex = 4
        ' 
        ' dgvRechercheVols
        ' 
        dgvRechercheVols.BackgroundColor = Color.LightBlue
        dgvRechercheVols.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRechercheVols.Location = New Point(37, 471)
        dgvRechercheVols.Name = "dgvRechercheVols"
        dgvRechercheVols.RowHeadersWidth = 51
        dgvRechercheVols.Size = New Size(824, 198)
        dgvRechercheVols.TabIndex = 5
        ' 
        ' lblNomClient
        ' 
        lblNomClient.AutoSize = True
        lblNomClient.BackColor = Color.LightBlue
        lblNomClient.Font = New Font("Arial", 12F, FontStyle.Bold)
        lblNomClient.Location = New Point(12, 265)
        lblNomClient.Name = "lblNomClient"
        lblNomClient.Size = New Size(66, 24)
        lblNomClient.TabIndex = 6
        lblNomClient.Text = "Nom :"
        ' 
        ' lblPrenomClient
        ' 
        lblPrenomClient.AutoSize = True
        lblPrenomClient.BackColor = Color.LightBlue
        lblPrenomClient.Font = New Font("Arial", 12F, FontStyle.Bold)
        lblPrenomClient.ForeColor = Color.Black
        lblPrenomClient.Location = New Point(291, 265)
        lblPrenomClient.Name = "lblPrenomClient"
        lblPrenomClient.Size = New Size(96, 24)
        lblPrenomClient.TabIndex = 7
        lblPrenomClient.Text = "Prénom :"
        ' 
        ' lblTelephoneClient
        ' 
        lblTelephoneClient.AutoSize = True
        lblTelephoneClient.BackColor = Color.LightBlue
        lblTelephoneClient.Font = New Font("Arial", 12F, FontStyle.Bold)
        lblTelephoneClient.Location = New Point(578, 265)
        lblTelephoneClient.Name = "lblTelephoneClient"
        lblTelephoneClient.Size = New Size(122, 24)
        lblTelephoneClient.TabIndex = 8
        lblTelephoneClient.Text = "Téléphone :"
        ' 
        ' txtNomClient
        ' 
        txtNomClient.BackColor = SystemColors.Control
        txtNomClient.BorderStyle = BorderStyle.FixedSingle
        txtNomClient.Location = New Point(114, 262)
        txtNomClient.Name = "txtNomClient"
        txtNomClient.Size = New Size(140, 27)
        txtNomClient.TabIndex = 9
        ' 
        ' txtPrenomClient
        ' 
        txtPrenomClient.Location = New Point(414, 266)
        txtPrenomClient.Name = "txtPrenomClient"
        txtPrenomClient.Size = New Size(140, 27)
        txtPrenomClient.TabIndex = 10
        ' 
        ' txtTelephoneClient
        ' 
        txtTelephoneClient.Location = New Point(721, 265)
        txtTelephoneClient.Name = "txtTelephoneClient"
        txtTelephoneClient.Size = New Size(140, 27)
        txtTelephoneClient.TabIndex = 11
        ' 
        ' btnReserver
        ' 
        btnReserver.BackColor = Color.DarkCyan
        btnReserver.FlatStyle = FlatStyle.Popup
        btnReserver.Font = New Font("Arial", 12F)
        btnReserver.Location = New Point(556, 378)
        btnReserver.Name = "btnReserver"
        btnReserver.Size = New Size(106, 28)
        btnReserver.TabIndex = 12
        btnReserver.Text = "Réserver"
        btnReserver.UseVisualStyleBackColor = False
        ' 
        ' btnGenererRecu
        ' 
        btnGenererRecu.BackColor = Color.DarkCyan
        btnGenererRecu.FlatStyle = FlatStyle.Popup
        btnGenererRecu.Font = New Font("Arial", 12F)
        btnGenererRecu.Location = New Point(704, 378)
        btnGenererRecu.Name = "btnGenererRecu"
        btnGenererRecu.Size = New Size(157, 28)
        btnGenererRecu.TabIndex = 13
        btnGenererRecu.Text = "Generer Recu"
        btnGenererRecu.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Monotype Corsiva", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.MidnightBlue
        Label1.Location = New Point(227, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(400, 49)
        Label1.TabIndex = 14
        Label1.Text = "Gestion des Réservations"
        ' 
        ' FormReservation
        ' 
        AutoScaleDimensions = New SizeF(9F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.téléchargement
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(900, 681)
        Controls.Add(Label1)
        Controls.Add(btnGenererRecu)
        Controls.Add(btnReserver)
        Controls.Add(txtTelephoneClient)
        Controls.Add(txtPrenomClient)
        Controls.Add(txtNomClient)
        Controls.Add(lblTelephoneClient)
        Controls.Add(lblPrenomClient)
        Controls.Add(lblNomClient)
        Controls.Add(dgvRechercheVols)
        Controls.Add(dtpRechercheDate)
        Controls.Add(txtRechercheDestination)
        Controls.Add(btnRechercherVols)
        Controls.Add(lblRechercheDate)
        Controls.Add(lblRechercheDestination)
        Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "FormReservation"
        Text = "UserForm"
        CType(dgvRechercheVols, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblRechercheDestination As Label
    Friend WithEvents lblRechercheDate As Label
    Friend WithEvents btnRechercherVols As Button
    Friend WithEvents txtRechercheDestination As ComboBox
    Friend WithEvents dtpRechercheDate As DateTimePicker
    Friend WithEvents dgvRechercheVols As DataGridView
    Friend WithEvents lblNomClient As Label
    Friend WithEvents lblPrenomClient As Label
    Friend WithEvents lblTelephoneClient As Label
    Friend WithEvents txtNomClient As TextBox
    Friend WithEvents txtPrenomClient As TextBox
    Friend WithEvents txtTelephoneClient As TextBox
    Friend WithEvents btnReserver As Button
    Friend WithEvents btnGenererRecu As Button
    Friend WithEvents Label1 As Label
End Class
