Public Class frmusers

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmaddemployee.ShowDialog()
    End Sub

    Private Sub frmusers_Load(sender As Object, e As EventArgs) Handles Me.Load
        connect()
        loadData("SELECT empID,fullname,dob,uname,password,level,date_in, isActive FROM vwusers", dgv) ' ORDER BY empID DESC
        Timer1.Enabled = True
        dgv.Tag = ""
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.ControlBox = False
        Me.AutoSize = False
    End Sub

    Public Sub fetchuser(ByVal id As Long)
        connect()
        Dim da As Odbc.OdbcDataAdapter
        Dim dt As New DataTable
        da = New Odbc.OdbcDataAdapter("SELECT * FROM vw_emps WHERE empID=" & dgv.Tag, con)
        da.Fill(dt)
        With frmeditemployee
            .txtfname.Text = dt.Rows(0)(1)
            .txtmi.Text = dt.Rows(0)(2)
            .txtlname.Text = dt.Rows(0)(3)
            .dtdob.Value = dt.Rows(0)(4)
            .txtusername.Text = dt.Rows(0)(5)
            .txtpassword.Text = dt.Rows(0)(6)
            .cboposition.Text = dt.Rows(0)(8)
            .lbluserdt.Text = dt.Rows(0)(9)
            .chkactive.Checked = dt.Rows(0)(10)
        End With
        frmeditemployee.Show()
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        If e.RowIndex >= 0 Then
            dgv.Tag = dgv.Item(0, e.RowIndex).Value

        Else
            MsgBox("NO RECORD SELECTED!")
        End If
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        If Len(dgv.Tag) = 0 Then
            MsgBox("Please select a User Information", MsgBoxStyle.Information, "Information")
        Else
            If MsgBox("Do you want to edit this User information??", MsgBoxStyle.Question + vbYesNo, "User") = vbYes Then
                Call fetchuser(Val(dgv.Tag))
            End If
        End If
    End Sub
End Class