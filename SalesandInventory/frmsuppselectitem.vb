Public Class frmsuppselectitem
    Private Sub frmsuppselectitem_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Call connect()
        Dim sql As String = "select itemid, itemcode, itemtype, Description, price, UnitP from (vw_prod)"
        Call loadDGV(sql, dgv, "itemid")
        txtsearch.Focus()
        'loadcombobox("SELECT typeid, ItemType FROM itemtype ORDER BY typeid DESC", frmEdit.cboitemtype, "ItemType", "typeid")
    End Sub

    Private Sub frmsuppselectitem_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call connect()
        Dim sql As String = "select itemid, itemcode, itemtype, Description, price, UnitP from (vw_prod)"
        Call loadDGV(sql, dgv, "itemid")
        txtsearch.Focus()
        lblsupitemid.Text = getsupitemid()
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Call connect()
        If cbosearch.Text = "ItemCode" Then
            Call loadData("select * from vw_prod where itemCode like '%" & Trim(txtsearch.Text) & "%' ", dgv)
        ElseIf cbosearch.Text = "ItemType" Then
            Call loadData("select * from vw_prod where ItemType like '%" & Trim(txtsearch.Text) & "%' ", dgv)
        ElseIf cbosearch.Text = "Description" Then
            Call loadData("select * from vw_prod where Description like '%" & Trim(txtsearch.Text) & "%' ", dgv)
            'ElseIf cbosearch.Text = "" Then
            ' loadData("SELECT stockid,itemcode,itemtype,description,price,UnitP,quantity,Total FROM vw_inventory ORDER BY quantity", dgv)
        End If
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        If e.RowIndex >= 0 Then
            dgv.Tag = dgv.Item(0, e.RowIndex).Value
            Call fetchdata(Val(dgv.Tag))
        Else
            MsgBox("NO RECORD SELECTED!")
        End If
    End Sub
    Private Sub fetchdata(ByVal sid As String)
        Try
            Dim da As Odbc.OdbcDataAdapter
            Dim dt As New DataTable
            Dim sql As String = "select * from vw_prod where itemid=" & sid
            da = New Odbc.OdbcDataAdapter(sql, con)
            da.Fill(dt)
            With Me
                .lblitemid.Text = dt.Rows(0).Item(0).ToString
                .lblitemcode.Text = dt.Rows(0).Item(1).ToString
                .lblitemtype.Text = dt.Rows(0).Item(2).ToString
                .lbldesc.Text = dt.Rows(0).Item(3).ToString
                .lblprice.Text = dt.Rows(0).Item(4).ToString
            End With
            Me.Refresh()

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message)
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim cmd2 As Odbc.OdbcCommand
        Dim adapt As Odbc.OdbcDataAdapter
        Dim datatable As New DataTable
        cmd2 = New Odbc.OdbcCommand("SELECT itemcode FROM sup_item WHERE itemcode=? AND suppid=? ", con)
        With cmd2.Parameters
            .AddWithValue("@itemcode", Trim(lblitemcode.Text))
            .AddWithValue("@suppid", Trim(lblid.Text))
        End With
        adapt = New Odbc.OdbcDataAdapter(cmd2)
        adapt.Fill(datatable)
        If lblitemcode.Text = "Label2" Or lblitemtype.Text = "Label3" Or lblprice.Text = "Label6" Then
            MsgBox("Please Select an item!", vbOKOnly + vbInformation, "Missing")

        Else
            Try
                Call connect()
                If Val(btnadd.Tag) = 0 Then
                    If datatable.Rows.Count = 1 Then
                        MsgBox("This Item is already existed.", vbInformation, "Information")
                        Exit Sub
                    Else
                        Dim cmd As Odbc.OdbcCommand
                        Dim sql As String
                        sql = "INSERT INTO sup_item(suppid, itemid, itemcode, itemtype, description, price) VALUES (?,?,?,?,?,?)"
                        cmd = New Odbc.OdbcCommand(sql, con)
                        With cmd
                            .Parameters.AddWithValue("?", lblid.Text)
                            .Parameters.AddWithValue("?", lblitemid.Text)
                            .Parameters.AddWithValue("?", lblitemcode.Text)
                            .Parameters.AddWithValue("?", lblitemtype.Text)
                            .Parameters.AddWithValue("?", lbldesc.Text)
                            .Parameters.AddWithValue("?", lblprice.Text)
                            '.Parameters.AddWithValue("?", txtunitp.Text)
                            cmd.ExecuteNonQuery()
                            'saveQuantityItem()
                            Call loadData("select * from sup_item WHERE suppid='" & frmsuppdetails.lblid.Text & "'", frmsuppdetails.dgv)
                            'Call loadData("SELECT stockid, itemcode, itemtype, description,Price, UnitP,quantity FROM vw_inv ORDER BY stockid DESC", frmInventory.dgv)
                        End With
                        MsgBox("NEW ITEM HAS BEEN ADDED SUCCESSFULLY!", vbOKOnly + vbInformation, "Information")
                        'frmItems.dgv.Tag = ""
                        Me.Dispose()
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        'Call loadData("select * from vw_prod order by itemid", frmItems.dgv)
        'Call loadData("SELECT stockid, itemcode, itemtype, description,price, UnitP,quantity FROM vw_inv ORDER BY stockid DESC", frmInventory.dgv)
    End Sub
    Function getsupitemid() As Long
        connect()
        Dim com As New Odbc.OdbcDataAdapter("SELECT count(supitemid) from sup_item", con)
        Dim dt As New DataTable
        com.Fill(dt)
        getsupitemid = Val(dt.Rows(0)(0) + 1)
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub
End Class