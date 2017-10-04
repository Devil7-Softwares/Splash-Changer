Public Class frm_About

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Process.Start("https://chat.whatsapp.com/EnJsSukWafaLuD9cMg6NYn")
    End Sub

    Private Sub frm_About_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbl_Version.Text = Application.ProductVersion
    End Sub
End Class