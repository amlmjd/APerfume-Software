Public Class frm_customer_a174807
    Private Sub frm_customer_a174807_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_APERFUME_A174807.accdb;Persist Security Info=False;"
        Dim mysql As String = "SELECT * FROM TBL_CUSTOMER_A174807"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_customer.DataSource = mydatatable
        grd_customer.Columns(0).HeaderText = "CUSTOMER ID"
        grd_customer.Columns(1).HeaderText = "NAME"
        grd_customer.Columns(2).HeaderText = "ADDRESS"
        grd_customer.Columns(3).HeaderText = "PHONE NUMBER"

    End Sub

    Private Sub Back_btn_Click(sender As Object, e As EventArgs) Handles Back_btn.Click
        frm_mainmenu_a174807.Show()
        Me.Hide()
    End Sub

    Private Sub Exit_btn_Click(sender As Object, e As EventArgs) Handles Exit_btn.Click
        End
    End Sub

    Private Sub grd_customer_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_customer.CellContentClick

    End Sub

    Private Sub lbl_date_Click(sender As Object, e As EventArgs)

    End Sub
End Class