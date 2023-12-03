Public Class frmnewPO
    Private item_id As Integer
    Private sup_id As Integer
    Private cname As String
    Private itemC As String
    Private itemT As String
    Private descip As String
    Private price As Integer
    Private unitp As String
    Private qty As Integer
    Private Sub frmnewPO_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call connect()
        lblpo.Text = getpoID()
        lbldate.Text = Format(Today, "yyyy/MM/dd")
        lblyear.Text = Format(Today, "yyyy")
        lblponum.Text = lblyear.Text + "-" + getPONo()
        ' loadData("SELECT itemid,itemcode,itemtype,Description,Price,UnitP FROM vw_prod", dgvpoitem)
        gboxpo.Enabled = True
        btnRemove.Enabled = True
        btnSave.Enabled = True
        'txtSearch.Enabled = True
        ' txtSearch.Focus()
        dgvPO.Tag = ""
        btnSave.Enabled = False
        btnRemove.Enabled = False
        Call loadData("Select * from po_temp", dgvPO)
        loadcombobox("SELECT suppid, sup_cname FROM po_temp", cbosupplier, "sup_cname", "suppid")
        If dgvPO.RowCount = 0 Then
        Else
            btnSave.Enabled = True

        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If dgvPO.RowCount = 0 Then
            Me.Dispose()
            '  ElseIf Mainform.lblposition.Text = "Manager" Or Mainform.lblposition.Text = "Admin" Then
        Else
            MsgBox("The Purchasing Order are still running, Please Finish Purchasing Order First.", vbInformation, "")
        End If
    End Sub

    Private Sub cbosupplier_Click(sender As Object, e As EventArgs) Handles cbosupplier.Click
        loadcombobox("SELECT sup_id, sup_cname FROM supplier ORDER BY sup_id ASC", cbosupplier, "sup_cname", "sup_id")
      
        'loadcombobox2("SELECT sup_id, sup_cname FROM supplier ORDER BY sup_id ASC", lblsuppid, "sup_id", "sup_cname")
        'Call loadData("select from sup_item WHERE suppcname='" & cbosupplier.Text & "'", lblsuppid.Text)
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        If cbosupplier.Text = "" Then
            MsgBox("Please select a Supplier first", MsgBoxStyle.Information, "Information")
        Else
            btnSave.Enabled = True
            Call fetchdata(Val(cbosupplier.Tag))
        End If

    End Sub
    Private Sub fetchdata(ByVal sid As String)
        Try
            Dim da As Odbc.OdbcDataAdapter
            Dim dt As New DataTable
            Dim sql As String = "select * from vw_sup_item where suppid=" & sid
            da = New Odbc.OdbcDataAdapter(sql, con)
            da.Fill(dt)
            With frmnewposelectitem
                .lblid.Text = cbosupplier.Text
            End With
            frmnewposelectitem.ShowDialog()
        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message)
        End Try
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim cmd As Odbc.OdbcCommand
        Dim str As String = "DELETE FROM po_temp where poiddetailstemp=?"

        If Val(dgvPO.Tag) = 0 Then
            MsgBox("Select a record to Remove", vbCritical, "Information")
        Else
            If MsgBox("Do you want to remove the item?", MsgBoxStyle.Question + vbYesNo, "Remove") = vbYes Then
                Try
                    Call connect()
                    cmd = New Odbc.OdbcCommand(str, con)
                    cmd.Parameters.AddWithValue("@", Val(dgvPO.Tag))
                    cmd.ExecuteNonQuery()
                    Call loadData("select * from po_temp", dgvPO)

                    dgvPO.Tag = 0
                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                Finally
                    con.Close()
                    GC.Collect()
                End Try
            End If
        End If
    End Sub

    Private Sub dgvPO_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPO.CellClick
        If e.RowIndex >= 0 Then
            dgvPO.Tag = dgvPO.Item(0, e.RowIndex).Value
            sup_id = dgvPO.Item(1, e.RowIndex).Value
            cname = dgvPO.Item(2, e.RowIndex).Value
            item_id = dgvPO.Item(3, e.RowIndex).Value
            itemC = dgvPO.Item(4, e.RowIndex).Value
            itemT = dgvPO.Item(5, e.RowIndex).Value
            descip = dgvPO.Item(6, e.RowIndex).Value
            price = dgvPO.Item(7, e.RowIndex).Value
            qty = dgvPO.Item(8, e.RowIndex).Value
            lbliddddd.Text = dgvPO.Tag
            lblsupid.Text = sup_id
            lblcname.Text = cname
            lblitemid.Text = item_id
            lblitemcode.Text = itemC
            lblitemtype.Text = itemT
            lbldesc.Text = descip
            lblprice.Text = price
            lblqty.Text = qty
            btnRemove.Enabled = True
            lblid.Text = dgvPO.Tag
        Else
            MsgBox("NO RECORD SELECTED!")
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim cmd As Odbc.OdbcCommand
        Dim str As String = "DELETE FROM po_temp WHERE status=1"
        Dim addqty As Integer
        Dim dp As Date = Format(Date.Now, "yyyy-MM-dd")
        Dim dateVal As Integer = DateDiff(DateInterval.Day, dp, dtdate.Value)
        If dgvPO.RowCount = 0 Then
            MsgBox("Please complete the information", vbInformation, "")
            Exit Sub
        Else
            If dateVal < 0 Then
                MsgBox("Please Select a Date", vbCritical)
                dtdate.Focus()
            ElseIf cbosupplier.Text = "" Then
                MsgBox("Please Select a Supplier", vbCritical)
                cbosupplier.Focus()
            Else
                If MsgBox("Are you sure want to Purchase an Order?", vbInformation + vbYesNo, "Purchase Order") = vbYes Then

                    Dim length As Integer = dgvPO.RowCount
                    For i = 0 To length - 1
                        item_id = dgvPO.Item(3, i).Value
                        qty = dgvPO.Item(8, i).Value
                        Dim ponumber As Long = lblpo.Text
                        ModPO.savePO(item_id, qty, ponumber)
                        addqty = dgvPO.Rows.Count.ToString
                    Next
                    ModPO.savePODetails(lblponum.Text, cbosupplier.SelectedValue, addqty, Format(dtdate.Value, "yyyy-MM-dd"), lbldate.Text, cboorder.SelectedValue)
                    Call connect()
                    cmd = New Odbc.OdbcCommand(str, con)
                    'cmd.Parameters.AddWithValue("@", Val(Label5.Text))
                    cmd.ExecuteNonQuery()
                    loadData("SELECT porder_bodyid,ponum,numberofitem,sup_cname,expecdate,statid,status FROM vw_polistt ORDER BY ponum DESC", frmorder.dgvPO)
                    Me.Dispose()
                End If
            End If
        End If
    End Sub
    Private Sub cboorder_Click(sender As Object, e As EventArgs) Handles cboorder.Click
        Call connect()
        loadcombobox("SELECT empID, CONCAT(lname, ', ', fname,' ',mname) EmployeeName FROM employee", cboorder, "EmployeeName", "empID")
    End Sub

    Private Sub cbosupplier_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbosupplier.SelectedValueChanged
       
        'loadcombobox("SELECT sup_id, sup_cname FROM supplier where sup_cname=" & cbosupplier.Text & "'", cbosupid, "sup_id", "sup_cname")
    End Sub

    Private Sub gboxpo_Enter(sender As Object, e As EventArgs) Handles gboxpo.Enter

    End Sub

    Private Sub cboorder_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboorder.SelectedIndexChanged

    End Sub

    Private Sub dtdate_ValueChanged(sender As Object, e As EventArgs) Handles dtdate.ValueChanged

    End Sub

    Private Sub cbosupplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbosupplier.SelectedIndexChanged
       
    End Sub

    Private Sub cbosupplier_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbosupplier.SelectionChangeCommitted
       
    End Sub
End Class