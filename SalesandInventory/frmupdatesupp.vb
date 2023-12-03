Public Class frmupdatesupp

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim cmd As Odbc.OdbcCommand
        Dim sql As String
        Dim datatable As New DataTable
        If txtcname.Text = "" Or txtcontact.Text = "" Or txtemailadd.Text = "" Or txtstreet.Text = "" Or txtbrgy.Text = "" Or txtCity.Text = "" Then
            MsgBox("Please fill required Fields!", vbOKOnly + vbInformation, "Missing")

        Else
            Try
                Call connect()
                If Val(btnSave.Tag) = 0 Then

                    sql = "UPDATE supplier set sup_cname=?, contact=?, emailadd=?, house=?, brgy=?, city=? where sup_id=" & frmsupplier.dgv.Tag
                    cmd = New Odbc.OdbcCommand(sql, con)
                    With cmd
                        .Parameters.AddWithValue("?", txtcname.Text)
                        .Parameters.AddWithValue("?", txtcontact.Text)
                        .Parameters.AddWithValue("?", txtemailadd.Text)
                        .Parameters.AddWithValue("?", txtstreet.Text)
                        .Parameters.AddWithValue("?", txtbrgy.Text)
                        .Parameters.AddWithValue("?", txtCity.Text)
                        .ExecuteNonQuery()
                        Call loadData("SELECT sup_id, sup_cname, contact, emailadd, CONCAT(house, ', ', brgy,' ',city) Address FROM supplier ORDER BY sup_id DESC", frmsupplier.dgv)
                    End With
                    MsgBox("SUPPLIER HAS BEEN UPDATED SUCCESSFULLY!", vbOKOnly + vbInformation, "Information")
                    Me.Dispose()
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

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

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

    Private Sub pnladd_Paint(sender As Object, e As PaintEventArgs) Handles pnladd.Paint

    End Sub

    Private Sub txtemailadd_TextChanged(sender As Object, e As EventArgs) Handles txtemailadd.TextChanged
        txtemailadd.Text = UCase(txtemailadd.Text)
    End Sub

    Private Sub txtcname_TextChanged(sender As Object, e As EventArgs) Handles txtcname.TextChanged
        txtcname.Text = UCase(txtcname.Text)
    End Sub

    Private Sub txtstreet_TextChanged(sender As Object, e As EventArgs) Handles txtstreet.TextChanged
        txtstreet.Text = UCase(txtstreet.Text)
    End Sub

    Private Sub txtbrgy_TextChanged(sender As Object, e As EventArgs) Handles txtbrgy.TextChanged
        txtbrgy.Text = UCase(txtbrgy.Text)
    End Sub

    Private Sub txtcity_TextChanged(sender As Object, e As EventArgs) Handles txtcity.TextChanged
        txtcity.Text = UCase(txtcity.Text)
    End Sub
End Class