
Public Class FormLogo

    '添加修改按钮单击事件
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim Browser As New OpenFileDialog With {
            .FileName = "oem", ' 默认文件名
            .DefaultExt = ".bmp", ' 默认文件扩展名
            .Filter = "位图 |*.bmp", ' 对话框中可用的文件筛选选项
            .Title = "浏览文件" '文件对话框标题
            }
        ' Show open file dialog box
        If Browser.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try

                picLogo.ImageLocation = Browser.FileName
                FormMain.pnlLogo.BackgroundImage = Bitmap.FromFile(Browser.FileName)
            Catch ex As System.OutOfMemoryException
                MessageBox.Show("错误: " & ex.Message)
            Finally '
                Browser.Dispose()
            End Try

        End If
    End Sub
    '保存更改按钮单击事件
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        picLogo.ImageLocation = Nothing
        picLogo.Image = Nothing
        FormMain.pnlLogo.BackgroundImage = Nothing
        'Try
        '    'logo
        '    My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation",
        '    "LOGO", browser.FileName)
        'Catch ex As Exception
        '    MsgBox(ErrorToString)
        '    Exit Sub
        'End Try
        'Button2.Text = "修改成功"
        'Me.Close()
    End Sub

End Class