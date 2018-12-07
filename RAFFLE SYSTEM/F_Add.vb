Imports System.Data.SqlClient
Public Class F_Add
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles B_add.Click
        Try

            If txt_FirstName.Text = "" And txtMiddleName.Text = "" And txtLastName.Text = "" And txt_site.Text = "" Then
                MessageBox.Show("Fill in the blanks")
            Else
                Dim conn As New SqlConnection(My.Settings.ConnString)
                conn.Open()

                Dim command As New SqlCommand("Insert Into tbl_Participants (LastName,FirstName,MiddleName,Project,Status) Values (@name,@Mname,@Lname,@site,'0') ", conn)
                command.Parameters.AddWithValue("@name", txt_FirstName.Text)
                command.Parameters.AddWithValue("@Mname", txtMiddleName.Text)
                command.Parameters.AddWithValue("@Lname", txtLastName.Text)
                command.Parameters.AddWithValue("@site", txt_site.Text)
                command.ExecuteNonQuery()
                Dim result1 As DialogResult = MessageBox.Show("Success!", "New", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt_FirstName.Text = ""
                txtMiddleName.Text = ""
                txtLastName.Text = ""
                txt_site.Text = ""
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        ImportFromExcel.Show()
        Me.Hide()
    End Sub
End Class