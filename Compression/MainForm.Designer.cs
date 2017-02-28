namespace Compression
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
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.btnCompress = new System.Windows.Forms.Button();
            this.txtDirName = new System.Windows.Forms.TextBox();
            this.btnExtract = new System.Windows.Forms.Button();
            this.selectFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.compressLocationDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.selectZipDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lstFiles
            // 
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.Location = new System.Drawing.Point(12, 12);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(172, 290);
            this.lstFiles.TabIndex = 0;
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(206, 12);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(102, 43);
            this.btnAddFile.TabIndex = 1;
            this.btnAddFile.Text = "Add File";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // btnCompress
            // 
            this.btnCompress.Location = new System.Drawing.Point(206, 61);
            this.btnCompress.Name = "btnCompress";
            this.btnCompress.Size = new System.Drawing.Size(102, 43);
            this.btnCompress.TabIndex = 2;
            this.btnCompress.Text = "Compress";
            this.btnCompress.UseVisualStyleBackColor = true;
            this.btnCompress.Click += new System.EventHandler(this.btnCompress_Click);
            // 
            // txtDirName
            // 
            this.txtDirName.Location = new System.Drawing.Point(206, 124);
            this.txtDirName.Name = "txtDirName";
            this.txtDirName.Size = new System.Drawing.Size(102, 20);
            this.txtDirName.TabIndex = 3;
            this.txtDirName.Text = "JCVCompression";
            this.txtDirName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnExtract
            // 
            this.btnExtract.Location = new System.Drawing.Point(206, 258);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(102, 43);
            this.btnExtract.TabIndex = 4;
            this.btnExtract.Text = "Extract";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // selectZipDialog
            // 
            this.selectZipDialog.Filter = "Zip files|*.zip";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 313);
            this.Controls.Add(this.btnExtract);
            this.Controls.Add(this.txtDirName);
            this.Controls.Add(this.btnCompress);
            this.Controls.Add(this.btnAddFile);
            this.Controls.Add(this.lstFiles);
            this.Name = "MainForm";
            this.Text = "JCVCompression";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.Button btnCompress;
        private System.Windows.Forms.TextBox txtDirName;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.OpenFileDialog selectFileDialog;
        private System.Windows.Forms.FolderBrowserDialog compressLocationDialog;
        private System.Windows.Forms.OpenFileDialog selectZipDialog;
    }
}

