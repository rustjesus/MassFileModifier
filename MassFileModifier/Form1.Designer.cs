namespace MassFileModifier
{
    partial class Form1
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
            this.filePathTxtBox = new System.Windows.Forms.TextBox();
            this.newFileContentsBox = new System.Windows.Forms.TextBox();
            this.folderPathLabel = new System.Windows.Forms.Label();
            this.newFileContents = new System.Windows.Forms.Label();
            this.changeContentsBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.oldFileContents = new System.Windows.Forms.Label();
            this.oldFileContentsBox = new System.Windows.Forms.TextBox();
            this.recursiveCheckBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // filePathTxtBox
            // 
            this.filePathTxtBox.Location = new System.Drawing.Point(124, 26);
            this.filePathTxtBox.Name = "filePathTxtBox";
            this.filePathTxtBox.Size = new System.Drawing.Size(455, 20);
            this.filePathTxtBox.TabIndex = 0;
            this.filePathTxtBox.TextChanged += new System.EventHandler(this.filePathTxtBox_TextChanged);
            // 
            // newFileContentsBox
            // 
            this.newFileContentsBox.Location = new System.Drawing.Point(124, 75);
            this.newFileContentsBox.Name = "newFileContentsBox";
            this.newFileContentsBox.Size = new System.Drawing.Size(455, 20);
            this.newFileContentsBox.TabIndex = 1;
            this.newFileContentsBox.TextChanged += new System.EventHandler(this.newFileContentsBox_TextChanged);
            // 
            // folderPathLabel
            // 
            this.folderPathLabel.AutoSize = true;
            this.folderPathLabel.Location = new System.Drawing.Point(52, 29);
            this.folderPathLabel.Name = "folderPathLabel";
            this.folderPathLabel.Size = new System.Drawing.Size(64, 13);
            this.folderPathLabel.TabIndex = 2;
            this.folderPathLabel.Text = "Folder Path:";
            this.folderPathLabel.Click += new System.EventHandler(this.folderPathLabel_Click);
            // 
            // newFileContents
            // 
            this.newFileContents.AutoSize = true;
            this.newFileContents.Location = new System.Drawing.Point(15, 78);
            this.newFileContents.Name = "newFileContents";
            this.newFileContents.Size = new System.Drawing.Size(101, 13);
            this.newFileContents.TabIndex = 3;
            this.newFileContents.Text = "New Files Contents:";
            this.newFileContents.Click += new System.EventHandler(this.newFileContents_Click);
            // 
            // changeContentsBtn
            // 
            this.changeContentsBtn.Location = new System.Drawing.Point(32, 137);
            this.changeContentsBtn.Name = "changeContentsBtn";
            this.changeContentsBtn.Size = new System.Drawing.Size(133, 23);
            this.changeContentsBtn.TabIndex = 4;
            this.changeContentsBtn.Text = "Change Contents";
            this.changeContentsBtn.UseVisualStyleBackColor = true;
            this.changeContentsBtn.Click += new System.EventHandler(this.changeContentsBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(527, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Place the path then write the contents you want to replace in the old box and the" +
    " new contents in the new box";
            // 
            // oldFileContents
            // 
            this.oldFileContents.AutoSize = true;
            this.oldFileContents.Location = new System.Drawing.Point(21, 52);
            this.oldFileContents.Name = "oldFileContents";
            this.oldFileContents.Size = new System.Drawing.Size(95, 13);
            this.oldFileContents.TabIndex = 6;
            this.oldFileContents.Text = "Old Files Contents:";
            this.oldFileContents.Click += new System.EventHandler(this.oldFileContents_Click);
            // 
            // oldFileContentsBox
            // 
            this.oldFileContentsBox.Location = new System.Drawing.Point(124, 52);
            this.oldFileContentsBox.Name = "oldFileContentsBox";
            this.oldFileContentsBox.Size = new System.Drawing.Size(455, 20);
            this.oldFileContentsBox.TabIndex = 7;
            this.oldFileContentsBox.TextChanged += new System.EventHandler(this.oldFileContentsBox_TextChanged);
            // 
            // recursiveCheckBox1
            // 
            this.recursiveCheckBox1.AutoSize = true;
            this.recursiveCheckBox1.Location = new System.Drawing.Point(124, 102);
            this.recursiveCheckBox1.Name = "recursiveCheckBox1";
            this.recursiveCheckBox1.Size = new System.Drawing.Size(74, 17);
            this.recursiveCheckBox1.TabIndex = 8;
            this.recursiveCheckBox1.Text = "Recursive";
            this.recursiveCheckBox1.UseVisualStyleBackColor = true;
            this.recursiveCheckBox1.CheckedChanged += new System.EventHandler(this.recursiveCheckBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 225);
            this.Controls.Add(this.recursiveCheckBox1);
            this.Controls.Add(this.oldFileContentsBox);
            this.Controls.Add(this.oldFileContents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.changeContentsBtn);
            this.Controls.Add(this.newFileContents);
            this.Controls.Add(this.folderPathLabel);
            this.Controls.Add(this.newFileContentsBox);
            this.Controls.Add(this.filePathTxtBox);
            this.Name = "Form1";
            this.Text = "Mass File Rename";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox filePathTxtBox;
        private System.Windows.Forms.TextBox newFileContentsBox;
        private System.Windows.Forms.Label folderPathLabel;
        private System.Windows.Forms.Label newFileContents;
        private System.Windows.Forms.Button changeContentsBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label oldFileContents;
        private System.Windows.Forms.TextBox oldFileContentsBox;
        private System.Windows.Forms.CheckBox recursiveCheckBox1;
    }
}

