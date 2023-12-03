Public Class frmaddemployee
    Private Sub dtdob_ValueChanged(sender As Object, e As EventArgs) Handles dtdob.ValueChanged
        Dim myage As New Integer
        myage = DateTime.Today.Year - dtdob.Value.Year
        lblage.Text = myage - 1.ToString()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub cboposition_Click(sender As Object, e As EventArgs) Handles cboposition.Click
        Call connect()
        loadcombobox("SELECT lvl_id, level FROM position ORDER BY lvl_id ASC", cboposition, "level", "lvl_id")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            connect()
            Dim sql As String
            Dim key As String = "123"
            Dim cmd As Odbc.OdbcCommand
            Dim dt As New DataTable
            Dim da As New Odbc.OdbcDataAdapter
            cmd = New Odbc.OdbcCommand("SELECT * FROM employee WHERE lname=?", con)
            With cmd.Parameters
                .AddWithValue("?", txtfname.Text)
                .AddWithValue("?", txtmi.Text)
                .AddWithValue("?", txtlname.Text)
                .AddWithValue("?", dtdob.Text)
                .AddWithValue("?", txtusername.Text)
                .AddWithValue("?", encryptpass(txtpassword.Text)) 'txtpassword.Text)
                .AddWithValue("?", cboposition.Text)
                .AddWithValue("?", lbluserdt.Text)
                .AddWithValue("?", chkactive.Checked)
            End With
            da = New Odbc.OdbcDataAdapter(cmd)
            da.Fill(dt)
            If txtlname.Text = "" Or txtfname.Text = "" Or dtdob.Text = "" Or txtusername.Text = "" Or txtpassword.Text = "" Or cboposition.Text = "" Then
                MsgBox("Insufficient Data", vbExclamation, "Information")
                Exit Sub

            ElseIf Trim(lblage.Text) <= 18 Then
                MsgBox("17 age below is not valid", vbInformation)
                dtdob.Focus()
                Exit Sub
            ElseIf Len(Trim(lblage.Text)) > 101 Or Val(Trim(lblage.Text)) = 0 Then
                MsgBox("Invalid age", vbInformation)
                dtdob.Focus()
                Exit Sub
            ElseIf Val(txtpass1.Text) <= 8 And Val(txtpassword.Text) <= 8 Then
                MsgBox("Password Must be 8-10 characters long!", vbExclamation, "Password")
                txtpass1.Clear()
                txtpass1.Focus()
                txtpassword.Clear()
                Exit Sub
            ElseIf txtpass1.Text <> txtpassword.Text Then
                MsgBox("Password did'nt Match!", vbExclamation, "Password")
                txtpass1.Clear()
                txtpass1.Focus()
                txtpassword.Clear()
                Exit Sub
            Else
                If Val(frmusers.dgv.Tag) = 0 Then
                    If dt.Rows.Count = 1 Then
                        MsgBox("Already Exist!", vbInformation, "Information")
                        Exit Sub
                        loadData("SELECT * FROM vwusers ORDER BY empID DESC", frmusers.dgv)
                        Call clear()
                    End If

                    sql = "INSERT INTO employee(fname,mname,lname,dob,uname,password,lvl_id,date_in,isActive) VALUES (?,?,?,?,?,?,?,?,?)"
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
                        MsgBox("USER SAVE Successfully! ", vbInformation + vbOKOnly, "INFORMATION")
                    End With

                End If
            End If
            Modcon.loadData("SELECT * FROM vwusers ORDER BY empID DESC", frmusers.dgv)
            frmusers.Tag = ""
            Call clear()
            Me.Dispose()
        Catch ex As Exception
            MsgBox("ERROR:" & ex.Message)
        End Try
        loadData("SELECT * FROM vwusers ORDER BY empID DESC", frmusers.dgv)
    End Sub

    Private Sub txtusername_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged
        txtusername.Text = UCase$(txtusername.Text)
        txtusername.SelectionStart = Len(txtusername.Text)
    End Sub

    Private Sub frmaddemployee_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call connect()
        loadData("SELECT * FROM vwusers ORDER BY empID DESC", frmusers.dgv)
        lbluserdt.Text = Format(Today, "yyyy-MM-dd")
        dtdob.Format = DateTimePickerFormat.Custom
        dtdob.CustomFormat = "yyyy-MM-dd"
        frmusers.dgv.Tag = ""
        txtpass1.MaxLength = 10
        txtpassword.MaxLength = 10
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

    Private Sub cboposition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboposition.SelectedIndexChanged

    End Sub

    Private Sub pnladd_Paint(sender As Object, e As PaintEventArgs) Handles pnladd.Paint

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class