Imports ClassSql
Public Class F_Winner
    Dim dt As New DataTable
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        F_Participants.Show()
        Me.Hide()
    End Sub
    Private Sub F_Winner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dt = MsSql.Table("EXEC F_Winner @Name", New String() {"%"})
        dg_Winner.Rows.Clear()
        For Each dr As DataRow In dt.Rows
            dg_Winner.Rows.Add(dr(0), dr(1) & ", " & dr(2) & " " & dr(3) & ".", dr(4), dr(5))
        Next
    End Sub
    Public Sub F_Search(ValueToSeach As String)
        Try
            dt = MsSql.Table("EXEC F_Winner @Name", New String() {ValueToSeach})
            dg_Winner.Rows.Clear()
            For Each dr As DataRow In dt.Rows
                dg_Winner.Rows.Add(dr(0), dr(1) & ", " & dr(2) & " " & dr(3) & ".", dr(4), dr(5))
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_Search.TextChanged
        F_Search(txt_Search.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class