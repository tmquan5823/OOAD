namespace GUI
{
    partial class UserForm
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
            this.panel_menu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listApp = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.panel_taikhoan = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_tk = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_loc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_appDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_endtime = new System.Windows.Forms.DateTimePicker();
            this.dtp_starttime = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_des = new System.Windows.Forms.TextBox();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_RemoveAtt = new System.Windows.Forms.Button();
            this.btn_AddAtt = new System.Windows.Forms.Button();
            this.cbb_attendance = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.listAtt = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_removeRemider = new System.Windows.Forms.Button();
            this.btn_addReminder = new System.Windows.Forms.Button();
            this.cbb_reminderTime = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.listReminder = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel_menu.SuspendLayout();
            this.panel_taikhoan.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(215)))), ((int)(((byte)(197)))));
            this.panel_menu.Controls.Add(this.label1);
            this.panel_menu.Controls.Add(this.listApp);
            this.panel_menu.Controls.Add(this.dtp_date);
            this.panel_menu.Controls.Add(this.panel_taikhoan);
            this.panel_menu.Controls.Add(this.btn_tk);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(365, 764);
            this.panel_menu.TabIndex = 0;
            this.panel_menu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_menu_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cuộc hẹn ";
            // 
            // listApp
            // 
            this.listApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.listApp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listApp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listApp.FullRowSelect = true;
            this.listApp.GridLines = true;
            this.listApp.HideSelection = false;
            this.listApp.Location = new System.Drawing.Point(0, 407);
            this.listApp.Name = "listApp";
            this.listApp.Size = new System.Drawing.Size(365, 357);
            this.listApp.TabIndex = 4;
            this.listApp.UseCompatibleStateImageBehavior = false;
            this.listApp.View = System.Windows.Forms.View.Details;
            this.listApp.SelectedIndexChanged += new System.EventHandler(this.listApp_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID cuộc hẹn";
            this.columnHeader1.Width = 127;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên cuộc hẹn";
            this.columnHeader2.Width = 234;
            // 
            // dtp_date
            // 
            this.dtp_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date.Location = new System.Drawing.Point(0, 296);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(365, 38);
            this.dtp_date.TabIndex = 3;
            this.dtp_date.ValueChanged += new System.EventHandler(this.dtp_date_ValueChanged);
            // 
            // panel_taikhoan
            // 
            this.panel_taikhoan.Controls.Add(this.button2);
            this.panel_taikhoan.Controls.Add(this.button1);
            this.panel_taikhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_taikhoan.Location = new System.Drawing.Point(0, 80);
            this.panel_taikhoan.Name = "panel_taikhoan";
            this.panel_taikhoan.Size = new System.Drawing.Size(365, 160);
            this.panel_taikhoan.TabIndex = 2;
            this.panel_taikhoan.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(365, 80);
            this.button2.TabIndex = 3;
            this.button2.Text = "Đăng xuất";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(365, 80);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thông tin cá nhân";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_tk
            // 
            this.btn_tk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_tk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_tk.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_tk.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_tk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tk.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tk.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_tk.Location = new System.Drawing.Point(0, 0);
            this.btn_tk.Name = "btn_tk";
            this.btn_tk.Size = new System.Drawing.Size(365, 80);
            this.btn_tk.TabIndex = 1;
            this.btn_tk.Text = "Tài khoản";
            this.btn_tk.UseVisualStyleBackColor = false;
            this.btn_tk.Click += new System.EventHandler(this.btn_tk_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(215)))), ((int)(((byte)(197)))));
            this.panel1.Controls.Add(this.btn_xoa);
            this.panel1.Controls.Add(this.btn_capnhat);
            this.panel1.Controls.Add(this.btn_them);
            this.panel1.Controls.Add(this.txt_loc);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dtp_appDate);
            this.panel1.Controls.Add(this.dtp_endtime);
            this.panel1.Controls.Add(this.dtp_starttime);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_des);
            this.panel1.Controls.Add(this.txt_title);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(365, 407);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 357);
            this.panel1.TabIndex = 1;
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(105)))), ((int)(((byte)(77)))));
            this.btn_xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xoa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_xoa.FlatAppearance.BorderSize = 2;
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_xoa.Location = new System.Drawing.Point(592, 245);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(291, 82);
            this.btn_xoa.TabIndex = 33;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(105)))), ((int)(((byte)(77)))));
            this.btn_capnhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_capnhat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_capnhat.FlatAppearance.BorderSize = 2;
            this.btn_capnhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_capnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capnhat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_capnhat.Location = new System.Drawing.Point(592, 136);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(291, 82);
            this.btn_capnhat.TabIndex = 32;
            this.btn_capnhat.Text = "Cập nhật";
            this.btn_capnhat.UseVisualStyleBackColor = false;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click_1);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(105)))), ((int)(((byte)(77)))));
            this.btn_them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_them.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_them.FlatAppearance.BorderSize = 2;
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_them.Location = new System.Drawing.Point(592, 20);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(291, 82);
            this.btn_them.TabIndex = 31;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click_1);
            // 
            // txt_loc
            // 
            this.txt_loc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.txt_loc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_loc.Location = new System.Drawing.Point(128, 175);
            this.txt_loc.Multiline = true;
            this.txt_loc.Name = "txt_loc";
            this.txt_loc.Size = new System.Drawing.Size(411, 62);
            this.txt_loc.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 193);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(86, 25);
            this.label8.TabIndex = 29;
            this.label8.Text = "Location";
            // 
            // dtp_appDate
            // 
            this.dtp_appDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.dtp_appDate.CustomFormat = "MM/dd/yyyy";
            this.dtp_appDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_appDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_appDate.Location = new System.Drawing.Point(125, 64);
            this.dtp_appDate.Name = "dtp_appDate";
            this.dtp_appDate.Size = new System.Drawing.Size(414, 30);
            this.dtp_appDate.TabIndex = 28;
            // 
            // dtp_endtime
            // 
            this.dtp_endtime.CustomFormat = "\"HH:mm\"";
            this.dtp_endtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_endtime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_endtime.Location = new System.Drawing.Point(385, 114);
            this.dtp_endtime.Name = "dtp_endtime";
            this.dtp_endtime.ShowUpDown = true;
            this.dtp_endtime.Size = new System.Drawing.Size(154, 30);
            this.dtp_endtime.TabIndex = 27;
            // 
            // dtp_starttime
            // 
            this.dtp_starttime.CustomFormat = "\"HH:mm\"";
            this.dtp_starttime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_starttime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_starttime.Location = new System.Drawing.Point(128, 112);
            this.dtp_starttime.Name = "dtp_starttime";
            this.dtp_starttime.ShowUpDown = true;
            this.dtp_starttime.Size = new System.Drawing.Size(140, 30);
            this.dtp_starttime.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, 69);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(53, 25);
            this.label7.TabIndex = 25;
            this.label7.Text = "Date";
            // 
            // txt_des
            // 
            this.txt_des.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.txt_des.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_des.Location = new System.Drawing.Point(128, 261);
            this.txt_des.Multiline = true;
            this.txt_des.Name = "txt_des";
            this.txt_des.Size = new System.Drawing.Size(411, 66);
            this.txt_des.TabIndex = 24;
            // 
            // txt_title
            // 
            this.txt_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.txt_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_title.Location = new System.Drawing.Point(125, 15);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(414, 30);
            this.txt_title.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 283);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(109, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 178);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(294, 116);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "End time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 114);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Start time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 20);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(49, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Title";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(215)))), ((int)(((byte)(197)))));
            this.panel2.Controls.Add(this.btn_RemoveAtt);
            this.panel2.Controls.Add(this.btn_AddAtt);
            this.panel2.Controls.Add(this.cbb_attendance);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.listAtt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(365, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(458, 407);
            this.panel2.TabIndex = 2;
            // 
            // btn_RemoveAtt
            // 
            this.btn_RemoveAtt.Location = new System.Drawing.Point(371, 41);
            this.btn_RemoveAtt.Name = "btn_RemoveAtt";
            this.btn_RemoveAtt.Size = new System.Drawing.Size(82, 35);
            this.btn_RemoveAtt.TabIndex = 7;
            this.btn_RemoveAtt.Text = "Remove";
            this.btn_RemoveAtt.UseVisualStyleBackColor = true;
            this.btn_RemoveAtt.Click += new System.EventHandler(this.btn_RemoveAtt_Click);
            // 
            // btn_AddAtt
            // 
            this.btn_AddAtt.Location = new System.Drawing.Point(305, 41);
            this.btn_AddAtt.Name = "btn_AddAtt";
            this.btn_AddAtt.Size = new System.Drawing.Size(58, 35);
            this.btn_AddAtt.TabIndex = 6;
            this.btn_AddAtt.Text = "Add";
            this.btn_AddAtt.UseVisualStyleBackColor = true;
            this.btn_AddAtt.Click += new System.EventHandler(this.btn_AddAtt_Click);
            // 
            // cbb_attendance
            // 
            this.cbb_attendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_attendance.FormattingEnabled = true;
            this.cbb_attendance.Location = new System.Drawing.Point(8, 43);
            this.cbb_attendance.Name = "cbb_attendance";
            this.cbb_attendance.Size = new System.Drawing.Size(287, 33);
            this.cbb_attendance.TabIndex = 5;
            this.cbb_attendance.SelectedIndexChanged += new System.EventHandler(this.listUser_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 29);
            this.label9.TabIndex = 1;
            this.label9.Text = "Attendance";
            // 
            // listAtt
            // 
            this.listAtt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.listAtt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader3});
            this.listAtt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listAtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listAtt.FullRowSelect = true;
            this.listAtt.GridLines = true;
            this.listAtt.HideSelection = false;
            this.listAtt.Location = new System.Drawing.Point(0, 96);
            this.listAtt.Name = "listAtt";
            this.listAtt.Size = new System.Drawing.Size(458, 311);
            this.listAtt.TabIndex = 0;
            this.listAtt.UseCompatibleStateImageBehavior = false;
            this.listAtt.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID ";
            this.columnHeader4.Width = 68;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Người tham gia";
            this.columnHeader5.Width = 210;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tình trạng";
            this.columnHeader3.Width = 176;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(215)))), ((int)(((byte)(197)))));
            this.panel3.Controls.Add(this.btn_removeRemider);
            this.panel3.Controls.Add(this.btn_addReminder);
            this.panel3.Controls.Add(this.cbb_reminderTime);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.listReminder);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(832, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(444, 407);
            this.panel3.TabIndex = 3;
            // 
            // btn_removeRemider
            // 
            this.btn_removeRemider.Location = new System.Drawing.Point(350, 38);
            this.btn_removeRemider.Name = "btn_removeRemider";
            this.btn_removeRemider.Size = new System.Drawing.Size(82, 38);
            this.btn_removeRemider.TabIndex = 12;
            this.btn_removeRemider.Text = "Remove";
            this.btn_removeRemider.UseVisualStyleBackColor = true;
            this.btn_removeRemider.Click += new System.EventHandler(this.btn_removeRemider_Click);
            // 
            // btn_addReminder
            // 
            this.btn_addReminder.Location = new System.Drawing.Point(286, 38);
            this.btn_addReminder.Name = "btn_addReminder";
            this.btn_addReminder.Size = new System.Drawing.Size(58, 38);
            this.btn_addReminder.TabIndex = 11;
            this.btn_addReminder.Text = "Add";
            this.btn_addReminder.UseVisualStyleBackColor = true;
            this.btn_addReminder.Click += new System.EventHandler(this.btn_addReminder_Click);
            // 
            // cbb_reminderTime
            // 
            this.cbb_reminderTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_reminderTime.FormattingEnabled = true;
            this.cbb_reminderTime.Items.AddRange(new object[] {
            "5 phút ",
            "15 phút ",
            "30 phút ",
            "1 tiếng "});
            this.cbb_reminderTime.Location = new System.Drawing.Point(6, 40);
            this.cbb_reminderTime.Name = "cbb_reminderTime";
            this.cbb_reminderTime.Size = new System.Drawing.Size(257, 33);
            this.cbb_reminderTime.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 29);
            this.label10.TabIndex = 9;
            this.label10.Text = "Reminder";
            // 
            // listReminder
            // 
            this.listReminder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.listReminder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader9,
            this.columnHeader10});
            this.listReminder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listReminder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listReminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listReminder.FullRowSelect = true;
            this.listReminder.GridLines = true;
            this.listReminder.HideSelection = false;
            this.listReminder.Location = new System.Drawing.Point(0, 96);
            this.listReminder.Name = "listReminder";
            this.listReminder.Size = new System.Drawing.Size(444, 311);
            this.listReminder.TabIndex = 8;
            this.listReminder.UseCompatibleStateImageBehavior = false;
            this.listReminder.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ID";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Tên cuộc họp";
            this.columnHeader9.Width = 188;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Thời gian nhắc trước";
            this.columnHeader10.Width = 192;
            // 
            // UserForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1276, 764);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_menu);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            this.panel_taikhoan.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.ListView listApp;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Panel panel_taikhoan;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_tk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_loc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_appDate;
        private System.Windows.Forms.DateTimePicker dtp_endtime;
        private System.Windows.Forms.DateTimePicker dtp_starttime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_des;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_capnhat;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_RemoveAtt;
        private System.Windows.Forms.Button btn_AddAtt;
        private System.Windows.Forms.ComboBox cbb_attendance;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView listAtt;
        private System.Windows.Forms.Button btn_removeRemider;
        private System.Windows.Forms.Button btn_addReminder;
        private System.Windows.Forms.ComboBox cbb_reminderTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView listReminder;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
    }
}