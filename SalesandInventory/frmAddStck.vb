Public Class frmAddStck

    Private Sub txtqty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtqty.KeyPress
        If (e.KeyChar.ToString = "") And (txtqty.Text.Contains(e.KeyChar.ToString)) Then
            e.Handled = True
        End If
        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8
                e.KeyChar = e.KeyChar
            Case Else
                e.KeyChar = ""
        End Select
    End Sub
    Private Sub txtqty_TextChanged(sender As Object, e As EventArgs) Handles txtqty.TextChanged

        txtqty.Focus()

    End Sub

    Private Sub txtqty_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqty.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtqty.Text = "" Then
                MsgBox("Please Enter Quantity", vbInformation, "Information")
                Exit Sub
            Else
                If txtqty.Text < 0 Then
                    MsgBox("Invalid Quantity", vbInformation, "")
                Else
                    Try
                        connect()
                        Dim cmd As Odbc.OdbcCommand
                        cmd = New Odbc.OdbcCommand("UPDATE stocks SET quantity=quantity+? WHERE stockid=" & frmInventory.dgv.Tag, con)
                        cmd.Parameters.AddWithValue("?", Val(Me.txtqty.Text))
                        cmd.ExecuteNonQuery()
                        loadData("SELECT stockid, itemcode, itemtype, description, price, UnitP,quantity FROM vw_inv ORDER BY stockid DESC", frmInventory.dgv)
                        Me.Dispose()

                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            End If
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class