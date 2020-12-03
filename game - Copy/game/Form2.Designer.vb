<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Bullet = New System.Windows.Forms.PictureBox()
        Me.yay = New System.Windows.Forms.PictureBox()
        Me.gameover = New System.Windows.Forms.PictureBox()
        Me.replayButton = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.yay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gameover, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Turquoise
        Me.PictureBox2.Image = Global.game.My.Resources.Resources.starship__1_
        Me.PictureBox2.Location = New System.Drawing.Point(101, 373)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(166, 159)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.game.My.Resources.Resources.starship__1_
        Me.PictureBox1.Location = New System.Drawing.Point(60, 140)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(166, 159)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Bullet
        '
        Me.Bullet.BackColor = System.Drawing.Color.Transparent
        Me.Bullet.Image = Global.game.My.Resources.Resources.star
        Me.Bullet.Location = New System.Drawing.Point(12, 449)
        Me.Bullet.Name = "Bullet"
        Me.Bullet.Size = New System.Drawing.Size(83, 83)
        Me.Bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Bullet.TabIndex = 18
        Me.Bullet.TabStop = False
        Me.Bullet.Visible = False
        '
        'yay
        '
        Me.yay.BackColor = System.Drawing.Color.Transparent
        Me.yay.Image = Global.game.My.Resources.Resources.win2
        Me.yay.Location = New System.Drawing.Point(357, 241)
        Me.yay.Name = "yay"
        Me.yay.Size = New System.Drawing.Size(683, 321)
        Me.yay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.yay.TabIndex = 19
        Me.yay.TabStop = False
        Me.yay.Visible = False
        '
        'gameover
        '
        Me.gameover.BackColor = System.Drawing.Color.Transparent
        Me.gameover.Image = Global.game.My.Resources.Resources.gameover
        Me.gameover.Location = New System.Drawing.Point(381, 241)
        Me.gameover.Name = "gameover"
        Me.gameover.Size = New System.Drawing.Size(634, 321)
        Me.gameover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.gameover.TabIndex = 20
        Me.gameover.TabStop = False
        Me.gameover.Visible = False
        '
        'replayButton
        '
        Me.replayButton.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.replayButton.Location = New System.Drawing.Point(611, 568)
        Me.replayButton.Name = "replayButton"
        Me.replayButton.Size = New System.Drawing.Size(166, 159)
        Me.replayButton.TabIndex = 21
        Me.replayButton.Text = "Retry"
        Me.replayButton.UseVisualStyleBackColor = True
        Me.replayButton.Visible = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1396, 803)
        Me.Controls.Add(Me.replayButton)
        Me.Controls.Add(Me.gameover)
        Me.Controls.Add(Me.yay)
        Me.Controls.Add(Me.Bullet)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.yay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gameover, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Bullet As PictureBox
    Friend WithEvents yay As PictureBox
    Friend WithEvents gameover As PictureBox
    Friend WithEvents replayButton As Button
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
End Class
