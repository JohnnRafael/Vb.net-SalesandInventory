Public Class frmpayment
    Private Sub btnfull_Click(sender As Object, e As EventArgs) Handles btnfull.Click
        frmPOSfullypaid.ShowDialog()
        Me.Dispose()
    End Sub

    Private Sub btn50_Click(sender As Object, e As EventArgs) Handles btn50.Click
        frmPOS50.ShowDialog()
        Me.Dispose()
    End Sub


    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Dispose()

    End Sub
End Class