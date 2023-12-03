Public Class printfp

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Sub printdailysales()
        Dim rpt As New CrystalReport2()
        Dim conn As New Odbc.OdbcConnection
        Dim sql As New Odbc.OdbcCommand

        Dim da As New Odbc.OdbcDataAdapter
        Dim dt As New DataSet1

        Dim fromdate = Format(dtdatef.Value, "yyyy-dd-MM").ToString
        Dim ToDate = Format(dtdateto.Value, "yyyy-dd-MM").ToString
        Try
            conn = New Odbc.OdbcConnection("dsn=salesandinventory")
            conn.Open()
            sql = conn.CreateCommand
            sql.CommandText = "SELECT * FROM vw_paymentfpreport WHERE (tDate BETWEEN ('" & fromdate & "')AND('" & ToDate & "')) ORDER BY transno DESC"
            da.SelectCommand = sql
            da.Fill(dt, "vw_paymentfpreport")
            rpt.SetDataSource(dt)

            CrystalReportViewer1.ReportSource = rpt
            rpt.SummaryInfo.ReportTitle = "Sales Date : " & Format(dtdatef.Value, "yyyy-dd-MM") & " To: " & Format(dtdateto.Value, "yyyy-dd-MM")
            conn.Close()

            Me.CrystalReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message)
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class