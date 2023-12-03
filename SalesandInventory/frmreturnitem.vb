Public Class frmreturnitem

    
    Private Sub frmreturnitem_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadData("SELECT * FROM vw_polistwdel WHERE dateDelivered > CURRENT_DATE -INTERVAL 15 DAY AND quantity >0 ORDER BY ruID DESC", dgv)
    End Sub
    Private Sub btnpo_Click(sender As Object, e As EventArgs) Handles btnpo.Click
        If Len(dgv.Tag) = 0 Then
            MsgBox("Please select an Item", MsgBoxStyle.Information, "Product Information")
        Else
            If MsgBox("Do you want to Return this Item?", MsgBoxStyle.Question + vbYesNo, "Update") = vbYes Then
                Call fetchdata(Val(dgv.Tag))
            End If
        End If
    End Sub
    Private Sub fetchdata(ByVal sid As String)
        Try
            Dim da As Odbc.OdbcDataAdapter
            Dim dt As New DataTable
            Dim sql As String = "select * from vw_polistwdel where ruID=" & sid
            da = New Odbc.OdbcDataAdapter(sql, con)
            da.Fill(dt)
            With frmreturnitemdetails
                .lbldrID.Text = dt.Rows(0).Item(1).ToString
                .lblponum.Text = dt.Rows(0).Item(2).ToString
                .lblitemid.Text = dt.Rows(0).Item(3).ToString
                .lblitemcode.Text = dt.Rows(0).Item(4).ToString
                .lblitemtype.Text = dt.Rows(0).Item(5).ToString
                .lblprice.Text = dt.Rows(0).Item(7).ToString
                .txtqty.Text = dt.Rows(0).Item(8).ToString
                .lblqty.Text = dt.Rows(0).Item(8).ToString
                .lblsupid.Text = dt.Rows(0).Item(9).ToString
                .lblsupplier.Text = dt.Rows(0).Item(10).ToString
            End With
            frmreturnitemdetails.ShowDialog()
        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message)
        End Try
    End Sub
    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        If e.RowIndex >= 0 Then
            dgv.Tag = dgv.Item(0, e.RowIndex).Value
        Else
            MsgBox("NO RECORD SELECTED!")
        End If
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub
End Class