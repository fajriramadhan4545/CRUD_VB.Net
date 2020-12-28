Imports System.Data.OleDb
Module mdlConfig
    Public CONN As OleDbConnection
    Public DA As OleDbDataAdapter
    Public DS As DataSet
    Public CMD As OleDbCommand
    Public DR As OleDbDataReader

    Sub koneksiDB()
        Try
            CONN = New OleDbConnection("provider=microsoft.ace.oledb.12.0; data source=CRUD.accdb")
            CONN.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
