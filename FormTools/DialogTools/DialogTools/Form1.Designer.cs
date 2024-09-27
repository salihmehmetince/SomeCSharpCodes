namespace DialogTools
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.BtnFBD = new System.Windows.Forms.Button();
            this.BtnOFD = new System.Windows.Forms.Button();
            this.BtnSFD = new System.Windows.Forms.Button();
            this.BtnChooseLocation = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LblFolderPath = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblFBD = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblOFD = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtFileName = new System.Windows.Forms.TextBox();
            this.BtnRead = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BtnWriteFile = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnFBD
            // 
            this.BtnFBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnFBD.Location = new System.Drawing.Point(528, 12);
            this.BtnFBD.Name = "BtnFBD";
            this.BtnFBD.Size = new System.Drawing.Size(260, 39);
            this.BtnFBD.TabIndex = 0;
            this.BtnFBD.Text = "Choose a path...";
            this.BtnFBD.UseVisualStyleBackColor = true;
            this.BtnFBD.Click += new System.EventHandler(this.BtnFBD_Click);
            // 
            // BtnOFD
            // 
            this.BtnOFD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOFD.Location = new System.Drawing.Point(528, 70);
            this.BtnOFD.Name = "BtnOFD";
            this.BtnOFD.Size = new System.Drawing.Size(260, 39);
            this.BtnOFD.TabIndex = 1;
            this.BtnOFD.Text = "Choose a file...";
            this.BtnOFD.UseVisualStyleBackColor = true;
            this.BtnOFD.Click += new System.EventHandler(this.BtnOFD_Click);
            // 
            // BtnSFD
            // 
            this.BtnSFD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSFD.Location = new System.Drawing.Point(528, 133);
            this.BtnSFD.Name = "BtnSFD";
            this.BtnSFD.Size = new System.Drawing.Size(260, 39);
            this.BtnSFD.TabIndex = 2;
            this.BtnSFD.Text = "Save a file...";
            this.BtnSFD.UseVisualStyleBackColor = true;
            this.BtnSFD.Click += new System.EventHandler(this.BtnSFD_Click);
            // 
            // BtnChooseLocation
            // 
            this.BtnChooseLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnChooseLocation.Location = new System.Drawing.Point(528, 339);
            this.BtnChooseLocation.Name = "BtnChooseLocation";
            this.BtnChooseLocation.Size = new System.Drawing.Size(260, 39);
            this.BtnChooseLocation.TabIndex = 3;
            this.BtnChooseLocation.Text = "Choose a location to create";
            this.BtnChooseLocation.UseVisualStyleBackColor = true;
            this.BtnChooseLocation.Click += new System.EventHandler(this.BtnChooseLocation_Click);
            // 
            // BtnCreate
            // 
            this.BtnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCreate.Location = new System.Drawing.Point(528, 399);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(260, 39);
            this.BtnCreate.TabIndex = 4;
            this.BtnCreate.Text = "Create";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kaydedilecek Dosya Yolu:";
            // 
            // LblFolderPath
            // 
            this.LblFolderPath.AutoSize = true;
            this.LblFolderPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblFolderPath.Location = new System.Drawing.Point(232, 348);
            this.LblFolderPath.Name = "LblFolderPath";
            this.LblFolderPath.Size = new System.Drawing.Size(38, 20);
            this.LblFolderPath.TabIndex = 6;
            this.LblFolderPath.Text = "Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kaydedilecek Dosya Adı:";
            // 
            // LblFBD
            // 
            this.LblFBD.AutoSize = true;
            this.LblFBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblFBD.Location = new System.Drawing.Point(232, 21);
            this.LblFBD.Name = "LblFBD";
            this.LblFBD.Size = new System.Drawing.Size(38, 20);
            this.LblFBD.TabIndex = 10;
            this.LblFBD.Text = "Null";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Seçilen Dosya Yolu:";
            // 
            // LblOFD
            // 
            this.LblOFD.AutoSize = true;
            this.LblOFD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblOFD.Location = new System.Drawing.Point(232, 58);
            this.LblOFD.Name = "LblOFD";
            this.LblOFD.Size = new System.Drawing.Size(38, 20);
            this.LblOFD.TabIndex = 12;
            this.LblOFD.Text = "Null";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(12, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Seçilen Dosya Adı:";
            // 
            // TxtFileName
            // 
            this.TxtFileName.Location = new System.Drawing.Point(236, 399);
            this.TxtFileName.Name = "TxtFileName";
            this.TxtFileName.Size = new System.Drawing.Size(171, 22);
            this.TxtFileName.TabIndex = 13;
            // 
            // BtnRead
            // 
            this.BtnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnRead.Location = new System.Drawing.Point(528, 280);
            this.BtnRead.Name = "BtnRead";
            this.BtnRead.Size = new System.Drawing.Size(260, 39);
            this.BtnRead.TabIndex = 14;
            this.BtnRead.Text = "Read From a File";
            this.BtnRead.UseVisualStyleBackColor = true;
            this.BtnRead.Click += new System.EventHandler(this.BtnRead_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(16, 293);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(254, 52);
            this.listBox1.TabIndex = 15;
            // 
            // BtnWriteFile
            // 
            this.BtnWriteFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnWriteFile.Location = new System.Drawing.Point(528, 220);
            this.BtnWriteFile.Name = "BtnWriteFile";
            this.BtnWriteFile.Size = new System.Drawing.Size(260, 39);
            this.BtnWriteFile.TabIndex = 16;
            this.BtnWriteFile.Text = "Write to a File";
            this.BtnWriteFile.UseVisualStyleBackColor = true;
            this.BtnWriteFile.Click += new System.EventHandler(this.BtnWriteFile_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(16, 220);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(254, 67);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.BtnWriteFile);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BtnRead);
            this.Controls.Add(this.TxtFileName);
            this.Controls.Add(this.LblOFD);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LblFBD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblFolderPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.BtnChooseLocation);
            this.Controls.Add(this.BtnSFD);
            this.Controls.Add(this.BtnOFD);
            this.Controls.Add(this.BtnFBD);
            this.Name = "Form1";
            this.Text = "Form Tools";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button BtnFBD;
        private System.Windows.Forms.Button BtnOFD;
        private System.Windows.Forms.Button BtnSFD;
        private System.Windows.Forms.Button BtnChooseLocation;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblFolderPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblFBD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblOFD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtFileName;
        private System.Windows.Forms.Button BtnRead;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BtnWriteFile;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

