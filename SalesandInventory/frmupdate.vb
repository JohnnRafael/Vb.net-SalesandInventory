Public Class frmupdate
    Public xtotal, xgrand, change, tot As Double
    Private transaction As New transaction
    Public totchange As Double
 
    Private Sub frmupdate_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadcombobox("SELECT paymentid, paymentname FROM paymenttype ORDER BY paymentid ASC", cbopayment, "paymentname", "paymentid")
        Call loadData("select * from vw_updatepaymenttttt WHERE transno='" & lbltransno.Text & "'AND status=0", dgv)
        Dim totDue As Double = lbltotalamount.Text
        lbltotalamount.Text = Format(totDue, "#,##0.00")
        ' Dim discount As Integer = lbldiscount.Text
        ' lbldiscount.Text = Format(discount, "#%")
        Dim delfee As Double = lbldelfee.Text
        lbldelfee.Text = Format(delfee, "#,##0.00")
        Dim currentbal As Double = lblcurrentbal.Text
        lblcurrentbal.Text = Format(currentbal, "#,##0.00")
        Dim amounttendered As Double = lblamountTendered.Text
        lblamountTendered.Text = Format(amounttendered, "#,##0.00")
        'lbltotalamount.Text = Format("#,##0.00")
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub cbopayment_Click(sender As Object, e As EventArgs) Handles cbopayment.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
            sql = "INSERT INTO updatepayment(paymenttype, paymentdetails, Amount, clientid, transno, referenceno) values (?,?,?,?,?,?)"
            cmd = New Odbc.OdbcCommand(sql, con)
            With cmd
                .Parameters.AddWithValue("?", cbopayment.SelectedValue)
                .Parameters.AddWithValue("?", txtpd.Text)
                .Parameters.AddWithValue("?", txtamount.Text)
                .Parameters.AddWithValue("?", lblid.Text)
                .Parameters.AddWithValue("?", lbltransno.Text)
                .Parameters.AddWithValue("?", txtrn.Text)
                cmd.ExecuteNonQuery()
                Call loadData("select * from vw_updatepaymenttttt WHERE transno='" & lbltransno.Text & "' AND status=0", dgv)
            End With
            txtamount.Text = ""
            txtpd.Text = ""
            txtrn.Text = ""
            ' current()
        End If
    End Sub
   

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub dgv_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs)

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If lblta.TextLength > 10 Then
            MsgBox("Amount Out of Ranged!", vbExclamation, "")
            txtamount.Clear()
            txtamount.Focus()
            Exit Sub
        ElseIf Val(lblta.Text) < Val(lblcb.Text) Then
            MsgBox("Amount Out of Ranged!", vbExclamation, "")
            txtamount.Clear()
            txtamount.Focus()
            Exit Sub
        Else
            If MsgBox("Are you sure want to Accept Payment?", vbInformation + vbYesNo, "") = vbYes Then
                save()

            End If
        End If
    End Sub
    Sub Payment()
        Dim str As String = "SELECT * FROM transaction_details2 WHERE transdetailsId=" & lbltransno.Text
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
                transaction.updatetransaction("UPDATE transaction_details2 SET (finalpayment = ?, change = ?)", 0)
                Me.Dispose()
                ' frmPOS.txttypeitemcode.Focus()
            End If

        Catch ex As Exception

        End Try
    End Sub
    Sub save()
        Dim cmd As Odbc.OdbcCommand
        Dim sql As String
        Dim datatable As New DataTable
       

        Call connect()
        If Val(btnSave.Tag) = 0 Then

            sql = "UPDATE transaction_details2 set finalpayment= ?, changes=? where transNo=" & frmupdatepayment50.dgv.Tag
            cmd = New Odbc.OdbcCommand(sql, con)
            With cmd

                .Parameters.AddWithValue("?", lblta.Text)
                .Parameters.AddWithValue("?", lblc.Text)
                .Parameters.AddWithValue("?", Val(btnSave.Tag))
                .ExecuteNonQuery()

            End With
            transaction.paymenttrans2("UPDATE updatepayment set status=? ", 0)
            transaction.paymenttrans2("UPDATE transaction_details2 set isPaid=? where transNo=" & frmupdatepayment50.dgv.Tag, 0)
            MsgBox("PAYMENT HAS BEEN UPDATED SUCCESSFULLY!", vbOKOnly + vbInformation, "Information")
            loadData("SELECT * from vw_updatepayment50 where isPaid = 0", frmupdatepayment50.dgv)
            Me.Dispose()


        End If
           

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
            ' ewallet = Val(txtewallet.Text)
            ' cheque = Val(txtcheque.Text)
            xtotal = cash
            xgrand = Replace(lblcurrentbal.Text, ",", "")
            If xgrand > xtotal Then
                lblchange.Text = "0.00"
                lblc.Text = "0.00"
            Else
                If xtotal >= Replace(lblcurrentbal.Text, ",", "") Then
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

    Private Sub lblta_TextChanged(sender As Object, e As EventArgs) Handles lblta.TextChanged
        computeChange()
    End Sub

    Private Sub dgv_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    Private Sub dgv_RowsAdded1(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgv.RowsAdded
        transaction.totalPriceupdate()
        computeChange()
        current()
    End Sub

    Private Sub txtamount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtamount.KeyPress
        filternum(e.KeyChar)
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
            xgrand = Replace(lblcurrentbal.Text, ",", "")
            balance = xgrand - cash
            lblchange.Text = Format(balance, "#,##0.00")
            lblbalc.Text = balance
        End If
    End Sub
    Private Sub cbopayment_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbopayment.SelectedValueChanged
        txtamount.Text = ""
        txtpd.Text = ""
        If cbopayment.Text = "Cash" Then
            txtpd.Enabled = False
            txtrn.Enabled = False
            txtamount.Focus()
        ElseIf cbopayment.Text = "Gcash" Then
            If lblta.Text = "" Or 0 Then
                txtpd.Enabled = True
                txtrn.Enabled = True
                txtpd.Text = Format("09##-###-####")
                txtpd.MaxLength = 11
                Dim amount As Double
                amount = Val(lblcb.Text)
                txtamount.Text = amount
                txtamount.Focus()
            Else
                txtpd.Enabled = True
                txtrn.Enabled = True
                txtpd.Text = Format("09##-###-####")
                txtpd.MaxLength = 11
                Dim amount As Double
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
            amount = Val(lblbalc.Text)
            txtamount.Text = amount
            txtamount.Focus()
        ElseIf cbopayment.Text = "Cheque" Then
            txtpd.Enabled = True
            txtrn.Enabled = False
            txtpd.MaxLength = 30
            Dim amount As Double
            amount = Val(lblbalc.Text)
            txtamount.Text = amount
            txtamount.Focus()
        End If
    End Sub

    Private Sub lbltransno_Click(sender As Object, e As EventArgs) Handles lbltransno.Click

    End Sub

    Private Sub lbltdate_Click(sender As Object, e As EventArgs) Handles lbltdate.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub cbopayment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbopayment.SelectedIndexChanged

    End Sub

    Private Sub txtpd_Click(sender As Object, e As EventArgs) Handles txtpd.Click
        txtpd.Clear()
    End Sub

    Private Sub txtpd_TextChanged(sender As Object, e As EventArgs) Handles txtpd.TextChanged

    End Sub
End Class