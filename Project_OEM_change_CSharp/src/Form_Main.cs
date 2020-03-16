#region << 版 本 注 释 >>
/*----------------------------------------------------------------
* 项目名称 ：OEMchange
* 项目描述 ：OEM_change for CSharp
* 类 名 称 ：FormMain
* 类 描 述 ：主窗体
* 命名空间 ：OEMchange
* CLR 版本 ：4.0
* 作    者 ：fesugar
* 邮    箱 ：fesugar@fesugar.com
* 创建时间 ：12:42 2020/3/16
* 更新时间 ：12:42 2020/3/16
* 版 本 号 ：v1.0.0.0
* 参考文献 ：
*******************************************************************
* Copyright @ fesugar 2020. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/
#endregion

using Microsoft.VisualBasic; //导入VB命名空间使用已有功能操作
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using OEMchange.My;
using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace OEMchange
{
    /// <summary>
    /// 主窗体
    /// </summary>
    public partial class FormMain : MetroFramework.Forms.MetroForm
    {

        /* 设置系统messagebox 位置  START*/
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        static extern IntPtr FindWindow(IntPtr classname, string title); // extern method: FindWindow

        [DllImport("user32.dll")]
        static extern void MoveWindow(IntPtr hwnd, int X, int Y, int nWidth, int nHeight, bool rePaint); // extern method: MoveWindow

        [DllImport("user32.dll")]
        static extern bool GetWindowRect(IntPtr hwnd, out Rectangle rect); // extern method: GetWindowRect
        /// <summary>
        /// 寻找 MSGBOX 窗口重新定位
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="repaint"></param>
        /// <param name="title"></param>
        public static void FindAndMoveMsgBox(int x, int y, bool repaint, string title)
        {
            Thread thr = new Thread(() => // create a new thread
            {
                IntPtr msgBox = IntPtr.Zero;
                // while there's no MessageBox, FindWindow returns IntPtr.Zero
                while ((msgBox = FindWindow(IntPtr.Zero, title)) == IntPtr.Zero) ;
                // after the while loop, msgBox is the handle of your MessageBox
                Rectangle r = new Rectangle();
                GetWindowRect(msgBox, out r); // Gets the rectangle of the message box
                MoveWindow(msgBox /* handle of the message box */, x, y,
                  r.Width - r.X /* width of originally message box */,
                  r.Height - r.Y /* height of originally message box */,
                  repaint /* if true, the message box repaints */);
            });
            thr.Start(); // starts the thread
        }
        /* 设置系统messagebox 位置  END*/

        public FormMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 清空按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            this.tctlInfo.SelectedIndex = 1;
            this.txtManufacturer.Clear();
            this.txtModel.Clear();
            this.txtSupportHours.Clear();
            this.txtSupportPhone.Clear();
            this.txtSupportUrl.Clear();
            this.pnlLogo.BackgroundImage = null;
            this.GetINFO();
        }
        /// <summary>
        /// 获取注册表记录
        /// </summary>
        private void GetINFO()
        {
            try
            {
                object read_Manufacturer_Value = RuntimeHelpers.GetObjectValue(MyProject.Computer.Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation", "Manufacturer", null));
                object read_Model_Value = RuntimeHelpers.GetObjectValue(MyProject.Computer.Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation", "Model", null));
                object read_SupportHours_Value = RuntimeHelpers.GetObjectValue(MyProject.Computer.Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation", "SupportHours", null));
                object read_SupportPhone_Value = RuntimeHelpers.GetObjectValue(MyProject.Computer.Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation", "SupportPhone", null));
                object read_SupportURL_Value = RuntimeHelpers.GetObjectValue(MyProject.Computer.Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation", "SupportURL", null));
                object read_Logo_Value = RuntimeHelpers.GetObjectValue(MyProject.Computer.Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation", "Logo", null));
                //获取注册表相关的值并显示
                lblManufacturer.Text = Conversions.ToString(read_Manufacturer_Value);
                lblModel.Text = Conversions.ToString(read_Model_Value);
                lblSupportHours.Text = Conversions.ToString(read_SupportHours_Value);
                lblSupportPhone.Text = Conversions.ToString(read_SupportPhone_Value);
                lblSupportUrl.Text = Conversions.ToString(read_SupportURL_Value);
                this.pnlLogo.BackgroundImage = Bitmap.FromFile(Conversions.ToString(read_Logo_Value));
                grpSecond.Text = IniRead("grpSecond1", "Text", "当前系统中OEM信息预览");
            }
            catch (Exception ex) when (ex.GetType() == typeof(FileNotFoundException))
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// 重置按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            this.tctlInfo.SelectedIndex = 1;
            Interaction.Shell("cmd.exe /c wmic /output:tmp BASEBOARD get Manufacturer ", AppWinStyle.Hide, true, 0xbb8);
            this.txtManufacturer.Text = File.ReadAllText("tmp");
            Interaction.Shell("cmd.exe /c wmic /output:tmp BASEBOARD get Model ", AppWinStyle.Hide, true, 0xbb8);
            this.txtModel.Text = File.ReadAllText("tmp");
            this.txtSupportHours.Text = Conversions.ToString("SupportHours");
            this.txtSupportPhone.Text = Conversions.ToString("SupportPhone");
            this.txtSupportUrl.Text = Conversions.ToString("SupportURL");
        }
        /// <summary>
        /// 图标按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Logo_Click(object sender, EventArgs e)
        {
            FormLogo flogo = new FormLogo
            {
                Left = base.Left + 20,
                Top = base.Top + 0x23
            };
            flogo.picLogo.Image = this.pnlLogo.BackgroundImage;
            flogo.Opacity = 93.0;
            flogo.ShowDialog();
            flogo.Dispose();
        }
        /// <summary>
        /// 修改按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            FindAndMoveMsgBox(this.Location.X + this.Width / 6, this.Location.Y + this.Height / 3, true, IniRead("msgbox1", "Title", "是否更改"));
            if (MessageBox.Show(IniRead("msgbox1", "Text", "您确认继续操作更改吗？"), IniRead("msgbox1", "Title", "是否更改"), MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2) != DialogResult.No)
            {
                Interaction.Shell(@"cmd.exe /c REG SAVE HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation bk /y", AppWinStyle.Hide, true, 0xbb8);
                try
                {
                    MyProject.Computer.Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation", "Manufacturer", this.txtManufacturer.Text);
                    MyProject.Computer.Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation", "Model", this.txtModel.Text);
                    MyProject.Computer.Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation", "SupportPhone", this.txtSupportPhone.Text);
                    MyProject.Computer.Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation", "SupportHours", this.txtSupportHours.Text);
                    MyProject.Computer.Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation", "SupportURL", this.txtSupportUrl.Text);
                    string str = Guid.NewGuid().ToString();
                    if (!Directory.Exists(Conversions.ToString(Environment.GetFolderPath(Environment.SpecialFolder.System)) + @"\oobe\info"))
                    {
                        Directory.CreateDirectory(Conversions.ToString(Environment.GetFolderPath(Environment.SpecialFolder.System)) + @"\oobe\info");
                    }
                    if (this.pnlLogo.BackgroundImage != null)
                    {
                        this.pnlLogo.BackgroundImage.Save(Conversions.ToString(Environment.GetFolderPath(Environment.SpecialFolder.System)) + @"\oobe\info\" + str + "_logo.bmp", ImageFormat.Bmp);
                    }
                    MyProject.Computer.Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation", "LOGO", Environment.GetFolderPath(Environment.SpecialFolder.System) + @"\oobe\info\" + str + "_logo.bmp");
                }
                catch (DirectoryNotFoundException exception1)
                {
                    ProjectData.SetProjectError(exception1);
                    Interaction.MsgBox(Conversion.ErrorToString(), MsgBoxStyle.ApplicationModal, null);
                    ProjectData.ClearProjectError();
                    return;
                }

                Interaction.Shell("cmd.exe /c control.exe system", AppWinStyle.MinimizedFocus, false, -1);
                this.GetINFO();
                FindAndMoveMsgBox(this.Location.X + this.Width / 6, this.Location.Y + this.Height / 3, true, IniRead("msgbox2", "Title", "对结果不满意"));
                if (MessageBox.Show(IniRead("msgbox2", "Text", "需要撤销对系统OEM信息的更改吗？"),IniRead("msgbox2", "Title", "对结果不满意"), MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1) != DialogResult.No)
                {
                    Interaction.Shell(@"cmd.exe /c REG RESTORE HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation bk", AppWinStyle.Hide, true, 0xbb8);
                    Interaction.Shell("cmd.exe /c control.exe system", AppWinStyle.MinimizedFocus, false, -1);
                    this.GetINFO();
                }
            }
        }
        /// <summary>
        /// 窗体载入时事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                this.MaximumSize = this.Size;
                this.MinimumSize = this.Size;
                this.GetINFO();
                this.StringInitialize();
                lblCurrentSystem.Text += My.MyProject.Computer.Info.OSFullName;
                XmlDocument doc = new XmlDocument();
                doc.Load(MyProject.Application.Info.DirectoryPath + @"\content.xml");
                XmlNode xmlNode = doc.SelectSingleNode("combox");
                IEnumerator enumerator = xmlNode.ChildNodes.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);

                    object[] arguments = new object[] { "ItemName" };
                    this.cboDefaultScheme.Items.Add(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Attributes", arguments, null, null, null), null, "value", new object[0], null, null, null)));
                }
            }
            catch (Exception ex) when (ex.GetType() != typeof(AggregateException))
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 初始化字符资源
        /// </summary>
        private void StringInitialize()
        {
            tipFirst.SetToolTip(tbpgOne, IniRead("tipfirst", "tbpgOne", "~已经设置好的一些OEM方案"));
            tipFirst.SetToolTip(tbpgTwo, IniRead("tipfirst", "tbpgTwo", "~自定义OEM信息"));
            tipFirst.SetToolTip(btnClear, IniRead("tipfirst", "btnClear", "~清空当前的设置信息"));
            tipFirst.SetToolTip(btnReset, IniRead("tipfirst", "btnReset", "~自动填写默认缺省值信息"));
            tipFirst.SetToolTip(btnLogo, IniRead("tipfirst", "btnLogo", "~单独设置logo图标信息"));
            tipFirst.SetToolTip(btnOk, IniRead("tipfirst", "btnOk", "~保存当前所设置的OEM信息"));
            tipFirst.SetToolTip(cboDefaultScheme, IniRead("tipfirst", "cboDefaultScheme", "~预设OEM方案选择"));
            tipFirst.SetToolTip(lblCurrentSystem, IniRead("tipfirst", "lblCurrentSystem", "~当前电脑运行的系统信息"));
            tipFirst.SetToolTip(pnlLogo, IniRead("tipfirst", "pnlLogo", "~所展示的logo图标"));
            this.Text = IniRead("FormMain", "Text", "OEM  信息更改工具");
            grpFirst.Text = IniRead("grpFirst", "Text", "信息修改");
            tbpgOne.Text = IniRead("tbpgOne", "Text", "默认方案");
            lblDefaultScheme.Text = IniRead("lblDefaultScheme", "Text", "~请选择默认方案~");
            tbpgTwo.Text = IniRead("tbpgTwo", "Text", "自定义"); ;
            lblManufacturerFirst.Text = IniRead("lblManufacturer", "Text", "制造商：");
            lblManufacturerSecond.Text = IniRead("lblManufacturer", "Text", "制造商：");
            lblModelFirst.Text = IniRead("lblModel", "Text", "型号：");
            lblModelSecond.Text = IniRead("lblModel", "Text", "型号：");
            lblSupportPhoneFirst.Text = IniRead("lblSupportPhone", "Text", "电话号码：");
            lblSupportPhoneSecond.Text = IniRead("lblSupportPhone", "Text", "电话号码：");
            lblSupportHoursFirst.Text = IniRead("lblSupportHours", "Text", "支持小时数：");
            lblSupportHoursSecond.Text = IniRead("lblSupportHours", "Text", "支持小时数：");
            lblSupportUrlFirst.Text = IniRead("lblSupportUrl", "Text", "网站：");
            lblSupportUrlSecond.Text = IniRead("lblSupportUrl", "Text", "网站：");
            btnClear.Text = IniRead("btnClear", "Text", "清空");
            btnReset.Text = IniRead("btnReset", "Text", "默认");
            btnLogo.Text = IniRead("btnLogo", "Text", "图标");
            btnOk.Text = IniRead("btnOk", "Text", "修改");
            grpSecond.Text = IniRead("grpSecond", "Text", "当前系统OEM信息");
            lblSystem.Text = IniRead("lblSystem", "Text", "系统————");
            lblSupport.Text = IniRead("lblSupport", "Text", "支持————");
            lblCurrentSystem.Text = IniRead("lblCurrentSystem", "Text", "当前系统：");
        }

        /// <summary>
        /// 预设品牌选项框按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MetroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                string f = File.OpenText(MyProject.Application.Info.DirectoryPath + @"\content.json").ReadToEnd();
                lblManufacturer.Text = ((Newtonsoft.Json.Linq.JObject)JsonConvert.DeserializeObject(f))[Conversions.ToString(cboDefaultScheme.Text)]["Manufacturer"].ToString();
                lblModel.Text = ((Newtonsoft.Json.Linq.JObject)JsonConvert.DeserializeObject(f))[Conversions.ToString(cboDefaultScheme.Text)]["Model"].ToString();
                lblSupportHours.Text = ((Newtonsoft.Json.Linq.JObject)JsonConvert.DeserializeObject(f))[Conversions.ToString(cboDefaultScheme.Text)]["SupportHours"].ToString();
                lblSupportPhone.Text = ((Newtonsoft.Json.Linq.JObject)JsonConvert.DeserializeObject(f))[Conversions.ToString(cboDefaultScheme.Text)]["SupportPhone"].ToString();
                lblSupportUrl.Text = ((Newtonsoft.Json.Linq.JObject)JsonConvert.DeserializeObject(f))[Conversions.ToString(cboDefaultScheme.Text)]["SupportURL"].ToString();
                txtManufacturer.Text = ((Newtonsoft.Json.Linq.JObject)JsonConvert.DeserializeObject(f))[Conversions.ToString(cboDefaultScheme.Text)]["Manufacturer"].ToString();
                txtModel.Text = ((Newtonsoft.Json.Linq.JObject)JsonConvert.DeserializeObject(f))[Conversions.ToString(cboDefaultScheme.Text)]["Model"].ToString();
                txtSupportHours.Text = ((Newtonsoft.Json.Linq.JObject)JsonConvert.DeserializeObject(f))[Conversions.ToString(cboDefaultScheme.Text)]["SupportHours"].ToString();
                txtSupportPhone.Text = ((Newtonsoft.Json.Linq.JObject)JsonConvert.DeserializeObject(f))[Conversions.ToString(cboDefaultScheme.Text)]["SupportPhone"].ToString();
                txtSupportUrl.Text = ((Newtonsoft.Json.Linq.JObject)JsonConvert.DeserializeObject(f))[Conversions.ToString(cboDefaultScheme.Text)]["SupportURL"].ToString();
                pnlLogo.BackgroundImage = Bitmap.FromFile(MyProject.Application.Info.DirectoryPath + ((Newtonsoft.Json.Linq.JObject)JsonConvert.DeserializeObject(f))[Conversions.ToString(cboDefaultScheme.Text)]["Logo"].ToString());
                grpSecond.Text = IniRead("grpSecond2", "Text", "当前所设置中的OEM信息预览");
            }
            catch (FileNotFoundException exception1)
            {
                ProjectData.SetProjectError(exception1);
                FileNotFoundException exception = exception1;
                Interaction.MsgBox(e.ToString(), MsgBoxStyle.ApplicationModal, null);
                ProjectData.ClearProjectError();
            }
            catch (JsonReaderException exception3)
            {
                ProjectData.SetProjectError(exception3);
                Interaction.MsgBox(e.ToString(), MsgBoxStyle.ApplicationModal, null);
                ProjectData.ClearProjectError();
            }

        }
        /// <summary>
        /// 读取 INI
        /// </summary>
        /// <param name="Section"></param>
        /// <param name="Value"></param>
        /// <returns></returns>
        public static string IniRead(string Section, string Value, string Give)
        {
            IniFiles iniFiles = new IniFiles(My.MyProject.Application.Info.DirectoryPath + @"\string.ini");
            return iniFiles.ReadString(Section, Value,Give);

        }

    }
}
