Public Class frmreturnitemdetails
    Dim trans As New transaction
    Private Sub frmreturnitemdetails_Load(sender As Object, e As EventArgs) Handles Me.Load
        cboreason.Focus()
        lbldate.Text = Format(Today, "yyyy/MM/dd")
        Dim price As Double
        price = Val(lblprice.Text)
        lblprice.Text = Format(price, "##,##0.00")
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub txtqty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtqty.KeyPress
        filternum(e.KeyChar)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Dim cmd2 As Odbc.OdbcCommand
        'Dim adapt As Odbc.OdbcDataAdapter
        'Dim datatable As New DataTable
        'cmd2 = New Odbc.OdbcCommand("SELECT drID FROM return WHERE drID=?", con)
        'With cmd2.Parameters
        '    .AddWithValue("@drID", Trim(txtqty.Text))
        'End With
        'adapt = New Odbc.OdbcDataAdapter(cmd2)
        'adapt.Fill(datatable)
        'connect()
        Dim da As New Odbc.OdbcDataAdapter("SELECT * FROM vw_inv WHERE stockid =" & Val(lblitemid.Text), con)
        Dim dt As New DataTable
        da.Fill(dt)
        ' Dim quantity As Integer = frmreturnitem.dgv.Item(9, frmreturnitem.dgv.CurrentRow.Index).Value
        Dim stocks As Integer = dt.Rows(0)(6) '- quantity
        If txtqty.Text = "" Or txtqty.Text = 0 Then
            MsgBox("Please Input Quantity!", vbOKOnly + vbInformation, "Missing")
            txtqty.Focus()
        ElseIf cboreason.Text = "" Or cboreason.Text = "---Select Reason---" Then
            MsgBox("Please Select a Reason!", vbOKOnly + vbInformation, "Missing")
            cboreason.Focus()
        ElseIf txtqty.Text > Val(lblqty.Text) Then
            MsgBox("Please Enter Right Quantity!", vbOKOnly + vbInformation, "Missing")
            txtqty.Focus()
            txtqty.Clear()
        ElseIf Val(txtqty.Text) > stocks Then
            MsgBox("Insufficient Stocks! The remaining stocks is only'" & Val(dt.Rows(0)(6)) & "'", vbCritical, "")
            txtqty.Text = ""
            txtqty.Focus()
            Exit Sub
        Else
           
            If MsgBox("Are you sure want to Return(" & txtqty.Text & " Pcs) of " & lblitemcode.Text & "'?", vbQuestion + vbYesNo, "Return Item") = vbYes Then
                Try
                    Call connect()
                   
                    Dim cmd As Odbc.OdbcCommand
                    Dim sql As String
                    sql = "INSERT INTO returns(drID,sup_id,itemid,returnby,reason,other,qty,datereturn) VALUES (?,?,?,?,?,?,?,?)"
                    cmd = New Odbc.OdbcCommand(sql, con)
                    With cmd
                        .Parameters.AddWithValue("?", lbldrID.Text)
                        .Parameters.AddWithValue("?", lblsupid.Text)
                        .Parameters.AddWithValue("?", lblitemid.Text)
                        .Parameters.AddWithValue("?", cboreturnby.SelectedValue)
                        .Parameters.AddWithValue("?", cboreason.Text)
                        .Parameters.AddWithValue("?", txtother.Text)
                        .Parameters.AddWithValue("?", txtqty.Text)
                        .Parameters.AddWithValue("?", lbldate.Text)
                        cmd.ExecuteNonQuery()
                        minusprod()
                    End With
                    loadData("SELECT * FROM vw_polistwdel WHERE dateDelivered > CURRENT_DATE -INTERVAL 15 DAY AND quantity >0 ORDER BY ruID DESC", frmreturnitem.dgv)
                    MsgBox("Item Return Successfully Save ", vbOKOnly + vbInformation, "Information")

                    Me.Dispose()


                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
        loadData("SELECT * FROM vw_polistwdel WHERE dateDelivered > CURRENT_DATE -INTERVAL 15 DAY AND quantity >0 ORDER BY ruID DESC", frmreturnfromclient.dgv)
        loaddgvv("SELECT stockID,itemcode,itemtype,description,Price,UnitP,quantity FROM vw_inv ORDER BY stockid DESC", frmInventory.dgv)
    End Sub

    Private Sub cboreturnby_Click(sender As Object, e As EventArgs) Handles cboreturnby.Click
        Call connect()
        loadcombobox("SELECT empID, CONCAT(lname, ', ', fname,' ',mname) EmployeeName FROM employee", cboreturnby, "EmployeeName", "empID")
    End Sub
    Sub minusprod()
        trans.prodID = lblitemid.Text
        trans.qty1 = txtqty.Text
        trans.ponum = lblponum.Text
        trans.minusProduct("UPDATE stocks SET quantity=quantity - ? WHERE itemid = ?", 0)
        trans.minusdel("UPDATE receiveddetails SET quantity=quantity - ? WHERE itemid = ? AND ponum = ?", 0)
    End Sub
End Class