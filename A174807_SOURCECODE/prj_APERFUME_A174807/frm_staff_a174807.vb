Public Class frm_staff_a174807
    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ThankYouLabel_Click(sender As Object, e As EventArgs) Handles ThankYouLabel.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_staff.CellContentClick

    End Sub

    Private Sub frm_staff_a174807_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_APERFUME_A174807.accdb;Persist Security Info=False;"
        Dim mysql As String = "SELECT * FROM TBL_STAFF_A174807"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_staff.DataSource = mydatatable

        grd_staff.Columns(0).HeaderText = "STAFF ID"
        grd_staff.Columns(1).HeaderText = "NAME"
        grd_staff.Columns(2).HeaderText = "EMAIL"
        grd_staff.Columns(3).HeaderText = "PHONE NUMBER"
    End Sub

    Private Sub Back_button_Click(sender As Object, e As EventArgs) Handles Back_button.Click
        frm_mainmenu_a174807.Show()
        Me.Hide()
    End Sub

    Private Sub Exit_btn_Click(sender As Object, e As EventArgs) Handles Exit_btn.Click
        End
    End Sub

    Private Sub lbl_date_Click(sender As Object, e As EventArgs)

    End Sub
End Class