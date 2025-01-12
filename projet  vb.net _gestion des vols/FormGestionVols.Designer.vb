<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGestionVols
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormGestionVols))
        lblNumeroVol = New Label()
        lblDateVol = New Label()
        lblPlaces = New Label()
        lblDestination = New Label()
        lblPrix = New Label()
        lblHeure = New Label()
        txtNumeroVol = New TextBox()
        txtHeure = New TextBox()
        txtDestination = New TextBox()
        txtPlaces = New TextBox()
        txtPrix = New TextBox()
        dtpDateVol = New DateTimePicker()
        btnAjouterVol = New Button()
        btnModifierVol = New Button()
        btnSupprimerVol = New Button()
        dgvVols = New DataGridView()
        Label1 = New Label()
        CType(dgvVols, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblNumeroVol
        ' 
        lblNumeroVol.AutoSize = True
        lblNumeroVol.BackColor = Color.Transparent
        lblNumeroVol.Font = New Font("Arial Black", 12F, FontStyle.Bold)
        lblNumeroVol.ForeColor = Color.DarkOrange
        lblNumeroVol.Location = New Point(22, 117)
        lblNumeroVol.Name = "lblNumeroVol"
        lblNumeroVol.Size = New Size(182, 28)
        lblNumeroVol.TabIndex = 0
        lblNumeroVol.Text = "Numéro de vol :"
        ' 
        ' lblDateVol
        ' 
        lblDateVol.AutoSize = True
        lblDateVol.BackColor = Color.Transparent
        lblDateVol.Font = New Font("Arial Black", 12F, FontStyle.Bold)
        lblDateVol.ForeColor = Color.DarkOrange
        lblDateVol.Location = New Point(22, 186)
        lblDateVol.Name = "lblDateVol"
        lblDateVol.Size = New Size(77, 28)
        lblDateVol.TabIndex = 1
        lblDateVol.Text = "Date :"
        ' 
        ' lblPlaces
        ' 
        lblPlaces.AutoSize = True
        lblPlaces.BackColor = Color.Transparent
        lblPlaces.Font = New Font("Arial Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPlaces.ForeColor = Color.DarkOrange
        lblPlaces.Location = New Point(5, 253)
        lblPlaces.Name = "lblPlaces"
        lblPlaces.Size = New Size(208, 26)
        lblPlaces.TabIndex = 2
        lblPlaces.Text = "Places disponibles :"
        ' 
        ' lblDestination
        ' 
        lblDestination.AutoSize = True
        lblDestination.BackColor = Color.Transparent
        lblDestination.Font = New Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDestination.ForeColor = Color.DarkOrange
        lblDestination.Location = New Point(393, 120)
        lblDestination.Name = "lblDestination"
        lblDestination.Size = New Size(151, 28)
        lblDestination.TabIndex = 3
        lblDestination.Text = "Destination :"
        ' 
        ' lblPrix
        ' 
        lblPrix.AutoSize = True
        lblPrix.BackColor = Color.Transparent
        lblPrix.Font = New Font("Arial Black", 12F, FontStyle.Bold)
        lblPrix.ForeColor = Color.DarkOrange
        lblPrix.Location = New Point(393, 254)
        lblPrix.Name = "lblPrix"
        lblPrix.Size = New Size(118, 28)
        lblPrix.TabIndex = 4
        lblPrix.Text = "     Prix :  "
        ' 
        ' lblHeure
        ' 
        lblHeure.AutoSize = True
        lblHeure.BackColor = Color.Transparent
        lblHeure.Font = New Font("Arial Black", 12F, FontStyle.Bold)
        lblHeure.ForeColor = Color.DarkOrange
        lblHeure.Location = New Point(420, 189)
        lblHeure.Name = "lblHeure"
        lblHeure.Size = New Size(91, 28)
        lblHeure.TabIndex = 5
        lblHeure.Text = "Heure :"
        ' 
        ' txtNumeroVol
        ' 
        txtNumeroVol.BackColor = SystemColors.InactiveCaption
        txtNumeroVol.Location = New Point(219, 120)
        txtNumeroVol.Name = "txtNumeroVol"
        txtNumeroVol.Size = New Size(125, 27)
        txtNumeroVol.TabIndex = 6
        ' 
        ' txtHeure
        ' 
        txtHeure.BackColor = SystemColors.InactiveCaption
        txtHeure.Location = New Point(577, 189)
        txtHeure.Name = "txtHeure"
        txtHeure.Size = New Size(125, 27)
        txtHeure.TabIndex = 7
        ' 
        ' txtDestination
        ' 
        txtDestination.BackColor = SystemColors.InactiveCaption
        txtDestination.Location = New Point(577, 120)
        txtDestination.Name = "txtDestination"
        txtDestination.Size = New Size(125, 27)
        txtDestination.TabIndex = 8
        ' 
        ' txtPlaces
        ' 
        txtPlaces.BackColor = SystemColors.InactiveCaption
        txtPlaces.Location = New Point(219, 254)
        txtPlaces.Name = "txtPlaces"
        txtPlaces.Size = New Size(125, 27)
        txtPlaces.TabIndex = 9
        ' 
        ' txtPrix
        ' 
        txtPrix.BackColor = SystemColors.InactiveCaption
        txtPrix.Location = New Point(577, 257)
        txtPrix.Name = "txtPrix"
        txtPrix.Size = New Size(125, 27)
        txtPrix.TabIndex = 10
        ' 
        ' dtpDateVol
        ' 
        dtpDateVol.CalendarMonthBackground = SystemColors.InactiveCaption
        dtpDateVol.Format = DateTimePickerFormat.Short
        dtpDateVol.Location = New Point(219, 187)
        dtpDateVol.Name = "dtpDateVol"
        dtpDateVol.Size = New Size(125, 27)
        dtpDateVol.TabIndex = 11
        dtpDateVol.Value = New Date(2025, 1, 5, 0, 0, 0, 0)
        ' 
        ' btnAjouterVol
        ' 
        btnAjouterVol.BackColor = Color.LightSkyBlue
        btnAjouterVol.FlatStyle = FlatStyle.Flat
        btnAjouterVol.Font = New Font("Arial", 10.2F, FontStyle.Bold)
        btnAjouterVol.Location = New Point(159, 339)
        btnAjouterVol.Name = "btnAjouterVol"
        btnAjouterVol.Size = New Size(94, 29)
        btnAjouterVol.TabIndex = 12
        btnAjouterVol.Text = "Ajouter"
        btnAjouterVol.UseVisualStyleBackColor = False
        ' 
        ' btnModifierVol
        ' 
        btnModifierVol.BackColor = Color.LightSkyBlue
        btnModifierVol.FlatStyle = FlatStyle.Flat
        btnModifierVol.Font = New Font("Arial", 10.2F, FontStyle.Bold)
        btnModifierVol.Location = New Point(344, 339)
        btnModifierVol.Name = "btnModifierVol"
        btnModifierVol.Size = New Size(94, 29)
        btnModifierVol.TabIndex = 13
        btnModifierVol.Text = "Modifier"
        btnModifierVol.UseVisualStyleBackColor = False
        ' 
        ' btnSupprimerVol
        ' 
        btnSupprimerVol.BackColor = Color.LightSkyBlue
        btnSupprimerVol.FlatStyle = FlatStyle.Flat
        btnSupprimerVol.Font = New Font("Arial", 10.2F, FontStyle.Bold)
        btnSupprimerVol.Location = New Point(545, 339)
        btnSupprimerVol.Name = "btnSupprimerVol"
        btnSupprimerVol.Size = New Size(94, 29)
        btnSupprimerVol.TabIndex = 14
        btnSupprimerVol.Text = "Supprimer"
        btnSupprimerVol.UseVisualStyleBackColor = False
        ' 
        ' dgvVols
        ' 
        dgvVols.BackgroundColor = Color.LightBlue
        dgvVols.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvVols.GridColor = Color.SaddleBrown
        dgvVols.Location = New Point(12, 443)
        dgvVols.Name = "dgvVols"
        dgvVols.RowHeadersWidth = 51
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        dgvVols.RowsDefaultCellStyle = DataGridViewCellStyle1
        dgvVols.Size = New Size(746, 188)
        dgvVols.TabIndex = 15
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Monotype Corsiva", 22.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.MidnightBlue
        Label1.Location = New Point(207, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(329, 45)
        Label1.TabIndex = 16
        Label1.Text = "Page d'administration"
        ' 
        ' FormGestionVols
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(770, 643)
        Controls.Add(Label1)
        Controls.Add(dgvVols)
        Controls.Add(btnSupprimerVol)
        Controls.Add(btnModifierVol)
        Controls.Add(btnAjouterVol)
        Controls.Add(dtpDateVol)
        Controls.Add(txtPrix)
        Controls.Add(txtPlaces)
        Controls.Add(txtDestination)
        Controls.Add(txtHeure)
        Controls.Add(txtNumeroVol)
        Controls.Add(lblHeure)
        Controls.Add(lblPrix)
        Controls.Add(lblDestination)
        Controls.Add(lblPlaces)
        Controls.Add(lblDateVol)
        Controls.Add(lblNumeroVol)
        DoubleBuffered = True
        Name = "FormGestionVols"
        Text = "FormGestionVols"
        CType(dgvVols, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNumeroVol As Label
    Friend WithEvents lblDateVol As Label
    Friend WithEvents lblPlaces As Label
    Friend WithEvents lblDestination As Label
    Friend WithEvents lblPrix As Label
    Friend WithEvents lblHeure As Label
    Friend WithEvents txtNumeroVol As TextBox
    Friend WithEvents txtHeure As TextBox
    Friend WithEvents txtDestination As TextBox
    Friend WithEvents txtPlaces As TextBox
    Friend WithEvents txtPrix As TextBox
    Friend WithEvents dtpDateVol As DateTimePicker
    Friend WithEvents btnAjouterVol As Button
    Friend WithEvents btnModifierVol As Button
    Friend WithEvents btnSupprimerVol As Button
    Friend WithEvents dgvVols As DataGridView
    Friend WithEvents Label1 As Label


End Class
