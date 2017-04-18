<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.previousButton = New System.Windows.Forms.Button()
        Me.nextButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.beginButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.slideshowCheckbox = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.stopslideshowButton = New System.Windows.Forms.Button()
        Me.Album = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'previousButton
        '
        Me.previousButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.previousButton.BackColor = System.Drawing.Color.MediumBlue
        Me.previousButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.previousButton.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.previousButton.Location = New System.Drawing.Point(164, 302)
        Me.previousButton.Name = "previousButton"
        Me.previousButton.Size = New System.Drawing.Size(75, 29)
        Me.previousButton.TabIndex = 1
        Me.previousButton.Text = "<< - Previous"
        Me.previousButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.previousButton.UseVisualStyleBackColor = False
        '
        'nextButton
        '
        Me.nextButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.nextButton.Location = New System.Drawing.Point(358, 302)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(75, 29)
        Me.nextButton.TabIndex = 2
        Me.nextButton.Text = "Next ->>"
        Me.nextButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(499, 374)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 4
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'beginButton
        '
        Me.beginButton.Location = New System.Drawing.Point(261, 302)
        Me.beginButton.Name = "beginButton"
        Me.beginButton.Size = New System.Drawing.Size(75, 29)
        Me.beginButton.TabIndex = 5
        Me.beginButton.Text = "Begin"
        Me.beginButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.OldLace
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(151, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.PictureBox1.Size = New System.Drawing.Size(289, 284)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'slideshowCheckbox
        '
        Me.slideshowCheckbox.Location = New System.Drawing.Point(164, 360)
        Me.slideshowCheckbox.Name = "slideshowCheckbox"
        Me.slideshowCheckbox.Size = New System.Drawing.Size(99, 24)
        Me.slideshowCheckbox.TabIndex = 7
        Me.slideshowCheckbox.Text = "StartSlideShow"
        Me.slideshowCheckbox.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'stopslideshowButton
        '
        Me.stopslideshowButton.Location = New System.Drawing.Point(334, 360)
        Me.stopslideshowButton.Name = "stopslideshowButton"
        Me.stopslideshowButton.Size = New System.Drawing.Size(99, 24)
        Me.stopslideshowButton.TabIndex = 8
        Me.stopslideshowButton.Text = "Stop Slideshow"
        Me.stopslideshowButton.UseVisualStyleBackColor = True
        '
        'Album
        '
        Me.Album.ImageStream = CType(resources.GetObject("Album.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Album.TransparentColor = System.Drawing.Color.Transparent
        Me.Album.Images.SetKeyName(0, "39551686.png")
        Me.Album.Images.SetKeyName(1, "43698590.png")
        Me.Album.Images.SetKeyName(2, "66148098.png")
        Me.Album.Images.SetKeyName(3, "119302279.png")
        Me.Album.Images.SetKeyName(4, "150915968.png")
        Me.Album.Images.SetKeyName(5, "183915336.png")
        Me.Album.Images.SetKeyName(6, "196201707.png")
        Me.Album.Images.SetKeyName(7, "198809993.png")
        Me.Album.Images.SetKeyName(8, "439438632.png")
        Me.Album.Images.SetKeyName(9, "605797315.png")
        Me.Album.Images.SetKeyName(10, "613343026.png")
        Me.Album.Images.SetKeyName(11, "614730214.jpg")
        Me.Album.Images.SetKeyName(12, "781557356.png")
        Me.Album.Images.SetKeyName(13, "828042703.png")
        Me.Album.Images.SetKeyName(14, "862149855.png")
        Me.Album.Images.SetKeyName(15, "867419686.png")
        Me.Album.Images.SetKeyName(16, "911037597.png")
        Me.Album.Images.SetKeyName(17, "926276741.png")
        Me.Album.Images.SetKeyName(18, "952790312.png")
        Me.Album.Images.SetKeyName(19, "961720139.png")
        Me.Album.Images.SetKeyName(20, "991944330.png")
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(586, 409)
        Me.Controls.Add(Me.stopslideshowButton)
        Me.Controls.Add(Me.slideshowCheckbox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.beginButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.nextButton)
        Me.Controls.Add(Me.previousButton)
        Me.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Name = "MainForm"
        Me.Text = "Memories"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents previousButton As System.Windows.Forms.Button
    Friend WithEvents nextButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents beginButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents slideshowCheckbox As System.Windows.Forms.CheckBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents stopslideshowButton As System.Windows.Forms.Button
    Friend WithEvents Album As ImageList
End Class
