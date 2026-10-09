Public Class Form1
    Public Files() As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FBD As New FolderBrowserDialog
        If FBD.ShowDialog = DialogResult.OK Then
            TextBox1.Text = FBD.SelectedPath
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class
