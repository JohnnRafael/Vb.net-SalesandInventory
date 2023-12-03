<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mainform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mainform))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatuslbluser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblactiveuser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatuslblposition = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblposition = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatuslbldt = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblmaindt = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblmaindt2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbldate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblmaindt3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblitemtype = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnedItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnedItemsToSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnedItemsFromClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FullyPaidToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DownPaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventoryReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdatePaymentTransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ListOfReturnedItemsFromClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.BackColor = System.Drawing.Color.MintCream
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatuslbluser, Me.lblactiveuser, Me.ToolStripStatuslblposition, Me.lblposition, Me.ToolStripStatuslbldt, Me.lblmaindt, Me.lblmaindt2, Me.lbldate, Me.lblmaindt3})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 477)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(954, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatuslbluser
        '
        Me.ToolStripStatuslbluser.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatuslbluser.Name = "ToolStripStatuslbluser"
        Me.ToolStripStatuslbluser.Size = New System.Drawing.Size(82, 17)
        Me.ToolStripStatuslbluser.Text = "Active User:"
        '
        'lblactiveuser
        '
        Me.lblactiveuser.AutoSize = False
        Me.lblactiveuser.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblactiveuser.Name = "lblactiveuser"
        Me.lblactiveuser.Size = New System.Drawing.Size(140, 17)
        '
        'ToolStripStatuslblposition
        '
        Me.ToolStripStatuslblposition.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatuslblposition.Name = "ToolStripStatuslblposition"
        Me.ToolStripStatuslblposition.Size = New System.Drawing.Size(62, 17)
        Me.ToolStripStatuslblposition.Text = "Position:"
        '
        'lblposition
        '
        Me.lblposition.AutoSize = False
        Me.lblposition.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblposition.Name = "lblposition"
        Me.lblposition.Size = New System.Drawing.Size(150, 17)
        '
        'ToolStripStatuslbldt
        '
        Me.ToolStripStatuslbldt.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatuslbldt.Name = "ToolStripStatuslbldt"
        Me.ToolStripStatuslbldt.Size = New System.Drawing.Size(103, 17)
        Me.ToolStripStatuslbldt.Text = "Date and Time:"
        Me.ToolStripStatuslbldt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblmaindt
        '
        Me.lblmaindt.AutoSize = False
        Me.lblmaindt.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmaindt.Name = "lblmaindt"
        Me.lblmaindt.Size = New System.Drawing.Size(200, 17)
        Me.lblmaindt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblmaindt2
        '
        Me.lblmaindt2.AutoSize = False
        Me.lblmaindt2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmaindt2.Name = "lblmaindt2"
        Me.lblmaindt2.Size = New System.Drawing.Size(200, 17)
        Me.lblmaindt2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblmaindt2.Visible = False
        '
        'lbldate
        '
        Me.lbldate.AutoSize = False
        Me.lbldate.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(200, 17)
        Me.lbldate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbldate.Visible = False
        '
        'lblmaindt3
        '
        Me.lblmaindt3.AutoSize = False
        Me.lblmaindt3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmaindt3.Name = "lblmaindt3"
        Me.lblmaindt3.Size = New System.Drawing.Size(200, 17)
        Me.lblmaindt3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblmaindt3.Visible = False
        '
        'Timer1
        '
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MintCream
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(954, 28)
        Me.Panel2.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(393, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Specter Enterprise | Sales and Inventory System"
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.MintCream
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.ReturnedItemsToolStripMenuItem, Me.BackToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 28)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(7, 1, 0, 1)
        Me.MenuStrip.Size = New System.Drawing.Size(954, 24)
        Me.MenuStrip.TabIndex = 13
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblitemtype, Me.ToolStripSeparator1, Me.UsersToolStripMenuItem})
        Me.FileMenu.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(130, 22)
        Me.FileMenu.Text = "&File Maintenance"
        '
        'lblitemtype
        '
        Me.lblitemtype.Name = "lblitemtype"
        Me.lblitemtype.Size = New System.Drawing.Size(137, 22)
        Me.lblitemtype.Text = "Item Type"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(134, 6)
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.UsersToolStripMenuItem.Text = "Users"
        '
        'ReturnedItemsToolStripMenuItem
        '
        Me.ReturnedItemsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToSupplierToolStripMenuItem, Me.ReturnedItemsToSupplierToolStripMenuItem, Me.ReturnedItemsFromClientToolStripMenuItem, Me.ListOfReturnedItemsFromClientToolStripMenuItem})
        Me.ReturnedItemsToolStripMenuItem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReturnedItemsToolStripMenuItem.Name = "ReturnedItemsToolStripMenuItem"
        Me.ReturnedItemsToolStripMenuItem.Size = New System.Drawing.Size(95, 22)
        Me.ReturnedItemsToolStripMenuItem.Text = "Return Item"
        '
        'ToSupplierToolStripMenuItem
        '
        Me.ToSupplierToolStripMenuItem.Name = "ToSupplierToolStripMenuItem"
        Me.ToSupplierToolStripMenuItem.Size = New System.Drawing.Size(297, 22)
        Me.ToSupplierToolStripMenuItem.Text = "Return Items To Supplier"
        '
        'ReturnedItemsToSupplierToolStripMenuItem
        '
        Me.ReturnedItemsToSupplierToolStripMenuItem.Name = "ReturnedItemsToSupplierToolStripMenuItem"
        Me.ReturnedItemsToSupplierToolStripMenuItem.Size = New System.Drawing.Size(297, 22)
        Me.ReturnedItemsToSupplierToolStripMenuItem.Text = "List of Returned Items to Suppplier"
        '
        'ReturnedItemsFromClientToolStripMenuItem
        '
        Me.ReturnedItemsFromClientToolStripMenuItem.Name = "ReturnedItemsFromClientToolStripMenuItem"
        Me.ReturnedItemsFromClientToolStripMenuItem.Size = New System.Drawing.Size(297, 22)
        Me.ReturnedItemsFromClientToolStripMenuItem.Text = "Returned Items From Client"
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.BackToolStripMenuItem.Text = "Backup and Restore"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalesReportToolStripMenuItem, Me.InventoryReportToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(70, 22)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'SalesReportToolStripMenuItem
        '
        Me.SalesReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FullyPaidToolStripMenuItem, Me.DownPaymentToolStripMenuItem})
        Me.SalesReportToolStripMenuItem.Name = "SalesReportToolStripMenuItem"
        Me.SalesReportToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.SalesReportToolStripMenuItem.Text = "Sales Report"
        '
        'FullyPaidToolStripMenuItem
        '
        Me.FullyPaidToolStripMenuItem.Name = "FullyPaidToolStripMenuItem"
        Me.FullyPaidToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.FullyPaidToolStripMenuItem.Text = "Fully Paid"
        '
        'DownPaymentToolStripMenuItem
        '
        Me.DownPaymentToolStripMenuItem.Name = "DownPaymentToolStripMenuItem"
        Me.DownPaymentToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.DownPaymentToolStripMenuItem.Text = "50% Down Payment"
        '
        'InventoryReportToolStripMenuItem
        '
        Me.InventoryReportToolStripMenuItem.Name = "InventoryReportToolStripMenuItem"
        Me.InventoryReportToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.InventoryReportToolStripMenuItem.Text = "Inventory Report"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdatePaymentTransactionToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(73, 22)
        Me.ToolStripMenuItem1.Text = "Settings"
        '
        'UpdatePaymentTransactionToolStripMenuItem
        '
        Me.UpdatePaymentTransactionToolStripMenuItem.Name = "UpdatePaymentTransactionToolStripMenuItem"
        Me.UpdatePaymentTransactionToolStripMenuItem.Size = New System.Drawing.Size(262, 22)
        Me.UpdatePaymentTransactionToolStripMenuItem.Text = "Update Payment Transaction"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(262, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.MintCream
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.ToolStripSeparator2, Me.ToolStripButton1, Me.ToolStripSeparator3, Me.ToolStripButton4, Me.ToolStripSeparator4, Me.ToolStripButton3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 52)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(954, 90)
        Me.ToolStrip1.TabIndex = 14
        Me.ToolStrip1.Text = "Tsmenu"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.CheckOnClick = True
        Me.ToolStripButton2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(68, 87)
        Me.ToolStripButton2.Text = "Sales"
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 90)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.CheckOnClick = True
        Me.ToolStripButton1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(88, 87)
        Me.ToolStripButton1.Text = "Inventory"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 90)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.CheckOnClick = True
        Me.ToolStripButton4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(78, 87)
        Me.ToolStripButton4.Text = "Supplier"
        Me.ToolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 90)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.CheckOnClick = True
        Me.ToolStripButton3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(140, 87)
        Me.ToolStripButton3.Text = "Purchase Order"
        Me.ToolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ListOfReturnedItemsFromClientToolStripMenuItem
        '
        Me.ListOfReturnedItemsFromClientToolStripMenuItem.Name = "ListOfReturnedItemsFromClientToolStripMenuItem"
        Me.ListOfReturnedItemsFromClientToolStripMenuItem.Size = New System.Drawing.Size(297, 22)
        Me.ListOfReturnedItemsFromClientToolStripMenuItem.Text = "List of Returned Items From Client"
        '
        'Mainform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(954, 499)
        Me.ControlBox = False
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.StatusStrip)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "Mainform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Specter Enterprise | Sales and Inventory"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolStripStatuslbldt As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblmaindt As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbldate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblitemtype As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents InventoryReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblmaindt2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UsersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatuslbluser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblactiveuser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatuslblposition As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblposition As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SalesReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FullyPaidToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DownPaymentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdatePaymentTransactionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblmaindt3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ReturnedItemsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToSupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReturnedItemsToSupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReturnedItemsFromClientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListOfReturnedItemsFromClientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
