Public Class frm_products_a174807
    Private Sub Cust_Label1_Click(sender As Object, e As EventArgs) Handles Cust_Label1.Click

    End Sub

    Private Sub frm_products_a174807_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_APERFUME_A174807.accdb;Persist Security Info=False;"
        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A174807"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_products.DataSource = mydatatable

        grd_products.Columns(0).HeaderText = "PRODUCT ID"
        grd_products.Columns(1).HeaderText = "NAME"
        grd_products.Columns(2).HeaderText = "PRICE"
        grd_products.Columns(3).HeaderText = "BRAND"
        grd_products.Columns(4).HeaderText = "VOLUME"
        grd_products.Columns(5).HeaderText = "CATEGORY"
        grd_products.Columns(6).HeaderText = "SCENT DESCRIPTIONS"
        grd_products.Columns(7).HeaderText = "TYPE"
        grd_products.Columns(8).HeaderText = "STOCK"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_mainmenu_a174807.Show()
        Me.Hide()

    End Sub

    Private Sub Exit_btn_Click(sender As Object, e As EventArgs) Handles Exit_btn.Click
        End
    End Sub

    'Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
    '    Dim mysql As String = "SELECT* FROM TBL_PRODUCTS_A174807"
    '    Dim mydatatable As New DataTable
    '    Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
    '    myreader.Fill(mydatatable)
    '    grd_products.DataSource = mydatatable
    'End Sub
End Class