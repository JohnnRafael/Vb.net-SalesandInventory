Public Class frmsupplier

    
    Private Sub frmsupplier_Load(sender As Object, e As EventArgs) Handles Me.Load
        'btnpo.Enabled = False
        Call connect()
        Call loadData("SELECT sup_id, sup_cname, contact, emailadd, CONCAT(house, ', ', brgy,' ',city) Address FROM supplier ORDER BY sup_id ASC", dgv)
    End Sub


    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        If MsgBox("Do you want to Add a New Supplier?", MsgBoxStyle.Question + vbYesNo, "Supplier") = vbYes Then

            frmsuppadd.ShowDialog()
        End If
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        If e.RowIndex >= 0 Then
            dgv.Tag = dgv.Item(0, e.RowIndex).Value
            'btnpo.Enabled = True
        Else
            MsgBox("NO RECORD SELECTED!")
        End If
    End Sub

    Private Sub dgvpoitem_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        ' btnpo.Enabled = True
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If Len(dgv.Tag) = 0 Then
            MsgBox("Please select a record", MsgBoxStyle.Information, "Product Information")
        Else
            If MsgBox("Do you want to edit this supplier?", MsgBoxStyle.Question + vbYesNo, "Supplier") = vbYes Then
                Call fetchdata(Val(dgv.Tag))
            End If
        End If
    End Sub
    Private Sub fetchdata(ByVal sid As String)
        Try
            Dim da As Odbc.OdbcDataAdapter
            Dim dt As New DataTable
            Dim sql As String = "select * from supplier where sup_id=" & sid
            da = New Odbc.OdbcDataAdapter(sql, con)
            da.Fill(dt)
            With frmupdatesupp
                .txtcname.Text = dt.Rows(0).Item(1).ToString
                .txtcontact.Text = dt.Rows(0).Item(3).ToString
                .txtemailadd.Text = dt.Rows(0).Item(4).ToString
                .txtstreet.Text = dt.Rows(0).Item(5).ToString
                .txtbrgy.Text = dt.Rows(0).Item(6).ToString
                .txtCity.Text = dt.Rows(0).Item(7).ToString
            End With
            frmupdatesupp.ShowDialog()

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message)
        End Try
    End Sub

    Private Sub btnpo_Click(sender As Object, e As EventArgs)
        If Len(dgv.Tag) = 0 Then
            MsgBox("Please select a Supplier", MsgBoxStyle.Information, "Supplier Information")
        Else
            If MsgBox("Do you want to Purchase an Order?", MsgBoxStyle.Question + vbYesNo, "Supplier") = vbYes Then
                ' Call fetchdata2(Val(dgv.Tag))
            End If
        End If
    End Sub
    Private Sub fetchdata2(ByVal sid As String)
        Try
            Dim da As Odbc.OdbcDataAdapter
            Dim dt As New DataTable
            Dim sql As String = "select * from vw_supplier where sup_id=" & sid
            da = New Odbc.OdbcDataAdapter(sql, con)
            da.Fill(dt)
            With frmsuppdetails
                .lblid.Text = dt.Rows(0).Item(0).ToString
                .lblsupplier.Text = dt.Rows(0).Item(1).ToString
                .lblcontactno.Text = dt.Rows(0).Item(2).ToString
                .lblemail.Text = dt.Rows(0).Item(3).ToString
                .lbladd.Text = dt.Rows(0).Item(4).ToString
            End With
            frmsuppdetails.ShowDialog()

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message)
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Len(dgv.Tag) = 0 Then
            MsgBox("Please select a record", MsgBoxStyle.Information, "Product Information")
        Else
            Call fetchdata2(Val(dgv.Tag))
            End If

    End Sub
End Class