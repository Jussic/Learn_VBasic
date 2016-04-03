Public Class Form1

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If TextBox1.Text = "secret" Then
            Timer1.Enabled = False
            MsgBox(" Welcome to the system")
            End
        Else
            MsgBox("Sorry, friend, I dont know you")
        End If
    End Sub
End Class

' This is not working.....