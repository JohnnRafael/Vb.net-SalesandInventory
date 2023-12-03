Public Class frmedititemtype

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim cmd As Odbc.OdbcCommand
        Dim sql As String
        Dim datatable As New DataTable
        If txtitemtype.Text = "" Then
            MsgBox("Please fill required Fields!", vbOKOnly + vbInformation, "Missing")
        Else
            Try
                Call connect()
                If Val(btnSave.Tag) = 0 Then

                    sql = "UPDATE itemtype set itemtype=? where typeid=" & frmitemtype.dgv.Tag
                    cmd = New Odbc.OdbcCommand(sql, con)
                    With cmd
                        .Parameters.AddWithValue("?", txtitemtype.Text)

                        .Parameters.AddWithValue("?", Val(btnSave.Tag))
                        .ExecuteNonQuery()

                        Call loadData("SELECT stockid, itemcode, itemtype, description,price, UnitP,quantity FROM vw_inv ORDER BY stockid DESC", frmInventory.dgv)
                    End With
                    MsgBox("ITEM HAS BEEN UPDATED SUCCESSFULLY!", vbOKOnly + vbInformation, "Information")
                    Me.Close()
                    Call CLEANER()

                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
        Call loadData("select * from itemtype order by typeid", frmitemtype.dgv)
    End Sub
    Sub cleaner()
        txtitemtype.Text = ""
    End Sub
End Class