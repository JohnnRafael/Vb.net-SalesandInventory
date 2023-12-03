Public Class frmEdit
    Private Sub CLEANER()
        cboitemtype.Text = ""
        txtunitp.Text = ""
        txtitemcode.Text = ""
        txtdesc.Text = ""
        txtprice.Text = ""
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MsgBox("Cancel?", vbYesNo + vbQuestion, "Cancel") = vbYes Then
            Call CLEANER()
            Me.Close()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim cmd As Odbc.OdbcCommand
        Dim sql As String
        Dim datatable As New DataTable
        If txtprice.TextLength > 10 Then
            MsgBox("Amount Out of Ranged!", vbExclamation, "")
            txtprice.Clear()
            txtprice.Focus()
            Exit Sub
        ElseIf txtunitp.TextLength > 10 Then
            MsgBox("Amount Out of Ranged!", vbExclamation, "")
            txtprice.Clear()
            txtprice.Focus()
            Exit Sub
        ElseIf Val(lblprice.Text) > Val(lblunitp.Text) Then
            MsgBox("Invalid Unit Price!", vbExclamation, "")
            txtunitp.Clear()
            txtunitp.Focus()
            Exit Sub
        Else
            If txtitemcode.Text = "" Then
                MsgBox("Please Input Item Code!", vbOKOnly + vbInformation, "Missing")
                txtitemcode.Focus()
            ElseIf cboitemtype.Text = "" Then
                MsgBox("Please Input Item Type!", vbOKOnly + vbInformation, "Missing")
                cboitemtype.Focus()
            ElseIf txtunitp.Text = "" Then
                MsgBox("Please Input Item Price!", vbOKOnly + vbInformation, "Missing")
                txtunitp.Focus()
            ElseIf txtprice.Text = "" Then
                MsgBox("Please Input Supplier Price!", vbOKOnly + vbInformation, "Missing")
                txtprice.Focus()
            Else
                If MsgBox("Are you sure want to save this item?", vbQuestion + vbYesNo, "") = vbYes Then
                    Try
                        Call connect()
                        If Val(btnSave.Tag) = 0 Then

                            sql = "UPDATE items set itemcode=?, typeid=?, Description=?, price=?, Unitp=? where itemid=" & frmsuppdetails.dgv.Tag
                            cmd = New Odbc.OdbcCommand(sql, con)
                            With cmd
                                .Parameters.AddWithValue("?", txtitemcode.Text)
                                .Parameters.AddWithValue("?", cboitemtype.SelectedValue)
                                .Parameters.AddWithValue("?", txtdesc.Text)
                                .Parameters.AddWithValue("?", txtprice.Text)
                                .Parameters.AddWithValue("?", txtunitp.Text)
                                .Parameters.AddWithValue("?", Val(btnSave.Tag))
                                .ExecuteNonQuery()
                            End With
                            MsgBox("ITEM HAS BEEN UPDATED SUCCESSFULLY!", vbOKOnly + vbInformation, "Information")
                            frmsuppdetails.dgv.Tag = ""
                            Me.Close()
                            Call CLEANER()
                          
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            End If
        End If
        Call loadData("select * from vw_sup_item2 where suppid='" & frmsuppdetails.lblid.Text & "' ORDER BY itemid DESC ", frmsuppdetails.dgv)
        Call loadData("SELECT stockid, itemcode, itemtype, description,price, UnitP,quantity FROM vw_inv ORDER BY stockid DESC", frmInventory.dgv)
    End Sub

    Private Sub txtunitp_KeyPress1(sender As Object, e As KeyPressEventArgs) Handles txtunitp.KeyPress
        filternum(e.KeyChar)
    End Sub

    Private Sub cboitemtype_Click(sender As Object, e As EventArgs) Handles cboitemtype.Click
        loadcombobox("Select typeid, itemtype from itemtype", cboitemtype, "itemtype", "typeid")
    End Sub
    Private Sub txtprice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprice.KeyPress
        filternum(e.KeyChar)
    End Sub

    Private Sub txtprice_TextChanged(sender As Object, e As EventArgs) Handles txtprice.TextChanged
        lblprice.Text = txtprice.Text
    End Sub

    Private Sub txtunitp_TextChanged(sender As Object, e As EventArgs) Handles txtunitp.TextChanged
        lblunitp.Text = txtunitp.Text
    End Sub
End Class