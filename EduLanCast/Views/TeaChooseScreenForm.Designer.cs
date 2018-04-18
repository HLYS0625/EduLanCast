namespace EduLanCast.Views
{
    partial class TeaChooseScreenForm
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
            this.LblScreen = new System.Windows.Forms.Label();
            this.ComBScreen = new System.Windows.Forms.ComboBox();
            this.LblGPU = new System.Windows.Forms.Label();
            this.ComBGPU = new System.Windows.Forms.ComboBox();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblScreen
            // 
            this.LblScreen.AutoSize = true;
            this.LblScreen.Location = new System.Drawing.Point(85, 215);
            this.LblScreen.Name = "LblScreen";
            this.LblScreen.Size = new System.Drawing.Size(67, 15);
            this.LblScreen.TabIndex = 0;
            this.LblScreen.Text = "显示器：";
            // 
            // ComBScreen
            // 
            this.ComBScreen.FormattingEnabled = true;
            this.ComBScreen.Items.AddRange(new object[] {
            "显示器一",
            "显示器二"});
            this.ComBScreen.Location = new System.Drawing.Point(235, 212);
            this.ComBScreen.Name = "ComBScreen";
            this.ComBScreen.Size = new System.Drawing.Size(234, 23);
            this.ComBScreen.TabIndex = 1;
            // 
            // LblGPU
            // 
            this.LblGPU.AutoSize = true;
            this.LblGPU.Location = new System.Drawing.Point(85, 141);
            this.LblGPU.Name = "LblGPU";
            this.LblGPU.Size = new System.Drawing.Size(52, 15);
            this.LblGPU.TabIndex = 2;
            this.LblGPU.Text = "显卡：";
            // 
            // ComBGPU
            // 
            this.ComBGPU.FormattingEnabled = true;
            this.ComBGPU.Location = new System.Drawing.Point(235, 138);
            this.ComBGPU.Name = "ComBGPU";
            this.ComBGPU.Size = new System.Drawing.Size(234, 23);
            this.ComBGPU.TabIndex = 3;
            // 
            // BtnOK
            // 
            this.BtnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOK.Location = new System.Drawing.Point(152, 379);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 30);
            this.BtnOK.TabIndex = 4;
            this.BtnOK.Text = "确定";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Location = new System.Drawing.Point(334, 379);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 30);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // TeaChooseScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(582, 453);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.ComBGPU);
            this.Controls.Add(this.LblGPU);
            this.Controls.Add(this.ComBScreen);
            this.Controls.Add(this.LblScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TeaChooseScreenForm";
            this.Text = "选择投屏";
            this.Load += new System.EventHandler(this.TeaChooseScreenForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblScreen;
        private System.Windows.Forms.ComboBox ComBScreen;
        private System.Windows.Forms.Label LblGPU;
        private System.Windows.Forms.ComboBox ComBGPU;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
    }
}