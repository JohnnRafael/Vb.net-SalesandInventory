Public Class frmReceived
    Public item_id As Integer
    Public porder_id As Integer
    Public qty As Integer
    Public itemcode As String
    Public itemtype As String
    Public desc As String
    Public price As Double
    Private Sub frmReceiving_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connect()
        loadcombobox("SELECT porder_bodyid, ponum FROM vw_polistt WHERE statid=1 ORDER BY ponum DESC", cboPOno, "ponum", "porder_bodyid")
        loadcombobox("SELECT empID, CONCAT(lname, ', ', fname,' ',mname) EmployeeName FROM employee", cboReceivedby, "EmployeeName", "empID")
        'lbldate.Text = Format(Today, "yyyy-MM-dd")
        datee.Text = Format(Today, "yyyy/MM/dd")
        dtdate.Enabled = False
        cboReceivedBy.Enabled = False
    End Sub

    Private Sub txtdelivery_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdelivery.KeyPress
        filternum(e.KeyChar)
    End Sub
    Private Sub txtdelivery_TextChanged(sender As Object, e As EventArgs) Handles txtdelivery.TextChanged
        If txtdelivery.Text = "" Then
            dtdate.Enabled = False
            cboReceivedby.Enabled = False
            cboPOno.Enabled = False
        Else
            dtdate.Enabled = True
            cboReceivedby.Enabled = True
            cboPOno.Enabled = True
        End If
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim cmd As Odbc.OdbcCommand
        Dim adapt As Odbc.OdbcDataAdapter
        Dim dt As New DataTable
        cmd = New Odbc.OdbcCommand("SELECT ruID, drID FROM receiveddetails WHERE drID=?", con)
        cmd.Parameters.AddWithValue("?", Val(txtdelivery.Text))
        adapt = New Odbc.OdbcDataAdapter(cmd)
        adapt.Fill(dt)
        Dim numqty As Integer
        Try
            If txtdelivery.Text = "" Or dgvRitem.RowCount = 0 Then
                MsgBox("Deliver Number Required", vbInformation, "")
            ElseIf cboReceivedby.Text = "" Then
                MsgBox("Recevieved By Required!", vbInformation, "")
            ElseIf dgvRitem.RowCount = 0 Then
                MsgBox("No P.O Number Selected!", vbInformation, "")
                'ElseIf lbldater.Text > lbldate.Text Then
                '    If MsgBox("The received is Late than the expected date (" & lbldate.Text & "), Are you sure want to Received Order?", vbInformation + vbYesNo, "Date") = vbNo Then
                '        dtdate.Focus()
                '        lbldater.Text = ""
                '    Else
                '        If dt.Rows.Count >= 1 Then
                '            MsgBox("Delivery Number is already exist.", vbInformation, "")
                '            txtdelivery.Text = ""
                '            txtdelivery.Focus()
                '            Exit Sub
                '        Else
                '            If dt.Rows.Count >= 1 Then
                '                MsgBox("Delivery Number is already exist.", vbInformation, "")
                '                txtdelivery.Text = ""
                '                Exit Sub
                '            Else
                '                Dim length As Integer = dgvRitem.RowCount
                '                For x = 0 To length - 1
                '                    item_id = dgvRitem.Item(0, x).Value
                '                    qty = dgvRitem.Item(6, x).Value
                '                    numqty = dgvRitem.Rows.Count.ToString
                '                    'save to tblreceiveddetails
                '                    Dim com As New Odbc.OdbcCommand("INSERT INTO receiveddetails(drID,itemid,quantity,dateDelivered,sup_id,ponum) VALUES (?,?,?,?,?,?)", con)
                '                    com.Parameters.AddWithValue("?", Val(txtdelivery.Text))
                '                    com.Parameters.AddWithValue("?", item_id)
                '                    com.Parameters.AddWithValue("?", qty)
                '                    com.Parameters.AddWithValue("", dtdate.Value)
                '                    com.Parameters.AddWithValue("", Val(lblsupplier.Text))
                '                    com.Parameters.AddWithValue("", lblpo.Text)
                '                    com.ExecuteNonQuery()
                '                    'add stock to inventory
                '                    Dim com1 As Odbc.OdbcCommand
                '                    com1 = New Odbc.OdbcCommand("UPDATE stocks SET quantity=quantity+? WHERE itemid=" & item_id, con)
                '                    com1.Parameters.AddWithValue("?", Val(qty))
                '                    com1.ExecuteNonQuery()
                '                    'update status in po
                '                    Dim com2 As Odbc.OdbcCommand
                '                    com2 = New Odbc.OdbcCommand("UPDATE porder_details SET statid=?, numberofitem=? WHERE porder_bodyid=" & cboPOno.SelectedValue, con)
                '                    com2.Parameters.AddWithValue("?", 2)
                '                    com2.Parameters.AddWithValue("?", numqty)
                '                    com2.ExecuteNonQuery()
                '                    loadData("SELECT stockid, itemcode, itemtype, Description, Price, UnitP,quantity FROM vw_inv ORDER BY stockid DESC", frmInventory.dgv)
                '                Next
                '                'save to tblreceived
                '                Dim com3 As Odbc.OdbcCommand
                '                com3 = New Odbc.OdbcCommand("INSERT INTO received(sup_id,date_received,numberofitem,receiveBy) VALUES (?,?,?,?)", con)
                '                com3.Parameters.AddWithValue("?", lblsupplier.Text)
                '                com3.Parameters.AddWithValue("?", dtdate.Value)
                '                com3.Parameters.AddWithValue("?", numqty)
                '                com3.Parameters.AddWithValue("?", cboReceivedby.SelectedValue)
                '                com3.ExecuteNonQuery()
                '                MsgBox("Received products already saved.", vbInformation, "")
                '                Me.Dispose()
                '            End If
                '        End If
                '    End If
            ElseIf lbldater.Text < lbldate.Text Then
                If MsgBox("The received is earlier than the expected date (" & lbldate.Text & ") , Are you sure want to Received Order?", vbInformation + vbYesNo, "Date") = vbNo Then
                    dtdate.Focus()
                Else
                    If dt.Rows.Count >= 1 Then
                        MsgBox("Delivery Number is already exist.", vbInformation, "")
                        txtdelivery.Text = ""
                        Exit Sub
                    Else
                        Dim length As Integer = dgvRitem.RowCount
                        For x = 0 To length - 1
                            item_id = dgvRitem.Item(0, x).Value
                            qty = dgvRitem.Item(6, x).Value
                            numqty = dgvRitem.Rows.Count.ToString
                            'save to tblreceiveddetails
                            Dim com As New Odbc.OdbcCommand("INSERT INTO receiveddetails(drID,itemid,quantity,dateDelivered,sup_id,ponum) VALUES (?,?,?,?,?,?)", con)
                            com.Parameters.AddWithValue("?", Val(txtdelivery.Text))
                            com.Parameters.AddWithValue("?", item_id)
                            com.Parameters.AddWithValue("?", qty)
                            com.Parameters.AddWithValue("", dtdate.Value)
                            com.Parameters.AddWithValue("", Val(lblsupplier.Text))
                            com.Parameters.AddWithValue("", lblpo.Text)
                            com.ExecuteNonQuery()
                            'add stock to inventory
                            Dim com1 As Odbc.OdbcCommand
                            com1 = New Odbc.OdbcCommand("UPDATE stocks SET quantity=quantity+? WHERE itemid=" & item_id, con)
                            com1.Parameters.AddWithValue("?", Val(qty))
                            com1.ExecuteNonQuery()
                            'update status in po
                            Dim com2 As Odbc.OdbcCommand
                            com2 = New Odbc.OdbcCommand("UPDATE porder_details SET statid=?, numberofitem=? WHERE porder_bodyid=" & cboPOno.SelectedValue, con)
                            com2.Parameters.AddWithValue("?", 2)
                            com2.Parameters.AddWithValue("?", numqty)
                            com2.ExecuteNonQuery()
                            loadData("SELECT stockid, itemcode, itemtype, Description, Price, UnitP,quantity FROM vw_inv ORDER BY stockid DESC", frmInventory.dgv)
                        Next
                        'save to tblreceived
                        Dim com3 As Odbc.OdbcCommand
                        com3 = New Odbc.OdbcCommand("INSERT INTO received(sup_id,date_received,numberofitem,receiveBy) VALUES (?,?,?,?)", con)
                        com3.Parameters.AddWithValue("?", lblsupplier.Text)
                        com3.Parameters.AddWithValue("?", dtdate.Value)
                        com3.Parameters.AddWithValue("?", numqty)
                        com3.Parameters.AddWithValue("?", cboReceivedby.SelectedValue)
                        com3.ExecuteNonQuery()
                        MsgBox("Received products already saved.", vbInformation, "")
                        Me.Dispose()
                    End If
                End If
            Else
                If dt.Rows.Count >= 1 Then
                    MsgBox("Delivery Number is already exist.", vbInformation, "")
                    txtdelivery.Text = ""
                    Exit Sub
                Else
                    If MsgBox("Are you sure want to Received Order?", vbInformation + vbYesNo, "") = vbYes Then
                        Dim length As Integer = dgvRitem.RowCount
                        For x = 0 To length - 1
                            item_id = dgvRitem.Item(0, x).Value
                            qty = dgvRitem.Item(6, x).Value
                            numqty = dgvRitem.Rows.Count.ToString
                            'save to tblreceiveddetails
                            Dim com As New Odbc.OdbcCommand("INSERT INTO receiveddetails(drID,itemid,quantity,dateDelivered,sup_id,ponum) VALUES (?,?,?,?,?,?)", con)
                            com.Parameters.AddWithValue("?", Val(txtdelivery.Text))
                            com.Parameters.AddWithValue("?", item_id)
                            com.Parameters.AddWithValue("?", qty)
                            com.Parameters.AddWithValue("", dtdate.Value)
                            com.Parameters.AddWithValue("", Val(lblsupplier.Text))
                            com.Parameters.AddWithValue("", lblpo.Text)
                            com.ExecuteNonQuery()
                            'add stock to inventory
                            Dim com1 As Odbc.OdbcCommand
                            com1 = New Odbc.OdbcCommand("UPDATE stocks SET quantity=quantity+? WHERE itemid=" & item_id, con)
                            com1.Parameters.AddWithValue("?", Val(qty))
                            com1.ExecuteNonQuery()
                            'update status in po
                            Dim com2 As Odbc.OdbcCommand
                            com2 = New Odbc.OdbcCommand("UPDATE porder_details SET statid=?, numberofitem=? WHERE porder_bodyid=" & cboPOno.SelectedValue, con)
                            com2.Parameters.AddWithValue("?", 2)
                            com2.Parameters.AddWithValue("?", numqty)
                            com2.ExecuteNonQuery()
                            loadData("SELECT stockid, itemcode, itemtype, Description, Price, UnitP,quantity FROM vw_inv ORDER BY stockid DESC", frmInventory.dgv)
                        Next
                        'save to tblreceived
                        Dim com3 As Odbc.OdbcCommand
                        com3 = New Odbc.OdbcCommand("INSERT INTO received(sup_id,date_received,numberofitem,receiveBy) VALUES (?,?,?,?)", con)
                        com3.Parameters.AddWithValue("?", lblsupplier.Text)
                        com3.Parameters.AddWithValue("?", dtdate.Value)
                        com3.Parameters.AddWithValue("?", numqty)
                        com3.Parameters.AddWithValue("?", cboReceivedby.SelectedValue)
                        com3.ExecuteNonQuery()
                        MsgBox("Received products already saved.", vbInformation, "")
                        Me.Dispose()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cboPOno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPOno.SelectedIndexChanged
        Try
            connect()
            loadData("SELECT itemid,itemcode,itemtype,Description,Price,unitP,quantity,Total, sup_cname, porderid FROM vw_po WHERE porder_bodyid='" & Trim(cboPOno.SelectedValue.ToString) & "'", dgvRitem)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MsgBox("Are you sure want to close?", vbInformation + vbYesNo, "") = vbYes Then
            Me.Dispose()
        End If
    End Sub
    Private Sub fetchdata(ByVal sid As String)
        Try
            Dim da As Odbc.OdbcDataAdapter
            Dim dt As New DataTable
            Dim sql As String = "select * from vw_po where porderid=" & sid
            da = New Odbc.OdbcDataAdapter(sql, con)
            da.Fill(dt)
            lblsupplier.Text = dt.Rows(0).Item(10).ToString
        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message)
        End Try
    End Sub
    Private Sub dgvRitem_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRitem.CellClick
        If e.RowIndex >= 0 Then
            dgvRitem.Tag = dgvRitem.Item(0, e.RowIndex).Value
            qty = dgvRitem.Item(5, e.RowIndex).Value
            Call fetchdata(dgvRitem.Tag)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmreceivedpono.Show()
    End Sub
    Private Sub dtdate_ValueChanged(sender As Object, e As EventArgs) Handles dtdate.ValueChanged
        lbldater.Text = dtdate.Text
    End Sub
End Class