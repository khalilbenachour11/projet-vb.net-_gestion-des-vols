Public Class FormConnexion

    Private Sub btnConnexion_Click(sender As Object, e As EventArgs) Handles btnConnexion.Click
        Dim username = txtUsername.Text
        Dim password = txtPassword.Text

        If username = "admin" And password = "admin123" Then
            MessageBox.Show("Connecté en tant qu'Admin.")
            Dim adminForm As New FormGestionVols()
            adminForm.Show()
            ' Me.Hide()
        ElseIf username = "user" And password = "user123" Then
            MessageBox.Show("Connecté en tant qu'Utilisateur.")
            Dim userForm As New FormReservation()
            userForm.Show()
            'Me.Hide()
        Else
            lblMessage.Text = "Identifiants incorrects !"
        End If
    End Sub
End Class
Public Class ApplicationData
    Public Shared Vols As New List(Of FormGestionVols.Vol)
End Class