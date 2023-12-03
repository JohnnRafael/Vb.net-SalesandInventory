﻿Public Class frmPOSfullypaid
    Dim trans As New transaction
    Dim dtable As New DataTable
    Public xtotal, xgrand, change, tot As Double
    Public nonvatble As Double
    Public totVat As Double
    Public totalChange As Double
    Public totchange As Double
    Public delivfee As Double
    Public discounter As Double
    Public disc As Double
    Public totalss As Double
    Public totdis As Double
    Public totaloftotal As Double
    Public totaloftotals As Double
    Public adapt As Odbc.OdbcDataAdapter
    Private transaction As New transaction
    Private Sub frmPOSTransact_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtdiscount.Focus()
        txtdiscount.Text = "5"
        Call loadData("select * from vw_payment WHERE transno='" & frmPOS.lbltrans.Text & "'AND status=0", dgv)
        loadcombobox("SELECT paymentid, paymentname FROM paymenttype ORDER BY paymentid ASC", cbopayment, "paymentname", "paymentid")
        txtamount.Focus()
        lbltop.Text = frmPOS.lblid.Text
        Dim totDue As Double = frmPOS.lblsubtotal1.Text
        lblgrandtotal.Text = frmPOS.lblsubtotal.Text
        lbltotal1.Text = Format(totDue, "#,##0.00")
        lbltotal.Text = Format(totDue, "#,##0.00")
        lbltotalers.Text = Format(totDue, "#,##0.00")
        If txtdiscount.Text = "" Or txtdelfee.Text = "" Then
            lbltotal.Text = Format(totDue, "#,##0.00")
            lbltotalers.Text = Format(totDue, "#,##0.00")
            lblgrandtotal.Text = Format(totDue, "#,##0.00")
        End If

    End Sub
    Sub Payment()
        Dim str As String = "SELECT * FROM transaction_details WHERE transdetailsId=" & frmPOS.lbltrans.Text
        Dim da As New Odbc.OdbcDataAdapter(str, con)
        Dim dat As New DataTable
        da.Fill(dat)
        Try
            If lblta.Text = "" Or Val(lblta.Text) = 0 Then
                MsgBox("Please input amount to accept this transaction", vbInformation)
                txtamount.Focus()
                Exit Sub
            End If
            If dat.Rows.Count >= 0 Then
                trans.transaction("INSERT INTO transaction_details(amountTendered,Discount,delfee,totaDueAmount,amountChange,tDate,transNo,clientid,numberofitems,noi)VALUES(?,?,?,?,?,?,?,?,?,?)", 0)
                minusprod()
                trans.paymenttrans("UPDATE payment set status=? ", 0)
                frmPOS.btnpayment.BackColor = Color.White
                loaddgvv("SELECT * FROM vwtransaction", frmPOS.dgvItem)
                loaddgvv("SELECT stockID,itemcode,itemtype,description,Price,UnitP,quantity FROM vw_inv ORDER BY stockID DESC", frmInventory.dgv)
                lbltotal.Text = ""
                frmPOS.lblcustname.Text = "---------"
                frmPOS.lbltrans.Text = "0000000"
                Me.Dispose()
                MsgBox("Payment Successfully Saved", vbInformation, "Payment")
            End If

        Catch ex As Exception

        End Try
    End Sub
    Sub minusprod()
        Dim length As Integer = frmPOS.dgvItem.Rows.Count
        For i = 0 To length - 1
            trans.stocktotalId = frmPOS.dgvItem.Item(0, i).Value
            trans.prodID = frmPOS.dgvItem.Item(1, i).Value
            trans.qty1 = frmPOS.dgvItem.Item(5, i).Value
            trans.id = frmPOS.dgvItem.Item(7, i).Value
            trans.total = frmPOS.dgvItem.Item(6, i).Value
            trans.minusProduct("UPDATE stocks SET quantity=quantity - ? WHERE itemid = ?", 0)
            trans.saveTransactions("INSERT INTO transaction(transdetailsId,totalstockId,qty,totalprice,ornum,clientID,numberofitems,tDate)VALUES(?,?,?,?,?,?,?,?)", 0)
            trans.unfinishTransaction("DELETE FROM temp_transaction WHERE transId=?", 2)
            trans.itemmoving("UPDATE sales SET quantity=quantity + ? WHERE itemid = ?", 0)
        Next
    End Sub
    Sub computeChange()
        Dim cash As Double
        If lblta.Text = "" Then
            lblchanges.Text = 0.0
            lblchange.Text = Format(0.0, "#,##0.00")
        ElseIf lblta.Text.Contains("..") Then
            MsgBox("Invalid Input Amount!", vbInformation, "")
            txtamount.Clear()
            txtamount.Focus()
            Exit Sub
        Else
            cash = Val(lblta.Text)
            xtotal = cash
            xgrand = Replace(lblgrandtotal.Text, ",", "")
            If xgrand > xtotal Then
                lblchange.Text = "0.00"
                lblc.Text = "0.00"
            Else
                If xtotal >= Replace(lblgrandtotal.Text, ",", "") Then
                    totchange = xtotal - xgrand
                    lblchanges.Text = totchange
                    lblchange.Text = Format(totchange, "#,##0.00")
                    lblc.Text = totchange
                Else
                    lblchange.Text = "0.00"
                    lblc.Text = "0.00"
                End If
            End If
        End If
    End Sub
    Sub discount()
        Dim discount As Double
        Dim totals As Double
        Dim totdue As Double
        If txtdiscount.Text = "" Then
            lbltotal.Text = lbltotalers.Text
            totdue = lbltotalers.Text
            lbltotal.Text = Format(totdue, "#,##0.00")
        ElseIf txtamount.Text.Contains("..") Then
            MsgBox("Invalid Input Amount!", vbInformation, "")
            txtdiscount.Clear()
            txtdiscount.Focus()
            Exit Sub
        Else
            discount = Val(txtdiscount.Text)
            totals = lbltotal.Text
            discounter = discount * totals
            totdis = discounter / 100
            lbldiscount.Text = Format(totdis, "#,##0.00")
            disc = lbldiscount.Text
            totaloftotal = totals - disc
            totaloftotals = totals - disc
            lbltotal.Text = Format(totaloftotal, "#,##0.00")
            lbldiscounted.Text = totaloftotal
            lblgrandtotal.Text = Format(totaloftotals, "#,##0.00")
            lblgt.Text = totaloftotals

        End If
    End Sub
    Sub delfee()
        Dim deli As Double
        Dim totals As Double
        deli = Val(txtdelfee.Text)
        delivfee = deli
        totals = lbltotal.Text
        tot = totals
        xgrand = delivfee + tot
        lblgrandtotal.Text = Format(xgrand, "#,##0.00")
        lblgt.Text = xgrand
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmPOS.btnpayment.BackColor = Color.White
        Me.Dispose()
    End Sub
    Private Sub btnCancel_KeyDown(sender As Object, e As KeyEventArgs) Handles btnCancel.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub
    Private Sub txtcash_KeyPress(sender As Object, e As KeyPressEventArgs)
        filternum(e.KeyChar)
    End Sub
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If txtdiscount.Text = "" or txtdiscount.Text = 0 Then
            MsgBox("Please Enter Discount!", vbExclamation, "Payment")
            txtdiscount.Clear()
            txtdiscount.Focus()
            Exit Sub
        ElseIf lblta.TextLength > 10 Then
            MsgBox("Invalid Amount!", vbExclamation, "Payment")
            txtamount.Clear()
            txtamount.Focus()
            Exit Sub
        ElseIf Val(lblta.Text) < Val(lblgt.Text) Then
            MsgBox("Invalid Amount!", vbExclamation, "Payment")
            txtamount.Clear()
            txtamount.Focus()
            Exit Sub
        Else
            If MsgBox("Are you sure want to Accept Payment?", vbInformation + vbYesNo, "Payment") = vbYes Then
                Payment()
                frmPOS.lblid.Text = "00000000"
                frmPOS.lblcustname.Text = "-----------------"
                frmPOS.lbllocation.Text = "-----------------"
                frmPOS.lbltrans.Text = "0000000"
                frmPOS.Show()
                frmPOS.btnpayment.BackColor = Color.White
                loadData("SELECT * FROM vw_sales where quantity >=1 ORDER BY quantity DESC", frmitemsales.dgv)
            End If
        End If

    End Sub

    Private Sub txtdelfee_KeyPress1(sender As Object, e As KeyPressEventArgs) Handles txtdelfee.KeyPress
        filternum(e.KeyChar)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtdelfee.TextChanged
        delfee()
    End Sub
    Private Sub txtdiscount_Leave(sender As Object, e As EventArgs)
        discount()
    End Sub
    Sub current()
        Dim cash, balance As Double
        If lblta.Text = "" Then
            lblchanger.Text = 0.0
        ElseIf lblta.Text.Contains("..") Then
            MsgBox("Invalid Input Amount!", vbInformation, "")
            Exit Sub
        Else
            cash = Val(lblta.Text)
            xtotal = cash
            xgrand = Replace(lblgrandtotal.Text, ",", "")
            balance = xgrand - cash
            lblchange.Text = Format(balance, "#,##0.00")
            lblbalc.Text = balance
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        If cbopayment.Text = "Gcash" And txtpd.Text = "" Then
            MsgBox("Please Input Mobile Number!", vbOKOnly + vbInformation, "Payment")
            txtpd.Focus()
        ElseIf cbopayment.Text = "Gcash" And txtrn.Text = "" Then
            MsgBox("Please Input Reference Number!", vbOKOnly + vbInformation, "Payment")
            txtrn.Focus()
        ElseIf cbopayment.Text = "Gcash" And txtamount.Text = "" Then
            MsgBox("Please Input Amount!", vbOKOnly + vbInformation, "Payment")
            txtamount.Focus()
        ElseIf cbopayment.Text = "Paymaya" And txtpd.Text = "" Then
            MsgBox("Please Input Mobile Number!", vbOKOnly + vbInformation, "Payment")
            txtpd.Focus()
        ElseIf cbopayment.Text = "Paymaya" And txtrn.Text = "" Then
            MsgBox("Please Input Reference Number!", vbOKOnly + vbInformation, "Payment")
            txtrn.Focus()
        ElseIf cbopayment.Text = "Paymaya" And txtamount.Text = "" Then
            MsgBox("Please Input Amount!", vbOKOnly + vbInformation, "Payment")
            txtamount.Focus()
        ElseIf cbopayment.Text = "Cheque" And txtpd.Text = "" Then
            MsgBox("Please Input Cheque Information!", vbOKOnly + vbInformation, "Payment")
            txtpd.Focus()
        ElseIf cbopayment.Text = "Cheque" And txtrn.Text = "" Then
            MsgBox("Please Input Cheque Amount!", vbOKOnly + vbInformation, "Payment")
            txtpd.Focus()
        ElseIf cbopayment.Text = "Cash" And txtamount.Text = "" Then
            MsgBox("Please Input Amount!", vbOKOnly + vbInformation, "Payment")
            txtamount.Focus()
        Else
            Dim cmd As Odbc.OdbcCommand
            Dim sql As String
            sql = "INSERT INTO payment(paymenttype, paymentdetails, Amount, clientid, transno, referenceno) values (?,?,?,?,?,?)"
            cmd = New Odbc.OdbcCommand(sql, con)
            With cmd
                .Parameters.AddWithValue("?", cbopayment.SelectedValue)
                .Parameters.AddWithValue("?", txtpd.Text)
                .Parameters.AddWithValue("?", txtamount.Text)
                .Parameters.AddWithValue("?", frmPOS.lblid.Text)
                .Parameters.AddWithValue("?", frmPOS.lbltrans.Text)
                .Parameters.AddWithValue("?", txtrn.Text)
                cmd.ExecuteNonQuery()
                Call loadData("select * from vw_payment WHERE transno='" & frmPOS.lbltrans.Text & "' AND status=0", dgv)
            End With
            txtamount.Text = ""
            txtpd.Text = ""
            txtrn.Text = ""
            computeChange()
        End If

    End Sub

    Private Sub cbopayment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbopayment.SelectedIndexChanged
      
    End Sub
    Private Sub dgv_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgv.RowsAdded
        transaction.totalPricepayment()
        computeChange()
        current()
    End Sub

    Private Sub txtamount_KeyDown(sender As Object, e As KeyEventArgs) Handles txtamount.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cbopayment.Text = "Gcash" And txtpd.Text = "" Then
                MsgBox("Please Input Mobile Number!", vbOKOnly + vbInformation, "Payment")
                txtpd.Focus()
            ElseIf cbopayment.Text = "Gcash" And txtrn.Text = "" Then
                MsgBox("Please Input Reference Number!", vbOKOnly + vbInformation, "Payment")
                txtrn.Focus()
            ElseIf cbopayment.Text = "Gcash" And txtamount.Text = "" Then
                MsgBox("Please Input Amount!", vbOKOnly + vbInformation, "Payment")
                txtamount.Focus()
            ElseIf cbopayment.Text = "Paymaya" And txtpd.Text = "" Then
                MsgBox("Please Input Mobile Number!", vbOKOnly + vbInformation, "Payment")
                txtpd.Focus()
            ElseIf cbopayment.Text = "Paymaya" And txtrn.Text = "" Then
                MsgBox("Please Input Reference Number!", vbOKOnly + vbInformation, "Payment")
                txtrn.Focus()
            ElseIf cbopayment.Text = "Paymaya" And txtamount.Text = "" Then
                MsgBox("Please Input Amount!", vbOKOnly + vbInformation, "Payment")
                txtamount.Focus()
            ElseIf cbopayment.Text = "Cheque" And txtpd.Text = "" Then
                MsgBox("Please Input Cheque Information!", vbOKOnly + vbInformation, "Payment")
                txtpd.Focus()
            ElseIf cbopayment.Text = "Cheque" And txtrn.Text = "" Then
                MsgBox("Please Input Cheque Amount!", vbOKOnly + vbInformation, "Payment")
                txtpd.Focus()
            ElseIf cbopayment.Text = "Cash" And txtamount.Text = "" Then
                MsgBox("Please Input Amount!", vbOKOnly + vbInformation, "Payment")
                txtamount.Focus()
            Else
                Dim cmd As Odbc.OdbcCommand
                Dim sql As String
                sql = "INSERT INTO payment(paymenttype, paymentdetails, Amount, clientid, transno, referenceno) values (?,?,?,?,?,?)"
                cmd = New Odbc.OdbcCommand(sql, con)
                With cmd
                    .Parameters.AddWithValue("?", cbopayment.SelectedValue)
                    .Parameters.AddWithValue("?", txtpd.Text)
                    .Parameters.AddWithValue("?", txtamount.Text)
                    .Parameters.AddWithValue("?", frmPOS.lblid.Text)
                    .Parameters.AddWithValue("?", frmPOS.lbltrans.Text)
                    .Parameters.AddWithValue("?", txtrn.Text)
                    cmd.ExecuteNonQuery()
                    Call loadData("select * from vw_payment WHERE transno='" & frmPOS.lbltrans.Text & "' AND status=0", dgv)
                End With
                txtamount.Text = ""
                txtpd.Text = ""
                txtrn.Text = ""
                computeChange()
            End If
        End If
    End Sub
    Private Sub txtamount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtamount.KeyPress
        filternum(e.KeyChar)
    End Sub
    Private Sub lblta_TextChanged(sender As Object, e As EventArgs)
        computeChange()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        computeChange()
    End Sub

    Private Sub txtdiscount_KeyPress1(sender As Object, e As KeyPressEventArgs) Handles txtdiscount.KeyPress
        filternum(e.KeyChar)
        
    End Sub
    Private Sub txtdiscount_Leave1(sender As Object, e As EventArgs) Handles txtdiscount.Leave
        discount()
    End Sub
    Private Sub txtpd_Click(sender As Object, e As EventArgs) Handles txtpd.Click
        txtpd.Text = ""
    End Sub
    Private Sub txtrn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtrn.KeyPress
        filternum(e.KeyChar)
    End Sub

    Private Sub grppayment_Enter(sender As Object, e As EventArgs) Handles grppayment.Enter

    End Sub

    Private Sub txtdiscount_TextChanged(sender As Object, e As EventArgs) Handles txtdiscount.TextChanged
       
    End Sub

    Private Sub txtamount_TextChanged(sender As Object, e As EventArgs) Handles txtamount.TextChanged

    End Sub

    Private Sub btnEnter_KeyDown1(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtdiscount.Text = "" Or txtdiscount.Text = 0 Then
                MsgBox("Please Enter Discount!", vbExclamation, "Payment")
                txtdiscount.Clear()
                txtdiscount.Focus()
                Exit Sub
            ElseIf lblta.TextLength > 10 Then
                MsgBox("Invalid Amount!", vbExclamation, "Payment")
                txtamount.Clear()
                txtamount.Focus()
                Exit Sub
            ElseIf Val(lblta.Text) < Val(lblgt.Text) Then
                MsgBox("Invalid Amount!", vbExclamation, "Payment")
                txtamount.Clear()
                txtamount.Focus()
                Exit Sub
            Else
                If MsgBox("Are you sure want to Accept Payment?", vbInformation + vbYesNo, "Payment") = vbYes Then
                    Payment()
                    frmPOS.lblid.Text = "00000000"
                    frmPOS.lblcustname.Text = "-----------------"
                    frmPOS.lbllocation.Text = "-----------------"
                    frmPOS.lbltrans.Text = "0000000"
                    frmPOS.Show()
                    frmPOS.btnpayment.BackColor = Color.White
                End If
            End If
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Dispose()
            frmPOS.btnpayment.BackColor = Color.White
        End If
    End Sub

    Private Sub btnEnter_KeyDown(sender As Object, e As KeyEventArgs) Handles btnEnter.KeyDown

    End Sub

    Private Sub cbopayment_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbopayment.SelectedValueChanged
        txtamount.Text = ""
        txtpd.Text = ""
        If cbopayment.Text = "Cash" Then
            txtpd.Enabled = False
            txtrn.Enabled = False
            txtamount.Focus()
        ElseIf cbopayment.Text = "Gcash" Then
            txtpd.Enabled = True
            txtrn.Enabled = True
            txtpd.Text = Format("09##-###-####")
            txtpd.MaxLength = 11
            Dim amount As Double
            If lblta.Text = 0 Then
                amount = Val(lblgt.Text)
                txtamount.Text = amount
                txtamount.Focus()
            Else
                amount = Val(lblbalc.Text)
                txtamount.Text = amount
                txtamount.Focus()
            End If
            
        ElseIf cbopayment.Text = "Paymaya" Then
            txtpd.Enabled = True
            txtrn.Enabled = True
            txtpd.Text = Format("09##-###-####")
            txtpd.MaxLength = 11
            Dim amount As Double
            If lblta.Text = 0 Then
                amount = Val(lblgt.Text)
                txtamount.Text = amount
                txtamount.Focus()
            Else
                amount = Val(lblbalc.Text)
                txtamount.Text = amount
                txtamount.Focus()
            End If
        ElseIf cbopayment.Text = "Cheque" Then
            txtpd.Enabled = True
            txtrn.Enabled = False
            txtpd.MaxLength = 30
            Dim amount As Double
            If lblta.Text = 0 Then
                amount = Val(lblgt.Text)
                txtamount.Text = amount
                txtamount.Focus()
            Else
                amount = Val(lblbalc.Text)
                txtamount.Text = amount
                txtamount.Focus()
            End If
        End If
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub
End Class