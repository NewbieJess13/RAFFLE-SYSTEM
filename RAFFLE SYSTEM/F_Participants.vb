Imports System.Data.SqlClient
Imports ClassSql
Public Class F_Participants
    Dim dt As New DataTable
    Private Sub F_Participants_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loaddata()
    End Sub

    Private Sub b_Update_Click(sender As Object, e As EventArgs) Handles btn_Update.Click
        L_name.Visible = True
        L_site.Visible = True
        txt_name.Visible = True
        txt_site.Visible = True
        L_ID.Text = grid_list.CurrentRow.Cells("ID").Value
        txt_name.Text = grid_list.CurrentRow.Cells("Name").Value
        txt_site.Text = grid_list.CurrentRow.Cells("Site").Value
        btn_save.Visible = True
        btn_Update.Visible = False
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            Using conn As New SqlConnection(My.Settings.ConnString)
                conn.Open()
                Dim command As New SqlCommand("Update R_List Set Name = @name, Site = @site Where ID = @id ", conn)
                command.Parameters.AddWithValue("@id", L_ID.Text)
                command.Parameters.AddWithValue("@name", txt_name.Text)
                command.Parameters.AddWithValue("@site", txt_site.Text)
                command.ExecuteNonQuery()
                Dim result1 As DialogResult = MessageBox.Show("Success!", "New", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Loaddata()
                txt_name.Visible = False
                txt_site.Visible = False
                L_name.Visible = False
                L_site.Visible = False
                btn_save.Visible = False
                btn_Update.Visible = True
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Sub Loaddata()
        Try
            dt = MsSql.Table("EXEC F_EmployeeList", Nothing)
            grid_list.Rows.Clear()
            For Each dr As DataRow In dt.Rows
                grid_list.Rows.Add(dr(0), dr(1) & ", " & dr(2) & " " & dr(3), dr(4))

            Next
            L_Items.Text = "Items: " & grid_list.Rows.Count
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub txt_Search_TextChanged(sender As Object, e As EventArgs) Handles txt_Search.TextChanged
        F_Search(txt_Search.Text)

    End Sub

    Public Sub F_Search(ValueToSeach As String)
        Try
            dt = MsSql.Table("EXEC searchName @EmplaoyeeName", New String() {ValueToSeach})
            grid_list.Rows.Clear()
            For Each dr As DataRow In dt.Rows
                grid_list.Rows.Add(dr(0), dr(1) & ", " & dr(2) & " " & dr(3), dr(4))

            Next
            L_Items.Text = "Items: " & grid_list.Rows.Count
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_Delete.Click
        If MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            MsSql.ExecuteQuery("Delete from tbl_Participants Where id = @ID", New String() {grid_list.CurrentRow.Cells(0).Value})
            Loaddata()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        F_Winner.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If MessageBox.Show("Are you sure you want to reset all the participants list? You cant undo this once you agreed.", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                MsSql.ExecuteQuery("DELETE FROM tbl_Participants", Nothing)
                Loaddata()
                MessageBox.Show("All Participants has been reset", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class