<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogo
    Inherits MetroFramework.Forms.MetroForm

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdd = New MetroFramework.Controls.MetroButton()
        Me.btnRemove = New MetroFramework.Controls.MetroButton()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picLogo
        '
        Me.picLogo.ImageLocation = ""
        Me.picLogo.Location = New System.Drawing.Point(13, 89)
        Me.picLogo.Margin = New System.Windows.Forms.Padding(4)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(144, 126)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 65)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(261, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "只允许 bmp(120*120)格式大小内图片"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(190, 93)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(84, 47)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "添/改图标"
        Me.btnAdd.UseSelectable = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(190, 161)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(84, 47)
        Me.btnRemove.TabIndex = 3
        Me.btnRemove.Text = "清空图标"
        Me.btnRemove.UseSelectable = True
        '
        'FormLogo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(301, 225)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picLogo)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(301, 225)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(301, 225)
        Me.Name = "FormLogo"
        Me.ShowIcon = False
        Me.Text = "logo"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As MetroFramework.Controls.MetroButton
    Friend WithEvents btnRemove As MetroFramework.Controls.MetroButton
End Class
