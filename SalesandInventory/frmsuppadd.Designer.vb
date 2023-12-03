<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsuppadd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmsuppadd))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblitemID = New System.Windows.Forms.Label()
        Me.pnladd = New System.Windows.Forms.Panel()
        Me.txtcity = New System.Windows.Forms.TextBox()
        Me.txtbrgy = New System.Windows.Forms.TextBox()
        Me.txtstreet = New System.Windows.Forms.TextBox()
        Me.txtemailadd = New System.Windows.Forms.TextBox()
        Me.txtcname = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcontact = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnladd.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Honeydew
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(527, 54)
        Me.Panel3.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add New"
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(419, 4)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 51)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Ca&ncel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(316, 4)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(96, 51)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "&Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Honeydew
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.lblitemID)
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 313)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(527, 63)
        Me.Panel2.TabIndex = 9
        '
        'lblitemID
        '
        Me.lblitemID.AutoSize = True
        Me.lblitemID.Location = New System.Drawing.Point(17, 19)
        Me.lblitemID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblitemID.Name = "lblitemID"
        Me.lblitemID.Size = New System.Drawing.Size(0, 26)
        Me.lblitemID.TabIndex = 33
        Me.lblitemID.Visible = False
        '
        'pnladd
        '
        Me.pnladd.BackColor = System.Drawing.Color.MintCream
        Me.pnladd.Controls.Add(Me.Panel1)
        Me.pnladd.Controls.Add(Me.Panel2)
        Me.pnladd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnladd.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnladd.Location = New System.Drawing.Point(0, 0)
        Me.pnladd.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pnladd.Name = "pnladd"
        Me.pnladd.Size = New System.Drawing.Size(527, 376)
        Me.pnladd.TabIndex = 9
        '
        'txtcity
        '
        Me.txtcity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcity.Location = New System.Drawing.Point(164, 267)
        Me.txtcity.Name = "txtcity"
        Me.txtcity.Size = New System.Drawing.Size(333, 29)
        Me.txtcity.TabIndex = 46
        '
        'txtbrgy
        '
        Me.txtbrgy.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbrgy.Location = New System.Drawing.Point(164, 226)
        Me.txtbrgy.Name = "txtbrgy"
        Me.txtbrgy.Size = New System.Drawing.Size(333, 29)
        Me.txtbrgy.TabIndex = 45
        '
        'txtstreet
        '
        Me.txtstreet.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtstreet.Location = New System.Drawing.Point(164, 187)
        Me.txtstreet.Name = "txtstreet"
        Me.txtstreet.Size = New System.Drawing.Size(333, 29)
        Me.txtstreet.TabIndex = 44
        '
        'txtemailadd
        '
        Me.txtemailadd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtemailadd.Location = New System.Drawing.Point(164, 147)
        Me.txtemailadd.Name = "txtemailadd"
        Me.txtemailadd.Size = New System.Drawing.Size(333, 29)
        Me.txtemailadd.TabIndex = 43
        '
        'txtcname
        '
        Me.txtcname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcname.Location = New System.Drawing.Point(164, 69)
        Me.txtcname.Name = "txtcname"
        Me.txtcname.Size = New System.Drawing.Size(333, 29)
        Me.txtcname.TabIndex = 42
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(503, 270)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(17, 22)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(503, 229)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(17, 22)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(503, 190)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(17, 22)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(503, 150)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(17, 22)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(503, 111)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(17, 22)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(503, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 22)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 22)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Email Address :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(106, 270)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 22)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "City :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(99, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 22)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Brgy :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(87, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 22)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Street :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 22)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Contact No. :"
        '
        'txtcontact
        '
        Me.txtcontact.Location = New System.Drawing.Point(164, 108)
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.Size = New System.Drawing.Size(333, 29)
        Me.txtcontact.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(2, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(156, 22)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Company Name :"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtcity)
        Me.Panel1.Controls.Add(Me.txtcontact)
        Me.Panel1.Controls.Add(Me.txtbrgy)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtstreet)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtemailadd)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtcname)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(527, 313)
        Me.Panel1.TabIndex = 47
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label14.Location = New System.Drawing.Point(3, 4)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(214, 22)
        Me.Label14.TabIndex = 40
        Me.Label14.Text = "Fill up required fields *"
        '
        'frmsuppadd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 376)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.pnladd)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmsuppadd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmsuppadd"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnladd.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblitemID As System.Windows.Forms.Label
    Friend WithEvents pnladd As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcontact As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtcname As System.Windows.Forms.TextBox
    Friend WithEvents txtcity As System.Windows.Forms.TextBox
    Friend WithEvents txtbrgy As System.Windows.Forms.TextBox
    Friend WithEvents txtstreet As System.Windows.Forms.TextBox
    Friend WithEvents txtemailadd As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
