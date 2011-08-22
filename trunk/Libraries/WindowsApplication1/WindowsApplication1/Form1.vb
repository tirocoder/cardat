Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Text = "HALLO"
        If (Button1.Text = "HALLO") Then

            Button1.Width = 100
        End If
        Dim a As Double
        a = 12
        Button1.Text = a.ToString()
    End Sub
End Class
