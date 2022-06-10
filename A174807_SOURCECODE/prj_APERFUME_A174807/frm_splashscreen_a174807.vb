Public Class frm_splashscreen_a174807
    Private Sub btn_enter_Click(sender As Object, e As EventArgs) Handles btn_enter.Click
        'username = txt_username.Text
        frm_mainmenu_a174807.Show()
        Me.Hide()
    End Sub

    Private Sub frm_splashscreen_a174807_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim current_date As String = Date.Now
        lbl_date.Text = current_date
    End Sub

    Private Sub frm_splashscreen_a174807_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub
End Class