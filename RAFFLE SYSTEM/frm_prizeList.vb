Imports ClassSql


Public Class frm_prizeList
    Private Sub frm_prizeList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dt As New DataTable
        dt = MsSql.Table("SELECT dbo.Prize.RecID, dbo.Prize.Prize, dbo.Prize.Quantity, dbo.Prize.Price FROM dbo.Prize ORDER BY dbo.Prize.RecID ASC")
        dg1.Rows.Clear()
        For Each dr As DataRow In dt.Rows
            dg1.Rows.Add(dr(0), dr(2) & " PIECE(S)" & "    " & dr(1), dr(2), dr(3))
        Next

    End Sub

    Private Sub dg1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg1.CellDoubleClick
        If dg1.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value = "0" Then
            MessageBox.Show("Please select other prizes! This item is out of availability.", "Raffle System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                If e.RowIndex <> -1 Or e.ColumnIndex <> -1 Then
                    Dim id, PrizeName, QuanQuan As String

                    id = dg1.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value
                    PrizeName = dg1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
                    QuanQuan = dg1.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value

                    Form1.cmdLoadPrize.Tag = id
                    Form1.cmdLoadPrize.Text = PrizeName
                    Form1.Label3.Text = QuanQuan
                    Me.Close()

                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.cmdLoadPrize.Text = "Click me to select prize"
        Me.Close()

    End Sub

End Class