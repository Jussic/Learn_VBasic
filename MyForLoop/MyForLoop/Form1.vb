Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        Dim Wrap As String
        Wrap = Chr(13) & Chr(10)
        For i = 5 To 25 Step 5
            TextBox1.Text = TextBox1.Text & "Line " & i & Wrap
        Next i
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
