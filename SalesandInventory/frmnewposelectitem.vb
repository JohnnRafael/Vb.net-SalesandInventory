Public Class frmnewposelectitem
    Private item_id As Integer
    Private supid As Integer
    Private cname As String
    Private itemC As String
    Private itemT As String
    Private descip As String
    Private price As Integer
    Private unitp As String
    Private qty As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim cmd2 As Odbc.OdbcCommand
        Dim adapt As Odbc.OdbcDataAdapter
        Dim datatable As New DataTable
        cmd2 = New Odbc.OdbcCommand("SELECT itemcode FROM po_temp WHERE itemcode=? ", con)
        With cmd2.Parameters
            .AddWithValue("@itemcode", Trim(lblitemcode.Text))
            '.AddWithValue("@itemtype", Trim(cboitemtype.SelectedText))
        End With
        adapt = New Odbc.OdbcDataAdapter(cmd2)
        adapt.Fill(datatable)
        If lblitemcode.Text = "itemcode" Or lblitemtype.Text = "itemtype" Or txtquantity.Text = "" Then
            MsgBox("Please Select an item!", vbOKOnly + vbInformation, "Missing")
        ElseIf txtquantity.Text = "" Or txtquantity.Text = 0 Then
            MsgBox("Please Input Quantity!", vbOKOnly + vbInformation, "Missing")
            txtquantity.Focus()
        Else
            Try
                Call connect()
                If Val(btnadd.Tag) = 0 Then
                    If datatable.Rows.Count = 1 Then
                        MsgBox("This product is already existed.", vbInformation, "Information")
                        Exit Sub
                    Else
                        Dim cmd As Odbc.OdbcCommand
                        Dim sql As String
                        sql = "INSERT INTO po_temp(suppid, sup_cname, itemid, itemcode, itemtype, description, price, qty, ordernum) VALUES (?,?,?,?,?,?,?,?,?)"
                        cmd = New Odbc.OdbcCommand(sql, con)
                        With cmd
                            .Parameters.AddWithValue("?", lblsupid.Text)
                            .Parameters.AddWithValue("?", lblcname.Text)
                            .Parameters.AddWithValue("?", lblitemid.Text)
                            .Parameters.AddWithValue("?", lblitemcode.Text)
                            .Parameters.AddWithValue("?", lblitemtype.Text)
                            .Parameters.AddWithValue("?", lbldesc.Text)
                            .Parameters.AddWithValue("?", lblprice.Text)
                            .Parameters.AddWithValue("?", txtquantity.Text)
                            .Parameters.AddWithValue("?", frmnewPO.lblponum.Text)
                            cmd.ExecuteNonQuery()
                            Call loadData("select * from po_temp", frmnewPO.dgvPO)
                        End With
                        MsgBox("NEW ITEM HAS BEEN ADDED SUCCESSFULLY!", vbOKOnly + vbInformation, "Information")
                        frmnewPO.btnSave.Enabled = True
                        frmnewPO.btnRemove.Enabled = True
                        Me.dgv.Tag = ""
                        Me.Dispose()
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub frmnewposelectitem_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call loadData("select * from vw_sup_item2 WHERE sup_cname='" & lblid.Text & "'", dgv)
        dgv.Tag = ""
    End Sub

    Private Sub dgv_CellClick1(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        If e.RowIndex >= 0 Then
            dgv.Tag = dgv.Item(0, e.RowIndex).Value
            cname = dgv.Item(1, e.RowIndex).Value
            item_id = dgv.Item(2, e.RowIndex).Value
            itemC = dgv.Item(3, e.RowIndex).Value
            itemT = dgv.Item(4, e.RowIndex).Value
            descip = dgv.Item(5, e.RowIndex).Value
            price = dgv.Item(6, e.RowIndex).Value
            lblsupid.Text = dgv.Tag
            lblcname.Text = cname
            lblitemid.Text = item_id
            lblitemcode.Text = itemC
            lblitemtype.Text = itemT
            lbldesc.Text = descip
            lblprice.Text = price
            txtquantity.Text = "1"
            txtquantity.Enabled = True
            txtquantity.Focus()
        End If
    End Sub
    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Call connect()
        Call loadData("select * from vw_prod where itemCode like '%" & Trim(txtsearch.Text) & "%' ", dgv)
        If cbosearch.Text = "ItemCode" Then
            Call loadData("select * from  vw_prod where itemCode like '%" & Trim(txtsearch.Text) & "%' ", dgv)
        ElseIf cbosearch.Text = "ItemType" Then
            Call loadData("select * from  vw_prod where ItemType like '%" & Trim(txtsearch.Text) & "%' ", dgv)
        ElseIf cbosearch.Text = "Description" Then
            Call loadData("select * from  vw_prod where Description like '%" & Trim(txtsearch.Text) & "%' ", dgv)
        End If
    End Sub
    Private Sub txtquantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtquantity.KeyPress
        filternum(e.KeyChar)
    End Sub
End Class