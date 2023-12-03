Public Class frmeditemployee

  
    Private Sub frmeditemployee_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call connect()
        loadcombobox("SELECT lvl_id, level FROM position ORDER BY lvl_id ASC", cboposition, "level", "lvl_id")
        Dim myage As New Integer
        myage = DateTime.Today.Year - dtdob.Value.Year
        lblage.Text = myage - 1.ToString()
        lbluserdt.Text = Format(Today, "yyyy-MM-dd")
        dtdob.Format = DateTimePickerFormat.Custom
        dtdob.CustomFormat = "yyyy-MM-dd"
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim cmd As Odbc.OdbcCommand
        Dim sql As String
        Dim sql2 As String
        Dim datatable As New DataTable
        Dim key As String = "123"
            If txtlname.Text = "" Or txtfname.Text = "" Or dtdob.Text = "" Or txtusername.Text = "" Or txtpassword.Text = "" Or cboposition.Text = "" Then
                MsgBox("Insufficient Data", vbExclamation, "Information")
                Exit Sub

            ElseIf Trim(lblage.Text) <= 18 Then
                MsgBox("17 age below is not valid", vbInformation)
                Exit Sub
            ElseIf Len(Trim(lblage.Text)) > 101 Or Val(Trim(lblage.Text)) = 0 Then
                MsgBox("Invalid age", vbInformation)
                Exit Sub
        Else
            Try
                Call connect()

                If chkactive.CheckState = CheckState.Checked Then
                    sql = "UPDATE employee SET fname=?,mname=?,lname=?,dob=?,uname=?,password=?,lvl_id=?,date_in=?,isActive=? where empID =" & frmusers.dgv.Tag
                    cmd = New Odbc.OdbcCommand(sql, con)

                    With cmd.Parameters
                        .AddWithValue("?", txtfname.Text)
                        .AddWithValue("?", txtmi.Text)
                        .AddWithValue("?", txtlname.Text)
                        .AddWithValue("?", dtdob.Value)
                        .AddWithValue("?", txtusername.Text)
                        .AddWithValue("?", frmLogin.Encrypt(txtpassword.Text, key))
                        .AddWithValue("?", cboposition.SelectedValue)
                        .AddWithValue("?", lbluserdt.Text)
                        .AddWithValue("?", chkactive.Checked)
                        cmd.ExecuteNonQuery()
                        loadData("SELECT * FROM vwusers ORDER BY empID DESC", frmusers.dgv)
                        MsgBox("User updated Successfully! ", vbInformation + vbOKOnly, "INFORMATION")
                    End With
                Else
                    sql2 = "UPDATE employee SET isActive=0 where empID=" & frmusers.dgv.Tag
                    cmd = New Odbc.OdbcCommand(sql2, con)
                    With cmd.Parameters
                        '.AddWithValue("?", txtfname.Text)
                        '.AddWithValue("?", txtmi.Text)
                        '.AddWithValue("?", txtlname.Text)
                        '.AddWithValue("?", dtdob.Value)
                        '.AddWithValue("?", txtusername.Text)
                        '.AddWithValue("?", frmLogin.Encrypt(txtpassword.Text, key))
                        '.AddWithValue("?", cboposition.SelectedValue)
                        '.AddWithValue("?", lbluserdt.Text)
                        .AddWithValue("?", chkactive.Checked)
                        cmd.ExecuteNonQuery()
                        loadData("SELECT * FROM vwusers ORDER BY empID DESC", frmusers.dgv)
                        MsgBox("User disabled Successfully! ", vbInformation + vbOKOnly, "INFORMATION")
                    End With
                End If
            Catch ex As Exception

            End Try

            Modcon.loadData("SELECT * FROM vwusers ORDER BY empID DESC", frmusers.dgv)
            frmusers.Tag = ""
            Call clear()
            Me.Dispose()
        End If

        loadData("SELECT * FROM vwusers ORDER BY empID DESC", frmusers.dgv)
    End Sub
    Public Sub clear()
        txtfname.Clear()
        txtmi.Clear()
        txtlname.Clear()
        dtdob.Enabled = True
        txtusername.Clear()
        txtpassword.Clear()
        cboposition.Enabled = True
        ' chkactive.Enabled = True
        lblage.Text = ""

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()

    End Sub

    Private Sub dtdob_ValueChanged(sender As Object, e As EventArgs) Handles dtdob.ValueChanged
        Dim myage As New Integer
        myage = DateTime.Today.Year - dtdob.Value.Year
        lblage.Text = myage - 1.ToString()
    End Sub

    Private Sub pnladd_Paint(sender As Object, e As PaintEventArgs) Handles pnladd.Paint

    End Sub
End Class