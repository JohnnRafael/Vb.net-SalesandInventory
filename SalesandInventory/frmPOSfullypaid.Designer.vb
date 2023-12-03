<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOSfullypaid
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOSfullypaid))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtdiscount = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblgt = New System.Windows.Forms.Label()
        Me.lblgrandtotal = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtrn = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.cbopayment = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtamount = New System.Windows.Forms.TextBox()
        Me.txtpd = New System.Windows.Forms.TextBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblbalc = New System.Windows.Forms.Label()
        Me.lblbal = New System.Windows.Forms.Label()
        Me.lblchanger = New System.Windows.Forms.Label()
        Me.lblc = New System.Windows.Forms.Label()
        Me.lblchange = New System.Windows.Forms.Label()
        Me.lblchanges = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lbldiscounted = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtdelfee = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbltotalers = New System.Windows.Forms.Label()
        Me.lblchequeno = New System.Windows.Forms.Label()
        Me.lbltop = New System.Windows.Forms.Label()
        Me.lbldiscount = New System.Windows.Forms.Label()
        Me.grppayment = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.lblta = New System.Windows.Forms.TextBox()
        Me.lbltotalamount = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.lbltotal1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.grppayment.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MintCream
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtdiscount)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.Coral
        Me.Panel1.Location = New System.Drawing.Point(429, 14)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(337, 50)
        Me.Panel1.TabIndex = 0
        '
        'txtdiscount
        '
        Me.txtdiscount.BackColor = System.Drawing.Color.MintCream
        Me.txtdiscount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtdiscount.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtdiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold)
        Me.txtdiscount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtdiscount.Location = New System.Drawing.Point(148, 0)
        Me.txtdiscount.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtdiscount.Multiline = True
        Me.txtdiscount.Name = "txtdiscount"
        Me.txtdiscount.Size = New System.Drawing.Size(141, 48)
        Me.txtdiscount.TabIndex = 105
        Me.txtdiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(289, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 48)
        Me.Label15.TabIndex = 104
        Me.Label15.Text = "%"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 24)
        Me.Label3.TabIndex = 101
        Me.Label3.Text = "DISCOUNT"
        '
        'btnEnter
        '
        Me.btnEnter.Image = CType(resources.GetObject("btnEnter.Image"), System.Drawing.Image)
        Me.btnEnter.Location = New System.Drawing.Point(643, 586)
        Me.btnEnter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(66, 43)
        Me.btnEnter.TabIndex = 4
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(715, 591)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(38, 28)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(714, 621)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 14)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Cancel"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.MintCream
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.lblgt)
        Me.Panel4.Controls.Add(Me.lblgrandtotal)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.ForeColor = System.Drawing.Color.Coral
        Me.Panel4.Location = New System.Drawing.Point(3, 473)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(762, 50)
        Me.Panel4.TabIndex = 3
        '
        'lblgt
        '
        Me.lblgt.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblgt.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblgt.Location = New System.Drawing.Point(356, 0)
        Me.lblgt.Name = "lblgt"
        Me.lblgt.Size = New System.Drawing.Size(130, 48)
        Me.lblgt.TabIndex = 101
        Me.lblgt.Text = " 0"
        Me.lblgt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblgt.Visible = False
        '
        'lblgrandtotal
        '
        Me.lblgrandtotal.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblgrandtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgrandtotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblgrandtotal.Location = New System.Drawing.Point(486, 0)
        Me.lblgrandtotal.Name = "lblgrandtotal"
        Me.lblgrandtotal.Size = New System.Drawing.Size(274, 48)
        Me.lblgrandtotal.TabIndex = 100
        Me.lblgrandtotal.Text = " 0.00"
        Me.lblgrandtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(3, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(190, 24)
        Me.Label8.TabIndex = 99
        Me.Label8.Text = "GRAND TOTAL     "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(659, 631)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 14)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Enter"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.MintCream
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.txtrn)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.btnadd)
        Me.Panel3.Controls.Add(Me.cbopayment)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.txtamount)
        Me.Panel3.Controls.Add(Me.txtpd)
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel3.Location = New System.Drawing.Point(3, 171)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(763, 246)
        Me.Panel3.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(3, -1)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 24)
        Me.Label6.TabIndex = 112
        Me.Label6.Text = "PAYMENT"
        '
        'txtrn
        '
        Me.txtrn.Location = New System.Drawing.Point(586, 50)
        Me.txtrn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtrn.Name = "txtrn"
        Me.txtrn.Size = New System.Drawing.Size(163, 25)
        Me.txtrn.TabIndex = 111
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label16.Location = New System.Drawing.Point(413, 51)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(167, 24)
        Me.Label16.TabIndex = 110
        Me.Label16.Text = "Reference No. :"
        '
        'btnadd
        '
        Me.btnadd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnadd.Location = New System.Drawing.Point(11, 74)
        Me.btnadd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(78, 25)
        Me.btnadd.TabIndex = 109
        Me.btnadd.Text = "&Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'cbopayment
        '
        Me.cbopayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbopayment.FormattingEnabled = True
        Me.cbopayment.Location = New System.Drawing.Point(217, 25)
        Me.cbopayment.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbopayment.Name = "cbopayment"
        Me.cbopayment.Size = New System.Drawing.Size(148, 25)
        Me.cbopayment.TabIndex = 108
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(52, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(159, 24)
        Me.Label11.TabIndex = 107
        Me.Label11.Text = "Payment Type:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(7, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(204, 24)
        Me.Label9.TabIndex = 106
        Me.Label9.Text = "Amount Tendered :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(396, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 24)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "Payment Details :"
        '
        'txtamount
        '
        Me.txtamount.Location = New System.Drawing.Point(217, 54)
        Me.txtamount.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.Size = New System.Drawing.Size(148, 25)
        Me.txtamount.TabIndex = 104
        Me.txtamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtpd
        '
        Me.txtpd.Location = New System.Drawing.Point(586, 23)
        Me.txtpd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtpd.Name = "txtpd"
        Me.txtpd.Size = New System.Drawing.Size(163, 25)
        Me.txtpd.TabIndex = 103
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.dgv)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 105)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(761, 139)
        Me.Panel7.TabIndex = 102
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToResizeColumns = False
        Me.dgv.AllowUserToResizeRows = False
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv.BackgroundColor = System.Drawing.Color.White
        Me.dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column1, Me.Column2, Me.Column3, Me.Column5, Me.Column7, Me.Column8, Me.Column6})
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(0, 0)
        Me.dgv.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(761, 139)
        Me.dgv.TabIndex = 15
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "paymentid"
        Me.Column4.HeaderText = "paymentid"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Visible = False
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "paymentname"
        Me.Column1.HeaderText = "Payment Type"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "paymentdetails"
        Me.Column2.HeaderText = "Payment Details"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "amount"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column3.HeaderText = "Amount"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "transno"
        Me.Column5.HeaderText = "transno"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Visible = False
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "clientid"
        Me.Column7.HeaderText = "clientid"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Visible = False
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "referenceno"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column8.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column8.HeaderText = "Reference No."
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "status"
        Me.Column6.HeaderText = "status"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Visible = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.MintCream
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.lblbalc)
        Me.Panel5.Controls.Add(Me.lblbal)
        Me.Panel5.Controls.Add(Me.lblchanger)
        Me.Panel5.Controls.Add(Me.lblc)
        Me.Panel5.Controls.Add(Me.lblchange)
        Me.Panel5.Controls.Add(Me.lblchanges)
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.ForeColor = System.Drawing.Color.Coral
        Me.Panel5.Location = New System.Drawing.Point(3, 526)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(763, 50)
        Me.Panel5.TabIndex = 8
        '
        'lblbalc
        '
        Me.lblbalc.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblbalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbalc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblbalc.Location = New System.Drawing.Point(7, 0)
        Me.lblbalc.Name = "lblbalc"
        Me.lblbalc.Size = New System.Drawing.Size(122, 48)
        Me.lblbalc.TabIndex = 105
        Me.lblbalc.Text = " 0"
        Me.lblbalc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblbalc.Visible = False
        '
        'lblbal
        '
        Me.lblbal.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblbal.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblbal.Location = New System.Drawing.Point(129, 0)
        Me.lblbal.Name = "lblbal"
        Me.lblbal.Size = New System.Drawing.Size(122, 48)
        Me.lblbal.TabIndex = 104
        Me.lblbal.Text = " 0"
        Me.lblbal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblbal.Visible = False
        '
        'lblchanger
        '
        Me.lblchanger.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblchanger.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblchanger.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblchanger.Location = New System.Drawing.Point(251, 0)
        Me.lblchanger.Name = "lblchanger"
        Me.lblchanger.Size = New System.Drawing.Size(122, 48)
        Me.lblchanger.TabIndex = 103
        Me.lblchanger.Text = " 0"
        Me.lblchanger.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblchanger.Visible = False
        '
        'lblc
        '
        Me.lblc.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblc.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblc.Location = New System.Drawing.Point(373, 0)
        Me.lblc.Name = "lblc"
        Me.lblc.Size = New System.Drawing.Size(122, 48)
        Me.lblc.TabIndex = 102
        Me.lblc.Text = " 0"
        Me.lblc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblc.Visible = False
        '
        'lblchange
        '
        Me.lblchange.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblchange.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblchange.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblchange.Location = New System.Drawing.Point(495, 0)
        Me.lblchange.Name = "lblchange"
        Me.lblchange.Size = New System.Drawing.Size(266, 48)
        Me.lblchange.TabIndex = 101
        Me.lblchange.Text = " 0.00"
        Me.lblchange.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblchanges
        '
        Me.lblchanges.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblchanges.ForeColor = System.Drawing.Color.White
        Me.lblchanges.Location = New System.Drawing.Point(360, 0)
        Me.lblchanges.Name = "lblchanges"
        Me.lblchanges.Size = New System.Drawing.Size(116, 50)
        Me.lblchanges.TabIndex = 100
        Me.lblchanges.Text = "0.00"
        Me.lblchanges.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblchanges.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(3, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 24)
        Me.Label10.TabIndex = 99
        Me.Label10.Text = "CHANGE"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.MintCream
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.lbldiscounted)
        Me.Panel6.Controls.Add(Me.Label7)
        Me.Panel6.Controls.Add(Me.lbltotal)
        Me.Panel6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.ForeColor = System.Drawing.Color.Coral
        Me.Panel6.Location = New System.Drawing.Point(3, 66)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(763, 50)
        Me.Panel6.TabIndex = 9
        '
        'lbldiscounted
        '
        Me.lbldiscounted.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldiscounted.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbldiscounted.Location = New System.Drawing.Point(282, -6)
        Me.lbldiscounted.Name = "lbldiscounted"
        Me.lbldiscounted.Size = New System.Drawing.Size(122, 60)
        Me.lbldiscounted.TabIndex = 103
        Me.lbldiscounted.Text = "0.00"
        Me.lbldiscounted.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbldiscounted.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(3, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(229, 24)
        Me.Label7.TabIndex = 101
        Me.Label7.Text = "TOTAL w/ DISCOUNT"
        '
        'lbltotal
        '
        Me.lbltotal.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbltotal.Location = New System.Drawing.Point(440, 0)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(321, 48)
        Me.lbltotal.TabIndex = 100
        Me.lbltotal.Text = "0.00"
        Me.lbltotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MintCream
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtdelfee)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.lbltotalers)
        Me.Panel2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.ForeColor = System.Drawing.Color.MintCream
        Me.Panel2.Location = New System.Drawing.Point(3, 118)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(763, 50)
        Me.Panel2.TabIndex = 10
        '
        'txtdelfee
        '
        Me.txtdelfee.BackColor = System.Drawing.Color.MintCream
        Me.txtdelfee.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtdelfee.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtdelfee.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold)
        Me.txtdelfee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtdelfee.Location = New System.Drawing.Point(503, 0)
        Me.txtdelfee.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtdelfee.Multiline = True
        Me.txtdelfee.Name = "txtdelfee"
        Me.txtdelfee.Size = New System.Drawing.Size(258, 48)
        Me.txtdelfee.TabIndex = 102
        Me.txtdelfee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 24)
        Me.Label4.TabIndex = 101
        Me.Label4.Text = "DELIVERY FEE"
        '
        'lbltotalers
        '
        Me.lbltotalers.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbltotalers.Location = New System.Drawing.Point(223, -7)
        Me.lbltotalers.Name = "lbltotalers"
        Me.lbltotalers.Size = New System.Drawing.Size(132, 60)
        Me.lbltotalers.TabIndex = 104
        Me.lbltotalers.Text = "0.00"
        Me.lbltotalers.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbltotalers.Visible = False
        '
        'lblchequeno
        '
        Me.lblchequeno.AutoSize = True
        Me.lblchequeno.Location = New System.Drawing.Point(233, 1)
        Me.lblchequeno.Name = "lblchequeno"
        Me.lblchequeno.Size = New System.Drawing.Size(53, 14)
        Me.lblchequeno.TabIndex = 62
        Me.lblchequeno.Text = "Label11"
        Me.lblchequeno.Visible = False
        '
        'lbltop
        '
        Me.lbltop.AutoSize = True
        Me.lbltop.Location = New System.Drawing.Point(102, 3)
        Me.lbltop.Name = "lbltop"
        Me.lbltop.Size = New System.Drawing.Size(14, 14)
        Me.lbltop.TabIndex = 63
        Me.lbltop.Text = "1"
        Me.lbltop.Visible = False
        '
        'lbldiscount
        '
        Me.lbldiscount.AutoSize = True
        Me.lbldiscount.Location = New System.Drawing.Point(172, 1)
        Me.lbldiscount.Name = "lbldiscount"
        Me.lbldiscount.Size = New System.Drawing.Size(53, 14)
        Me.lbldiscount.TabIndex = 64
        Me.lbldiscount.Text = "Label11"
        Me.lbldiscount.Visible = False
        '
        'grppayment
        '
        Me.grppayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grppayment.Controls.Add(Me.Label14)
        Me.grppayment.Controls.Add(Me.Panel9)
        Me.grppayment.Controls.Add(Me.Panel8)
        Me.grppayment.Controls.Add(Me.lbldiscount)
        Me.grppayment.Controls.Add(Me.Panel6)
        Me.grppayment.Controls.Add(Me.lbltop)
        Me.grppayment.Controls.Add(Me.lblchequeno)
        Me.grppayment.Controls.Add(Me.Panel2)
        Me.grppayment.Controls.Add(Me.Panel5)
        Me.grppayment.Controls.Add(Me.Panel3)
        Me.grppayment.Controls.Add(Me.Label5)
        Me.grppayment.Controls.Add(Me.Panel4)
        Me.grppayment.Controls.Add(Me.Label2)
        Me.grppayment.Controls.Add(Me.btnCancel)
        Me.grppayment.Controls.Add(Me.btnEnter)
        Me.grppayment.Controls.Add(Me.Panel1)
        Me.grppayment.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grppayment.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grppayment.Location = New System.Drawing.Point(0, 1)
        Me.grppayment.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grppayment.Name = "grppayment"
        Me.grppayment.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grppayment.Size = New System.Drawing.Size(769, 657)
        Me.grppayment.TabIndex = 2
        Me.grppayment.TabStop = False
        Me.grppayment.Text = "PAYMENT"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(361, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(14, 14)
        Me.Label14.TabIndex = 68
        Me.Label14.Text = "1"
        Me.Label14.Visible = False
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.MintCream
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.lblta)
        Me.Panel9.Controls.Add(Me.lbltotalamount)
        Me.Panel9.Controls.Add(Me.Label13)
        Me.Panel9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel9.ForeColor = System.Drawing.Color.Coral
        Me.Panel9.Location = New System.Drawing.Point(3, 420)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(762, 50)
        Me.Panel9.TabIndex = 66
        '
        'lblta
        '
        Me.lblta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblta.Location = New System.Drawing.Point(265, 2)
        Me.lblta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lblta.Name = "lblta"
        Me.lblta.Size = New System.Drawing.Size(88, 25)
        Me.lblta.TabIndex = 103
        Me.lblta.Text = "0"
        Me.lblta.Visible = False
        '
        'lbltotalamount
        '
        Me.lbltotalamount.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbltotalamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalamount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbltotalamount.Location = New System.Drawing.Point(486, 0)
        Me.lbltotalamount.Name = "lbltotalamount"
        Me.lbltotalamount.Size = New System.Drawing.Size(274, 48)
        Me.lbltotalamount.TabIndex = 102
        Me.lbltotalamount.Text = " 0.00"
        Me.lbltotalamount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(3, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(180, 24)
        Me.Label13.TabIndex = 101
        Me.Label13.Text = "TOTAL AMOUNT"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.MintCream
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.lbltotal1)
        Me.Panel8.Controls.Add(Me.Label12)
        Me.Panel8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel8.ForeColor = System.Drawing.Color.Coral
        Me.Panel8.Location = New System.Drawing.Point(3, 14)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(424, 50)
        Me.Panel8.TabIndex = 65
        '
        'lbltotal1
        '
        Me.lbltotal1.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbltotal1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbltotal1.Location = New System.Drawing.Point(199, 0)
        Me.lbltotal1.Name = "lbltotal1"
        Me.lbltotal1.Size = New System.Drawing.Size(223, 48)
        Me.lbltotal1.TabIndex = 102
        Me.lbltotal1.Text = "0.00"
        Me.lbltotal1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(9, 3)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 24)
        Me.Label12.TabIndex = 101
        Me.Label12.Text = "TOTAL"
        '
        'frmPOSfullypaid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(769, 658)
        Me.ControlBox = False
        Me.Controls.Add(Me.grppayment)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Name = "frmPOSfullypaid"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.grppayment.ResumeLayout(False)
        Me.grppayment.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lblgt As System.Windows.Forms.Label
    Friend WithEvents lblgrandtotal As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lblc As System.Windows.Forms.Label
    Friend WithEvents lblchange As System.Windows.Forms.Label
    Friend WithEvents lblchanges As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents lbldiscounted As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lbltotalers As System.Windows.Forms.Label
    Friend WithEvents txtdelfee As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblchequeno As System.Windows.Forms.Label
    Friend WithEvents lbltop As System.Windows.Forms.Label
    Friend WithEvents lbldiscount As System.Windows.Forms.Label
    Friend WithEvents grppayment As System.Windows.Forms.GroupBox
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtamount As System.Windows.Forms.TextBox
    Friend WithEvents txtpd As System.Windows.Forms.TextBox
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents cbopayment As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents lbltotalamount As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lbltotal1 As System.Windows.Forms.Label
    Friend WithEvents lblta As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtdiscount As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtrn As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblchanger As System.Windows.Forms.Label
    Friend WithEvents lblbal As System.Windows.Forms.Label
    Friend WithEvents lblbalc As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
