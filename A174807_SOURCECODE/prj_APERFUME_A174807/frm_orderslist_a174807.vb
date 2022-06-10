Public Class frm_orderslist_a174807
    Private Sub frm_orders_a174807_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_APERFUME_A174807.accdb;Persist Security Info=False;"
        Dim mysql As String = "SELECT * FROM TBL_ORDER_A174807"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_orders.DataSource = mydatatable

        grd_orders.Columns(0).HeaderText = "ORDER ID"
        grd_orders.Columns(1).HeaderText = "STAFF ID"
        grd_orders.Columns(2).HeaderText = "CUSTOMER ID"
        grd_orders.Columns(3).HeaderText = "DATE PURCHASED"
    End Sub

    Private Sub Back_btnOrders_Click(sender As Object, e As EventArgs) Handles Back_btnOrders.Click
        frm_mainmenu_a174807.Show()
        Me.Hide()
    End Sub

    Private Sub Exit_btn_Click(sender As Object, e As EventArgs) Handles Exit_btn.Click
        End
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_makeOrder_Click(sender As Object, e As EventArgs) Handles btn_makeOrder.Click
        frm_makeOrder_a174807.Show()
        Me.Hide()
    End Sub
End Class