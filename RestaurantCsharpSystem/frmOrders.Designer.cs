namespace RestaurantCsharpSystem
{
    partial class frmOrders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menusPanel = new System.Windows.Forms.Panel();
            this.payroll_menu = new System.Windows.Forms.Button();
            this.products_menu = new System.Windows.Forms.Button();
            this.orders_menu = new System.Windows.Forms.Button();
            this.employees_menu = new System.Windows.Forms.Button();
            this.user_menu = new System.Windows.Forms.Button();
            this.dashboard_menu = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.btnDelOrder = new System.Windows.Forms.Button();
            this.btnListOrders = new System.Windows.Forms.Button();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.ordersGridView = new System.Windows.Forms.DataGridView();
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOrderDiscount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOrderQty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchOrder = new System.Windows.Forms.TextBox();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOrderItems = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbOrderRefEmployee = new System.Windows.Forms.ComboBox();
            this.menusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).BeginInit();
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
            this.menusPanel.TabIndex = 5;
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
            this.payroll_menu.TabIndex = 2;
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
            this.products_menu.Click += new System.EventHandler(this.products_menu_Click);
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
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Public Sans SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.Location = new System.Drawing.Point(223, 42);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(235, 39);
            this.lblDashboard.TabIndex = 50;
            this.lblDashboard.Text = "Orders Directory";
            // 
            // btnDelOrder
            // 
            this.btnDelOrder.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelOrder.ForeColor = System.Drawing.Color.Black;
            this.btnDelOrder.Location = new System.Drawing.Point(1224, 517);
            this.btnDelOrder.Name = "btnDelOrder";
            this.btnDelOrder.Size = new System.Drawing.Size(124, 46);
            this.btnDelOrder.TabIndex = 47;
            this.btnDelOrder.Text = "Delete";
            this.btnDelOrder.UseVisualStyleBackColor = true;
            // 
            // btnListOrders
            // 
            this.btnListOrders.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListOrders.ForeColor = System.Drawing.Color.Black;
            this.btnListOrders.Location = new System.Drawing.Point(1035, 516);
            this.btnListOrders.Name = "btnListOrders";
            this.btnListOrders.Size = new System.Drawing.Size(124, 46);
            this.btnListOrders.TabIndex = 45;
            this.btnListOrders.Text = "Refresh";
            this.btnListOrders.UseVisualStyleBackColor = true;
            this.btnListOrders.Click += new System.EventHandler(this.btnListOrders_Click);
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateOrder.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateOrder.Location = new System.Drawing.Point(866, 516);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(124, 46);
            this.btnUpdateOrder.TabIndex = 40;
            this.btnUpdateOrder.Text = "Update";
            this.btnUpdateOrder.UseVisualStyleBackColor = true;
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateOrder.ForeColor = System.Drawing.Color.Black;
            this.btnCreateOrder.Location = new System.Drawing.Point(683, 517);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(124, 46);
            this.btnCreateOrder.TabIndex = 49;
            this.btnCreateOrder.Text = "Register";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            // 
            // ordersGridView
            // 
            this.ordersGridView.AllowUserToAddRows = false;
            this.ordersGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.ordersGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ordersGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.ordersGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Inter", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ordersGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ordersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Inter", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ordersGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.ordersGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.ordersGridView.Location = new System.Drawing.Point(683, 86);
            this.ordersGridView.Name = "ordersGridView";
            this.ordersGridView.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Inter", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ordersGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.ordersGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.ordersGridView.RowTemplate.Height = 24;
            this.ordersGridView.Size = new System.Drawing.Size(665, 425);
            this.ordersGridView.TabIndex = 48;
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrderTotal.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderTotal.Location = new System.Drawing.Point(230, 507);
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.Size = new System.Drawing.Size(333, 32);
            this.txtOrderTotal.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(226, 475);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 24);
            this.label4.TabIndex = 41;
            this.label4.Text = "Order. Total";
            // 
            // txtOrderDiscount
            // 
            this.txtOrderDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrderDiscount.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderDiscount.Location = new System.Drawing.Point(230, 440);
            this.txtOrderDiscount.Name = "txtOrderDiscount";
            this.txtOrderDiscount.Size = new System.Drawing.Size(333, 32);
            this.txtOrderDiscount.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(226, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 24);
            this.label3.TabIndex = 46;
            this.label3.Text = "Order. Discount";
            // 
            // txtOrderQty
            // 
            this.txtOrderQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrderQty.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderQty.Location = new System.Drawing.Point(230, 370);
            this.txtOrderQty.Name = "txtOrderQty";
            this.txtOrderQty.Size = new System.Drawing.Size(333, 32);
            this.txtOrderQty.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(226, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 43;
            this.label2.Text = "Order. Qty";
            // 
            // txtSearchOrder
            // 
            this.txtSearchOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchOrder.Font = new System.Drawing.Font("Inter", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchOrder.Location = new System.Drawing.Point(1015, 40);
            this.txtSearchOrder.Name = "txtSearchOrder";
            this.txtSearchOrder.Size = new System.Drawing.Size(333, 40);
            this.txtSearchOrder.TabIndex = 39;
            // 
            // txtOrderID
            // 
            this.txtOrderID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrderID.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderID.Location = new System.Drawing.Point(230, 159);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(333, 32);
            this.txtOrderID.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(226, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 24);
            this.label6.TabIndex = 42;
            this.label6.Text = "Order. ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 44;
            this.label1.Text = "Order. Items";
            // 
            // cmbOrderItems
            // 
            this.cmbOrderItems.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrderItems.FormattingEnabled = true;
            this.cmbOrderItems.Location = new System.Drawing.Point(230, 232);
            this.cmbOrderItems.Name = "cmbOrderItems";
            this.cmbOrderItems.Size = new System.Drawing.Size(333, 32);
            this.cmbOrderItems.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(226, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 24);
            this.label5.TabIndex = 41;
            this.label5.Text = "Order. Ref Employee";
            // 
            // cmbOrderRefEmployee
            // 
            this.cmbOrderRefEmployee.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrderRefEmployee.FormattingEnabled = true;
            this.cmbOrderRefEmployee.Location = new System.Drawing.Point(230, 301);
            this.cmbOrderRefEmployee.Name = "cmbOrderRefEmployee";
            this.cmbOrderRefEmployee.Size = new System.Drawing.Size(333, 32);
            this.cmbOrderRefEmployee.TabIndex = 51;
            // 
            // frmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1382, 598);
            this.Controls.Add(this.cmbOrderRefEmployee);
            this.Controls.Add(this.cmbOrderItems);
            this.Controls.Add(this.lblDashboard);
            this.Controls.Add(this.btnDelOrder);
            this.Controls.Add(this.btnListOrders);
            this.Controls.Add(this.btnUpdateOrder);
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(this.ordersGridView);
            this.Controls.Add(this.txtOrderTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOrderDiscount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOrderQty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearchOrder);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menusPanel);
            this.Font = new System.Drawing.Font("Inter", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.Name = "frmOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrders";
            this.Load += new System.EventHandler(this.frmOrders_Load);
            this.menusPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).EndInit();
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
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Button btnDelOrder;
        private System.Windows.Forms.Button btnListOrders;
        private System.Windows.Forms.Button btnUpdateOrder;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.DataGridView ordersGridView;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOrderDiscount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOrderQty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchOrder;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOrderItems;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbOrderRefEmployee;
    }
}