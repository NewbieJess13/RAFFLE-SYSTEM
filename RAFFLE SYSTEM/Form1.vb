Imports System.Data.SqlClient
Imports System.Threading
Imports System.Timers
Imports ClassSql

Public Class Form1
    Shared random As New Random()
    Dim dt As New DataTable
    Dim dita As New DataTable
    Dim interval As Integer
    Dim intervalCounter As Integer
    Dim DestinationCounter As Integer
    Dim sample As String
    Dim con As New SqlConnection(My.Settings.ConnString)
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If intervalCounter >= interval Then
            sample = ""
            stopTimer()
            btncountdown.Visible = True
            btn_Claimed.Visible = True
            My.Computer.Audio.Stop()
            My.Computer.Audio.Play(My.Settings.FilePath & "Victory.wav")
        Else
            For i = 0 To DestinationCounter
                btncountdown.Visible = False
                Dim ran As Integer = random.Next(0, DestinationCounter)
                L_Name.Text = dt.Rows(ran).Item(1) & "," & dt.Rows(ran).Item(2) & " " & dt.Rows(ran).Item(3) & "."
                Raffle_ID.Text = dt.Rows(ran).Item(0)
                intervalCounter += 1
            Next
        End If
        Text = intervalCounter.ToString() & " > " & interval & " > " & DestinationCounter
    End Sub

    Private Sub btncountdown_Click(sender As Object, e As EventArgs) Handles btncountdown.Click
        countdownform.Label2.Text = L_Name.Text
        countdownform.ShowDialog()
    End Sub

    Private Sub AddNewParticipantsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewParticipantsToolStripMenuItem.Click
        F_Add.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_Start.Click
        If Label3.Text <> "0" Then
            startTimer()
        Else
            Dim Result2 As DialogResult = MessageBox.Show("Please select other prizes! This item is out of availability.", "Raffle System", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Private Sub DeleteParticipantToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteParticipantToolStripMenuItem.Click
        F_Participants.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MsSql.connectionString = My.Settings.ConnString
            con.Open()
            Label4.Text = "CONNECTED"
        Catch ex As Exception
            Label4.Text = "DISCONNECTED"
            If MessageBox.Show("NO CONNECTION ESTABLISHED. Want to change the settings?", "Raffle Connection", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                frmConnection.ShowDialog()
            End If
        End Try



    End Sub

    Public Sub updateStatus(id As String)
        MsSql.ExecuteQuery("Update tbl_Participants Set Status = '1' where id = @ID", New String() {id})
    End Sub
    Public Sub updatePrize(id As String)
        MsSql.ExecuteQuery("UPDATE tbl_Participants SET PrizeID = '" & cmdLoadPrize.Tag.ToString & "' WHERE id =  @ID", New String() {id})
    End Sub

    Public Sub ClaimedPrize(id As String, quan As Integer)
        MsSql.ExecuteQuery("UPDATE Prize SET Quantity = @quan WHERE RecID = @ID", New String() {quan, id})
        Label3.Text = quanquan
        MessageBox.Show("Congratulation! Prize has been claimed.", "Raffle System", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub startTimer()
        If cmdLoadPrize.Tag = Nothing Then
            Dim result1 As DialogResult = MessageBox.Show("Please select prize!!!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            My.Computer.Audio.Play(My.Settings.FilePath & "Drum Roll.wav", AudioPlayMode.BackgroundLoop)

            dt = MsSql.Table("Select * From tbl_Participants where Status = '0'   " & sample & " ORDER BY NEWID() ", Nothing)
            DestinationCounter = random.Next(1, dt.Rows.Count)
            If dt.Rows.Count > 1 Then
                btn_Start.Enabled = False
                btn_Start.Text = "Wait.."
                cmdLoadPrize.Enabled = False
                intervalCounter = 0
                Dim rndTimer As New Random()
                interval = rndTimer.Next(70000, 100000)
                Timer1.Start()
                L_Winner.Visible = False
            Else
                Dim result1 As DialogResult = MessageBox.Show("You can't spin the raffle with single person!!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If

    End Sub

    Public Sub stopTimer()
        btn_Start.Text = "START DRAW RAFFLE"
        btn_Start.Enabled = True
        cmdLoadPrize.Enabled = True
        updateStatus(Raffle_ID.Text)
        intervalCounter = 0
        Timer1.Stop()
        L_Winner.Visible = True
    End Sub

    Private Sub resetTimer()
        btn_Start.Text = "START DRAW RAFFLE"
        btn_Start.Enabled = True
        cmdLoadPrize.Enabled = True
        dt = Nothing
        gridview2.Rows.Clear()
        cmdLoadPrize.Text = ""
        cmdLoadPrize.Tag = Nothing
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.N AndAlso e.Modifiers = Keys.Control) Then
            resetTimer()
            Dim result1 As DialogResult = MessageBox.Show("Success!", "New", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lbl_count.Text = "Items : 0"
        End If

        If (e.KeyCode = Keys.R AndAlso e.Modifiers = Keys.Control) Then
            MsSql.ExecuteQuery("Update tbl_Participants Set Status = 0, PrizeID = 0 ", Nothing)
            Dim result2 As DialogResult = MessageBox.Show("Success!", "Reset All", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        If (e.KeyCode = Keys.S AndAlso e.Modifiers = Keys.Control) Then
            stopTimer()
            My.Computer.Audio.Stop()
            My.Computer.Audio.Play(My.Settings.FilePath & "Victory.wav")
            btncountdown.Visible = True
            btn_Claimed.Visible = True
        End If
    End Sub

    Private Sub cmdLoadPrize_Click(sender As Object, e As EventArgs) Handles cmdLoadPrize.Click
        If cmdLoadPrize.Tag = Nothing Then
            frm_prizeList.ShowDialog()
        Else
            If MessageBox.Show("Would you like to reset the current selected Raffle?", "Reset Raffle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                resetTimer()
                frm_prizeList.ShowDialog()
                lbl_count.Text = "Items : 0"
            End If
        End If
    End Sub

    Private Sub AddPrizesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddPrizesToolStripMenuItem.Click
        F_RaffleList.Show()
    End Sub

    Private Sub ListOfPrizesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListOfPrizesToolStripMenuItem.Click
        F_Prizes.Show()
    End Sub

    Private Sub ResetWinnersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetWinnersToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to reset all the winners?", "Raffle System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            MessageBox.Show("Success! The database has been restored to default settings", "Raffle System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MsSql.ExecuteQuery("UPDATE tbl_Participants SET Status = '0', PrizeID = '0' WHERE status <> 0 and PrizeID <> 0", Nothing)
            Application.Restart()
        End If
    End Sub

    Dim quanquan As Integer

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btn_Claimed.Click
        quanquan = Label3.Text
        quanquan -= 1
        ClaimedPrize(cmdLoadPrize.Tag, quanquan)
        updatePrize(Raffle_ID.Text)
        btn_Claimed.Visible = False
        btncountdown.Visible = False
        Dim dtt As DataTable = MsSql.Table("SELECT b.id, b.LastName, b.FirstName, b.MiddleName, b.Project, a.Prize FROM dbo.Prize AS a INNER JOIN tbl_Participants AS b ON b.PrizeID = a.RecID WHERE b.Status = 1 AND b.PrizeID = '" + cmdLoadPrize.Tag.ToString + "' ORDER BY b.id", Nothing)
        gridview2.Rows.Clear()
        For Each dr As DataRow In dtt.Rows
            gridview2.Rows.Add(dr(0), dr(1) & ", " & dr(2) & dr(3) & ".", dr(4), dr(5))
        Next
        lbl_count.Text = "Items: " & dtt.Rows.Count
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        frmConnection.ShowDialog()
    End Sub
End Class
