Imports System.Data.SqlClient
Public Class F_RaffleList
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try

            If txt_item.Text = "" Or txt_Quan.Text = "" Or txt_price.Text = "" Then
                MessageBox.Show("Fill the blank")
            Else
                Dim conn As New SqlConnection(My.Settings.ConnString)
                conn.Open()
                Dim command As New SqlCommand("Insert Into Prize (Prize,Quantity,Price) Values (@prize,@quan,@Price) ", conn)
                command.Parameters.AddWithValue("@prize", txt_item.Text.ToUpper)
                command.Parameters.AddWithValue("@quan", txt_Quan.Text)
                command.Parameters.AddWithValue("@Price", txt_price.Text)
                command.ExecuteNonQuery()
                Dim result1 As DialogResult = MessageBox.Show("Success!", "New", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt_item.Text = ""
                txt_Quan.Text = ""
                txt_price.Text = ""
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

End Class