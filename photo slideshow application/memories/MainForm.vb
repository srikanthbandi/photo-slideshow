
Option Explicit On
Option Infer Off
Option Strict On

Public Class MainForm

    Private number_photo As Integer


    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub DisplayImage()

        PictureBox1.Image = Album.Images(number_photo)
    End Sub

    Private Sub beginButton_Click(sender As Object, e As EventArgs) Handles beginButton.Click
        ' PictureBox1.Image = Album.Images(0)
        number_photo = 0
        DisplayImage()
    End Sub

    Private Sub previousButton_Click(sender As Object, e As EventArgs) Handles previousButton.Click
        number_photo = number_photo - 1
        If number_photo < 0 Then
            number_photo = Album.Images.Count - 1
        End If
        DisplayImage()

    End Sub

    Private Sub nextButton_Click(sender As Object, e As EventArgs) Handles nextButton.Click
        number_photo = number_photo + 1
        If number_photo = Album.Images.Count Then
            number_photo = 0     
        End If
        DisplayImage()

    End Sub


    Private Sub slideshowCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles slideshowCheckbox.CheckedChanged
        If slideshowCheckbox.Checked = True Then
            Timer1.Enabled = True
        Else
            Timer1.Enabled = False
        End If


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Call nextButton_Click(sender, e)
    End Sub

    Private Sub stopslideshowButton_Click(sender As Object, e As EventArgs) Handles stopslideshowButton.Click
        slideshowCheckbox.Checked = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
