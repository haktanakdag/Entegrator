Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Threading
Imports System.IO
Imports System.Configuration
Imports System.Data.OleDb
Imports System.IO.Compression
Imports System.Xml
Imports System.Net
Imports System.Web

Public Class mainform
    Function ExcelOku()
        Dim Dosya As New OpenFileDialog
        Dosya.ShowDialog()

        Dim Baglanti As String
        Baglanti = "provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + Dosya.FileName + "';Extended Properties='Excel 12.0;HDR=YES;IMEX=1';"

        'Baglanti = "Provider=Microsoft.Jet.Oldedb.4.0;" +
        '           "Data Source=C:\Database\" + Dosya.FileName + ";"


        Dim Con As New OleDbConnection(Baglanti)
        Dim Cmd As New OleDbCommand("Select * from [Sayfa1$];")
        Cmd.Connection = Con
        Con.Open()

        Dim da As New OleDbDataAdapter(Cmd)
        Dim dt As New Data.DataTable
        da.Fill(dt)

        grdExcel.DataSource = dt
        Con.Close()
        MessageBox.Show("Excel Okundu")

    End Function
    Public Function gGetConnectionString() As String
        Dim conn As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("connstring")
        Dim connString As String = conn.ConnectionString
        Return connString
    End Function
    Function sqlconnect() As SqlConnection
        Dim sqlcon As New SqlConnection
        Using connection As New SqlConnection(gGetConnectionString())
            sqlcon = connection
        End Using
        Return sqlcon
    End Function
    Private Sub mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExcelAc_Click(sender As Object, e As EventArgs) Handles btnExcelAc.Click
        ExcelOku()
    End Sub

    Private Sub btnAktar_Click(sender As Object, e As EventArgs) Handles btnAktar.Click
        Dim Connection As New SqlConnection(gGetConnectionString())
        Connection.Open()
        Dim cmd As New SqlCommand
        cmd.Connection = Connection
        Dim tablecreate As String = "if exists (select * from INFORMATION_SCHEMA.TABLES where TABLE_NAME = 'tmp_table' AND TABLE_SCHEMA = 'dbo') " & vbCrLf &
            "drop table dbo.tmp_table;" & vbCrLf &
            "create table tmp_table ("


        Dim c As Integer = 0
        Dim tablecolons As String = ""

        For kolon As Integer = 0 To grdExcel.Columns.Count - 1
            Dim CO As String = grdExcel.Columns(kolon).Name
            Dim colon As Boolean = False
            If tablecolons = "" Then
                tablecolons = tablecolons & CO
                colon = True
            ElseIf colon = True Then
                tablecolons = tablecolons & " VARCHAR(MAX)"
                colon = False
            Else
                tablecolons = tablecolons & " VARCHAR(MAX)," & CO
            End If
        Next
        tablecreate = tablecreate & tablecolons & " VARCHAR(MAX))"
        cmd.CommandText = tablecreate
        cmd.ExecuteNonQuery()
        For i As Integer = 0 To grdExcel.Rows.Count - 2
            'For Each column In DataGridView1.Rows
            Dim query As String = "insert into tmp_table("
            Dim kolonlar As String = ""
            Dim hucre As String = ""
            For kolon As Integer = 0 To grdExcel.Columns.Count - 1
                Dim A As String = grdExcel.Columns(kolon).Name
                If kolonlar = "" Then
                    kolonlar = kolonlar & A
                Else
                    kolonlar = kolonlar & "," & A

                End If
            Next
            query = query & kolonlar & ") values ("

            For c = 0 To grdExcel.Columns.Count - 1
                Dim A As String = grdExcel.Rows(i).Cells(c).Value.ToString()
                If hucre = "" Then
                    hucre = hucre & "'" & A & "'"
                Else
                    hucre = hucre & ",'" & A & "'"
                End If

                'cmd.CommandText = "insert into tmp_deneme (a,b,c) values ('" & A & "' ,'" & A & "','" & A & "')"
                'cmd.ExecuteNonQuery()
            Next

            query = query + hucre & ")"
            'Len(query)
            cmd.CommandText = query
            cmd.ExecuteNonQuery()
        Next
        MessageBox.Show("Temp Tabloya Yazma İşlemi Başarılı")

    End Sub
End Class
