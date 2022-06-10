Public Class frm_updateStaff_a174807
    Dim current_id As String
    Private Sub frm_updateStaff_a174807_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        grd_staff.DataSource = run_sql_query("SELECT*FROM TBL_STAFF_A174807")
        grd_staff.Columns(0).HeaderText = "STAFF ID"
        grd_staff.Columns(1).HeaderText = "NAME"
        grd_staff.Columns(2).HeaderText = "EMAIL"
        grd_staff.Columns(3).HeaderText = "PHONE NUMBER"
    End Sub

    Private Sub refresh_grid()
        Dim mysql As String = "SELECT* FROM TBL_STAFF_A174807"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_staff.DataSource = mydatatable
    End Sub

    Private Sub clear_fields()
        txt_id.Text = ""
        txt_name.Text = ""
        txt_email.Text = ""
        txt_phone.Text = ""
    End Sub

    Private Sub get_current_id()
        Dim current_row As Integer = grd_staff.CurrentRow.Index
        current_id = grd_staff(0, current_row).Value

        txt_id.Text = current_id
        txt_name.Text = grd_staff(1, current_row).Value
        txt_email.Text = grd_staff(2, current_row).Value
        txt_phone.Text = grd_staff(3, current_row).Value

    End Sub

    Private Sub grd_staff_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_staff.CellContentClick

    End Sub

    Private Sub grd_staff_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_staff.CellClick
        get_current_id()
    End Sub

    Private Sub btn_Upadte_Click(sender As Object, e As EventArgs) Handles btn_Upadte.Click
        run_sql_command("UPDATE TBL_STAFF_A174807 SET FLD_STAFF_NAME='" & txt_name.Text & "' WHERE FLD_STAFF_ID='" & current_id & "'")
        run_sql_command("UPDATE TBL_STAFF_A174807 SET FLD_STAFF_EMAIL='" & txt_email.Text & "' WHERE FLD_STAFF_ID= '" & current_id & "'")
        run_sql_command("UPDATE TBL_STAFF_A174807 SET FLD_STAFF_PHONE='" & txt_phone.Text & "' WHERE FLD_STAFF_ID= '" & current_id & "'")

        Beep()
        MsgBox("You have successfully update the Staff """ & current_id & """.")
        refresh_grid()
        clear_fields()
        get_current_id()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a174807.Show()
        Me.Hide()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim delete_confrimation = MsgBox("Are you sure you would like to delete the information of """ & current_id & """ ?", MsgBoxStyle.YesNo)

        If delete_confrimation = MsgBoxResult.Yes Then
            run_sql_command("DELETE FROM TBL_STAFF_A174807 WHERE FLD_STAFF_ID='" & current_id & "'")
            Beep()
            MsgBox("The Data of """ & current_id & """ has been successfully deleted.")
            refresh_grid()
            clear_fields()
            get_current_id()
        End If
    End Sub
End Class