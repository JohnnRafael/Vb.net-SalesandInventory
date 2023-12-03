Public Class printinv
    Dim sql As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs)
    '    Dim cmd As Odbc.OdbcCommand
    '    sql = "Select * from vw_inv"
    '    cmd = New Odbc.OdbcCommand(sql, con)
    '    reports(sql, "CrystalReport1", CrystalReportViewer1)
    'End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub printinv_Load(sender As Object, e As EventArgs) Handles Me.Load
        'CrystalReportViewer1.ShowGroupTreeButton =

    End Sub
End Class