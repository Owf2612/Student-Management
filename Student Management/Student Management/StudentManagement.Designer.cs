namespace Student_Management
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dataGridStudent = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudentCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new Student_Management.owf.UIButton();
            this.btnSua = new Student_Management.owf.UIButton();
            this.btnDelete = new Student_Management.owf.UIButton();
            this.btnAdd = new Student_Management.owf.UIButton();
            this.txtSearch = new Student_Management.owf.TextBox();
            this.txtClass = new Student_Management.owf.TextBox();
            this.txtAge = new Student_Management.owf.TextBox();
            this.txtPersonID = new Student_Management.owf.TextBox();
            this.txtStudentCode = new Student_Management.owf.TextBox();
            this.txtEmail = new Student_Management.owf.TextBox();
            this.txtName = new Student_Management.owf.TextBox();
            this.bntMinimize = new Student_Management.owf.UIButton();
            this.btnMaximize = new Student_Management.owf.UIButton();
            this.btnClose = new Student_Management.owf.UIButton();
            this.btnSearch = new Student_Management.owf.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudent)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(545, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name*";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(857, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Student Code*";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1189, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Age*";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(545, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "Email*";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(857, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "Person ID*";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1189, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "Class*";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1407, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 21);
            this.label9.TabIndex = 18;
            this.label9.Text = "Search By Name";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(0, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 25;
            // 
            // dataGridStudent
            // 
            this.dataGridStudent.AllowUserToAddRows = false;
            this.dataGridStudent.AllowUserToDeleteRows = false;
            this.dataGridStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridStudent.BackgroundColor = System.Drawing.Color.White;
            this.dataGridStudent.ColumnHeadersHeight = 48;
            this.dataGridStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName,
            this.colPersonID,
            this.colStudentCode,
            this.colAge,
            this.colClass,
            this.colEmail});
            this.dataGridStudent.Location = new System.Drawing.Point(304, 294);
            this.dataGridStudent.Name = "dataGridStudent";
            this.dataGridStudent.ReadOnly = true;
            this.dataGridStudent.RowHeadersVisible = false;
            this.dataGridStudent.RowHeadersWidth = 51;
            this.dataGridStudent.RowTemplate.Height = 24;
            this.dataGridStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridStudent.Size = new System.Drawing.Size(1623, 610);
            this.dataGridStudent.TabIndex = 16;
            this.dataGridStudent.SelectionChanged += new System.EventHandler(this.dataGridStudent_SelectionChanged);
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 125;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colPersonID
            // 
            this.colPersonID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPersonID.DataPropertyName = "PersonID";
            this.colPersonID.HeaderText = "Person ID";
            this.colPersonID.MinimumWidth = 6;
            this.colPersonID.Name = "colPersonID";
            this.colPersonID.ReadOnly = true;
            // 
            // colStudentCode
            // 
            this.colStudentCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStudentCode.DataPropertyName = "StudentCode";
            this.colStudentCode.HeaderText = "Student Code";
            this.colStudentCode.MinimumWidth = 6;
            this.colStudentCode.Name = "colStudentCode";
            this.colStudentCode.ReadOnly = true;
            // 
            // colAge
            // 
            this.colAge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAge.DataPropertyName = "Age";
            this.colAge.HeaderText = "Age";
            this.colAge.MinimumWidth = 6;
            this.colAge.Name = "colAge";
            this.colAge.ReadOnly = true;
            // 
            // colClass
            // 
            this.colClass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colClass.DataPropertyName = "Class";
            this.colClass.HeaderText = "Class";
            this.colClass.MinimumWidth = 6;
            this.colClass.Name = "colClass";
            this.colClass.ReadOnly = true;
            // 
            // colEmail
            // 
            this.colEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "Email";
            this.colEmail.MinimumWidth = 6;
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.txtClass);
            this.panel1.Controls.Add(this.txtAge);
            this.panel1.Controls.Add(this.txtPersonID);
            this.panel1.Controls.Add(this.txtStudentCode);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.bntMinimize);
            this.panel1.Controls.Add(this.btnMaximize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1939, 288);
            this.panel1.TabIndex = 25;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(298, 288);
            this.panel4.TabIndex = 24;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Student_Management.Properties.Resources.Logo_Truong_cao_dang_Quoc_te_BTEC_FPT;
            this.pictureBox1.Location = new System.Drawing.Point(12, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(75, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "student management";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "welcome to ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.panel3.Controls.Add(this.dataGridStudent);
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Controls.Add(this.btnEdit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1939, 916);
            this.panel3.TabIndex = 27;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(0, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(74)))));
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 288);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(298, 628);
            this.panel2.TabIndex = 26;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(74)))));
            this.btnSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(74)))));
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(117)))), ((int)(((byte)(44)))));
            this.btnSave.BorderRadius = 5;
            this.btnSave.BorderSize = 2;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(244)))));
            this.btnSave.Location = new System.Drawing.Point(0, 543);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSave.Size = new System.Drawing.Size(298, 85);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(244)))));
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(74)))));
            this.btnSua.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(74)))));
            this.btnSua.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(117)))), ((int)(((byte)(44)))));
            this.btnSua.BorderRadius = 5;
            this.btnSua.BorderSize = 2;
            this.btnSua.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(8)))));
            this.btnSua.Location = new System.Drawing.Point(0, 170);
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSua.Size = new System.Drawing.Size(298, 85);
            this.btnSua.TabIndex = 24;
            this.btnSua.Text = "Edit";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(8)))));
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(74)))));
            this.btnDelete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(74)))));
            this.btnDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(117)))), ((int)(((byte)(44)))));
            this.btnDelete.BorderRadius = 5;
            this.btnDelete.BorderSize = 2;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnDelete.Location = new System.Drawing.Point(0, 85);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnDelete.Size = new System.Drawing.Size(298, 85);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(74)))));
            this.btnAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(74)))));
            this.btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(117)))), ((int)(((byte)(44)))));
            this.btnAdd.BorderRadius = 5;
            this.btnAdd.BorderSize = 2;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(241)))), ((int)(((byte)(134)))));
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAdd.Size = new System.Drawing.Size(298, 85);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(241)))), ((int)(((byte)(134)))));
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(107)))), ((int)(((byte)(43)))));
            this.txtSearch.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(242)))), ((int)(((byte)(79)))));
            this.txtSearch.BorderRadius = 0;
            this.txtSearch.BorderSize = 2;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(1400, 126);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearch.PlaceholderText = "Enter the name you want to search";
            this.txtSearch.ReadOnly = false;
            this.txtSearch.Size = new System.Drawing.Size(288, 34);
            this.txtSearch.TabIndex = 35;
            this.txtSearch.Texts = "";
            this.txtSearch.UnderlinedStyle = true;
            // 
            // txtClass
            // 
            this.txtClass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.txtClass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(107)))), ((int)(((byte)(43)))));
            this.txtClass.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(242)))), ((int)(((byte)(79)))));
            this.txtClass.BorderRadius = 0;
            this.txtClass.BorderSize = 2;
            this.txtClass.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClass.ForeColor = System.Drawing.Color.White;
            this.txtClass.Location = new System.Drawing.Point(1184, 163);
            this.txtClass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtClass.Multiline = false;
            this.txtClass.Name = "txtClass";
            this.txtClass.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtClass.PasswordChar = false;
            this.txtClass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtClass.PlaceholderText = "";
            this.txtClass.ReadOnly = false;
            this.txtClass.Size = new System.Drawing.Size(155, 36);
            this.txtClass.TabIndex = 34;
            this.txtClass.Texts = "";
            this.txtClass.UnderlinedStyle = true;
            // 
            // txtAge
            // 
            this.txtAge.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.txtAge.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(107)))), ((int)(((byte)(43)))));
            this.txtAge.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(242)))), ((int)(((byte)(79)))));
            this.txtAge.BorderRadius = 0;
            this.txtAge.BorderSize = 2;
            this.txtAge.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.ForeColor = System.Drawing.Color.White;
            this.txtAge.Location = new System.Drawing.Point(1184, 60);
            this.txtAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAge.Multiline = false;
            this.txtAge.Name = "txtAge";
            this.txtAge.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtAge.PasswordChar = false;
            this.txtAge.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAge.PlaceholderText = "";
            this.txtAge.ReadOnly = false;
            this.txtAge.Size = new System.Drawing.Size(155, 36);
            this.txtAge.TabIndex = 33;
            this.txtAge.Texts = "";
            this.txtAge.UnderlinedStyle = true;
            // 
            // txtPersonID
            // 
            this.txtPersonID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPersonID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.txtPersonID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(107)))), ((int)(((byte)(43)))));
            this.txtPersonID.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(242)))), ((int)(((byte)(79)))));
            this.txtPersonID.BorderRadius = 0;
            this.txtPersonID.BorderSize = 2;
            this.txtPersonID.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonID.ForeColor = System.Drawing.Color.White;
            this.txtPersonID.Location = new System.Drawing.Point(852, 163);
            this.txtPersonID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPersonID.Multiline = false;
            this.txtPersonID.Name = "txtPersonID";
            this.txtPersonID.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPersonID.PasswordChar = false;
            this.txtPersonID.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPersonID.PlaceholderText = "";
            this.txtPersonID.ReadOnly = false;
            this.txtPersonID.Size = new System.Drawing.Size(270, 36);
            this.txtPersonID.TabIndex = 32;
            this.txtPersonID.Texts = "";
            this.txtPersonID.UnderlinedStyle = true;
            // 
            // txtStudentCode
            // 
            this.txtStudentCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtStudentCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.txtStudentCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(107)))), ((int)(((byte)(43)))));
            this.txtStudentCode.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(242)))), ((int)(((byte)(79)))));
            this.txtStudentCode.BorderRadius = 0;
            this.txtStudentCode.BorderSize = 2;
            this.txtStudentCode.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentCode.ForeColor = System.Drawing.Color.White;
            this.txtStudentCode.Location = new System.Drawing.Point(852, 60);
            this.txtStudentCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStudentCode.Multiline = false;
            this.txtStudentCode.Name = "txtStudentCode";
            this.txtStudentCode.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtStudentCode.PasswordChar = false;
            this.txtStudentCode.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtStudentCode.PlaceholderText = "";
            this.txtStudentCode.ReadOnly = false;
            this.txtStudentCode.Size = new System.Drawing.Size(270, 36);
            this.txtStudentCode.TabIndex = 31;
            this.txtStudentCode.Texts = "";
            this.txtStudentCode.UnderlinedStyle = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(107)))), ((int)(((byte)(43)))));
            this.txtEmail.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(242)))), ((int)(((byte)(79)))));
            this.txtEmail.BorderRadius = 0;
            this.txtEmail.BorderSize = 2;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(540, 163);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.ReadOnly = false;
            this.txtEmail.Size = new System.Drawing.Size(270, 36);
            this.txtEmail.TabIndex = 30;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = true;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(107)))), ((int)(((byte)(43)))));
            this.txtName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(242)))), ((int)(((byte)(79)))));
            this.txtName.BorderRadius = 0;
            this.txtName.BorderSize = 2;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(540, 59);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtName.PasswordChar = false;
            this.txtName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtName.PlaceholderText = "";
            this.txtName.ReadOnly = false;
            this.txtName.Size = new System.Drawing.Size(270, 36);
            this.txtName.TabIndex = 26;
            this.txtName.Texts = "";
            this.txtName.UnderlinedStyle = true;
            // 
            // bntMinimize
            // 
            this.bntMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(188)))), ((int)(((byte)(62)))));
            this.bntMinimize.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(188)))), ((int)(((byte)(62)))));
            this.bntMinimize.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bntMinimize.BorderRadius = 12;
            this.bntMinimize.BorderSize = 0;
            this.bntMinimize.FlatAppearance.BorderSize = 0;
            this.bntMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntMinimize.ForeColor = System.Drawing.Color.White;
            this.bntMinimize.Location = new System.Drawing.Point(1864, 3);
            this.bntMinimize.Name = "bntMinimize";
            this.bntMinimize.Size = new System.Drawing.Size(31, 31);
            this.bntMinimize.TabIndex = 29;
            this.bntMinimize.TextColor = System.Drawing.Color.White;
            this.bntMinimize.UseVisualStyleBackColor = false;
            this.bntMinimize.Click += new System.EventHandler(this.bntMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(204)))), ((int)(((byte)(67)))));
            this.btnMaximize.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(204)))), ((int)(((byte)(67)))));
            this.btnMaximize.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMaximize.BorderRadius = 12;
            this.btnMaximize.BorderSize = 0;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Location = new System.Drawing.Point(1901, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(31, 31);
            this.btnMaximize.TabIndex = 28;
            this.btnMaximize.TextColor = System.Drawing.Color.White;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(90)))), ((int)(((byte)(85)))));
            this.btnClose.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(90)))), ((int)(((byte)(85)))));
            this.btnClose.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnClose.BorderRadius = 12;
            this.btnClose.BorderSize = 0;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1827, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 31);
            this.btnClose.TabIndex = 27;
            this.btnClose.TextColor = System.Drawing.Color.White;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(74)))));
            this.btnSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(74)))));
            this.btnSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(241)))), ((int)(((byte)(134)))));
            this.btnSearch.BorderRadius = 5;
            this.btnSearch.BorderSize = 2;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(241)))), ((int)(((byte)(134)))));
            this.btnSearch.Location = new System.Drawing.Point(1597, 176);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSearch.Size = new System.Drawing.Size(127, 39);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(241)))), ((int)(((byte)(134)))));
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1939, 916);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Students Management";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudent)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dataGridStudent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel2;
        private owf.UIButton btnAdd;
        private owf.UIButton btnDelete;
        private owf.UIButton btnSua;
        private owf.UIButton btnSave;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private owf.UIButton btnSearch;
        private owf.UIButton bntMinimize;
        private owf.UIButton btnMaximize;
        private owf.UIButton btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPersonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private owf.TextBox txtName;
        private owf.TextBox txtEmail;
        private owf.TextBox txtPersonID;
        private owf.TextBox txtStudentCode;
        private owf.TextBox txtSearch;
        private owf.TextBox txtClass;
        private owf.TextBox txtAge;
    }
}

