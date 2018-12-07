Imports System.Data.SqlClient
Imports ClassSql
Public Class F_Participants
    Dim dt As New DataTable
    Private Sub F_Participants_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
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

        'Dim form As New F_Update
        'form.l_id.Text = grid_list.CurrentRow.Cells("ID").Value
        'form.txt_name.Text = grid_list.CurrentRow.Cells("Name").Value
        'form.txt_site.Text = grid_list.CurrentRow.Cells("Site").Value
        'form.ShowDialog()
    End Sub
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            Using conn As New SqlConnection(My.Settings.ConnString)
                conn.Open()
                Dim command As New SqlCommand("Update R_List Set Name = @name, Site = @site Where ID = @id ", conn)
                command.Parameters.AddWithValue("@id", L_ID.Text)
                'command.Parameters.Add("@login", SqlDbType.VarChar).Value = txtin.Text
                'command.Parameters.Add("@logout", SqlDbType.VarChar).Value = txtout.Text
                command.Parameters.AddWithValue("@name", txt_name.Text)
                command.Parameters.AddWithValue("@site", txt_site.Text)
                command.ExecuteNonQuery()
                Dim result1 As DialogResult = MessageBox.Show("Success!", "New", MessageBoxButtons.OK, MessageBoxIcon.Information)
                loaddata()
                'grid_list.Controls.Clear()             
                txt_name.Visible = False
                txt_site.Visible = False
                L_name.Visible = False
                L_site.Visible = False
                btn_save.Visible = False
                btn_Update.Visible = True
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub loaddata()
        Try
            grid_list.DataSource = MsSql.Table("EXEC F_EmployeeList", Nothing)
            'Dim conn As New SqlConnection(My.Settings.ConnString)
            'conn.Open()
            'Dim command As New SqlCommand("Select * From R_List", conn)
            'Dim da As New SqlDataAdapter
            'da.SelectCommand = command
            'da.Fill(dt)
            'grid_list.DataSource = dt
            grid_list.Columns(0).Visible = False
            grid_list.Columns(3).Visible = False
            grid_list.Columns(5).Visible = False
            L_Items.Text = "Items: " & grid_list.Rows.Count
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub txt_Search_TextChanged(sender As Object, e As EventArgs) Handles txt_Search.TextChanged
        F_Search(txt_Search.Text)
    End Sub
    Public Sub F_Search(ValueToSeach As String)
        Try
            grid_list.DataSource = MsSql.Table("EXEC searchName @EmplaoyeeName", New String() {ValueToSeach})
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub btn_Refresh_Click(sender As Object, e As EventArgs)
        loaddata()
    End Sub
    Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_Delete.Click
        If MessageBox.Show("Are you sure do you want do delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            MsSql.ExecuteQuery("Delete from R_list Where ID = @ID", New String() {grid_list.CurrentRow.Cells(0).Value})
            loaddata()
        Else

        End If
    End Sub
    Private Sub LinkLabel1_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        F_Winner.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

End Class