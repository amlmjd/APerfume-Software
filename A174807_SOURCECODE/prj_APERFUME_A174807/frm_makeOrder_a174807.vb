Public Class frm_makeOrder_a174807
    Dim number1 As Double
    Dim a As String
    Dim money As Double
    Dim num As Integer
    Dim current_code As String
    Private Sub frm_makeOrder_a174807_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()
        get_current_code()
        Dim current_date As String = Date.Now
        txt_date.Text = current_date

        a = 100
        refresh_count()
        refresh_staff()
        refresh_customer()
        btn_addtocart.Enabled = False
        btn_confirm.Enabled = False
        btn_remove.Enabled = False

        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A174807"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        cmb_productid.DataSource = mydatatable

        cmb_productid.DisplayMember = "FLD_PRODUCT_ID"

        refresh_text(cmb_productid.Text)
    End Sub
    Private Sub refresh_grid()

        Dim mysql2 As String = "SELECT * FROM TBL_CUSTOMER_A174807"

        Dim mydatatable2 As New DataTable

        Dim myreader2 As New OleDb.OleDbDataAdapter(mysql2, myconnection)

        myreader2.Fill(mydatatable2)

    End Sub
    Private Sub refresh_text(product As String)

        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A174807 WHERE FLD_PRODUCT_ID='" & product & "'"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        cmb_productid.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_ID")
        txt_productname.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_NAME")
        txt_price.Text = mydatatable.Rows(0).Item("FLD_PRICE")
        txt_brand.Text = mydatatable.Rows(0).Item("FLD_BRAND")
        txt_volume.Text = mydatatable.Rows(0).Item("FLD_VOLUME")
        txt_categories.Text = mydatatable.Rows(0).Item("FLD_CATEGORIES")
        txt_scent.Text = mydatatable.Rows(0).Item("FLD_SCENT_DESCRIPTION")
        txt_type.Text = mydatatable.Rows(0).Item("FLD_TYPE")
        lbl_STotal.Text = num * txt_price.Text

        Try

            pic_product.BackgroundImage = Image.FromFile("pictures/" & cmb_productid.Text & ".jpg")

        Catch ex As Exception

            pic_product.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")

        End Try

    End Sub
    Private Sub get_current_code()

        cmb_staffID.Text = current_code

    End Sub
    Private Sub refresh_count()

        Dim count As Integer = 1

        Dim mysql As String = "SELECT COUNT (FLD_ORDER_ID) As count_id FROM TBL_ORDER_A174807"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        count += mydatatable.Rows(0).Item("count_id")

        lbl_IDorder.Text = "OR" + count.ToString("100")

    End Sub
    Private Sub refresh_staff()

        Dim mysql As String = "SELECT FLD_STAFF_ID FROM TBL_STAFF_A174807"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        cmb_staffID.DataSource = mydatatable

        cmb_staffID.DisplayMember = "FLD_STAFF_ID"

    End Sub
    Private Sub refresh_customer()

        Dim mysql As String = "SELECT FLD_CUST_ID FROM TBL_CUSTOMER_A174807"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        cmb_customerID.DataSource = mydatatable

        cmb_customerID.DisplayMember = "FLD_CUST_ID"

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a174807.Show()
        Me.Hide()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub
    Private Sub nud_quantity_ValueChanged(sender As Object, e As EventArgs) Handles nud_quantity.ValueChanged

        num = nud_quantity.Value
        number1 = txt_price.Text()
        lbl_STotal.Text = num * number1

    End Sub

    Private Sub btn_neworder_Click(sender As Object, e As EventArgs) Handles btn_neworder.Click
        Dim mytransaction As OleDb.OleDbTransaction

        myconnection2.Open()

        mytransaction = myconnection2.BeginTransaction

        Try

            Dim mysql As String = "INSERT INTO TBL_ORDER_A174807 (FLD_ORDER_ID, FLD_STAFF, FLD_CUSTOMER, FLD_DATE_PURCHASED) values 
            ('" & lbl_IDorder.Text & "', '" & cmb_staffID.Text & "','" & cmb_customerID.Text & "','" & txt_date.Text & "')"
            'Dim mysql As String = "INSERT INTO TBL_ORDER_A174807 (FLD_ORDER_ID, FLD_STAFF, FLD_CUSTOMER, FLD_DATE_PURCHASED) values 
            '('" & lbl_IDorder.Text & "', '" & cmb_staffID.Text & "','" & cmb_customerID.Text & "','" & dtp_date.Text & "')"

            Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2, mytransaction)

            mywriter.ExecuteNonQuery()
            mytransaction.Commit()
            myconnection2.Close()

            Beep()
            MsgBox("Proceed to make a new order")

            refresh_grid()
            grd_orderdetails.Rows.Clear()

        Catch ex As Exception

            Beep()
            MsgBox("There is a problem during transaction: " & vbCrLf & vbCrLf & ex.Message)
            mytransaction.Rollback()
            myconnection2.Close()
            refresh_grid()

        End Try

        btn_addtocart.Enabled = True
        btn_confirm.Enabled = True
        btn_remove.Enabled = True
        btn_neworder.Enabled = False
    End Sub

    Private Sub refresh_price()

        If grd_orderdetails.RowCount > 0 Then

            money = 0

            For index As Integer = 0 To grd_orderdetails.RowCount - 1

                money += Convert.ToDouble(grd_orderdetails.Rows(index).Cells(2).Value)

            Next

            lbl_TotalRM.Text = money

        ElseIf grd_orderdetails.RowCount = 1 Then

            lbl_TotalRM.Text = " 0 "

        End If

    End Sub


    Private Sub btn_confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click
        Dim mytransaction As OleDb.OleDbTransaction
        myconnection2.Open()

        mytransaction = myconnection2.BeginTransaction

        Try

            For i As Integer = 0 To grd_orderdetails.RowCount - 1
                Dim productid As String = grd_orderdetails(0, i).Value
                'Dim pdtname As String = grd_orderdetails(1, i).Value
                Dim quantity As String = grd_orderdetails(1, i).Value
                Dim price As String = grd_orderdetails(2, i).Value

                Dim mysql As String = "INSERT INTO TBL_RECEIPT_A174807 (FLD_ORDER_ID, FLD_PRODUCTS_ID, FLD_QUANTITY, FLD_SUBTOL) 
                VALUES (""" & lbl_IDorder.Text & """, """ & productid & """,  """ & quantity & """, """ & price & """)"

                Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2, mytransaction)

                mywriter.ExecuteNonQuery()

            Next

            mytransaction.Commit()
            myconnection2.Close()

            Beep()
            MsgBox("Transaction Successful!")

            frm_invoice_a174807.lbl_idorder.Text = lbl_IDorder.Text
            frm_invoice_a174807.lbl_staffid.Text = cmb_staffID.Text
            frm_invoice_a174807.lbl_custid.Text = cmb_customerID.Text
            frm_invoice_a174807.lbl_PDate.Text = txt_date.Text
            frm_invoice_a174807.lbl_total.Text = lbl_TotalRM.Text
            frm_invoice_a174807.Show()

            refresh_grid()
            grd_orderdetails.Rows.Clear()

        Catch ex As Exception

            Beep()
            MsgBox("There is a problem during transaction:  " & vbCrLf & vbCrLf & ex.Message)
            mytransaction.Rollback()
            myconnection2.Close()
            refresh_grid()

        End Try

        btn_addtocart.Enabled = False
        btn_confirm.Enabled = False
        btn_remove.Enabled = False
        btn_neworder.Enabled = True
        nud_quantity.Value = 0
        lbl_TotalRM.Text = "0"
        refresh_count()
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        refresh_text(cmb_productid.Text)
    End Sub

    Private Sub btn_invoice_Click(sender As Object, e As EventArgs) Handles btn_invoice.Click
        frm_invoices_a174807.Show()
        Me.Hide()
    End Sub

    Private Sub grd_orderdetails_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_orderdetails.CellContentClick

    End Sub

    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btn_remove.Click
        Dim delete_order = MsgBox("Are you sure you want to remove this item in the Cart?", MsgBoxStyle.YesNo)

        If delete_order = MsgBoxResult.Yes Then

            grd_orderdetails.Rows.Remove(grd_orderdetails.CurrentRow)
            refresh_price()

        Else

            refresh_price()

        End If
    End Sub

    Private Sub btn_addtocart_Click_1(sender As Object, e As EventArgs) Handles btn_addtocart.Click

        grd_orderdetails.Rows.Add(New String() {cmb_productid.Text, nud_quantity.Value, lbl_STotal.Text})
        lbl_STotal.Text = ""
        nud_quantity.Value = 0
        lbl_TotalRM.Text = ""
        refresh_grid()
        refresh_price()
    End Sub

    Private Sub frm_makeOrder_a174807_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub
End Class