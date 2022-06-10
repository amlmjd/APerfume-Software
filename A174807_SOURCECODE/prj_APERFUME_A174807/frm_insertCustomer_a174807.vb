Public Class frm_insertCustomer_a174807
    Private Sub frm_insertCustomer_a174807_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grd_customer.DataSource = run_sql_query("SELECT*FROM TBL_CUSTOMER_A174807 ORDER BY FLD_CUST_ID")
        grd_customer.Columns(0).HeaderText = "CUSTOMER ID"
        grd_customer.Columns(1).HeaderText = "NAME"
        grd_customer.Columns(2).HeaderText = "ADDRESS"
        grd_customer.Columns(3).HeaderText = "PHONE NUMBER"

        txt_id.Text = generate_custID()
    End Sub
    Private Function generate_custID()
        Dim lastID As String = run_sql_query("SELECT MAX(FLD_CUST_ID) AS LASTID FROM TBL_CUSTOMER_A174807").Rows(0).Item("LASTID")
        Dim newID As String = "C" & "U" & Mid(lastID, 3) + 1
        Return newID
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mysql As String = "INSERT INTO TBL_CUSTOMER_A174807 VALUES ('” & txt_id.Text & "', '" & txt_name.Text & "', '" & txt_address.Text & "', '" & txt_phone.Text & "')"
        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)
        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            grd_customer.DataSource = run_sql_query("SELECT*FROM TBL_CUSTOMER_A174807 ORDER BY FLD_CUST_ID")

            txt_id.Text = generate_custID()
            'txt_id.Text = ""
            txt_name.Text = ""
            txt_address.Text = ""
            txt_phone.Text = ""

            MsgBox("Data of New Customer has been Insert Successfuly")
        Catch ex As Exception
            Beep()
            MsgBox(“There is a mistake in the data you entered, as shown below” & vbCrLf & vbCrLf & ex.Message)
            mywriter.Connection.Close()
        End Try
        'refresh_grid()
        'clear_fields()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a174807.Show()
        Me.Hide()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub
End Class