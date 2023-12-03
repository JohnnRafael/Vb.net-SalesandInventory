Imports System.Windows.Forms

Public Class Mainform

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        frmItems.Show()

        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer


    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub
    Private Sub mdi(ByVal frm As Form)
        For Each childform As Form In Me.MdiChildren
            If Not frm.Equals(childform) Then
                childform.Close()
            End If
        Next
        frm.MdiParent = Me
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub


    Private Sub Items_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Sales_Click(ByVal sender As Object, ByVal e As EventArgs)

        frmPOS.Show()
        Me.Hide()

    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblmaindt.Text = Date.Now.ToString("MMMMMMMM-dd-yyyy|hh:mm:ss")
        lbldate.Text = Format(Today, "yyyy-MM-dd")
        lblmaindt2.Text = Date.Now.ToString("MM-dd-yyyy")
        lblmaindt3.Text = Date.Now.ToString("yyyy-dd-MM")
    End Sub

    Private Sub StatusStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StatusStrip.ItemClicked

    End Sub

    Private Sub lblitems_Click(sender As Object, e As EventArgs)
        mdi(frmItems)
    End Sub

    Private Sub ItemTypeToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub EmployeesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        mdi(frmEmployee)
    End Sub

    Private Sub OrderToolStripMenuItem_Click(sender As Object, e As EventArgs)
        mdi(frmorder)
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs)
        mdi(frmorder)
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs)
        mdi(frmsupplier)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs)
        frmclient.Show()
    End Sub

    Private Sub ClientToolStripMenuItem_Click(sender As Object, e As EventArgs)
        mdi(frmclient)
    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs)
        
    End Sub

    Private Sub ToolStripButton3_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton2_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        frmPOS.ShowDialog()
    End Sub

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        mdi(frmInventory)
    End Sub

    Private Sub ToolStripButton4_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        mdi(frmsupplier)
    End Sub

    Private Sub ToolStripButton3_Click_2(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        mdi(frmorder)
    End Sub

    Private Sub OrderToolStripMenuItem_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblitems_Click_1(sender As Object, e As EventArgs)
        mdi(frmItems)
    End Sub

    Private Sub lblitemtype_Click(sender As Object, e As EventArgs) Handles lblitemtype.Click
        mdi(frmitemtype)
    End Sub

    Private Sub ClientToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        mdi(frmclient)
    End Sub

    Private Sub BackToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        Dim RestoreBackupDp As New RestoreBackupDb
        RestoreBackupDp.ShowDialog()
    End Sub

    Private Sub InventoryReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventoryReportToolStripMenuItem.Click
        mdi(inventoryreport)
    End Sub


    Private Sub FullyPaidToolStripMenuItem_Click(sender As Object, e As EventArgs)
        mdi(salesreportfp)
    End Sub

    Private Sub DownPaymentToolStripMenuItem_Click(sender As Object, e As EventArgs)
        mdi(salesreport50)
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Dispose()
        frmLogin.Show()
        frmLogin.txtuser.Text = ""
        frmLogin.pword.Text = ""
        cmdqry("INSERT INTO tblinout(username,position,activity,date)VALUES('" & Me.lblactiveuser.Text & "', '" & Me.lblposition.Text & "', 'Successfully logged out', '" & Date.Now.ToString("yyyy-MM-dd hh:mm:ss tt") & "')")
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub UsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsersToolStripMenuItem.Click
        mdi(frmusers)
    End Sub

    Private Sub FullyPaidToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles FullyPaidToolStripMenuItem.Click
        mdi(salesreportfp)
    End Sub

    Private Sub DownPaymentToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles DownPaymentToolStripMenuItem.Click
        mdi(salesreport50)
    End Sub

    Private Sub UpdatePaymentTransactionsToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub UpdatePaymentTransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdatePaymentTransactionToolStripMenuItem.Click
        mdi(frmupdatepayment50)
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblmaindt2_Click(sender As Object, e As EventArgs) Handles lblmaindt2.Click

    End Sub

    Private Sub ReturnedItemsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnedItemsToolStripMenuItem.Click

    End Sub

    Private Sub FastMovingToolStripMenuItem_Click(sender As Object, e As EventArgs)
        mdi(frmitemsales)
    End Sub

    Private Sub ToSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToSupplierToolStripMenuItem.Click
        mdi(frmreturnitem)
    End Sub

    Private Sub FromClientToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ReturnedItemsToSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnedItemsToSupplierToolStripMenuItem.Click
        mdi(returned)
    End Sub

    Private Sub ReturnedItemsFromClientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnedItemsFromClientToolStripMenuItem.Click
        mdi(frmreturnfromclient)
    End Sub

    Private Sub ListOfReturnedItemsFromClientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListOfReturnedItemsFromClientToolStripMenuItem.Click
        mdi(returnfromclient)
    End Sub
End Class
