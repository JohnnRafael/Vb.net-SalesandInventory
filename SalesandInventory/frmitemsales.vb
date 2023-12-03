Public Class frmitemsales

   
    Private Sub frmitemsales_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadData("SELECT * FROM vw_sales where quantity >=1 ORDER BY quantity DESC", dgv)
    End Sub
End Class