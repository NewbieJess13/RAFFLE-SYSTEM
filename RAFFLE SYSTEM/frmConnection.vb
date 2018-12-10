Imports ClassSql

Public Class frmConnection
    Public Shared Connstring As String
    Dim Audiopath As String
    Private Sub B_add_Click(sender As Object, e As EventArgs) Handles B_add.Click
        If txtServerName.Text = "" And txtAudioconnection.Text = "" Then
            MessageBox.Show("Please fill up all the required textboxes!", "Raffle System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Connstring = "Server=" & txtServerName.Text & ";Database=Raffle;Integrated Security=true"
            Audiopath = txtAudioconnection.Text
            My.Settings.ConnString = Connstring
            My.Settings.FilePath = Audiopath
            My.Settings.Save()
            txtServerName.Clear()
            txtAudioconnection.Clear()
            Application.Restart()
        End If
    End Sub

    Private Sub frmConnection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtAudioconnection.Text = My.Settings.FilePath
        Label4.Text = "* " & My.Settings.ConnString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.Reset()
        Application.Restart()
    End Sub
End Class