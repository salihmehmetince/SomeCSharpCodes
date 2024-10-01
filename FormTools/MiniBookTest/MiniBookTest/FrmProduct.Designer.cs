namespace MiniBookTest
{
    partial class FrmProduct
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnList = new System.Windows.Forms.Button();
            this.GBTransitions = new System.Windows.Forms.GroupBox();
            this.TxtProductName = new System.Windows.Forms.TextBox();
            this.LblProductName = new System.Windows.Forms.Label();
            this.LblStock = new System.Windows.Forms.Label();
            this.TxtBuyingPrice = new System.Windows.Forms.TextBox();
            this.LblBuyingPrice = new System.Windows.Forms.Label();
            this.TxtSellingPrice = new System.Windows.Forms.TextBox();
            this.LblSellingPrice = new System.Windows.Forms.Label();
            this.LblCategory = new System.Windows.Forms.Label();
            this.CmbCategory = new System.Windows.Forms.ComboBox();
            this.NUDStock = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GBTransitions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDStock)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 354);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1095, 400);
            this.dataGridView1.TabIndex = 1;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(375, 240);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(150, 40);
            this.BtnSearch.TabIndex = 11;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(375, 190);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(150, 40);
            this.BtnUpdate.TabIndex = 10;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(375, 135);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(150, 40);
            this.BtnDelete.TabIndex = 9;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(375, 80);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(150, 40);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnList
            // 
            this.BtnList.Location = new System.Drawing.Point(375, 27);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(150, 40);
            this.BtnList.TabIndex = 7;
            this.BtnList.Text = "List";
            this.BtnList.UseVisualStyleBackColor = true;
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // GBTransitions
            // 
            this.GBTransitions.BackColor = System.Drawing.Color.Tan;
            this.GBTransitions.Controls.Add(this.NUDStock);
            this.GBTransitions.Controls.Add(this.CmbCategory);
            this.GBTransitions.Controls.Add(this.LblCategory);
            this.GBTransitions.Controls.Add(this.TxtSellingPrice);
            this.GBTransitions.Controls.Add(this.LblSellingPrice);
            this.GBTransitions.Controls.Add(this.TxtBuyingPrice);
            this.GBTransitions.Controls.Add(this.LblBuyingPrice);
            this.GBTransitions.Controls.Add(this.LblStock);
            this.GBTransitions.Controls.Add(this.TxtProductName);
            this.GBTransitions.Controls.Add(this.LblProductName);
            this.GBTransitions.Controls.Add(this.BtnList);
            this.GBTransitions.Controls.Add(this.BtnSearch);
            this.GBTransitions.Controls.Add(this.BtnSave);
            this.GBTransitions.Controls.Add(this.BtnUpdate);
            this.GBTransitions.Controls.Add(this.BtnDelete);
            this.GBTransitions.Location = new System.Drawing.Point(12, 12);
            this.GBTransitions.Name = "GBTransitions";
            this.GBTransitions.Size = new System.Drawing.Size(904, 336);
            this.GBTransitions.TabIndex = 12;
            this.GBTransitions.TabStop = false;
            this.GBTransitions.Text = "Transitions";
            // 
            // TxtProductName
            // 
            this.TxtProductName.Location = new System.Drawing.Point(180, 30);
            this.TxtProductName.Name = "TxtProductName";
            this.TxtProductName.Size = new System.Drawing.Size(163, 30);
            this.TxtProductName.TabIndex = 13;
            // 
            // LblProductName
            // 
            this.LblProductName.AutoSize = true;
            this.LblProductName.Location = new System.Drawing.Point(6, 35);
            this.LblProductName.Name = "LblProductName";
            this.LblProductName.Size = new System.Drawing.Size(142, 25);
            this.LblProductName.TabIndex = 12;
            this.LblProductName.Text = "Product Name:";
            // 
            // LblStock
            // 
            this.LblStock.AutoSize = true;
            this.LblStock.Location = new System.Drawing.Point(6, 90);
            this.LblStock.Name = "LblStock";
            this.LblStock.Size = new System.Drawing.Size(68, 25);
            this.LblStock.TabIndex = 14;
            this.LblStock.Text = "Stock:";
            // 
            // TxtBuyingPrice
            // 
            this.TxtBuyingPrice.Location = new System.Drawing.Point(180, 140);
            this.TxtBuyingPrice.Name = "TxtBuyingPrice";
            this.TxtBuyingPrice.Size = new System.Drawing.Size(163, 30);
            this.TxtBuyingPrice.TabIndex = 17;
            this.TxtBuyingPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuyingPrice_KeyPress);
            // 
            // LblBuyingPrice
            // 
            this.LblBuyingPrice.AutoSize = true;
            this.LblBuyingPrice.Location = new System.Drawing.Point(6, 145);
            this.LblBuyingPrice.Name = "LblBuyingPrice";
            this.LblBuyingPrice.Size = new System.Drawing.Size(127, 25);
            this.LblBuyingPrice.TabIndex = 16;
            this.LblBuyingPrice.Text = "Buying Price:";
            // 
            // TxtSellingPrice
            // 
            this.TxtSellingPrice.Location = new System.Drawing.Point(180, 195);
            this.TxtSellingPrice.Name = "TxtSellingPrice";
            this.TxtSellingPrice.Size = new System.Drawing.Size(163, 30);
            this.TxtSellingPrice.TabIndex = 19;
            this.TxtSellingPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSellingPrice_KeyPress);
            // 
            // LblSellingPrice
            // 
            this.LblSellingPrice.AutoSize = true;
            this.LblSellingPrice.Location = new System.Drawing.Point(6, 200);
            this.LblSellingPrice.Name = "LblSellingPrice";
            this.LblSellingPrice.Size = new System.Drawing.Size(126, 25);
            this.LblSellingPrice.TabIndex = 18;
            this.LblSellingPrice.Text = "Selling Price:";
            // 
            // LblCategory
            // 
            this.LblCategory.AutoSize = true;
            this.LblCategory.Location = new System.Drawing.Point(6, 255);
            this.LblCategory.Name = "LblCategory";
            this.LblCategory.Size = new System.Drawing.Size(155, 25);
            this.LblCategory.TabIndex = 20;
            this.LblCategory.Text = "Category Name:";
            // 
            // CmbCategory
            // 
            this.CmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCategory.FormattingEnabled = true;
            this.CmbCategory.Location = new System.Drawing.Point(180, 255);
            this.CmbCategory.Name = "CmbCategory";
            this.CmbCategory.Size = new System.Drawing.Size(163, 33);
            this.CmbCategory.TabIndex = 21;
            // 
            // NUDStock
            // 
            this.NUDStock.Location = new System.Drawing.Point(180, 88);
            this.NUDStock.Name = "NUDStock";
            this.NUDStock.Size = new System.Drawing.Size(163, 30);
            this.NUDStock.TabIndex = 23;
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1095, 754);
            this.Controls.Add(this.GBTransitions);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmProduct";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GBTransitions.ResumeLayout(false);
            this.GBTransitions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnList;
        private System.Windows.Forms.GroupBox GBTransitions;
        private System.Windows.Forms.Label LblCategory;
        private System.Windows.Forms.TextBox TxtSellingPrice;
        private System.Windows.Forms.Label LblSellingPrice;
        private System.Windows.Forms.TextBox TxtBuyingPrice;
        private System.Windows.Forms.Label LblBuyingPrice;
        private System.Windows.Forms.Label LblStock;
        private System.Windows.Forms.TextBox TxtProductName;
        private System.Windows.Forms.Label LblProductName;
        private System.Windows.Forms.NumericUpDown NUDStock;
        private System.Windows.Forms.ComboBox CmbCategory;
    }
}