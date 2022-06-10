Imports System.IO

Public Class frm_updateProduct_a174807
    Dim current_id As String
    Dim defaultpicture As String = Application.StartupPath & "\pictures\nophoto.jpg"
    Dim current_picture As String
    Dim open As Boolean
    Dim img As Image
    Private Sub frm_updateProduct_a174807_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        'txt_picture.Text = defaultpicture
        'pic_product.BackgroundImage = Image.FromFile(defaultpicture)
        refresh_grid()
    End Sub
    Private Sub refresh_grid()
        Dim mysql As String = "SELECT* FROM TBL_PRODUCTS_A174807"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_products.DataSource = mydatatable
    End Sub
    Private Sub clear_fields()
        txt_id.Text = ""
        txt_name.Text = ""
        txt_price.Text = ""
        txt_brand.Text = ""
        txt_volume.Text = ""
        txt_category.Text = ""
        txt_scent.Text = ""
        txt_type.Text = ""
        txt_stock.Text = ""
    End Sub
    Private Sub get_current_id()
        Dim current_row As Integer = grd_products.CurrentRow.Index
        current_id = grd_products(0, current_row).Value

        txt_id.Text = current_id
        txt_name.Text = grd_products(1, current_row).Value
        txt_price.Text = grd_products(2, current_row).Value
        txt_brand.Text = grd_products(3, current_row).Value
        txt_volume.Text = grd_products(4, current_row).Value
        txt_category.Text = grd_products(5, current_row).Value
        txt_scent.Text = grd_products(6, current_row).Value
        txt_type.Text = grd_products(7, current_row).Value
        txt_stock.Text = grd_products(8, current_row).Value

        current_picture = Application.StartupPath & "\pictures\" & txt_id.Text & ".jpg"
        txt_picture.Text = current_picture

        Using fs As New FileStream(current_picture, FileMode.Open, FileAccess.Read)
            img = Image.FromStream(fs)
        End Using
        pic_product.BackgroundImage = img
    End Sub
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a174807.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        End
    End Sub

    Private Sub btn_picture_Click(sender As Object, e As EventArgs) Handles btn_picture.Click
        open = True
        Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop

        OpenFileDialog1.InitialDirectory = mydesktop
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG files (*.jpg)|*.jpg"
        OpenFileDialog1.ShowDialog()

        'pic_product.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
        txt_picture.Text = OpenFileDialog1.FileName
        Try
            pic_product.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
        Catch ex As Exception
            txt_picture.Text = current_picture
            pic_product.BackgroundImage = Image.FromFile(current_picture)
        End Try
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim mywriter As New OleDb.OleDbCommand("update TBL_PRODUCTS_A174807 set FLD_PRODUCT_NAME='" & txt_name.Text & "', FLD_PRICE='" & txt_price.Text & "', FLD_BRAND='" & txt_brand.Text & "', FLD_VOLUME='" & txt_volume.Text & "', FLD_CATEGORIES='" & txt_category.Text & "', FLD_SCENT_DESCRIPTION='" & txt_scent.Text & "', FLD_TYPE= '" & txt_type.Text & "', FLD_STOCK= " & txt_stock.Text & " where FLD_PRODUCT_ID='" & txt_id.Text & "'", myconnection2)
        Try

            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()
            MsgBox(txt_picture.Text)
            If open = True Then
                pic_product.BackgroundImage.Dispose()
                'pic_product.BackgroundImage = Image.FromFile(defaultpicture)
                'My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\pictures\" & txt_id.Text & ".jpg")

                My.Computer.FileSystem.CopyFile(txt_picture.Text, "pictures\" & txt_id.Text & ".jpg", True)
            End If
            MsgBox("You have successfully update the Product """ & current_id & """.")
            refresh_grid()
            get_current_id()

        Catch ex As Exception

            Beep()
            MsgBox("There is a mistake in the command you sent:: " & vbCrLf & vbCrLf & ex.Message)
            mywriter.Connection.Close()

        End Try

        refresh_grid()
        get_current_id()
    End Sub


    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the informations of """ & current_id & """?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then

            run_sql_command("DELETE FROM TBL_PRODUCTS_A174807 WHERE FLD_PRODUCT_ID='" & current_id & "'")
            pic_product.BackgroundImage.Dispose()
            pic_product.BackgroundImage = Image.FromFile(defaultpicture)
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\pictures\" & txt_id.Text & ".jpg")
            Beep()
            MsgBox("The Product  """ & current_id & """ has been successfully deleted.")

            refresh_grid()
            clear_fields()
            get_current_id()
        End If
    End Sub

    Private Sub grd_products_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_products.CellContentClick

    End Sub

    Private Sub grd_products_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_products.CellClick
        get_current_id()
        open = False
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        Dim mysql As String = "SELECT* FROM TBL_PRODUCTS_A174807"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_products.DataSource = mydatatable
    End Sub
End Class