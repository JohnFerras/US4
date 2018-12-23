namespace US4
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_MigrateContent = new System.Windows.Forms.RadioButton();
            this.rb_GameplayConvert = new System.Windows.Forms.RadioButton();
            this.rb_LevelConvert = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_StartConvert = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_SelectUE4Path = new System.Windows.Forms.Button();
            this.txtBox_UE4Path = new System.Windows.Forms.TextBox();
            this.lbl_UE4Path = new System.Windows.Forms.Label();
            this.btn_SelectUDKPath = new System.Windows.Forms.Button();
            this.txtBox_UE3Path = new System.Windows.Forms.TextBox();
            this.lbl_UdkPath = new System.Windows.Forms.Label();
            this.UDKPathBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.UE4PathBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_MigrateContent);
            this.groupBox1.Controls.Add(this.rb_GameplayConvert);
            this.groupBox1.Controls.Add(this.rb_LevelConvert);
            this.groupBox1.Location = new System.Drawing.Point(35, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 90);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Converter Mode";
            // 
            // rb_MigrateContent
            // 
            this.rb_MigrateContent.AutoSize = true;
            this.rb_MigrateContent.Enabled = false;
            this.rb_MigrateContent.Location = new System.Drawing.Point(7, 66);
            this.rb_MigrateContent.Name = "rb_MigrateContent";
            this.rb_MigrateContent.Size = new System.Drawing.Size(108, 17);
            this.rb_MigrateContent.TabIndex = 2;
            this.rb_MigrateContent.TabStop = true;
            this.rb_MigrateContent.Text = "Content Migration";
            this.rb_MigrateContent.UseVisualStyleBackColor = true;
            // 
            // rb_GameplayConvert
            // 
            this.rb_GameplayConvert.AutoSize = true;
            this.rb_GameplayConvert.Location = new System.Drawing.Point(7, 43);
            this.rb_GameplayConvert.Name = "rb_GameplayConvert";
            this.rb_GameplayConvert.Size = new System.Drawing.Size(121, 17);
            this.rb_GameplayConvert.TabIndex = 1;
            this.rb_GameplayConvert.TabStop = true;
            this.rb_GameplayConvert.Text = "Gameplay Converter";
            this.rb_GameplayConvert.UseVisualStyleBackColor = true;
            // 
            // rb_LevelConvert
            // 
            this.rb_LevelConvert.AutoSize = true;
            this.rb_LevelConvert.Enabled = false;
            this.rb_LevelConvert.Location = new System.Drawing.Point(7, 20);
            this.rb_LevelConvert.Name = "rb_LevelConvert";
            this.rb_LevelConvert.Size = new System.Drawing.Size(100, 17);
            this.rb_LevelConvert.TabIndex = 0;
            this.rb_LevelConvert.TabStop = true;
            this.rb_LevelConvert.Text = "Level Converter";
            this.rb_LevelConvert.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(799, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // btn_StartConvert
            // 
            this.btn_StartConvert.Location = new System.Drawing.Point(663, 372);
            this.btn_StartConvert.Name = "btn_StartConvert";
            this.btn_StartConvert.Size = new System.Drawing.Size(105, 23);
            this.btn_StartConvert.TabIndex = 3;
            this.btn_StartConvert.Text = "Convert";
            this.btn_StartConvert.UseVisualStyleBackColor = true;
            this.btn_StartConvert.Click += new System.EventHandler(this.btn_StartConvert_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_SelectUE4Path);
            this.groupBox2.Controls.Add(this.txtBox_UE4Path);
            this.groupBox2.Controls.Add(this.lbl_UE4Path);
            this.groupBox2.Controls.Add(this.btn_SelectUDKPath);
            this.groupBox2.Controls.Add(this.txtBox_UE3Path);
            this.groupBox2.Controls.Add(this.lbl_UdkPath);
            this.groupBox2.Location = new System.Drawing.Point(174, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 153);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Converter Setup";
            // 
            // btn_SelectUE4Path
            // 
            this.btn_SelectUE4Path.Location = new System.Drawing.Point(268, 43);
            this.btn_SelectUE4Path.Name = "btn_SelectUE4Path";
            this.btn_SelectUE4Path.Size = new System.Drawing.Size(75, 23);
            this.btn_SelectUE4Path.TabIndex = 5;
            this.btn_SelectUE4Path.Text = "Select";
            this.btn_SelectUE4Path.UseVisualStyleBackColor = true;
            this.btn_SelectUE4Path.Click += new System.EventHandler(this.btn_SelectUE4Path_Click);
            // 
            // txtBox_UE4Path
            // 
            this.txtBox_UE4Path.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtBox_UE4Path.Location = new System.Drawing.Point(68, 46);
            this.txtBox_UE4Path.Name = "txtBox_UE4Path";
            this.txtBox_UE4Path.Size = new System.Drawing.Size(194, 20);
            this.txtBox_UE4Path.TabIndex = 4;
            this.txtBox_UE4Path.Text = "F:/UE4";
            // 
            // lbl_UE4Path
            // 
            this.lbl_UE4Path.AutoSize = true;
            this.lbl_UE4Path.Location = new System.Drawing.Point(7, 49);
            this.lbl_UE4Path.Name = "lbl_UE4Path";
            this.lbl_UE4Path.Size = new System.Drawing.Size(53, 13);
            this.lbl_UE4Path.TabIndex = 3;
            this.lbl_UE4Path.Text = "UE4Path:";
            // 
            // btn_SelectUDKPath
            // 
            this.btn_SelectUDKPath.Location = new System.Drawing.Point(268, 14);
            this.btn_SelectUDKPath.Name = "btn_SelectUDKPath";
            this.btn_SelectUDKPath.Size = new System.Drawing.Size(75, 23);
            this.btn_SelectUDKPath.TabIndex = 2;
            this.btn_SelectUDKPath.Text = "Select";
            this.btn_SelectUDKPath.UseVisualStyleBackColor = true;
            this.btn_SelectUDKPath.Click += new System.EventHandler(this.btn_SelectUDKPath_Click);
            // 
            // txtBox_UE3Path
            // 
            this.txtBox_UE3Path.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtBox_UE3Path.Location = new System.Drawing.Point(68, 17);
            this.txtBox_UE3Path.Name = "txtBox_UE3Path";
            this.txtBox_UE3Path.Size = new System.Drawing.Size(194, 20);
            this.txtBox_UE3Path.TabIndex = 1;
            this.txtBox_UE3Path.Text = "F:/build_ue3";
            // 
            // lbl_UdkPath
            // 
            this.lbl_UdkPath.AutoSize = true;
            this.lbl_UdkPath.Location = new System.Drawing.Point(7, 20);
            this.lbl_UdkPath.Name = "lbl_UdkPath";
            this.lbl_UdkPath.Size = new System.Drawing.Size(55, 13);
            this.lbl_UdkPath.TabIndex = 0;
            this.lbl_UdkPath.Text = "UDKPath:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 426);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_StartConvert);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Unreal Converter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_MigrateContent;
        private System.Windows.Forms.RadioButton rb_GameplayConvert;
        private System.Windows.Forms.RadioButton rb_LevelConvert;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btn_StartConvert;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_SelectUDKPath;
        private System.Windows.Forms.TextBox txtBox_UE3Path;
        private System.Windows.Forms.Label lbl_UdkPath;
        private System.Windows.Forms.FolderBrowserDialog UDKPathBrowser;
        private System.Windows.Forms.Button btn_SelectUE4Path;
        private System.Windows.Forms.TextBox txtBox_UE4Path;
        private System.Windows.Forms.Label lbl_UE4Path;
        private System.Windows.Forms.FolderBrowserDialog UE4PathBrowser;
    }
}

