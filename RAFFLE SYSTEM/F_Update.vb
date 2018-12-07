Imports System.Data.SqlClient
Public Class F_Update
    Private Sub B_add_Click(sender As Object, e As EventArgs) Handles B_add.Click

        Try
                Using conn As New SqlConnection(My.Settings.ConnString)
                    conn.Open()
                Dim command As New SqlCommand("Update R_List Set  Name = @name, Site = @site Where ID = @id ", conn)
                command.Parameters.Add("@id", SqlDbType.BigInt).Value = l_id.Text
                'command.Parameters.Add("@login", SqlDbType.VarChar).Value = txtin.Text
                'command.Parameters.Add("@logout", SqlDbType.VarChar).Value = txtout.Text
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = txt_name.Text
                command.Parameters.Add("@site", SqlDbType.VarChar).Value = txt_site.Text
                command.ExecuteNonQuery()
                MessageBox.Show("Success Update!")
                'F_Participants.Dispose()
                'F_Participants.Show()

            End Using
            Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class