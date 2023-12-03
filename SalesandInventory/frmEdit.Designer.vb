<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEdit))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboitemtype = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblitemID = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtdesc = New System.Windows.Forms.TextBox()
        Me.txtunitp = New System.Windows.Forms.TextBox()
        Me.txtitemcode = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblid = New System.Windows.Forms.Label()
        Me.pnladd = New System.Windows.Forms.Panel()
        Me.lblunitp = New System.Windows.Forms.Label()
        Me.lblprice = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.pnladd.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(566, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 22)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Edit"
        '
        'cboitemtype
        '
        Me.cboitemtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboitemtype.FormattingEnabled = True
        Me.cboitemtype.Location = New System.Drawing.Point(128, 111)
        Me.cboitemtype.Name = "cboitemtype"
        Me.cboitemtype.Size = New System.Drawing.Size(432, 30)
        Me.cboitemtype.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 22)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Description :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 22)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Item Type :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Item Code :"
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
        Me.btnCancel.Location = New System.Drawing.Point(499, 8)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(93, 49)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Ca&ncel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 22)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Unit Price:"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(400, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(93, 49)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "&Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(294, 230)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(17, 22)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "*"
        '
        'txtdesc
        '
        Me.txtdesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdesc.Location = New System.Drawing.Point(128, 151)
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(432, 29)
        Me.txtdesc.TabIndex = 21
        '
        'txtunitp
        '
        Me.txtunitp.Location = New System.Drawing.Point(128, 230)
        Me.txtunitp.MaxLength = 7
        Me.txtunitp.Name = "txtunitp"
        Me.txtunitp.Size = New System.Drawing.Size(160, 29)
        Me.txtunitp.TabIndex = 22
        Me.txtunitp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtitemcode
        '
        Me.txtitemcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtitemcode.Location = New System.Drawing.Point(128, 70)
        Me.txtitemcode.Name = "txtitemcode"
        Me.txtitemcode.Size = New System.Drawing.Size(432, 29)
        Me.txtitemcode.TabIndex = 19
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
        Me.Panel2.Location = New System.Drawing.Point(0, 277)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(602, 67)
        Me.Panel2.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label10.Location = New System.Drawing.Point(12, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(214, 22)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Fill up required fields *"
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
        Me.Panel3.Size = New System.Drawing.Size(604, 61)
        Me.Panel3.TabIndex = 10
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblid.Location = New System.Drawing.Point(247, 16)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(111, 28)
        Me.lblid.TabIndex = 43
        Me.lblid.Text = "Supplier"
        Me.lblid.Visible = False
        '
        'pnladd
        '
        Me.pnladd.BackColor = System.Drawing.Color.MintCream
        Me.pnladd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnladd.Controls.Add(Me.lblunitp)
        Me.pnladd.Controls.Add(Me.lblprice)
        Me.pnladd.Controls.Add(Me.Label11)
        Me.pnladd.Controls.Add(Me.Label7)
        Me.pnladd.Controls.Add(Me.txtprice)
        Me.pnladd.Controls.Add(Me.Label8)
        Me.pnladd.Controls.Add(Me.Label6)
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
        Me.pnladd.Size = New System.Drawing.Size(604, 346)
        Me.pnladd.TabIndex = 9
        '
        'lblunitp
        '
        Me.lblunitp.AutoSize = True
        Me.lblunitp.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblunitp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblunitp.Location = New System.Drawing.Point(355, 227)
        Me.lblunitp.Name = "lblunitp"
        Me.lblunitp.Size = New System.Drawing.Size(111, 28)
        Me.lblunitp.TabIndex = 48
        Me.lblunitp.Text = "Supplier"
        Me.lblunitp.Visible = False
        '
        'lblprice
        '
        Me.lblprice.AutoSize = True
        Me.lblprice.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblprice.Location = New System.Drawing.Point(342, 187)
        Me.lblprice.Name = "lblprice"
        Me.lblprice.Size = New System.Drawing.Size(111, 28)
        Me.lblprice.TabIndex = 47
        Me.lblprice.Text = "Supplier"
        Me.lblprice.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(566, 114)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(17, 22)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(294, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(17, 22)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "*"
        '
        'txtprice
        '
        Me.txtprice.Location = New System.Drawing.Point(128, 189)
        Me.txtprice.MaxLength = 7
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(160, 29)
        Me.txtprice.TabIndex = 40
        Me.txtprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(53, 192)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 22)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Price :"
        '
        'frmEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 346)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.pnladd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEdit"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.pnladd.ResumeLayout(False)
        Me.pnladd.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboitemtype As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblitemID As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtdesc As System.Windows.Forms.TextBox
    Friend WithEvents txtunitp As System.Windows.Forms.TextBox
    Friend WithEvents txtitemcode As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents pnladd As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtprice As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblid As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblunitp As System.Windows.Forms.Label
    Friend WithEvents lblprice As System.Windows.Forms.Label
End Class
