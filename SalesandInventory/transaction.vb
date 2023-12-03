Public Class transaction
    Public auto As String
    Public auto1 As Integer
    Public zero As String
    Public stocktotalId As Double
    Public prodID As Double
    Public qty1 As Long
    Public id As Integer
    Public total As Double
    Public ponum As String
    Public transId As Integer
    Public itemid As Integer

    Public Sub totalPrice()
        Dim total = 0.0
        Dim length As Integer = frmPOS.dgvItem.RowCount - 1
        'Dim vatSales, vat As Double
        For y = 0 To length
            total += frmPOS.dgvItem.Item(6, y).Value
        Next
        If frmPOS.dgvItem.RowCount = 0 Then
            frmPOS.lblsubtotal1.Text = 0
            frmPOS.lblsubtotal.Text = 0.0
            'frmPOS.lblsubtot.Text = 0.0
            'frmPOS.lblvatsales.Text = 0.0
            'frmPOS.lblvat.Text = 0.0
        Else
            frmPOS.lblsubtotal1.Text = total
            frmPOS.lblsubtotal.Text = Format(total, "#,##0.00")
            'vatSales = total / 1.12
            'vat = total - vatSales
            'frmPOS.lblvatsales.Text = vatSales
            'frmPOS.lblvatsales.Text = Format(vatSales, "#,##0.00")
            'frmPOS.lblvat.Text = vat
            'frmPOS.lblvat.Text = Format(vat, "#,##0.00")
            'frmPOS.lblsubtot.Text = total
            'frmPOS.lblsubtot.Text = Format(total, "#,##0.00")
        End If
    End Sub
    Public Sub totalPricepayment()
        Dim total = 0.0
        Dim length As Integer = frmPOSfullypaid.dgv.RowCount - 1
        'Dim vatSales, vat As Double
        For y = 0 To length
            total += frmPOSfullypaid.dgv.Item(3, y).Value
        Next
        If frmPOSfullypaid.dgv.RowCount = 0 Then
            frmPOSfullypaid.lbltotalamount.Text = 0
            frmPOSfullypaid.lbltotalamount.Text = 0.0
            'frmPOS.lblsubtot.Text = 0.0
            'frmPOS.lblvatsales.Text = 0.0
            'frmPOS.lblvat.Text = 0.0
        Else
            frmPOSfullypaid.lbltotalamount.Text = total
            frmPOSfullypaid.lbltotalamount.Text = Format(total, "#,##0.00")
            frmPOSfullypaid.lblta.Text = total
            'vatSales = total / 1.12
            'vat = total - vatSales
            'frmPOS.lblvatsales.Text = vatSales
            'frmPOS.lblvatsales.Text = Format(vatSales, "#,##0.00")
            'frmPOS.lblvat.Text = vat
            'frmPOS.lblvat.Text = Format(vat, "#,##0.00")
            'frmPOS.lblsubtot.Text = total
            'frmPOS.lblsubtot.Text = Format(total, "#,##0.00")
        End If
    End Sub
    Public Sub totalPricepayment2()
        Dim total = 0.0
        Dim length As Integer = frmPOS50.dgv.RowCount - 1
        'Dim vatSales, vat As Double
        For y = 0 To length
            total += frmPOS50.dgv.Item(3, y).Value
        Next
        If frmPOS50.dgv.RowCount = 0 Then
            frmPOS50.lbltotalamount.Text = 0
            frmPOS50.lbltotalamount.Text = 0.0
            'frmPOS.lblsubtot.Text = 0.0
            'frmPOS.lblvatsales.Text = 0.0
            'frmPOS.lblvat.Text = 0.0
        Else
            frmPOS50.lbltotalamount.Text = total
            frmPOS50.lbltotalamount.Text = Format(total, "#,##0.00")
            frmPOS50.lblta.Text = total
            'vatSales = total / 1.12
            'vat = total - vatSales
            'frmPOS.lblvatsales.Text = vatSales
            'frmPOS.lblvatsales.Text = Format(vatSales, "#,##0.00")
            'frmPOS.lblvat.Text = vat
            'frmPOS.lblvat.Text = Format(vat, "#,##0.00")
            'frmPOS.lblsubtot.Text = total
            'frmPOS.lblsubtot.Text = Format(total, "#,##0.00")
        End If
    End Sub
    Public Sub totalPriceupdate()
        Dim total = 0.0
        Dim length As Integer = frmupdate.dgv.RowCount - 1
        'Dim vatSales, vat As Double
        For y = 0 To length
            total += frmupdate.dgv.Item(4, y).Value
        Next
        If frmupdate.dgv.RowCount = 0 Then
            frmupdate.lbltat.Text = 0
            frmupdate.lbltat.Text = 0.0
            'frmPOS.lblsubtot.Text = 0.0
            'frmPOS.lblvatsales.Text = 0.0
            'frmPOS.lblvat.Text = 0.0
        Else
            frmupdate.lbltat.Text = total
            frmupdate.lbltat.Text = Format(total, "#,##0.00")
            frmupdate.lblta.Text = total
            'vatSales = total / 1.12
            'vat = total - vatSales
            'frmPOS.lblvatsales.Text = vatSales
            'frmPOS.lblvatsales.Text = Format(vatSales, "#,##0.00")
            'frmPOS.lblvat.Text = vat
            'frmPOS.lblvat.Text = Format(vat, "#,##0.00")
            'frmPOS.lblsubtot.Text = total
            'frmPOS.lblsubtot.Text = Format(total, "#,##0.00")
        End If
    End Sub
    Public Function getclientNo() As String
        connect()
        Dim com As New Odbc.OdbcDataAdapter("SELECT COUNT(Iddetails) FROM client", con)
        Dim dt As New DataTable
        com.Fill(dt)
        auto = dt.Rows(0)(0) + 1
        auto1 = Val(dt.Rows(0)(0)) + 1

        Select Case Val(auto)
            Case 1 To 9
                zero = "000"
            Case 10 To 99
                zero = "00"
            Case 100 To 999
                zero = "0"
        End Select
        getclientNo = zero + auto
    End Function
    Public Function getTransId() As Integer
        connect()
        Dim com As New Odbc.OdbcDataAdapter("SELECT COUNT(transId) FROM transaction", con)
        Dim dt As New DataTable
        com.Fill(dt)
        getTransId = dt.Rows(0)(0) + 1
    End Function
    Public Function loadTransactionNo() As String
        connect()
        Dim com As New Odbc.OdbcDataAdapter("SELECT COUNT(transid) FROM temp_transaction", con)
        Dim dt As New DataTable
        com.Fill(dt)
        loadTransactionNo = dt.Rows(0)(6)
    End Function
    Public Function getTransactionNo2() As String
        connect()
        Dim com As New Odbc.OdbcDataAdapter("SELECT COUNT(transdetailsid) FROM transaction_details2", con)
        Dim dt As New DataTable
        com.Fill(dt)
        auto = dt.Rows(0)(0) + 1
        auto1 = Val(dt.Rows(0)(0)) + 1

        Select Case Val(auto)
            Case 1 To 9
                zero = "000"
            Case 10 To 99
                zero = "00"
            Case 100 To 999
                zero = "0"
        End Select
        getTransactionNo2 = zero + auto
    End Function
    Public Function getTransactionNo() As String
        connect()
        Dim com As New Odbc.OdbcDataAdapter("SELECT COUNT(transdetailsid) FROM transaction_details", con)
        Dim dt As New DataTable
        com.Fill(dt)
        auto = dt.Rows(0)(0) + 1
        auto1 = Val(dt.Rows(0)(0)) + 1

        Select Case Val(auto)
            Case 1 To 9
                zero = "000"
            Case 10 To 99
                zero = "00"
            Case 100 To 999
                zero = "0"
        End Select
        getTransactionNo = zero + auto
    End Function
    Public Sub unfinishTransaction(ByVal str As String, ByVal intid As Integer)
        Try
            Dim cmd As Odbc.OdbcCommand
            cmd = New Odbc.OdbcCommand(str, con)
            With cmd
                If intid = 0 Then
                    .Parameters.AddWithValue("?", Val(frmPOS.totalprice))
                    .Parameters.AddWithValue("?", Val(frmPOS.transId))

                ElseIf intid = 1 Then
                    .Parameters.AddWithValue("?", Val(frmPOS.lbltransId.Text))
                    .Parameters.AddWithValue("?", Val(frmPOS.stockID))
                    .Parameters.AddWithValue("?", Val(frmPOS.qty))
                    .Parameters.AddWithValue("?", Val(frmPOS.totalprice))
                    .Parameters.AddWithValue("?", frmPOS.lbltrans.Text)
                    .Parameters.AddWithValue("?", frmPOS.lblcdut.Text)
                ElseIf intid = 2 Then
                    .Parameters.AddWithValue("?", id)
                    'ElseIf intid = 3 Then
                    '.Parameters.AddWithValue("?", frmPOS.lblTransNo.Text)
                ElseIf intid = 3 Then
                    .Parameters.AddWithValue("?", Val(frmvoidqty.txtvoid.Text))
                    .Parameters.AddWithValue("?", frmPOS.dgvItem.Item(6, frmPOS.dgvItem.CurrentRow.Index).Value)
                    .Parameters.AddWithValue("?", frmPOS.dgvItem.Item(7, frmPOS.dgvItem.CurrentRow.Index).Value)
                End If
                .ExecuteNonQuery()
                frmPOS.dgvItem.Tag = ""
            End With
        Catch ex As Exception

        End Try
    End Sub
    Public Sub saveTransactions(ByVal str As String, ByVal intid As Integer)
        Try
            connect()
            Dim cmd As Odbc.OdbcCommand
            cmd = New Odbc.OdbcCommand(str, con)
            With cmd
                If intid = 0 Then
                    .Parameters.AddWithValue("?", Val(frmPOS.lbltransid.Text))
                    .Parameters.AddWithValue("?", Val(stocktotalId))
                    .Parameters.AddWithValue("?", Val(qty1))
                    .Parameters.AddWithValue("?", Val(total))
                    .Parameters.AddWithValue("?", frmPOS.lbltrans.Text)
                    .Parameters.AddWithValue("?", frmPOS.lblid.Text)
                    .Parameters.AddWithValue("?", Val(frmPOS.lblqtyitem.Text))
                    .Parameters.AddWithValue("?", Mainform.lbldate.Text)
                End If
                .ExecuteNonQuery()
            End With
        Catch ex As Exception

        End Try
    End Sub
   
    Public Sub saveTransactions2(ByVal str As String, ByVal intid As Integer)
        Try
            connect()
            Dim cmd As Odbc.OdbcCommand
            cmd = New Odbc.OdbcCommand(str, con)
            With cmd
                If intid = 0 Then
                    .Parameters.AddWithValue("?", Val(frmPOS.lbltransid.Text))
                    .Parameters.AddWithValue("?", Val(stocktotalId))
                    .Parameters.AddWithValue("?", Val(qty1))
                    .Parameters.AddWithValue("?", Val(total))
                    .Parameters.AddWithValue("?", frmPOS.lbltrans.Text)
                    '.Parameters.AddWithValue("?", Val(frmPOS50.lblchange.Text))
                    .Parameters.AddWithValue("?", frmPOS.lblid.Text)
                    .Parameters.AddWithValue("?", Val(frmPOS.lblqtyitem.Text))
                    .Parameters.AddWithValue("?", Mainform.lbldate.Text)
                End If
                .ExecuteNonQuery()
            End With
        Catch ex As Exception

        End Try
    End Sub
    Public Sub transaction(ByVal str As String, ByVal intID As Integer)
        Try
            connect()
            Dim cmd As Odbc.OdbcCommand
            cmd = New Odbc.OdbcCommand(str, con)
            With cmd
                If intID = 0 Then
                    .Parameters.AddWithValue("?", Val(frmPOSfullypaid.lblta.Text))
                    .Parameters.AddWithValue("?", Val(frmPOSfullypaid.txtdiscount.Text))
                    .Parameters.AddWithValue("?", Val(frmPOSfullypaid.txtdelfee.Text))
                    .Parameters.AddWithValue("?", Val(frmPOSfullypaid.lblgt.Text))
                    .Parameters.AddWithValue("?", Val(frmPOSfullypaid.lblc.Text))
                    .Parameters.AddWithValue("?", Mainform.lblmaindt3.Text)
                    .Parameters.AddWithValue("?", frmPOS.lbltrans.Text)
                    ' .Parameters.AddWithValue("?", frmPOSfullypaid.lblchequeno.Text)
                    ' .Parameters.AddWithValue("?", Val(frmPOSfullypaid.txtcheque.Text))
                    '.Parameters.AddWithValue("?", Val(frmPOSfullypaid.txtewallet.Text))
                    .Parameters.AddWithValue("?", frmPOSfullypaid.lbltop.Text)
                    .Parameters.AddWithValue("?", frmPOS.lblcdut.Text)
                    .Parameters.AddWithValue("?", Val(frmPOS.lblqtyitem.Text))
                    ' .Parameters.AddWithValue("?", frmPOS.lblid.Text)
                    '.Parameters.AddWithValue("?", 1)
                    .ExecuteNonQuery()
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message.ToString, vbCritical, "ERROR MESSAGE")
        Finally
            GC.Collect()
        End Try
    End Sub
    Public Sub paymenttrans(ByVal str As String, ByVal intID As Integer)
        Try
            connect()
            Dim cmd As Odbc.OdbcCommand
            cmd = New Odbc.OdbcCommand(str, con)
            With cmd
                If intID = 0 Then
                    .Parameters.AddWithValue("?", frmPOSfullypaid.Label14.Text)
                    .ExecuteNonQuery()
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message.ToString, vbCritical, "ERROR MESSAGE")
        Finally
            GC.Collect()
        End Try
    End Sub
    Public Sub paymenttrans2(ByVal str As String, ByVal intID As Integer)
        Try
            connect()
            Dim cmd As Odbc.OdbcCommand
            cmd = New Odbc.OdbcCommand(str, con)
            With cmd
                If intID = 0 Then
                    .Parameters.AddWithValue("?", 1)
                    .ExecuteNonQuery()
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message.ToString, vbCritical, "ERROR MESSAGE")
        Finally
            GC.Collect()
        End Try
    End Sub
    'Public Sub delete()
    '    Dim cmd As Odbc.OdbcCommand
    '    Dim str As String = "DELETE FROM payment where transno=?"

    '    If Val(dgvPO.Tag) = 0 Then
    '        MsgBox("Select a record to Remove", vbCritical, "Information")
    '    Else
    '        If MsgBox("Do you want to edit the item?", MsgBoxStyle.Question + vbYesNo, "Remove") = vbYes Then
    '            Try
    '                Call connect()
    '                cmd = New Odbc.OdbcCommand(str, con)
    '                cmd.Parameters.AddWithValue("@", Val(dgvPO.Tag))
    '                cmd.ExecuteNonQuery()
    '                Call loadData("select * from po_temp", dgvPO)

    '                dgvPO.Tag = 0
    '            Catch ex As Exception
    '                MsgBox(ex.Message.ToString)
    '            Finally
    '                con.Close()
    '                GC.Collect()
    '            End Try
    '        End If
    '    End If
    'End Sub
    Public Sub addProductwarrant(str As String, intID As Integer)
        Try
            connect()
            Dim cmd As Odbc.OdbcCommand
            cmd = New Odbc.OdbcCommand(str, con)
            With cmd
                If intID = 0 Then
                    .Parameters.AddWithValue("?", qty1)
                    .Parameters.AddWithValue("?", itemid)
                    .ExecuteNonQuery()
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub
    Public Sub minusProduct(str As String, intID As Integer)
        Try
            connect()
            Dim cmd As Odbc.OdbcCommand
            cmd = New Odbc.OdbcCommand(str, con)
            With cmd
                If intID = 0 Then
                    .Parameters.AddWithValue("?", qty1)
                    .Parameters.AddWithValue("?", prodID)
                    .ExecuteNonQuery()
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub
    Public Sub minusintrans(str As String, intID As Integer)
        Try
            connect()
            Dim cmd As Odbc.OdbcCommand
            cmd = New Odbc.OdbcCommand(str, con)
            With cmd
                If intID = 0 Then
                    .Parameters.AddWithValue("?", qty1)
                    .Parameters.AddWithValue("?", itemid)
                    .Parameters.AddWithValue("?", transId)
                    .ExecuteNonQuery()
                End If
            End With
        Catch ex As Exception
        End Try
    End Sub
    Public Sub minusdel(str As String, intID As Integer)
        Try
            connect()
            Dim cmd As Odbc.OdbcCommand
            cmd = New Odbc.OdbcCommand(str, con)
            With cmd
                If intID = 0 Then
                    .Parameters.AddWithValue("?", qty1)
                    .Parameters.AddWithValue("?", prodID)
                    .Parameters.AddWithValue("?", ponum)
                    .ExecuteNonQuery()
                End If
            End With
        Catch ex As Exception
        End Try
    End Sub
    Public Sub itemmoving(str As String, intID As Integer)
        Try
            connect()
            Dim cmd As Odbc.OdbcCommand
            cmd = New Odbc.OdbcCommand(str, con)
            With cmd
                If intID = 0 Then
                    .Parameters.AddWithValue("?", qty1)
                    .Parameters.AddWithValue("?", prodID)
                    .ExecuteNonQuery()
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub
    Public Sub itemmoving2(str As String, intID As Integer)
        Try
            connect()
            Dim cmd As Odbc.OdbcCommand
            cmd = New Odbc.OdbcCommand(str, con)
            With cmd
                If intID = 0 Then
                    .Parameters.AddWithValue("?", prodID)
                    .Parameters.AddWithValue("?", qty1)
                    .Parameters.AddWithValue("?", frmPOS.lbltrans.Text)
                    .Parameters.AddWithValue("?", Mainform.lblmaindt3.Text)
                    .Parameters.AddWithValue("?", 1)
                    .ExecuteNonQuery()
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

    Public Sub cancelAll()
        Dim Id As Integer
        For e As Integer = 0 To frmPOS.dgvItem.RowCount - 1
            Id = frmPOS.dgvItem.Item(7, e).Value
            prodID = frmPOS.dgvItem.Item(1, e).Value
        Next
    End Sub
    Sub fetchVoid(id As Integer, prodID As Integer)
        connect()
        Dim cmd1 As New Odbc.OdbcCommand("")
    End Sub
    Public Sub transaction2(ByVal str As String, ByVal intID As Integer)
        Try
            connect()
            Dim cmd As Odbc.OdbcCommand
            cmd = New Odbc.OdbcCommand(str, con)
            With cmd
                If intID = 0 Then
                    .Parameters.AddWithValue("?", Val(frmPOS50.lblta.Text))
                    .Parameters.AddWithValue("?", Val(frmPOS50.txtdiscount.Text))
                    .Parameters.AddWithValue("?", Val(frmPOS50.txtdelfee.Text))
                    .Parameters.AddWithValue("?", Val(frmPOS50.lblgt.Text))
                    .Parameters.AddWithValue("?", Val(frmPOS50.lblc.Text))
                    .Parameters.AddWithValue("?", Mainform.lblmaindt3.Text)
                    .Parameters.AddWithValue("?", frmPOS.lbltrans.Text)
                    .Parameters.AddWithValue("?", frmPOS50.lbltop.Text)
                    .Parameters.AddWithValue("?", Val(frmPOS.lblqtyitem.Text))
                    ' .Parameters.AddWithValue("?", frmPOS.lblid.Text)
                    ' .Parameters.AddWithValue("?", 1)
                    .ExecuteNonQuery()
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message.ToString, vbCritical, "ERROR MESSAGE")
        Finally
            GC.Collect()
        End Try
    End Sub
    Public Sub updatetransaction(ByVal str As String, ByVal intID As Integer)
        Try
            connect()
            Dim cmd As Odbc.OdbcCommand
            cmd = New Odbc.OdbcCommand(str, con)
            With cmd
                If intID = 0 Then
                    ' .Parameters.AddWithValue("?", Mainform.lblmaindt2.Text)
                    .Parameters.AddWithValue("?", frmupdate.lblta.Text)
                    .Parameters.AddWithValue("?", frmupdate.lblc.Text)
                    ' .Parameters.AddWithValue("?", frmPOS.lblid.Text)
                    ' .Parameters.AddWithValue("?", 1)
                    .ExecuteNonQuery()
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message.ToString, vbCritical, "ERROR MESSAGE")
        Finally
            GC.Collect()
        End Try
    End Sub
End Class
