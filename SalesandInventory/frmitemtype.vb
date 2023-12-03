Public Class frmitemtype

    Private Sub frmCateg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connect()
        Dim sql As String = "select typeid, ItemType from (itemtype)"
        Call loadDGV(sql, dgv, "typeid")

    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
          If e.RowIndex >= 0 Then
            dgv.Tag = dgv.Item(0, e.RowIndex).Value
        Else
            MsgBox("NO RECORD SELECTED!")
        End If
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub


    Private Sub fetchdata(ByVal sid As String)
        Try
            Dim da As Odbc.OdbcDataAdapter
            Dim dt As New DataTable
            Dim sql As String = "select * from itemtype where typeid=" & sid
            da = New Odbc.OdbcDataAdapter(sql, con)
            da.Fill(dt)
            With frmedititemtype
                .txtitemtype.Text = dt.Rows(0).Item(1).ToString
            End With
            frmedititemtype.show()
        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message)
        End Try
    End Sub

    Private Sub btnadd_Click_1(sender As Object, e As EventArgs) Handles btnadd.Click
        additemtype.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If Len(dgv.Tag) = 0 Then
            MsgBox("Please select a record", MsgBoxStyle.Information, "Product Information")
        Else
            If MsgBox("Do you want to edit the itemtype?", MsgBoxStyle.Question + vbYesNo, "EDIT") = vbYes Then
                Call fetchdata(Val(dgv.Tag))
            End If
        End If
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Dispose()
    End Sub
End Class