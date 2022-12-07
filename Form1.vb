﻿Public Class Form1
    Dim r As Boolean = False
    Dim l As Boolean = False
    Dim u As Boolean = False
    Dim d As Boolean = False
    Dim walls() As Panel
    Dim playerspeed As Integer = 4
    Dim coins(199) As PictureBox
    Dim gosty As Integer
    Dim gostx As Integer

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If (e.KeyCode = Keys.W) Then
            u = False
        ElseIf (e.KeyCode = Keys.A) Then
            l = False
        ElseIf (e.KeyCode = Keys.S) Then
            d = False
        ElseIf (e.KeyCode = Keys.D) Then
            r = False
        End If
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.W) Then
            u = True
        ElseIf (e.KeyCode = Keys.A) Then
            l = True
        ElseIf (e.KeyCode = Keys.S) Then
            d = True
        ElseIf (e.KeyCode = Keys.D) Then
            r = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        walls = New Panel() {Panel1, Panel2, Panel4, Panel5, Panel6, Panel7, Panel8, Panel9, Panel10, Panel11, Panel12, Panel13, Panel14, Panel15, Panel16, Panel17, Panel18, Panel19, Panel20, Panel21, Panel22, Panel23, Panel24, Panel25, Panel26, Panel27, Panel28, Panel29, Panel30, Panel31, Panel32, Panel33, Panel34, Panel35, Panel36, Panel37, Panel38, Panel39, Panel40, Panel41, Panel42, Panel43, Panel44, Panel45, Panel46, Panel47, Panel48, Panel49, Panel50, Panel51, Panel52, Panel53, Panel54, Panel55, Panel56, Panel57}
        For a = 0 To walls.Length - 1
            If player.Bounds.IntersectsWith(walls(a).Bounds) Then
                Dim result As DialogResult = MessageBox.Show("Do You Want To Play Again?", "GAME OVER", MessageBoxButtons.YesNo)
                If result = DialogResult.No Then
                    End
                    move.Stop()
                ElseIf result = DialogResult.Yes Then
                    Application.Restart()
                End If
            End If
            For i = 1 To 199
                coins(i) = Me.Controls("PictureBox" & i)
            Next
        Next

    End Sub

    Private Sub move_Tick(sender As Object, e As EventArgs) Handles move.Tick
        If (u) Then
            player.Top -= playerspeed
        ElseIf (l) Then
            player.Left -= playerspeed
        ElseIf (r) Then
            player.Left += playerspeed
        ElseIf (d) Then
            player.Top += playerspeed
        End If
        'playagain()
        Try
            For i = 1 To 199
                If (player.Bounds.IntersectsWith(coins(i).Bounds)) Then
                    coins(i).Location = New Point(Me.Width, 0)
                End If
            Next
        Catch ex As Exception

        End Try
        pacspeed()
    End Sub
    Private Sub playagain()
    If (player.Bounds.IntersectsWith(prize.Bounds)) Then
                            Dim result As DialogResult = MessageBox.Show("Congratulation you won!!!", MessageBoxButtons.YesNo)
                            If result = DialogResult.No Then
                                End
                                move.Stop()
                            ElseIf result = DialogResult.Yes Then
                                Application.Restart()
                            End If
        If (player.Bounds.IntersectsWith(red.Bounds)) Then
        Dim result As DialogResult = MessageBox.Show("Do You Want To Play Again?", "GAME OVER", MessageBoxButtons.YesNo)
                            If result = DialogResult.No Then
                                End
                                move.Stop()
                            ElseIf result = DialogResult.Yes Then
                                Application.Restart()
                            End If
                            end if
            If (player.Bounds.IntersectsWith(pink.Bounds)) Then
            Dim result As DialogResult = MessageBox.Show("Do You Want To Play Again?", "GAME OVER", MessageBoxButtons.YesNo)
                            If result = DialogResult.No Then
                                End
                                move.Stop()
                            ElseIf result = DialogResult.Yes Then
                                Application.Restart()
                            End If
                            End if
                If (player.Bounds.IntersectsWith(orange.Bounds)) Then
                Dim result As DialogResult = MessageBox.Show("Do You Want To Play Again?", "GAME OVER", MessageBoxButtons.YesNo)
                            If result = DialogResult.No Then
                                End
                                move.Stop()
                            ElseIf result = DialogResult.Yes Then
                                Application.Restart()
                            End If
                            end if
                    If (player.Bounds.IntersectsWith(blue.Bounds)) Then
                        Dim result As DialogResult = MessageBox.Show("Do You Want To Play Again?", "GAME OVER", MessageBoxButtons.YesNo)
                            If result = DialogResult.No Then
                                End
                                move.Stop()
                            ElseIf result = DialogResult.Yes Then
                                Application.Restart()
                            End If
                            End If
    End Sub

    Private Sub pacspeed()
        If (playerspeed > 2) Then
            If player.Bounds.IntersectsWith(bb10.Bounds) Then
                playerspeed -= 1
            End If
            If player.Bounds.IntersectsWith(bb11.Bounds) Then
                playerspeed -= 1
            End If
            If player.Bounds.IntersectsWith(bb12.Bounds) Then
                playerspeed -= 1
            End If
            If player.Bounds.IntersectsWith(bb13.Bounds) Then
                playerspeed -= 1
            End If
            If player.Bounds.IntersectsWith(bb14.Bounds) Then
                playerspeed -= 1
            End If
            If player.Bounds.IntersectsWith(bb15.Bounds) Then
                playerspeed -= 1
            End If
            If player.Bounds.IntersectsWith(bb16.Bounds) Then
                playerspeed -= 1
            End If
            If player.Bounds.IntersectsWith(bb17.Bounds) Then
                playerspeed -= 1
            End If
            If player.Bounds.IntersectsWith(bb18.Bounds) Then
                playerspeed -= 1
            End If
            If player.Bounds.IntersectsWith(bb19.Bounds) Then
                playerspeed -= 1
            End If
            
        End If

    End Sub

    Private Sub tmrmovegost_Tick(sender As Object, e As EventArgs) Handles tmrmovegost.Tick
        Randomize()
        gostx = Rnd() * Me.Width
        gosty = Rnd() * Me.Height
        orange.Location = New Point(gostx, gosty)
        gostx = Rnd() * Me.Width
        gosty = Rnd() * Me.Height
        red.Location = New Point(gostx, gosty)
        gostx = Rnd() * Me.Width
        gosty = Rnd() * Me.Height
        pink.Location = New Point(gostx, gosty)
        gostx = Rnd() * Me.Width
        gosty = Rnd() * Me.Height
        blue.Location = New Point(gostx, gosty)
    End Sub
End Class
