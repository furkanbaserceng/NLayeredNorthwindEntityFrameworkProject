namespace Northwind.WebFormsUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.gbxAddProduct = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxUpdateOrDeleteProduct = new System.Windows.Forms.GroupBox();
            this.gbxListByCategory = new System.Windows.Forms.GroupBox();
            this.lblCategories = new System.Windows.Forms.Label();
            this.cbxListCategories = new System.Windows.Forms.ComboBox();
            this.gbxSearchByProductName = new System.Windows.Forms.GroupBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbxSearchProductName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.gbxAddProduct.SuspendLayout();
            this.gbxListByCategory.SuspendLayout();
            this.gbxSearchByProductName.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProducts
            // 
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(17, 203);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.RowTemplate.Height = 25;
            this.dgwProducts.Size = new System.Drawing.Size(894, 285);
            this.dgwProducts.TabIndex = 0;
            // 
            // gbxAddProduct
            // 
            this.gbxAddProduct.Controls.Add(this.button1);
            this.gbxAddProduct.Controls.Add(this.textBox1);
            this.gbxAddProduct.Controls.Add(this.label1);
            this.gbxAddProduct.Location = new System.Drawing.Point(17, 12);
            this.gbxAddProduct.Name = "gbxAddProduct";
            this.gbxAddProduct.Size = new System.Drawing.Size(289, 185);
            this.gbxAddProduct.TabIndex = 1;
            this.gbxAddProduct.TabStop = false;
            this.gbxAddProduct.Text = "Add Product";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // gbxUpdateOrDeleteProduct
            // 
            this.gbxUpdateOrDeleteProduct.Location = new System.Drawing.Point(322, 12);
            this.gbxUpdateOrDeleteProduct.Name = "gbxUpdateOrDeleteProduct";
            this.gbxUpdateOrDeleteProduct.Size = new System.Drawing.Size(289, 185);
            this.gbxUpdateOrDeleteProduct.TabIndex = 2;
            this.gbxUpdateOrDeleteProduct.TabStop = false;
            this.gbxUpdateOrDeleteProduct.Text = "Update/Delete Product";
            // 
            // gbxListByCategory
            // 
            this.gbxListByCategory.Controls.Add(this.lblCategories);
            this.gbxListByCategory.Controls.Add(this.cbxListCategories);
            this.gbxListByCategory.Location = new System.Drawing.Point(622, 12);
            this.gbxListByCategory.Name = "gbxListByCategory";
            this.gbxListByCategory.Size = new System.Drawing.Size(289, 87);
            this.gbxListByCategory.TabIndex = 3;
            this.gbxListByCategory.TabStop = false;
            this.gbxListByCategory.Text = "List By Category";
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Location = new System.Drawing.Point(25, 39);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(66, 15);
            this.lblCategories.TabIndex = 4;
            this.lblCategories.Text = "Categories:";
            // 
            // cbxListCategories
            // 
            this.cbxListCategories.FormattingEnabled = true;
            this.cbxListCategories.Location = new System.Drawing.Point(97, 37);
            this.cbxListCategories.Name = "cbxListCategories";
            this.cbxListCategories.Size = new System.Drawing.Size(186, 23);
            this.cbxListCategories.TabIndex = 2;
            this.cbxListCategories.SelectedIndexChanged += new System.EventHandler(this.cbxListCategories_SelectedIndexChanged);
            // 
            // gbxSearchByProductName
            // 
            this.gbxSearchByProductName.Controls.Add(this.tbxSearchProductName);
            this.gbxSearchByProductName.Controls.Add(this.lblSearch);
            this.gbxSearchByProductName.Location = new System.Drawing.Point(622, 110);
            this.gbxSearchByProductName.Name = "gbxSearchByProductName";
            this.gbxSearchByProductName.Size = new System.Drawing.Size(289, 87);
            this.gbxSearchByProductName.TabIndex = 4;
            this.gbxSearchByProductName.TabStop = false;
            this.gbxSearchByProductName.Text = "Search Product";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(46, 35);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(45, 15);
            this.lblSearch.TabIndex = 5;
            this.lblSearch.Text = "Search:";
            // 
            // tbxSearchProductName
            // 
            this.tbxSearchProductName.Location = new System.Drawing.Point(97, 32);
            this.tbxSearchProductName.Name = "tbxSearchProductName";
            this.tbxSearchProductName.Size = new System.Drawing.Size(186, 23);
            this.tbxSearchProductName.TabIndex = 4;
            this.tbxSearchProductName.TextChanged += new System.EventHandler(this.tbxSearchProductName_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 500);
            this.Controls.Add(this.gbxSearchByProductName);
            this.Controls.Add(this.gbxListByCategory);
            this.Controls.Add(this.gbxUpdateOrDeleteProduct);
            this.Controls.Add(this.gbxAddProduct);
            this.Controls.Add(this.dgwProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.gbxAddProduct.ResumeLayout(false);
            this.gbxAddProduct.PerformLayout();
            this.gbxListByCategory.ResumeLayout(false);
            this.gbxListByCategory.PerformLayout();
            this.gbxSearchByProductName.ResumeLayout(false);
            this.gbxSearchByProductName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgwProducts;
        private GroupBox gbxAddProduct;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private GroupBox gbxUpdateOrDeleteProduct;
        private GroupBox gbxListByCategory;
        private ComboBox cbxListCategories;
        private GroupBox gbxSearchByProductName;
        private Label lblCategories;
        private TextBox tbxSearchProductName;
        private Label lblSearch;
    }
}