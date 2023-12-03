<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmreturnitemdetailsfromclient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmreturnitemdetailsfromclient))
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.lblqty = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbltransid = New System.Windows.Forms.Label()
        Me.lblornum = New System.Windows.Forms.Label()
        Me.lblitemid = New System.Windows.Forms.Label()
        Me.lblclientid = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboreason = New System.Windows.Forms.ComboBox()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblprice = New System.Windows.Forms.Label()
        Me.lblitemtype = New System.Windows.Forms.Label()
        Me.lblitemcode = New System.Windows.Forms.Label()
        Me.lblclientname = New System.Windows.Forms.Label()
        Me.txtother = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Honeydew
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.lbldate)
        Me.Panel5.Controls.Add(Me.lblqty)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(728, 70)
        Me.Panel5.TabIndex = 39
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(316, 21)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(59, 24)
        Me.lbldate.TabIndex = 54
        Me.lbldate.Text = "-------"
        Me.lbldate.Visible = False
        '
        'lblqty
        '
        Me.lblqty.AutoSize = True
        Me.lblqty.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblqty.Location = New System.Drawing.Point(422, 21)
        Me.lblqty.Name = "lblqty"
        Me.lblqty.Size = New System.Drawing.Size(59, 24)
        Me.lblqty.TabIndex = 53
        Me.lblqty.Text = "-------"
        Me.lblqty.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(257, 24)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "RETURN INFORMATION"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Honeydew
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 394)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(728, 70)
        Me.Panel1.TabIndex = 40
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnSave)
        Me.Panel3.Controls.Add(Me.btnCancel)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(508, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(218, 68)
        Me.Panel3.TabIndex = 41
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(12, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(93, 49)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "&Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(111, 8)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(93, 49)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Ca&ncel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MintCream
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lbltransid)
        Me.Panel2.Controls.Add(Me.lblornum)
        Me.Panel2.Controls.Add(Me.lblitemid)
        Me.Panel2.Controls.Add(Me.lblclientid)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.cboreason)
        Me.Panel2.Controls.Add(Me.txtqty)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.lblprice)
        Me.Panel2.Controls.Add(Me.lblitemtype)
        Me.Panel2.Controls.Add(Me.lblitemcode)
        Me.Panel2.Controls.Add(Me.lblclientname)
        Me.Panel2.Controls.Add(Me.txtother)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 70)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(728, 324)
        Me.Panel2.TabIndex = 41
        '
        'lbltransid
        '
        Me.lbltransid.AutoSize = True
        Me.lbltransid.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltransid.Location = New System.Drawing.Point(579, 48)
        Me.lbltransid.Name = "lbltransid"
        Me.lbltransid.Size = New System.Drawing.Size(59, 24)
        Me.lbltransid.TabIndex = 50
        Me.lbltransid.Text = "-------"
        Me.lbltransid.Visible = False
        '
        'lblornum
        '
        Me.lblornum.AutoSize = True
        Me.lblornum.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblornum.Location = New System.Drawing.Point(445, 84)
        Me.lblornum.Name = "lblornum"
        Me.lblornum.Size = New System.Drawing.Size(59, 24)
        Me.lblornum.TabIndex = 49
        Me.lblornum.Text = "-------"
        Me.lblornum.Visible = False
        '
        'lblitemid
        '
        Me.lblitemid.AutoSize = True
        Me.lblitemid.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblitemid.Location = New System.Drawing.Point(445, 48)
        Me.lblitemid.Name = "lblitemid"
        Me.lblitemid.Size = New System.Drawing.Size(59, 24)
        Me.lblitemid.TabIndex = 48
        Me.lblitemid.Text = "-------"
        Me.lblitemid.Visible = False
        '
        'lblclientid
        '
        Me.lblclientid.AutoSize = True
        Me.lblclientid.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclientid.Location = New System.Drawing.Point(445, 13)
        Me.lblclientid.Name = "lblclientid"
        Me.lblclientid.Size = New System.Drawing.Size(59, 24)
        Me.lblclientid.TabIndex = 47
        Me.lblclientid.Text = "-------"
        Me.lblclientid.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(60, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(172, 24)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Others Reason :"
        '
        'cboreason
        '
        Me.cboreason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboreason.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboreason.FormattingEnabled = True
        Me.cboreason.Items.AddRange(New Object() {"---Select Reason---", "Defective", "Sent Wrong Item", "Damage in Shipment", "Missing Item"})
        Me.cboreason.Location = New System.Drawing.Point(238, 153)
        Me.cboreason.Name = "cboreason"
        Me.cboreason.Size = New System.Drawing.Size(316, 32)
        Me.cboreason.TabIndex = 45
        '
        'txtqty
        '
        Me.txtqty.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqty.Location = New System.Drawing.Point(238, 229)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(92, 32)
        Me.txtqty.TabIndex = 44
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(124, 232)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(108, 24)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "Quantity :"
        '
        'lblprice
        '
        Me.lblprice.AutoSize = True
        Me.lblprice.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprice.Location = New System.Drawing.Point(234, 117)
        Me.lblprice.Name = "lblprice"
        Me.lblprice.Size = New System.Drawing.Size(59, 24)
        Me.lblprice.TabIndex = 42
        Me.lblprice.Text = "-------"
        '
        'lblitemtype
        '
        Me.lblitemtype.AutoSize = True
        Me.lblitemtype.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblitemtype.Location = New System.Drawing.Point(234, 84)
        Me.lblitemtype.Name = "lblitemtype"
        Me.lblitemtype.Size = New System.Drawing.Size(59, 24)
        Me.lblitemtype.TabIndex = 41
        Me.lblitemtype.Text = "-------"
        '
        'lblitemcode
        '
        Me.lblitemcode.AutoSize = True
        Me.lblitemcode.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblitemcode.Location = New System.Drawing.Point(234, 48)
        Me.lblitemcode.Name = "lblitemcode"
        Me.lblitemcode.Size = New System.Drawing.Size(59, 24)
        Me.lblitemcode.TabIndex = 40
        Me.lblitemcode.Text = "-------"
        '
        'lblclientname
        '
        Me.lblclientname.AutoSize = True
        Me.lblclientname.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclientname.Location = New System.Drawing.Point(234, 13)
        Me.lblclientname.Name = "lblclientname"
        Me.lblclientname.Size = New System.Drawing.Size(59, 24)
        Me.lblclientname.TabIndex = 39
        Me.lblclientname.Text = "-------"
        '
        'txtother
        '
        Me.txtother.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtother.Location = New System.Drawing.Point(238, 191)
        Me.txtother.Name = "txtother"
        Me.txtother.Size = New System.Drawing.Size(316, 32)
        Me.txtother.TabIndex = 38
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(86, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(146, 24)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Client Name :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(206, 24)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Reason for Return :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(110, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 24)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Unit Price :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(111, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 24)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Item Type :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(106, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 24)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Item Code :"
        '
        'frmreturnitemdetailsfromclient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 464)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel5)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmreturnitemdetailsfromclient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmreturnitemdetailsfromclient"
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents lblqty As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblornum As System.Windows.Forms.Label
    Friend WithEvents lblitemid As System.Windows.Forms.Label
    Friend WithEvents lblclientid As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboreason As System.Windows.Forms.ComboBox
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblprice As System.Windows.Forms.Label
    Friend WithEvents lblitemtype As System.Windows.Forms.Label
    Friend WithEvents lblitemcode As System.Windows.Forms.Label
    Friend WithEvents lblclientname As System.Windows.Forms.Label
    Friend WithEvents txtother As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbltransid As System.Windows.Forms.Label
End Class
