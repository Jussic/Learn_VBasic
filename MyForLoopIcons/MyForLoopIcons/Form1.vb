Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        For i = 1 To 4
            PictureBox1.Image = System.Drawing.Image.FromFile("C:\VBasic Project\VB Resources\chap07\FACE01" & i & ".ICO")
            MsgBox("Click here for next face.")
        Next
    End Sub
End Class

' Comments.
' The picture is not being recieved because the path is problematic. Talk to Prof. Berque? 