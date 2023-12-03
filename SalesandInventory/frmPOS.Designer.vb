<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOS
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOS))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.dgvItem = New System.Windows.Forms.DataGridView()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnSelectitem = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnvoidtrans = New System.Windows.Forms.Button()
        Me.btnvoiditem = New System.Windows.Forms.Button()
        Me.btnQty = New System.Windows.Forms.Button()
        Me.btnitemlookup = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbllocation = New System.Windows.Forms.Label()
        Me.lblcustname = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnnewtransact = New System.Windows.Forms.Button()
        Me.btnpayment = New System.Windows.Forms.Button()
        Me.lbltrans = New System.Windows.Forms.Label()
        Me.lblid = New System.Windows.Forms.Label()
        Me.lblsubtotal1 = New System.Windows.Forms.Label()
        Me.lblqtyitem = New System.Windows.Forms.ToolStripLabel()
        Me.lblposdate = New System.Windows.Forms.ToolStripLabel()
        Me.lbldate = New System.Windows.Forms.ToolStripLabel()
        Me.lbldate1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbldate2 = New System.Windows.Forms.Label()
        Me.lblcustomerID = New System.Windows.Forms.Label()
        Me.lblcustomerno = New System.Windows.Forms.Label()
        Me.lblsubtotal = New System.Windows.Forms.Label()
        Me.pnlitem = New System.Windows.Forms.Panel()
        Me.lbltranstemp = New System.Windows.Forms.Label()
        Me.lbltransid = New System.Windows.Forms.Label()
        Me.zz = New System.Windows.Forms.Label()
        Me.lblcdut = New System.Windows.Forms.Label()
        Me.lblTransNo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.postime = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel13.SuspendLayout()
        CType(Me.dgvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.pnlitem.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel13)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 65)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1102, 682)
        Me.Panel1.TabIndex = 104
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel13.Controls.Add(Me.dgvItem)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel13.Location = New System.Drawing.Point(0, 0)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(1102, 682)
        Me.Panel13.TabIndex = 114
        '
        'dgvItem
        '
        Me.dgvItem.AllowUserToAddRows = False
        Me.dgvItem.AllowUserToDeleteRows = False
        Me.dgvItem.AllowUserToResizeColumns = False
        Me.dgvItem.AllowUserToResizeRows = False
        Me.dgvItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvItem.BackgroundColor = System.Drawing.Color.White
        Me.dgvItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column7, Me.Column1, Me.Column2, Me.Column4, Me.Quantity, Me.Column6, Me.Column8, Me.Column9, Me.Column3, Me.Column10})
        Me.dgvItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvItem.Location = New System.Drawing.Point(0, 0)
        Me.dgvItem.Name = "dgvItem"
        Me.dgvItem.ReadOnly = True
        Me.dgvItem.RowHeadersVisible = False
        Me.dgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvItem.Size = New System.Drawing.Size(1102, 682)
        Me.dgvItem.TabIndex = 14
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "stockid"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column5.HeaderText = "stockID"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column5.Visible = False
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "itemID"
        Me.Column7.HeaderText = "itemID"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Visible = False
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "itemcode"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column1.FillWeight = 50.0!
        Me.Column1.HeaderText = "Item Code"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "itemtype"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column2.HeaderText = "Item Type"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "UnitP"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column4.FillWeight = 50.0!
        Me.Column4.HeaderText = "Unit Price"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Quantity
        '
        Me.Quantity.DataPropertyName = "qty"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.Format = "N0"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.Quantity.DefaultCellStyle = DataGridViewCellStyle5
        Me.Quantity.FillWeight = 50.0!
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "totalprice"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column6.FillWeight = 50.0!
        Me.Column6.HeaderText = "Total Price"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "transId"
        Me.Column8.HeaderText = "transId"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Visible = False
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "ornum"
        Me.Column9.HeaderText = "ornum"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Visible = False
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "clientid"
        Me.Column3.HeaderText = "clientid"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Visible = False
        '
        'Column10
        '
        Me.Column10.DataPropertyName = "status"
        Me.Column10.HeaderText = "status"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyyMMdd"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(293, 31)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 21)
        Me.DateTimePicker1.TabIndex = 113
        '
        'btnSelectitem
        '
        Me.btnSelectitem.BackColor = System.Drawing.SystemColors.Control
        Me.btnSelectitem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectitem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectitem.ForeColor = System.Drawing.Color.Black
        Me.btnSelectitem.Image = CType(resources.GetObject("btnSelectitem.Image"), System.Drawing.Image)
        Me.btnSelectitem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSelectitem.Location = New System.Drawing.Point(0, 96)
        Me.btnSelectitem.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSelectitem.Name = "btnSelectitem"
        Me.btnSelectitem.Size = New System.Drawing.Size(268, 44)
        Me.btnSelectitem.TabIndex = 37
        Me.btnSelectitem.Text = "Select Item"
        Me.btnSelectitem.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Control
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(0, 316)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(268, 44)
        Me.btnExit.TabIndex = 38
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnvoidtrans
        '
        Me.btnvoidtrans.BackColor = System.Drawing.SystemColors.Control
        Me.btnvoidtrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnvoidtrans.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnvoidtrans.ForeColor = System.Drawing.Color.Black
        Me.btnvoidtrans.Image = CType(resources.GetObject("btnvoidtrans.Image"), System.Drawing.Image)
        Me.btnvoidtrans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnvoidtrans.Location = New System.Drawing.Point(0, 272)
        Me.btnvoidtrans.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnvoidtrans.Name = "btnvoidtrans"
        Me.btnvoidtrans.Size = New System.Drawing.Size(268, 44)
        Me.btnvoidtrans.TabIndex = 40
        Me.btnvoidtrans.Text = "Void Transaction"
        Me.btnvoidtrans.UseVisualStyleBackColor = False
        '
        'btnvoiditem
        '
        Me.btnvoiditem.BackColor = System.Drawing.SystemColors.Control
        Me.btnvoiditem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnvoiditem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnvoiditem.ForeColor = System.Drawing.Color.Black
        Me.btnvoiditem.Image = CType(resources.GetObject("btnvoiditem.Image"), System.Drawing.Image)
        Me.btnvoiditem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnvoiditem.Location = New System.Drawing.Point(0, 228)
        Me.btnvoiditem.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnvoiditem.Name = "btnvoiditem"
        Me.btnvoiditem.Size = New System.Drawing.Size(268, 44)
        Me.btnvoiditem.TabIndex = 39
        Me.btnvoiditem.Text = "Void Item"
        Me.btnvoiditem.UseVisualStyleBackColor = False
        '
        'btnQty
        '
        Me.btnQty.BackColor = System.Drawing.SystemColors.Control
        Me.btnQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQty.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQty.ForeColor = System.Drawing.Color.Black
        Me.btnQty.Image = CType(resources.GetObject("btnQty.Image"), System.Drawing.Image)
        Me.btnQty.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQty.Location = New System.Drawing.Point(0, 184)
        Me.btnQty.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnQty.Name = "btnQty"
        Me.btnQty.Size = New System.Drawing.Size(268, 44)
        Me.btnQty.TabIndex = 42
        Me.btnQty.Text = "Quantity"
        Me.btnQty.UseVisualStyleBackColor = False
        '
        'btnitemlookup
        '
        Me.btnitemlookup.BackColor = System.Drawing.SystemColors.Control
        Me.btnitemlookup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnitemlookup.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnitemlookup.ForeColor = System.Drawing.Color.Black
        Me.btnitemlookup.Image = CType(resources.GetObject("btnitemlookup.Image"), System.Drawing.Image)
        Me.btnitemlookup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnitemlookup.Location = New System.Drawing.Point(0, 140)
        Me.btnitemlookup.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnitemlookup.Name = "btnitemlookup"
        Me.btnitemlookup.Size = New System.Drawing.Size(268, 44)
        Me.btnitemlookup.TabIndex = 43
        Me.btnitemlookup.Text = "Item Look Up"
        Me.btnitemlookup.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MintCream
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel8)
        Me.Panel2.Controls.Add(Me.lbllocation)
        Me.Panel2.Controls.Add(Me.lblcustname)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.lbltrans)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(1102, 65)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(268, 682)
        Me.Panel2.TabIndex = 103
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Honeydew
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.Label5)
        Me.Panel8.Location = New System.Drawing.Point(-1, 142)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(269, 47)
        Me.Panel8.TabIndex = 111
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(9, 10)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 22)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = "Customer Name:"
        '
        'lbllocation
        '
        Me.lbllocation.BackColor = System.Drawing.Color.MintCream
        Me.lbllocation.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllocation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbllocation.Location = New System.Drawing.Point(26, 280)
        Me.lbllocation.Name = "lbllocation"
        Me.lbllocation.Size = New System.Drawing.Size(221, 40)
        Me.lbllocation.TabIndex = 35
        Me.lbllocation.Text = "-----------------"
        Me.lbllocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblcustname
        '
        Me.lblcustname.BackColor = System.Drawing.Color.MintCream
        Me.lblcustname.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcustname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblcustname.Location = New System.Drawing.Point(26, 190)
        Me.lblcustname.Name = "lblcustname"
        Me.lblcustname.Size = New System.Drawing.Size(221, 40)
        Me.lblcustname.TabIndex = 37
        Me.lblcustname.Text = "-----------------"
        Me.lblcustname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Honeydew
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.Label4)
        Me.Panel7.Location = New System.Drawing.Point(-1, 231)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(269, 47)
        Me.Panel7.TabIndex = 106
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(3, 10)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 22)
        Me.Label4.TabIndex = 110
        Me.Label4.Text = "Payment Method:"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Honeydew
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Location = New System.Drawing.Point(-1, 95)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(269, 47)
        Me.Panel6.TabIndex = 105
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(6, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 22)
        Me.Label3.TabIndex = 94
        Me.Label3.Text = "Customer Details "
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Honeydew
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Location = New System.Drawing.Point(-1, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(269, 47)
        Me.Panel5.TabIndex = 104
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(6, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(134, 22)
        Me.Label7.TabIndex = 93
        Me.Label7.Text = "Transaction#:"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnnewtransact)
        Me.Panel4.Controls.Add(Me.btnpayment)
        Me.Panel4.Controls.Add(Me.btnExit)
        Me.Panel4.Controls.Add(Me.btnvoidtrans)
        Me.Panel4.Controls.Add(Me.btnvoiditem)
        Me.Panel4.Controls.Add(Me.btnQty)
        Me.Panel4.Controls.Add(Me.btnitemlookup)
        Me.Panel4.Controls.Add(Me.btnSelectitem)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 320)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(266, 360)
        Me.Panel4.TabIndex = 103
        '
        'btnnewtransact
        '
        Me.btnnewtransact.BackColor = System.Drawing.SystemColors.Control
        Me.btnnewtransact.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnewtransact.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnewtransact.ForeColor = System.Drawing.Color.Black
        Me.btnnewtransact.Image = CType(resources.GetObject("btnnewtransact.Image"), System.Drawing.Image)
        Me.btnnewtransact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnnewtransact.Location = New System.Drawing.Point(0, 8)
        Me.btnnewtransact.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnnewtransact.Name = "btnnewtransact"
        Me.btnnewtransact.Size = New System.Drawing.Size(268, 44)
        Me.btnnewtransact.TabIndex = 103
        Me.btnnewtransact.Text = "New Transaction"
        Me.btnnewtransact.UseVisualStyleBackColor = True
        '
        'btnpayment
        '
        Me.btnpayment.BackColor = System.Drawing.SystemColors.Control
        Me.btnpayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpayment.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpayment.ForeColor = System.Drawing.Color.Black
        Me.btnpayment.Image = CType(resources.GetObject("btnpayment.Image"), System.Drawing.Image)
        Me.btnpayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnpayment.Location = New System.Drawing.Point(0, 52)
        Me.btnpayment.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnpayment.Name = "btnpayment"
        Me.btnpayment.Size = New System.Drawing.Size(268, 44)
        Me.btnpayment.TabIndex = 102
        Me.btnpayment.Text = "Payment"
        Me.btnpayment.UseVisualStyleBackColor = True
        '
        'lbltrans
        '
        Me.lbltrans.BackColor = System.Drawing.Color.MintCream
        Me.lbltrans.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltrans.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbltrans.Location = New System.Drawing.Point(22, 50)
        Me.lbltrans.Name = "lbltrans"
        Me.lbltrans.Size = New System.Drawing.Size(221, 40)
        Me.lbltrans.TabIndex = 6
        Me.lbltrans.Text = "---------"
        Me.lbltrans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblid
        '
        Me.lblid.BackColor = System.Drawing.Color.Silver
        Me.lblid.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid.ForeColor = System.Drawing.Color.Black
        Me.lblid.Location = New System.Drawing.Point(324, 18)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(221, 40)
        Me.lblid.TabIndex = 7
        Me.lblid.Text = "---------"
        Me.lblid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblid.Visible = False
        '
        'lblsubtotal1
        '
        Me.lblsubtotal1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsubtotal1.ForeColor = System.Drawing.Color.White
        Me.lblsubtotal1.Location = New System.Drawing.Point(1022, 4)
        Me.lblsubtotal1.Name = "lblsubtotal1"
        Me.lblsubtotal1.Size = New System.Drawing.Size(220, 60)
        Me.lblsubtotal1.TabIndex = 99
        Me.lblsubtotal1.Text = "0.00"
        Me.lblsubtotal1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblsubtotal1.Visible = False
        '
        'lblqtyitem
        '
        Me.lblqtyitem.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblqtyitem.Name = "lblqtyitem"
        Me.lblqtyitem.Size = New System.Drawing.Size(91, 22)
        Me.lblqtyitem.Text = "                     "
        Me.lblqtyitem.Visible = False
        '
        'lblposdate
        '
        Me.lblposdate.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblposdate.Name = "lblposdate"
        Me.lblposdate.Size = New System.Drawing.Size(11, 22)
        Me.lblposdate.Text = " "
        '
        'lbldate
        '
        Me.lbldate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(59, 22)
        Me.lbldate.Text = "             "
        Me.lbldate.Visible = False
        '
        'lbldate1
        '
        Me.lbldate1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate1.Name = "lbldate1"
        Me.lbldate1.Size = New System.Drawing.Size(59, 22)
        Me.lbldate1.Text = "             "
        Me.lbldate1.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblqtyitem, Me.lblposdate, Me.lbldate, Me.lbldate1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 747)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1370, 25)
        Me.ToolStrip1.TabIndex = 102
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lbldate2)
        Me.Panel3.Controls.Add(Me.lblcustomerID)
        Me.Panel3.Controls.Add(Me.lblcustomerno)
        Me.Panel3.Controls.Add(Me.lblsubtotal1)
        Me.Panel3.Controls.Add(Me.lblsubtotal)
        Me.Panel3.Controls.Add(Me.pnlitem)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1370, 65)
        Me.Panel3.TabIndex = 1
        '
        'lbldate2
        '
        Me.lbldate2.AutoSize = True
        Me.lbldate2.Location = New System.Drawing.Point(551, 41)
        Me.lbldate2.Name = "lbldate2"
        Me.lbldate2.Size = New System.Drawing.Size(46, 14)
        Me.lbldate2.TabIndex = 114
        Me.lbldate2.Text = "Label4"
        Me.lbldate2.Visible = False
        '
        'lblcustomerID
        '
        Me.lblcustomerID.AutoSize = True
        Me.lblcustomerID.Location = New System.Drawing.Point(824, 13)
        Me.lblcustomerID.Name = "lblcustomerID"
        Me.lblcustomerID.Size = New System.Drawing.Size(46, 14)
        Me.lblcustomerID.TabIndex = 113
        Me.lblcustomerID.Text = "Label4"
        Me.lblcustomerID.Visible = False
        '
        'lblcustomerno
        '
        Me.lblcustomerno.AutoSize = True
        Me.lblcustomerno.Location = New System.Drawing.Point(727, 8)
        Me.lblcustomerno.Name = "lblcustomerno"
        Me.lblcustomerno.Size = New System.Drawing.Size(90, 14)
        Me.lblcustomerno.TabIndex = 112
        Me.lblcustomerno.Text = "lblcustomerno"
        Me.lblcustomerno.Visible = False
        '
        'lblsubtotal
        '
        Me.lblsubtotal.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblsubtotal.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblsubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold)
        Me.lblsubtotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblsubtotal.Location = New System.Drawing.Point(1122, 0)
        Me.lblsubtotal.Name = "lblsubtotal"
        Me.lblsubtotal.Size = New System.Drawing.Size(246, 63)
        Me.lblsubtotal.TabIndex = 111
        Me.lblsubtotal.Text = "0.00"
        Me.lblsubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlitem
        '
        Me.pnlitem.BackColor = System.Drawing.Color.Honeydew
        Me.pnlitem.Controls.Add(Me.lbltranstemp)
        Me.pnlitem.Controls.Add(Me.lbltransid)
        Me.pnlitem.Controls.Add(Me.zz)
        Me.pnlitem.Controls.Add(Me.lblcdut)
        Me.pnlitem.Controls.Add(Me.lblTransNo)
        Me.pnlitem.Controls.Add(Me.lblid)
        Me.pnlitem.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlitem.Location = New System.Drawing.Point(0, 0)
        Me.pnlitem.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pnlitem.Name = "pnlitem"
        Me.pnlitem.Size = New System.Drawing.Size(543, 63)
        Me.pnlitem.TabIndex = 102
        '
        'lbltranstemp
        '
        Me.lbltranstemp.AutoSize = True
        Me.lbltranstemp.Location = New System.Drawing.Point(474, 23)
        Me.lbltranstemp.Name = "lbltranstemp"
        Me.lbltranstemp.Size = New System.Drawing.Size(48, 14)
        Me.lbltranstemp.TabIndex = 112
        Me.lbltranstemp.Text = "transid"
        Me.lbltranstemp.Visible = False
        '
        'lbltransid
        '
        Me.lbltransid.AutoSize = True
        Me.lbltransid.Location = New System.Drawing.Point(412, 41)
        Me.lbltransid.Name = "lbltransid"
        Me.lbltransid.Size = New System.Drawing.Size(48, 14)
        Me.lbltransid.TabIndex = 111
        Me.lbltransid.Text = "transid"
        Me.lbltransid.Visible = False
        '
        'zz
        '
        Me.zz.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.zz.AutoSize = True
        Me.zz.BackColor = System.Drawing.Color.Honeydew
        Me.zz.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.zz.ForeColor = System.Drawing.Color.Black
        Me.zz.Location = New System.Drawing.Point(13, 8)
        Me.zz.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.zz.Name = "zz"
        Me.zz.Size = New System.Drawing.Size(101, 24)
        Me.zz.TabIndex = 109
        Me.zz.Text = "Cashier :"
        '
        'lblcdut
        '
        Me.lblcdut.BackColor = System.Drawing.Color.Honeydew
        Me.lblcdut.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcdut.ForeColor = System.Drawing.Color.Black
        Me.lblcdut.Location = New System.Drawing.Point(152, 15)
        Me.lblcdut.Name = "lblcdut"
        Me.lblcdut.Size = New System.Drawing.Size(213, 42)
        Me.lblcdut.TabIndex = 110
        Me.lblcdut.Text = "Admin"
        Me.lblcdut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTransNo
        '
        Me.lblTransNo.AutoSize = True
        Me.lblTransNo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransNo.ForeColor = System.Drawing.Color.White
        Me.lblTransNo.Location = New System.Drawing.Point(338, 8)
        Me.lblTransNo.Name = "lblTransNo"
        Me.lblTransNo.Size = New System.Drawing.Size(184, 21)
        Me.lblTransNo.TabIndex = 106
        Me.lblTransNo.Text = "        transno                     "
        Me.lblTransNo.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(551, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 28)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "AMOUNT"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel9.Controls.Add(Me.Panel3)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1370, 65)
        Me.Panel9.TabIndex = 101
        '
        'postime
        '
        '
        'frmPOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 772)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel9)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmPOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Specter Enterprise Furniture Manufacturing | Sales Transaction"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        CType(Me.dgvItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.pnlitem.ResumeLayout(False)
        Me.pnlitem.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSelectitem As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnvoidtrans As System.Windows.Forms.Button
    Friend WithEvents btnvoiditem As System.Windows.Forms.Button
    Friend WithEvents btnQty As System.Windows.Forms.Button
    Friend WithEvents btnitemlookup As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblqtyitem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lblposdate As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lbldate As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lbldate1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblTransNo As System.Windows.Forms.Label
    Friend WithEvents pnlitem As System.Windows.Forms.Panel
    Friend WithEvents zz As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents postime As System.Windows.Forms.Timer
    Friend WithEvents lblcdut As System.Windows.Forms.Label
    Friend WithEvents dgvItem As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnpayment As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents lbltrans As System.Windows.Forms.Label
    Friend WithEvents lblsubtotal1 As System.Windows.Forms.Label
    Friend WithEvents lblsubtotal As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbllocation As System.Windows.Forms.Label
    Friend WithEvents lblcustomerno As System.Windows.Forms.Label
    Friend WithEvents lblcustomerID As System.Windows.Forms.Label
    Friend WithEvents lbldate2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblcustname As System.Windows.Forms.Label
    Friend WithEvents lbltransid As System.Windows.Forms.Label
    Friend WithEvents lblid As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnnewtransact As System.Windows.Forms.Button
    Friend WithEvents lbltranstemp As System.Windows.Forms.Label
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
End Class
