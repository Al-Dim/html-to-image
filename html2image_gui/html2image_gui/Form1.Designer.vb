<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txt_html = New System.Windows.Forms.TextBox()
        Me.cmd_html = New System.Windows.Forms.Button()
        Me.lbl_info = New System.Windows.Forms.Label()
        Me.lbl_info_2 = New System.Windows.Forms.Label()
        Me.cmd_image = New System.Windows.Forms.Button()
        Me.txt_image = New System.Windows.Forms.TextBox()
        Me.cmd_convert = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'txt_html
        '
        Me.txt_html.Location = New System.Drawing.Point(12, 30)
        Me.txt_html.Name = "txt_html"
        Me.txt_html.Size = New System.Drawing.Size(382, 20)
        Me.txt_html.TabIndex = 0
        '
        'cmd_html
        '
        Me.cmd_html.Location = New System.Drawing.Point(410, 30)
        Me.cmd_html.Name = "cmd_html"
        Me.cmd_html.Size = New System.Drawing.Size(126, 23)
        Me.cmd_html.TabIndex = 1
        Me.cmd_html.Text = "Choose HTML"
        Me.cmd_html.UseVisualStyleBackColor = True
        '
        'lbl_info
        '
        Me.lbl_info.AutoSize = True
        Me.lbl_info.BackColor = System.Drawing.Color.White
        Me.lbl_info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_info.Location = New System.Drawing.Point(12, 9)
        Me.lbl_info.Name = "lbl_info"
        Me.lbl_info.Size = New System.Drawing.Size(47, 15)
        Me.lbl_info.TabIndex = 2
        Me.lbl_info.Text = "html link"
        '
        'lbl_info_2
        '
        Me.lbl_info_2.AutoSize = True
        Me.lbl_info_2.BackColor = System.Drawing.Color.White
        Me.lbl_info_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_info_2.Location = New System.Drawing.Point(12, 58)
        Me.lbl_info_2.Name = "lbl_info_2"
        Me.lbl_info_2.Size = New System.Drawing.Size(61, 15)
        Me.lbl_info_2.TabIndex = 5
        Me.lbl_info_2.Text = "image path"
        '
        'cmd_image
        '
        Me.cmd_image.Location = New System.Drawing.Point(410, 79)
        Me.cmd_image.Name = "cmd_image"
        Me.cmd_image.Size = New System.Drawing.Size(126, 23)
        Me.cmd_image.TabIndex = 4
        Me.cmd_image.Text = "Choose IMAGE"
        Me.cmd_image.UseVisualStyleBackColor = True
        '
        'txt_image
        '
        Me.txt_image.Location = New System.Drawing.Point(12, 79)
        Me.txt_image.Name = "txt_image"
        Me.txt_image.Size = New System.Drawing.Size(382, 20)
        Me.txt_image.TabIndex = 3
        '
        'cmd_convert
        '
        Me.cmd_convert.Location = New System.Drawing.Point(12, 119)
        Me.cmd_convert.Name = "cmd_convert"
        Me.cmd_convert.Size = New System.Drawing.Size(524, 51)
        Me.cmd_convert.TabIndex = 6
        Me.cmd_convert.Text = "Convert"
        Me.cmd_convert.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 180)
        Me.Controls.Add(Me.cmd_convert)
        Me.Controls.Add(Me.lbl_info_2)
        Me.Controls.Add(Me.cmd_image)
        Me.Controls.Add(Me.txt_image)
        Me.Controls.Add(Me.lbl_info)
        Me.Controls.Add(Me.cmd_html)
        Me.Controls.Add(Me.txt_html)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "html2image < GUI >"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_html As TextBox
    Friend WithEvents cmd_html As Button
    Friend WithEvents lbl_info As Label
    Friend WithEvents lbl_info_2 As Label
    Friend WithEvents cmd_image As Button
    Friend WithEvents txt_image As TextBox
    Friend WithEvents cmd_convert As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
