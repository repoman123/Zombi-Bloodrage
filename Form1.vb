Public Class Form1
    Dim int As Integer = 0
    Dim deaths As Integer = 1
    Dim kills As Integer = 0
    Dim Zombi As New PictureBox
    Dim c As Integer = 20
    Dim b As Integer = -50
    Dim a As Integer = 14
    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'Player Move Up
        If e.KeyCode = Keys.Up Then
            Gravity.Start()
            WalkRightTimer.Stop()
            WalkLeftTimer.Stop()
            PictureBox1.Top += -100
            'Player Move Margin Top
            If PictureBox1.Top <= 0 Then
                PictureBox1.Top += a
                PictureBox1.Height += 1
                PictureBox1.Width += 1
            End If
        End If
        'Player Move Right
        If e.KeyCode = Keys.Right Then
            Gravity.Start()
            PictureBox3.Visible = True
            PictureBox3.Top = PictureBox1.Bottom - 50
            PictureBox3.Left = PictureBox1.Left + 12
            WalkLeftTimer.Stop()
            WalkRightTimer.Start()
            PictureBox1.Name = "Right"
            PictureBox1.Image = My.Resources.ukko_ase_oik_
            PictureBox1.Left += a
            'Player Move Margin Right
            If PictureBox1.Right <= 1 Then
                PictureBox1.Left -= a
                PictureBox3.Top = PictureBox1.Bottom - 50
                PictureBox3.Left = PictureBox1.Left
            End If
        End If
        'Player Move Left
        If e.KeyCode = Keys.Left Then
            Gravity.Start()
            PictureBox3.Visible = True
            PictureBox3.Top = PictureBox1.Bottom - 50
            PictureBox3.Left = PictureBox1.Left - 22
            WalkLeftTimer.Start()
            WalkRightTimer.Stop()
            PictureBox1.Name = "Left"
            PictureBox1.Image = My.Resources.ukko_ase_vas_
            PictureBox1.Left -= a
            'Player Move Margin Left
            If PictureBox1.Left <= 1 Then
                PictureBox1.Left += a
            End If
        End If
        'Player Shoot
        If e.KeyCode = Keys.V Then
            If Timer.Enabled = False Then
                PictureBox2.Top = PictureBox1.Top + PictureBox1.Height * 0.5 - 5
                PictureBox2.Left = PictureBox1.Left + 14
                PictureBox5.Top = PictureBox1.Top + PictureBox1.Height * 0.5 - 5
                PictureBox5.Left = PictureBox1.Left + 65
                If PictureBox1.Name = "Left" Then
                    BulletTimer.Start()
                End If
                If PictureBox1.Name = "Right" Then
                    BulletTimer2.Start()
                End If
                Timer.Enabled = True
                Timer.Start()
            End If
        End If

    End Sub
    Private Sub Me_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        KeyPreview = True
        PictureBox1.Top += 720
        PictureBox3.Visible = False
        My.Resources.ukko_ase_vas_.Tag = "left"
        My.Resources.ukko_ase_oik_.Tag = "Right"
        PictureBox2.Top = PictureBox1.Top + PictureBox1.Height * 0.5 - 5
        PictureBox2.Left = PictureBox1.Left + 14
        If Dialog1.Visible = True Then
            Me.WindowState = FormWindowState.Minimized
        End If
        Zombi.Name = ("NewZombi")
        Me.Controls.Add(Zombi)
        Zombi.Image = My.Resources.zombi_elossa_oik_()
        Zombi.Left = 700
        Zombi.Top = 700
        Zombi.SizeMode = PictureBoxSizeMode.AutoSize
        ZMoveTimer.Start()
        ZombiSpawn.Start()
        Timer.Enabled = False
        PictureBox3.Left = PictureBox1.Left - 18
        PictureBox3.Top = PictureBox1.Bottom - 50
        deaths = 1
        Label2.Text = 0
    End Sub
    Private Sub Form1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        Me.KeyPreview = True
        If Keys.Left Then
            WalkLeftTimer.Stop()
            PictureBox3.Visible = False
        End If
        If Keys.Right Then
            WalkRightTimer.Stop()
            PictureBox3.Visible = False
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZMoveTimer.Tick
        Dim a = 0
        'Zombi Follow Down
        If Not Zombi.Name = "Zombi Dead" Then
            If Zombi.Visible.Equals(True) Then
                If Not Zombi.Image.ToString = "zombi oik" Then
                    If Zombi.Top >= PictureBox1.Top Then
                        Zombi.Top -= a
                    End If
                    If Zombi.Top <= PictureBox1.Top Then
                        Zombi.Top += a
                    End If
                End If
            End If
        End If
        'Zombi Follow Up
        If Not Zombi.Name = "Zombi Dead" Then
            If Zombi.Top <= PictureBox1.Top Then
                Zombi.Top += a
            End If
            If Zombi.Top >= PictureBox1.Top Then
                Zombi.Top -= a
            End If
        End If
        'Zombi Follow Left
        If Not Zombi.Name = "Zombi Dead" Then
            If Zombi.Left >= PictureBox1.Left Then
                Zombi.Left -= a
            End If
            If Zombi.Left <= PictureBox1.Left Then
                Zombi.Left += a
            End If
        End If
        'Zombi Follow Right
        If Not Zombi.Name = "Zombi Dead" Then
            If Zombi.Left <= PictureBox1.Left Then
                Zombi.Left += a
            End If
            If Zombi.Left >= PictureBox1.Left Then
                Zombi.Left -= a
            End If
        End If
        If PictureBox1.Visible = False Then
            Zombi.Top = 0
            Zombi.Left = 0
        End If
        'Player Collision With Zombi 1
        If (Zombi.Left >= PictureBox1.Left And Zombi.Left <= PictureBox1.Right) And (Zombi.Top >= PictureBox1.Top And Zombi.Top <= PictureBox1.Bottom) And Zombi.Visible Then
            PictureBox1.Visible = False
            Label2.Text = deaths
            deaths += 1
            Dialog1.Show()
        End If
        If (Zombi.Right >= PictureBox1.Left And Zombi.Right <= PictureBox1.Right) And (Zombi.Bottom >= PictureBox1.Top And Zombi.Bottom <= PictureBox1.Bottom) And Zombi.Visible Then
            PictureBox1.Visible = False
            Label2.Text = deaths
            deaths += 1
            Dialog1.Show()
        End If
        If (Zombi.Top >= PictureBox1.Top And Zombi.Top <= PictureBox1.Bottom) And (Zombi.Left >= PictureBox1.Left And Zombi.Left <= PictureBox1.Right) And Zombi.Visible Then
            PictureBox1.Visible = False
            Label2.Text = deaths
            deaths += 1
            Dialog1.Show()
        End If
    End Sub
    Private Sub BulletTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BulletTimer.Tick
        If PictureBox1.Name = "Left" Then
            PictureBox5.Visible = False
            PictureBox2.Left -= 20
            PictureBox2.Visible = True
        End If
        If (PictureBox2.Left >= Zombi.Left And PictureBox2.Left <= Zombi.Right) And (PictureBox2.Top >= Zombi.Top And PictureBox2.Top <= Zombi.Bottom) Then
            Zombi.Image = My.Resources.zombi_oik_
            Zombi.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
            Zombi.Name = "Zombi Dead"
            PictureBox2.Visible = False
        End If
        If (PictureBox5.Right >= Zombi.Left And PictureBox2.Right <= Zombi.Right) And (PictureBox2.Bottom >= Zombi.Top And PictureBox2.Bottom <= Zombi.Bottom) Then
            Zombi.Image = My.Resources.zombi_oik_
            Zombi.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
            Zombi.Name = "Zombi Dead"
            PictureBox2.Visible = False
        End If

    End Sub
    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick
        BulletTimer.Stop()
        BulletTimer2.Stop()
        PictureBox2.Visible = False
        Timer.Enabled = False
        Timer.Stop()
    End Sub
    Private Sub ZombiSpawn_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZombiSpawn.Tick
        Zombi.Image = My.Resources.zombi_elossa_oik_
        Zombi.Name = "NewZombi"
    End Sub
    Private Sub BulletTimer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BulletTimer2.Tick
        If PictureBox1.Name = "Right" Then
            PictureBox5.Visible = True
            PictureBox5.Left += 20
        End If
        If (PictureBox5.Left >= Zombi.Left And PictureBox5.Left <= Zombi.Right) And (PictureBox5.Top >= Zombi.Top And PictureBox5.Top <= Zombi.Bottom) Then
            Zombi.Image = My.Resources.zombi_oik_
            Zombi.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
            Zombi.Name = "Zombi Dead"
            PictureBox5.Visible = False
        End If
        If (PictureBox5.Right >= Zombi.Left And PictureBox5.Right <= Zombi.Right) And (PictureBox5.Bottom >= Zombi.Top And PictureBox5.Bottom <= Zombi.Bottom) Then
            Zombi.Image = My.Resources.zombi_oik_
            Zombi.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
            Zombi.Name = "Zombi Dead"
            PictureBox5.Visible = False
        End If
    End Sub
    Private Sub WalkLeftTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WalkLeftTimer.Tick
        PictureBox3.Image = WalkLeft.Images(int)
        int += 1
        If int = 6 Then
            int = 0
        End If
    End Sub

    Private Sub WalkRightTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WalkRightTimer.Tick
        PictureBox3.Image = WalkRight.Images(int)
        int += 1
        If int = 6 Then
            int = 0
        End If
    End Sub

    Private Sub Gravity_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gravity.Tick
        
        If PictureBox1.Top >= 896 Then
            Gravity.Stop()
        End If
        If (PictureBox4.Left >= PictureBox1.Left And PictureBox4.Left <= PictureBox1.Right) And (PictureBox4.Top >= PictureBox1.Top And PictureBox4.Top <= PictureBox1.Bottom) Then
            Gravity.Stop()
        End If
        If (PictureBox4.Right >= PictureBox1.Left And PictureBox4.Right <= PictureBox1.Right) And (PictureBox4.Bottom >= PictureBox1.Top And PictureBox4.Bottom <= PictureBox1.Bottom) Then
            Gravity.Stop()
        End If

    End Sub
End Class
