Public Class frm_mainmenu_a174807
    Private Sub frm_mainmenu_a174807_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'lbl_welcome.Text = "Welcome " & username & " To APerfume"
    End Sub

    Private Sub frm_mainmenu_a174807_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub

    Private Sub btn_makeOrder_Click(sender As Object, e As EventArgs) Handles btn_makeOrder.Click
        frm_makeOrder_a174807.Show()
        Me.Hide()
    End Sub

    Private Sub btn_invoices_Click(sender As Object, e As EventArgs) Handles btn_invoices.Click
        frm_invoices_a174807.Show()
        Me.Hide()
    End Sub

    Private Sub btn_custList_Click(sender As Object, e As EventArgs) Handles btn_custList.Click
        Me.Hide()
        frm_customer_a174807.Show()
    End Sub

    Private Sub btn_addCust_Click(sender As Object, e As EventArgs) Handles btn_addCust.Click
        frm_insertCustomer_a174807.Show()
        Me.Hide()
    End Sub

    Private Sub btn_upCust_Click(sender As Object, e As EventArgs) Handles btn_upCust.Click
        frm_updateCustomer_a174807.Show()
        Me.Hide()
    End Sub

    Private Sub btn_staffList_Click(sender As Object, e As EventArgs) Handles btn_staffList.Click
        Me.Hide()
        frm_staff_a174807.Show()
    End Sub

    Private Sub btn_addStaff_Click(sender As Object, e As EventArgs) Handles btn_addStaff.Click
        frm_insertStaff_a174807.Show()
        Me.Hide()
    End Sub

    Private Sub btn_upStaff_Click(sender As Object, e As EventArgs) Handles btn_upStaff.Click
        frm_updateStaff_a174807.Show()
        Me.Hide()
    End Sub

    Private Sub btn_productList_Click(sender As Object, e As EventArgs) Handles btn_productList.Click
        Me.Hide()
        frm_products_a174807.Show()
    End Sub

    Private Sub btn_catalog_Click(sender As Object, e As EventArgs) Handles btn_catalog.Click
        frm_catalogue_a174807.Show()
        Me.Hide()
    End Sub

    Private Sub btn_addProd_Click(sender As Object, e As EventArgs) Handles btn_addProd.Click
        frm_insertProducts_a174807.Show()
        Me.Hide()
    End Sub

    Private Sub btn_upProd_Click(sender As Object, e As EventArgs) Handles btn_upProd.Click
        frm_updateProduct_a174807.Show()
        Me.Hide()
    End Sub

    Private Sub btn_order_Click(sender As Object, e As EventArgs) Handles btn_order.Click
        Me.Hide()
        frm_orderslist_a174807.Show()
    End Sub

    Private Sub btn_receipts_Click(sender As Object, e As EventArgs) Handles btn_receipts.Click
        frm_receipts_a174807.Show()
        Me.Hide()
    End Sub
End Class