Public Class frmorder


    Private Sub btnadd_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub dgvPO_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPO.CellContentClick

    End Sub

    Private Sub frmorder_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Call connect()
        cbosearch.Text = ""
        ' loadData("SELECT porder_bodyid,ponum,numberofitem,sup_cname,expecdate,statid,status FROM vw_polistt ORDER BY ponum DESC", dgvPO)
    End Sub

    Private Sub frmorder_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call connect()
        cbosearch.Text = ""
        'loadData("SELECT porder_bodyid,ponum,numberofitem,sup_cname,expecdate,statid,status FROM vw_polistt ORDER BY ponum DESC", dgvPO)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbosearch.SelectedIndexChanged
        If cbosearch.Text = "Delivered" Then
            Call connect()
            loadData("SELECT porder_bodyid,ponum,numberofitem,sup_cname,expecdate,statid,status FROM vw_polistt WHERE statid = 2", dgvPO)
        ElseIf cbosearch.Text = "Pending" Then
            Call connect()
            loadData("SELECT porder_bodyid,ponum,numberofitem,sup_cname,expecdate,statid,status FROM vw_polistt WHERE statid = 1", dgvPO)
        ElseIf cbosearch.Text = "" Then
            Call connect()
            loadData("SELECT porder_bodyid,ponum,numberofitem,sup_cname,expecdate,statid,status FROM vw_polistt ORDER BY ponum DESC", dgvPO)
            'loadData("SELECT stockid,itemcode,itemtype,description,UnitP,quantity FROM vw_inv ORDER BY quantity", dgv)
        End If
    End Sub

    Private Sub btnpo_Click(sender As Object, e As EventArgs) Handles btnpo.Click
        frmnewPO.ShowDialog()
    End Sub
End Class