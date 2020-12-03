<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.kracko = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Bullet = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.yay = New System.Windows.Forms.PictureBox()
        Me.KirbyBar = New System.Windows.Forms.ProgressBar()
        Me.gameover = New System.Windows.Forms.PictureBox()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.replayButton = New System.Windows.Forms.Button()
        CType(Me.kracko, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.yay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gameover, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'kracko
        '
        Me.kracko.BackColor = System.Drawing.Color.Transparent
        Me.kracko.Image = Global.game.My.Resources.Resources.cloud__1_
        Me.kracko.Location = New System.Drawing.Point(579, 22)
        Me.kracko.Name = "kracko"
        Me.kracko.Size = New System.Drawing.Size(366, 258)
        Me.kracko.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.kracko.TabIndex = 1
        Me.kracko.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.game.My.Resources.Resources.starship__1_
        Me.PictureBox1.Location = New System.Drawing.Point(75, 179)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(166, 159)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Bullet
        '
        Me.Bullet.BackColor = System.Drawing.Color.Transparent
        Me.Bullet.Image = Global.game.My.Resources.Resources.star
        Me.Bullet.Location = New System.Drawing.Point(119, 482)
        Me.Bullet.Name = "Bullet"
        Me.Bullet.Size = New System.Drawing.Size(83, 83)
        Me.Bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Bullet.TabIndex = 7
        Me.Bullet.TabStop = False
        Me.Bullet.Visible = False
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.Teal
        Me.ProgressBar1.ForeColor = System.Drawing.Color.HotPink
        Me.ProgressBar1.Location = New System.Drawing.Point(57, 22)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(499, 23)
        Me.ProgressBar1.TabIndex = 12
        Me.ProgressBar1.Value = 100
        '
        'yay
        '
        Me.yay.BackColor = System.Drawing.Color.Transparent
        Me.yay.Image = Global.game.My.Resources.Resources.win2
        Me.yay.Location = New System.Drawing.Point(361, 260)
        Me.yay.Name = "yay"
        Me.yay.Size = New System.Drawing.Size(683, 321)
        Me.yay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.yay.TabIndex = 13
        Me.yay.TabStop = False
        Me.yay.Visible = False
        '
        'KirbyBar
        '
        Me.KirbyBar.Location = New System.Drawing.Point(27, 802)
        Me.KirbyBar.Name = "KirbyBar"
        Me.KirbyBar.Size = New System.Drawing.Size(252, 23)
        Me.KirbyBar.TabIndex = 14
        Me.KirbyBar.Value = 100
        '
        'gameover
        '
        Me.gameover.BackColor = System.Drawing.Color.Transparent
        Me.gameover.Image = Global.game.My.Resources.Resources.gameover
        Me.gameover.Location = New System.Drawing.Point(364, 267)
        Me.gameover.Name = "gameover"
        Me.gameover.Size = New System.Drawing.Size(634, 321)
        Me.gameover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.gameover.TabIndex = 15
        Me.gameover.TabStop = False
        Me.gameover.Visible = False
        '
        'Timer3
        '
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Turquoise
        Me.PictureBox2.Image = Global.game.My.Resources.Resources.starship__1_
        Me.PictureBox2.Location = New System.Drawing.Point(622, 348)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(166, 159)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'replayButton
        '
        Me.replayButton.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.replayButton.Location = New System.Drawing.Point(622, 587)
        Me.replayButton.Name = "replayButton"
        Me.replayButton.Size = New System.Drawing.Size(166, 159)
        Me.replayButton.TabIndex = 18
        Me.replayButton.Text = "Retry"
        Me.replayButton.UseVisualStyleBackColor = True
        Me.replayButton.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SpringGreen
        Me.BackgroundImage = Global.game.My.Resources.Resources.tree_background
        Me.ClientSize = New System.Drawing.Size(1410, 854)
        Me.Controls.Add(Me.replayButton)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.gameover)
        Me.Controls.Add(Me.KirbyBar)
        Me.Controls.Add(Me.yay)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Bullet)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.kracko)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.kracko, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.yay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gameover, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents kracko As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Bullet As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents yay As PictureBox
    Friend WithEvents KirbyBar As ProgressBar
    Friend WithEvents gameover As PictureBox
    Friend WithEvents Timer3 As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents replayButton As Button
End Class
