Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DisplayPictureBox.Image = ShoePictureBox.Image
        Name12.Text = "Panda Dunks"
        Year.Text = "2021"
        Color.Text = "black and white"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DisplayPictureBox.Image = PictureBox2.Image
        Name12.Text = "University Blue Dunks"
        Year.Text = "2021"
        Color.Text = "blue and white"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DisplayPictureBox.Image = PictureBox3.Image
        Name12.Text = "Bone Dunks"
        Year.Text = "2021"
        Color.Text = "white"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DisplayPictureBox.Image = PictureBox4.Image
        Name12.Text = "Vintage Green"
        Year.Text = "2021"
        Color.Text = "Green and White"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        DisplayPictureBox.Image = PictureBox5.Image
        Name12.Text = "University of Michigan"
        Year.Text = "2021"
        Color.Text = "Blue and Yellow"
    End Sub
End Class