<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RestoreBackupDb
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestoreBackupDb))
        Me.pnlitem = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnclose = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnbackup = New System.Windows.Forms.Button()
        Me.btnrestore = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.pnlitem.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.btnclose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlitem
        '
        Me.pnlitem.BackColor = System.Drawing.Color.Honeydew
        Me.pnlitem.Controls.Add(Me.Panel1)
        Me.pnlitem.Controls.Add(Me.Label1)
        Me.pnlitem.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlitem.Location = New System.Drawing.Point(0, 0)
        Me.pnlitem.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.pnlitem.Name = "pnlitem"
        Me.pnlitem.Size = New System.Drawing.Size(495, 44)
        Me.pnlitem.TabIndex = 104
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnclose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(448, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(47, 44)
        Me.Panel1.TabIndex = 100
        '
        'btnclose
        '
        Me.btnclose.BackgroundImage = CType(resources.GetObject("btnclose.BackgroundImage"), System.Drawing.Image)
        Me.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnclose.Location = New System.Drawing.Point(16, 4)
        Me.btnclose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(25, 25)
        Me.btnclose.TabIndex = 99
        Me.btnclose.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(125, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 22)
        Me.Label1.TabIndex = 98
        Me.Label1.Text = "BACK-UP AND RESTORE"
        '
        'btnbackup
        '
        Me.btnbackup.Location = New System.Drawing.Point(45, 84)
        Me.btnbackup.Name = "btnbackup"
        Me.btnbackup.Size = New System.Drawing.Size(181, 71)
        Me.btnbackup.TabIndex = 105
        Me.btnbackup.Text = "BACKUP"
        Me.btnbackup.UseVisualStyleBackColor = True
        '
        'btnrestore
        '
        Me.btnrestore.Location = New System.Drawing.Point(272, 84)
        Me.btnrestore.Name = "btnrestore"
        Me.btnrestore.Size = New System.Drawing.Size(181, 71)
        Me.btnrestore.TabIndex = 106
        Me.btnrestore.Text = "RESTORE"
        Me.btnrestore.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Backup Files (*.Bak)|*.bak"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FolderBrowserDialog1
        '
        '
        'RestoreBackupDb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(495, 222)
        Me.Controls.Add(Me.btnrestore)
        Me.Controls.Add(Me.btnbackup)
        Me.Controls.Add(Me.pnlitem)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "RestoreBackupDb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RestoreBackupDb"
        Me.pnlitem.ResumeLayout(False)
        Me.pnlitem.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.btnclose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlitem As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnclose As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnbackup As System.Windows.Forms.Button
    Friend WithEvents btnrestore As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
End Class
