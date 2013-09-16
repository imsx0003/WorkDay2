Option Strict On

Public Class Form1

    Private Sub btnFirstName_Click(sender As System.Object, e As System.EventArgs) Handles btnFirstName.Click

        Dim fullName As String
        ' Read the input from the user
        fullName = txtFullName.Text

        'Find the index of first space
        Dim idxSpace As Integer
        idxSpace = fullName.IndexOf(" ")

        'extract the first name
        Dim FirstName As String
        FirstName = fullName.Substring(0, idxSpace)

        'Display the result to the user
        txtFirstName.Text = FirstName

    End Sub
End Class
