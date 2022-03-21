Public Class Form1
    Private Sub cmdClick_Click(sender As Object, e As EventArgs) Handles cmdClick.Click
        Dim strNama As String = txtName.Text
        Dim strResult As String = "Hello  " + strNama

        lblResult.Text = strResult
    End Sub
End Class
