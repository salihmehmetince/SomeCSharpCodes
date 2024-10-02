namespace MiniBookTest
{
    partial class FrmDirectTo
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
            this.BtnProductTransactions = new System.Windows.Forms.Button();
            this.BtnCategoryTransactions = new System.Windows.Forms.Button();
            this.BtnStatistics = new System.Windows.Forms.Button();
            this.BtnCharts = new System.Windows.Forms.Button();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnProductTransactions
            // 
            this.BtnProductTransactions.BackColor = System.Drawing.Color.Navy;
            this.BtnProductTransactions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnProductTransactions.ForeColor = System.Drawing.Color.White;
            this.BtnProductTransactions.Location = new System.Drawing.Point(12, 12);
            this.BtnProductTransactions.Name = "BtnProductTransactions";
            this.BtnProductTransactions.Size = new System.Drawing.Size(180, 148);
            this.BtnProductTransactions.TabIndex = 0;
            this.BtnProductTransactions.Text = "Product Transactions";
            this.BtnProductTransactions.UseVisualStyleBackColor = false;
            this.BtnProductTransactions.Click += new System.EventHandler(this.BtnProductTransactions_Click);
            // 
            // BtnCategoryTransactions
            // 
            this.BtnCategoryTransactions.BackColor = System.Drawing.Color.Navy;
            this.BtnCategoryTransactions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCategoryTransactions.ForeColor = System.Drawing.Color.White;
            this.BtnCategoryTransactions.Location = new System.Drawing.Point(198, 12);
            this.BtnCategoryTransactions.Name = "BtnCategoryTransactions";
            this.BtnCategoryTransactions.Size = new System.Drawing.Size(180, 148);
            this.BtnCategoryTransactions.TabIndex = 1;
            this.BtnCategoryTransactions.Text = "Category Transactions";
            this.BtnCategoryTransactions.UseVisualStyleBackColor = false;
            this.BtnCategoryTransactions.Click += new System.EventHandler(this.BtnCategoryTransactions_Click);
            // 
            // BtnStatistics
            // 
            this.BtnStatistics.BackColor = System.Drawing.Color.Navy;
            this.BtnStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStatistics.ForeColor = System.Drawing.Color.White;
            this.BtnStatistics.Location = new System.Drawing.Point(386, 10);
            this.BtnStatistics.Name = "BtnStatistics";
            this.BtnStatistics.Size = new System.Drawing.Size(180, 148);
            this.BtnStatistics.TabIndex = 2;
            this.BtnStatistics.Text = "Statistics";
            this.BtnStatistics.UseVisualStyleBackColor = false;
            this.BtnStatistics.Click += new System.EventHandler(this.BtnStatistics_Click);
            // 
            // BtnCharts
            // 
            this.BtnCharts.BackColor = System.Drawing.Color.Navy;
            this.BtnCharts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCharts.ForeColor = System.Drawing.Color.White;
            this.BtnCharts.Location = new System.Drawing.Point(572, 12);
            this.BtnCharts.Name = "BtnCharts";
            this.BtnCharts.Size = new System.Drawing.Size(180, 148);
            this.BtnCharts.TabIndex = 3;
            this.BtnCharts.Text = "Charts";
            this.BtnCharts.UseVisualStyleBackColor = false;
            this.BtnCharts.Click += new System.EventHandler(this.BtnCharts_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.Navy;
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.Location = new System.Drawing.Point(758, 12);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(180, 148);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "Log in";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // FrmDirectTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(952, 168);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.BtnCharts);
            this.Controls.Add(this.BtnStatistics);
            this.Controls.Add(this.BtnCategoryTransactions);
            this.Controls.Add(this.BtnProductTransactions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDirectTo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDirectTo";
            this.Load += new System.EventHandler(this.FrmDirectTo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnProductTransactions;
        private System.Windows.Forms.Button BtnCategoryTransactions;
        private System.Windows.Forms.Button BtnStatistics;
        private System.Windows.Forms.Button BtnCharts;
        private System.Windows.Forms.Button BtnLogin;
    }
}