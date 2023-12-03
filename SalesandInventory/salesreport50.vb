Public Class salesreport50


    Private Sub salesreport50_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Call connect()
        'loadData("SELECT * from vw_payment50report where isPaid=1", dgvv)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim vReport2 As New print50
        vReport2.dtdatef.Value = dtdatef.Value
        vReport2.dtdateto.Value = dtdateto.Value

        Call vReport2.printdailysales()
        vReport2.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        loadData("Select * FROM vw_payment50report where isPaid=1 And tDate like '%" & Trim(Mainform.lblmaindt3.Text) & "%'ORDER BY transno DESC", dgvv)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call connect()
        loadData("SELECT * FROM vw_payment50report WHERE isPaid=1 AND tDate BETWEEN '" & dtdatef.Value.ToString("yyyy-dd-MM") & "'AND'" & dtdateto.Value.ToString("yyyy-dd-MM") & "'ORDER BY transno DESC", dgvv)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    
End Class