Public Class frm_insertStaff_a174807
    Private Sub frm_insertStaff_a174807_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grd_staff.DataSource = run_sql_query("SELECT * FROM TBL_STAFF_A174807 ORDER BY FLD_STAFF_ID")
        grd_staff.Columns(0).HeaderText = "STAFF ID"
        grd_staff.Columns(1).HeaderText = "NAME"
        grd_staff.Columns(2).HeaderText = "EMAIL"
        grd_staff.Columns(3).HeaderText = "PHONE NUMBER"


        txt_id.Text = generate_custID()

    End Sub
    Private Function generate_custID()
        Dim lastID As String = run_sql_query("SELECT MAX(FLD_STAFF_ID)AS LASTID FROM TBL_STAFF_A174807").Rows(0).Item("LASTID")
        Dim newID As String = "ST" & Mid(lastID, 3) + 1
        Return newID
    End Function

    Private Sub btn_Insert_Click(sender As Object, e As EventArgs) Handles btn_Insert.Click
        Dim mysql As String = "INSERT INTO TBL_STAFF_A174807 VALUES('" & txt_id.Text & "', '" & txt_name.Text & "', '" & txt_email.Text & "', '" & txt_phone.Text & "')"
        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)
        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            grd_staff.DataSource = run_sql_query("SELECT*FROM TBL_STAFF_A174807 ORDER BY FLD_STAFF_ID")
            txt_id.Text = generate_custID()
            'txt_id.Text = ""
            txt_name.Text = ""
            txt_email.Text = ""
            txt_phone.Text = ""

            MsgBox("Data of New Staff has been Insert Successfully")
        Catch ex As Exception
            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_mainmenu_a174807.Show()
        Me.Hide()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub
End Class