Imports System.IO
Public Class RestoreBackupDb
    Dim Path As String
    Dim BackupPath As String
    Dim dbname As String
    Dim DatabaseName As String = "Backup-" + Date.Now.ToString("dd-MM-yyyy-HH-mm-ss")
    Sub Restore()
        Dim myprocess As New Process
        myprocess.StartInfo.FileName = "cmd.exe"
        myprocess.StartInfo.UseShellExecute = False
        myprocess.StartInfo.WorkingDirectory = "C:\xampp\mysql\bin"
        myprocess.StartInfo.RedirectStandardInput = True
        myprocess.StartInfo.RedirectStandardOutput = True
        myprocess.Start()
        Dim myStreamerWriter As StreamWriter = myprocess.StandardInput
        Dim myStreamerReader As StreamReader = myprocess.StandardOutput
        myStreamerWriter.WriteLine("mysql -u root  salesandinventory < " & Path & "")
        myStreamerWriter.Close()
        myprocess.WaitForExit()
        myprocess.Close()
    End Sub
    Sub Backup()
        Try
            If Not Directory.Exists(BackupPath) Then
                Directory.CreateDirectory(BackupPath)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'WAMP Server
        'Process.Start("C:\wamp64\bin\mysql\mysql5.7.14\bin\mysqldump.exe", "-u root skripsi -r """ & BackupPath & "" & DatabaseName & ".sql""")

        'XAMPP SERVER
        Process.Start("C:\xampp\mysql\bin\mysqldump.exe", "-u root salesandinventory -r""" & BackupPath & "" & DatabaseName & ".sql""")
        'Process.Start("cmd.exe", "/k cd C:\xampp\mysql\bin" + "mysqldump -u root salesandinventory > D:\salesandinventory.sql")
        'Process.Start("C:\xampp\mysql\bin\mysqldump.exe", "-u root salesandinventory > D:\dbbackup.sql")

        ' mysqldump -u root salesandinventory > D:\salesandinventory.sql

        'MySQL 8.0 Above
        ' Process.Start("C:\xampp\mysql\bin\mysqldump.exe", "--replace --column-statistics=0 -u root -proot --databases salesandinventory -r """ & BackupPath & "" & DatabaseName & ".sql""")

    End Sub


    Private Sub btnbackup_Click_1(sender As Object, e As EventArgs) Handles btnbackup.Click
        If MsgBox("Are you sure do you want to backup?", vbQuestion + vbYesNo) = vbYes Then
            FolderBrowserDialog1.ShowDialog()
            BackupPath = FolderBrowserDialog1.SelectedPath.ToString() + "\"
            Backup()
        End If
      
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnrestore.Click
        OpenFileDialog1.Title = "Please Select a File"
        OpenFileDialog1.InitialDirectory = "C:\"
        OpenFileDialog1.ShowDialog()
        'SaveFileDialog1.ShowDialog()
        'Restore()
        ' MsgBox("Database Restoration Successfully!", MsgBoxStyle.Information, "Restore")
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Dispose()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Path = OpenFileDialog1.FileName.ToString()
        Restore()
        MsgBox("Database Restoration Successfully!", MsgBoxStyle.Information, "Restore")
    End Sub

    Private Sub FolderBrowserDialog1_HelpRequest(sender As Object, e As EventArgs) Handles FolderBrowserDialog1.HelpRequest

    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk

    End Sub
End Class