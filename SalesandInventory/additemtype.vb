Public Class additemtype

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim cmd2 As Odbc.OdbcCommand
        Dim adapt As Odbc.OdbcDataAdapter
        Dim datatable As New DataTable
        cmd2 = New Odbc.OdbcCommand("SELECT itemType FROM itemtype WHERE itemType=?", con)
        With cmd2.Parameters
            .AddWithValue("@itemtype", Trim(txtitemtype.Text))
        End With
        adapt = New Odbc.OdbcDataAdapter(cmd2)
        adapt.Fill(datatable)
        If txtitemtype.Text = "" Then
            MsgBox("Please fill required Fields!", vbOKOnly + vbInformation, "Missing")
        Else
            Try
                Call connect()
                If Val(btnSave.Tag) = 0 Then
                    If datatable.Rows.Count = 1 Then
                        MsgBox("This product is already existed.", vbInformation, "Information")
                        Exit Sub
                    Else
                        Dim cmd As Odbc.OdbcCommand
                        Dim sql As String
                        sql = "INSERT INTO itemtype(Itemtype) values (?)"
                        cmd = New Odbc.OdbcCommand(sql, con)
                        With cmd
                            .Parameters.AddWithValue("?", txtitemtype.Text)
                            cmd.ExecuteNonQuery()
                            Call loadData("Select * From itemtype", frmitemtype.dgv)
                        End With
                        MsgBox("NEW ITEMTYPE HAS BEEN ADDED SUCCESSFULLY!", vbOKOnly + vbInformation, "Information")
                        Me.Dispose()
                    End If

                End If
            Catch ex As Exception
            End Try
        End If
        Call loadData("Select * From itemtype", frmitemtype.dgv)
        Call loadData("Select * from vw_prod", frmItems.dgv)

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub
End Class