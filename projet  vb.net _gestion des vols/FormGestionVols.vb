Public Class FormGestionVols

    Public Class Vol
        Public Property Numero As String
        Public Property Destination As String
        Public Property DateVol As DateTime
        Public Property Heure As String
        Public Property PlacesDisponibles As Integer
        Public Property Prix As Decimal
    End Class

    Private Sub btnAjouterVol_Click(sender As Object, e As EventArgs) Handles btnAjouterVol.Click
        If Not ValiderSaisie() Then Exit Sub

        Dim vol = New Vol() With {
            .Numero = txtNumeroVol.Text,
            .Destination = txtDestination.Text,
            .DateVol = dtpDateVol.Value,
            .Heure = txtHeure.Text,
            .PlacesDisponibles = Integer.Parse(txtPlaces.Text),
            .Prix = Decimal.Parse(txtPrix.Text)
        }
        ApplicationData.Vols.Add(vol)
        RafraichirTableauVols()
        MessageBox.Show("Vol ajouté avec succès.")
    End Sub

    Private Sub btnModifierVol_Click(sender As Object, e As EventArgs) Handles btnModifierVol.Click
        If dgvVols.SelectedRows.Count > 0 Then
            Dim selectedIndex = dgvVols.SelectedRows(0).Index
            Dim vol = ApplicationData.Vols(selectedIndex)

            vol.Numero = txtNumeroVol.Text
            vol.Destination = txtDestination.Text
            vol.DateVol = dtpDateVol.Value
            vol.Heure = txtHeure.Text
            vol.PlacesDisponibles = Integer.Parse(txtPlaces.Text)
            vol.Prix = Decimal.Parse(txtPrix.Text)

            RafraichirTableauVols()
            MessageBox.Show("Vol modifié avec succès.")
        Else
            MessageBox.Show("Veuillez sélectionner un vol.")
        End If
    End Sub

    Private Sub btnSupprimerVol_Click(sender As Object, e As EventArgs) Handles btnSupprimerVol.Click
        If dgvVols.SelectedRows.Count > 0 Then
            Dim selectedIndex = dgvVols.SelectedRows(0).Index
            ApplicationData.Vols.RemoveAt(selectedIndex)
            RafraichirTableauVols()
            MessageBox.Show("Vol supprimé avec succès.")
        Else
            MessageBox.Show("Veuillez sélectionner un vol.")
        End If
    End Sub

    Private Sub RafraichirTableauVols()
        dgvVols.Rows.Clear()
        For Each vol In ApplicationData.Vols
            dgvVols.Rows.Add(vol.Numero, vol.Destination, vol.DateVol.ToShortDateString(), vol.Heure, vol.PlacesDisponibles, vol.Prix)
        Next
    End Sub

    Private Function ValiderSaisie() As Boolean
        If String.IsNullOrWhiteSpace(txtNumeroVol.Text) OrElse
           String.IsNullOrWhiteSpace(txtDestination.Text) OrElse
           String.IsNullOrWhiteSpace(txtHeure.Text) OrElse
           Not Integer.TryParse(txtPlaces.Text, Nothing) OrElse
           Not Decimal.TryParse(txtPrix.Text, Nothing) Then
            MessageBox.Show("Veuillez remplir tous les champs correctement.")
            Return False
        End If
        Return True
    End Function

    Private Sub FormGestionVols_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitialiserDataGridView()
        RafraichirTableauVols()
    End Sub
    Private Sub InitialiserDataGridView()
        dgvVols.Columns.Clear()
        dgvVols.Columns.Add("colNumero", "Numéro")
        dgvVols.Columns.Add("colDestination", "Destination")
        dgvVols.Columns.Add("colDate", "Date")
        dgvVols.Columns.Add("colHeure", "Heure")
        dgvVols.Columns.Add("colPlaces", "Places disponibles")
        dgvVols.Columns.Add("colPrix", "Prix")
    End Sub
End Class