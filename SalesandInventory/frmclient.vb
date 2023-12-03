Public Class frmclient

    Private Sub frmclient_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Call connect()
        loadData("select * from vwclients", dgv)
        loadcombobox("SELECT pmethodid, pmethod FROM clientpay ORDER BY pmethodid ASC", frmeditclient.cbopm, "pmethod", "pmethodid")
    End Sub


    Private Sub frmclient_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call connect()
        loadData("select * from vwclients", dgv)
        loadcombobox("SELECT pmethodid, pmethod FROM clientpay ORDER BY pmethodid ASC", frmeditclient.cbopm, "pmethod", "pmethodid")
        'loadData("select custID, Iddetails, clientname, pmethod, address, contactno, emailadd from vwclients", dgv)
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        frmaddclient.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If Len(dgv.Tag) = 0 Then
            MsgBox("Please select a record", MsgBoxStyle.Information, "Information")
        Else
            If MsgBox("Do you want to edit the client's information??", MsgBoxStyle.Question + vbYesNo, "Supplier") = vbYes Then
                Call fetchdata(Val(dgv.Tag))
            End If
        End If
    End Sub
    Private Sub fetchdata(ByVal sid As String)
        Call connect()
        Try
            Dim da As Odbc.OdbcDataAdapter
            Dim dt As New DataTable
            Dim sql As String = "select * from client where custid=" & sid
            da = New Odbc.OdbcDataAdapter(sql, con)
            da.Fill(dt)
            With frmeditclient
                .lblclient.Text = dt.Rows(0).Item(1).ToString
                .txtlname.Text = dt.Rows(0).Item(2).ToString
                .txtfname.Text = dt.Rows(0).Item(3).ToString
                .txtmi.Text = dt.Rows(0).Item(4).ToString
                .cbopm.Text = dt.Rows(0).Item(5).ToString
                .txtstreet.Text = dt.Rows(0).Item(6).ToString
                .txtbrgy.Text = dt.Rows(0).Item(7).ToString
                .txtcity.Text = dt.Rows(0).Item(8).ToString
                .txtcontactno.Text = dt.Rows(0).Item(9).ToString
                .txtemail.Text = dt.Rows(0).Item(10).ToString
            End With
            frmeditclient.ShowDialog()

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


    Private Sub fetchdatas(ByVal sid As String)
        Call connect()
        Try
            Dim da As Odbc.OdbcDataAdapter
            Dim dt As New DataTable
            Dim sql As String = "select * from vwclients where custID=" & sid
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnconfirm.Click
        If Len(dgv.Tag) = 0 Then
            MsgBox("Please select a record", MsgBoxStyle.Information, "Client Information")
        Else
            Call fetchdatas(Val(dgv.Tag))
            Me.Close()
            frmPOS.Show()
            frmPOS.Refresh()
        End If
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class