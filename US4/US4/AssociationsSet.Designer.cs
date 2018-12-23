namespace US4
{
    partial class AssociationsSet
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
            this.CodeLine = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CodeLine
            // 
            this.CodeLine.AutoSize = true;
            this.CodeLine.Location = new System.Drawing.Point(25, 34);
            this.CodeLine.Name = "CodeLine";
            this.CodeLine.Size = new System.Drawing.Size(35, 13);
            this.CodeLine.TabIndex = 1;
            this.CodeLine.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1109, 61);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AssociationsSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1218, 439);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CodeLine);
            this.Name = "AssociationsSet";
            this.Text = "AssociationsSet";
            this.Load += new System.EventHandler(this.AssociationsSet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CodeLine;
        private System.Windows.Forms.Button button1;
    }
}