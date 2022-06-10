Public Class frm_updateCustomer_a174807
    Dim current_id As String
    Private Sub frm_updateCustomer_a174807_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grd_customer.DataSource = run_sql_query("SELECT*FROM TBL_CUSTOMER_A174807 ORDER BY FLD_CUST_ID")
        grd_customer.Columns(0).HeaderText = "CUSTOMER ID"
        grd_customer.Columns(1).HeaderText = "NAME"
        grd_customer.Columns(2).HeaderText = "ADDRESS"
        grd_customer.Columns(3).HeaderText = "PHONE NUMBER"
        refresh_grid()
        get_current_id()
    End Sub

    Private Sub refresh_grid()
        Dim mysql As String = "SELECT*FROM TBL_CUSTOMER_A174807"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_customer.DataSource = mydatatable
    End Sub

    Private Sub clear_fields()
        txt_id.Text = ""
        txt_name.Text = ""
        txt_address.Text = ""
        txt_phone.Text = ""
    End Sub

    Private Sub get_current_id()
        Dim current_row As Integer = grd_customer.CurrentRow.Index
        current_id = grd_customer(0, current_row).Value

        txt_id.Text = current_id
        txt_name.Text = grd_customer(1, current_row).Value
        txt_address.Text = grd_customer(2, current_row).Value
        txt_phone.Text = grd_customer(3, current_row).Value

    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a174807.Show()
        Me.Hide()
    End Sub

    Private Sub grd_customer_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_customer.CellContentClick

    End Sub

    Private Sub grd_customer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_customer.CellClick
        get_current_id()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        run_sql_command("UPDATE TBL_CUSTOMER_A174807 SET FLD_CUST_NAME='" & txt_name.Text & "' WHERE FLD_CUST_ID='" & current_id & "'")
        run_sql_command("UPDATE TBL_CUSTOMER_A174807 SET FLD_CUST_ADDRESS='" & txt_address.Text & "' WHERE FLD_CUST_ID='" & current_id & "'")
        run_sql_command("UPDATE TBL_CUSTOMER_A174807 SET FLD_CUST_PHONE='" & txt_phone.Text & "' WHERE FLD_CUST_ID='" & current_id & "'")

        Beep()
        MsgBox("You have successfully update the Staff """ & current_id & """.")

        refresh_grid()
        clear_fields()
        get_current_id()
    End Sub

    Private Sub frm_updateCustomer_a174807_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the informations of """ & current_id & """?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then

            run_sql_command("DELETE FROM TBL_CUSTOMER_A174807 WHERE FLD_CUST_ID='" & current_id & "'")

            Beep()
            MsgBox("The data of """ & current_id & """ has been successfully deleted.")

            refresh_grid()
            clear_fields()
            get_current_id()
        End If
    End Sub
End Class