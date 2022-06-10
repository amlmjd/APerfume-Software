Public Class frm_catalogue_a174807
    Private Sub frm_catalogue_a174807_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT FLD_PRODUCT_ID FROM TBL_PRODUCTS_A174807"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        lst_products.DataSource = mydatatable
        lst_products.DisplayMember = "FLD_PRODUCT_ID"
        refresh_text(lst_products.Text)

        Dim current_date As String = Date.Now
        lbl_date.Text = current_date
    End Sub

    Private Sub refresh_text(product_ID As String)
        Dim mysql As String = "SELECT * From TBL_PRODUCTS_A174807 Where FLD_PRODUCT_ID ='" & product_ID & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        txt_name.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_NAME")
        txt_price.Text = mydatatable.Rows(0).Item("FLD_PRICE")
        txt_brand.Text = mydatatable.Rows(0).Item("FLD_BRAND")
        txt_Vol.Text = mydatatable.Rows(0).Item("FLD_VOLUME")
        txt_Category.Text = mydatatable.Rows(0).Item("FLD_CATEGORIES")
        txt_scent.Text = mydatatable.Rows(0).Item("FLD_SCENT_DESCRIPTION")
        txt_type.Text = mydatatable.Rows(0).Item("FLD_TYPE")
        txt_stock.Text = mydatatable.Rows(0).Item("FLD_STOCK")
        txt_id.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_ID")

        Try
            pic_product.BackgroundImage = Image.FromFile("pictures/" & txt_id.Text & ".jpg")
        Catch ex As Exception
            pic_product.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")
        End Try


    End Sub

    Private Sub lst_products_MouseClick(sender As Object, e As MouseEventArgs) Handles lst_products.MouseClick
        refresh_text(lst_products.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_mainmenu_a174807.Show()
        Me.Hide()
    End Sub


    Private Sub Exit_btn_Click(sender As Object, e As EventArgs) Handles Exit_btn.Click
        End
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        Dim mysql As String = "SELECT * From TBL_PRODUCTS_A174807 Where FLD_PRODUCT_ID"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        txt_name.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_NAME")
        txt_price.Text = mydatatable.Rows(0).Item("FLD_PRICE")
        txt_brand.Text = mydatatable.Rows(0).Item("FLD_BRAND")
        txt_Vol.Text = mydatatable.Rows(0).Item("FLD_VOLUME")
        txt_Category.Text = mydatatable.Rows(0).Item("FLD_CATEGORIES")
        txt_scent.Text = mydatatable.Rows(0).Item("FLD_SCENT_DESCRIPTION")
        txt_type.Text = mydatatable.Rows(0).Item("FLD_TYPE")
        txt_stock.Text = mydatatable.Rows(0).Item("FLD_STOCK")
        txt_id.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_ID")

        Try
            pic_product.BackgroundImage = Image.FromFile("pictures/" & txt_id.Text & ".jpg")
        Catch ex As Exception
            pic_product.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")
        End Try
    End Sub
End Class