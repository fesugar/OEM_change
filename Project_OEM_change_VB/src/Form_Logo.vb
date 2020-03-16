#Region "版 本 注 释 "
' ----------------------------------------------------------------
' 项目名称 ：OEMchange
' 项目描述 ：OEM_change for VB.NET
' 类 名 称 ：FormLogo
' 类 描 述 ：图标按钮窗体
' 命名空间 ：OEMchange
' CLR 版本 ：4.0
' 作    者 ：fesugar
' 邮    箱 ：fesugar@fesugar.com
' 创建时间 ：12:42 2020/3/16
' 更新时间 ：12:42 2020/3/16
' 版 本 号 ：v1.0.0.0
' 参考文献 ：
' *****************************************************************
' * Copyright @ fesugar 2020. All rights reserved.
' *****************************************************************
' ----------------------------------------------------------------*
#End Region

''' <summary>
''' 修改图标窗体
''' </summary>
Public Class FormLogo

    ''' <summary>
    ''' 添加图标按钮单击事件
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
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
    ''' <summary>
    ''' 清空图标按钮单击事件
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
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