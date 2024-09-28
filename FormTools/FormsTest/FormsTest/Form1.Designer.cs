namespace FormsTest
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
            this.BtnForm2 = new System.Windows.Forms.Button();
            this.BtnForm3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnForm2
            // 
            this.BtnForm2.Location = new System.Drawing.Point(12, 12);
            this.BtnForm2.Name = "BtnForm2";
            this.BtnForm2.Size = new System.Drawing.Size(170, 36);
            this.BtnForm2.TabIndex = 0;
            this.BtnForm2.Text = "Go to form 2";
            this.BtnForm2.UseVisualStyleBackColor = true;
            this.BtnForm2.Click += new System.EventHandler(this.BtnForm2_Click);
            // 
            // BtnForm3
            // 
            this.BtnForm3.Location = new System.Drawing.Point(12, 59);
            this.BtnForm3.Name = "BtnForm3";
            this.BtnForm3.Size = new System.Drawing.Size(170, 36);
            this.BtnForm3.TabIndex = 1;
            this.BtnForm3.Text = "Go to form 3";
            this.BtnForm3.UseVisualStyleBackColor = true;
            this.BtnForm3.Click += new System.EventHandler(this.BtnForm3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnForm3);
            this.Controls.Add(this.BtnForm2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnForm2;
        private System.Windows.Forms.Button BtnForm3;
    }
}

