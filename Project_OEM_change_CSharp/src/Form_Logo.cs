﻿using Microsoft.VisualBasic.CompilerServices;
using OEMchange.My;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace OEMchange
{
    public partial class FormLogo : MetroFramework.Forms.MetroForm
    {
        public FormLogo()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 添加图标按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, System.EventArgs e)
        {
            //     using   OpenFileDialog dialog = new OpenFileDialog
            using (OpenFileDialog dialog = new OpenFileDialog
            {
                FileName = "oem",
                DefaultExt = ".bmp",
                Filter = "位图 |*.bmp",
                Title = "浏览文件"
            })
            {

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        this.picLogo.ImageLocation = dialog.FileName;
                        MyProject.Forms.FormMain.pnlLogo.BackgroundImage = Image.FromFile(dialog.FileName);
                    }
                    catch (OutOfMemoryException exception1)
                    {
                        ProjectData.SetProjectError(exception1);
                        OutOfMemoryException exception = exception1;
                        MessageBox.Show("错误: " + exception.Message);
                        ProjectData.ClearProjectError();
                    }
                    finally
                    {
                        dialog.Dispose();
                    }
                }
            }
        }
        /// <summary>
        /// 清空图标按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button2_Click(object sender, System.EventArgs e)
        {
            this.picLogo.ImageLocation = null;
            this.picLogo.Image = null;
            MyProject.Forms.FormMain.pnlLogo.BackgroundImage = null;
        }

        private void FormLogo_Load(object sender, EventArgs e)
        {
            lblTip.Text = IniRead("lblTip", "Text", "只允许 bmp(120*120)格式大小内图片");
            btnAdd.Text = IniRead("btnAdd", "Text", "添/改图标");
            BtnRemove.Text = IniRead("BtnRemove", "Text", "清空图标");
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
            return iniFiles.ReadString(Section, Value, Give);

        }
    }
}
