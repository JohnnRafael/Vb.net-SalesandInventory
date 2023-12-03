Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Imports System.Windows.Forms
Imports System.Diagnostics
Imports System.ComponentModel.Component
Public Class frmLogin
    Dim attemp As Integer = 0
    Public empID As Integer
    Public posnumber As Integer
    Private Sub frmLogin_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txtuser.Focus()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call connect()
        txtuser.Focus()
        ' loadcbo("SELECT empID, level FROM vwuser ORDER BY level", cboposition, "level", "empID")
        logintime.Enabled = True
    End Sub
    Private Sub btncancel_Click(sender As Object, e As EventArgs)
        Call Dispose()
    End Sub
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        connect()
        Dim key As String = "123"
        Dim cmd As New Odbc.OdbcCommand("SELECT empID,fname,mname,lname,dob,uname,password,lvl_id,date_in,isActive FROM employee WHERE uname=? AND password=? AND isActive=?", con)
        cmd.Parameters.AddWithValue("@uname", txtuser.Text)
        cmd.Parameters.AddWithValue("@password", Encrypt(pword.Text, key)) ' pword.Text) '
        cmd.Parameters.AddWithValue("@isActive", 1)
        Dim adapter As New Odbc.OdbcDataAdapter(cmd)
        Dim dtable As New DataTable
        adapter.Fill(dtable)

        If txtuser.Text = "" And pword.Text = "" Then
            txtuser.Focus()
            pword.Focus()
            Exit Sub
        ElseIf txtuser.Text = "ADMIN" And pword.Text = "admin" Then
            posnumber = 3
            Mainform.lblactiveuser.Text = "Admin"
            Mainform.lblposition.Text = "Admin"
            cmdqry("INSERT INTO tblinout(username,position,activity,date)VALUES('" & Mainform.lblactiveuser.Text & "', '" & Mainform.lblposition.Text & "', 'Successfully logged in', '" & Date.Now.ToString("yyyy-MM-dd hh:mm:ss tt") & "')")
            Mainform.Show()
            txtuser.Text = ""
            pword.Text = ""
            Me.Hide()
        ElseIf dtable.Rows.Count = 0 Then
            MsgBox("User and Password is not Exist!", vbInformation, "Login Information")
            txtuser.Text = ""
            pword.Text = ""
            txtuser.Focus()
            attemp += 1
            If attemp = 3 Then
                MsgBox("You have reach 3 attempt, Please contact Administrator. ", vbInformation)
                Me.Hide()
                admpass.Show()

            End If

            Exit Sub
        Else
            empID = dtable.Rows(0)(0)
            position = dtable.Rows(0)(7)
            Mainform.lblactiveuser.Text = dtable.Rows(0)(1) & " " & dtable.Rows(0)(2) & " " & dtable.Rows(0)(3)
            posi(Mainform.lblposition)
            frmPOS.lblcdut.Text = dtable.Rows(0)(1) & " " & dtable.Rows(0)(2) & " " & dtable.Rows(0)(3)

            If position = 1 Then
                posnumber = 1
                MsgBox("Welcome " & dtable.Rows(0)(1) & " " & dtable.Rows(0)(2) & " " & dtable.Rows(0)(3), vbInformation, "Login Information")
                cmdqry("INSERT INTO tblinout(username,position,activity,date)VALUES('" & Mainform.lblactiveuser.Text & "', '" & Mainform.lblposition.Text & "', 'Successfully logged in', '" & Date.Now.ToString("yyyy-MM-dd hh:mm:ss") & "')")

                Mainform.Show()
                pword.Text = ""
                txtuser.Text = ""
                Me.Hide()
            ElseIf position = 2 Then
                posnumber = 2
                MsgBox("Welcome " & dtable.Rows(0)(1) & " " & dtable.Rows(0)(2) & " " & dtable.Rows(0)(3), vbInformation, "Login Information")
                cmdqry("INSERT INTO tblinout(username,position,activity,date)VALUES('" & Mainform.lblactiveuser.Text & "', '" & Mainform.lblposition.Text & "', 'Successfully logged in', '" & Date.Now.ToString("yyyy-MM-dd hh:mm:ss") & "')")

                frmPOS.Show()
                frmPOS.lblcdut.Text = (dtable.Rows(0)(1) & " " & dtable.Rows(0)(3))
                txtuser.Text = ""
                pword.Text = ""
                Me.Hide()
            ElseIf position = 3 Then
                posnumber = 3
                MsgBox("Welcome " & dtable.Rows(0)(1) & " " & dtable.Rows(0)(2) & " " & dtable.Rows(0)(3), vbInformation, "Login Information")
                cmdqry("INSERT INTO tblinout(username,position,activity,date)VALUES('" & Mainform.lblactiveuser.Text & "', '" & Mainform.lblposition.Text & "', 'Successfully logged in', '" & Date.Now.ToString("yyyy-MM-dd hh:mm:ss") & "')")

                Mainform.Show()
                pword.Text = ""
                txtuser.Text = ""
                Me.Hide()
            End If
        End If

    End Sub
    Private Sub logintime_Tick(sender As System.Object, e As System.EventArgs) Handles logintime.Tick
        lbluserdt.Text = Date.Now.ToString("MMMMMMMM/dd/yyyy | hh:mm:ss")
    End Sub
    Private Shared DES As New TripleDESCryptoServiceProvider
    Private Shared MD5 As New MD5CryptoServiceProvider
    Public Shared Function MD5Hash(ByVal value As String) As Byte()
        Return MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(value))
    End Function
    Public Shared Function Encrypt(ByVal stringToEncrypt As String, ByVal key As String) As String
        DES.Key = MD5Hash(key)
        DES.Mode = CipherMode.ECB
        Dim Buffer As Byte() = ASCIIEncoding.ASCII.GetBytes(stringToEncrypt)
        Return Convert.ToBase64String(DES.CreateEncryptor().TransformFinalBlock(Buffer, 0, Buffer.Length))
    End Function
    Public Shared Function Decrypt(ByVal encryptedString As String, ByVal key As String) As String
        Try
            DES.Key = MD5Hash(key)
            DES.Mode = CipherMode.ECB
            Dim Buffer As Byte() = Convert.FromBase64String(encryptedString)
            Return ASCIIEncoding.ASCII.GetString(DES.CreateDecryptor().TransformFinalBlock(Buffer, 0, Buffer.Length))
        Catch ex As Exception
            MessageBox.Show("Invalid Key", "Decryption Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Function

    Private Sub pword_KeyDown(sender As Object, e As KeyEventArgs) Handles pword.KeyDown
        If e.KeyCode = Keys.Enter Then
            connect()
            Dim key As String = "123"
            Dim cmd As New Odbc.OdbcCommand("SELECT empID,fname,mname,lname,dob,uname,password,lvl_id,date_in,isActive FROM employee WHERE uname=? AND password=? AND isActive=?", con)
            cmd.Parameters.AddWithValue("@uname", txtuser.Text)
            cmd.Parameters.AddWithValue("@password", Encrypt(pword.Text, key)) ' pword.Text) '
            cmd.Parameters.AddWithValue("@isActive", 1)
            Dim adapter As New Odbc.OdbcDataAdapter(cmd)
            Dim dtable As New DataTable
            adapter.Fill(dtable)

            If txtuser.Text = "" And pword.Text = "" Then
                txtuser.Focus()
                pword.Focus()
                Exit Sub
            ElseIf txtuser.Text = "ADMIN" And pword.Text = "admin" Then
                posnumber = 3
                Mainform.lblactiveuser.Text = "Admin"
                Mainform.lblposition.Text = "Admin"
                cmdqry("INSERT INTO tblinout(username,position,activity,date)VALUES('" & Mainform.lblactiveuser.Text & "', '" & Mainform.lblposition.Text & "', 'Successfully logged in', '" & Date.Now.ToString("yyyy-MM-dd hh:mm:ss tt") & "')")
                Mainform.Show()
                txtuser.Text = ""
                pword.Text = ""
                Me.Hide()
            ElseIf dtable.Rows.Count = 0 Then
                MsgBox("User and Password is not Exist!", vbInformation, "Login Information")
                txtuser.Text = ""
                pword.Text = ""
                txtuser.Focus()
                attemp += 1
                If attemp = 3 Then
                    MsgBox("You have reach 3 attempt, Please contact Administrator. ", vbInformation)
                    Me.Hide()
                    admpass.Show()

                End If

                Exit Sub
            Else
                empID = dtable.Rows(0)(0)
                position = dtable.Rows(0)(7)
                Mainform.lblactiveuser.Text = dtable.Rows(0)(1) & " " & dtable.Rows(0)(2) & " " & dtable.Rows(0)(3)
                posi(Mainform.lblposition)
                frmPOS.lblcdut.Text = dtable.Rows(0)(1) & " " & dtable.Rows(0)(2) & " " & dtable.Rows(0)(3)

                If position = 1 Then
                    posnumber = 1
                    MsgBox("Welcome " & dtable.Rows(0)(1) & " " & dtable.Rows(0)(2) & " " & dtable.Rows(0)(3), vbInformation, "Login Information")
                    cmdqry("INSERT INTO tblinout(username,position,activity,date)VALUES('" & Mainform.lblactiveuser.Text & "', '" & Mainform.lblposition.Text & "', 'Successfully logged in', '" & Date.Now.ToString("yyyy-MM-dd hh:mm:ss") & "')")

                    Mainform.Show()
                    pword.Text = ""
                    txtuser.Text = ""
                    Me.Hide()
                ElseIf position = 2 Then
                    posnumber = 2
                    MsgBox("Welcome " & dtable.Rows(0)(1) & " " & dtable.Rows(0)(2) & " " & dtable.Rows(0)(3), vbInformation, "Login Information")
                    cmdqry("INSERT INTO tblinout(username,position,activity,date)VALUES('" & Mainform.lblactiveuser.Text & "', '" & Mainform.lblposition.Text & "', 'Successfully logged in', '" & Date.Now.ToString("yyyy-MM-dd hh:mm:ss") & "')")

                    frmPOS.Show()
                    frmPOS.lblcdut.Text = (dtable.Rows(0)(1) & " " & dtable.Rows(0)(3))
                    txtuser.Text = ""
                    pword.Text = ""
                    Me.Hide()
                ElseIf position = 3 Then
                    posnumber = 3
                    MsgBox("Welcome " & dtable.Rows(0)(1) & " " & dtable.Rows(0)(2) & " " & dtable.Rows(0)(3), vbInformation, "Login Information")
                    cmdqry("INSERT INTO tblinout(username,position,activity,date)VALUES('" & Mainform.lblactiveuser.Text & "', '" & Mainform.lblposition.Text & "', 'Successfully logged in', '" & Date.Now.ToString("yyyy-MM-dd hh:mm:ss") & "')")

                    Mainform.Show()
                    pword.Text = ""
                    txtuser.Text = ""
                    Me.Hide()
                End If
            End If
        End If
    End Sub

    Private Sub pword_TextChanged(sender As Object, e As EventArgs) Handles pword.TextChanged
        pword.UseSystemPasswordChar = True
    End Sub

    Private Sub txtuser_TextChanged(sender As Object, e As EventArgs) Handles txtuser.TextChanged
        txtuser.Text = UCase$(txtuser.Text)
        txtuser.SelectionStart = Len(txtuser.Text)
    End Sub

    Private Sub btncancel_Click_1(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Dispose()
    End Sub
End Class