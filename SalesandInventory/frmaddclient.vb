Public Class frmaddclient

    Private transaction As New transaction
    Private Sub frmaddclient_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblclient.Text = DateTimePicker1.Text + transaction.getclientNo
        lblclientid.Text = transaction.auto 'id in table transaction
        lblclientno.Text = transaction.getclientNo
        Call connect()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtfname.Text = "" Or txtlname.Text = "" Or txtstreet.Text = "" Or txtbrgy.Text = "" Or txtcity.Text = "" Or txtcontactno.Text = "" Or txtemail.Text = "" Then
            MsgBox("Please fill required Fields!", vbOKOnly + vbInformation, "Missing")
        Else
            Try
                Call connect()
                If Val(btnSave.Tag) = 0 Then

                    Dim cmd As Odbc.OdbcCommand
                    Dim sql As String
                    sql = "INSERT INTO client(Iddetails, lname, fname, mi, pmethod, street, brgy, city, contactno, emailadd, status) values (?,?,?,?,?,?,?,?,?,?,?)"
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
                    MsgBox("NEW CLIENT HAS BEEN ADDED SUCCESSFULLY!", vbOKOnly + vbInformation, "Information")
                    'frmItems.dgv.Tag = ""
                    Me.Dispose()

                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        'loadData("select custID, Iddetails, CONCAT(lname, ', ', fname,' ',mi) clientname, CONCAT(street, ', ', brgy,' ',city) address, contactno, emailadd from client", frmclient.dgv)
    End Sub

    Private Sub txtlname_TextChanged(sender As Object, e As EventArgs) Handles txtlname.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub cbopm_Click(sender As Object, e As EventArgs) Handles cbopm.Click
        loadcombobox("SELECT pmethodid, pmethod FROM clientpay ORDER BY pmethodid ASC", cbopm, "pmethod", "pmethodid")
    End Sub

    Private Sub cbopm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbopm.SelectedIndexChanged
        'loadcombobox("SELECT pmethodid, pmethod FROM clientpay ORDER BY pmethodid ASC", cbopm, "pmethos", "pmethodid")
    End Sub

    Private Sub txtcontactno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcontactno.KeyPress
        filternum(e.KeyChar)
    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click

    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class