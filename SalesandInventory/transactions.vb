Module transactions
    Public auto As String
    Public zero As String
    Public stocktotalId As Integer
    Public prodID As Integer
    Public qty1 As Integer
    Public id As Integer
    Public total As Double
    Public auto1 As Integer
    Public Sub totalPrice()
        Dim total = 0.0
        Dim length As Integer = frmPOS.dgvItem.RowCount - 1
        For y = 0 To length
            total += frmPOS.dgvItem.Item(6, y).Value
        Next
        If frmPOS.dgvItem.RowCount = 0 Then
            frmPOS.lblsubtotal1.Text = 0
            frmPOS.lblsubtotal.Text = 0.0
        Else
            frmPOS.lblsubtotal1.Text = Format(total, "#,##0.00")
            frmPOS.lblsubtotal.Text = Format(total, "#,##0.00")
        End If
    End Sub
    Public Sub unfinishTransaction(ByVal str As String, ByVal intid As Integer)
        Try
            Dim cmd As Odbc.OdbcCommand
            cmd = New Odbc.OdbcCommand(str, con)
            With cmd
                If intid = 0 Then
                    .Parameters.AddWithValue("?", Val(frmPOS.totalprice))
                    .Parameters.AddWithValue("?", Val(frmPOS.transId))
                ElseIf intid = 1 Then
                    .Parameters.AddWithValue("?", Val(frmPOS.lbltransId.Text))
                    .Parameters.AddWithValue("?", Val(frmPOS.stockID))
                    .Parameters.AddWithValue("?", Val(frmPOS.qty))
                    .Parameters.AddWithValue("?", Val(frmPOS.totalprice))
                    .Parameters.AddWithValue("?", frmPOS.lbltrans.Text)
                    .Parameters.AddWithValue("?", frmPOS.lblcdut.Text)
                ElseIf intid = 2 Then
                    .Parameters.AddWithValue("?", id)
                    'ElseIf intid = 3 Then
                    '.Parameters.AddWithValue("?", frmPOS.lblTransNo.Text)
                End If
                .ExecuteNonQuery()
                frmPOS.dgvItem.Tag = ""
            End With
        Catch ex As Exception

        End Try
    End Sub
   
    Public Sub transaction(str As String, intID As Integer)
        Try
            connect()
            Dim cmd As Odbc.OdbcCommand
            cmd = New Odbc.OdbcCommand(str, con)
            With cmd
                If intID = 0 Then
                    .Parameters.AddWithValue("?", frmPOS.lbldate.Text)
                    .Parameters.AddWithValue("?", frmPOSfullypaid.nonvatble)
                    .Parameters.AddWithValue("?", Val(frmPOSfullypaid.txtamount.Text))
                    .Parameters.AddWithValue("?", Val(frmPOSfullypaid.lbltotal.Text))
                    .Parameters.AddWithValue("?", Val(frmPOSfullypaid.lblchange.Text))
                    .Parameters.AddWithValue("?", frmPOS.lbldate1.Text)
                    .Parameters.AddWithValue("?", frmPOS.lbltrans.Text)
                    .Parameters.AddWithValue("?", frmPOS.lblcdut.Text)
                    .Parameters.AddWithValue("?", 1)
                    .ExecuteNonQuery()
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message.ToString, vbCritical, "ERROR MESSAGE")
        Finally
            GC.Collect()
        End Try
    End Sub
    Public Sub minusProduct(str As String, intID As Integer)
        Try
            connect()
            Dim cmd As Odbc.OdbcCommand
            cmd = New Odbc.OdbcCommand(str, con)
            With cmd
                If intID = 0 Then
                    .Parameters.AddWithValue("?", qty1)
                    .Parameters.AddWithValue("?", prodID)
                    .ExecuteNonQuery()
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

    Public Function getTransactionNo2() As String
        connect()
        Dim com As New Odbc.OdbcDataAdapter("SELECT COUNT(transdetailsid) FROM transaction_details2", con)
        Dim dt As New DataTable
        com.Fill(dt)
        auto = dt.Rows(0)(0) + 1
        auto1 = Val(dt.Rows(0)(0)) + 1

        Select Case Val(auto)
            Case 1 To 9
                zero = "000"
            Case 10 To 99
                zero = "00"
            Case 100 To 999
                zero = "0"
        End Select
        getTransactionNo2 = zero + auto
    End Function
    Public Function getTransactionNo() As String
        connect()
        Dim com As New Odbc.OdbcDataAdapter("SELECT COUNT(transdetailsid) FROM transaction_details", con)
        Dim dt As New DataTable
        com.Fill(dt)
        auto = dt.Rows(0)(0) + 1
        auto1 = Val(dt.Rows(0)(0)) + 1

        Select Case Val(auto)
            Case 1 To 9
                zero = "000"
            Case 10 To 99
                zero = "00"
            Case 100 To 999
                zero = "0"
        End Select
        getTransactionNo = zero + auto
    End Function
    Public Sub cancelAll()
        Dim Id As Integer
        For e As Integer = 0 To frmPOS.dgvItem.RowCount - 1
            Id = frmPOS.dgvItem.Item(7, e).Value
            prodID = frmPOS.dgvItem.Item(1, e).Value
        Next
    End Sub
    Sub fetchVoid(id As Integer, prodID As Integer)
        connect()
        Dim cmd1 As New Odbc.OdbcCommand("")
    End Sub
End Module
