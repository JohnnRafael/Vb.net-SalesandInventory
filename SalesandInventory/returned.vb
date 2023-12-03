Public Class returned


    Private Sub returned_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadData("Select * from vw_return ORDER BY returnid DESC", dgv)
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub
End Class