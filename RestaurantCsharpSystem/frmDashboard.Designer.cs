namespace RestaurantCsharpSystem
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.lblDashboard = new System.Windows.Forms.Label();
            this.menusPanel = new System.Windows.Forms.Panel();
            this.payroll_menu = new System.Windows.Forms.Button();
            this.category_menu = new System.Windows.Forms.Button();
            this.products_menu = new System.Windows.Forms.Button();
            this.orders_menu = new System.Windows.Forms.Button();
            this.employees_menu = new System.Windows.Forms.Button();
            this.user_menu = new System.Windows.Forms.Button();
            this.dashboard_menu = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.total_products_in_store = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.total_orders = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.total_employees = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.total_unpaid_orders = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.total_paid_orders = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.total_cancelled_orders = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Public Sans SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.Location = new System.Drawing.Point(344, 100);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(160, 39);
            this.lblDashboard.TabIndex = 0;
            this.lblDashboard.Text = "Dashboard";
            // 
            // menusPanel
            // 
            this.menusPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menusPanel.Controls.Add(this.payroll_menu);
            this.menusPanel.Controls.Add(this.category_menu);
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
            this.menusPanel.TabIndex = 3;
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
            this.payroll_menu.Location = new System.Drawing.Point(7, 471);
            this.payroll_menu.Name = "payroll_menu";
            this.payroll_menu.Size = new System.Drawing.Size(188, 36);
            this.payroll_menu.TabIndex = 2;
            this.payroll_menu.Text = "Payroll";
            this.payroll_menu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.payroll_menu.UseVisualStyleBackColor = false;
            this.payroll_menu.Click += new System.EventHandler(this.payroll_menu_Click);
            // 
            // category_menu
            // 
            this.category_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.category_menu.FlatAppearance.BorderSize = 0;
            this.category_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.category_menu.Font = new System.Drawing.Font("Inter", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_menu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.category_menu.Image = global::RestaurantCsharpSystem.Properties.Resources.products_icon;
            this.category_menu.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.category_menu.Location = new System.Drawing.Point(7, 249);
            this.category_menu.Name = "category_menu";
            this.category_menu.Size = new System.Drawing.Size(188, 36);
            this.category_menu.TabIndex = 2;
            this.category_menu.Text = "Category";
            this.category_menu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.category_menu.UseVisualStyleBackColor = false;
            this.category_menu.Click += new System.EventHandler(this.category_menu_Click);
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
            this.products_menu.Location = new System.Drawing.Point(7, 300);
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
            this.orders_menu.Location = new System.Drawing.Point(7, 358);
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
            this.employees_menu.Location = new System.Drawing.Point(7, 418);
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
            this.dashboard_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.total_products_in_store);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(351, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 127);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RestaurantCsharpSystem.Properties.Resources.products1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // total_products_in_store
            // 
            this.total_products_in_store.AutoSize = true;
            this.total_products_in_store.Font = new System.Drawing.Font("Public Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_products_in_store.Location = new System.Drawing.Point(202, 80);
            this.total_products_in_store.Name = "total_products_in_store";
            this.total_products_in_store.Size = new System.Drawing.Size(80, 34);
            this.total_products_in_store.TabIndex = 0;
            this.total_products_in_store.Text = "2,900";
            this.total_products_in_store.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.total_products_in_store.Click += new System.EventHandler(this.total_products_in_store_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Public Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 34);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Products";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.total_orders);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(673, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 127);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RestaurantCsharpSystem.Properties.Resources.orders1;
            this.pictureBox2.Location = new System.Drawing.Point(15, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // total_orders
            // 
            this.total_orders.AutoSize = true;
            this.total_orders.Font = new System.Drawing.Font("Public Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_orders.Location = new System.Drawing.Point(208, 80);
            this.total_orders.Name = "total_orders";
            this.total_orders.Size = new System.Drawing.Size(74, 34);
            this.total_orders.TabIndex = 0;
            this.total_orders.Text = "2900";
            this.total_orders.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Public Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(86, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 34);
            this.label10.TabIndex = 0;
            this.label10.Text = "Total Orders";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.total_employees);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(1001, 200);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(284, 127);
            this.panel3.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::RestaurantCsharpSystem.Properties.Resources.products1;
            this.pictureBox3.Location = new System.Drawing.Point(12, 16);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // total_employees
            // 
            this.total_employees.AutoSize = true;
            this.total_employees.Font = new System.Drawing.Font("Public Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_employees.Location = new System.Drawing.Point(202, 80);
            this.total_employees.Name = "total_employees";
            this.total_employees.Size = new System.Drawing.Size(80, 34);
            this.total_employees.TabIndex = 0;
            this.total_employees.Text = "2,900";
            this.total_employees.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Public Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(86, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(198, 34);
            this.label12.TabIndex = 0;
            this.label12.Text = "Total Employees";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel6.Controls.Add(this.pictureBox7);
            this.panel6.Controls.Add(this.total_unpaid_orders);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Location = new System.Drawing.Point(673, 383);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(284, 127);
            this.panel6.TabIndex = 1;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::RestaurantCsharpSystem.Properties.Resources.orders1;
            this.pictureBox7.Location = new System.Drawing.Point(15, 16);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(65, 64);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 1;
            this.pictureBox7.TabStop = false;
            // 
            // total_unpaid_orders
            // 
            this.total_unpaid_orders.AutoSize = true;
            this.total_unpaid_orders.Font = new System.Drawing.Font("Public Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_unpaid_orders.Location = new System.Drawing.Point(208, 80);
            this.total_unpaid_orders.Name = "total_unpaid_orders";
            this.total_unpaid_orders.Size = new System.Drawing.Size(74, 34);
            this.total_unpaid_orders.TabIndex = 0;
            this.total_unpaid_orders.Text = "2900";
            this.total_unpaid_orders.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Public Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(86, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 77);
            this.label9.TabIndex = 0;
            this.label9.Text = "Total Unpaid Orders";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Controls.Add(this.pictureBox5);
            this.panel4.Controls.Add(this.total_paid_orders);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(351, 383);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(284, 127);
            this.panel4.TabIndex = 1;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::RestaurantCsharpSystem.Properties.Resources.orders1;
            this.pictureBox5.Location = new System.Drawing.Point(15, 16);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(65, 64);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // total_paid_orders
            // 
            this.total_paid_orders.AutoSize = true;
            this.total_paid_orders.Font = new System.Drawing.Font("Public Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_paid_orders.Location = new System.Drawing.Point(208, 80);
            this.total_paid_orders.Name = "total_paid_orders";
            this.total_paid_orders.Size = new System.Drawing.Size(74, 34);
            this.total_paid_orders.TabIndex = 0;
            this.total_paid_orders.Text = "2900";
            this.total_paid_orders.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Public Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 77);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Paid Orders";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Controls.Add(this.pictureBox6);
            this.panel5.Controls.Add(this.total_cancelled_orders);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(1001, 383);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(284, 127);
            this.panel5.TabIndex = 1;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::RestaurantCsharpSystem.Properties.Resources.orders1;
            this.pictureBox6.Location = new System.Drawing.Point(15, 16);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(65, 64);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            // 
            // total_cancelled_orders
            // 
            this.total_cancelled_orders.AutoSize = true;
            this.total_cancelled_orders.Font = new System.Drawing.Font("Public Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_cancelled_orders.Location = new System.Drawing.Point(208, 80);
            this.total_cancelled_orders.Name = "total_cancelled_orders";
            this.total_cancelled_orders.Size = new System.Drawing.Size(74, 34);
            this.total_cancelled_orders.TabIndex = 0;
            this.total_cancelled_orders.Text = "2900";
            this.total_cancelled_orders.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Public Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(86, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 77);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total Cancelled Orders";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1382, 598);
            this.Controls.Add(this.menusPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDashboard);
            this.Font = new System.Drawing.Font("Inter", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tufaax Restaurant";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menusPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel menusPanel;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button dashboard_menu;
        private System.Windows.Forms.Button user_menu;
        private System.Windows.Forms.Button employees_menu;
        private System.Windows.Forms.Button orders_menu;
        private System.Windows.Forms.Button products_menu;
        private System.Windows.Forms.Button payroll_menu;
        private System.Windows.Forms.Button category_menu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label total_products_in_store;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label total_orders;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label total_employees;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label total_unpaid_orders;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label total_paid_orders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label total_cancelled_orders;
        private System.Windows.Forms.Label label5;
    }
}

