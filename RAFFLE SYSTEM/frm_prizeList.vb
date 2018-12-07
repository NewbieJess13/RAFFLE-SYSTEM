Imports ClassSql


Public Class frm_prizeList
    Private Sub frm_prizeList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dt As New DataTable
        dt = MsSql.Table("SELECT dbo.Prize.RecID, dbo.Prize.Prize FROM dbo.Prize ORDER BY dbo.Prize.RecID ASC")

        dg1.Rows.Clear()
        For Each dr As DataRow In dt.Rows
            dg1.Rows.Add(dr(0), dr(1))
        Next

    End Sub

    Private Sub dg1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg1.CellDoubleClick

        Try

            If e.RowIndex <> -1 Or e.ColumnIndex <> -1 Then
                Dim id, PrizeName As String

                id = dg1.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value
                PrizeName = dg1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value

                Form1.cmdLoadPrize.Tag = id
                Form1.cmdLoadPrize.Text = PrizeName
                Me.Close()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class