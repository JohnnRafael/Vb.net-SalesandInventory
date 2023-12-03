Public Class salesreportfp
    Private Sub salesreportfp_Load(sender As Object, e As EventArgs) Handles Me.Load
     
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim vReport As New printfp
        vReport.dtdatef.Value = dtdatef.Value
        vReport.dtdateto.Value = dtdateto.Value

        Call vReport.printdailysales()
        vReport.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        loadData("Select * FROM vw_paymentfpreport where tDate like '%" & Trim(Mainform.lblmaindt3.Text) & "%'ORDER BY transno DESC", dgvv)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call connect()
        loadData("SELECT * FROM vw_paymentfpreport WHERE tDate BETWEEN '" & dtdatef.Value.ToString("yyyy-dd-MM") & "'AND'" & dtdateto.Value.ToString("yyyy-dd-MM") & "'ORDER BY transno DESC", dgvv)
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class