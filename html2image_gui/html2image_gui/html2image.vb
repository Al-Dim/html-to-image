Imports System.Drawing
Imports System.Windows.Forms

Module html2image

    Sub html2image(ByVal str_html_path As String, ByVal str_image_path As String)

        Dim str_image_type As String, I As Integer
        Dim wb As New WebBrowser

        wb.ScrollBarsEnabled = False
        wb.ScriptErrorsSuppressed = True
        wb.Navigate(str_html_path)
        While Not wb.ReadyState = WebBrowserReadyState.Complete
            Application.DoEvents()
        End While
        wb.Width = wb.Document.Body.ScrollRectangle.Width
        wb.Height = wb.Document.Body.ScrollRectangle.Height
        Dim bitmap As New Bitmap(wb.Width, wb.Height)
        wb.DrawToBitmap(bitmap, New Rectangle(0, 0, wb.Width, wb.Height))
        wb.Dispose()

        If InStr(str_image_path, "\") = 0 Then
            I = InStrRev(str_html_path, "\")
            If I > 0 Then
                str_image_path = Left(str_html_path, I) & str_image_path
            Else
                Console.WriteLine("Syntax: html2image <html_file_path> <image_file_path>")
                End
            End If
        End If

        I = InStrRev(str_image_path, ".")
        If I > 0 Then
            str_image_type = Mid(str_image_path, I + 1).ToLower
            Select Case str_image_type
                Case "png"
                    bitmap.Save(str_image_path, System.Drawing.Imaging.ImageFormat.Png)
                Case "jpeg"
                    bitmap.Save(str_image_path, System.Drawing.Imaging.ImageFormat.Jpeg)
                Case "bmp"
                    bitmap.Save(str_image_path, System.Drawing.Imaging.ImageFormat.Bmp)
                Case "emf"
                    bitmap.Save(str_image_path, System.Drawing.Imaging.ImageFormat.Emf)
                Case "exif"
                    bitmap.Save(str_image_path, System.Drawing.Imaging.ImageFormat.Exif)
                Case "gif"
                    bitmap.Save(str_image_path, System.Drawing.Imaging.ImageFormat.Gif)
                Case "icon"
                    bitmap.Save(str_image_path, System.Drawing.Imaging.ImageFormat.Icon)
                Case "tiff"
                    bitmap.Save(str_image_path, System.Drawing.Imaging.ImageFormat.Tiff)
                Case "wmf"
                    bitmap.Save(str_image_path, System.Drawing.Imaging.ImageFormat.Wmf)
                Case Else
                    str_image_path = Left(str_image_path, I) & ".png"
                    bitmap.Save(str_image_path, System.Drawing.Imaging.ImageFormat.Png)
            End Select
        Else
            str_image_path = str_image_path & ".png"
            bitmap.Save(str_image_path, System.Drawing.Imaging.ImageFormat.Png)
        End If

    End Sub

    Sub html2image_gui(ByVal str_html_path As String, ByVal str_image_path As String)

        Dim str_image_type As String, I As Integer
        Dim wb As New WebBrowser

        wb.ScrollBarsEnabled = False
        wb.ScriptErrorsSuppressed = True
        wb.Navigate(str_html_path)
        While Not wb.ReadyState = WebBrowserReadyState.Complete
            Application.DoEvents()
        End While
        wb.Width = wb.Document.Body.ScrollRectangle.Width
        wb.Height = wb.Document.Body.ScrollRectangle.Height
        Dim bitmap As New Bitmap(wb.Width, wb.Height)
        wb.DrawToBitmap(bitmap, New Rectangle(0, 0, wb.Width, wb.Height))
        wb.Dispose()

        I = InStrRev(str_image_path, ".")
        If I > 0 Then
            str_image_type = Mid(str_image_path, I + 1).ToLower
            Select Case str_image_type
                Case "png"
                    bitmap.Save(str_image_path, System.Drawing.Imaging.ImageFormat.Png)
                Case "jpeg"
                    bitmap.Save(str_image_path, System.Drawing.Imaging.ImageFormat.Jpeg)
                Case "bmp"
                    bitmap.Save(str_image_path, System.Drawing.Imaging.ImageFormat.Bmp)
                Case "emf"
                    bitmap.Save(str_image_path, System.Drawing.Imaging.ImageFormat.Emf)
                Case "exif"
                    bitmap.Save(str_image_path, System.Drawing.Imaging.ImageFormat.Exif)
                Case "gif"
                    bitmap.Save(str_image_path, System.Drawing.Imaging.ImageFormat.Gif)
                Case "icon"
                    bitmap.Save(str_image_path, System.Drawing.Imaging.ImageFormat.Icon)
                Case "tiff"
                    bitmap.Save(str_image_path, System.Drawing.Imaging.ImageFormat.Tiff)
                Case "wmf"
                    bitmap.Save(str_image_path, System.Drawing.Imaging.ImageFormat.Wmf)
                Case Else
                    str_image_path = Left(str_image_path, I) & ".png"
                    bitmap.Save(str_image_path, System.Drawing.Imaging.ImageFormat.Png)
            End Select
        Else
            str_image_path = str_image_path & ".png"
            bitmap.Save(str_image_path, System.Drawing.Imaging.ImageFormat.Png)
        End If

    End Sub

    Sub Main()

        Dim PATH As String, str_temp As String, I As Integer, str_html As String, str_image As String

        PATH = Application.StartupPath
        If Right(PATH, 1) <> "\" Then PATH = PATH & "\"

        If My.Application.CommandLineArgs.Count > 0 Then
            str_temp = Environment.CommandLine()
            str_html = ""
            str_image = ""
            I = InStr(str_temp, " ")
            If I > 0 Then
                str_temp = Mid(str_temp, I + 1).Trim
            Else
                Console.WriteLine("Syntax: html2image <html_file_path> <image_file_path>")
                End
            End If
            I = InStr(str_temp, "html")
            If I > 0 Then
                str_html = Left(str_temp, I + 4).Trim
                str_image = Mid(str_temp, I + 4).Trim
            Else
                Console.WriteLine("Syntax: html2image <html_file_path> <image_file_path>")
                End
            End If

            str_html = str_html.Replace("/", "\")
            str_image = str_image.Replace("/", "\")

            If Dir(str_html) = "" Then
                If Dir(PATH & str_html) = "" Then
                    Console.WriteLine("Syntax: html2image <html_file_path> <image_file_path>")
                    End
                Else
                    str_html = PATH & str_html
                End If
            Else
                If InStr(str_html, "\") = 0 Then
                    If Dir(PATH & str_html) = "" Then
                        Console.WriteLine("Syntax: html2image <html_file_path> <image_file_path>")
                        End
                    Else
                        str_html = PATH & str_html
                    End If
                End If
            End If
            If str_image.Trim = "" Then
                Console.WriteLine("Syntax: html2image <html_file_path> <image_file_path>")
                End
            End If
            Console.WriteLine("Start converting ...")
            html2image(str_html, str_image)
            Console.WriteLine("Convertion ended :)")
        Else
            Dim frmMain As New frm_main
            frmMain.ShowDialog()
        End If

    End Sub

End Module
