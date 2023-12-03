<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdd
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdd))
        Me.pnladd = New System.Windows.Forms.Panel()
        Me.lblunitp = New System.Windows.Forms.Label()
        Me.lblprice = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.cboitemtype = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtdesc = New System.Windows.Forms.TextBox()
        Me.txtunitp = New System.Windows.Forms.TextBox()
        Me.txtitemcode = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblitemID = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblid = New System.Windows.Forms.Label()
        Me.pnladd.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnladd
        '
        Me.pnladd.BackColor = System.Drawing.Color.MintCream
        Me.pnladd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnladd.Controls.Add(Me.lblunitp)
        Me.pnladd.Controls.Add(Me.lblprice)
        Me.pnladd.Controls.Add(Me.Label8)
        Me.pnladd.Controls.Add(Me.Label7)
        Me.pnladd.Controls.Add(Me.txtprice)
        Me.pnladd.Controls.Add(Me.Label6)
        Me.pnladd.Controls.Add(Me.btnadd)
        Me.pnladd.Controls.Add(Me.cboitemtype)
        Me.pnladd.Controls.Add(Me.Label9)
        Me.pnladd.Controls.Add(Me.txtdesc)
        Me.pnladd.Controls.Add(Me.txtunitp)
        Me.pnladd.Controls.Add(Me.txtitemcode)
        Me.pnladd.Controls.Add(Me.Panel2)
        Me.pnladd.Controls.Add(Me.Label5)
        Me.pnladd.Controls.Add(Me.Label4)
        Me.pnladd.Controls.Add(Me.Label3)
        Me.pnladd.Controls.Add(Me.Label2)
        Me.pnladd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnladd.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnladd.Location = New System.Drawing.Point(0, 0)
        Me.pnladd.Name = "pnladd"
        Me.pnladd.Size = New System.Drawing.Size(656, 346)
        Me.pnladd.TabIndex = 7
        '
        'lblunitp
        '
        Me.lblunitp.AutoSize = True
        Me.lblunitp.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblunitp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblunitp.Location = New System.Drawing.Point(385, 228)
        Me.lblunitp.Name = "lblunitp"
        Me.lblunitp.Size = New System.Drawing.Size(111, 28)
        Me.lblunitp.TabIndex = 46
        Me.lblunitp.Text = "Supplier"
        Me.lblunitp.Visible = False
        '
        'lblprice
        '
        Me.lblprice.AutoSize = True
        Me.lblprice.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblprice.Location = New System.Drawing.Point(372, 188)
        Me.lblprice.Name = "lblprice"
        Me.lblprice.Size = New System.Drawing.Size(111, 28)
        Me.lblprice.TabIndex = 45
        Me.lblprice.Text = "Supplier"
        Me.lblprice.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 194)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(151, 22)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Supplier Price :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(324, 194)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(17, 22)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "*"
        '
        'txtprice
        '
        Me.txtprice.Location = New System.Drawing.Point(160, 191)
        Me.txtprice.MaxLength = 7
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(158, 29)
        Me.txtprice.TabIndex = 37
        Me.txtprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(578, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 22)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "*"
        '
        'btnadd
        '
        Me.btnadd.Image = CType(resources.GetObject("btnadd.Image"), System.Drawing.Image)
        Me.btnadd.Location = New System.Drawing.Point(582, 110)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(40, 31)
        Me.btnadd.TabIndex = 34
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'cboitemtype
        '
        Me.cboitemtype.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.cboitemtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboitemtype.FormattingEnabled = True
        Me.cboitemtype.Location = New System.Drawing.Point(160, 111)
        Me.cboitemtype.Name = "cboitemtype"
        Me.cboitemtype.Size = New System.Drawing.Size(416, 30)
        Me.cboitemtype.TabIndex = 33
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(324, 234)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(17, 22)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "*"
        '
        'txtdesc
        '
        Me.txtdesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdesc.Location = New System.Drawing.Point(160, 151)
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(416, 29)
        Me.txtdesc.TabIndex = 21
        '
        'txtunitp
        '
        Me.txtunitp.Location = New System.Drawing.Point(160, 231)
        Me.txtunitp.MaxLength = 7
        Me.txtunitp.Name = "txtunitp"
        Me.txtunitp.Size = New System.Drawing.Size(158, 29)
        Me.txtunitp.TabIndex = 22
        Me.txtunitp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtitemcode
        '
        Me.txtitemcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtitemcode.Location = New System.Drawing.Point(160, 70)
        Me.txtitemcode.Name = "txtitemcode"
        Me.txtitemcode.Size = New System.Drawing.Size(416, 29)
        Me.txtitemcode.TabIndex = 19
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Honeydew
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.lblitemID)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 277)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(654, 67)
        Me.Panel2.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(434, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(218, 65)
        Me.Panel1.TabIndex = 40
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
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label10.Location = New System.Drawing.Point(9, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(214, 22)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Fill up required fields *"
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(48, 234)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 22)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Unit Price:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 22)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Description :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 22)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Item Type :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Item Code :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add New"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Honeydew
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lblid)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(656, 61)
        Me.Panel3.TabIndex = 8
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblid.Location = New System.Drawing.Point(433, 17)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(111, 28)
        Me.lblid.TabIndex = 43
        Me.lblid.Text = "Supplier"
        Me.lblid.Visible = False
        '
        'frmAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 346)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.pnladd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add"
        Me.pnladd.ResumeLayout(False)
        Me.pnladd.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnladd As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtdesc As System.Windows.Forms.TextBox
    Friend WithEvents txtunitp As System.Windows.Forms.TextBox
    Friend WithEvents txtitemcode As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblitemID As Label
    Friend WithEvents cboitemtype As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtprice As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblid As System.Windows.Forms.Label
    Friend WithEvents lblunitp As System.Windows.Forms.Label
    Friend WithEvents lblprice As System.Windows.Forms.Label
End Class
