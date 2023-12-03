Public Class frmreceivedpono
    Private ponum As String
    Private expecdate As String
    Private supid As Integer
    
    Private Sub frmreceivedpono_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadData("SELECT porder_bodyid,ponum,numberofitem,expecdate,sup_id,sup_cname FROM vw_polistt WHERE statid = 1 ORDER BY porder_bodyid DESC", dgv)
    End Sub
    Private Sub btnconfirm_Click(sender As Object, e As EventArgs) Handles btnconfirm.Click
        If Len(dgv.Tag) = 0 Then
            MsgBox("Please select a record", MsgBoxStyle.Information, "Purchased Order List")
        Else
            If MsgBox("Do you want to select this purchase order?", MsgBoxStyle.Question + vbYesNo, "Purchased Order List") = vbYes Then
                loadData("SELECT itemid,itemcode,itemtype,Description,Price,unitP,quantity,Total, sup_cname, porderid FROM vw_po WHERE ponum='" & lblponum.Text & "'", frmReceived.dgvRitem)
                Me.Dispose()
            End If
        End If
    End Sub
    Private Sub fetchdata(ByVal sid As String)
        Try
            Dim da As Odbc.OdbcDataAdapter
            Dim dt As New DataTable
            Dim sql As String = "select * from vw_polistt where porder_bodyid=" & sid
            da = New Odbc.OdbcDataAdapter(sql, con)
            da.Fill(dt)
            With frmReceived
                .lblpo.Text = dt.Rows(0).Item(1).ToString
            End With

            frmReceived.Show()

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message)
        End Try
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        If e.RowIndex >= 0 Then
            dgv.Tag = dgv.Item(0, e.RowIndex).Value
            ponum = dgv.Item(1, e.RowIndex).Value
            expecdate = dgv.Item(3, e.RowIndex).Value
            supid = dgv.Item(4, e.RowIndex).Value
            lblponum.Text = ponum
            frmReceived.lblpo.Text = ponum
            frmReceived.lbldate.Text = expecdate
            frmReceived.lblsupplier.Text = supid
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class