Module ModPO
    Public zero2 As String
    Public auto2 As String

    Public Function getPONo() As String
        connect()
        Dim com As New Odbc.OdbcDataAdapter("SELECT count(ponum) from porder_details", con)
        Dim dt As New DataTable
        com.Fill(dt)
        auto2 = Val(dt.Rows(0)(0)) + 1
        Select Case Val(auto2)
            Case 1 To 9
                zero2 = "000"
            Case 10 To 99
                zero2 = "00"
            Case 100 To 999
                zero2 = "0"
            Case 1000 To 9999
                zero2 = ""
        End Select
        getPONo = zero2 + auto2
    End Function

    Public Function getpoID() As Integer
        connect()
        Dim com As New Odbc.OdbcDataAdapter("SELECT count(porder_bodyid) FROM porder_details", con)
        Dim dt As New DataTable
        com.Fill(dt)
        getpoID = Val(dt.Rows(0)(0)) + 1
    End Function

    Public Sub savePO(ByVal itemid As Long, ByVal quantity As Integer, ByVal bodyID As Long)
        Try
            connect()
            Dim com As Odbc.OdbcCommand
            com = New Odbc.OdbcCommand("INSERT INTO porder(itemid,quantity,porder_bodyid) VALUES (?,?,?)", con)
            With com.Parameters
                .AddWithValue("@itemid", itemid)
                .AddWithValue("@quantity", quantity)
                .AddWithValue("@porder_bodyid", bodyID)
            End With
            com.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            GC.Collect()
            con.Dispose()
            con.Close()
        End Try
    End Sub

    Public Sub savePODetails(ByVal ponum As String, ByVal sup As String, ByVal num As Integer, ByVal dateexpect As String, ByVal dateissue As String, ByVal emp As Integer)

        Try
            connect()
            Dim comm As Odbc.OdbcCommand
            comm = New Odbc.OdbcCommand("INSERT INTO porder_details(ponum,sup_id,numberofitem,expecdate,dateissue,createdby,statid) VALUES (?,?,?,?,?,?,?)", con)
            With comm.Parameters
                .AddWithValue("", ponum)
                .AddWithValue("", sup)
                .AddWithValue("", num)
                .AddWithValue("", dateexpect)
                .AddWithValue("", dateissue)
                .AddWithValue("", emp)
                .AddWithValue("@status_id", 1)
            End With
            comm.ExecuteNonQuery()
            MsgBox("Purchase Order Successfully Saved", vbInformation, "")
        Catch ex As Exception
            MsgBox(ex.Message)
            'Finally
            '    GC.Collect()
            '    con.Dispose()
            '    con.Close()
        End Try
    End Sub
    Public Sub unfinishTransaction(ByVal str As String, ByVal intid As Integer)
        Try
            Dim cmd As Odbc.OdbcCommand
            cmd = New Odbc.OdbcCommand(str, con)
            With cmd
                If intid = 0 Then
                    .Parameters.AddWithValue("?", Val(frmnewPO.lblid))
                End If
                .ExecuteNonQuery()
                '   frmPOS.dgvItem.Tag = ""
            End With
        Catch ex As Exception

        End Try
    End Sub
End Module
