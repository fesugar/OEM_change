Imports System.IO
Imports System.Xml
Imports Newtonsoft.Json

Public Class FormMain
    Private Sub Form_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tipFirst.SetToolTip(tbpgOne, "已经设置好的一些OEM方案")
        tipFirst.SetToolTip(tbpgTwo, "自定义OEM信息")
        tipFirst.SetToolTip(btnClear, "清空当前的设置信息")
        tipFirst.SetToolTip(btnReset, "自动填写默认缺省值信息")
        tipFirst.SetToolTip(btnLogo, "单独设置logo图标信息")
        tipFirst.SetToolTip(btnOk, "保存当前所设置的OEM信息")
        tipFirst.SetToolTip(cboDefaultScheme, "预设OEM方案选择")
        tipFirst.SetToolTip(lblCurrentSystem, "当前电脑运行的系统信息")
        tipFirst.SetToolTip(pnlLogo, "所展示的logo图标")
        On Error Resume Next
        GetINFO()
        lblCurrentSystem.Text += My.Computer.Info.OSFullName

        '读取设定档 
        Dim xmlDoc = New XmlDocument()
        xmlDoc.Load(My.Application.Info.DirectoryPath & "\content.xml")

        '取得节点 

        Dim xmlNode = xmlDoc.SelectSingleNode("combox")
        For Each item In xmlNode.ChildNodes

            cboDefaultScheme.Items.Add(item.Attributes("ItemName").value)

        Next
    End Sub

    Private Function GetINFO()
        '使用 GetValue 方法，指定路径和名称) 读取注册表项的值。 下面的示例读取 HKEY_CURRENT_USER\Software\MyApp 的值 Name 并在消息框中显示该
        'Dim readValue = My.Computer.Registry.GetValue(
        '"HKEY_CURRENT_USER\Software\MyApp", "Name", Nothing)
        'MsgBox("The value is " & readValue)
        On Error Resume Next '如果执行中有错误，直接往下执行
        Dim _
        read_Manufacturer_Value = My.Computer.Registry.GetValue(
            "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation", "Manufacturer", Nothing),
        read_Model_Value = My.Computer.Registry.GetValue(
            "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation", "Model", Nothing),
        read_SupportHours_Value = My.Computer.Registry.GetValue(
            "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation", "SupportHours", Nothing),
        read_SupportPhone_Value = My.Computer.Registry.GetValue(
            "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation", "SupportPhone", Nothing),
        read_SupportURL_Value = My.Computer.Registry.GetValue(
            "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation", "SupportURL", Nothing),
         read_Logo_Value = My.Computer.Registry.GetValue(
            "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation", "Logo", Nothing)
        '获取注册表相关的值并显示
        lblManufacturer.Text = read_Manufacturer_Value
        lblModel.Text = read_Model_Value
        lblSupportHours.Text = read_SupportHours_Value
        lblSupportPhone.Text = read_SupportPhone_Value
        lblSupportUrl.Text = read_SupportURL_Value
        Me.pnlLogo.BackgroundImage = Bitmap.FromFile(read_Logo_Value)
        grpSecond.Text = "当前系统中OEM信息预览"
    End Function

    Private Sub Btn_clear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        tctlInfo.SelectedIndex = 1
        '清空输入框所有内容
        txtManufacturer.Clear()
        txtModel.Clear()
        txtSupportHours.Clear()
        txtSupportPhone.Clear()
        txtSupportUrl.Clear()
        pnlLogo.BackgroundImage = Nothing
        GetINFO()
    End Sub

    Private Sub Btn_reset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        tctlInfo.SelectedIndex = 1
        '自动填写为默认的信息
        Shell("cmd.exe /c wmic /output:tmp BASEBOARD get Manufacturer ", AppWinStyle.Hide, True, 3000)
        txtManufacturer.Text = File.ReadAllText("tmp")
        Shell("cmd.exe /c wmic /output:tmp BASEBOARD get Model ", AppWinStyle.Hide, True, 3000)
        txtModel.Text = File.ReadAllText("tmp")
        txtSupportHours.Text = "SupportHours"
        txtSupportPhone.Text = "SupportPhone"
        txtSupportUrl.Text = "SupportURL"

    End Sub

    Private Sub Btn_OK_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If MessageBox.Show("您确认继续操作更改吗？", "是否更改", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2) = DialogResult.No Then Return
        Shell("cmd.exe /c REG SAVE HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation bk /y", AppWinStyle.Hide, True, 3000)

        Try     'Try......Catch......Catch......End Try 用于程序运行中发生未知错误等错误的处理
            '修改注册表OEMInformation信息  
            ' Windows Registry Editor Version 5.00

            '[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation]
            '"Manufacturer"="Manufacturer"
            '"Logo"="%windir%\\system32\\oem.bmp"
            '"SupportPhone"="SupportPhone"
            '"SupportURL"="SupportURL"
            '"Model"="Model"
            '"SupportHours"="SupportHours"

            '此示例创建注册表项 MyTestKey 在 HKEY_CURRENT_USER 下然后将字符串值 MyTestKeyValue 到 This is a test value。
            'My.Computer.Registry.CurrentUser.CreateSubKey("MyTestKey")
            ' Change MyTestKeyValue to This is a test value. 
            'My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MyTestKey",
            '"MyTestKeyValue", "This is a test value.")

            'My.Computer.Registry.LocalMachine.CreateSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation")
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation",
      "Manufacturer", txtManufacturer.Text)
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation",
     "Model", txtModel.Text)
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation",
     "SupportPhone", txtSupportPhone.Text)
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation",
     "SupportHours", txtSupportHours.Text)
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation",
     "SupportURL", txtSupportUrl.Text)
            Dim gid = System.Guid.NewGuid.ToString()
            '  If (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles).ToString & "\oem\images")) = True Then Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles).ToString & "\oem\images")
            If (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.System).ToString & "\oobe\info")) = False Then Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.System).ToString & "\oobe\info")
            If pnlLogo.BackgroundImage IsNot Nothing Then pnlLogo.BackgroundImage.Save(Environment.GetFolderPath(Environment.SpecialFolder.System).ToString & "\oobe\info\" & gid & "_logo.bmp", System.Drawing.Imaging.ImageFormat.Bmp)

            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation",
     "LOGO", Environment.GetFolderPath(Environment.SpecialFolder.System) & "\oobe\info\" & gid & "_logo.bmp")
        Catch ex As System.IO.DirectoryNotFoundException
            MsgBox(ErrorToString) '显示详细错误信息
            Exit Sub '退出此事件，不在往下执行
        End Try

        Shell("cmd.exe /c control.exe system")
        GetINFO()
        If MessageBox.Show("需要撤销对系统OEM信息的更改吗？", "对结果不满意", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1) = DialogResult.No Then Return
        Shell("cmd.exe /c REG RESTORE HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation bk", AppWinStyle.Hide, True, 3000)
        Shell("cmd.exe /c control.exe system")
        GetINFO()
    End Sub

    Private Sub Btn_logo_Click(sender As Object, e As EventArgs) Handles btnLogo.Click
        Dim dlg As New FormLogo
        dlg.Left = Me.Left + 20
        dlg.Top = Me.Top + 35
        dlg.picLogo.Image = pnlLogo.BackgroundImage
        'form2窗体透明度
        dlg.Opacity = 93%
        dlg.ShowDialog()
        dlg.Dispose()
    End Sub

    Private Sub MetroComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDefaultScheme.SelectedIndexChanged
        Try


            Dim f = File.OpenText(My.Application.Info.DirectoryPath & "\content.json").ReadToEnd

            lblManufacturer.Text = JsonConvert.DeserializeObject(f)(cboDefaultScheme.Text.ToString)("Manufacturer").ToString()
            lblModel.Text = JsonConvert.DeserializeObject(f)(cboDefaultScheme.Text.ToString)("Model").ToString()
            lblSupportHours.Text = JsonConvert.DeserializeObject(f)(cboDefaultScheme.Text.ToString)("SupportHours").ToString()
            lblSupportPhone.Text = JsonConvert.DeserializeObject(f)(cboDefaultScheme.Text.ToString)("SupportPhone").ToString()
            lblSupportUrl.Text = JsonConvert.DeserializeObject(f)(cboDefaultScheme.Text.ToString)("SupportURL").ToString()

            txtManufacturer.Text = JsonConvert.DeserializeObject(f)(cboDefaultScheme.Text.ToString)("Manufacturer").ToString()
            txtModel.Text = JsonConvert.DeserializeObject(f)(cboDefaultScheme.Text.ToString)("Model").ToString()
            txtSupportHours.Text = JsonConvert.DeserializeObject(f)(cboDefaultScheme.Text.ToString)("SupportHours").ToString()
            txtSupportPhone.Text = JsonConvert.DeserializeObject(f)(cboDefaultScheme.Text.ToString)("SupportPhone").ToString()
            txtSupportUrl.Text = JsonConvert.DeserializeObject(f)(cboDefaultScheme.Text.ToString)("SupportURL").ToString()

            Me.pnlLogo.BackgroundImage = Bitmap.FromFile(My.Application.Info.DirectoryPath & JsonConvert.DeserializeObject(f)(cboDefaultScheme.Text.ToString)("Logo").ToString())

            grpSecond.Text = "当前所设置中的OEM信息预览"

        Catch ex As System.IO.FileNotFoundException
            MsgBox(e.ToString)
        Catch ex As Newtonsoft.Json.JsonReaderException
            MsgBox(e.ToString)
        End Try
        '  MsgBox(f)

        '  While JsonConvert.DeserializeObject(f)("惠普").ToString()

        '    Console.WriteLine(JsonConvert.DeserializeObject(f)("厂家").ToString())
        '  End While

        '   Console.WriteLine(JsonConvert.DeserializeObject(f)("惠普")("Model").ToString())


        ' Console.WriteLine(JsonConvert.DeserializeObject(f)("惠普")("Model").ToString())
        '    Dim reader = New JsonTextReader(New StringReader（f）)
        '   While reader.Read
        ' Console.WriteLine(reader.Depth)
        ' End While
        ''  Dim is1 = JsonConvert.DeserializeObject(JsonConvert.SerializeObject(reader))("惠普")("Model").ToString()

        ''   Console.Write(is1)

    End Sub

    Private Sub ParseCommandLineArgs()
        Dim inputArgument As String = "/input="
        Dim inputName As String = String.Empty

        For Each s As String In My.Application.CommandLineArgs
            If s.ToLower.StartsWith(inputArgument) Then
                inputName = s.Remove(0, inputArgument.Length)
            End If
        Next

        If inputName = Nothing Then
            MsgBox("No input name")
        Else
            MsgBox("Input name: " & inputName)
        End If
    End Sub
End Class
