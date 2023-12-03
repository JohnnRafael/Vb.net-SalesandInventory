Public Class frmEmployee

    Private Sub frmEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connect()
        loadData("select empID, CONCAT(lname, ', ', fname,' ',mname) Fullname, dob, lvl_id from employee", dgv)
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click

    End Sub
End Class