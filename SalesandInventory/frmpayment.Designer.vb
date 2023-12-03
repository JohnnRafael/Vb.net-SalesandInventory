<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmpayment))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn3mo = New System.Windows.Forms.Button()
        Me.btnfull = New System.Windows.Forms.Button()
        Me.btn50 = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.btnclose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Controls.Add(Me.btnclose)
        Me.Panel1.Controls.Add(Me.btn3mo)
        Me.Panel1.Controls.Add(Me.btnfull)
        Me.Panel1.Controls.Add(Me.btn50)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(468, 150)
        Me.Panel1.TabIndex = 0
        '
        'btn3mo
        '
        Me.btn3mo.Location = New System.Drawing.Point(163, 90)
        Me.btn3mo.Name = "btn3mo"
        Me.btn3mo.Size = New System.Drawing.Size(153, 52)
        Me.btn3mo.TabIndex = 2
        Me.btn3mo.Text = "3 Months to Pay"
        Me.btn3mo.UseVisualStyleBackColor = True
        Me.btn3mo.Visible = False
        '
        'btnfull
        '
        Me.btnfull.Location = New System.Drawing.Point(255, 42)
        Me.btnfull.Name = "btnfull"
        Me.btnfull.Size = New System.Drawing.Size(153, 52)
        Me.btnfull.TabIndex = 1
        Me.btnfull.Text = "Full Pay"
        Me.btnfull.UseVisualStyleBackColor = True
        '
        'btn50
        '
        Me.btn50.Location = New System.Drawing.Point(62, 42)
        Me.btn50.Name = "btn50"
        Me.btn50.Size = New System.Drawing.Size(153, 52)
        Me.btn50.TabIndex = 0
        Me.btn50.Text = "50% Down Payment"
        Me.btn50.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.BackgroundImage = CType(resources.GetObject("btnclose.BackgroundImage"), System.Drawing.Image)
        Me.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnclose.Location = New System.Drawing.Point(443, 0)
        Me.btnclose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(25, 25)
        Me.btnclose.TabIndex = 100
        Me.btnclose.TabStop = False
        '
        'frmpayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 150)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmpayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmpayment"
        Me.Panel1.ResumeLayout(False)
        CType(Me.btnclose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn3mo As System.Windows.Forms.Button
    Friend WithEvents btnfull As System.Windows.Forms.Button
    Friend WithEvents btn50 As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.PictureBox
End Class
