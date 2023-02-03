namespace RestaurantCsharpSystem
{
    partial class frmEmployees
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
            this.btnDelEmp = new System.Windows.Forms.Button();
            this.btnListEmps = new System.Windows.Forms.Button();
            this.btnUpdateEmp = new System.Windows.Forms.Button();
            this.btnCreateEmp = new System.Windows.Forms.Button();
            this.employeesGridView = new System.Windows.Forms.DataGridView();
            this.txtEmpSalary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmpAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmpPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchEmp = new System.Windows.Forms.TextBox();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesGridView)).BeginInit();
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
            this.menusPanel.Size = new System.Drawing.Size(200, 730);
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
            this.lblDashboard.Location = new System.Drawing.Point(226, 42);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(290, 39);
            this.lblDashboard.TabIndex = 33;
            this.lblDashboard.Text = "Employees Directory";
            // 
            // btnDelEmp
            // 
            this.btnDelEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelEmp.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.btnDelEmp.Location = new System.Drawing.Point(1367, 558);
            this.btnDelEmp.Name = "btnDelEmp";
            this.btnDelEmp.Size = new System.Drawing.Size(124, 46);
            this.btnDelEmp.TabIndex = 30;
            this.btnDelEmp.Text = "Delete";
            this.btnDelEmp.UseVisualStyleBackColor = true;
            this.btnDelEmp.Click += new System.EventHandler(this.btnDelEmp_Click);
            // 
            // btnListEmps
            // 
            this.btnListEmps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListEmps.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListEmps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.btnListEmps.Location = new System.Drawing.Point(1178, 557);
            this.btnListEmps.Name = "btnListEmps";
            this.btnListEmps.Size = new System.Drawing.Size(124, 46);
            this.btnListEmps.TabIndex = 28;
            this.btnListEmps.Text = "Refresh";
            this.btnListEmps.UseVisualStyleBackColor = true;
            this.btnListEmps.Click += new System.EventHandler(this.btnListEmps_Click);
            // 
            // btnUpdateEmp
            // 
            this.btnUpdateEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateEmp.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.btnUpdateEmp.Location = new System.Drawing.Point(1009, 557);
            this.btnUpdateEmp.Name = "btnUpdateEmp";
            this.btnUpdateEmp.Size = new System.Drawing.Size(124, 46);
            this.btnUpdateEmp.TabIndex = 22;
            this.btnUpdateEmp.Text = "Update";
            this.btnUpdateEmp.UseVisualStyleBackColor = true;
            this.btnUpdateEmp.Click += new System.EventHandler(this.btnUpdateEmp_Click);
            // 
            // btnCreateEmp
            // 
            this.btnCreateEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateEmp.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.btnCreateEmp.Location = new System.Drawing.Point(826, 558);
            this.btnCreateEmp.Name = "btnCreateEmp";
            this.btnCreateEmp.Size = new System.Drawing.Size(124, 46);
            this.btnCreateEmp.TabIndex = 32;
            this.btnCreateEmp.Text = "Register";
            this.btnCreateEmp.UseVisualStyleBackColor = true;
            this.btnCreateEmp.Click += new System.EventHandler(this.btnCreateEmp_Click);
            // 
            // employeesGridView
            // 
            this.employeesGridView.AllowUserToAddRows = false;
            this.employeesGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.employeesGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.employeesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employeesGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.employeesGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Inter", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.employeesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Inter", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.employeesGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.employeesGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.employeesGridView.Location = new System.Drawing.Point(722, 127);
            this.employeesGridView.Name = "employeesGridView";
            this.employeesGridView.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Inter", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeesGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.employeesGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.employeesGridView.RowTemplate.Height = 24;
            this.employeesGridView.Size = new System.Drawing.Size(769, 425);
            this.employeesGridView.TabIndex = 31;
            this.employeesGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeesGridView_CellContentClick);
            // 
            // txtEmpSalary
            // 
            this.txtEmpSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.txtEmpSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpSalary.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.txtEmpSalary.Location = new System.Drawing.Point(233, 487);
            this.txtEmpSalary.Name = "txtEmpSalary";
            this.txtEmpSalary.Size = new System.Drawing.Size(333, 32);
            this.txtEmpSalary.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(229, 455);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "Emp. Salary";
            // 
            // txtEmpAddress
            // 
            this.txtEmpAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.txtEmpAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpAddress.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.txtEmpAddress.Location = new System.Drawing.Point(233, 420);
            this.txtEmpAddress.Name = "txtEmpAddress";
            this.txtEmpAddress.Size = new System.Drawing.Size(333, 32);
            this.txtEmpAddress.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(229, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 24);
            this.label3.TabIndex = 29;
            this.label3.Text = "Emp. Address";
            // 
            // txtEmpPhone
            // 
            this.txtEmpPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.txtEmpPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpPhone.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.txtEmpPhone.Location = new System.Drawing.Point(233, 350);
            this.txtEmpPhone.Name = "txtEmpPhone";
            this.txtEmpPhone.Size = new System.Drawing.Size(333, 32);
            this.txtEmpPhone.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "Emp. Phone";
            // 
            // txtSearchEmp
            // 
            this.txtSearchEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.txtSearchEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchEmp.Font = new System.Drawing.Font("Inter", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.txtSearchEmp.Location = new System.Drawing.Point(1088, 81);
            this.txtSearchEmp.Name = "txtSearchEmp";
            this.txtSearchEmp.Size = new System.Drawing.Size(403, 40);
            this.txtSearchEmp.TabIndex = 21;
            this.txtSearchEmp.TextChanged += new System.EventHandler(this.txtSearchEmp_TextChanged);
            // 
            // txtEmpID
            // 
            this.txtEmpID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.txtEmpID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpID.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.txtEmpID.Location = new System.Drawing.Point(233, 206);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(333, 32);
            this.txtEmpID.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(229, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 24);
            this.label6.TabIndex = 24;
            this.label6.Text = "Emp. ID";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtEmpName
            // 
            this.txtEmpName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.txtEmpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpName.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.txtEmpName.Location = new System.Drawing.Point(233, 278);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(333, 32);
            this.txtEmpName.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Emp. Name";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.button1.Location = new System.Drawing.Point(722, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 46);
            this.button1.TabIndex = 28;
            this.button1.Text = "Employees Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.button2.Location = new System.Drawing.Point(894, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 46);
            this.button2.TabIndex = 28;
            this.button2.Text = "Individual Rpt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1503, 730);
            this.Controls.Add(this.lblDashboard);
            this.Controls.Add(this.btnDelEmp);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnListEmps);
            this.Controls.Add(this.btnUpdateEmp);
            this.Controls.Add(this.btnCreateEmp);
            this.Controls.Add(this.employeesGridView);
            this.Controls.Add(this.txtEmpSalary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmpAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmpPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearchEmp);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menusPanel);
            this.Font = new System.Drawing.Font("Inter", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.Name = "frmEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEmployees";
            this.Load += new System.EventHandler(this.frmEmployees_Load);
            this.menusPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesGridView)).EndInit();
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
        private System.Windows.Forms.Button btnDelEmp;
        private System.Windows.Forms.Button btnListEmps;
        private System.Windows.Forms.Button btnUpdateEmp;
        private System.Windows.Forms.Button btnCreateEmp;
        private System.Windows.Forms.DataGridView employeesGridView;
        private System.Windows.Forms.TextBox txtEmpSalary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmpAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmpPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchEmp;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}