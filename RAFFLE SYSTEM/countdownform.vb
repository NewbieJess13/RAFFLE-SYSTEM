Public Class countdownform
    Private Sub countdownform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Timer1.Start()
        Label1.Text = 10
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text -= 1
        My.Computer.Audio.Play(My.Settings.FilePath & "beep.wav")
        If Label1.Text < 0 Then
            Timer1.Stop()
            My.Computer.Audio.Play(My.Settings.FilePath & "935271541986969.wav")
            Me.Close()
            Form1.btncountdown.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.btncountdown.Visible = False
        Me.Close()
    End Sub
End Class