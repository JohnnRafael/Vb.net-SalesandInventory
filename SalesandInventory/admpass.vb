Public Class admpass

    Private Sub admpass_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F10 Then
            Me.Close()
            Dim LoginForm1 As New frmLogin
            LoginForm1.ShowDialog()

        End If
    End Sub

End Class