namespace OEMchange
{
    partial class FormLogo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnRemove = new MetroFramework.Controls.MetroButton();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.lblTip = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRemove
            // 
            this.BtnRemove.Location = new System.Drawing.Point(197, 162);
            this.BtnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(84, 47);
            this.BtnRemove.TabIndex = 7;
            this.BtnRemove.Text = "清空图标";
            this.BtnRemove.UseSelectable = true;
            this.BtnRemove.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(197, 94);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 47);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "添/改图标";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(17, 66);
            this.lblTip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(261, 15);
            this.lblTip.TabIndex = 5;
            this.lblTip.Text = "只允许 bmp(120*120)格式大小内图片";
            // 
            // picLogo
            // 
            this.picLogo.ImageLocation = "";
            this.picLogo.Location = new System.Drawing.Point(20, 90);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(144, 126);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLogo.TabIndex = 4;
            this.picLogo.TabStop = false;
            // 
            // FormLogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(301, 225);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.picLogo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(301, 225);
            this.MinimumSize = new System.Drawing.Size(301, 225);
            this.Name = "FormLogo";
            this.ShowIcon = false;
            this.Text = "logo";
            this.Load += new System.EventHandler(this.FormLogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal MetroFramework.Controls.MetroButton BtnRemove;
        internal MetroFramework.Controls.MetroButton btnAdd;
        internal System.Windows.Forms.Label lblTip;
        internal System.Windows.Forms.PictureBox picLogo;
    }
}