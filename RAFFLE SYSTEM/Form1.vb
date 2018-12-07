Imports System.Data.SqlClient
Imports System.Threading
Imports System.Timers
Imports ClassSql

Public Class Form1
    Shared random As New Random()
    Dim dt As New DataTable
    Dim interval As Integer
    Dim intervalCounter As Integer
    Dim DestinationCounter As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If intervalCounter >= interval Then
            stopTimer()
            btncountdown.Visible = True
            My.Computer.Audio.Stop()
            My.Computer.Audio.Play(My.Settings.FilePath & "Victory.wav")

        Else
            For i = 0 To DestinationCounter

                Dim ran As Integer = random.Next(0, DestinationCounter)
                L_Name.Text = dt.Rows(ran).Item(1)
                Raffle_ID.Text = dt.Rows(ran).Item(0)
                'labelID.Refresh()
                intervalCounter += 1
                'System.Threading.Thread.Sleep(0.6)
            Next
        End If
        Me.Text = intervalCounter.ToString() & " > " & interval & " > " & DestinationCounter
    End Sub
    Private Sub btncountdown_Click(sender As Object, e As EventArgs) Handles btncountdown.Click
        countdownform.Label2.Text = L_Name.Text
        countdownform.ShowDialog()

    End Sub

    Private Sub AddNewParticipantsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewParticipantsToolStripMenuItem.Click
        F_Add.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_Start.Click
        startTimer()
        My.Computer.Audio.Play(My.Settings.FilePath & "Drum Roll.wav", AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub DeleteParticipantToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteParticipantToolStripMenuItem.Click
        F_Participants.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsSql.connectionString = My.Settings.ConnString
    End Sub

    Public Sub updateStatus(id As String)
        MsSql.ExecuteQuery("Update R_List Set Status = '1', PrizeID = '" & cmdLoadPrize.Tag.ToString & "' where ID = @ID ", New String() {id})
    End Sub

    'Public Sub updateRemark(id As String)
    '    MsSql.ExecuteQuery("Update R_List Set Remark = 1 where ID = @ID ", New String() {id})
    'End Sub
    Private Sub startTimer()

        If cmdLoadPrize.Tag = Nothing Then
            'MessageBox.Show("Please select prize!")
            Dim result1 As DialogResult = MessageBox.Show("Please select prize!!!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            dt = MsSql.Table("Select ID,Name,Site From R_List where Status = '0' ORDER BY NEWID()", Nothing)
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
                'MessageBox.Show("You can't spin with single Item!")
                Dim result1 As DialogResult = MessageBox.Show("You can't spin with single Item!!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If


        End If

    End Sub
    Public Sub stopTimer()
        btn_Start.Text = "START DRAW RAFFLE"
        btn_Start.Enabled = True
        cmdLoadPrize.Enabled = True
        updateStatus(Raffle_ID.Text)
        Dim dtt As DataTable = MsSql.Table("SELECT b.ID, b.Name, b.Site, a.Prize FROM dbo.Prize AS a INNER JOIN dbo.R_List AS b ON b.PrizeID = a.RecID WHERE b.Status = 1 AND b.PrizeID = '" + cmdLoadPrize.Tag.ToString + "' ORDER BY b.ID", Nothing)
        ' gridview2.DataSource = dtt
        gridview2.Rows.Clear()
        For Each dr As DataRow In dtt.Rows
            gridview2.Rows.Add(dr(0), dr(1), dr(2), dr(3))
        Next
        lbl_count.Text = "Items: " & dtt.Rows.Count
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
        'gridview2.DataSource = Nothing

    End Sub
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.N AndAlso e.Modifiers = Keys.Control) Then
            resetTimer()
            Dim result1 As DialogResult = MessageBox.Show("Success!", "New", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lbl_count.Text = "Items : 0"
        End If
        If (e.KeyCode = Keys.R AndAlso e.Modifiers = Keys.Control) Then
            MsSql.ExecuteQuery("Update R_List Set Status = 0, PrizeID = 0 ", Nothing)
            'MessageBox.Show("Do you want to Reset", "Reset All", MessageBoxButtons.OK)
            Dim result2 As DialogResult = MessageBox.Show("Success!", "Reset All", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        If (e.KeyCode = Keys.S AndAlso e.Modifiers = Keys.Control) Then
            stopTimer()
            btncountdown.Visible = True


        End If
    End Sub
    Private Sub cmdLoadPrize_Click(sender As Object, e As EventArgs) Handles cmdLoadPrize.Click
        If cmdLoadPrize.Tag = Nothing Then
            frm_prizeList.ShowDialog()
        Else
            If MessageBox.Show("Would you like to Reset the current Raffle?", "Reset Raffle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
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
        If MsgBox("Are you sure you want to reset all the winners?", vbQuestion + vbYesNo, "Raffle System") = DialogResult.Yes Then
            MsgBox("Success! The database has been restored to default settings", vbInformation, "Raffle System")
            resetWinner(1, 0)
            Application.Restart()
        End If
    End Sub

    Public Sub resetWinner(status As String, prizeId As String)
        MsSql.ExecuteQuery("UPDATE dbo.R_List SET status = '0', PrizeID = '0' WHERE status= @status and PrizeID <> @prizeId", New String() {status, prizeId})
    End Sub
End Class
