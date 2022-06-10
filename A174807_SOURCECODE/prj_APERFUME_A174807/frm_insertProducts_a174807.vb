Public Class frm_insertProducts_a174807
    Dim defaultpicture As String = Application.StartupPath & "\pictures\nophoto.jpg"
    Private Sub frm_insertProducts_a174807_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grd_products.DataSource = run_sql_query("SELECT*FROM TBL_PRODUCTS_A174807 ORDER BY FLD_PRODUCT_ID")
        grd_products.Columns(0).HeaderText = "PRODUCT ID"
        grd_products.Columns(1).HeaderText = "NAME"
        grd_products.Columns(2).HeaderText = "PRICE"
        grd_products.Columns(3).HeaderText = "BRAND"
        grd_products.Columns(4).HeaderText = "VOLUME"
        grd_products.Columns(5).HeaderText = "CATEGORY"
        grd_products.Columns(6).HeaderText = "SCENT DESCRIPTIONS"
        grd_products.Columns(7).HeaderText = "TYPE"
        grd_products.Columns(8).HeaderText = "STOCK"

        txt_id.Text = generate_productID()

        txt_picture.Text = defaultpicture
        pic_product.BackgroundImage = Image.FromFile(defaultpicture)
        refresh_grid()
    End Sub
    Private Sub refresh_grid()
        Dim mysql As String = "SELECT* FROM TBL_PRODUCTS_A174807"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_products.DataSource = mydatatable
    End Sub
    Private Function generate_productID()
        Dim lastID As String = run_sql_query("SELECT MAX(FLD_PRODUCT_ID)AS LASTID FROM TBL_PRODUCTS_A174807").Rows(0).Item("LASTID")
        Dim newID As String = "P" & Mid(lastID, 2) + 1
        Return newID
    End Function

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Dim mysql As String = "INSERT INTO TBL_PRODUCTS_A174807 VALUES('" & txt_id.Text & "','" & txt_name.Text & "','" & txt_price.Text & "','" & txt_brand.Text & "', '" & txt_volume.Text & "', '" & txt_category.Text & "','" & txt_scent.Text & "','" & txt_type.Text & "'," & txt_stock.Text & ")"
        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            My.Computer.FileSystem.CopyFile(txt_picture.Text, "pictures\" & txt_id.Text & ".jpg")

            grd_products.DataSource = run_sql_query("SELECT*FROM TBL_PRODUCTS_A174807 ORDER BY FLD_PRODUCT_ID")

            txt_id.Text = generate_productID()
            'txt_id.Text = ""
            txt_name.Text = ""
            txt_price.Text = ""
            txt_brand.Text = ""
            txt_volume.Text = ""
            txt_category.Text = ""
            txt_scent.Text = ""
            txt_type.Text = ""
            txt_stock.Text = ""

            txt_picture.Text = defaultpicture
            pic_product.BackgroundImage = Image.FromFile(defaultpicture)
            MsgBox("Data of New Product has been Insert Successfully")
        Catch ex As Exception
            Beep()
            MsgBox("There is a mistake in the data you entered , as shown below" & vbCrLf & vbCrLf & ex.Message)
            mywriter.Connection.Close()
        End Try
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a174807.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        End
    End Sub

    Private Sub btn_picture_Click(sender As Object, e As EventArgs) Handles btn_picture.Click
        Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop

        OpenFileDialog1.InitialDirectory = mydesktop
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG files (*.jpg)|*.jpg"
        OpenFileDialog1.ShowDialog()

        pic_product.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
        txt_picture.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        Dim mysql As String = "SELECT* FROM TBL_PRODUCTS_A174807"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_products.DataSource = mydatatable
    End Sub
End Class