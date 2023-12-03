Public Class frmeditclient

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim cmd As Odbc.OdbcCommand
        Dim sql As String
        Dim datatable As New DataTable
        If txtfname.Text = "" Or txtlname.Text = "" Or txtstreet.Text = "" Or txtbrgy.Text = "" Or txtcity.Text = "" Or txtcontactno.Text = "" Or txtemail.Text = "" Then
            MsgBox("Please fill required Fields!", vbOKOnly + vbInformation, "Missing")
        Else
            Try
                Call connect()
                If Val(btnSave.Tag) = 0 Then


                    sql = "UPDATE client set Iddetails=?, lname=?, fname=?, mi=?, pmethod=?, street=?, brgy=?, city=?, contactno=?, emailadd=?, status=? where custid=" & frmclient.dgv.Tag
                    cmd = New Odbc.OdbcCommand(sql, con)
                    With cmd
                        .Parameters.AddWithValue("?", lblclient.Text)
                        .Parameters.AddWithValue("?", txtlname.Text)
                        .Parameters.AddWithValue("?", txtfname.Text)
                        .Parameters.AddWithValue("?", txtmi.Text)
                        .Parameters.AddWithValue("?", cbopm.SelectedValue)
                        .Parameters.AddWithValue("?", txtstreet.Text)
                        .Parameters.AddWithValue("?", txtbrgy.Text)
                        .Parameters.AddWithValue("?", txtcity.Text)
                        .Parameters.AddWithValue("?", txtcontactno.Text)
                        .Parameters.AddWithValue("?", txtemail.Text)
                        .Parameters.AddWithValue("?", 1)
                        cmd.ExecuteNonQuery()
                        loadData("select * from vwclients", frmclient.dgv)
                        'loadData("select custID, Iddetails, CONCAT(lname, ', ', fname,' ',mi) clientname, CONCAT(street, ', ', brgy,' ',city) address, contactno, emailadd from client", frmclient.dgv)
                        'loadData("select custID, Iddetails, CONCAT(lname, ', ', fname,' ',mi) clientname, CONCAT(street, ', ', brgy,' ',city) address, contactno, emailadd from client", frmposclient.dgv)
                    End With
                    MsgBox("CLIENT INFORMATION HAS BEEN UPDATED SUCCESSFULLY!", vbOKOnly + vbInformation, "Information")
                    'frmItems.dgv.Tag = ""
                    Me.Dispose()

                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub txtcontactno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcontactno.KeyPress
        filternum(e.KeyChar)
    End Sub

    Private Sub cbopm_Click(sender As Object, e As EventArgs) Handles cbopm.Click
        loadcombobox("SELECT pmethodid, pmethod FROM clientpay ORDER BY pmethodid ASC", cbopm, "pmethod", "pmethodid")
    End Sub

    Private Sub cbopm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbopm.SelectedIndexChanged

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()

    End Sub
End Class