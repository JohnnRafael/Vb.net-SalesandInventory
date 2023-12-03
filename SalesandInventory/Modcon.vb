Imports System.Security.Cryptography
Module Modcon
    Private trd As New TripleDESCryptoServiceProvider
    Public con As Odbc.OdbcConnection
    Public dr As Odbc.OdbcDataReader
    Public zero1 As String
    Public auto1 As String
    Public position As String

    Public Sub connect()
        Try
            con = New Odbc.OdbcConnection("dsn=salesandinventory")
            con.Open()
        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message)
        End Try
    End Sub

    Public Sub loadData(ByVal sql As String, ByVal dgv As DataGridView)
        Dim da As Odbc.OdbcDataAdapter
        Dim dt As New DataTable
        Try
            da = New Odbc.OdbcDataAdapter(sql, con)
            da.Fill(dt)
            dgv.DataSource = dt
            da.Dispose()
        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message)
        End Try

    End Sub


    Public Sub loadDGV(ByVal sql As String, ByVal dgv As DataGridView, ByVal orderfield As String, Optional ByVal field As String = "", Optional ByVal value As String = "")
        Dim dt As New DataTable
        Dim da As New Odbc.OdbcDataAdapter
        Dim cmd As Odbc.OdbcCommand
        Try
            Call connect()
            If Len(value) = 0 Then
                sql = sql & " ORDER BY " & orderfield
                cmd = New Odbc.OdbcCommand(sql, con)
            Else
                sql = sql & " WHERE " & field & " LIKE ?" & " ORDER BY " & orderfield
                cmd = New Odbc.OdbcCommand(sql, con)
                cmd.Parameters.AddWithValue("@", "%" & value & "%")
            End If
            da.SelectCommand = cmd
            da.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dt.Dispose()
            con.Close()
            GC.Collect()
        End Try
    End Sub

    Public Sub loadcombobox(ByVal sql As String, ByVal cboCateg As ComboBox, ByVal info As String, ByVal pkey As String)
        Dim da As Odbc.OdbcDataAdapter
        Dim dt As New DataTable

        Try
            da = New Odbc.OdbcDataAdapter(sql, con)
            da.Fill(dt)

            cboCateg.DataSource = dt
            cboCateg.DisplayMember = info
            cboCateg.ValueMember = pkey
            da.Dispose()


        Catch ex As Exception
            MsgBox("ERROR" & ex.Message)
        End Try
    End Sub
    'Public Sub loadcombobox2(ByVal sql As String, ByVal cboCateg As Label, ByVal info As String, ByVal pkey As String)
    '    Dim da As Odbc.OdbcDataAdapter
    '    Dim dt As New DataTable

    '    Try
    '        da = New Odbc.OdbcDataAdapter(sql, con)
    '        da.Fill(dt)

    '        cboCateg.DataSource = dt
    '        cboCateg.DisplayMember = info
    '        cboCateg.ValueMember = pkey
    '        da.Dispose()


    '    Catch ex As Exception
    '        MsgBox("ERROR" & ex.Message)
    '    End Try
    'End Sub

    Public Function getItemNo() As String
        connect()
        Dim com As New Odbc.OdbcDataAdapter("SELECT count(itemcode) FROM items", con)
        Dim dt As New DataTable
        com.Fill(dt)
        auto1 = Val(dt.Rows(0)(0)) + 1
        Select Case Val(auto1)
            Case 1 To 9
                zero1 = "000"
            Case 10 To 99
                zero1 = "00"
            Case 100 To 999
                zero1 = "0"
            Case 1000 To 9999
                zero1 = ""

        End Select
        getItemNo = zero1 + auto1

    End Function
    Public Function getItemNo2() As String
        connect()
        Dim com As New Odbc.OdbcDataAdapter("SELECT count(itemcode) FROM items", con)
        Dim dt As New DataTable
        com.Fill(dt)
        auto1 = Val(dt.Rows(0)(0))
        Select Case Val(auto1)
            Case 1 To 9
                zero1 = "000"
            Case 10 To 99
                zero1 = "00"
            Case 100 To 999
                zero1 = "0"
            Case 1000 To 9999
                zero1 = ""

        End Select
        getItemNo2 = zero1 + auto1

    End Function

    Public Sub loaddgvv(ByVal sql As String, ByVal dgv As DataGridView)
        Dim da As Odbc.OdbcDataAdapter
        Dim dt As New DataTable

        Try
            Call connect()
            da = New Odbc.OdbcDataAdapter(sql, con)
            da.Fill(dt)
            dgv.DataSource = dt
            da.Dispose()

        Catch ex As Exception
            MsgBox("ERROR:" & ex.Message)
        End Try
    End Sub
    Public Sub filternum2(ByRef num As String) 'decimal point: take note
        Select Case Asc(num)

            Case 48 To 57, 8, 1, 127, 46
                num = num
            Case Else
                num = ""
        End Select
    End Sub

    Public Sub filternum(ByRef num As String) 'number only
        Select Case Asc(num)

            Case 48 To 57, 8, 1, 127
                num = num
            Case Else
                num = ""
        End Select
    End Sub
    Public Sub cmdqry(ByVal sql As String)
        Try
            connect()
            Dim cmd As Odbc.OdbcCommand
            cmd = New Odbc.OdbcCommand
            cmd.Connection = Modcon.con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As Exception

        End Try
    End Sub
    Public Sub reports(sql As String, rptname As String, crystalrpt As Object)
        Try
            Call connect()
            Dim cmd As Odbc.OdbcCommand
            cmd = New Odbc.OdbcCommand
            ' Dim dt As DataTable
            Dim da As Odbc.OdbcDataAdapter
            Dim ds As DataSet

            Dim reportname As String
            With cmd
                .Connection = Modcon.con
                .CommandText = sql
            End With
            ds = New DataSet
            da = New Odbc.OdbcDataAdapter(sql, con)
            da.Fill(ds)
            reportname = rptname
            Dim Reportdoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Dim strReportpath As String
            strReportpath = Application.StartupPath & "\Report" & reportname & ".rpt"
            With Reportdoc
                .Load(strReportpath)
                .SetDataSource(ds.Tables(0))
            End With
            With crystalrpt
                .showrefreshbutton = False
                .showclosebutton = False
                .showgrouptreebutton = False
                .reportSource = Reportdoc

            End With
        Catch ex As Exception



        End Try

    End Sub
    Public Sub posi(ByVal lblPosition As ToolStripItem)
        connect()
        Dim holder As String
        Dim positype As String
        Dim cmd1 As New Odbc.OdbcCommand
        Try
            holder = "SELECT * FROM position"
            cmd1 = New Odbc.OdbcCommand(holder, con)
            dr = cmd1.ExecuteReader
            While (dr.Read())
                If dr("lvl_id") = position Then
                    positype = dr("level")
                    lblPosition.Text = positype.ToString
                End If
            End While
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub
    Public Function encryptpass(ByVal plaintext As String) As String
        Dim plaintextBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(plaintext)
        Dim ms As New System.IO.MemoryStream
        Dim encStream As New CryptoStream(ms, trd.CreateEncryptor(),
        System.Security.Cryptography.CryptoStreamMode.Write)
        encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
        encStream.FlushFinalBlock()

        Return Convert.ToBase64String(ms.ToArray)
    End Function
End Module
