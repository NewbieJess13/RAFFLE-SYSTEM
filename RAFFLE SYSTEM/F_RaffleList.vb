Imports System.Data.SqlClient
Public Class F_RaffleList
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try

            If txt_item.Text = "" Then
                MessageBox.Show("Fill the blank")
            Else
                Dim conn As New SqlConnection(My.Settings.ConnString)
                conn.Open()

                Dim command As New SqlCommand("Insert Into Prize (Prize) Values (@prize) ", conn)
                command.Parameters.AddWithValue("@prize", txt_item.Text)
                command.ExecuteNonQuery()
                Dim result1 As DialogResult = MessageBox.Show("Success!", "New", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt_item.Text = ""
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class