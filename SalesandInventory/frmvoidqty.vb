Public Class frmvoidqty
    Private void As New Void
    Private trans As New transaction
    Private Sub frmvoidqty_Load(sender As Object, e As EventArgs) Handles Me.Load

        txtvoid.Focus()
    End Sub

    Private Sub txtvoid_KeyDown(sender As Object, e As KeyEventArgs) Handles txtvoid.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Val(txtvoid.Text) > frmPOS.dgvItem.Item(5, frmPOS.dgvItem.CurrentRow.Index).Value Then
                MsgBox("Warning the void quantity is out of range", vbCritical, "")
                txtvoid.Text = ""
                txtvoid.Focus()
                Exit Sub
            ElseIf txtvoid.Text = 0 Then
                MsgBox("Invalid void quantity", vbInformation, "")
                txtvoid.Text = ""
                txtvoid.Focus()
                Exit Sub
            Else
                If frmPOS.dgvItem.Item(5, frmPOS.dgvItem.CurrentRow.Index).Value = 1 Or frmPOS.dgvItem.Item(5, frmPOS.dgvItem.CurrentRow.Index).Value = Val(txtvoid.Text) Then
                    If MsgBox("Are you sure you want to void this item?", vbQuestion + vbYesNo) = vbYes Then
                        void.deleteItem()
                        void.fetchVoidInfo()
                        If void.db.Rows.Count = 0 Then
                            Call void.deleteTransaction("DELETE from temp_transaction WHERE transId=?")
                        Else
                            void.voidId = void.db.Rows(0)(0)
                            void.updatevoid("UPDATE void SET qty=qty+?qty, totalprice=?totprice WHERE voidID=?id", Val(Me.txtvoid.Text))
                            void.deleteTransaction("DELETE FROM temp_transaction WHERE transId=?")
                        End If
                        loaddgvv("SELECT * FROM vwtransaction", frmPOS.dgvItem)
                        frmPOS.dgvItem.ClearSelection()
                        '  frmPOS.txttypeitemcode.Focus()
                        Me.Dispose()
                        frmPOS.dgvItem.Enabled = False
                        frmPOS.btnvoidtrans.BackColor = Color.White
                    End If
                ElseIf MsgBox("Are you sure you want to reduce this Item?", vbQuestion + vbYesNo) = vbYes Then
                    void.minusItem()
                    loaddgvv("SELECT * FROM vwtransaction", frmPOS.dgvItem)
                    Call trans.totalPrice()

                    Me.Dispose()
                    '  frmPOS.txttypeitemcode.Focus()
                    frmPOS.dgvItem.ClearSelection()
                    frmPOS.dgvItem.Enabled = False
                    frmPOS.btnvoidtrans.BackColor = Color.White

                End If
            End If
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Dispose()


        End If
    End Sub

    Private Sub txtvoid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtvoid.KeyPress
        filternum(e.KeyChar)
    End Sub

    Private Sub txtvoid_TextChanged(sender As Object, e As EventArgs) Handles txtvoid.TextChanged

    End Sub
End Class