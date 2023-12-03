<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceived
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReceived))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.pnlrec = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblpo = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtdelivery = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboReceivedby = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtdate = New System.Windows.Forms.DateTimePicker()
        Me.lbldater = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.lblsupplier = New System.Windows.Forms.Label()
        Me.datee = New System.Windows.Forms.Label()
        Me.cboPOno = New System.Windows.Forms.ComboBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dgvRitem = New System.Windows.Forms.DataGridView()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.pnlrec.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgvRitem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Honeydew
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1255, 60)
        Me.Panel1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(17, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(247, 37)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Receiving Item"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Honeydew
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 519)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1255, 60)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnCancel)
        Me.Panel3.Controls.Add(Me.btnSave)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(769, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(486, 60)
        Me.Panel3.TabIndex = 28
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(386, 6)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(93, 49)
        Me.btnCancel.TabIndex = 27
        Me.btnCancel.Text = "Ca&ncel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(287, 6)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(93, 49)
        Me.btnSave.TabIndex = 26
        Me.btnSave.Text = "&Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'pnlrec
        '
        Me.pnlrec.BackColor = System.Drawing.Color.MintCream
        Me.pnlrec.Controls.Add(Me.GroupBox1)
        Me.pnlrec.Controls.Add(Me.lblsupplier)
        Me.pnlrec.Controls.Add(Me.datee)
        Me.pnlrec.Controls.Add(Me.cboPOno)
        Me.pnlrec.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlrec.Location = New System.Drawing.Point(0, 60)
        Me.pnlrec.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pnlrec.Name = "pnlrec"
        Me.pnlrec.Size = New System.Drawing.Size(361, 459)
        Me.pnlrec.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.MintCream
        Me.GroupBox1.Controls.Add(Me.lblpo)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtdelivery)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cboReceivedby)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtdate)
        Me.GroupBox1.Controls.Add(Me.lbldater)
        Me.GroupBox1.Controls.Add(Me.lbldate)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(361, 359)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Receiving Information"
        '
        'lblpo
        '
        Me.lblpo.AutoSize = True
        Me.lblpo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpo.Location = New System.Drawing.Point(158, 154)
        Me.lblpo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblpo.Name = "lblpo"
        Me.lblpo.Size = New System.Drawing.Size(104, 22)
        Me.lblpo.TabIndex = 44
        Me.lblpo.Text = "0000-0000"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(162, 97)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 40)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "S&elect PO Number"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 49)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 22)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Delivery No. :"
        '
        'txtdelivery
        '
        Me.txtdelivery.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdelivery.Location = New System.Drawing.Point(162, 49)
        Me.txtdelivery.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtdelivery.Name = "txtdelivery"
        Me.txtdelivery.Size = New System.Drawing.Size(183, 26)
        Me.txtdelivery.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 154)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 22)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "PO Number :"
        '
        'cboReceivedby
        '
        Me.cboReceivedby.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboReceivedby.FormattingEnabled = True
        Me.cboReceivedby.Location = New System.Drawing.Point(162, 257)
        Me.cboReceivedby.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cboReceivedby.Name = "cboReceivedby"
        Me.cboReceivedby.Size = New System.Drawing.Size(183, 26)
        Me.cboReceivedby.TabIndex = 42
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 255)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 22)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Received By :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 209)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 22)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Date Received :"
        '
        'dtdate
        '
        Me.dtdate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtdate.Location = New System.Drawing.Point(162, 209)
        Me.dtdate.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dtdate.Name = "dtdate"
        Me.dtdate.Size = New System.Drawing.Size(183, 26)
        Me.dtdate.TabIndex = 40
        '
        'lbldater
        '
        Me.lbldater.AutoSize = True
        Me.lbldater.BackColor = System.Drawing.Color.White
        Me.lbldater.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldater.Location = New System.Drawing.Point(184, 339)
        Me.lbldater.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldater.Name = "lbldater"
        Me.lbldater.Size = New System.Drawing.Size(98, 17)
        Me.lbldater.TabIndex = 45
        Me.lbldater.Text = "        123123 "
        Me.lbldater.Visible = False
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.BackColor = System.Drawing.Color.White
        Me.lbldate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(201, 310)
        Me.lbldate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(98, 17)
        Me.lbldate.TabIndex = 43
        Me.lbldate.Text = "        123123 "
        Me.lbldate.Visible = False
        '
        'lblsupplier
        '
        Me.lblsupplier.AutoSize = True
        Me.lblsupplier.BackColor = System.Drawing.Color.White
        Me.lblsupplier.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsupplier.Location = New System.Drawing.Point(255, 416)
        Me.lblsupplier.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblsupplier.Name = "lblsupplier"
        Me.lblsupplier.Size = New System.Drawing.Size(44, 17)
        Me.lblsupplier.TabIndex = 44
        Me.lblsupplier.Text = "         "
        Me.lblsupplier.Visible = False
        '
        'datee
        '
        Me.datee.AutoSize = True
        Me.datee.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datee.Location = New System.Drawing.Point(19, 417)
        Me.datee.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.datee.Name = "datee"
        Me.datee.Size = New System.Drawing.Size(106, 17)
        Me.datee.TabIndex = 45
        Me.datee.Text = "Delivery No. :"
        Me.datee.Visible = False
        '
        'cboPOno
        '
        Me.cboPOno.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPOno.FormattingEnabled = True
        Me.cboPOno.Location = New System.Drawing.Point(144, 399)
        Me.cboPOno.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cboPOno.Name = "cboPOno"
        Me.cboPOno.Size = New System.Drawing.Size(94, 24)
        Me.cboPOno.TabIndex = 38
        Me.cboPOno.Visible = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.dgvRitem)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(361, 60)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(894, 459)
        Me.Panel4.TabIndex = 3
        '
        'dgvRitem
        '
        Me.dgvRitem.AllowUserToAddRows = False
        Me.dgvRitem.AllowUserToDeleteRows = False
        Me.dgvRitem.AllowUserToResizeColumns = False
        Me.dgvRitem.AllowUserToResizeRows = False
        Me.dgvRitem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRitem.BackgroundColor = System.Drawing.Color.White
        Me.dgvRitem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvRitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvRitem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.Column7, Me.Column1, Me.Column9, Me.Column2, Me.Column10, Me.Column3, Me.Column4, Me.Column5, Me.Column8})
        Me.dgvRitem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRitem.Location = New System.Drawing.Point(0, 0)
        Me.dgvRitem.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dgvRitem.Name = "dgvRitem"
        Me.dgvRitem.ReadOnly = True
        Me.dgvRitem.RowHeadersVisible = False
        Me.dgvRitem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRitem.Size = New System.Drawing.Size(894, 459)
        Me.dgvRitem.TabIndex = 15
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "itemID"
        Me.Column6.HeaderText = "ID"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Visible = False
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "itemcode"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column7.FillWeight = 50.0!
        Me.Column7.HeaderText = "Item Code"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "itemtype"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column1.HeaderText = "Item Type"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "sup_cname"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column9.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column9.HeaderText = "Supplier"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "Description"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column2.HeaderText = "Description"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Visible = False
        '
        'Column10
        '
        Me.Column10.DataPropertyName = "price"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.Format = "N2"
        Me.Column10.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column10.FillWeight = 50.0!
        Me.Column10.HeaderText = "Supplier Price"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "UnitP"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.Format = "N2"
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column3.FillWeight = 50.0!
        Me.Column3.HeaderText = "Unit Price"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "quantity"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle7
        Me.Column4.FillWeight = 20.0!
        Me.Column4.HeaderText = "Qty"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "Total"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.Format = "N2"
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle8
        Me.Column5.FillWeight = 75.0!
        Me.Column5.HeaderText = "Total Amount"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "porderid"
        Me.Column8.HeaderText = "porder_id"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Visible = False
        '
        'frmReceived
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1255, 579)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.pnlrec)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmReceived"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RecItem"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.pnlrec.ResumeLayout(False)
        Me.pnlrec.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.dgvRitem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents pnlrec As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtdelivery As System.Windows.Forms.TextBox
    Friend WithEvents cboPOno As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboReceivedby As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvRitem As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblsupplier As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblpo As System.Windows.Forms.Label
    Friend WithEvents datee As System.Windows.Forms.Label
    Friend WithEvents lbldater As System.Windows.Forms.Label
End Class
