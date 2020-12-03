Public Class Form2
    Sub move(p As PictureBox, x As Integer, y As Integer)
        p.Location = New Point(p.Location.X + x, p.Location.Y + y)
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown, replayButton.KeyDown
        If gameover.Visible Or yay.Visible Then
            Exit Sub
        End If
        Select Case e.KeyCode

            Case Keys.R
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
                Me.Refresh()
            Case Keys.Up, Keys.W
                MoveTo(PictureBox1, 0, -15)

            Case Keys.Down, Keys.S
                MoveTo(PictureBox1, 0, 15)

            Case Keys.Left, Keys.A
                MoveTo(PictureBox1, -15, 0)

            Case Keys.Right, Keys.D
                MoveTo(PictureBox1, 15, 0)

            Case Keys.Space
                Bullet.Location = PictureBox1.Location
                Bullet.Visible = True
                Timer2.Enabled = True
        End Select
    End Sub
    Sub follow(p As PictureBox)
        Static headstart As Integer
        Static c As New Collection
        c.Add(PictureBox1.Location)
        headstart = headstart + 1
        If headstart > 10 Then
            p.Location = c.Item(1)
            c.Remove(1)
        End If
    End Sub

    Public Sub chase(p As PictureBox)
        Dim x, y As Integer
        If p.Location.X > PictureBox1.Location.X Then
            x = -5
        Else
            x = 5
        End If
        MoveTo(p, x, 0)
        If p.Location.Y < PictureBox1.Location.Y Then
            y = 5
        Else
            y = -5
        End If
        MoveTo(p, x, y)
    End Sub



    Function Collision(p As PictureBox, t As String, Optional ByRef other As Object = vbNull)
        Dim col As Boolean

        For Each c In Controls
            Dim obj As Control
            obj = c
            If obj.Visible AndAlso p.Bounds.IntersectsWith(obj.Bounds) And obj.Name.ToUpper.Contains(t.ToUpper) Then
                col = True
                other = obj
            End If
        Next
        Return col
    End Function

    'Return true or false if moving to the new location is clear of objects ending with t
    Function IsClear(p As PictureBox, distx As Integer, disty As Integer, t As String) As Boolean
        Dim b As Boolean

        p.Location += New Point(distx, disty)
        b = Not Collision(p, t)
        p.Location -= New Point(distx, disty)
        Return b
    End Function
    'Moves and object (won't move onto objects containing  "wall" and shows green if object ends with "win"
    Sub MoveTo(p As PictureBox, distx As Integer, disty As Integer)
        If IsClear(p, distx, disty, "WALL") Then
            p.Location += New Point(distx, disty)
        End If

        If p.Name = "PictureBox1" And Collision(p, "WIN") Then

            Return

        End If
    End Sub




End Class