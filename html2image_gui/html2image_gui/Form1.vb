Public Class frm_main
    Private Sub cmd_html_Click(sender As Object, e As EventArgs) Handles cmd_html.Click
        OpenFileDialog1.Filter = "HTML Files (*.html)|*.html"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            txt_html.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub cmd_image_Click(sender As Object, e As EventArgs) Handles cmd_image.Click
        SaveFileDialog1.Filter = "PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|JPEG Files (*.jpeg)|*.jpeg|TIFF Files (*.tiff)|*.tiff|EMF Files (*.emf)|*.emf|EXIF Files (*.exif)|*.exif|GIF Files (*.gif)|*.gif|ICON Files (*.icon)|*.icon|WMF Files (*.wmf)|*.wmf"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            txt_image.Text = SaveFileDialog1.FileName
        End If
    End Sub

    Private Sub cmd_convert_Click(sender As Object, e As EventArgs) Handles cmd_convert.Click
        If txt_html.Text = "" Or txt_image.Text = "" Then
            MsgBox("Please choose an html file and an image filename.", vbExclamation + vbOKOnly, "User Error...")
            Exit Sub
        End If
        cmd_convert.Text = "Converting..."
        html2image.html2image_gui(txt_html.Text, txt_image.Text)
        cmd_convert.Text = "Convert"
        MsgBox("Convertion ended :)", vbInformation + vbOKOnly, "Information...")
    End Sub

    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'pass
    End Sub
End Class
