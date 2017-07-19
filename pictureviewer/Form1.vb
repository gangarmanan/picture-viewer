Public Class Form1

    Private Sub OPENToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OPENToolStripMenuItem.Click
        Try
            OpenFileDialog1.Title = "Select a Picture"
            OpenFileDialog1.Filter = "Bitmap Image (*.bmp)|*.bmp|JPEG Image (*.JPEG)|*.JPEG|JPG Image (*.JPG)|*.JPG|GIF Image (*.gif)|*.gif|PNG Image (*.PNG)|*.PNG|All Files |*.*"
            OpenFileDialog1.ShowDialog()
            PictureBox1.BackgroundImage = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
