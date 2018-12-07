Imports System.Data.SqlClient
Public Class F_Add
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles B_add.Click
        Try

            If txt_name.Text = "" And txt_site.Text = "" Then
                MessageBox.Show("Fill in the blanks")
            Else
                Dim conn As New SqlConnection(My.Settings.ConnString)
                conn.Open()

                Dim command As New SqlCommand("Insert Into R_List (Name,Site,Status) Values (@name,@site,'0') ", conn)
                command.Parameters.AddWithValue("@name", txt_name.Text)
                command.Parameters.AddWithValue("@site", txt_site.Text)
                command.ExecuteNonQuery()
                Dim result1 As DialogResult = MessageBox.Show("Success!", "New", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt_name.Text = ""
                txt_site.Text = ""
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class