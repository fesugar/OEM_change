<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits MetroFramework.Forms.MetroForm
    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.grpFirst = New System.Windows.Forms.GroupBox()
        Me.btnOk = New MetroFramework.Controls.MetroButton()
        Me.btnLogo = New MetroFramework.Controls.MetroButton()
        Me.btnReset = New MetroFramework.Controls.MetroButton()
        Me.btnClear = New MetroFramework.Controls.MetroButton()
        Me.tctlInfo = New MetroFramework.Controls.MetroTabControl()
        Me.tbpgOne = New MetroFramework.Controls.MetroTabPage()
        Me.lblDefaultScheme = New MetroFramework.Controls.MetroLabel()
        Me.cboDefaultScheme = New MetroFramework.Controls.MetroComboBox()
        Me.tbpgTwo = New MetroFramework.Controls.MetroTabPage()
        Me.txtSupportUrl = New MetroFramework.Controls.MetroTextBox()
        Me.txtSupportHours = New MetroFramework.Controls.MetroTextBox()
        Me.txtSupportPhone = New MetroFramework.Controls.MetroTextBox()
        Me.lblManufacturerFirst = New MetroFramework.Controls.MetroLabel()
        Me.txtModel = New MetroFramework.Controls.MetroTextBox()
        Me.txtManufacturer = New MetroFramework.Controls.MetroTextBox()
        Me.lblSupportUrlFirst = New MetroFramework.Controls.MetroLabel()
        Me.lblSupportHoursFirst = New MetroFramework.Controls.MetroLabel()
        Me.lblSupportPhoneFirst = New MetroFramework.Controls.MetroLabel()
        Me.lblModelFirst = New MetroFramework.Controls.MetroLabel()
        Me.grpSecond = New System.Windows.Forms.GroupBox()
        Me.pnlLogo = New MetroFramework.Controls.MetroPanel()
        Me.lblSupportUrl = New MetroFramework.Controls.MetroLink()
        Me.lblSupportHours = New MetroFramework.Controls.MetroLabel()
        Me.lblSupportPhone = New MetroFramework.Controls.MetroLabel()
        Me.lblModel = New MetroFramework.Controls.MetroLabel()
        Me.lblManufacturer = New MetroFramework.Controls.MetroLabel()
        Me.lblSupportUrlSecond = New MetroFramework.Controls.MetroLabel()
        Me.lblSupportHoursSecond = New MetroFramework.Controls.MetroLabel()
        Me.lblSupportPhoneSecond = New MetroFramework.Controls.MetroLabel()
        Me.lblModelSecond = New MetroFramework.Controls.MetroLabel()
        Me.lblManufacturerSecond = New MetroFramework.Controls.MetroLabel()
        Me.lblSupport = New MetroFramework.Controls.MetroLabel()
        Me.lblSystem = New MetroFramework.Controls.MetroLabel()
        Me.lblCurrentSystem = New MetroFramework.Controls.MetroLabel()
        Me.tipFirst = New MetroFramework.Components.MetroToolTip()
        Me.grpFirst.SuspendLayout()
        Me.tctlInfo.SuspendLayout()
        Me.tbpgOne.SuspendLayout()
        Me.tbpgTwo.SuspendLayout()
        Me.grpSecond.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpFirst
        '
        Me.grpFirst.Controls.Add(Me.btnOk)
        Me.grpFirst.Controls.Add(Me.btnLogo)
        Me.grpFirst.Controls.Add(Me.btnReset)
        Me.grpFirst.Controls.Add(Me.btnClear)
        Me.grpFirst.Controls.Add(Me.tctlInfo)
        Me.grpFirst.Location = New System.Drawing.Point(15, 73)
        Me.grpFirst.Name = "grpFirst"
        Me.grpFirst.Size = New System.Drawing.Size(426, 249)
        Me.grpFirst.TabIndex = 0
        Me.grpFirst.TabStop = False
        Me.grpFirst.Text = "信息修改"
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(364, 191)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(53, 25)
        Me.btnOk.TabIndex = 9
        Me.btnOk.Text = "修改"
        Me.btnOk.UseSelectable = True
        '
        'btnLogo
        '
        Me.btnLogo.Location = New System.Drawing.Point(364, 156)
        Me.btnLogo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogo.Name = "btnLogo"
        Me.btnLogo.Size = New System.Drawing.Size(53, 25)
        Me.btnLogo.TabIndex = 8
        Me.btnLogo.Text = "图标"
        Me.btnLogo.UseSelectable = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(364, 121)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(53, 25)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "默认"
        Me.btnReset.UseSelectable = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(364, 86)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(53, 25)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "清空"
        Me.btnClear.UseSelectable = True
        '
        'tctlInfo
        '
        Me.tctlInfo.Controls.Add(Me.tbpgOne)
        Me.tctlInfo.Controls.Add(Me.tbpgTwo)
        Me.tctlInfo.Location = New System.Drawing.Point(8, 24)
        Me.tctlInfo.Name = "tctlInfo"
        Me.tctlInfo.SelectedIndex = 0
        Me.tctlInfo.Size = New System.Drawing.Size(346, 210)
        Me.tctlInfo.TabIndex = 0
        Me.tctlInfo.UseSelectable = True
        '
        'tbpgOne
        '
        Me.tbpgOne.Controls.Add(Me.lblDefaultScheme)
        Me.tbpgOne.Controls.Add(Me.cboDefaultScheme)
        Me.tbpgOne.HorizontalScrollbarBarColor = True
        Me.tbpgOne.HorizontalScrollbarHighlightOnWheel = False
        Me.tbpgOne.HorizontalScrollbarSize = 10
        Me.tbpgOne.Location = New System.Drawing.Point(4, 38)
        Me.tbpgOne.Name = "tbpgOne"
        Me.tbpgOne.Size = New System.Drawing.Size(338, 168)
        Me.tbpgOne.TabIndex = 0
        Me.tbpgOne.Text = "默认方案"
        Me.tbpgOne.VerticalScrollbarBarColor = True
        Me.tbpgOne.VerticalScrollbarHighlightOnWheel = False
        Me.tbpgOne.VerticalScrollbarSize = 10
        '
        'lblDefaultScheme
        '
        Me.lblDefaultScheme.AutoSize = True
        Me.lblDefaultScheme.Location = New System.Drawing.Point(23, 46)
        Me.lblDefaultScheme.Name = "lblDefaultScheme"
        Me.lblDefaultScheme.Size = New System.Drawing.Size(134, 20)
        Me.lblDefaultScheme.TabIndex = 3
        Me.lblDefaultScheme.Text = "~请选择默认方案~"
        '
        'cboDefaultScheme
        '
        Me.cboDefaultScheme.FormattingEnabled = True
        Me.cboDefaultScheme.ItemHeight = 24
        Me.cboDefaultScheme.Location = New System.Drawing.Point(23, 79)
        Me.cboDefaultScheme.Name = "cboDefaultScheme"
        Me.cboDefaultScheme.Size = New System.Drawing.Size(203, 30)
        Me.cboDefaultScheme.TabIndex = 2
        Me.cboDefaultScheme.UseSelectable = True
        '
        'tbpgTwo
        '
        Me.tbpgTwo.Controls.Add(Me.txtSupportUrl)
        Me.tbpgTwo.Controls.Add(Me.txtSupportHours)
        Me.tbpgTwo.Controls.Add(Me.txtSupportPhone)
        Me.tbpgTwo.Controls.Add(Me.lblManufacturerFirst)
        Me.tbpgTwo.Controls.Add(Me.txtModel)
        Me.tbpgTwo.Controls.Add(Me.txtManufacturer)
        Me.tbpgTwo.Controls.Add(Me.lblSupportUrlFirst)
        Me.tbpgTwo.Controls.Add(Me.lblSupportHoursFirst)
        Me.tbpgTwo.Controls.Add(Me.lblSupportPhoneFirst)
        Me.tbpgTwo.Controls.Add(Me.lblModelFirst)
        Me.tbpgTwo.HorizontalScrollbarBarColor = True
        Me.tbpgTwo.HorizontalScrollbarHighlightOnWheel = False
        Me.tbpgTwo.HorizontalScrollbarSize = 10
        Me.tbpgTwo.Location = New System.Drawing.Point(4, 38)
        Me.tbpgTwo.Name = "tbpgTwo"
        Me.tbpgTwo.Size = New System.Drawing.Size(338, 168)
        Me.tbpgTwo.TabIndex = 1
        Me.tbpgTwo.Text = "自定义"
        Me.tbpgTwo.VerticalScrollbarBarColor = True
        Me.tbpgTwo.VerticalScrollbarHighlightOnWheel = False
        Me.tbpgTwo.VerticalScrollbarSize = 10
        '
        'txtSupportUrl
        '
        '
        '
        '
        Me.txtSupportUrl.CustomButton.Image = Nothing
        Me.txtSupportUrl.CustomButton.Location = New System.Drawing.Point(137, 1)
        Me.txtSupportUrl.CustomButton.Name = ""
        Me.txtSupportUrl.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txtSupportUrl.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSupportUrl.CustomButton.TabIndex = 1
        Me.txtSupportUrl.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSupportUrl.CustomButton.UseSelectable = True
        Me.txtSupportUrl.CustomButton.Visible = False
        Me.txtSupportUrl.Lines = New String(-1) {}
        Me.txtSupportUrl.Location = New System.Drawing.Point(132, 133)
        Me.txtSupportUrl.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSupportUrl.MaxLength = 32767
        Me.txtSupportUrl.Name = "txtSupportUrl"
        Me.txtSupportUrl.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSupportUrl.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSupportUrl.SelectedText = ""
        Me.txtSupportUrl.SelectionLength = 0
        Me.txtSupportUrl.SelectionStart = 0
        Me.txtSupportUrl.ShortcutsEnabled = True
        Me.txtSupportUrl.Size = New System.Drawing.Size(161, 25)
        Me.txtSupportUrl.TabIndex = 19
        Me.txtSupportUrl.UseSelectable = True
        Me.txtSupportUrl.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSupportUrl.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtSupportHours
        '
        '
        '
        '
        Me.txtSupportHours.CustomButton.Image = Nothing
        Me.txtSupportHours.CustomButton.Location = New System.Drawing.Point(137, 1)
        Me.txtSupportHours.CustomButton.Name = ""
        Me.txtSupportHours.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txtSupportHours.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSupportHours.CustomButton.TabIndex = 1
        Me.txtSupportHours.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSupportHours.CustomButton.UseSelectable = True
        Me.txtSupportHours.CustomButton.Visible = False
        Me.txtSupportHours.Lines = New String(-1) {}
        Me.txtSupportHours.Location = New System.Drawing.Point(132, 104)
        Me.txtSupportHours.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSupportHours.MaxLength = 32767
        Me.txtSupportHours.Name = "txtSupportHours"
        Me.txtSupportHours.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSupportHours.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSupportHours.SelectedText = ""
        Me.txtSupportHours.SelectionLength = 0
        Me.txtSupportHours.SelectionStart = 0
        Me.txtSupportHours.ShortcutsEnabled = True
        Me.txtSupportHours.Size = New System.Drawing.Size(161, 25)
        Me.txtSupportHours.TabIndex = 18
        Me.txtSupportHours.UseSelectable = True
        Me.txtSupportHours.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSupportHours.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtSupportPhone
        '
        '
        '
        '
        Me.txtSupportPhone.CustomButton.Image = Nothing
        Me.txtSupportPhone.CustomButton.Location = New System.Drawing.Point(137, 1)
        Me.txtSupportPhone.CustomButton.Name = ""
        Me.txtSupportPhone.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txtSupportPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSupportPhone.CustomButton.TabIndex = 1
        Me.txtSupportPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSupportPhone.CustomButton.UseSelectable = True
        Me.txtSupportPhone.CustomButton.Visible = False
        Me.txtSupportPhone.Lines = New String(-1) {}
        Me.txtSupportPhone.Location = New System.Drawing.Point(132, 74)
        Me.txtSupportPhone.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSupportPhone.MaxLength = 32767
        Me.txtSupportPhone.Name = "txtSupportPhone"
        Me.txtSupportPhone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSupportPhone.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSupportPhone.SelectedText = ""
        Me.txtSupportPhone.SelectionLength = 0
        Me.txtSupportPhone.SelectionStart = 0
        Me.txtSupportPhone.ShortcutsEnabled = True
        Me.txtSupportPhone.Size = New System.Drawing.Size(161, 25)
        Me.txtSupportPhone.TabIndex = 17
        Me.txtSupportPhone.UseSelectable = True
        Me.txtSupportPhone.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSupportPhone.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblManufacturerFirst
        '
        Me.lblManufacturerFirst.AutoSize = True
        Me.lblManufacturerFirst.Location = New System.Drawing.Point(44, 14)
        Me.lblManufacturerFirst.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManufacturerFirst.Name = "lblManufacturerFirst"
        Me.lblManufacturerFirst.Size = New System.Drawing.Size(69, 20)
        Me.lblManufacturerFirst.TabIndex = 10
        Me.lblManufacturerFirst.Text = "制造商："
        '
        'txtModel
        '
        '
        '
        '
        Me.txtModel.CustomButton.Image = Nothing
        Me.txtModel.CustomButton.Location = New System.Drawing.Point(137, 1)
        Me.txtModel.CustomButton.Name = ""
        Me.txtModel.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txtModel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtModel.CustomButton.TabIndex = 1
        Me.txtModel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtModel.CustomButton.UseSelectable = True
        Me.txtModel.CustomButton.Visible = False
        Me.txtModel.Lines = New String(-1) {}
        Me.txtModel.Location = New System.Drawing.Point(132, 44)
        Me.txtModel.Margin = New System.Windows.Forms.Padding(4)
        Me.txtModel.MaxLength = 32767
        Me.txtModel.Name = "txtModel"
        Me.txtModel.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtModel.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtModel.SelectedText = ""
        Me.txtModel.SelectionLength = 0
        Me.txtModel.SelectionStart = 0
        Me.txtModel.ShortcutsEnabled = True
        Me.txtModel.Size = New System.Drawing.Size(161, 25)
        Me.txtModel.TabIndex = 16
        Me.txtModel.UseSelectable = True
        Me.txtModel.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtModel.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtManufacturer
        '
        '
        '
        '
        Me.txtManufacturer.CustomButton.Image = Nothing
        Me.txtManufacturer.CustomButton.Location = New System.Drawing.Point(137, 1)
        Me.txtManufacturer.CustomButton.Name = ""
        Me.txtManufacturer.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txtManufacturer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtManufacturer.CustomButton.TabIndex = 1
        Me.txtManufacturer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtManufacturer.CustomButton.UseSelectable = True
        Me.txtManufacturer.CustomButton.Visible = False
        Me.txtManufacturer.Lines = New String(-1) {}
        Me.txtManufacturer.Location = New System.Drawing.Point(132, 14)
        Me.txtManufacturer.Margin = New System.Windows.Forms.Padding(4)
        Me.txtManufacturer.MaxLength = 32767
        Me.txtManufacturer.Name = "txtManufacturer"
        Me.txtManufacturer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtManufacturer.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtManufacturer.SelectedText = ""
        Me.txtManufacturer.SelectionLength = 0
        Me.txtManufacturer.SelectionStart = 0
        Me.txtManufacturer.ShortcutsEnabled = True
        Me.txtManufacturer.Size = New System.Drawing.Size(161, 25)
        Me.txtManufacturer.TabIndex = 15
        Me.txtManufacturer.UseSelectable = True
        Me.txtManufacturer.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtManufacturer.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblSupportUrlFirst
        '
        Me.lblSupportUrlFirst.AutoSize = True
        Me.lblSupportUrlFirst.Location = New System.Drawing.Point(59, 134)
        Me.lblSupportUrlFirst.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSupportUrlFirst.Name = "lblSupportUrlFirst"
        Me.lblSupportUrlFirst.Size = New System.Drawing.Size(54, 20)
        Me.lblSupportUrlFirst.TabIndex = 14
        Me.lblSupportUrlFirst.Text = "网站："
        '
        'lblSupportHoursFirst
        '
        Me.lblSupportHoursFirst.AutoSize = True
        Me.lblSupportHoursFirst.Location = New System.Drawing.Point(14, 109)
        Me.lblSupportHoursFirst.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSupportHoursFirst.Name = "lblSupportHoursFirst"
        Me.lblSupportHoursFirst.Size = New System.Drawing.Size(99, 20)
        Me.lblSupportHoursFirst.TabIndex = 13
        Me.lblSupportHoursFirst.Text = "支持小时数："
        '
        'lblSupportPhoneFirst
        '
        Me.lblSupportPhoneFirst.AutoSize = True
        Me.lblSupportPhoneFirst.Location = New System.Drawing.Point(29, 79)
        Me.lblSupportPhoneFirst.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSupportPhoneFirst.Name = "lblSupportPhoneFirst"
        Me.lblSupportPhoneFirst.Size = New System.Drawing.Size(84, 20)
        Me.lblSupportPhoneFirst.TabIndex = 12
        Me.lblSupportPhoneFirst.Text = "电话号码："
        '
        'lblModelFirst
        '
        Me.lblModelFirst.AutoSize = True
        Me.lblModelFirst.Location = New System.Drawing.Point(59, 49)
        Me.lblModelFirst.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblModelFirst.Name = "lblModelFirst"
        Me.lblModelFirst.Size = New System.Drawing.Size(54, 20)
        Me.lblModelFirst.TabIndex = 11
        Me.lblModelFirst.Text = "型号："
        '
        'grpSecond
        '
        Me.grpSecond.Controls.Add(Me.pnlLogo)
        Me.grpSecond.Controls.Add(Me.lblSupportUrl)
        Me.grpSecond.Controls.Add(Me.lblSupportHours)
        Me.grpSecond.Controls.Add(Me.lblSupportPhone)
        Me.grpSecond.Controls.Add(Me.lblModel)
        Me.grpSecond.Controls.Add(Me.lblManufacturer)
        Me.grpSecond.Controls.Add(Me.lblSupportUrlSecond)
        Me.grpSecond.Controls.Add(Me.lblSupportHoursSecond)
        Me.grpSecond.Controls.Add(Me.lblSupportPhoneSecond)
        Me.grpSecond.Controls.Add(Me.lblModelSecond)
        Me.grpSecond.Controls.Add(Me.lblManufacturerSecond)
        Me.grpSecond.Controls.Add(Me.lblSupport)
        Me.grpSecond.Controls.Add(Me.lblSystem)
        Me.grpSecond.Location = New System.Drawing.Point(15, 328)
        Me.grpSecond.Name = "grpSecond"
        Me.grpSecond.Size = New System.Drawing.Size(426, 219)
        Me.grpSecond.TabIndex = 1
        Me.grpSecond.TabStop = False
        Me.grpSecond.Text = "当前系统OEM信息"
        '
        'pnlLogo
        '
        Me.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlLogo.HorizontalScrollbarBarColor = True
        Me.pnlLogo.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlLogo.HorizontalScrollbarSize = 10
        Me.pnlLogo.Location = New System.Drawing.Point(300, 61)
        Me.pnlLogo.Name = "pnlLogo"
        Me.pnlLogo.Size = New System.Drawing.Size(120, 110)
        Me.pnlLogo.TabIndex = 25
        Me.pnlLogo.VerticalScrollbarBarColor = True
        Me.pnlLogo.VerticalScrollbarHighlightOnWheel = False
        Me.pnlLogo.VerticalScrollbarSize = 10
        '
        'lblSupportUrl
        '
        Me.lblSupportUrl.AutoSize = True
        Me.lblSupportUrl.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.lblSupportUrl.Location = New System.Drawing.Point(130, 187)
        Me.lblSupportUrl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSupportUrl.Name = "lblSupportUrl"
        Me.lblSupportUrl.Size = New System.Drawing.Size(6, 6)
        Me.lblSupportUrl.TabIndex = 24
        Me.lblSupportUrl.UseSelectable = True
        '
        'lblSupportHours
        '
        Me.lblSupportHours.AutoSize = True
        Me.lblSupportHours.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.lblSupportHours.Location = New System.Drawing.Point(130, 161)
        Me.lblSupportHours.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSupportHours.Name = "lblSupportHours"
        Me.lblSupportHours.Size = New System.Drawing.Size(0, 0)
        Me.lblSupportHours.TabIndex = 23
        '
        'lblSupportPhone
        '
        Me.lblSupportPhone.AutoSize = True
        Me.lblSupportPhone.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.lblSupportPhone.Location = New System.Drawing.Point(130, 137)
        Me.lblSupportPhone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSupportPhone.Name = "lblSupportPhone"
        Me.lblSupportPhone.Size = New System.Drawing.Size(0, 0)
        Me.lblSupportPhone.TabIndex = 22
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.lblModel.Location = New System.Drawing.Point(130, 85)
        Me.lblModel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(0, 0)
        Me.lblModel.TabIndex = 21
        '
        'lblManufacturer
        '
        Me.lblManufacturer.AutoSize = True
        Me.lblManufacturer.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.lblManufacturer.Location = New System.Drawing.Point(130, 54)
        Me.lblManufacturer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManufacturer.Name = "lblManufacturer"
        Me.lblManufacturer.Size = New System.Drawing.Size(0, 0)
        Me.lblManufacturer.TabIndex = 20
        '
        'lblSupportUrlSecond
        '
        Me.lblSupportUrlSecond.AutoSize = True
        Me.lblSupportUrlSecond.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblSupportUrlSecond.Location = New System.Drawing.Point(64, 187)
        Me.lblSupportUrlSecond.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSupportUrlSecond.Name = "lblSupportUrlSecond"
        Me.lblSupportUrlSecond.Size = New System.Drawing.Size(54, 20)
        Me.lblSupportUrlSecond.TabIndex = 19
        Me.lblSupportUrlSecond.Text = "网站："
        '
        'lblSupportHoursSecond
        '
        Me.lblSupportHoursSecond.AutoSize = True
        Me.lblSupportHoursSecond.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblSupportHoursSecond.Location = New System.Drawing.Point(19, 161)
        Me.lblSupportHoursSecond.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSupportHoursSecond.Name = "lblSupportHoursSecond"
        Me.lblSupportHoursSecond.Size = New System.Drawing.Size(99, 20)
        Me.lblSupportHoursSecond.TabIndex = 18
        Me.lblSupportHoursSecond.Text = "支持小时数："
        '
        'lblSupportPhoneSecond
        '
        Me.lblSupportPhoneSecond.AutoSize = True
        Me.lblSupportPhoneSecond.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblSupportPhoneSecond.Location = New System.Drawing.Point(35, 137)
        Me.lblSupportPhoneSecond.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSupportPhoneSecond.Name = "lblSupportPhoneSecond"
        Me.lblSupportPhoneSecond.Size = New System.Drawing.Size(84, 20)
        Me.lblSupportPhoneSecond.TabIndex = 17
        Me.lblSupportPhoneSecond.Text = "电话号码："
        '
        'lblModelSecond
        '
        Me.lblModelSecond.AutoSize = True
        Me.lblModelSecond.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblModelSecond.Location = New System.Drawing.Point(64, 85)
        Me.lblModelSecond.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblModelSecond.Name = "lblModelSecond"
        Me.lblModelSecond.Size = New System.Drawing.Size(54, 20)
        Me.lblModelSecond.TabIndex = 16
        Me.lblModelSecond.Text = "型号："
        '
        'lblManufacturerSecond
        '
        Me.lblManufacturerSecond.AutoSize = True
        Me.lblManufacturerSecond.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblManufacturerSecond.Location = New System.Drawing.Point(49, 54)
        Me.lblManufacturerSecond.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManufacturerSecond.Name = "lblManufacturerSecond"
        Me.lblManufacturerSecond.Size = New System.Drawing.Size(69, 20)
        Me.lblManufacturerSecond.TabIndex = 15
        Me.lblManufacturerSecond.Text = "制造商："
        '
        'lblSupport
        '
        Me.lblSupport.AutoSize = True
        Me.lblSupport.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblSupport.Location = New System.Drawing.Point(18, 107)
        Me.lblSupport.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSupport.Name = "lblSupport"
        Me.lblSupport.Size = New System.Drawing.Size(99, 20)
        Me.lblSupport.TabIndex = 14
        Me.lblSupport.Text = "支持————"
        '
        'lblSystem
        '
        Me.lblSystem.AutoSize = True
        Me.lblSystem.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblSystem.Location = New System.Drawing.Point(18, 27)
        Me.lblSystem.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSystem.Name = "lblSystem"
        Me.lblSystem.Size = New System.Drawing.Size(99, 20)
        Me.lblSystem.TabIndex = 13
        Me.lblSystem.Text = "系统————"
        '
        'lblCurrentSystem
        '
        Me.lblCurrentSystem.AutoSize = True
        Me.lblCurrentSystem.Location = New System.Drawing.Point(15, 550)
        Me.lblCurrentSystem.Name = "lblCurrentSystem"
        Me.lblCurrentSystem.Size = New System.Drawing.Size(84, 20)
        Me.lblCurrentSystem.TabIndex = 2
        Me.lblCurrentSystem.Text = "当前系统："
        '
        'tipFirst
        '
        Me.tipFirst.Style = MetroFramework.MetroColorStyle.Blue
        Me.tipFirst.StyleManager = Nothing
        Me.tipFirst.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 577)
        Me.Controls.Add(Me.lblCurrentSystem)
        Me.Controls.Add(Me.grpSecond)
        Me.Controls.Add(Me.grpFirst)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormMain"
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "OEM  信息更改工具"
        Me.grpFirst.ResumeLayout(False)
        Me.tctlInfo.ResumeLayout(False)
        Me.tbpgOne.ResumeLayout(False)
        Me.tbpgOne.PerformLayout()
        Me.tbpgTwo.ResumeLayout(False)
        Me.tbpgTwo.PerformLayout()
        Me.grpSecond.ResumeLayout(False)
        Me.grpSecond.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpFirst As GroupBox
    Friend WithEvents grpSecond As GroupBox
    Friend WithEvents lblCurrentSystem As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnOk As MetroFramework.Controls.MetroButton
    Friend WithEvents btnLogo As MetroFramework.Controls.MetroButton
    Friend WithEvents btnReset As MetroFramework.Controls.MetroButton
    Friend WithEvents btnClear As MetroFramework.Controls.MetroButton
    Friend WithEvents tctlInfo As MetroFramework.Controls.MetroTabControl
    Friend WithEvents tbpgOne As MetroFramework.Controls.MetroTabPage
    Friend WithEvents cboDefaultScheme As MetroFramework.Controls.MetroComboBox
    Friend WithEvents tbpgTwo As MetroFramework.Controls.MetroTabPage
    Friend WithEvents txtSupportUrl As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtSupportHours As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtSupportPhone As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtModel As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtManufacturer As MetroFramework.Controls.MetroTextBox
    Friend WithEvents pnlLogo As MetroFramework.Controls.MetroPanel
    Friend WithEvents lblSupportUrl As MetroFramework.Controls.MetroLink
    Friend WithEvents lblSupportHours As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblSupportPhone As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblModel As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblManufacturer As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblManufacturerFirst As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblSupportUrlFirst As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblSupportHoursFirst As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblSupportPhoneFirst As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblModelFirst As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblSupportUrlSecond As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblSupportHoursSecond As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblSupportPhoneSecond As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblModelSecond As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblManufacturerSecond As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblSupport As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblSystem As MetroFramework.Controls.MetroLabel
    Friend WithEvents tipFirst As MetroFramework.Components.MetroToolTip
    Friend WithEvents lblDefaultScheme As MetroFramework.Controls.MetroLabel
End Class
