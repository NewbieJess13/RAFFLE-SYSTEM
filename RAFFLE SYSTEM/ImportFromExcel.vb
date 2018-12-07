Imports System.Data.OleDb
Imports System.IO
Imports System.Data.SqlClient
Imports ClassSql
Public Class ImportFromExcel
    Private Sub btn_browse_Click(sender As Object, e As EventArgs) Handles btn_browse.Click
        Dim f As New FolderBrowserDialog
        f.Description = "Select the folder of excel files to be imported"
        Dim folderDialog As New FolderBrowserDialog
        folderDialog.ShowNewFolderButton = True
        If (folderDialog.ShowDialog() = DialogResult.OK) Then
            lstToImport.Text = folderDialog.SelectedPath
            Label1.Text = folderDialog.SelectedPath
            Dim di As New DirectoryInfo(folderDialog.SelectedPath)
            Dim myFileInfoArray As FileInfo() = di.GetFiles()
            lstToImport.DataSource = myFileInfoArray
        End If
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Dim fldr() As String = Directory.GetFiles(Label1.Text & "\")
        Dim file As String
        Dim Rd As OleDbDataReader
        Dim Olp As New SqlConnection
        Try
            For Each file In fldr
                Dim Olconn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" & file & "'; " & "Extended Properties=Excel 8.0;")
                Olconn.Open()
                Dim queryExcel As String = "Select * from[Sheet1$]"
                Dim cmd As OleDbCommand = New OleDbCommand(queryExcel, Olconn)
                Dim TestingDatabase As String = "Data Source=DESKTOP-5ABB736\SQLEXPRESS;Initial Catalog=Raffle;Integrated Security=true"
                Olp.ConnectionString = TestingDatabase
                Olp.Open()

                Using blkCopy As SqlBulkCopy = New SqlBulkCopy(Olp)
                    blkCopy.DestinationTableName = "dbo.tbl_Participants"
                    Rd = cmd.ExecuteReader
                    blkCopy.WriteToServer(Rd)
                    Rd.Close()
                End Using


            Next
            Olp.Dispose()

            MessageBox.Show("Data is successfully transfered!", "Raffle System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Imported")
            Olp.Dispose()
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsSql.connectionString = My.Settings.ConnString
        Dim dt As New DataTable

        dt = MsSql.Table("SELECT * FROM tbl_Participants", Nothing)

        dgData.Rows.Clear()

        For Each dr As DataRow In dt.Rows
            dgData.Rows.Add(dr(1) & "," & dr(2) & " " & dr(3) & ".", dr(4))
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class