
Public Class frmItems
    Public type As String
    Private Sub Inventory_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Call connect()
        Dim sql As String = "select itemid, itemcode, itemtype, Description, price, UnitP from (vw_prod)"
        Call loadDGV(sql, dgv, "itemid")
        txtsearch.Focus()
        loadcombobox("SELECT typeid, ItemType FROM itemtype ORDER BY typeid DESC", frmEdit.cboitemtype, "ItemType", "typeid")

    End Sub
    Private Sub inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connect()
        Dim sql As String = "select itemid, itemcode, itemtype, Description, price, UnitP from (vw_prod)"
        Call loadDGV(sql, dgv, "itemid")
        txtsearch.Focus()
        loadcombobox("SELECT typeid, ItemType FROM itemtype ORDER BY typeid DESC", frmEdit.cboitemtype, "ItemType", "typeid")
    End Sub
    Private Sub fetchdata(ByVal sid As String)
        Try
            Dim da As Odbc.OdbcDataAdapter
            Dim dt As New DataTable
            Dim sql As String = "select * from vw_prod where itemid=" & sid
            da = New Odbc.OdbcDataAdapter(sql, con)
            da.Fill(dt)
            With frmEdit
                .txtitemcode.Text = dt.Rows(0).Item(1).ToString
                .cboitemtype.Text = dt.Rows(0).Item(2).ToString
                .txtdesc.Text = dt.Rows(0).Item(3).ToString
                .txtprice.Text = dt.Rows(0).Item(4).ToString
                .txtunitp.Text = dt.Rows(0).Item(5).ToString
            End With
            frmEdit.ShowDialog()

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message)
        End Try
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        If MsgBox("Do you want to Add a New Item?", MsgBoxStyle.Question + vbYesNo, "New Item") = vbYes Then
            frmAdd.ShowDialog()
        End If
    End Sub

    '  Private Sub txtitemcode_TextChanged(sender As Object, e As EventArgs)

    'End Sub

    ' Private Sub txtquantity_KeyPress(sender As Object, e As KeyPressEventArgs)
    ' If (e.KeyChar.ToString = ".") And (txtquantity.Text.Contains(e.KeyChar.ToString)) Then
    '  e.Handled = True
    '   End If
    ' Select Case Asc(e.KeyChar)
    '     Case 48 To 57, 46, 8
    'e.KeyChar = e.KeyChar
    '    Case Else
    ' e.KeyChar = ""
    ' End Select
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If Len(dgv.Tag) = 0 Then
            MsgBox("Please select a record", MsgBoxStyle.Information, "Product Information")
        Else
            If MsgBox("Do you want to edit the item?", MsgBoxStyle.Question + vbYesNo, "EDIT") = vbYes Then
                Call fetchdata(Val(dgv.Tag))
            End If
        End If
    End Sub
    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Call connect()
        If cbosearch.Text = "ItemCode" Then
            Call loadData("select * from vw_prod where itemCode like '%" & Trim(txtsearch.Text) & "%' ", dgv)
        ElseIf cbosearch.Text = "ItemType" Then
            Call loadData("select * from vw_prod where ItemType like '%" & Trim(txtsearch.Text) & "%' ", dgv)
        ElseIf cbosearch.Text = "Description" Then
            Call loadData("select * from vw_prod where Description like '%" & Trim(txtsearch.Text) & "%' ", dgv)
        ElseIf cbosearch.Text = "" Then
            loadData("SELECT stockid,itemcode,itemtype,description,price,UnitP,quantity,Total FROM vw_inventory ORDER BY quantity", dgv)
        End If
    End Sub

    Private Sub cbosearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbosearch.SelectedIndexChanged

    End Sub

    Private Sub dgv_CellClick1(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        If e.RowIndex >= 0 Then
            dgv.Tag = dgv.Item(0, e.RowIndex).Value
        Else
            MsgBox("NO RECORD SELECTED!")
        End If
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class