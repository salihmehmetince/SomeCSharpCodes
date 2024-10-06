namespace MiniBookTest
{
    partial class FrmSales
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
            this.TxtSaleId = new System.Windows.Forms.TextBox();
            this.LblProductName = new System.Windows.Forms.Label();
            this.BtnList = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.GBTransitions = new System.Windows.Forms.GroupBox();
            this.MTBSaleDate = new System.Windows.Forms.MaskedTextBox();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.TxtPiece = new System.Windows.Forms.TextBox();
            this.TxtCustomer = new System.Windows.Forms.TextBox();
            this.CmbProduct = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GBTransitions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtSaleId
            // 
            this.TxtSaleId.Location = new System.Drawing.Point(138, 30);
            this.TxtSaleId.Name = "TxtSaleId";
            this.TxtSaleId.Size = new System.Drawing.Size(163, 30);
            this.TxtSaleId.TabIndex = 13;
            // 
            // LblProductName
            // 
            this.LblProductName.AutoSize = true;
            this.LblProductName.Location = new System.Drawing.Point(37, 35);
            this.LblProductName.Name = "LblProductName";
            this.LblProductName.Size = new System.Drawing.Size(79, 25);
            this.LblProductName.TabIndex = 12;
            this.LblProductName.Text = "Sale Id:";
            // 
            // BtnList
            // 
            this.BtnList.Location = new System.Drawing.Point(337, 60);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(150, 40);
            this.BtnList.TabIndex = 7;
            this.BtnList.Text = "List";
            this.BtnList.UseVisualStyleBackColor = true;
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(337, 113);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(150, 40);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(337, 223);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(150, 40);
            this.BtnUpdate.TabIndex = 10;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(337, 168);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(150, 40);
            this.BtnDelete.TabIndex = 9;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // GBTransitions
            // 
            this.GBTransitions.BackColor = System.Drawing.Color.Tan;
            this.GBTransitions.Controls.Add(this.MTBSaleDate);
            this.GBTransitions.Controls.Add(this.TxtTotal);
            this.GBTransitions.Controls.Add(this.TxtPrice);
            this.GBTransitions.Controls.Add(this.TxtPiece);
            this.GBTransitions.Controls.Add(this.TxtCustomer);
            this.GBTransitions.Controls.Add(this.CmbProduct);
            this.GBTransitions.Controls.Add(this.label6);
            this.GBTransitions.Controls.Add(this.label5);
            this.GBTransitions.Controls.Add(this.label4);
            this.GBTransitions.Controls.Add(this.label3);
            this.GBTransitions.Controls.Add(this.label2);
            this.GBTransitions.Controls.Add(this.label1);
            this.GBTransitions.Controls.Add(this.TxtSaleId);
            this.GBTransitions.Controls.Add(this.LblProductName);
            this.GBTransitions.Controls.Add(this.BtnList);
            this.GBTransitions.Controls.Add(this.BtnSave);
            this.GBTransitions.Controls.Add(this.BtnUpdate);
            this.GBTransitions.Controls.Add(this.BtnDelete);
            this.GBTransitions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GBTransitions.Location = new System.Drawing.Point(0, 406);
            this.GBTransitions.Name = "GBTransitions";
            this.GBTransitions.Size = new System.Drawing.Size(948, 326);
            this.GBTransitions.TabIndex = 14;
            this.GBTransitions.TabStop = false;
            this.GBTransitions.Text = "Transitions";
            // 
            // MTBSaleDate
            // 
            this.MTBSaleDate.Location = new System.Drawing.Point(138, 276);
            this.MTBSaleDate.Mask = "00/00/0000";
            this.MTBSaleDate.Name = "MTBSaleDate";
            this.MTBSaleDate.Size = new System.Drawing.Size(163, 30);
            this.MTBSaleDate.TabIndex = 25;
            this.MTBSaleDate.ValidatingType = typeof(System.DateTime);
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(138, 235);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(163, 30);
            this.TxtTotal.TabIndex = 24;
            // 
            // TxtPrice
            // 
            this.TxtPrice.Location = new System.Drawing.Point(138, 194);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(163, 30);
            this.TxtPrice.TabIndex = 23;
            // 
            // TxtPiece
            // 
            this.TxtPiece.Location = new System.Drawing.Point(138, 153);
            this.TxtPiece.Name = "TxtPiece";
            this.TxtPiece.Size = new System.Drawing.Size(163, 30);
            this.TxtPiece.TabIndex = 22;
            // 
            // TxtCustomer
            // 
            this.TxtCustomer.Location = new System.Drawing.Point(138, 112);
            this.TxtCustomer.Name = "TxtCustomer";
            this.TxtCustomer.Size = new System.Drawing.Size(163, 30);
            this.TxtCustomer.TabIndex = 21;
            // 
            // CmbProduct
            // 
            this.CmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbProduct.FormattingEnabled = true;
            this.CmbProduct.Location = new System.Drawing.Point(138, 68);
            this.CmbProduct.Name = "CmbProduct";
            this.CmbProduct.Size = new System.Drawing.Size(163, 33);
            this.CmbProduct.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Sale Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Piece:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Customer:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Product:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(948, 400);
            this.dataGridView1.TabIndex = 13;
            // 
            // FrmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(948, 732);
            this.Controls.Add(this.GBTransitions);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSales";
            this.Load += new System.EventHandler(this.FrmSales_Load);
            this.GBTransitions.ResumeLayout(false);
            this.GBTransitions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSaleId;
        private System.Windows.Forms.Label LblProductName;
        private System.Windows.Forms.Button BtnList;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.GroupBox GBTransitions;
        private System.Windows.Forms.MaskedTextBox MTBSaleDate;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.TextBox TxtPiece;
        private System.Windows.Forms.TextBox TxtCustomer;
        private System.Windows.Forms.ComboBox CmbProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}