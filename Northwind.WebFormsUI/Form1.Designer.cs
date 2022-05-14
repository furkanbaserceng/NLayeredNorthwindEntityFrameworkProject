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
            this.cbxProductCategoryAdd = new System.Windows.Forms.ComboBox();
            this.tbxProductQuantityPerUnitAdd = new System.Windows.Forms.TextBox();
            this.lblQuantityPerUnitAdd = new System.Windows.Forms.Label();
            this.tbxProductUnitsInStockAdd = new System.Windows.Forms.TextBox();
            this.lblStockAmountAdd = new System.Windows.Forms.Label();
            this.lblCategoryAdd = new System.Windows.Forms.Label();
            this.tbxProductUnitPriceAdd = new System.Windows.Forms.TextBox();
            this.lblUnitPriceAdd = new System.Windows.Forms.Label();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.tbxProductNameAdd = new System.Windows.Forms.TextBox();
            this.lblProductNameAdd = new System.Windows.Forms.Label();
            this.gbxUpdateOrDeleteProduct = new System.Windows.Forms.GroupBox();
            this.btnProductDelete = new System.Windows.Forms.Button();
            this.cbxProductCategoryUpdate = new System.Windows.Forms.ComboBox();
            this.tbxProductNameUpdate = new System.Windows.Forms.TextBox();
            this.tbxProductQuantityPerUnitUpdate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProductUpdate = new System.Windows.Forms.Button();
            this.tbxProductUnitsInStockUpdate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxProductUnitPriceUpdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxListByCategory = new System.Windows.Forms.GroupBox();
            this.lblCategories = new System.Windows.Forms.Label();
            this.cbxListCategories = new System.Windows.Forms.ComboBox();
            this.gbxSearchByProductName = new System.Windows.Forms.GroupBox();
            this.tbxSearchProductName = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.gbxAddProduct.SuspendLayout();
            this.gbxUpdateOrDeleteProduct.SuspendLayout();
            this.gbxListByCategory.SuspendLayout();
            this.gbxSearchByProductName.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProducts
            // 
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(17, 219);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.RowTemplate.Height = 25;
            this.dgwProducts.Size = new System.Drawing.Size(894, 269);
            this.dgwProducts.TabIndex = 0;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
            // 
            // gbxAddProduct
            // 
            this.gbxAddProduct.Controls.Add(this.cbxProductCategoryAdd);
            this.gbxAddProduct.Controls.Add(this.tbxProductQuantityPerUnitAdd);
            this.gbxAddProduct.Controls.Add(this.lblQuantityPerUnitAdd);
            this.gbxAddProduct.Controls.Add(this.tbxProductUnitsInStockAdd);
            this.gbxAddProduct.Controls.Add(this.lblStockAmountAdd);
            this.gbxAddProduct.Controls.Add(this.lblCategoryAdd);
            this.gbxAddProduct.Controls.Add(this.tbxProductUnitPriceAdd);
            this.gbxAddProduct.Controls.Add(this.lblUnitPriceAdd);
            this.gbxAddProduct.Controls.Add(this.btnProductAdd);
            this.gbxAddProduct.Controls.Add(this.tbxProductNameAdd);
            this.gbxAddProduct.Controls.Add(this.lblProductNameAdd);
            this.gbxAddProduct.Location = new System.Drawing.Point(17, 12);
            this.gbxAddProduct.Name = "gbxAddProduct";
            this.gbxAddProduct.Size = new System.Drawing.Size(289, 201);
            this.gbxAddProduct.TabIndex = 1;
            this.gbxAddProduct.TabStop = false;
            this.gbxAddProduct.Text = "Add Product";
            // 
            // cbxProductCategoryAdd
            // 
            this.cbxProductCategoryAdd.FormattingEnabled = true;
            this.cbxProductCategoryAdd.Location = new System.Drawing.Point(106, 49);
            this.cbxProductCategoryAdd.Name = "cbxProductCategoryAdd";
            this.cbxProductCategoryAdd.Size = new System.Drawing.Size(177, 23);
            this.cbxProductCategoryAdd.TabIndex = 5;
            // 
            // tbxProductQuantityPerUnitAdd
            // 
            this.tbxProductQuantityPerUnitAdd.Location = new System.Drawing.Point(106, 139);
            this.tbxProductQuantityPerUnitAdd.Name = "tbxProductQuantityPerUnitAdd";
            this.tbxProductQuantityPerUnitAdd.Size = new System.Drawing.Size(177, 23);
            this.tbxProductQuantityPerUnitAdd.TabIndex = 11;
            // 
            // lblQuantityPerUnitAdd
            // 
            this.lblQuantityPerUnitAdd.AutoSize = true;
            this.lblQuantityPerUnitAdd.Location = new System.Drawing.Point(-1, 142);
            this.lblQuantityPerUnitAdd.Name = "lblQuantityPerUnitAdd";
            this.lblQuantityPerUnitAdd.Size = new System.Drawing.Size(101, 15);
            this.lblQuantityPerUnitAdd.TabIndex = 10;
            this.lblQuantityPerUnitAdd.Text = "Quantity Per Unit:";
            // 
            // tbxProductUnitsInStockAdd
            // 
            this.tbxProductUnitsInStockAdd.Location = new System.Drawing.Point(106, 107);
            this.tbxProductUnitsInStockAdd.Name = "tbxProductUnitsInStockAdd";
            this.tbxProductUnitsInStockAdd.Size = new System.Drawing.Size(177, 23);
            this.tbxProductUnitsInStockAdd.TabIndex = 9;
            // 
            // lblStockAmountAdd
            // 
            this.lblStockAmountAdd.AutoSize = true;
            this.lblStockAmountAdd.Location = new System.Drawing.Point(14, 110);
            this.lblStockAmountAdd.Name = "lblStockAmountAdd";
            this.lblStockAmountAdd.Size = new System.Drawing.Size(86, 15);
            this.lblStockAmountAdd.TabIndex = 8;
            this.lblStockAmountAdd.Text = "Stock Amount:";
            // 
            // lblCategoryAdd
            // 
            this.lblCategoryAdd.AutoSize = true;
            this.lblCategoryAdd.Location = new System.Drawing.Point(42, 52);
            this.lblCategoryAdd.Name = "lblCategoryAdd";
            this.lblCategoryAdd.Size = new System.Drawing.Size(58, 15);
            this.lblCategoryAdd.TabIndex = 6;
            this.lblCategoryAdd.Text = "Category:";
            // 
            // tbxProductUnitPriceAdd
            // 
            this.tbxProductUnitPriceAdd.Location = new System.Drawing.Point(106, 78);
            this.tbxProductUnitPriceAdd.Name = "tbxProductUnitPriceAdd";
            this.tbxProductUnitPriceAdd.Size = new System.Drawing.Size(177, 23);
            this.tbxProductUnitPriceAdd.TabIndex = 5;
            // 
            // lblUnitPriceAdd
            // 
            this.lblUnitPriceAdd.AutoSize = true;
            this.lblUnitPriceAdd.Location = new System.Drawing.Point(39, 81);
            this.lblUnitPriceAdd.Name = "lblUnitPriceAdd";
            this.lblUnitPriceAdd.Size = new System.Drawing.Size(61, 15);
            this.lblUnitPriceAdd.TabIndex = 4;
            this.lblUnitPriceAdd.Text = "Unit Price:";
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Location = new System.Drawing.Point(106, 167);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(75, 27);
            this.btnProductAdd.TabIndex = 3;
            this.btnProductAdd.Text = "Add";
            this.btnProductAdd.UseVisualStyleBackColor = true;
            this.btnProductAdd.Click += new System.EventHandler(this.btnProductAdd_Click);
            // 
            // tbxProductNameAdd
            // 
            this.tbxProductNameAdd.Location = new System.Drawing.Point(106, 22);
            this.tbxProductNameAdd.Name = "tbxProductNameAdd";
            this.tbxProductNameAdd.Size = new System.Drawing.Size(177, 23);
            this.tbxProductNameAdd.TabIndex = 1;
            // 
            // lblProductNameAdd
            // 
            this.lblProductNameAdd.AutoSize = true;
            this.lblProductNameAdd.Location = new System.Drawing.Point(13, 25);
            this.lblProductNameAdd.Name = "lblProductNameAdd";
            this.lblProductNameAdd.Size = new System.Drawing.Size(87, 15);
            this.lblProductNameAdd.TabIndex = 0;
            this.lblProductNameAdd.Text = "Product Name:";
            // 
            // gbxUpdateOrDeleteProduct
            // 
            this.gbxUpdateOrDeleteProduct.Controls.Add(this.btnProductDelete);
            this.gbxUpdateOrDeleteProduct.Controls.Add(this.cbxProductCategoryUpdate);
            this.gbxUpdateOrDeleteProduct.Controls.Add(this.tbxProductNameUpdate);
            this.gbxUpdateOrDeleteProduct.Controls.Add(this.tbxProductQuantityPerUnitUpdate);
            this.gbxUpdateOrDeleteProduct.Controls.Add(this.label5);
            this.gbxUpdateOrDeleteProduct.Controls.Add(this.label1);
            this.gbxUpdateOrDeleteProduct.Controls.Add(this.btnProductUpdate);
            this.gbxUpdateOrDeleteProduct.Controls.Add(this.tbxProductUnitsInStockUpdate);
            this.gbxUpdateOrDeleteProduct.Controls.Add(this.label4);
            this.gbxUpdateOrDeleteProduct.Controls.Add(this.label2);
            this.gbxUpdateOrDeleteProduct.Controls.Add(this.tbxProductUnitPriceUpdate);
            this.gbxUpdateOrDeleteProduct.Controls.Add(this.label3);
            this.gbxUpdateOrDeleteProduct.Location = new System.Drawing.Point(322, 12);
            this.gbxUpdateOrDeleteProduct.Name = "gbxUpdateOrDeleteProduct";
            this.gbxUpdateOrDeleteProduct.Size = new System.Drawing.Size(289, 201);
            this.gbxUpdateOrDeleteProduct.TabIndex = 2;
            this.gbxUpdateOrDeleteProduct.TabStop = false;
            this.gbxUpdateOrDeleteProduct.Text = "Update/Delete Product";
            // 
            // btnProductDelete
            // 
            this.btnProductDelete.Location = new System.Drawing.Point(208, 167);
            this.btnProductDelete.Name = "btnProductDelete";
            this.btnProductDelete.Size = new System.Drawing.Size(75, 27);
            this.btnProductDelete.TabIndex = 23;
            this.btnProductDelete.Text = "Delete";
            this.btnProductDelete.UseVisualStyleBackColor = true;
            this.btnProductDelete.Click += new System.EventHandler(this.btnProductDelete_Click);
            // 
            // cbxProductCategoryUpdate
            // 
            this.cbxProductCategoryUpdate.FormattingEnabled = true;
            this.cbxProductCategoryUpdate.Location = new System.Drawing.Point(106, 49);
            this.cbxProductCategoryUpdate.Name = "cbxProductCategoryUpdate";
            this.cbxProductCategoryUpdate.Size = new System.Drawing.Size(177, 23);
            this.cbxProductCategoryUpdate.TabIndex = 16;
            // 
            // tbxProductNameUpdate
            // 
            this.tbxProductNameUpdate.Location = new System.Drawing.Point(106, 22);
            this.tbxProductNameUpdate.Name = "tbxProductNameUpdate";
            this.tbxProductNameUpdate.Size = new System.Drawing.Size(177, 23);
            this.tbxProductNameUpdate.TabIndex = 13;
            // 
            // tbxProductQuantityPerUnitUpdate
            // 
            this.tbxProductQuantityPerUnitUpdate.Location = new System.Drawing.Point(106, 139);
            this.tbxProductQuantityPerUnitUpdate.Name = "tbxProductQuantityPerUnitUpdate";
            this.tbxProductQuantityPerUnitUpdate.Size = new System.Drawing.Size(177, 23);
            this.tbxProductQuantityPerUnitUpdate.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Product Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Quantity Per Unit:";
            // 
            // btnProductUpdate
            // 
            this.btnProductUpdate.Location = new System.Drawing.Point(106, 167);
            this.btnProductUpdate.Name = "btnProductUpdate";
            this.btnProductUpdate.Size = new System.Drawing.Size(75, 27);
            this.btnProductUpdate.TabIndex = 14;
            this.btnProductUpdate.Text = "Update";
            this.btnProductUpdate.UseVisualStyleBackColor = true;
            this.btnProductUpdate.Click += new System.EventHandler(this.btnProductUpdate_Click);
            // 
            // tbxProductUnitsInStockUpdate
            // 
            this.tbxProductUnitsInStockUpdate.Location = new System.Drawing.Point(106, 107);
            this.tbxProductUnitsInStockUpdate.Name = "tbxProductUnitsInStockUpdate";
            this.tbxProductUnitsInStockUpdate.Size = new System.Drawing.Size(177, 23);
            this.tbxProductUnitsInStockUpdate.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Unit Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Stock Amount:";
            // 
            // tbxProductUnitPriceUpdate
            // 
            this.tbxProductUnitPriceUpdate.Location = new System.Drawing.Point(106, 78);
            this.tbxProductUnitPriceUpdate.Name = "tbxProductUnitPriceUpdate";
            this.tbxProductUnitPriceUpdate.Size = new System.Drawing.Size(177, 23);
            this.tbxProductUnitPriceUpdate.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Category:";
            // 
            // gbxListByCategory
            // 
            this.gbxListByCategory.Controls.Add(this.lblCategories);
            this.gbxListByCategory.Controls.Add(this.cbxListCategories);
            this.gbxListByCategory.Location = new System.Drawing.Point(622, 26);
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
            this.gbxSearchByProductName.Location = new System.Drawing.Point(622, 119);
            this.gbxSearchByProductName.Name = "gbxSearchByProductName";
            this.gbxSearchByProductName.Size = new System.Drawing.Size(289, 87);
            this.gbxSearchByProductName.TabIndex = 4;
            this.gbxSearchByProductName.TabStop = false;
            this.gbxSearchByProductName.Text = "Search Product";
            // 
            // tbxSearchProductName
            // 
            this.tbxSearchProductName.Location = new System.Drawing.Point(97, 32);
            this.tbxSearchProductName.Name = "tbxSearchProductName";
            this.tbxSearchProductName.Size = new System.Drawing.Size(186, 23);
            this.tbxSearchProductName.TabIndex = 4;
            this.tbxSearchProductName.TextChanged += new System.EventHandler(this.tbxSearchProductName_TextChanged);
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
            this.gbxUpdateOrDeleteProduct.ResumeLayout(false);
            this.gbxUpdateOrDeleteProduct.PerformLayout();
            this.gbxListByCategory.ResumeLayout(false);
            this.gbxListByCategory.PerformLayout();
            this.gbxSearchByProductName.ResumeLayout(false);
            this.gbxSearchByProductName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgwProducts;
        private GroupBox gbxAddProduct;
        private Button btnProductAdd;
        private TextBox tbxProductNameAdd;
        private Label lblProductNameAdd;
        private GroupBox gbxUpdateOrDeleteProduct;
        private GroupBox gbxListByCategory;
        private ComboBox cbxListCategories;
        private GroupBox gbxSearchByProductName;
        private Label lblCategories;
        private TextBox tbxSearchProductName;
        private Label lblSearch;
        private ComboBox cbxProductCategoryAdd;
        private TextBox tbxProductQuantityPerUnitAdd;
        private Label lblQuantityPerUnitAdd;
        private TextBox tbxProductUnitsInStockAdd;
        private Label lblStockAmountAdd;
        private Label lblCategoryAdd;
        private TextBox tbxProductUnitPriceAdd;
        private Label lblUnitPriceAdd;
        private Button btnProductDelete;
        private ComboBox cbxProductCategoryUpdate;
        private TextBox tbxProductNameUpdate;
        private TextBox tbxProductQuantityPerUnitUpdate;
        private Label label5;
        private Label label1;
        private Button btnProductUpdate;
        private TextBox tbxProductUnitsInStockUpdate;
        private Label label4;
        private Label label2;
        private TextBox tbxProductUnitPriceUpdate;
        private Label label3;
    }
}