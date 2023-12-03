Public Class frmsuppdetails

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub lblemail_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Call fetchdata2(Val(dgv.Tag))
    End Sub
    Private Sub fetchdata2(ByVal sid As String)
        Try
            Dim da As Odbc.OdbcDataAdapter
            Dim dt As New DataTable
            Dim sql As String = "select * from vw_supplier where sup_id=" & sid
            da = New Odbc.OdbcDataAdapter(sql, con)
            da.Fill(dt)
            With frmAdd
                .lblid.Text = Me.lblid.Text
            End With
            frmAdd.ShowDialog()


        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message)
        End Try
    End Sub

    Private Sub frmsuppdetails_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call loadData("select * from vw_sup_item2 WHERE suppid='" & lblid.Text & "'", dgv)
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If Len(dgv.Tag) = 0 Then
            MsgBox("Please select a record", MsgBoxStyle.Information, "Product Information")
        Else
            If MsgBox("Do you want to edit the item?", MsgBoxStyle.Question + vbYesNo, "EDIT") = vbYes Then
                Call fetchdata(Val(dgv.Tag))
            End If
        End If
    End Sub
    Private Sub fetchdata(ByVal sid As String)
        Try
            Dim da As Odbc.OdbcDataAdapter
            Dim dt As New DataTable
            Dim sql As String = "select * from vw_items where itemid=" & sid
            da = New Odbc.OdbcDataAdapter(sql, con)
            da.Fill(dt)
            With frmEdit
                .txtitemcode.Text = dt.Rows(0).Item(1).ToString
                .cboitemtype.Text = dt.Rows(0).Item(2).ToString
                .txtdesc.Text = dt.Rows(0).Item(3).ToString
                .txtprice.Text = dt.Rows(0).Item(4).ToString
                .txtunitp.Text = dt.Rows(0).Item(5).ToString
                .lblid.Text = dt.Rows(0).Item(6).ToString
                loadcombobox("Select typeid, itemtype from itemtype", .cboitemtype, "itemtype", "typeid")
            End With
            frmEdit.ShowDialog()

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

    Private Sub dgv_DoubleClick(sender As Object, e As EventArgs) Handles dgv.DoubleClick

    End Sub
End Class