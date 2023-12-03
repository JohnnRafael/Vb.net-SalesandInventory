Public Class frmsuppadd


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim cmd2 As Odbc.OdbcCommand
        Dim adapt As Odbc.OdbcDataAdapter
        Dim datatable As New DataTable
        cmd2 = New Odbc.OdbcCommand("SELECT sup_cname, contact FROM supplier WHERE sup_cname=? AND contact=?", con)
        With cmd2.Parameters
            .AddWithValue("@sup_cname", Trim(txtcname.Text))
            .AddWithValue("@emailadd", Trim(txtemailadd.Text))
        End With
        adapt = New Odbc.OdbcDataAdapter(cmd2)
        adapt.Fill(datatable)
        If txtcname.Text = "" Or txtcontact.Text = "" Or txtemailadd.Text = "" Or txtstreet.Text = "" Or txtbrgy.Text = "" Or txtCity.Text = "" Then
            MsgBox("Please fill required Fields!", vbOKOnly + vbInformation, "Missing")

        Else
            Try
                Call connect()
                If Val(btnSave.Tag) = 0 Then
                    If datatable.Rows.Count = 1 Then
                        MsgBox("This Supplier is already existed.", vbInformation, "Information")
                        Exit Sub
                    Else
                        Dim cmd As Odbc.OdbcCommand
                        Dim sql As String
                        sql = "INSERT INTO supplier(sup_cname, contact, emailadd, house, brgy, city) values (?,?,?,?,?,?)"
                        cmd = New Odbc.OdbcCommand(sql, con)
                        With cmd
                            .Parameters.AddWithValue("?", txtcname.Text)
                            .Parameters.AddWithValue("?", txtcontact.Text)
                            .Parameters.AddWithValue("?", txtemailadd.Text)
                            .Parameters.AddWithValue("?", txtstreet.Text)
                            .Parameters.AddWithValue("?", txtbrgy.Text)
                            .Parameters.AddWithValue("?", txtCity.Text)
                            cmd.ExecuteNonQuery()
                            'saveQuantityItem()
                            'Call loadData("select * from supplier", dgv)
                            Call loadData("SELECT sup_id, sup_cname, contact, emailadd, CONCAT(house, ', ', brgy,' ',city) Address FROM supplier ORDER BY sup_id DESC", frmsupplier.dgv)
                        End With
                        MsgBox("NEW SUPPLIER HAS BEEN ADDED SUCCESSFULLY!", vbOKOnly + vbInformation, "Information")
                        'frmItems.dgv.Tag = ""
                        Me.Dispose()
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        Call loadData("SELECT sup_id, sup_cname, contact, emailadd, CONCAT(house, ', ', brgy,' ',city) Address FROM supplier ORDER BY sup_id ASC", frmsupplier.dgv)

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MsgBox("Cancel?", vbYesNo + vbQuestion, "Cancel") = vbYes Then
            Me.Dispose()
        Else
        End If
    End Sub

    Private Sub frmsuppadd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtcname.Focus()

    End Sub


    Private Sub txtcname_TextChanged_1(sender As Object, e As EventArgs) Handles txtcname.TextChanged
        txtcname.Text = UCase(txtcname.Text)
    End Sub

    Private Sub txtcontact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcontact.KeyPress
        If (e.KeyChar.ToString = "") And (txtcontact.Text.Contains(e.KeyChar.ToString)) Then
            e.Handled = True
        End If
        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8
                e.KeyChar = e.KeyChar
            Case Else
                e.KeyChar = ""
        End Select
    End Sub





    Private Sub txtemailadd_TextChanged_1(sender As Object, e As EventArgs) Handles txtemailadd.TextChanged
        txtemailadd.Text = UCase(txtemailadd.Text)
    End Sub

    Private Sub txtcity_TextChanged(sender As Object, e As EventArgs) Handles txtcity.TextChanged
        txtcity.Text = UCase(txtcity.Text)
    End Sub

    Private Sub txtbrgy_TextChanged(sender As Object, e As EventArgs) Handles txtbrgy.TextChanged
        txtbrgy.Text = UCase(txtbrgy.Text)
    End Sub

    Private Sub txtstreet_TextChanged_1(sender As Object, e As EventArgs) Handles txtstreet.TextChanged
        txtstreet.Text = UCase(txtstreet.Text)
    End Sub
End Class