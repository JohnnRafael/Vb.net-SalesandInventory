Public Class frmAdd
    Private Sub frmAdd_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Call CLEANER()
        txtitemcode.Focus()
    End Sub

    Private Sub frmAdd_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblitemID.Text = getITEMid()
        connect()
        txtitemcode.Focus()
    End Sub
    Private Sub txtunitp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtunitp.KeyPress
        filternum(e.KeyChar)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim cmd2 As Odbc.OdbcCommand
        Dim adapt As Odbc.OdbcDataAdapter
        Dim datatable As New DataTable
        cmd2 = New Odbc.OdbcCommand("SELECT itemcode FROM items WHERE itemcode=?", con)
        With cmd2.Parameters
            .AddWithValue("@itemcode", Trim(txtitemcode.Text))
            .AddWithValue("@itemtype", Trim(cboitemtype.SelectedText))
        End With
        adapt = New Odbc.OdbcDataAdapter(cmd2)
        adapt.Fill(datatable)
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
                            If datatable.Rows.Count = 1 Then
                                MsgBox("This Item is already existed.", vbInformation, "Information")
                                txtitemcode.Clear()
                                txtitemcode.Focus()
                                Exit Sub
                            Else
                                Dim cmd As Odbc.OdbcCommand
                                Dim sql As String
                                sql = "INSERT INTO items(itemcode, typeid, Description, price, UnitP, suppid) values (?,?,?,?,?,?)"
                                cmd = New Odbc.OdbcCommand(sql, con)
                                With cmd
                                    .Parameters.AddWithValue("?", txtitemcode.Text)
                                    .Parameters.AddWithValue("?", cboitemtype.SelectedValue)
                                    .Parameters.AddWithValue("?", txtdesc.Text)
                                    .Parameters.AddWithValue("?", txtprice.Text)
                                    .Parameters.AddWithValue("?", txtunitp.Text)
                                    .Parameters.AddWithValue("?", lblid.Text)
                                    cmd.ExecuteNonQuery()
                                    saveQuantityItem()
                                    ' savesalesItem()
                                End With
                                MsgBox("NEW ITEM HAS BEEN ADDED SUCCESSFULLY!", vbOKOnly + vbInformation, "Information")
                                frmsuppdetails.dgv.Tag = ""
                                Me.Dispose()
                            End If
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

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MsgBox("Cancel?", vbYesNo + vbQuestion, "Cancel") = vbYes Then
            Me.Close()
            txtitemcode.Text = ""
            txtdesc.Text = ""
            cboitemtype.Text = ""
            txtprice.Text = ""
            txtunitp.Text = ""
        Else
        End If
    End Sub
    Function getITEMid() As Long
        connect()
        Dim com As New Odbc.OdbcDataAdapter("SELECT count(itemid) from items", con)
        Dim dt As New DataTable
        com.Fill(dt)
        getITEMid = Val(dt.Rows(0)(0) + 1)
    End Function
    Public Sub saveQuantityItem()
        Try
            connect()
            Dim cmd As Odbc.OdbcCommand
            cmd = New Odbc.OdbcCommand("INSERT INTO stocks(itemid) VALUES (?)", con)
            cmd.Parameters.AddWithValue("", Me.lblitemID.Text)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

    End Sub
    Public Sub savesalesItem()
        Try
            connect()
            Dim cmd As Odbc.OdbcCommand
            cmd = New Odbc.OdbcCommand("INSERT INTO sales(itemid) VALUES (?)", con)
            cmd.Parameters.AddWithValue("", Me.lblitemID.Text)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub txtitemcode_TextChanged(sender As Object, e As EventArgs) Handles txtitemcode.TextChanged
        txtitemcode.Text = UCase(txtitemcode.Text)
    End Sub
    Private Sub btnadd_click(sender As Object, e As EventArgs) Handles btnadd.Click
        Call frmitemtype.ShowDialog()
        loadcombobox("SELECT typeid, ItemType FROM itemtype ORDER BY typeid DESC", cboitemtype, "ItemType", "typeid")
    End Sub
    Private Sub CLEANER()
        cboitemtype.Text = ""
    End Sub

    Private Sub cboitemtype_Click(sender As Object, e As EventArgs) Handles cboitemtype.Click
        loadcombobox("SELECT typeid, ItemType FROM itemtype ORDER BY typeid ASC", cboitemtype, "ItemType", "typeid")
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