Public Class Form1

    Private Sub TimeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimeToolStripMenuItem.Click
        Label1.Text = TimeString

    End Sub

    Private Sub ClockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClockToolStripMenuItem.Click
     
    End Sub

    Private Sub DateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DateToolStripMenuItem.Click
        Label1.Text = DateString

    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub OpenToolStripButton_Click(sender As Object, e As EventArgs) Handles OpenToolStripButton.Click
        OpenFileDialog1.Filter = "Bitmaps (*.bmp)|*.bmp|MetaFiles (*.wmf)| *.wmf"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
        End If

    End Sub

    Private Sub HelpToolStripButton_Click(sender As Object, e As EventArgs) Handles ColorToolStripButton.Click
        ColorDialog1.ShowDialog()
        Label1.ForeColor = ColorDialog1.Color
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

End Class
