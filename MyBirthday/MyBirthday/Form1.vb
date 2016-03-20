Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Your birthdate was" + " " + DateTimePicker1.Text)
        MsgBox("Day of year:" + " " & DateTimePicker1.Value.DayOfYear.ToString())
    End Sub
End Class
