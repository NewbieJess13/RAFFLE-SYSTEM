Imports System.Data.SqlClient
Imports ClassSql
Public Class F_Prizes
    Public Sub Loaddata()

        Try
            prizeGrid.DataSource = MsSql.Table("EXEC F_Prizes", Nothing)
            'Dim conn As New SqlConnection(My.Settings.ConnString)
            'conn.Open()
            'Dim command As New SqlCommand("Select * From R_List", conn)
            'Dim da As New SqlDataAdapter
            'da.SelectCommand = command
            'da.Fill(dt)
            'grid_list.DataSource = dt
            'L_Items.Text = "Items: " & grid_list.Rows.Count
            prizeGrid.Columns(0).Visible = False
        Catch ex As Exception
                MsgBox(ex.ToString)
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
                MsgBox("Prize has been deleted from the list", MessageBoxIcon.Information)
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class