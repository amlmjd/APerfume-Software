Public Class frm_invoices_a174807
    Dim a As Double
    Private Sub frm_invoices_a174807_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT FLD_ORDER_ID FROM TBL_ORDER_A174807"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        cmb_orderid.DataSource = mydatatable

        cmb_orderid.DisplayMember = "FLD_ORDER_ID"

        refresh_text(cmb_orderid.Text)

        refresh_grid()

        refresh_price()

        Dim current_date As String = Date.Now

        lbl_date.Text = current_date
    End Sub
    Private Sub refresh_text(orderid As String)
        Try

            Dim mysql As String = "SELECT * FROM TBL_ORDER_A174807 WHERE FLD_ORDER_ID='" & orderid & "'"

            Dim mydatatable As New DataTable

            Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

            myreader.Fill(mydatatable)

            lbl_customerID.Text = mydatatable.Rows(0).Item("FLD_CUSTOMER")
            lbl_staffID.Text = mydatatable.Rows(0).Item("FLD_STAFF")

        Catch ex As Exception

            Beep()
            MsgBox("There is no order to view. Please make a new order" & vbCrLf & vbCrLf & ex.Message)

        End Try
        'Dim mysql As String = "SELECT * FROM TBL_ORDER_A174807 WHERE FLD_ORDER_ID='" & orderid & "'"

        'Dim mydatatable As New DataTable

        'Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        'myreader.Fill(mydatatable)

        'lbl_customerID.Text = mydatatable.Rows(0).Item("FLD_CUSTOMER")
        'lbl_staffID.Text = mydatatable.Rows(0).Item("FLD_STAFF")

    End Sub
    Private Sub refresh_grid()

        Dim mysql As String = "SELECT FLD_PRODUCTS_ID, FLD_QUANTITY, FLD_SUBTOL FROM TBL_RECEIPT_A174807 WHERE FLD_ORDER_ID like""%" & cmb_orderid.Text & "%"""

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_invoice.DataSource = mydatatable

        grd_invoice.Columns(0).HeaderText = "PRODUCT ID"

        grd_invoice.Columns(1).HeaderText = "QUANTITY"

        grd_invoice.Columns(2).HeaderText = "SUBTOTAL PRICE (RM)"

    End Sub

    Private Sub cmb_orderid_MouseClick(sender As Object, e As MouseEventArgs) Handles cmb_orderid.MouseClick
        refresh_text(cmb_orderid.Text)
    End Sub

    Private Sub cmb_orderid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_orderid.SelectedIndexChanged
        refresh_grid()
        refresh_price()
    End Sub
    Private Sub refresh_price()

        If grd_invoice.RowCount > 1 Then

            a = 0

            For index As Integer = 0 To grd_invoice.RowCount - 1

                a += Convert.ToDouble(grd_invoice.Rows(index).Cells(2).Value)

            Next

            lbl_price.Text = a

        ElseIf grd_invoice.RowCount = 1 Then

            lbl_price.Text = " 0 "

        End If

    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub


    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a174807.Show()
        Me.Hide()
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        Dim mysql As String = "SELECT  FLD_ORDER_ID FROM TBL_ORDER_A174807"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        cmb_orderid.DataSource = mydatatable
        cmb_orderid.DisplayMember = "FLD_ORDER_ID"
    End Sub

    Private Sub INVOICE_Enter(sender As Object, e As EventArgs) Handles INVOICE.Enter

    End Sub
End Class