Public Class frmInventory
    Public qty As Integer
    Private Sub Stocks_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Call connect()
        dgv.Tag = ""
    End Sub
    Private Sub Stocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connect()
        dgv.Tag = ""
    End Sub

    Private Sub btnadd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnadd.Click
        If Len(dgv.Tag) = 0 Then
            MsgBox("Please Select a record first.", vbInformation, "Information")
        Else
            frmAddStck.ShowDialog()
        End If
    End Sub
    Private Sub dgv_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellClick
        If e.RowIndex >= 0 Then
            dgv.Tag = dgv.Item(0, e.RowIndex).Value
            qty = dgv.Item(5, e.RowIndex).Value
        End If
    End Sub
    Private Sub dgv_RowPostPaint(ByVal sender As Object, ByVal e As DataGridViewRowPostPaintEventArgs) Handles dgv.RowPostPaint
        For i = 0 To dgv.Rows.Count - 1
            If Val(dgv.Rows(i).Cells(6).Value) = 0 Then
                dgv.Rows(i).Cells(0).Style.BackColor = Color.LightPink
                dgv.Rows(i).Cells(0).Style.ForeColor = Color.Black
                dgv.Rows(i).Cells(1).Style.BackColor = Color.LightPink
                dgv.Rows(i).Cells(1).Style.ForeColor = Color.Black
                dgv.Rows(i).Cells(2).Style.BackColor = Color.LightPink
                dgv.Rows(i).Cells(2).Style.ForeColor = Color.Black
                dgv.Rows(i).Cells(3).Style.BackColor = Color.LightPink
                dgv.Rows(i).Cells(3).Style.ForeColor = Color.Black
                dgv.Rows(i).Cells(4).Style.BackColor = Color.LightPink
                dgv.Rows(i).Cells(4).Style.ForeColor = Color.Black
                dgv.Rows(i).Cells(5).Style.BackColor = Color.LightPink
                dgv.Rows(i).Cells(5).Style.ForeColor = Color.Black
                dgv.Rows(i).Cells(6).Style.BackColor = Color.LightPink
                dgv.Rows(i).Cells(6).Style.ForeColor = Color.Black
            ElseIf Val(dgv.Rows(i).Cells(6).Value) <= 5 Then
                dgv.Rows(i).Cells(0).Style.BackColor = Color.LightBlue
                dgv.Rows(i).Cells(0).Style.ForeColor = Color.Black
                dgv.Rows(i).Cells(1).Style.BackColor = Color.LightBlue
                dgv.Rows(i).Cells(1).Style.ForeColor = Color.Black
                dgv.Rows(i).Cells(2).Style.BackColor = Color.LightBlue
                dgv.Rows(i).Cells(2).Style.ForeColor = Color.Black
                dgv.Rows(i).Cells(3).Style.BackColor = Color.LightBlue
                dgv.Rows(i).Cells(3).Style.ForeColor = Color.Black
                dgv.Rows(i).Cells(4).Style.BackColor = Color.LightBlue
                dgv.Rows(i).Cells(4).Style.ForeColor = Color.Black
                dgv.Rows(i).Cells(5).Style.BackColor = Color.LightBlue
                dgv.Rows(i).Cells(5).Style.ForeColor = Color.Black
                dgv.Rows(i).Cells(6).Style.BackColor = Color.LightBlue
                dgv.Rows(i).Cells(6).Style.ForeColor = Color.Black
            End If
        Next
    End Sub
    Private Sub cbosearch_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbosearch.SelectedIndexChanged
        If cbosearch.Text = "Out of Stock" Then
            Call connect()
            loadData("SELECT stockid,itemcode,itemtype,Description,Price,UnitP,quantity FROM vw_inv WHERE quantity=0 ORDER BY quantity DESC", dgv)
        ElseIf cbosearch.Text = "Critical" Then
            Call connect()
            loadData("SELECT stockid,itemcode,itemtype,Description,Price,UnitP,quantity FROM vw_inv WHERE quantity<=5 and quantity>=1 ORDER BY quantity DESC", dgv)
        ElseIf cbosearch.Text = "All Items" Then
            Call connect()
            loadData("SELECT stockid,itemcode,itemtype,Description,Price,UnitP,quantity FROM vw_inv ORDER BY quantity ASC", dgv)

        End If
    End Sub
    Private Sub btnorder_Click(sender As Object, e As EventArgs) Handles btnorder.Click
        frmReceived.ShowDialog()
    End Sub
    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Call connect()
        Call loadData("select * from vw_inv where itemCode like '%" & Trim(txtsearch.Text) & "%' ", dgv)
        If cbosearch2.Text = "ItemCode" Then
            Call loadData("select * from vw_inv where itemCode like '%" & Trim(txtsearch.Text) & "%' ", dgv)
        ElseIf cbosearch2.Text = "ItemType" Then
            Call loadData("select * from vw_inv where ItemType like '%" & Trim(txtsearch.Text) & "%' ", dgv)
        ElseIf cbosearch2.Text = "Description" Then
            Call loadData("select * from vw_inv where Description like '%" & Trim(txtsearch.Text) & "%' ", dgv)
        End If
    End Sub
End Class