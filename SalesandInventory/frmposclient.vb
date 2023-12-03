Public Class frmposclient

    Private Sub frmclient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connect()
        'loadData("select custID, Iddetails, CONCAT(lname, ', ', fname,' ',mi) clientname, CONCAT(street, ', ', brgy,' ',city) address, contactno, emailadd from client", dgv)
        loadData("select * from vwclient", dgv)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnenter.Click
        If Len(dgv.Tag) = 0 Then
            MsgBox("Please select a record", MsgBoxStyle.Information, "Client Information")
        Else
            Call fetchdata(Val(dgv.Tag))
        End If
    End Sub
    Private Sub fetchdata(ByVal sid As String)
        Call connect()
        Try
            Dim da As Odbc.OdbcDataAdapter
            Dim dt As New DataTable
            Dim sql As String = "select * from vwclient where custID=" & sid
            da = New Odbc.OdbcDataAdapter(sql, con)
            da.Fill(dt)
            With frmPOS
                .lblid.Text = dt.Rows(0).Item(1).ToString
                .lblcustname.Text = dt.Rows(0).Item(2).ToString
                .lbllocation.Text = dt.Rows(0).Item(3).ToString
            End With
            Me.Dispose()
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

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class