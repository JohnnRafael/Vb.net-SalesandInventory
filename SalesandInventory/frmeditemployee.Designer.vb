<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmeditemployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmeditemployee))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.chkactive = New System.Windows.Forms.CheckBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.pnladd = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblage = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtdob = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboposition = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtmi = New System.Windows.Forms.TextBox()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblitemID = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbluserdt = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnladd.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label10.Location = New System.Drawing.Point(3, 4)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(214, 22)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Fill up required fields *"
        '
        'chkactive
        '
        Me.chkactive.AutoSize = True
        Me.chkactive.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkactive.Location = New System.Drawing.Point(166, 272)
        Me.chkactive.Margin = New System.Windows.Forms.Padding(4)
        Me.chkactive.Name = "chkactive"
        Me.chkactive.Size = New System.Drawing.Size(91, 22)
        Me.chkactive.TabIndex = 116
        Me.chkactive.Text = "isActive"
        Me.chkactive.UseVisualStyleBackColor = True
        '
        'txtpassword
        '
        Me.txtpassword.BackColor = System.Drawing.SystemColors.Control
        Me.txtpassword.Font = New System.Drawing.Font("Verdana", 11.25!)
        Me.txtpassword.Location = New System.Drawing.Point(166, 197)
        Me.txtpassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.ShortcutsEnabled = False
        Me.txtpassword.Size = New System.Drawing.Size(327, 26)
        Me.txtpassword.TabIndex = 114
        Me.txtpassword.UseSystemPasswordChar = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(493, 238)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(17, 22)
        Me.Label16.TabIndex = 48
        Me.Label16.Text = "*"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(493, 201)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(17, 22)
        Me.Label15.TabIndex = 47
        Me.Label15.Text = "*"
        '
        'pnladd
        '
        Me.pnladd.BackColor = System.Drawing.Color.MintCream
        Me.pnladd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnladd.Controls.Add(Me.chkactive)
        Me.pnladd.Controls.Add(Me.txtpassword)
        Me.pnladd.Controls.Add(Me.Label16)
        Me.pnladd.Controls.Add(Me.Label15)
        Me.pnladd.Controls.Add(Me.Label14)
        Me.pnladd.Controls.Add(Me.txtusername)
        Me.pnladd.Controls.Add(Me.Label13)
        Me.pnladd.Controls.Add(Me.Label12)
        Me.pnladd.Controls.Add(Me.Label11)
        Me.pnladd.Controls.Add(Me.lblage)
        Me.pnladd.Controls.Add(Me.Label9)
        Me.pnladd.Controls.Add(Me.dtdob)
        Me.pnladd.Controls.Add(Me.Label8)
        Me.pnladd.Controls.Add(Me.txtlname)
        Me.pnladd.Controls.Add(Me.Label6)
        Me.pnladd.Controls.Add(Me.cboposition)
        Me.pnladd.Controls.Add(Me.Label7)
        Me.pnladd.Controls.Add(Me.txtmi)
        Me.pnladd.Controls.Add(Me.txtfname)
        Me.pnladd.Controls.Add(Me.Panel2)
        Me.pnladd.Controls.Add(Me.Label5)
        Me.pnladd.Controls.Add(Me.Label4)
        Me.pnladd.Controls.Add(Me.Label3)
        Me.pnladd.Controls.Add(Me.Label2)
        Me.pnladd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnladd.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnladd.Location = New System.Drawing.Point(0, 61)
        Me.pnladd.Name = "pnladd"
        Me.pnladd.Size = New System.Drawing.Size(527, 382)
        Me.pnladd.TabIndex = 11
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(341, 125)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(17, 22)
        Me.Label14.TabIndex = 46
        Me.Label14.Text = "*"
        '
        'txtusername
        '
        Me.txtusername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtusername.Location = New System.Drawing.Point(166, 161)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(327, 29)
        Me.txtusername.TabIndex = 44
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(40, 201)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(111, 22)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "Password :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(37, 161)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(114, 22)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "Username :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(493, 161)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(17, 22)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "*"
        '
        'lblage
        '
        Me.lblage.AutoSize = True
        Me.lblage.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblage.Location = New System.Drawing.Point(441, 123)
        Me.lblage.Name = "lblage"
        Me.lblage.Size = New System.Drawing.Size(0, 22)
        Me.lblage.TabIndex = 40
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(377, 125)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 22)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Age :"
        '
        'dtdob
        '
        Me.dtdob.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtdob.Location = New System.Drawing.Point(166, 120)
        Me.dtdob.Name = "dtdob"
        Me.dtdob.Size = New System.Drawing.Size(169, 29)
        Me.dtdob.TabIndex = 38
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 22)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Date of Birth :"
        '
        'txtlname
        '
        Me.txtlname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtlname.Location = New System.Drawing.Point(166, 83)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(327, 29)
        Me.txtlname.TabIndex = 36
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(493, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 22)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "*"
        '
        'cboposition
        '
        Me.cboposition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboposition.FormattingEnabled = True
        Me.cboposition.Location = New System.Drawing.Point(166, 235)
        Me.cboposition.Name = "cboposition"
        Me.cboposition.Size = New System.Drawing.Size(327, 30)
        Me.cboposition.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(381, 235)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(17, 22)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "*"
        '
        'txtmi
        '
        Me.txtmi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmi.Location = New System.Drawing.Point(166, 48)
        Me.txtmi.Name = "txtmi"
        Me.txtmi.Size = New System.Drawing.Size(327, 29)
        Me.txtmi.TabIndex = 21
        '
        'txtfname
        '
        Me.txtfname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtfname.Location = New System.Drawing.Point(166, 12)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(327, 29)
        Me.txtfname.TabIndex = 19
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Honeydew
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.lblitemID)
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 305)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(525, 75)
        Me.Panel2.TabIndex = 9
        '
        'lblitemID
        '
        Me.lblitemID.AutoSize = True
        Me.lblitemID.Location = New System.Drawing.Point(13, 18)
        Me.lblitemID.Name = "lblitemID"
        Me.lblitemID.Size = New System.Drawing.Size(0, 26)
        Me.lblitemID.TabIndex = 33
        Me.lblitemID.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(422, 18)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(93, 49)
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
        Me.btnSave.Location = New System.Drawing.Point(323, 18)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(93, 49)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "&Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 22)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Last Name :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 22)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "M.I (Optional) :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(57, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 22)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Position :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "First Name :"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Honeydew
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lbluserdt)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(527, 61)
        Me.Panel3.TabIndex = 12
        '
        'lbluserdt
        '
        Me.lbluserdt.AutoSize = True
        Me.lbluserdt.Location = New System.Drawing.Point(310, 10)
        Me.lbluserdt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbluserdt.Name = "lbluserdt"
        Me.lbluserdt.Size = New System.Drawing.Size(131, 26)
        Me.lbluserdt.TabIndex = 100
        Me.lbluserdt.Text = "date and time"
        Me.lbluserdt.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Edit User"
        '
        'frmeditemployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 443)
        Me.Controls.Add(Me.pnladd)
        Me.Controls.Add(Me.Panel3)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmeditemployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmeditemployee"
        Me.pnladd.ResumeLayout(False)
        Me.pnladd.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents chkactive As System.Windows.Forms.CheckBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents pnladd As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblage As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtdob As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtlname As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboposition As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtmi As System.Windows.Forms.TextBox
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblitemID As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lbluserdt As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
