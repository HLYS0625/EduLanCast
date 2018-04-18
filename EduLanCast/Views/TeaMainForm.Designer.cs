namespace EduLanCast.Views
{
    partial class TeaMainForm
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
            this.MenuTea = new System.Windows.Forms.MenuStrip();
            this.TSMIFile = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMICheck = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMISet = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.STCTeaMain = new System.Windows.Forms.SplitContainer();
            this.FLPnlTeaFunctions = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BtnStartCast = new System.Windows.Forms.Button();
            this.MenuTea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.STCTeaMain)).BeginInit();
            this.STCTeaMain.Panel2.SuspendLayout();
            this.STCTeaMain.SuspendLayout();
            this.FLPnlTeaFunctions.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuTea
            // 
            this.MenuTea.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuTea.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIFile,
            this.TSMIEdit,
            this.TSMICheck,
            this.TSMISet,
            this.TSMIHelp});
            this.MenuTea.Location = new System.Drawing.Point(0, 0);
            this.MenuTea.Name = "MenuTea";
            this.MenuTea.Size = new System.Drawing.Size(1182, 28);
            this.MenuTea.TabIndex = 0;
            this.MenuTea.Text = "menuStrip1";
            // 
            // TSMIFile
            // 
            this.TSMIFile.Name = "TSMIFile";
            this.TSMIFile.Size = new System.Drawing.Size(51, 24);
            this.TSMIFile.Text = "文件";
            // 
            // TSMIEdit
            // 
            this.TSMIEdit.Name = "TSMIEdit";
            this.TSMIEdit.Size = new System.Drawing.Size(51, 24);
            this.TSMIEdit.Text = "编辑";
            // 
            // TSMICheck
            // 
            this.TSMICheck.Name = "TSMICheck";
            this.TSMICheck.Size = new System.Drawing.Size(51, 24);
            this.TSMICheck.Text = "查看";
            // 
            // TSMISet
            // 
            this.TSMISet.Name = "TSMISet";
            this.TSMISet.Size = new System.Drawing.Size(51, 24);
            this.TSMISet.Text = "设置";
            // 
            // TSMIHelp
            // 
            this.TSMIHelp.Name = "TSMIHelp";
            this.TSMIHelp.Size = new System.Drawing.Size(51, 24);
            this.TSMIHelp.Text = "帮助";
            // 
            // STCTeaMain
            // 
            this.STCTeaMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.STCTeaMain.Location = new System.Drawing.Point(0, 28);
            this.STCTeaMain.Name = "STCTeaMain";
            // 
            // STCTeaMain.Panel2
            // 
            this.STCTeaMain.Panel2.Controls.Add(this.FLPnlTeaFunctions);
            this.STCTeaMain.Panel2.Controls.Add(this.BtnStartCast);
            this.STCTeaMain.Size = new System.Drawing.Size(1182, 725);
            this.STCTeaMain.SplitterDistance = 929;
            this.STCTeaMain.TabIndex = 1;
            // 
            // FLPnlTeaFunctions
            // 
            this.FLPnlTeaFunctions.Controls.Add(this.BtnRefresh);
            this.FLPnlTeaFunctions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FLPnlTeaFunctions.Location = new System.Drawing.Point(0, 361);
            this.FLPnlTeaFunctions.Name = "FLPnlTeaFunctions";
            this.FLPnlTeaFunctions.Size = new System.Drawing.Size(249, 364);
            this.FLPnlTeaFunctions.TabIndex = 1;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.AutoSize = true;
            this.BtnRefresh.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefresh.Location = new System.Drawing.Point(3, 3);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(245, 40);
            this.BtnRefresh.TabIndex = 0;
            this.BtnRefresh.Text = "刷新";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            // 
            // BtnStartCast
            // 
            this.BtnStartCast.AutoSize = true;
            this.BtnStartCast.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnStartCast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStartCast.Location = new System.Drawing.Point(0, 0);
            this.BtnStartCast.Name = "BtnStartCast";
            this.BtnStartCast.Size = new System.Drawing.Size(249, 184);
            this.BtnStartCast.TabIndex = 0;
            this.BtnStartCast.Text = "开始传屏";
            this.BtnStartCast.UseVisualStyleBackColor = true;
            this.BtnStartCast.Click += new System.EventHandler(this.BtnStartCast_Click);
            // 
            // TeaMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.STCTeaMain);
            this.Controls.Add(this.MenuTea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MenuTea;
            this.MaximizeBox = false;
            this.Name = "TeaMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeaMainForm";
            this.Load += new System.EventHandler(this.TeaMainForm_Load);
            this.MenuTea.ResumeLayout(false);
            this.MenuTea.PerformLayout();
            this.STCTeaMain.Panel2.ResumeLayout(false);
            this.STCTeaMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.STCTeaMain)).EndInit();
            this.STCTeaMain.ResumeLayout(false);
            this.FLPnlTeaFunctions.ResumeLayout(false);
            this.FLPnlTeaFunctions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuTea;
        private System.Windows.Forms.ToolStripMenuItem TSMIFile;
        private System.Windows.Forms.ToolStripMenuItem TSMIEdit;
        private System.Windows.Forms.ToolStripMenuItem TSMICheck;
        private System.Windows.Forms.ToolStripMenuItem TSMISet;
        private System.Windows.Forms.ToolStripMenuItem TSMIHelp;
        private System.Windows.Forms.SplitContainer STCTeaMain;
        private System.Windows.Forms.FlowLayoutPanel FLPnlTeaFunctions;
        private System.Windows.Forms.Button BtnStartCast;
        private System.Windows.Forms.Button BtnRefresh;
    }
}