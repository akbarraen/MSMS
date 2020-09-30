Imports System.Data.SqlClient
Module general
    Public connectionString As String
    Public svalue As String = "default"
    Public con As SqlConnection
    Public qry, Uname, Password, Utype As String
    Public cmd As SqlCommand
    Public dr As SqlDataReader
    Public ds As New DataSet
    Public adapter As New SqlDataAdapter
    Public i, id As Integer

    Public Sub connectiondb() 'connects to server
        connectionString = "Data Source=.\SQLEXPRESS;AttachDbFilename=D:\MEDICAL\MEDICAL\MEDDATA.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"
        con = New SqlConnection(connectionString)
        Try
            con.Open()
        Catch ex As Exception
            MsgBox("Can not open connection ! ", MsgBoxStyle.Critical)
        End Try
    End Sub
    Public Sub connection_close() 'closing the connection
        cmd.Dispose()
        con.Close()
    End Sub
End Module
