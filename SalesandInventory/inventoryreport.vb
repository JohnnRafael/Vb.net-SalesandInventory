Public Class inventoryreport

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub printinventory_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call connect()
        loadData("SELECT stockid,itemcode,itemtype,Description,UnitP,quantity,total FROM vw_inv2 ORDER BY stockid DESC", dgv)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        printinv.ShowDialog()

    End Sub
End Class