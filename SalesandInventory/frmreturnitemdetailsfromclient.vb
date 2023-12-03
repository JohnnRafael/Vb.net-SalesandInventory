Public Class frmreturnitemdetailsfromclient
    Dim trans As New transaction
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub
    Private Sub frmreturnitemdetailsfromclient_Load(sender As Object, e As EventArgs) Handles Me.Load
        lbldate.Text = Format(Today, "yyyy-MM-dd")
        Dim price As Double
        price = Val(lblprice.Text)
        lblprice.Text = Format(price, "##,##0.00")
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim da As New Odbc.OdbcDataAdapter("SELECT * FROM vw_inv WHERE stockid =" & Val(lblitemid.Text), con)
        Dim dt As New DataTable
        da.Fill(dt)
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
                    sql = "INSERT INTO returnfromclient(clientid,ornum,itemid,reason,other,qty,datereturn) VALUES (?,?,?,?,?,?,?)"
                    cmd = New Odbc.OdbcCommand(sql, con)
                    With cmd
                        .Parameters.AddWithValue("?", lblclientid.Text)
                        .Parameters.AddWithValue("?", lblornum.Text)
                        .Parameters.AddWithValue("?", lblitemid.Text)
                        .Parameters.AddWithValue("?", cboreason.Text)
                        .Parameters.AddWithValue("?", txtother.Text)
                        .Parameters.AddWithValue("?", txtqty.Text)
                        .Parameters.AddWithValue("?", lbldate.Text)
                        cmd.ExecuteNonQuery()
                        minusprod()
                    End With
                    loadData("SELECT * FROM vw_salestrans WHERE tDate > CURRENT_DATE -INTERVAL 15 DAY AND qty > 0 ORDER BY transID DESC", frmreturnfromclient.dgv)
                    MsgBox("Item Return Successfully Save ", vbOKOnly + vbInformation, "Information")
                    Me.Dispose()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
        loadData("SELECT * FROM vw_returnfromclient1 ORDER BY returnid DESC", returnfromclient.dgv)
        loadData("SELECT * FROM vw_salestrans WHERE tDate > CURRENT_DATE -INTERVAL 15 DAY AND qty > 0 ORDER BY transID DESC", frmreturnfromclient.dgv)
        loaddgvv("SELECT stockID,itemcode,itemtype,description,Price,UnitP,quantity FROM vw_inv ORDER BY stockid DESC", frmInventory.dgv)
    End Sub
    Sub minusprod()
        trans.itemid = lblitemid.Text
        trans.qty1 = txtqty.Text
        trans.transId = lbltransid.Text
        trans.addProductwarrant("UPDATE stocks SET quantity=quantity + ? WHERE itemid = ?", 0)
        trans.minusintrans("UPDATE transaction SET qty=qty - ? WHERE totalstockId = ? AND transId = ?", 0)
    End Sub
    Private Sub txtqty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtqty.KeyPress
        filternum(e.KeyChar)
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub
End Class