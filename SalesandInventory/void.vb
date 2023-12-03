Public Class void
    Private totalprice As Double
    Private qty As Integer
    Public voidId As Integer
    Public prodID As Integer
    Public transID As Integer
    Public db As New DataTable
    Public db1 As New DataTable
    Private trans As New transaction
    'Public Sub unVoidGetData()
    '    connect()
    '    Dim com As New Odbc.OdbcCommand("SELECT * FROM vw_void WHERE voidID=?", con)
    '    com.Parameters.AddWithValue("?", )
    'End Sub

    Public Sub deleteItem()
        For i = 0 To frmPOS.dgvItem.RowCount - 1
            Dim qty As Integer = frmPOS.dgvItem.Item(5, i).Value
            frmPOS.dgvItem.Item(5, i).Value = qty - Val(frmvoidqty.txtvoid.Text)
            Dim unitprice As Double = frmPOS.dgvItem.Item(4, i).Value

            frmPOS.dgvItem.Item(6, i).Value = frmPOS.dgvItem.Item(5, i).Value * unitprice
            prodID = frmPOS.dgvItem.Item(5, i).Value
            qty = frmPOS.dgvItem(5, i).Value
            totalprice = unitprice * Val(frmvoidqty.txtvoid.Text)
            transID = frmPOS.dgvItem.Item(7, i).Value
            Call trans.Totalprice()
        Next
    End Sub

    Public Sub fetchVoidInfo()
        connect()
        Dim cmd As New Odbc.OdbcCommand("SELECT voidID, transheadId, itemID FROM vwvoid WHERE transheadId=? AND itemid=?", con)
        cmd.Parameters.AddWithValue("?", Val(frmPOS.lbltransId.Text))
        cmd.Parameters.AddWithValue("?", prodID)
        Dim adp As New Odbc.OdbcDataAdapter(cmd)
        adp.Fill(db)
    End Sub

    Public Sub deleteTransaction(ByVal str As String)
        Try
            Dim com As New Odbc.OdbcCommand(str, con)
            com.Parameters.AddWithValue("?", CInt(frmPOS.dgvItem.Item(7, frmPOS.dgvItem.CurrentRow.Index).Value))
            com.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Deleting transaction", vbInformation)
        End Try
    End Sub
    Public Sub addUnvoid(ByVal str As String, ByVal qty As Integer, ByVal totprice As Double, ByVal id As Integer)
        Try
            connect()
            Dim com As New Odbc.OdbcCommand(str, con)
            com.Parameters.AddWithValue("@qty", qty)
            com.Parameters.AddWithValue("@totprice", totprice)
            com.Parameters.AddWithValue("@id", id)
            com.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error Adding Unvoiding", vbInformation, "")
        Finally
            GC.Collect()
        End Try
    End Sub
    Public Sub deleteVoid(ByVal str As String, ByVal id As Integer)
        Try
            connect()
            Dim cmd As New Odbc.OdbcCommand(str, con)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error Fetching Data", vbCritical, "")
        Finally
            GC.Collect()
        End Try
    End Sub

    Public Sub minusItem()
        For i As Integer = 0 To frmPOS.dgvItem.RowCount - 1
            Dim qty As Integer = frmPOS.dgvItem.Item(5, i).Value
            frmPOS.dgvItem.Item(5, i).Value = qty - Val(frmvoidqty.txtvoid.Text)
            Dim price As Double = frmPOS.dgvItem.Item(4, i).Value
            frmPOS.dgvItem.Item(6, i).Value = frmPOS.dgvItem.Item(5, i).Value * price
            prodID = frmPOS.dgvItem.Item(1, i).Value
            qty = frmPOS.dgvItem.Item(5, i).Value
            totalprice = frmvoidqty.txtvoid.Text * price
            transID = frmPOS.dgvItem.Item(7, i).Value
            Call trans.totalPrice()
            frmPOS.dgvItem.Enabled = False
        Next
        Call fetchExistingVoidProduct()
    End Sub

    Public Sub fetchExistingVoidProduct()
        connect()
        Dim cmd As New Odbc.OdbcCommand("SELECT VoidID, transheadId, itemid, UnitP FROM vwvoid WHERE transheadId=? AND itemid=?", con)
        cmd.Parameters.AddWithValue("?", frmPOS.lbltransId.Text)
        cmd.Parameters.AddWithValue("?", frmPOS.dgvItem.Item(1, frmPOS.dgvItem.CurrentRow.Index).Value)
        Dim adp As New Odbc.OdbcDataAdapter(cmd)
        adp.Fill(db)
        If db.Rows.Count = 1 Then
            voidId = db.Rows(0)(0)
            totalprice = frmvoidqty.txtvoid.Text * db.Rows(0)(3)
            Call updatevoid("UPDATE void SET qty=qty?qty, totalprice=totalprice+?tot WHERE voidID=?id", Val(frmvoidqty.txtvoid.Text))
            Call trans.unfinishTransaction("UPDATE temp_transaction SET qty=qty-?,totalprice=? WHERE transId=?", 3)
            Exit Sub
        Else
            Call insertVoid(Val(frmvoidqty.txtvoid.Text))
            Call trans.unfinishTransaction("UPDATE temp_transaction SET qty=qty-?,totalprice=? WHERE transId=?", 3)
        End If
        con.Dispose()
        db.Clear()
    End Sub
    Public Sub updatevoid(ByVal str As String, ByVal quantity As Integer)
        Try
            connect()
            Dim com As New Odbc.OdbcCommand(str, con)
            com.Parameters.AddWithValue("@qty", quantity)
            com.Parameters.AddWithValue("@totprice", totalprice)
            com.Parameters.AddWithValue("@id", Val(voidId))
            com.ExecuteNonQuery()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub insertVoid(ByVal quantity As Integer)
        Try
            connect()
            Dim str As String = "INSERT INTO void(transheadId, itemid, qty, totalprice, date_void, empID)VALUES(?, ?, ?, ?, ?, ?)"
            Dim cmd As New Odbc.OdbcCommand
            cmd = New Odbc.OdbcCommand(str, con)
            cmd.Parameters.AddWithValue("?", frmPOS.lbltransId.Text)
            cmd.Parameters.AddWithValue("?", CInt(prodID))
            cmd.Parameters.AddWithValue("?", quantity)
            cmd.Parameters.AddWithValue("?", Val(totalprice))
            cmd.Parameters.AddWithValue("?", Mainform.lbldate.Text)
            cmd.Parameters.AddWithValue("?", 1)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error Insert-Voiding Items", vbCritical, "")
        Finally
            GC.Collect()
        End Try
    End Sub


    Public Sub VoidTransaction()
        Dim id As Integer
        For e As Integer = 0 To frmPOS.dgvItem.RowCount - 1
            id = frmPOS.dgvItem.Item(7, e).Value
            prodID = frmPOS.dgvItem.Item(1, e).Value

            fetchVoid(id, prodID)

            If db1.Rows.Count = 0 Then
                Call deleteVoid("DELETE FROM temp_transaction WHERE transId=?", id)
            Else
                Call deleteVoid("DELETE FROM temp_transaction WHERE transId=?", id)
                Call VoidCancel("DELETE FROM void WHERE transheadId=?", frmPOS.lbltransId.Text)
            End If
        Next
    End Sub

    Sub fetchVoid(ByVal id As Integer, ByVal prodID As Integer)
        Try
            connect()
            Dim cmd1 As New Odbc.OdbcCommand("SELECT * FROM vwvoid WHERE transheadId=? AND itemid=?", con)
            cmd1.Parameters.AddWithValue("?", id)
            cmd1.Parameters.AddWithValue("?", prodID)
            Dim adp1 As New Odbc.OdbcDataAdapter(cmd1)
            adp1.Fill(db1)
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Public Sub VoidCancel(ByVal str As String, ByVal id As Integer)
        Try
            Dim com As New Odbc.OdbcCommand(str, con)
            com.Parameters.AddWithValue("?", id)
            com.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Unprocess Transaction", vbInformation, "Error Void")
        End Try
    End Sub
End Class
