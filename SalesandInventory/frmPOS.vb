Public Class frmPOS
    Public stockID As Integer
    Public barcode1 As String
    Public qty As Integer
    Public totalprice As Double
    Public totStockId As Integer
    Public transId As Integer
    Public prodID As Integer
    Dim price As Double
    Dim item As String
    Dim datatable As New DataTable
    Private void As New void
    Private transaction As New transaction
    Public unitprice1 As Double
    Private Sub frmPOS_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Panel4.Focus()
        If lbllocation.Text = "Fully Paid" Then
            lbltrans.Text = DateTimePicker1.Text + getTransactionNo()
            lbltransid.Text = transaction.auto 'id in table transaction
            lblTransNo.Text = transaction.getTransactionNo
            lbltrans.Text = DateTimePicker1.Text + transaction.zero + transaction.auto ' OR number
        ElseIf lbllocation.Text = "50% Down Payment" Then
            lbltrans.Text = DateTimePicker1.Text + getTransactionNo2()
            lbltransid.Text = transaction.auto 'id in table transaction
            lblTransNo.Text = transaction.getTransactionNo2
            lbltrans.Text = DateTimePicker1.Text + transaction.zero + transaction.auto ' OR number
        End If
        loaddgvv("SELECT * FROM vwtransaction WHERE status=0", dgvItem)
    End Sub
    Private Sub frmPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Focus()
        Me.KeyPreview = True
        lbldate.Text = Format(Today, "yyyyMMdd")
        lblsubtotal.Text = Format(0.0, "#,##0.00")
        loaddgvv("SELECT * FROM vwtransaction WHERE status=0", dgvItem)
        postime.Enabled = True
        dgvItem.ClearSelection()
        If lbllocation.Text = "Fully Paid" Then
            lbltrans.Text = DateTimePicker1.Text + getTransactionNo()
            lbltransid.Text = transaction.auto 'id in table transaction
            lblTransNo.Text = transaction.getTransactionNo
            lbltrans.Text = DateTimePicker1.Text + transaction.zero + transaction.auto ' OR number
        ElseIf lbllocation.Text = "50% Down Payment" Then
            lbltrans.Text = DateTimePicker1.Text + getTransactionNo2()
            lbltransid.Text = transaction.auto 'id in table transaction
            lblTransNo.Text = transaction.getTransactionNo2
            lbltrans.Text = DateTimePicker1.Text + transaction.zero + transaction.auto ' OR number
        End If
    End Sub
    Private Sub fetchdata(ByVal sid As String)
        Call connect()
        Try
            Dim da As Odbc.OdbcDataAdapter
            Dim dt As New DataTable
            Dim sql As String = "select * from vwtransaction where transid=" & sid
            da = New Odbc.OdbcDataAdapter(sql, con)
            da.Fill(dt)
            lblid.Text = dt.Rows(0).Item(9).ToString
            lblcustname.Text = dt.Rows(0).Item(10).ToString
            lbllocation.Text = dt.Rows(0).Item(11).ToString
        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message)
        End Try
    End Sub
    Private Sub fetchdatas(ByVal sid As String)
        Call connect()
        Try
            Dim da As Odbc.OdbcDataAdapter
            Dim dt As New DataTable
            Dim sql As String = "select * from vwclients where iddetails=" & sid
            da = New Odbc.OdbcDataAdapter(sql, con)
            da.Fill(dt)
            lblcustname.Text = dt.Rows(0).Item(2).ToString
            lbllocation.Text = dt.Rows(0).Item(3).ToString
        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message)
        End Try
    End Sub
    Sub cancelTransaction()
        Call void.VoidTransaction()
        Me.dgvItem.ClearSelection()
        Me.dgvItem.Enabled = False
        loaddgvv("SELECT * FROM vwtransaction WHERE status=0", Me.dgvItem)
        lblsubtotal.Text = Format(0.0, "#,##0.00")
        Exit Sub
    End Sub
    Private Sub postime_Tick(sender As System.Object, e As System.EventArgs) Handles postime.Tick
        lblposdate.Text = Date.Now.ToString("MMMMMMMM-dd-yyyy|hh:mm:ss")
        Mainform.lblmaindt.Text = Date.Now.ToString("yyyy-MM-dd hh:mm:ss tt")
        Mainform.lblmaindt.Text = Date.Now.ToString("yyyy-MM-dd")
    End Sub
    Private Sub dgvItem_RowsAdded(sender As Object, e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgvItem.RowsAdded
        transaction.totalPrice()
    End Sub
    Private Sub dgvItem_RowStateChanged(sender As Object, e As System.Windows.Forms.DataGridViewRowStateChangedEventArgs) Handles dgvItem.RowStateChanged
        transaction.totalPrice()
        Dim items = 0
        For y = 0 To dgvItem.RowCount - 1
            Dim z As Integer = dgvItem.Rows.Count.ToString
            Dim qty = dgvItem.Item(5, y).Value
            Dim totalprice = dgvItem.Item(4, y).Value * qty
            dgvItem.Item(6, y).Value = totalprice
            items = z
        Next
        lblqtyitem.Text = items
    End Sub
    Private Sub btnpayment_Click(sender As Object, e As EventArgs) Handles btnpayment.Click
        If lbllocation.Text = "Fully Paid" Then
            btnpayment.BackColor = Color.Gray
            frmPOSfullypaid.ShowDialog()
        ElseIf lbllocation.Text = "50% Down Payment" Then
            btnpayment.BackColor = Color.Gray
            frmPOS50.ShowDialog()
        End If
    End Sub
    Private Sub btnpayment_KeyDown(sender As Object, e As KeyEventArgs) Handles btnpayment.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnvoiditem.BackColor = Color.Gray
            frmPOSfullypaid.ShowDialog()
            frmPOSfullypaid.txtdiscount.Focus()
        End If
    End Sub
    Private Sub frmPOS_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ''If lblcdut.Text = "Admin" Then
        ''    connect()
        ''    Dim str As String = "SELECT * FROM transaction_details WHERE transdetailsID=" & Me.lblTransNo.Text & ""
        ''    Dim da As New Odbc.OdbcDataAdapter(str, con)
        ''    Dim dat As New DataTable
        ''    da.Fill(dat)
        ''If dat.Rows.Count <> 0 Then
        'If e.KeyCode = Keys.F3 Then
        '    btnQty.BackColor = Color.Gray
        '    If dgvItem.RowCount = 0 Then
        '        MsgBox("No item", vbInformation, "")
        '        btnQty.BackColor = Color.AliceBlue
        '        Exit Sub
        '    Else
        '        btnQty.BackColor = Color.AliceBlue
        '        dgvItem.RowsDefaultCellStyle.SelectionBackColor = Color.Gray
        '        dgvItem.RowsDefaultCellStyle.SelectionForeColor = Color.Black
        '        dgvItem.Enabled = True
        '        dgvItem.Rows(0).Cells(0).Selected = True
        '        frmpqty.txtqty.Visible = True
        '        dgvItem.Select()
        '    End If
        '    If e.KeyCode = Keys.F4 Then
        '        btnvoiditem.BackColor = Color.Gold
        '        frmitemlookup.ShowDialog()
        '    End If
        'ElseIf e.KeyCode = Keys.F5 Then
        '    If dgvItem.RowCount = 0 Then
        '        MsgBox("No Item", vbInformation, "")
        '        btnitemlookup.BackColor = Color.AliceBlue
        '        Exit Sub
        '    Else
        '        If dgvItem.SelectedRows.Count = 1 Then
        '            dgvItem.RowsDefaultCellStyle.SelectionBackColor = Color.Gray
        '            dgvItem.RowsDefaultCellStyle.SelectionForeColor = Color.Black
        '            'frmpqty.Label2.Text = "Quantity"
        '            frmpqty.ShowDialog()
        '        Else
        '            MsgBox("Please Select Item first", vbInformation, "")
        '            btnitemlookup.BackColor = Color.AliceBlue
        '            Exit Sub
        '        End If
        '    End If
        'ElseIf e.KeyCode = Keys.F6 Then
        '    If dgvItem.SelectedRows.Count = 1 Then
        '        dgvItem.RowsDefaultCellStyle.SelectionBackColor = Color.Gray
        '        dgvItem.RowsDefaultCellStyle.SelectionForeColor = Color.Black
        '        frmvoidqty.ShowDialog()
        '    Else
        '        MsgBox("Please Select Item first to Void", vbInformation, "")
        '        btnvoidtrans.BackColor = Color.AliceBlue
        '        Exit Sub
        '    End If
        'ElseIf e.KeyCode = Keys.F7 Then
        '    If dgvItem.Rows.Count = 0 Then
        '        MsgBox("No Item to be Process", vbInformation)
        '        Exit Sub
        '    Else
        '        If MsgBox("Are you sure you want to cancel all this transaction?", vbQuestion + vbYesNo) = vbYes Then
        '            dgvItem.SelectAll()
        '            cancelTransaction()
        '        End If
        '    End If
        'ElseIf e.KeyCode = Keys.F8 Then
        '    If dgvItem.RowCount = 0 Then
        '        Me.Dispose()
        '    Else
        '        MsgBox("The Transaction are still running, Please Click F7 for Void transaction", vbInformation, "")
        '    End If
        'End If
       
    End Sub
    Sub enabler()
        btnpayment.Enabled = False
        ' btnclient.Enabled = False
        btnQty.Enabled = False
        btnvoiditem.Enabled = False
        btnitemlookup.Enabled = False
        pnlitem.Enabled = False
        btnvoidtrans.Enabled = False
        btnExit.Enabled = False
    End Sub
   Private Sub dgvItem_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles dgvItem.RowsRemoved
        Call transaction.totalPrice()
    End Sub
    Private Sub btnSelectitem_Click(sender As Object, e As EventArgs) Handles btnSelectitem.Click
        btnSelectitem.BackColor = Color.Gray
        If dgvItem.RowCount = 0 Then
            MsgBox("No item", vbInformation, "")
            btnSelectitem.BackColor = Color.White
            Exit Sub
        Else
            btnSelectitem.BackColor = Color.Gray
            dgvItem.RowsDefaultCellStyle.SelectionBackColor = Color.Gray
            dgvItem.RowsDefaultCellStyle.SelectionForeColor = Color.Black
            dgvItem.Enabled = True
            dgvItem.Rows(0).Cells(0).Selected = True
            frmpqty.txtqty.Visible = True
            dgvItem.Select()
            btnSelectitem.BackColor = Color.White
        End If
    End Sub

    Private Sub btnitemlookup_Click(sender As Object, e As EventArgs) Handles btnitemlookup.Click
        If lblid.Text = "---------" Or lblid.Text = "00000000" Then
            MsgBox("Please Create a New Transaction First")
        Else
            btnitemlookup.BackColor = Color.Gray
            frmitemlookup.ShowDialog()
            Exit Sub
        End If
    End Sub

    Private Sub btnQty_Click(sender As Object, e As EventArgs) Handles btnQty.Click
        If dgvItem.RowCount = 0 Then
            MsgBox("No Item", vbInformation, "")
            btnQty.BackColor = Color.White
            Exit Sub
        Else
            If dgvItem.SelectedRows.Count = 1 Then
                dgvItem.RowsDefaultCellStyle.SelectionBackColor = Color.Gray
                dgvItem.RowsDefaultCellStyle.SelectionForeColor = Color.Black
                frmpqty.ShowDialog()
            Else
                MsgBox("Please Select Item first", vbInformation, "")
                btnQty.BackColor = Color.Gray
                Exit Sub
                btnQty.BackColor = Color.White
            End If
        End If
    End Sub

    Private Sub btnvoiditem_Click(sender As Object, e As EventArgs) Handles btnvoiditem.Click
        If dgvItem.SelectedRows.Count = 1 Then
            dgvItem.RowsDefaultCellStyle.SelectionBackColor = Color.Gray
            dgvItem.RowsDefaultCellStyle.SelectionForeColor = Color.Black
            frmvoidqty.ShowDialog()
         Else
            MsgBox("Please Select Item first to Void", vbInformation, "Point of Sale")
            btnvoiditem.BackColor = Color.Gray

        End If
        btnvoiditem.BackColor = Color.White
    End Sub
    Private Sub btnvoidtrans_Click(sender As Object, e As EventArgs) Handles btnvoidtrans.Click
        If dgvItem.Rows.Count = 0 Then
            MsgBox("No Item to be Process", vbInformation)
            btnvoidtrans.BackColor = Color.Gray

        Else
            If MsgBox("Are you sure you want to cancel all this transaction?", vbQuestion + vbYesNo, "Point of Sale") = vbYes Then
                btnvoidtrans.BackColor = Color.Gray
                dgvItem.SelectAll()
                cancelTransaction()

            End If
            btnvoidtrans.BackColor = Color.White
        End If
        btnvoidtrans.BackColor = Color.White
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If dgvItem.RowCount = 0 Then
            Me.Close()
            frmLogin.Show()
            frmLogin.txtuser.Text = ""
            frmLogin.pword.Text = ""
        ElseIf dgvItem.RowCount = 0 And lblcdut.Text = "Admin" Then
            Me.Close()
            Mainform.Show()
        Else
            MsgBox("The Transaction are still running, Please Click F7 for Void transaction", vbInformation, "")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnnewtransact.Click
        frmclient.Show()
        Me.Refresh()
    End Sub

    Private Sub btnnewtransact_KeyDown1(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            frmclient.Show()
            Me.Refresh()
        ElseIf e.KeyCode = Keys.F2 Then
            If lbllocation.Text = "Fully Paid" Then
                btnpayment.BackColor = Color.Gray
                frmPOSfullypaid.ShowDialog()
            ElseIf lbllocation.Text = "50% Down Payment" Then
                btnpayment.BackColor = Color.Gray
                frmPOS50.ShowDialog()
            Else
                MsgBox("No Item Selected", vbInformation, "Point of Sale")
            End If
        ElseIf e.KeyCode = Keys.F3 Then
            btnSelectitem.BackColor = Color.Gray
            If dgvItem.RowCount = 0 Then
                MsgBox("No item", vbInformation, "Point of Sale")
                btnSelectitem.BackColor = Color.White
                Exit Sub
            Else
                btnSelectitem.BackColor = Color.Gray
                dgvItem.RowsDefaultCellStyle.SelectionBackColor = Color.Gray
                dgvItem.RowsDefaultCellStyle.SelectionForeColor = Color.Black
                dgvItem.Enabled = True
                dgvItem.Rows(0).Cells(0).Selected = True
                frmpqty.txtqty.Visible = True
                dgvItem.Select()
                btnSelectitem.BackColor = Color.White

            End If
        ElseIf e.KeyCode = Keys.F4 Then
            If lblid.Text = "---------" Or lblid.Text = "00000000" Then
                MsgBox("Please Create a New Transaction First")
            Else
                btnitemlookup.BackColor = Color.Gray
                frmitemlookup.ShowDialog()
                Exit Sub
            End If
        ElseIf e.KeyCode = Keys.F5 Then
            If dgvItem.RowCount = 0 Then
                MsgBox("No Item", vbInformation, "Point of Sale")
                btnQty.BackColor = Color.White
                Exit Sub
            Else
                If dgvItem.SelectedRows.Count = 1 Then
                    dgvItem.RowsDefaultCellStyle.SelectionBackColor = Color.Gray
                    dgvItem.RowsDefaultCellStyle.SelectionForeColor = Color.Black
                    frmpqty.ShowDialog()
                Else
                    MsgBox("Please Select Item first", vbInformation, "Point of Sale")
                    btnQty.BackColor = Color.Gray
                    Exit Sub
                    btnQty.BackColor = Color.White
                End If
            End If
        ElseIf e.KeyCode = Keys.F6 Then
            If dgvItem.SelectedRows.Count = 1 Then
                dgvItem.RowsDefaultCellStyle.SelectionBackColor = Color.Gray
                frmvoidqty.ShowDialog()
            Else
                MsgBox("Please Select Item first to Void", vbInformation, "Point of Sale")
                btnvoiditem.BackColor = Color.Gray
                btnvoiditem.BackColor = Color.White

            End If
            btnvoiditem.BackColor = Color.White
        ElseIf e.KeyCode = Keys.F7 Then
            If dgvItem.Rows.Count = 0 Then
                MsgBox("No item", vbInformation, "Point of Sale")
                btnvoidtrans.BackColor = Color.Gray

            Else
                If MsgBox("Are you sure you want to cancel all this transaction?", vbQuestion + vbYesNo, "Point of Sale") = vbYes Then
                    btnvoidtrans.BackColor = Color.Gray
                    dgvItem.SelectAll()
                    cancelTransaction()
                End If
                btnvoidtrans.BackColor = Color.White
            End If
            btnvoidtrans.BackColor = Color.White
        ElseIf e.KeyCode = Keys.F8 Then
            If dgvItem.RowCount = 0 Then
                Me.Close()
                frmLogin.Show()
                frmLogin.txtuser.Text = ""
                frmLogin.pword.Text = ""
            ElseIf dgvItem.RowCount = 0 And lblcdut.Text = "Admin" Then
                Me.Close()
                Mainform.Show()
            Else
                MsgBox("The Transaction are still running, Please Click F7 for Void transaction", vbInformation, "Point of Sale")
            End If
        End If

    End Sub
End Class