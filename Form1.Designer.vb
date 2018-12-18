<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ZMoveTimer = New System.Windows.Forms.Timer(Me.components)
        Me.BulletTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.ZombiSpawn = New System.Windows.Forms.Timer(Me.components)
        Me.BulletTimer2 = New System.Windows.Forms.Timer(Me.components)
        Me.WalkLeft = New System.Windows.Forms.ImageList(Me.components)
        Me.WalkLeftTimer = New System.Windows.Forms.Timer(Me.components)
        Me.WalkRight = New System.Windows.Forms.ImageList(Me.components)
        Me.WalkRightTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Gravity = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ZMoveTimer
        '
        Me.ZMoveTimer.Interval = 50
        '
        'BulletTimer
        '
        Me.BulletTimer.Interval = 3
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 1500
        '
        'ZombiSpawn
        '
        Me.ZombiSpawn.Interval = 5000
        '
        'BulletTimer2
        '
        Me.BulletTimer2.Interval = 3
        '
        'WalkLeft
        '
        Me.WalkLeft.ImageStream = CType(resources.GetObject("WalkLeft.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.WalkLeft.TransparentColor = System.Drawing.Color.Transparent
        Me.WalkLeft.Images.SetKeyName(0, "ukko kävely1.png")
        Me.WalkLeft.Images.SetKeyName(1, "Ukko kävely2.png")
        Me.WalkLeft.Images.SetKeyName(2, "Ukko kävely3.png")
        Me.WalkLeft.Images.SetKeyName(3, "Ukko kävely4.png")
        Me.WalkLeft.Images.SetKeyName(4, "Ukko kävely5.png")
        Me.WalkLeft.Images.SetKeyName(5, "Ukko kävely6.png")
        Me.WalkLeft.Images.SetKeyName(6, "Ukko kävely7.png")
        '
        'WalkLeftTimer
        '
        '
        'WalkRight
        '
        Me.WalkRight.ImageStream = CType(resources.GetObject("WalkRight.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.WalkRight.TransparentColor = System.Drawing.Color.Transparent
        Me.WalkRight.Images.SetKeyName(0, "ukko kävely1flip.png")
        Me.WalkRight.Images.SetKeyName(1, "Ukko kävely2flip.png")
        Me.WalkRight.Images.SetKeyName(2, "Ukko kävely3flip.png")
        Me.WalkRight.Images.SetKeyName(3, "Ukko kävely4flip.png")
        Me.WalkRight.Images.SetKeyName(4, "Ukko kävely5flip.png")
        Me.WalkRight.Images.SetKeyName(5, "Ukko kävely6flip.png")
        Me.WalkRight.Images.SetKeyName(6, "Ukko kävely7flip.png")
        '
        'WalkRightTimer
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Deaths"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(68, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Kills"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(98, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "0"
        '
        'Gravity
        '
        Me.Gravity.Interval = 25
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.WindowsApplication1.My.Resources.Resources.Box1
        Me.PictureBox4.Location = New System.Drawing.Point(5, 335)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(233, 17)
        Me.PictureBox4.TabIndex = 15
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(398, 213)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(90, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.WindowsApplication1.My.Resources.Resources.ammus_oik_
        Me.PictureBox5.Location = New System.Drawing.Point(469, 190)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(19, 10)
        Me.PictureBox5.TabIndex = 9
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.ammus
        Me.PictureBox2.Location = New System.Drawing.Point(398, 190)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 10)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(398, 145)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 118)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(653, 466)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ZMoveTimer As System.Windows.Forms.Timer
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents BulletTimer As System.Windows.Forms.Timer
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents ZombiSpawn As System.Windows.Forms.Timer
    Friend WithEvents BulletTimer2 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents WalkLeft As System.Windows.Forms.ImageList
    Friend WithEvents WalkLeftTimer As System.Windows.Forms.Timer
    Friend WithEvents WalkRight As System.Windows.Forms.ImageList
    Friend WithEvents WalkRightTimer As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Gravity As System.Windows.Forms.Timer
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox

End Class
