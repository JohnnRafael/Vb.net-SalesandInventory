<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmaddclient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmaddclient))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblclientno = New System.Windows.Forms.Label()
        Me.lblclientid = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblclient = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblitemID = New System.Windows.Forms.Label()
        Me.pnladd = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cbopm = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtcontactno = New System.Windows.Forms.TextBox()
        Me.txtcity = New System.Windows.Forms.TextBox()
        Me.txtbrgy = New System.Windows.Forms.TextBox()
        Me.txtstreet = New System.Windows.Forms.TextBox()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.txtmi = New System.Windows.Forms.TextBox()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnladd.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Honeydew
        Me.Panel3.Controls.Add(Me.lblclientno)
        Me.Panel3.Controls.Add(Me.lblclientid)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.lblclient)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(466, 62)
        Me.Panel3.TabIndex = 10
        '
        'lblclientno
        '
        Me.lblclientno.AutoSize = True
        Me.lblclientno.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclientno.Location = New System.Drawing.Point(243, 44)
        Me.lblclientno.Name = "lblclientno"
        Me.lblclientno.Size = New System.Drawing.Size(98, 22)
        Me.lblclientno.TabIndex = 67
        Me.lblclientno.Text = "00000000"
        Me.lblclientno.Visible = False
        '
        'lblclientid
        '
        Me.lblclientid.AutoSize = True
        Me.lblclientid.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclientid.Location = New System.Drawing.Point(243, 11)
        Me.lblclientid.Name = "lblclientid"
        Me.lblclientid.Size = New System.Drawing.Size(98, 22)
        Me.lblclientid.TabIndex = 66
        Me.lblclientid.Text = "00000000"
        Me.lblclientid.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add New"
        '
        'lblclient
        '
        Me.lblclient.AutoSize = True
        Me.lblclient.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclient.Location = New System.Drawing.Point(361, 26)
        Me.lblclient.Name = "lblclient"
        Me.lblclient.Size = New System.Drawing.Size(98, 22)
        Me.lblclient.TabIndex = 89
        Me.lblclient.Text = "00000000"
        Me.lblclient.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(464, 55)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(17, 22)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "*"
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(248, 24)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(124, 53)
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
        Me.btnSave.Location = New System.Drawing.Point(116, 24)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(124, 53)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "&Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Honeydew
        Me.Panel2.Controls.Add(Me.Label26)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.lblitemID)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 433)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(466, 89)
        Me.Panel2.TabIndex = 9
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label26.Location = New System.Drawing.Point(12, 3)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(214, 22)
        Me.Label26.TabIndex = 110
        Me.Label26.Text = "Fill up required fields *"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Honeydew
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(86, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(380, 89)
        Me.Panel1.TabIndex = 34
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
        Me.pnladd.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pnladd.Controls.Add(Me.Panel4)
        Me.pnladd.Controls.Add(Me.DateTimePicker1)
        Me.pnladd.Controls.Add(Me.Label7)
        Me.pnladd.Controls.Add(Me.Panel2)
        Me.pnladd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnladd.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnladd.Location = New System.Drawing.Point(0, 0)
        Me.pnladd.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pnladd.Name = "pnladd"
        Me.pnladd.Size = New System.Drawing.Size(466, 522)
        Me.pnladd.TabIndex = 9
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.MintCream
        Me.Panel4.Controls.Add(Me.Label25)
        Me.Panel4.Controls.Add(Me.Label24)
        Me.Panel4.Controls.Add(Me.cbopm)
        Me.Panel4.Controls.Add(Me.Label23)
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Controls.Add(Me.Label22)
        Me.Panel4.Controls.Add(Me.Label21)
        Me.Panel4.Controls.Add(Me.Label20)
        Me.Panel4.Controls.Add(Me.Label19)
        Me.Panel4.Controls.Add(Me.txtemail)
        Me.Panel4.Controls.Add(Me.txtcontactno)
        Me.Panel4.Controls.Add(Me.txtcity)
        Me.Panel4.Controls.Add(Me.txtbrgy)
        Me.Panel4.Controls.Add(Me.txtstreet)
        Me.Panel4.Controls.Add(Me.txtlname)
        Me.Panel4.Controls.Add(Me.txtmi)
        Me.Panel4.Controls.Add(Me.txtfname)
        Me.Panel4.Controls.Add(Me.Label18)
        Me.Panel4.Controls.Add(Me.Label17)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(466, 433)
        Me.Panel4.TabIndex = 71
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.Color.Red
        Me.Label25.Location = New System.Drawing.Point(395, 83)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(17, 22)
        Me.Label25.TabIndex = 109
        Me.Label25.Text = "*"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ForeColor = System.Drawing.Color.Red
        Me.Label24.Location = New System.Drawing.Point(394, 205)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(17, 22)
        Me.Label24.TabIndex = 108
        Me.Label24.Text = "*"
        '
        'cbopm
        '
        Me.cbopm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbopm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbopm.FormattingEnabled = True
        Me.cbopm.Location = New System.Drawing.Point(184, 202)
        Me.cbopm.Name = "cbopm"
        Me.cbopm.Size = New System.Drawing.Size(204, 30)
        Me.cbopm.TabIndex = 107
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(5, 205)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(174, 22)
        Me.Label23.TabIndex = 106
        Me.Label23.Text = "Payment Method :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(12, 61)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 22)
        Me.Label16.TabIndex = 93
        Me.Label16.Text = "Client #:"
        Me.Label16.Visible = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.Color.Red
        Me.Label22.Location = New System.Drawing.Point(394, 401)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(17, 22)
        Me.Label22.TabIndex = 105
        Me.Label22.Text = "*"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.Red
        Me.Label21.Location = New System.Drawing.Point(394, 362)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(17, 22)
        Me.Label21.TabIndex = 104
        Me.Label21.Text = "*"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(394, 324)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(17, 22)
        Me.Label20.TabIndex = 103
        Me.Label20.Text = "*"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(395, 247)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(17, 22)
        Me.Label19.TabIndex = 102
        Me.Label19.Text = "*"
        '
        'txtemail
        '
        Me.txtemail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtemail.Location = New System.Drawing.Point(184, 398)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(204, 29)
        Me.txtemail.TabIndex = 101
        '
        'txtcontactno
        '
        Me.txtcontactno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcontactno.Location = New System.Drawing.Point(184, 359)
        Me.txtcontactno.Name = "txtcontactno"
        Me.txtcontactno.Size = New System.Drawing.Size(204, 29)
        Me.txtcontactno.TabIndex = 100
        '
        'txtcity
        '
        Me.txtcity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcity.Location = New System.Drawing.Point(184, 321)
        Me.txtcity.Name = "txtcity"
        Me.txtcity.Size = New System.Drawing.Size(204, 29)
        Me.txtcity.TabIndex = 99
        '
        'txtbrgy
        '
        Me.txtbrgy.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbrgy.Location = New System.Drawing.Point(184, 283)
        Me.txtbrgy.Name = "txtbrgy"
        Me.txtbrgy.Size = New System.Drawing.Size(204, 29)
        Me.txtbrgy.TabIndex = 98
        '
        'txtstreet
        '
        Me.txtstreet.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtstreet.Location = New System.Drawing.Point(184, 244)
        Me.txtstreet.Name = "txtstreet"
        Me.txtstreet.Size = New System.Drawing.Size(204, 29)
        Me.txtstreet.TabIndex = 97
        '
        'txtlname
        '
        Me.txtlname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtlname.Location = New System.Drawing.Point(184, 164)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(204, 29)
        Me.txtlname.TabIndex = 96
        '
        'txtmi
        '
        Me.txtmi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmi.Location = New System.Drawing.Point(184, 123)
        Me.txtmi.Name = "txtmi"
        Me.txtmi.Size = New System.Drawing.Size(204, 29)
        Me.txtmi.TabIndex = 95
        '
        'txtfname
        '
        Me.txtfname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtfname.Location = New System.Drawing.Point(184, 83)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(204, 29)
        Me.txtfname.TabIndex = 94
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(59, 83)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(120, 22)
        Me.Label18.TabIndex = 92
        Me.Label18.Text = "First Name :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(356, 86)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(17, 22)
        Me.Label17.TabIndex = 91
        Me.Label17.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(395, 279)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(17, 22)
        Me.Label13.TabIndex = 86
        Me.Label13.Text = "*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(107, 401)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 22)
        Me.Label14.TabIndex = 83
        Me.Label14.Text = "Email :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(52, 359)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(129, 22)
        Me.Label15.TabIndex = 82
        Me.Label15.Text = "Contact No. :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(395, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 22)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(262, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 22)
        Me.Label8.TabIndex = 79
        Me.Label8.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(122, 324)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 22)
        Me.Label9.TabIndex = 76
        Me.Label9.Text = "City :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(114, 286)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 22)
        Me.Label10.TabIndex = 75
        Me.Label10.Text = "Brgy :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(103, 247)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 22)
        Me.Label12.TabIndex = 74
        Me.Label12.Text = "Street :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(262, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(17, 22)
        Me.Label11.TabIndex = 73
        Me.Label11.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(262, -77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 22)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(61, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 22)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Last Name :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(130, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 22)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "M.I :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(-70, -77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 22)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "First Name :"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyyMMdd"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(128, 170)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(51, 29)
        Me.DateTimePicker1.TabIndex = 70
        '
        'frmaddclient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 522)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.pnladd)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmaddclient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmaddclient"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.pnladd.ResumeLayout(False)
        Me.pnladd.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblitemID As System.Windows.Forms.Label
    Friend WithEvents pnladd As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblclientid As System.Windows.Forms.Label
    Friend WithEvents lblclientno As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblclient As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents txtcontactno As System.Windows.Forms.TextBox
    Friend WithEvents txtcity As System.Windows.Forms.TextBox
    Friend WithEvents txtbrgy As System.Windows.Forms.TextBox
    Friend WithEvents txtstreet As System.Windows.Forms.TextBox
    Friend WithEvents txtlname As System.Windows.Forms.TextBox
    Friend WithEvents txtmi As System.Windows.Forms.TextBox
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents cbopm As System.Windows.Forms.ComboBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
End Class
