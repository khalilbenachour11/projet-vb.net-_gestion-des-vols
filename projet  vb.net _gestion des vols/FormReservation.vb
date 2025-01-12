Public Class FormReservation
    Private Sub btnRechercherVols_Click(sender As Object, e As EventArgs) Handles btnRechercherVols.Click
        dgvRechercheVols.Rows.Clear()

        Dim destinationRecherche As String = txtRechercheDestination.Text.Trim()
        Dim dateRecherche As DateTime = dtpRechercheDate.Value
        Dim resultats = ApplicationData.Vols.Where(Function(v) v.Destination.Contains(destinationRecherche) AndAlso v.DateVol.Date = dateRecherche.Date).ToList()

        For Each vol In resultats
            dgvRechercheVols.Rows.Add(vol.Numero, vol.Destination, vol.DateVol.ToShortDateString(), vol.Heure, vol.PlacesDisponibles, vol.Prix)
        Next

        If dgvRechercheVols.Rows.Count = 0 Then
            MessageBox.Show("Aucun vol trouvé.")
        End If
    End Sub

    Private Sub btnGenererRecu_Click(sender As Object, e As EventArgs) Handles btnGenererRecu.Click
        If dgvRechercheVols.SelectedRows.Count > 0 Then
            Dim selectedIndex = dgvRechercheVols.SelectedRows(0).Index
            Dim vol = ApplicationData.Vols(selectedIndex)

            If String.IsNullOrWhiteSpace(txtNomClient.Text) OrElse String.IsNullOrWhiteSpace(txtPrenomClient.Text) Then
                MessageBox.Show("Veuillez entrer les informations du client.")
                Return
            End If

            Dim recu = $"Réservation pour {txtNomClient.Text} {txtPrenomClient.Text}" & vbCrLf &
                       $"Téléphone: {txtTelephoneClient.Text}" & vbCrLf &
                       $"Vol: {vol.Numero}, Destination: {vol.Destination}" & vbCrLf &
                       $"Date: {vol.DateVol.ToShortDateString()}, Heure: {vol.Heure}" & vbCrLf &
                       $"Prix: {vol.Prix} TND"

            Dim cheminRecu = $"Recu_{txtNomClient.Text,0}_{vol.Numero}.txt"
            IO.File.WriteAllText(cheminRecu, recu)

            MessageBox.Show($"Reçu généré avec succès: {cheminRecu}")
        Else
            MessageBox.Show("Veuillez sélectionner un vol.")
        End If
    End Sub
    Private Sub FormReservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitialiserDataGridViewRecherche()
    End Sub

    Private Sub InitialiserDataGridViewRecherche()
        dgvRechercheVols.Columns.Clear()
        dgvRechercheVols.Columns.Add("colNumero", "Numéro de vol")
        dgvRechercheVols.Columns.Add("colDestination", "Destination")
        dgvRechercheVols.Columns.Add("colDate", "Date")
        dgvRechercheVols.Columns.Add("colHeure", "Heure")
        dgvRechercheVols.Columns.Add("colPlaces", "Places disponibles")
        dgvRechercheVols.Columns.Add("colPrix", "Prix")
    End Sub

    Private Sub btnReserver_Click(sender As Object, e As EventArgs) Handles btnReserver.Click

        If String.IsNullOrWhiteSpace(txtRechercheDestination.Text) Then
            MessageBox.Show("Veuillez remplir le champ Destination.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtRechercheDestination.Focus()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtNomClient.Text) Then
            MessageBox.Show("Veuillez remplir le champ Nom.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNomClient.Focus()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtPrenomClient.Text) Then
            MessageBox.Show("Veuillez remplir le champ Prénom.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPrenomClient.Focus()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtTelephoneClient.Text) Then
            MessageBox.Show("Veuillez remplir le champ Téléphone.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTelephoneClient.Focus()
            Exit Sub
        End If


        If Not IsNumeric(txtTelephoneClient.Text) OrElse txtTelephoneClient.Text.Length <> 8 Then
            MessageBox.Show("Veuillez saisir un numéro de téléphone valide (8 chiffres).", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTelephoneClient.Focus()
            Exit Sub
        End If


        Dim selectedDate As Date
        If Not Date.TryParse(dtpRechercheDate.Text, selectedDate) OrElse selectedDate < Date.Today Then
            MessageBox.Show("Veuillez sélectionner une date valide (aujourd'hui ou plus tard).", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dtpRechercheDate.Focus()
            Exit Sub
        End If


        MessageBox.Show("Le vol a été réservé avec succès", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class