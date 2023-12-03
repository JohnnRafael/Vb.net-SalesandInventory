Public Class frmpqty

    Private Sub frmPqty_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtqty.Focus()
    End Sub
    Private Sub btnqexit_Click(sender As System.Object, e As System.EventArgs)
        Me.Dispose()
    End Sub

    Public Sub EnterQty()
        Try

        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtqty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        filternum(e.KeyChar)
    End Sub

    Private Sub txtqty_KeyDown1(sender As Object, e As KeyEventArgs) Handles txtqty.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtqty.Text = "" Then
                MsgBox("Please Enter Quantity", vbInformation, "")
                Exit Sub
            Else
                For y = 0 To frmPOS.dgvItem.RowCount - 1
                    connect()
                    Dim da As New Odbc.OdbcDataAdapter("SELECT * FROM vw_selectitem WHERE stockid =" & frmPOS.dgvItem.Item(0, frmPOS.dgvItem.CurrentRow.Index).Value, con)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    If frmPOS.dgvItem.Enabled = True Then
                        If frmPOS.dgvItem.Item(0, y).Value = dt.Rows(0)(0) Then
                            Dim quantity As Integer = frmPOS.dgvItem.Item(5, y).Value
                            Dim stocks As Integer = dt.Rows(0)(5) - quantity
                            If txtqty.Text = 0 Then
                                MsgBox("Invalid Quantity Value!", vbCritical, "")
                                txtqty.Text = ""
                                txtqty.Focus()
                                Exit Sub
                            ElseIf Val(txtqty.Text) > stocks Then
                                MsgBox("Insufficient Stocks! The remaining stocks is only'" & Val(dt.Rows(0)(5)) & "'", vbCritical, "")
                                txtqty.Text = ""
                                txtqty.Focus()
                                Exit Sub
                            Else
                                Try
                                    connect()
                                    Dim cmd2 As Odbc.OdbcCommand
                                    cmd2 = New Odbc.OdbcCommand("UPDATE temp_transaction SET qty=qty+? WHERE transId=" & frmPOS.dgvItem.Item(7, frmPOS.dgvItem.CurrentRow.Index).Value, con)
                                    cmd2.Parameters.AddWithValue("?", Val(Me.txtqty.Text))
                                    cmd2.ExecuteNonQuery()
                                    loaddgvv("SELECT * FROM vwtransaction WHERE status=0", frmPOS.dgvItem)
                                    'loaddgv("SELECT totalstockID, prodID, barcode, item_desc, price, qty, totalPrice, transId, ornum, status FROM viwtransaction ORDER BY totalstockID DESC", frmPOS.dgvItem)
                                    frmPOS.btnQty.BackColor = Color.White
                                    Me.Dispose()
                                    frmPOS.dgvItem.ClearSelection()
                                    frmPOS.dgvItem.Enabled = False
                                Catch ex As Exception
                                End Try
                            End If
                        End If
                    End If
                Next
            End If
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Dispose()
            frmPOS.btnQty.BackColor = Color.White
        End If
    End Sub

    Private Sub txtqty_TextChanged(sender As Object, e As EventArgs) Handles txtqty.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class