<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmnewPO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmnewPO))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gboxpo = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblqty = New System.Windows.Forms.Label()
        Me.lbliddddd = New System.Windows.Forms.Label()
        Me.lblcname = New System.Windows.Forms.Label()
        Me.lblsupid = New System.Windows.Forms.Label()
        Me.lblitemid = New System.Windows.Forms.Label()
        Me.lblprice = New System.Windows.Forms.Label()
        Me.lbldesc = New System.Windows.Forms.Label()
        Me.lblitemtype = New System.Windows.Forms.Label()
        Me.lblitemcode = New System.Windows.Forms.Label()
        Me.lblid = New System.Windows.Forms.Label()
        Me.lblpo = New System.Windows.Forms.Label()
        Me.lblyear = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.cboorder = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtdate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbosupplier = New System.Windows.Forms.ComboBox()
        Me.lblponum = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.dgvPO = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.gboxpo.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.dgvPO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.gboxpo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(977, 120)
        Me.Panel1.TabIndex = 0
        '
        'gboxpo
        '
        Me.gboxpo.BackColor = System.Drawing.Color.Honeydew
        Me.gboxpo.Controls.Add(Me.Label5)
        Me.gboxpo.Controls.Add(Me.lblqty)
        Me.gboxpo.Controls.Add(Me.lbliddddd)
        Me.gboxpo.Controls.Add(Me.lblcname)
        Me.gboxpo.Controls.Add(Me.lblsupid)
        Me.gboxpo.Controls.Add(Me.lblitemid)
        Me.gboxpo.Controls.Add(Me.lblprice)
        Me.gboxpo.Controls.Add(Me.lbldesc)
        Me.gboxpo.Controls.Add(Me.lblitemtype)
        Me.gboxpo.Controls.Add(Me.lblitemcode)
        Me.gboxpo.Controls.Add(Me.lblid)
        Me.gboxpo.Controls.Add(Me.lblpo)
        Me.gboxpo.Controls.Add(Me.lblyear)
        Me.gboxpo.Controls.Add(Me.lbldate)
        Me.gboxpo.Controls.Add(Me.cboorder)
        Me.gboxpo.Controls.Add(Me.Label4)
        Me.gboxpo.Controls.Add(Me.dtdate)
        Me.gboxpo.Controls.Add(Me.Label1)
        Me.gboxpo.Controls.Add(Me.Label2)
        Me.gboxpo.Controls.Add(Me.Label3)
        Me.gboxpo.Controls.Add(Me.cbosupplier)
        Me.gboxpo.Controls.Add(Me.lblponum)
        Me.gboxpo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gboxpo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxpo.Location = New System.Drawing.Point(0, 0)
        Me.gboxpo.Name = "gboxpo"
        Me.gboxpo.Size = New System.Drawing.Size(977, 120)
        Me.gboxpo.TabIndex = 4
        Me.gboxpo.TabStop = False
        Me.gboxpo.Text = "Purchase Order Information"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(383, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 17)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "1"
        Me.Label5.Visible = False
        '
        'lblqty
        '
        Me.lblqty.AutoSize = True
        Me.lblqty.Location = New System.Drawing.Point(857, 18)
        Me.lblqty.Name = "lblqty"
        Me.lblqty.Size = New System.Drawing.Size(30, 17)
        Me.lblqty.TabIndex = 54
        Me.lblqty.Text = "qty"
        Me.lblqty.Visible = False
        '
        'lbliddddd
        '
        Me.lbliddddd.AutoSize = True
        Me.lbliddddd.Location = New System.Drawing.Point(485, 28)
        Me.lbliddddd.Name = "lbliddddd"
        Me.lbliddddd.Size = New System.Drawing.Size(39, 17)
        Me.lbliddddd.TabIndex = 53
        Me.lbliddddd.Text = "iddd"
        Me.lbliddddd.Visible = False
        '
        'lblcname
        '
        Me.lblcname.AutoSize = True
        Me.lblcname.Location = New System.Drawing.Point(872, 81)
        Me.lblcname.Name = "lblcname"
        Me.lblcname.Size = New System.Drawing.Size(47, 17)
        Me.lblcname.TabIndex = 52
        Me.lblcname.Text = "supid"
        Me.lblcname.Visible = False
        '
        'lblsupid
        '
        Me.lblsupid.AutoSize = True
        Me.lblsupid.Location = New System.Drawing.Point(905, 53)
        Me.lblsupid.Name = "lblsupid"
        Me.lblsupid.Size = New System.Drawing.Size(47, 17)
        Me.lblsupid.TabIndex = 51
        Me.lblsupid.Text = "supid"
        Me.lblsupid.Visible = False
        '
        'lblitemid
        '
        Me.lblitemid.AutoSize = True
        Me.lblitemid.Location = New System.Drawing.Point(740, 59)
        Me.lblitemid.Name = "lblitemid"
        Me.lblitemid.Size = New System.Drawing.Size(52, 17)
        Me.lblitemid.TabIndex = 50
        Me.lblitemid.Text = "itemid"
        Me.lblitemid.Visible = False
        '
        'lblprice
        '
        Me.lblprice.AutoSize = True
        Me.lblprice.Location = New System.Drawing.Point(641, 81)
        Me.lblprice.Name = "lblprice"
        Me.lblprice.Size = New System.Drawing.Size(46, 17)
        Me.lblprice.TabIndex = 49
        Me.lblprice.Text = "price"
        Me.lblprice.Visible = False
        '
        'lbldesc
        '
        Me.lbldesc.AutoSize = True
        Me.lbldesc.Location = New System.Drawing.Point(641, 53)
        Me.lbldesc.Name = "lbldesc"
        Me.lbldesc.Size = New System.Drawing.Size(43, 17)
        Me.lbldesc.TabIndex = 48
        Me.lbldesc.Text = "desc"
        Me.lbldesc.Visible = False
        '
        'lblitemtype
        '
        Me.lblitemtype.AutoSize = True
        Me.lblitemtype.Location = New System.Drawing.Point(530, 81)
        Me.lblitemtype.Name = "lblitemtype"
        Me.lblitemtype.Size = New System.Drawing.Size(70, 17)
        Me.lblitemtype.TabIndex = 47
        Me.lblitemtype.Text = "itemtype"
        Me.lblitemtype.Visible = False
        '
        'lblitemcode
        '
        Me.lblitemcode.AutoSize = True
        Me.lblitemcode.Location = New System.Drawing.Point(530, 53)
        Me.lblitemcode.Name = "lblitemcode"
        Me.lblitemcode.Size = New System.Drawing.Size(75, 17)
        Me.lblitemcode.TabIndex = 46
        Me.lblitemcode.Text = "itemcode"
        Me.lblitemcode.Visible = False
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Location = New System.Drawing.Point(476, 57)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(57, 17)
        Me.lblid.TabIndex = 44
        Me.lblid.Text = "Label5"
        Me.lblid.Visible = False
        '
        'lblpo
        '
        Me.lblpo.AutoSize = True
        Me.lblpo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 48.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpo.Location = New System.Drawing.Point(397, 25)
        Me.lblpo.Name = "lblpo"
        Me.lblpo.Size = New System.Drawing.Size(0, 75)
        Me.lblpo.TabIndex = 43
        Me.lblpo.Visible = False
        '
        'lblyear
        '
        Me.lblyear.AutoSize = True
        Me.lblyear.BackColor = System.Drawing.Color.White
        Me.lblyear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblyear.Location = New System.Drawing.Point(588, 84)
        Me.lblyear.Name = "lblyear"
        Me.lblyear.Size = New System.Drawing.Size(128, 16)
        Me.lblyear.TabIndex = 41
        Me.lblyear.Text = "                              "
        Me.lblyear.Visible = False
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.BackColor = System.Drawing.Color.White
        Me.lbldate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(733, 84)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(128, 16)
        Me.lbldate.TabIndex = 42
        Me.lbldate.Text = "                              "
        Me.lbldate.Visible = False
        '
        'cboorder
        '
        Me.cboorder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboorder.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboorder.FormattingEnabled = True
        Me.cboorder.Location = New System.Drawing.Point(137, 53)
        Me.cboorder.Name = "cboorder"
        Me.cboorder.Size = New System.Drawing.Size(254, 26)
        Me.cboorder.TabIndex = 40
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 17)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Ordered By :"
        '
        'dtdate
        '
        Me.dtdate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtdate.Location = New System.Drawing.Point(693, 21)
        Me.dtdate.Name = "dtdate"
        Me.dtdate.Size = New System.Drawing.Size(148, 26)
        Me.dtdate.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 17)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Order Number :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(449, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(223, 17)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Requested Date to Received :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(57, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 17)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Supplier:"
        '
        'cbosupplier
        '
        Me.cbosupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbosupplier.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbosupplier.FormattingEnabled = True
        Me.cbosupplier.Location = New System.Drawing.Point(137, 85)
        Me.cbosupplier.Name = "cbosupplier"
        Me.cbosupplier.Size = New System.Drawing.Size(254, 26)
        Me.cbosupplier.TabIndex = 38
        '
        'lblponum
        '
        Me.lblponum.AutoSize = True
        Me.lblponum.BackColor = System.Drawing.Color.Honeydew
        Me.lblponum.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblponum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblponum.Location = New System.Drawing.Point(139, 21)
        Me.lblponum.Name = "lblponum"
        Me.lblponum.Size = New System.Drawing.Size(178, 24)
        Me.lblponum.TabIndex = 36
        Me.lblponum.Text = "00000000000000"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Honeydew
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Controls.Add(Me.btnRemove)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel8)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 617)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(977, 55)
        Me.Panel2.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(277, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(93, 49)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "&Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Image = CType(resources.GetObject("btnRemove.Image"), System.Drawing.Image)
        Me.btnRemove.Location = New System.Drawing.Point(376, 3)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(108, 49)
        Me.btnRemove.TabIndex = 12
        Me.btnRemove.Text = "&Remove"
        Me.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(843, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(134, 55)
        Me.Panel3.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(20, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 49)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "&Cancel"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.btnadd)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(151, 55)
        Me.Panel8.TabIndex = 9
        '
        'btnadd
        '
        Me.btnadd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Image = CType(resources.GetObject("btnadd.Image"), System.Drawing.Image)
        Me.btnadd.Location = New System.Drawing.Point(12, 3)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(113, 49)
        Me.btnadd.TabIndex = 10
        Me.btnadd.Text = "&Add Item"
        Me.btnadd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnadd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'dgvPO
        '
        Me.dgvPO.AllowUserToAddRows = False
        Me.dgvPO.AllowUserToDeleteRows = False
        Me.dgvPO.AllowUserToResizeColumns = False
        Me.dgvPO.AllowUserToResizeRows = False
        Me.dgvPO.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPO.BackgroundColor = System.Drawing.Color.White
        Me.dgvPO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvPO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPO.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column2, Me.Column3, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.Column1, Me.Column5, Me.Column6})
        Me.dgvPO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPO.Location = New System.Drawing.Point(0, 120)
        Me.dgvPO.Name = "dgvPO"
        Me.dgvPO.ReadOnly = True
        Me.dgvPO.RowHeadersVisible = False
        Me.dgvPO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPO.Size = New System.Drawing.Size(977, 497)
        Me.dgvPO.TabIndex = 15
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "poiddetailstemp"
        Me.Column4.HeaderText = "poid"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Visible = False
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "suppid"
        Me.Column2.HeaderText = "suppid"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Visible = False
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "sup_cname"
        Me.Column3.HeaderText = "sup_cname"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "itemID"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn1.HeaderText = "ItemID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "itemcode"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn2.HeaderText = "Item Code"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "itemtype"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn3.HeaderText = "Item Type"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "description"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn4.FillWeight = 80.0!
        Me.DataGridViewTextBoxColumn4.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "price"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn5.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn5.HeaderText = "Unit Price"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "qty"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.Format = "N0"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column1.FillWeight = 30.0!
        Me.Column1.HeaderText = "Quantity"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "status"
        Me.Column5.HeaderText = "status"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Visible = False
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "ordernum"
        Me.Column6.HeaderText = "ordernum"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Visible = False
        '
        'frmnewPO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(977, 672)
        Me.Controls.Add(Me.dgvPO)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmnewPO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmnewPO"
        Me.Panel1.ResumeLayout(False)
        Me.gboxpo.ResumeLayout(False)
        Me.gboxpo.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        CType(Me.dgvPO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gboxpo As System.Windows.Forms.GroupBox
    Friend WithEvents dtdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbosupplier As System.Windows.Forms.ComboBox
    Friend WithEvents lblponum As System.Windows.Forms.Label
    Friend WithEvents cboorder As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents lblyear As System.Windows.Forms.Label
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents lblpo As System.Windows.Forms.Label
    Friend WithEvents dgvPO As System.Windows.Forms.DataGridView
    Friend WithEvents lblid As System.Windows.Forms.Label
    Friend WithEvents lblcname As System.Windows.Forms.Label
    Friend WithEvents lblsupid As System.Windows.Forms.Label
    Friend WithEvents lblitemid As System.Windows.Forms.Label
    Friend WithEvents lblprice As System.Windows.Forms.Label
    Friend WithEvents lbldesc As System.Windows.Forms.Label
    Friend WithEvents lblitemtype As System.Windows.Forms.Label
    Friend WithEvents lblitemcode As System.Windows.Forms.Label
    Friend WithEvents lbliddddd As System.Windows.Forms.Label
    Friend WithEvents lblqty As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
