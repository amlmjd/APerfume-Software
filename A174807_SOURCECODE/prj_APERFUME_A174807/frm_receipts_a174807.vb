Public Class frm_receipts_a174807
    Private Sub Back_btn_Click(sender As Object, e As EventArgs) Handles Back_btn.Click
        frm_mainmenu_a174807.Show()
        Me.Hide()
    End Sub

    Private Sub Exit_btn_Click(sender As Object, e As EventArgs) Handles Exit_btn.Click
        End
    End Sub

    Private Sub frm_receipts_a174807_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_APERFUME_A174807.accdb;Persist Security Info=False;"
        Dim mysql As String = "SELECT * FROM TBL_RECEIPT_A174807"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_receipt.DataSource = mydatatable

        grd_receipt.Columns(0).HeaderText = "ORDER ID"
        grd_receipt.Columns(1).HeaderText = "PRODUCT ID"
        grd_receipt.Columns(2).HeaderText = "QUANTITY"
        grd_receipt.Columns(3).HeaderText = "SUBTOTAL PRICE"
        'grd_receipt.Columns(4).HeaderText = "PRODUCT VOLUMES"
    End Sub

    Private Sub btn_invoices_Click(sender As Object, e As EventArgs) Handles btn_invoices.Click
        frm_invoices_a174807.Show()
        Me.Hide()
    End Sub
End Class