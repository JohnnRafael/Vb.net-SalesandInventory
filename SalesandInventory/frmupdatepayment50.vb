Public Class frmupdatepayment50

    
    Private Sub frmupdatepayment50_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call connect()
        loadData("SELECT * from vw_updatepayment50 where isPaid = 0", dgv)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Len(dgv.Tag) = 0 Then
            MsgBox("Please select a Transaction", MsgBoxStyle.Information, "Product Information")
        Else
            If MsgBox("Do you want to update payment for this Transaction??", MsgBoxStyle.Question + vbYesNo, "Update") = vbYes Then
                Call fetchdata(Val(dgv.Tag))
            End If
        End If
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        If e.RowIndex >= 0 Then
            dgv.Tag = dgv.Item(0, e.RowIndex).Value
        Else
            MsgBox("NO RECORD SELECTED!")
        End If
    End Sub
    Private Sub fetchdata(ByVal sid As String)
        Try
            Dim da As Odbc.OdbcDataAdapter
            Dim dt As New DataTable
            Dim sql As String = "select * from vw_updatepayment50 where transno=" & sid
            da = New Odbc.OdbcDataAdapter(sql, con)
            da.Fill(dt)
            With frmupdate
                .lbltransno.Text = dt.Rows(0).Item(0).ToString
                .lblid.Text = dt.Rows(0).Item(1).ToString
                .lblclientname.Text = dt.Rows(0).Item(2).ToString
                .lblnoi.Text = dt.Rows(0).Item(3).ToString
                .lbldiscount.Text = dt.Rows(0).Item(4).ToString
                .lbldelfee.Text = dt.Rows(0).Item(5).ToString
                .lbltotalamount.Text = dt.Rows(0).Item(6).ToString
                .lblamountTendered.Text = dt.Rows(0).Item(7).ToString
                .lblcurrentbal.Text = dt.Rows(0).Item(8).ToString
                .lblcb.Text = dt.Rows(0).Item(8).ToString
                .lbltdate.Text = dt.Rows(0).Item(9).ToString

            End With
            frmupdate.ShowDialog()

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message)
        End Try
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub
End Class