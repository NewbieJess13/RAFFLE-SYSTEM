Imports System.Data.SqlClient
Imports ClassSql
Public Class F_Prizes
    Public Sub Loaddata()
        Try
            Dim dt As New DataTable

            dt = MsSql.Table("EXEC F_Prizes", Nothing)
            prizeGrid.Rows.Clear()

            For Each dr As DataRow In dt.Rows
                prizeGrid.Rows.Add(dr(0), dr(2) & " PIECE(S)" & "    " & dr(1))
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub F_Prizes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loaddata()
    End Sub

    Private Sub btn_ADD_Click(sender As Object, e As EventArgs)
        F_RaffleList.Show()
    End Sub

    Private Sub btn_DELETE_Click(sender As Object, e As EventArgs) Handles btn_DELETE.Click
        Try
            If MessageBox.Show("Are you sure do you want do delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                MsSql.ExecuteQuery("Delete from Prize Where RecID = @ID", New String() {prizeGrid.CurrentRow.Cells(0).Value})
                Loaddata()
                MessageBox.Show("Prize has been deleted from the list", "Raffle System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If MessageBox.Show("Are you sure you want to delete all the records? You can't undo this once you agreed.", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                MsSql.ExecuteQuery("DELETE FROM Prize", Nothing)
                Loaddata()
                MessageBox.Show("All records have been deleted!", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class