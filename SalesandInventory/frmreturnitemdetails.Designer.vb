<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmreturnitemdetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmreturnitemdetails))
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.lblqty = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblponum = New System.Windows.Forms.Label()
        Me.cboreturnby = New System.Windows.Forms.ComboBox()
        Me.lblsupid = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbldrID = New System.Windows.Forms.Label()
        Me.lblitemid = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboreason = New System.Windows.Forms.ComboBox()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblprice = New System.Windows.Forms.Label()
        Me.lblitemtype = New System.Windows.Forms.Label()
        Me.lblitemcode = New System.Windows.Forms.Label()
        Me.lblsupplier = New System.Windows.Forms.Label()
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
        Me.Panel5.TabIndex = 38
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
        Me.Panel1.TabIndex = 39
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
        Me.Panel2.Controls.Add(Me.lblponum)
        Me.Panel2.Controls.Add(Me.cboreturnby)
        Me.Panel2.Controls.Add(Me.lblsupid)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.lbldrID)
        Me.Panel2.Controls.Add(Me.lblitemid)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.cboreason)
        Me.Panel2.Controls.Add(Me.txtqty)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.lblprice)
        Me.Panel2.Controls.Add(Me.lblitemtype)
        Me.Panel2.Controls.Add(Me.lblitemcode)
        Me.Panel2.Controls.Add(Me.lblsupplier)
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
        Me.Panel2.TabIndex = 40
        '
        'lblponum
        '
        Me.lblponum.AutoSize = True
        Me.lblponum.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblponum.Location = New System.Drawing.Point(445, 117)
        Me.lblponum.Name = "lblponum"
        Me.lblponum.Size = New System.Drawing.Size(59, 24)
        Me.lblponum.TabIndex = 52
        Me.lblponum.Text = "-------"
        Me.lblponum.Visible = False
        '
        'cboreturnby
        '
        Me.cboreturnby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboreturnby.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboreturnby.FormattingEnabled = True
        Me.cboreturnby.Items.AddRange(New Object() {"---Select Reason---", "Defective", "Sent Wrong Item", "Damage in Shipment", "Missing Item"})
        Me.cboreturnby.Location = New System.Drawing.Point(238, 146)
        Me.cboreturnby.Name = "cboreturnby"
        Me.cboreturnby.Size = New System.Drawing.Size(316, 32)
        Me.cboreturnby.TabIndex = 51
        '
        'lblsupid
        '
        Me.lblsupid.AutoSize = True
        Me.lblsupid.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsupid.Location = New System.Drawing.Point(445, 84)
        Me.lblsupid.Name = "lblsupid"
        Me.lblsupid.Size = New System.Drawing.Size(59, 24)
        Me.lblsupid.TabIndex = 49
        Me.lblsupid.Text = "-------"
        Me.lblsupid.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(110, 150)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 24)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Return By :"
        '
        'lbldrID
        '
        Me.lbldrID.AutoSize = True
        Me.lbldrID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldrID.Location = New System.Drawing.Point(445, 48)
        Me.lbldrID.Name = "lbldrID"
        Me.lbldrID.Size = New System.Drawing.Size(59, 24)
        Me.lbldrID.TabIndex = 48
        Me.lbldrID.Text = "-------"
        Me.lbldrID.Visible = False
        '
        'lblitemid
        '
        Me.lblitemid.AutoSize = True
        Me.lblitemid.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblitemid.Location = New System.Drawing.Point(445, 13)
        Me.lblitemid.Name = "lblitemid"
        Me.lblitemid.Size = New System.Drawing.Size(59, 24)
        Me.lblitemid.TabIndex = 47
        Me.lblitemid.Text = "-------"
        Me.lblitemid.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(60, 225)
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
        Me.cboreason.Location = New System.Drawing.Point(238, 184)
        Me.cboreason.Name = "cboreason"
        Me.cboreason.Size = New System.Drawing.Size(316, 32)
        Me.cboreason.TabIndex = 45
        '
        'txtqty
        '
        Me.txtqty.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqty.Location = New System.Drawing.Point(238, 260)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(92, 32)
        Me.txtqty.TabIndex = 44
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(124, 263)
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
        'lblsupplier
        '
        Me.lblsupplier.AutoSize = True
        Me.lblsupplier.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsupplier.Location = New System.Drawing.Point(234, 13)
        Me.lblsupplier.Name = "lblsupplier"
        Me.lblsupplier.Size = New System.Drawing.Size(59, 24)
        Me.lblsupplier.TabIndex = 39
        Me.lblsupplier.Text = "-------"
        '
        'txtother
        '
        Me.txtother.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtother.Location = New System.Drawing.Point(238, 222)
        Me.txtother.Name = "txtother"
        Me.txtother.Size = New System.Drawing.Size(316, 32)
        Me.txtother.TabIndex = 38
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(124, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 24)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Supplier :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(206, 24)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Reason for Return :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(66, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 24)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Supplier Price :"
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
        'frmreturnitemdetails
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
        Me.Name = "frmreturnitemdetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmreturnitemdetails"
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboreason As System.Windows.Forms.ComboBox
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblprice As System.Windows.Forms.Label
    Friend WithEvents lblitemtype As System.Windows.Forms.Label
    Friend WithEvents lblitemcode As System.Windows.Forms.Label
    Friend WithEvents lblsupplier As System.Windows.Forms.Label
    Friend WithEvents txtother As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblitemid As System.Windows.Forms.Label
    Friend WithEvents lbldrID As System.Windows.Forms.Label
    Friend WithEvents lblsupid As System.Windows.Forms.Label
    Friend WithEvents cboreturnby As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblponum As System.Windows.Forms.Label
    Friend WithEvents lblqty As System.Windows.Forms.Label
    Friend WithEvents lbldate As System.Windows.Forms.Label
End Class
