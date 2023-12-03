Imports System.Data
Imports System
Public Class frmitemlookup
    Private itemcode As String
    Private itemtype As String
    Private description As String
    Private unitpp As Double
    Private unitprice As Double
    Private transaction As New transaction

    Private Sub frmitemlookup_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'Call connect()
        'loadData("SELECT stockid, itemid, itemcode, itemtype, UnitP FROM vw_item Where quantity >= 1", dgv)
    End Sub

    Private Sub frmitemlookup_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Call connect()
        loadData("SELECT stockid, itemcode, itemtype, Description ,Price, UnitP FROM vw_inv where quantity >= 1", dgv)
        lblid.Text = frmPOS.lblid.Text
        lbltrans.Text = frmPOS.lbltrans.Text
        lblcustname.Text = frmPOS.lblcustname.Text
        lblpmethod.Text = frmPOS.lbllocation.Text
    End Sub
    
    Private Sub btnconfirm_Click(sender As Object, e As EventArgs) Handles btnqty.Click
        Try
          
            If Val(dgv.Tag) = 0 Then
                MsgBox("Please select a record", vbInformation)
                Exit Sub
                ' ElseIf txtqty.Text Then

            Else


                For y = 0 To frmPOS.dgvItem.RowCount - 1
                    If dgv.Tag = frmPOS.dgvItem.Item(0, y).Value Then
                        MsgBox("Item already Added", vbInformation)
                        'Dim cmd2 As New Odbc.OdbcCommand("UPDATE temp_transaction SET qty=?", con)
                        'Dim j As Integer = frmPOS.dgvItem.Item(5, y).Value
                        'cmd2.Parameters.AddWithValue("?", frmPOS.dgvItem.Item(5, y).Value = j + Val(lbl1.Text))


                        ''Dim t As Integer = frmPOS.dgvItem.Item(5, y).Value

                        ''frmPOS.dgvItem.Item(6, y).Value = t + Val(frmPOS.qty * frmPOS.totalprice)
                        'loaddgvv("SELECT * FROM vwtransaction WHERE status=0", frmPOS.dgvItem)
                        'MsgBox("Added Quantity Successfully", vbInformation)
                        'Me.Dispose()
                        'frmPOS.dgvItem.Rows(y).Selected = True
                        Exit Sub
                        Exit For
                    End If
                Next
                'frmRecevingItem.dgvRitem.Rows.Add(Me.dgvRec.Item(0, Me.dgvRec.CurrentRow.Index).Value, brandName, item_desc, categoryName, unitype1, unitprice1, txtqty.Text, Val(txtqty.Text * unitprice1))
                Dim cmd As New Odbc.OdbcCommand("INSERT INTO temp_transaction(totalstockid,qty,totalprice,ornum,clientid)VALUES(?,?,?,?,?)", con)
                cmd.Parameters.AddWithValue("?", dgv.Tag)
                cmd.Parameters.AddWithValue("?", Val(lbl1.Text))
                cmd.Parameters.AddWithValue("?", frmPOS.totalprice)
                cmd.Parameters.AddWithValue("?", Val(lbltrans.Text))
                cmd.Parameters.AddWithValue("?", Val(lblid.Text))
                'cmd.Parameters.AddWithValue("?", Val(lblcustname.Text))
                'cmd.Parameters.AddWithValue("?", Val(lblpmethod.Text))
                cmd.ExecuteNonQuery()
                loaddgvv("SELECT * FROM vwtransaction WHERE status=0", frmPOS.dgvItem)
                MsgBox("Added Quantity Successfully", vbInformation)
                frmPOS.lbltransid.Text = transaction.getTransId
                frmPOS.btnitemlookup.BackColor = Color.White
                Me.Dispose()

            End If
        Catch ex As Exception
            MsgBox("Error adding item", vbInformation)
        End Try
    End Sub

    Private Sub txtqty_KeyPress(sender As Object, e As KeyPressEventArgs)
        filternum(e.KeyChar)
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub txtqty_TextChanged(sender As Object, e As EventArgs)

    End Sub

   

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Call connect()
        If cbosearch2.Text = "ItemCode" Then
            Call loadData("SELECT stockid, itemcode, itemtype, Description ,Price, UnitP FROM vw_inv where quantity >= 1 AND itemCode like '%" & Trim(txtsearch.Text) & "%' ", dgv)
        ElseIf cbosearch2.Text = "ItemType" Then
            Call loadData("SELECT stockid, itemcode, itemtype, Description ,Price, UnitP FROM vw_inv where quantity >= 1 AND Itemtype like '%" & Trim(txtsearch.Text) & "%' ", dgv)
        ElseIf cbosearch2.Text = "Description" Then
            Call loadData("SELECT stockid, itemcode, itemtype, Description ,Price, UnitP FROM vw_inv where quantity >= 1 AND Desription like '%" & Trim(txtsearch.Text) & "%' ", dgv)
        ElseIf cbosearch2.Text = "" Then
            'loadData("SELECT stockid,itemcode,itemtype,description,price,UnitP,quantity,Total FROM vw_inventory ORDER BY quantity", dgv)
        End If
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        frmPOS.btnitemlookup.BackColor = Color.White
        dgv.Tag = ""
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub cbosearch2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbosearch2.SelectedIndexChanged

    End Sub

    Private Sub dgv_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)
       
    End Sub

    Private Sub dgv_CellClick1(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        If e.RowIndex >= 0 Then
            dgv.Tag = dgv.Item(0, e.RowIndex).Value
            itemcode = dgv.Item(1, e.RowIndex).Value
            itemtype = dgv.Item(2, e.RowIndex).Value
            description = dgv.Item(3, e.RowIndex).Value
            unitpp = dgv.Item(4, e.RowIndex).Value
            unitprice = dgv.Item(5, e.RowIndex).Value
        End If
    End Sub

    Private Sub dgv_CellContentClick_2(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub
End Class