namespace FindOutCLRVer
{
    partial class FrmMain
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
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.pnlDropZone = new System.Windows.Forms.Panel();
            this.txtClrVersion = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.pnlDropZone.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFilePath
            // 
            this.txtFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilePath.Location = new System.Drawing.Point(12, 187);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(461, 39);
            this.txtFilePath.TabIndex = 1;
            this.txtFilePath.TabStop = false;
            // 
            // pnlDropZone
            // 
            this.pnlDropZone.AllowDrop = true;
            this.pnlDropZone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDropZone.BackColor = System.Drawing.SystemColors.Info;
            this.pnlDropZone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDropZone.Controls.Add(this.label1);
            this.pnlDropZone.Location = new System.Drawing.Point(12, 12);
            this.pnlDropZone.Name = "pnlDropZone";
            this.pnlDropZone.Size = new System.Drawing.Size(503, 164);
            this.pnlDropZone.TabIndex = 2;
            // 
            // txtClrVersion
            // 
            this.txtClrVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClrVersion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClrVersion.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClrVersion.HideSelection = false;
            this.txtClrVersion.Location = new System.Drawing.Point(12, 301);
            this.txtClrVersion.Name = "txtClrVersion";
            this.txtClrVersion.ReadOnly = true;
            this.txtClrVersion.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtClrVersion.Size = new System.Drawing.Size(500, 72);
            this.txtClrVersion.TabIndex = 3;
            this.txtClrVersion.TabStop = false;
            this.txtClrVersion.Text = "Does not set a file. ";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(12, 256);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(169, 32);
            this.textBox1.TabIndex = 4;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "CLR Version:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(3, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drag and drop";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBrowser
            // 
            this.btnBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowser.BackgroundImage = global::FindOutCLRVer.Properties.Resources.Folder;
            this.btnBrowser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBrowser.Location = new System.Drawing.Point(473, 187);
            this.btnBrowser.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(39, 39);
            this.btnBrowser.TabIndex = 0;
            this.btnBrowser.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 398);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtClrVersion);
            this.Controls.Add(this.pnlDropZone);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnBrowser);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Find Out";
            this.pnlDropZone.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Panel pnlDropZone;
        private System.Windows.Forms.RichTextBox txtClrVersion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}