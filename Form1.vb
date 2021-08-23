Public Class Form1

    Public ofd As New OpenFileDialog
    Public TBvar As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        'Me.BackColor = Color.FromArgb(0, 255, 255, 255)
        'Me.TransparencyKey = Color.Transparent
        'Me.TransparencyKey = Me.BackColor
        'PictureBox1.BackColor = Me.BackColor
        'PictureBox1.BackColor = Color.Transparent
        'TrackBar1.Maximum = 10
        'TrackBar1.Minimum = 0


    End Sub

    Private Sub btnApplyBalanced_Click(sender As Object, e As EventArgs) Handles btnApplyBalanced.Click
        Process.Start("cmd", "/k powercfg -setactive 381b4222-f694-41f0-9685-ff5bb260df2e & exit") 'Launch cmd and run power command    
    End Sub

    Private Sub btnApplyHperformance_Click(sender As Object, e As EventArgs) Handles btnApplyHperformance.Click
        Process.Start("cmd", "/k powercfg -setactive 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c & exit")
    End Sub

    Private Sub btnPowerSave_Click(sender As Object, e As EventArgs) Handles btnPowerSave.Click
        Process.Start("cmd", "/k powercfg -setactive a1841308-3541-4fab-bc81-f71556f20b4a & exit")
    End Sub

    Private Sub btnExplorer_Click(sender As Object, e As EventArgs) Handles btnExplorer.Click
        Process.Start("cmd", "/k taskkill /im explorer.exe /F & start C:\windows\explorer.exe & exit")
    End Sub

    ' Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Process.Start("cmd", "shutdown /r /o /t 0 & exit")
    'End Sub

    Private Sub BtnBrowseImg_Click(sender As Object, e As EventArgs) Handles BtnBrowseImg.Click
        If ofd.ShowDialog() = DialogResult.OK Then
            'GroupBoxOSTools.Visible = False
            'GroupBoxTools.Visible = False
            Form2.Show()
            Form2.BackgroundImage = Image.FromFile(ofd.FileName)
            Form2.Opacity = 0.7
        End If
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Dim TBfinal As Single

        TBvar = TrackBar1.Value
        TBfinal = TBvar / 10
        Form2.Opacity = TBfinal

        'lblOpacity.Text = TBvar
        'lblOpacity2.Text = TBfinal
    End Sub

    Private Sub btnCTtrue_Click(sender As Object, e As EventArgs)
        'ClickThroughOn()
    End Sub
End Class
