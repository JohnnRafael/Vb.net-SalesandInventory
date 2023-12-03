Public Class returnfromclient

  
    Private Sub returnfromclient_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadData("SELECT * FROM vw_returnfromclient1 ORDER BY returnid DESC", dgv)
    End Sub
End Class