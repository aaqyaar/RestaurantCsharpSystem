namespace RestaurantCsharpSystem
{
    partial class frmProducts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menusPanel = new System.Windows.Forms.Panel();
            this.payroll_menu = new System.Windows.Forms.Button();
            this.products_menu = new System.Windows.Forms.Button();
            this.orders_menu = new System.Windows.Forms.Button();
            this.employees_menu = new System.Windows.Forms.Button();
            this.user_menu = new System.Windows.Forms.Button();
            this.dashboard_menu = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductCategory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductQty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductCost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.productsGridView = new System.Windows.Forms.DataGridView();
            this.btnCreateProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnListProducts = new System.Windows.Forms.Button();
            this.btnDelProduct = new System.Windows.Forms.Button();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.menusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menusPanel
            // 
            this.menusPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menusPanel.Controls.Add(this.payroll_menu);
            this.menusPanel.Controls.Add(this.products_menu);
            this.menusPanel.Controls.Add(this.orders_menu);
            this.menusPanel.Controls.Add(this.employees_menu);
            this.menusPanel.Controls.Add(this.user_menu);
            this.menusPanel.Controls.Add(this.dashboard_menu);
            this.menusPanel.Controls.Add(this.pictureBox4);
            this.menusPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menusPanel.Font = new System.Drawing.Font("Inter", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menusPanel.Location = new System.Drawing.Point(0, 0);
            this.menusPanel.Name = "menusPanel";
            this.menusPanel.Size = new System.Drawing.Size(200, 598);
            this.menusPanel.TabIndex = 4;
            // 
            // payroll_menu
            // 
            this.payroll_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.payroll_menu.FlatAppearance.BorderSize = 0;
            this.payroll_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payroll_menu.Font = new System.Drawing.Font("Inter", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payroll_menu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.payroll_menu.Image = global::RestaurantCsharpSystem.Properties.Resources.payroll1;
            this.payroll_menu.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.payroll_menu.Location = new System.Drawing.Point(11, 429);
            this.payroll_menu.Name = "payroll_menu";
            this.payroll_menu.Size = new System.Drawing.Size(188, 36);
            this.payroll_menu.TabIndex = 5;
            this.payroll_menu.Text = "Payroll";
            this.payroll_menu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.payroll_menu.UseVisualStyleBackColor = false;
            this.payroll_menu.Click += new System.EventHandler(this.payroll_menu_Click);
            // 
            // products_menu
            // 
            this.products_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.products_menu.FlatAppearance.BorderSize = 0;
            this.products_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.products_menu.Font = new System.Drawing.Font("Inter", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.products_menu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.products_menu.Image = global::RestaurantCsharpSystem.Properties.Resources.products_icon;
            this.products_menu.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.products_menu.Location = new System.Drawing.Point(11, 258);
            this.products_menu.Name = "products_menu";
            this.products_menu.Size = new System.Drawing.Size(188, 36);
            this.products_menu.TabIndex = 2;
            this.products_menu.Text = "Products";
            this.products_menu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.products_menu.UseVisualStyleBackColor = false;
            // 
            // orders_menu
            // 
            this.orders_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.orders_menu.FlatAppearance.BorderSize = 0;
            this.orders_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orders_menu.Font = new System.Drawing.Font("Inter", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_menu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.orders_menu.Image = global::RestaurantCsharpSystem.Properties.Resources.orders_icon;
            this.orders_menu.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.orders_menu.Location = new System.Drawing.Point(11, 316);
            this.orders_menu.Name = "orders_menu";
            this.orders_menu.Size = new System.Drawing.Size(162, 36);
            this.orders_menu.TabIndex = 2;
            this.orders_menu.Text = "Orders";
            this.orders_menu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.orders_menu.UseVisualStyleBackColor = false;
            this.orders_menu.Click += new System.EventHandler(this.orders_menu_Click);
            // 
            // employees_menu
            // 
            this.employees_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.employees_menu.FlatAppearance.BorderSize = 0;
            this.employees_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employees_menu.Font = new System.Drawing.Font("Inter", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employees_menu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.employees_menu.Image = global::RestaurantCsharpSystem.Properties.Resources.employees;
            this.employees_menu.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.employees_menu.Location = new System.Drawing.Point(11, 376);
            this.employees_menu.Name = "employees_menu";
            this.employees_menu.Size = new System.Drawing.Size(217, 36);
            this.employees_menu.TabIndex = 2;
            this.employees_menu.Text = "Employees";
            this.employees_menu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.employees_menu.UseVisualStyleBackColor = false;
            this.employees_menu.Click += new System.EventHandler(this.employees_menu_Click);
            // 
            // user_menu
            // 
            this.user_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.user_menu.FlatAppearance.BorderSize = 0;
            this.user_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.user_menu.Font = new System.Drawing.Font("Inter", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_menu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.user_menu.Image = global::RestaurantCsharpSystem.Properties.Resources.users;
            this.user_menu.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.user_menu.Location = new System.Drawing.Point(11, 199);
            this.user_menu.Name = "user_menu";
            this.user_menu.Size = new System.Drawing.Size(162, 36);
            this.user_menu.TabIndex = 2;
            this.user_menu.Text = "Users";
            this.user_menu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.user_menu.UseVisualStyleBackColor = false;
            this.user_menu.Click += new System.EventHandler(this.user_menu_Click);
            // 
            // dashboard_menu
            // 
            this.dashboard_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.dashboard_menu.FlatAppearance.BorderSize = 0;
            this.dashboard_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_menu.Font = new System.Drawing.Font("Inter", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_menu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dashboard_menu.Image = global::RestaurantCsharpSystem.Properties.Resources.dashboard2;
            this.dashboard_menu.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.dashboard_menu.Location = new System.Drawing.Point(11, 144);
            this.dashboard_menu.Name = "dashboard_menu";
            this.dashboard_menu.Size = new System.Drawing.Size(212, 38);
            this.dashboard_menu.TabIndex = 2;
            this.dashboard_menu.Text = "Dashboard";
            this.dashboard_menu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dashboard_menu.UseVisualStyleBackColor = false;
            this.dashboard_menu.Click += new System.EventHandler(this.dashboard_menu_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::RestaurantCsharpSystem.Properties.Resources.juliana_s_ilvia__1_;
            this.pictureBox4.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(200, 139);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Product Name";
            // 
            // txtProductName
            // 
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductName.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(229, 219);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(333, 32);
            this.txtProductName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(225, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Product Category";
            // 
            // txtProductCategory
            // 
            this.txtProductCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductCategory.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductCategory.Location = new System.Drawing.Point(229, 291);
            this.txtProductCategory.Name = "txtProductCategory";
            this.txtProductCategory.Size = new System.Drawing.Size(333, 32);
            this.txtProductCategory.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(225, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Product Quantity";
            // 
            // txtProductQty
            // 
            this.txtProductQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductQty.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductQty.Location = new System.Drawing.Point(229, 361);
            this.txtProductQty.Name = "txtProductQty";
            this.txtProductQty.Size = new System.Drawing.Size(333, 32);
            this.txtProductQty.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(225, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Product Cost";
            // 
            // txtProductCost
            // 
            this.txtProductCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductCost.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductCost.Location = new System.Drawing.Point(229, 428);
            this.txtProductCost.Name = "txtProductCost";
            this.txtProductCost.Size = new System.Drawing.Size(333, 32);
            this.txtProductCost.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(225, 466);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Product Price";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductPrice.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductPrice.Location = new System.Drawing.Point(229, 498);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(333, 32);
            this.txtProductPrice.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(225, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Product Id";
            // 
            // txtProductId
            // 
            this.txtProductId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductId.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductId.Location = new System.Drawing.Point(229, 147);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(333, 32);
            this.txtProductId.TabIndex = 5;
            // 
            // productsGridView
            // 
            this.productsGridView.AllowUserToAddRows = false;
            this.productsGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.productsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.productsGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.productsGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Inter", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.productsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Inter", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productsGridView.DefaultCellStyle = dataGridViewCellStyle11;
            this.productsGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.productsGridView.Location = new System.Drawing.Point(682, 74);
            this.productsGridView.Name = "productsGridView";
            this.productsGridView.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Inter", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.productsGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.productsGridView.RowTemplate.Height = 24;
            this.productsGridView.Size = new System.Drawing.Size(665, 425);
            this.productsGridView.TabIndex = 9;
            this.productsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsGridView_CellContentClick);
            // 
            // btnCreateProduct
            // 
            this.btnCreateProduct.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateProduct.ForeColor = System.Drawing.Color.Black;
            this.btnCreateProduct.Location = new System.Drawing.Point(682, 505);
            this.btnCreateProduct.Name = "btnCreateProduct";
            this.btnCreateProduct.Size = new System.Drawing.Size(124, 46);
            this.btnCreateProduct.TabIndex = 13;
            this.btnCreateProduct.Text = "Register";
            this.btnCreateProduct.UseVisualStyleBackColor = true;
            this.btnCreateProduct.Click += new System.EventHandler(this.btnCreateProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProduct.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateProduct.Location = new System.Drawing.Point(865, 504);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(124, 46);
            this.btnUpdateProduct.TabIndex = 6;
            this.btnUpdateProduct.Text = "Update";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnListProducts
            // 
            this.btnListProducts.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListProducts.ForeColor = System.Drawing.Color.Black;
            this.btnListProducts.Location = new System.Drawing.Point(1034, 504);
            this.btnListProducts.Name = "btnListProducts";
            this.btnListProducts.Size = new System.Drawing.Size(124, 46);
            this.btnListProducts.TabIndex = 7;
            this.btnListProducts.Text = "Refresh";
            this.btnListProducts.UseVisualStyleBackColor = true;
            this.btnListProducts.Click += new System.EventHandler(this.btnListProducts_Click);
            // 
            // btnDelProduct
            // 
            this.btnDelProduct.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelProduct.ForeColor = System.Drawing.Color.Black;
            this.btnDelProduct.Location = new System.Drawing.Point(1223, 505);
            this.btnDelProduct.Name = "btnDelProduct";
            this.btnDelProduct.Size = new System.Drawing.Size(124, 46);
            this.btnDelProduct.TabIndex = 8;
            this.btnDelProduct.Text = "Delete";
            this.btnDelProduct.UseVisualStyleBackColor = true;
            this.btnDelProduct.Click += new System.EventHandler(this.btnDelProduct_Click);
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Public Sans SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.Location = new System.Drawing.Point(222, 30);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(262, 39);
            this.lblDashboard.TabIndex = 14;
            this.lblDashboard.Text = "Products Directory";
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchProduct.Font = new System.Drawing.Font("Inter", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchProduct.Location = new System.Drawing.Point(1014, 28);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(333, 40);
            this.txtSearchProduct.TabIndex = 5;
            this.txtSearchProduct.TextChanged += new System.EventHandler(this.txtSearchProduct_TextChanged);
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1382, 598);
            this.Controls.Add(this.lblDashboard);
            this.Controls.Add(this.btnDelProduct);
            this.Controls.Add(this.btnListProducts);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.btnCreateProduct);
            this.Controls.Add(this.productsGridView);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProductCost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProductQty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProductCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearchProduct);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menusPanel);
            this.Font = new System.Drawing.Font("Inter", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.Name = "frmProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmProducts_Load);
            this.menusPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel menusPanel;
        private System.Windows.Forms.Button payroll_menu;
        private System.Windows.Forms.Button products_menu;
        private System.Windows.Forms.Button orders_menu;
        private System.Windows.Forms.Button employees_menu;
        private System.Windows.Forms.Button user_menu;
        private System.Windows.Forms.Button dashboard_menu;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProductCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.DataGridView productsGridView;
        private System.Windows.Forms.Button btnCreateProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnListProducts;
        private System.Windows.Forms.Button btnDelProduct;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.TextBox txtSearchProduct;
    }
}