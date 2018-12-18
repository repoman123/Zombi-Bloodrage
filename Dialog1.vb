Imports System.Windows.Forms
Public Class Dialog1
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Form1.PictureBox1.Visible = True
        Me.Close()
    End Sub
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
        Form1.Close()
    End Sub

    Private Sub Dialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form1.PictureBox3.Visible = False
        Form1.WalkLeftTimer.Stop()
        Form1.WalkRightTimer.Stop()
        Form1.PictureBox1.Top = 750
        Form1.PictureBox1.Left = 1200
    End Sub
End Class
