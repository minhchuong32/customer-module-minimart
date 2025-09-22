using System.Drawing;

namespace MiniMart.GUI
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.tabMain = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabCustomers = new System.Windows.Forms.TabPage();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.dgvCustomers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.cboStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboGender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.dtpBirthDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFullName = new Guna.UI2.WinForms.Guna2TextBox();
            this.tabAccount = new System.Windows.Forms.TabPage();
            this.dgvTaiKhoan = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label19 = new System.Windows.Forms.Label();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ToggleShowPass = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.cboMemberLevel = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCustomerID_Acc = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnViewAccount = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateAcc = new Guna.UI2.WinForms.Guna2Button();
            this.btnCreateAccount = new Guna.UI2.WinForms.Guna2Button();
            this.btnLoadAllAccounts = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelAcc = new Guna.UI2.WinForms.Guna2Button();
            this.tabQuaTang = new System.Windows.Forms.TabPage();
            this.guna2GroupBox6 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvGiftHistory = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label22 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.btnLoadGiftHistory = new Guna.UI2.WinForms.Guna2Button();
            this.lblPoint_gift = new System.Windows.Forms.Label();
            this.guna2GroupBox5 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvGifts = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnAddGift = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteGift = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditGift = new Guna.UI2.WinForms.Guna2Button();
            this.btnLoadGifts = new Guna.UI2.WinForms.Guna2Button();
            this.btnRedeemGift = new Guna.UI2.WinForms.Guna2Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtIdCustomer_gift = new Guna.UI2.WinForms.Guna2TextBox();
            this.chkIsActive = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txtPointsRequired = new Guna.UI2.WinForms.Guna2TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtGiftName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtGiftID = new Guna.UI2.WinForms.Guna2TextBox();
            this.tabInvoice = new System.Windows.Forms.TabPage();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnLoadTrans = new Guna.UI2.WinForms.Guna2Button();
            this.label27 = new System.Windows.Forms.Label();
            this.dgvTrans = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label40 = new System.Windows.Forms.Label();
            this.txtInvoiceID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.dgvThongTinHoaDon = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnTimHoaDon = new Guna.UI2.WinForms.Guna2Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCustomerID_HoaDon = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnDoiDiem = new Guna.UI2.WinForms.Guna2Button();
            this.tabStatistics = new System.Windows.Forms.TabPage();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.tabChat = new System.Windows.Forms.TabPage();
            this.guna2GroupBox9 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label39 = new System.Windows.Forms.Label();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.cbbCustomers = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lstConversation = new System.Windows.Forms.ListBox();
            this.label42 = new System.Windows.Forms.Label();
            this.txtMessage = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSend = new Guna.UI2.WinForms.Guna2Button();
            this.tabSystem = new System.Windows.Forms.TabPage();
            this.guna2GroupBox4 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtPosition_ad = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpHireDate_ad = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label51 = new System.Windows.Forms.Label();
            this.guna2GroupBox10 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.txtPassword_ad = new Guna.UI2.WinForms.Guna2TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.txtUsername_ad = new Guna.UI2.WinForms.Guna2TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.btnLuuQuyDoi = new Guna.UI2.WinForms.Guna2Button();
            this.dtpBirthDate_ad = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cbbGender_ad = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtAddress_ad = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail_ad = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPhone_ad = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFullname_ad = new Guna.UI2.WinForms.Guna2TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbbRoleRate = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.txtTiLeQuyDoi = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblServer = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.SettingUser = new System.Windows.Forms.TabPage();
            this.guna2GroupBox8 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dtpNgaySinh_cus = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cbbTrangThai_cus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbGioiTinh_cus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtDiaChi_cus = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtEmail_cus = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSdt_cus = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtHoten_cus = new Guna.UI2.WinForms.Guna2TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.guna2GroupBox7 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblCapDo_cus = new System.Windows.Forms.Label();
            this.lblPoints_cus = new System.Windows.Forms.Label();
            this.txtPass_cus = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUsername_cus = new Guna.UI2.WinForms.Guna2TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnLuuThayDoi_cus = new Guna.UI2.WinForms.Guna2Button();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2BorderlessForm2 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.chartStatsVip = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabMain.SuspendLayout();
            this.tabCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.tabAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.tabQuaTang.SuspendLayout();
            this.guna2GroupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiftHistory)).BeginInit();
            this.guna2GroupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGifts)).BeginInit();
            this.tabInvoice.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrans)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinHoaDon)).BeginInit();
            this.tabStatistics.SuspendLayout();
            this.tabChat.SuspendLayout();
            this.guna2GroupBox9.SuspendLayout();
            this.tabSystem.SuspendLayout();
            this.guna2GroupBox4.SuspendLayout();
            this.guna2GroupBox10.SuspendLayout();
            this.guna2GroupBox3.SuspendLayout();
            this.SettingUser.SuspendLayout();
            this.guna2GroupBox8.SuspendLayout();
            this.guna2GroupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatsVip)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabMain.Controls.Add(this.tabCustomers);
            this.tabMain.Controls.Add(this.tabAccount);
            this.tabMain.Controls.Add(this.tabQuaTang);
            this.tabMain.Controls.Add(this.tabInvoice);
            this.tabMain.Controls.Add(this.tabStatistics);
            this.tabMain.Controls.Add(this.tabChat);
            this.tabMain.Controls.Add(this.tabSystem);
            this.tabMain.Controls.Add(this.SettingUser);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.ItemSize = new System.Drawing.Size(180, 40);
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1282, 675);
            this.tabMain.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabMain.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.tabMain.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabMain.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tabMain.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabMain.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabMain.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabMain.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabMain.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tabMain.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabMain.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabMain.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tabMain.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabMain.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tabMain.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tabMain.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tabMain.TabIndex = 0;
            this.tabMain.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            // 
            // tabCustomers
            // 
            this.tabCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabCustomers.Controls.Add(this.btnUpdate);
            this.tabCustomers.Controls.Add(this.btnDelete);
            this.tabCustomers.Controls.Add(this.btnAdd);
            this.tabCustomers.Controls.Add(this.dgvCustomers);
            this.tabCustomers.Controls.Add(this.label8);
            this.tabCustomers.Controls.Add(this.label7);
            this.tabCustomers.Controls.Add(this.label6);
            this.tabCustomers.Controls.Add(this.label5);
            this.tabCustomers.Controls.Add(this.label4);
            this.tabCustomers.Controls.Add(this.label3);
            this.tabCustomers.Controls.Add(this.label2);
            this.tabCustomers.Controls.Add(this.label1);
            this.tabCustomers.Controls.Add(this.guna2Button1);
            this.tabCustomers.Controls.Add(this.txtSearch);
            this.tabCustomers.Controls.Add(this.btnSearch);
            this.tabCustomers.Controls.Add(this.cboStatus);
            this.tabCustomers.Controls.Add(this.cboGender);
            this.tabCustomers.Controls.Add(this.btnClear);
            this.tabCustomers.Controls.Add(this.dtpBirthDate);
            this.tabCustomers.Controls.Add(this.txtAddress);
            this.tabCustomers.Controls.Add(this.txtEmail);
            this.tabCustomers.Controls.Add(this.txtPhone);
            this.tabCustomers.Controls.Add(this.txtFullName);
            this.tabCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCustomers.Location = new System.Drawing.Point(184, 4);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomers.Size = new System.Drawing.Size(1094, 667);
            this.tabCustomers.TabIndex = 2;
            this.tabCustomers.Text = "Khách hàng";
            this.tabCustomers.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = global::MiniMart.Properties.Resources.edit;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUpdate.BorderColor = System.Drawing.Color.Yellow;
            this.btnUpdate.BorderRadius = 10;
            this.btnUpdate.BorderThickness = 3;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(877, 492);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 45);
            this.btnUpdate.TabIndex = 37;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::MiniMart.Properties.Resources.delete;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDelete.BorderColor = System.Drawing.Color.Red;
            this.btnDelete.BorderRadius = 10;
            this.btnDelete.BorderThickness = 3;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.Transparent;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(877, 607);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 45);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::MiniMart.Properties.Resources.add;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.BorderRadius = 10;
            this.btnAdd.BorderThickness = 3;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.Transparent;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(877, 381);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 45);
            this.btnAdd.TabIndex = 35;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AllowUserToResizeColumns = false;
            this.dgvCustomers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvCustomers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCustomers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomers.ColumnHeadersHeight = 20;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCustomers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvCustomers.Location = new System.Drawing.Point(113, 381);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.RowHeadersWidth = 51;
            this.dgvCustomers.RowTemplate.Height = 24;
            this.dgvCustomers.Size = new System.Drawing.Size(742, 271);
            this.dgvCustomers.TabIndex = 25;
            this.dgvCustomers.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvCustomers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCustomers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCustomers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCustomers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCustomers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCustomers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCustomers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvCustomers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvCustomers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCustomers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCustomers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvCustomers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCustomers.ThemeStyle.HeaderStyle.Height = 20;
            this.dgvCustomers.ThemeStyle.ReadOnly = true;
            this.dgvCustomers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCustomers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCustomers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCustomers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.dgvCustomers.ThemeStyle.RowsStyle.Height = 24;
            this.dgvCustomers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvCustomers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCustomers.SelectionChanged += new System.EventHandler(this.dgvCustomers_SelectionChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.label8.Location = new System.Drawing.Point(109, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Thông tin khách hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(852, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Ngày sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(385, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "SDT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(385, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(118, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(118, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(662, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Trạng thái";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(662, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Giới tính";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(3, 3);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(1088, 65);
            this.guna2Button1.TabIndex = 15;
            this.guna2Button1.Text = "MiniMart";
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(110, 88);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSearch.PlaceholderText = "Nhập từ khóa tìm kiếm..";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(745, 48);
            this.txtSearch.TabIndex = 14;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::MiniMart.Properties.Resources.search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.Transparent;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(862, 88);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(59, 48);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboStatus
            // 
            this.cboStatus.BackColor = System.Drawing.Color.Transparent;
            this.cboStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboStatus.ItemHeight = 30;
            this.cboStatus.Items.AddRange(new object[] {
            "Active",
            "Disactive"});
            this.cboStatus.Location = new System.Drawing.Point(665, 269);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(140, 36);
            this.cboStatus.TabIndex = 5;
            // 
            // cboGender
            // 
            this.cboGender.BackColor = System.Drawing.Color.Transparent;
            this.cboGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboGender.ItemHeight = 30;
            this.cboGender.Items.AddRange(new object[] {
            "Nam ",
            "Nữ",
            "Khác"});
            this.cboGender.Location = new System.Drawing.Point(665, 174);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(140, 36);
            this.cboGender.TabIndex = 4;
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = global::MiniMart.Properties.Resources.clear;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.Transparent;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(862, 162);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(67, 60);
            this.btnClear.TabIndex = 12;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Checked = true;
            this.dtpBirthDate.FillColor = System.Drawing.Color.White;
            this.dtpBirthDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(856, 269);
            this.dtpBirthDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpBirthDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(200, 36);
            this.dtpBirthDate.TabIndex = 8;
            this.dtpBirthDate.Value = new System.DateTime(2025, 9, 14, 23, 13, 57, 878);
            // 
            // txtAddress
            // 
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Location = new System.Drawing.Point(377, 269);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtAddress.PlaceholderText = "Địa chỉ..";
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(229, 36);
            this.txtAddress.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(110, 269);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtEmail.PlaceholderText = "Email..";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(229, 36);
            this.txtEmail.TabIndex = 2;
            // 
            // txtPhone
            // 
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.DefaultText = "";
            this.txtPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Location = new System.Drawing.Point(377, 174);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPhone.PlaceholderText = "SDT..";
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(229, 36);
            this.txtPhone.TabIndex = 1;
            // 
            // txtFullName
            // 
            this.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullName.DefaultText = "";
            this.txtFullName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFullName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFullName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFullName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFullName.Location = new System.Drawing.Point(110, 174);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtFullName.PlaceholderText = "Họ tên..";
            this.txtFullName.SelectedText = "";
            this.txtFullName.Size = new System.Drawing.Size(229, 36);
            this.txtFullName.TabIndex = 0;
            // 
            // tabAccount
            // 
            this.tabAccount.Controls.Add(this.dgvTaiKhoan);
            this.tabAccount.Controls.Add(this.label19);
            this.tabAccount.Controls.Add(this.guna2Button2);
            this.tabAccount.Controls.Add(this.guna2ToggleShowPass);
            this.tabAccount.Controls.Add(this.label13);
            this.tabAccount.Controls.Add(this.label12);
            this.tabAccount.Controls.Add(this.label11);
            this.tabAccount.Controls.Add(this.label10);
            this.tabAccount.Controls.Add(this.label9);
            this.tabAccount.Controls.Add(this.lblPoints);
            this.tabAccount.Controls.Add(this.cboMemberLevel);
            this.tabAccount.Controls.Add(this.txtPassword);
            this.tabAccount.Controls.Add(this.txtCustomerID_Acc);
            this.tabAccount.Controls.Add(this.txtUsername);
            this.tabAccount.Controls.Add(this.btnViewAccount);
            this.tabAccount.Controls.Add(this.btnUpdateAcc);
            this.tabAccount.Controls.Add(this.btnCreateAccount);
            this.tabAccount.Controls.Add(this.btnLoadAllAccounts);
            this.tabAccount.Controls.Add(this.btnDelAcc);
            this.tabAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabAccount.Location = new System.Drawing.Point(184, 4);
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccount.Size = new System.Drawing.Size(1094, 667);
            this.tabAccount.TabIndex = 1;
            this.tabAccount.Text = "Tài khoản";
            this.tabAccount.UseVisualStyleBackColor = true;
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.AllowUserToAddRows = false;
            this.dgvTaiKhoan.AllowUserToDeleteRows = false;
            this.dgvTaiKhoan.AllowUserToResizeColumns = false;
            this.dgvTaiKhoan.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvTaiKhoan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTaiKhoan.ColumnHeadersHeight = 20;
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTaiKhoan.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTaiKhoan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvTaiKhoan.Location = new System.Drawing.Point(66, 339);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.ReadOnly = true;
            this.dgvTaiKhoan.RowHeadersVisible = false;
            this.dgvTaiKhoan.RowHeadersWidth = 51;
            this.dgvTaiKhoan.RowTemplate.Height = 24;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(808, 284);
            this.dgvTaiKhoan.TabIndex = 38;
            this.dgvTaiKhoan.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvTaiKhoan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTaiKhoan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTaiKhoan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTaiKhoan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTaiKhoan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTaiKhoan.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvTaiKhoan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvTaiKhoan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvTaiKhoan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTaiKhoan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTaiKhoan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTaiKhoan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTaiKhoan.ThemeStyle.HeaderStyle.Height = 20;
            this.dgvTaiKhoan.ThemeStyle.ReadOnly = true;
            this.dgvTaiKhoan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTaiKhoan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTaiKhoan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTaiKhoan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.dgvTaiKhoan.ThemeStyle.RowsStyle.Height = 24;
            this.dgvTaiKhoan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvTaiKhoan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTaiKhoan.SelectionChanged += new System.EventHandler(this.dgvTaiKhoan_SelectionChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.label19.Location = new System.Drawing.Point(73, 316);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(152, 20);
            this.label19.TabIndex = 37;
            this.label19.Text = "Danh sách tài khoản";
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 5;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(3, 3);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(1088, 65);
            this.guna2Button2.TabIndex = 31;
            this.guna2Button2.Text = "MiniMart";
            // 
            // guna2ToggleShowPass
            // 
            this.guna2ToggleShowPass.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleShowPass.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleShowPass.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleShowPass.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ToggleShowPass.Location = new System.Drawing.Point(627, 239);
            this.guna2ToggleShowPass.Name = "guna2ToggleShowPass";
            this.guna2ToggleShowPass.Size = new System.Drawing.Size(50, 30);
            this.guna2ToggleShowPass.TabIndex = 25;
            this.guna2ToggleShowPass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleShowPass.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleShowPass.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleShowPass.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleShowPass.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch1_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(779, 197);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "Tổng điểm:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(388, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Cấp độ thành viên";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(73, 197);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Tên đăng nhập";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(388, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Mật khẩu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(73, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "ID Khách hàng";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblPoints.Location = new System.Drawing.Point(871, 187);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(84, 32);
            this.lblPoints.TabIndex = 6;
            this.lblPoints.Text = "Điểm";
            // 
            // cboMemberLevel
            // 
            this.cboMemberLevel.AutoCompleteCustomSource.AddRange(new string[] {
            "Normal",
            "VIP"});
            this.cboMemberLevel.BackColor = System.Drawing.Color.Transparent;
            this.cboMemberLevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMemberLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMemberLevel.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboMemberLevel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboMemberLevel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboMemberLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboMemberLevel.ItemHeight = 30;
            this.cboMemberLevel.Items.AddRange(new object[] {
            "Normal",
            "VIP"});
            this.cboMemberLevel.Location = new System.Drawing.Point(382, 142);
            this.cboMemberLevel.Name = "cboMemberLevel";
            this.cboMemberLevel.Size = new System.Drawing.Size(140, 36);
            this.cboMemberLevel.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(382, 221);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(229, 48);
            this.txtPassword.TabIndex = 2;
            // 
            // txtCustomerID_Acc
            // 
            this.txtCustomerID_Acc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerID_Acc.DefaultText = "";
            this.txtCustomerID_Acc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCustomerID_Acc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCustomerID_Acc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerID_Acc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerID_Acc.Enabled = false;
            this.txtCustomerID_Acc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerID_Acc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCustomerID_Acc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerID_Acc.Location = new System.Drawing.Point(66, 142);
            this.txtCustomerID_Acc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCustomerID_Acc.Name = "txtCustomerID_Acc";
            this.txtCustomerID_Acc.PlaceholderText = "ID";
            this.txtCustomerID_Acc.ReadOnly = true;
            this.txtCustomerID_Acc.SelectedText = "";
            this.txtCustomerID_Acc.Size = new System.Drawing.Size(114, 33);
            this.txtCustomerID_Acc.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Location = new System.Drawing.Point(66, 221);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceholderText = "Username";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(229, 48);
            this.txtUsername.TabIndex = 0;
            // 
            // btnViewAccount
            // 
            this.btnViewAccount.BackgroundImage = global::MiniMart.Properties.Resources.view;
            this.btnViewAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnViewAccount.BorderRadius = 10;
            this.btnViewAccount.BorderThickness = 1;
            this.btnViewAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewAccount.FillColor = System.Drawing.Color.Transparent;
            this.btnViewAccount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnViewAccount.ForeColor = System.Drawing.Color.Black;
            this.btnViewAccount.Location = new System.Drawing.Point(186, 142);
            this.btnViewAccount.Name = "btnViewAccount";
            this.btnViewAccount.Size = new System.Drawing.Size(66, 33);
            this.btnViewAccount.TabIndex = 36;
            this.btnViewAccount.Click += new System.EventHandler(this.btnViewAccount_Click);
            // 
            // btnUpdateAcc
            // 
            this.btnUpdateAcc.BackgroundImage = global::MiniMart.Properties.Resources.create;
            this.btnUpdateAcc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUpdateAcc.BorderColor = System.Drawing.Color.Gold;
            this.btnUpdateAcc.BorderRadius = 10;
            this.btnUpdateAcc.BorderThickness = 3;
            this.btnUpdateAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateAcc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateAcc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateAcc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateAcc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateAcc.FillColor = System.Drawing.Color.Transparent;
            this.btnUpdateAcc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdateAcc.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateAcc.Location = new System.Drawing.Point(914, 499);
            this.btnUpdateAcc.Name = "btnUpdateAcc";
            this.btnUpdateAcc.Size = new System.Drawing.Size(84, 45);
            this.btnUpdateAcc.TabIndex = 35;
            this.btnUpdateAcc.Click += new System.EventHandler(this.btnUpdateAcc_Click);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackgroundImage = global::MiniMart.Properties.Resources.add;
            this.btnCreateAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCreateAccount.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnCreateAccount.BorderRadius = 10;
            this.btnCreateAccount.BorderThickness = 3;
            this.btnCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreateAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreateAccount.FillColor = System.Drawing.Color.Transparent;
            this.btnCreateAccount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCreateAccount.ForeColor = System.Drawing.Color.Black;
            this.btnCreateAccount.Location = new System.Drawing.Point(914, 415);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(84, 45);
            this.btnCreateAccount.TabIndex = 34;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // btnLoadAllAccounts
            // 
            this.btnLoadAllAccounts.BackgroundImage = global::MiniMart.Properties.Resources.view;
            this.btnLoadAllAccounts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLoadAllAccounts.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnLoadAllAccounts.BorderRadius = 10;
            this.btnLoadAllAccounts.BorderThickness = 3;
            this.btnLoadAllAccounts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadAllAccounts.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoadAllAccounts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoadAllAccounts.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoadAllAccounts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoadAllAccounts.FillColor = System.Drawing.Color.Transparent;
            this.btnLoadAllAccounts.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLoadAllAccounts.ForeColor = System.Drawing.Color.Black;
            this.btnLoadAllAccounts.Location = new System.Drawing.Point(914, 339);
            this.btnLoadAllAccounts.Name = "btnLoadAllAccounts";
            this.btnLoadAllAccounts.Size = new System.Drawing.Size(84, 49);
            this.btnLoadAllAccounts.TabIndex = 33;
            this.btnLoadAllAccounts.Click += new System.EventHandler(this.btnLoadAllAccounts_Click);
            // 
            // btnDelAcc
            // 
            this.btnDelAcc.BackgroundImage = global::MiniMart.Properties.Resources.delete;
            this.btnDelAcc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDelAcc.BorderColor = System.Drawing.Color.Red;
            this.btnDelAcc.BorderRadius = 10;
            this.btnDelAcc.BorderThickness = 3;
            this.btnDelAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelAcc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelAcc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelAcc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelAcc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelAcc.FillColor = System.Drawing.Color.Transparent;
            this.btnDelAcc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelAcc.ForeColor = System.Drawing.Color.Black;
            this.btnDelAcc.Location = new System.Drawing.Point(914, 578);
            this.btnDelAcc.Name = "btnDelAcc";
            this.btnDelAcc.Size = new System.Drawing.Size(84, 45);
            this.btnDelAcc.TabIndex = 32;
            this.btnDelAcc.Click += new System.EventHandler(this.btnDelAcc_Click);
            // 
            // tabQuaTang
            // 
            this.tabQuaTang.Controls.Add(this.guna2GroupBox6);
            this.tabQuaTang.Controls.Add(this.guna2GroupBox5);
            this.tabQuaTang.Location = new System.Drawing.Point(184, 4);
            this.tabQuaTang.Name = "tabQuaTang";
            this.tabQuaTang.Size = new System.Drawing.Size(1094, 667);
            this.tabQuaTang.TabIndex = 5;
            this.tabQuaTang.Text = "Quà tặng";
            this.tabQuaTang.UseVisualStyleBackColor = true;
            // 
            // guna2GroupBox6
            // 
            this.guna2GroupBox6.Controls.Add(this.dgvGiftHistory);
            this.guna2GroupBox6.Controls.Add(this.label22);
            this.guna2GroupBox6.Controls.Add(this.label24);
            this.guna2GroupBox6.Controls.Add(this.btnLoadGiftHistory);
            this.guna2GroupBox6.Controls.Add(this.lblPoint_gift);
            this.guna2GroupBox6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2GroupBox6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox6.Location = new System.Drawing.Point(0, 351);
            this.guna2GroupBox6.Name = "guna2GroupBox6";
            this.guna2GroupBox6.Size = new System.Drawing.Size(1094, 316);
            this.guna2GroupBox6.TabIndex = 10;
            this.guna2GroupBox6.Text = "Lịch sử";
            // 
            // dgvGiftHistory
            // 
            this.dgvGiftHistory.AllowUserToAddRows = false;
            this.dgvGiftHistory.AllowUserToDeleteRows = false;
            this.dgvGiftHistory.AllowUserToResizeColumns = false;
            this.dgvGiftHistory.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvGiftHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvGiftHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGiftHistory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGiftHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvGiftHistory.ColumnHeadersHeight = 20;
            this.dgvGiftHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGiftHistory.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvGiftHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvGiftHistory.Location = new System.Drawing.Point(311, 91);
            this.dgvGiftHistory.Name = "dgvGiftHistory";
            this.dgvGiftHistory.ReadOnly = true;
            this.dgvGiftHistory.RowHeadersVisible = false;
            this.dgvGiftHistory.RowHeadersWidth = 51;
            this.dgvGiftHistory.RowTemplate.Height = 24;
            this.dgvGiftHistory.Size = new System.Drawing.Size(679, 194);
            this.dgvGiftHistory.TabIndex = 40;
            this.dgvGiftHistory.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvGiftHistory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvGiftHistory.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvGiftHistory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvGiftHistory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvGiftHistory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvGiftHistory.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvGiftHistory.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvGiftHistory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvGiftHistory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvGiftHistory.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvGiftHistory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvGiftHistory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvGiftHistory.ThemeStyle.HeaderStyle.Height = 20;
            this.dgvGiftHistory.ThemeStyle.ReadOnly = true;
            this.dgvGiftHistory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvGiftHistory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvGiftHistory.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvGiftHistory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.dgvGiftHistory.ThemeStyle.RowsStyle.Height = 24;
            this.dgvGiftHistory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvGiftHistory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.label22.Location = new System.Drawing.Point(307, 68);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(124, 20);
            this.label22.TabIndex = 38;
            this.label22.Text = "Lịch sử quà tặng";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(301, 58);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(0, 20);
            this.label24.TabIndex = 17;
            // 
            // btnLoadGiftHistory
            // 
            this.btnLoadGiftHistory.BorderRadius = 10;
            this.btnLoadGiftHistory.BorderThickness = 1;
            this.btnLoadGiftHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadGiftHistory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoadGiftHistory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoadGiftHistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoadGiftHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoadGiftHistory.FillColor = System.Drawing.Color.White;
            this.btnLoadGiftHistory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLoadGiftHistory.ForeColor = System.Drawing.Color.Black;
            this.btnLoadGiftHistory.Location = new System.Drawing.Point(35, 240);
            this.btnLoadGiftHistory.Name = "btnLoadGiftHistory";
            this.btnLoadGiftHistory.Size = new System.Drawing.Size(136, 45);
            this.btnLoadGiftHistory.TabIndex = 39;
            this.btnLoadGiftHistory.Text = "Xem lịch sử";
            this.btnLoadGiftHistory.Click += new System.EventHandler(this.btnLoadGiftHistory_Click);
            // 
            // lblPoint_gift
            // 
            this.lblPoint_gift.AutoSize = true;
            this.lblPoint_gift.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoint_gift.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPoint_gift.Location = new System.Drawing.Point(29, 91);
            this.lblPoint_gift.Name = "lblPoint_gift";
            this.lblPoint_gift.Size = new System.Drawing.Size(77, 31);
            this.lblPoint_gift.TabIndex = 6;
            this.lblPoint_gift.Text = "Điểm:";
            // 
            // guna2GroupBox5
            // 
            this.guna2GroupBox5.Controls.Add(this.dgvGifts);
            this.guna2GroupBox5.Controls.Add(this.btnAddGift);
            this.guna2GroupBox5.Controls.Add(this.btnDeleteGift);
            this.guna2GroupBox5.Controls.Add(this.btnEditGift);
            this.guna2GroupBox5.Controls.Add(this.btnLoadGifts);
            this.guna2GroupBox5.Controls.Add(this.btnRedeemGift);
            this.guna2GroupBox5.Controls.Add(this.label20);
            this.guna2GroupBox5.Controls.Add(this.label23);
            this.guna2GroupBox5.Controls.Add(this.txtIdCustomer_gift);
            this.guna2GroupBox5.Controls.Add(this.chkIsActive);
            this.guna2GroupBox5.Controls.Add(this.txtPointsRequired);
            this.guna2GroupBox5.Controls.Add(this.label21);
            this.guna2GroupBox5.Controls.Add(this.txtGiftName);
            this.guna2GroupBox5.Controls.Add(this.label18);
            this.guna2GroupBox5.Controls.Add(this.label16);
            this.guna2GroupBox5.Controls.Add(this.txtGiftID);
            this.guna2GroupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GroupBox5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox5.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox5.Name = "guna2GroupBox5";
            this.guna2GroupBox5.Size = new System.Drawing.Size(1094, 345);
            this.guna2GroupBox5.TabIndex = 9;
            this.guna2GroupBox5.Text = "Đổi quà";
            // 
            // dgvGifts
            // 
            this.dgvGifts.AllowUserToAddRows = false;
            this.dgvGifts.AllowUserToDeleteRows = false;
            this.dgvGifts.AllowUserToResizeColumns = false;
            this.dgvGifts.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgvGifts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvGifts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGifts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGifts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvGifts.ColumnHeadersHeight = 20;
            this.dgvGifts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGifts.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvGifts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvGifts.Location = new System.Drawing.Point(29, 106);
            this.dgvGifts.Name = "dgvGifts";
            this.dgvGifts.ReadOnly = true;
            this.dgvGifts.RowHeadersVisible = false;
            this.dgvGifts.RowHeadersWidth = 51;
            this.dgvGifts.RowTemplate.Height = 24;
            this.dgvGifts.Size = new System.Drawing.Size(517, 214);
            this.dgvGifts.TabIndex = 47;
            this.dgvGifts.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvGifts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvGifts.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvGifts.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvGifts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvGifts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvGifts.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvGifts.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvGifts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvGifts.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvGifts.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvGifts.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvGifts.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvGifts.ThemeStyle.HeaderStyle.Height = 20;
            this.dgvGifts.ThemeStyle.ReadOnly = true;
            this.dgvGifts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvGifts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvGifts.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvGifts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.dgvGifts.ThemeStyle.RowsStyle.Height = 24;
            this.dgvGifts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvGifts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvGifts.SelectionChanged += new System.EventHandler(this.dgvGifts_SelectionChanged);
            // 
            // btnAddGift
            // 
            this.btnAddGift.BackgroundImage = global::MiniMart.Properties.Resources.add;
            this.btnAddGift.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddGift.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnAddGift.BorderRadius = 10;
            this.btnAddGift.BorderThickness = 3;
            this.btnAddGift.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddGift.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddGift.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddGift.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddGift.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddGift.FillColor = System.Drawing.Color.Transparent;
            this.btnAddGift.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddGift.ForeColor = System.Drawing.Color.Black;
            this.btnAddGift.Location = new System.Drawing.Point(588, 163);
            this.btnAddGift.Name = "btnAddGift";
            this.btnAddGift.Size = new System.Drawing.Size(76, 37);
            this.btnAddGift.TabIndex = 45;
            this.btnAddGift.Click += new System.EventHandler(this.btnAddGift_Click);
            // 
            // btnDeleteGift
            // 
            this.btnDeleteGift.BackgroundImage = global::MiniMart.Properties.Resources.delete;
            this.btnDeleteGift.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDeleteGift.BorderColor = System.Drawing.Color.Red;
            this.btnDeleteGift.BorderRadius = 10;
            this.btnDeleteGift.BorderThickness = 3;
            this.btnDeleteGift.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteGift.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteGift.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteGift.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteGift.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteGift.FillColor = System.Drawing.Color.Transparent;
            this.btnDeleteGift.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteGift.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteGift.Location = new System.Drawing.Point(588, 283);
            this.btnDeleteGift.Name = "btnDeleteGift";
            this.btnDeleteGift.Size = new System.Drawing.Size(76, 37);
            this.btnDeleteGift.TabIndex = 44;
            this.btnDeleteGift.Click += new System.EventHandler(this.btnDeleteGift_Click);
            // 
            // btnEditGift
            // 
            this.btnEditGift.BackgroundImage = global::MiniMart.Properties.Resources.view;
            this.btnEditGift.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditGift.BorderColor = System.Drawing.Color.Gold;
            this.btnEditGift.BorderRadius = 10;
            this.btnEditGift.BorderThickness = 3;
            this.btnEditGift.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditGift.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditGift.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditGift.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditGift.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditGift.FillColor = System.Drawing.Color.Transparent;
            this.btnEditGift.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditGift.ForeColor = System.Drawing.Color.Black;
            this.btnEditGift.Location = new System.Drawing.Point(588, 219);
            this.btnEditGift.Name = "btnEditGift";
            this.btnEditGift.Size = new System.Drawing.Size(76, 37);
            this.btnEditGift.TabIndex = 43;
            this.btnEditGift.Click += new System.EventHandler(this.btnEditGift_Click);
            // 
            // btnLoadGifts
            // 
            this.btnLoadGifts.BackgroundImage = global::MiniMart.Properties.Resources.view;
            this.btnLoadGifts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLoadGifts.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnLoadGifts.BorderRadius = 10;
            this.btnLoadGifts.BorderThickness = 3;
            this.btnLoadGifts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadGifts.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoadGifts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoadGifts.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoadGifts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoadGifts.FillColor = System.Drawing.Color.Transparent;
            this.btnLoadGifts.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLoadGifts.ForeColor = System.Drawing.Color.Black;
            this.btnLoadGifts.Location = new System.Drawing.Point(588, 97);
            this.btnLoadGifts.Name = "btnLoadGifts";
            this.btnLoadGifts.Size = new System.Drawing.Size(76, 37);
            this.btnLoadGifts.TabIndex = 42;
            this.btnLoadGifts.Click += new System.EventHandler(this.btnLoadGifts_Click);
            // 
            // btnRedeemGift
            // 
            this.btnRedeemGift.BorderColor = System.Drawing.Color.Green;
            this.btnRedeemGift.BorderRadius = 10;
            this.btnRedeemGift.BorderThickness = 5;
            this.btnRedeemGift.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRedeemGift.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRedeemGift.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRedeemGift.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRedeemGift.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRedeemGift.FillColor = System.Drawing.Color.White;
            this.btnRedeemGift.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRedeemGift.ForeColor = System.Drawing.Color.Black;
            this.btnRedeemGift.Location = new System.Drawing.Point(870, 275);
            this.btnRedeemGift.Name = "btnRedeemGift";
            this.btnRedeemGift.Size = new System.Drawing.Size(136, 45);
            this.btnRedeemGift.TabIndex = 41;
            this.btnRedeemGift.Text = "Đổi quà";
            this.btnRedeemGift.Click += new System.EventHandler(this.btnRedeemGift_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.label20.Location = new System.Drawing.Point(31, 79);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(150, 20);
            this.label20.TabIndex = 38;
            this.label20.Text = "Danh sách quà tặng";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(866, 79);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(103, 20);
            this.label23.TabIndex = 16;
            this.label23.Text = "ID khách hàng";
            // 
            // txtIdCustomer_gift
            // 
            this.txtIdCustomer_gift.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdCustomer_gift.DefaultText = "";
            this.txtIdCustomer_gift.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdCustomer_gift.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdCustomer_gift.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdCustomer_gift.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdCustomer_gift.Enabled = false;
            this.txtIdCustomer_gift.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdCustomer_gift.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdCustomer_gift.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdCustomer_gift.Location = new System.Drawing.Point(870, 106);
            this.txtIdCustomer_gift.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIdCustomer_gift.Name = "txtIdCustomer_gift";
            this.txtIdCustomer_gift.PlaceholderText = "";
            this.txtIdCustomer_gift.SelectedText = "";
            this.txtIdCustomer_gift.Size = new System.Drawing.Size(50, 28);
            this.txtIdCustomer_gift.TabIndex = 15;
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkIsActive.CheckedState.BorderRadius = 0;
            this.chkIsActive.CheckedState.BorderThickness = 0;
            this.chkIsActive.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkIsActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkIsActive.ForeColor = System.Drawing.Color.Black;
            this.chkIsActive.Location = new System.Drawing.Point(720, 296);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(94, 24);
            this.chkIsActive.TabIndex = 11;
            this.chkIsActive.Text = "Còn hàng";
            this.chkIsActive.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkIsActive.UncheckedState.BorderRadius = 0;
            this.chkIsActive.UncheckedState.BorderThickness = 0;
            this.chkIsActive.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // txtPointsRequired
            // 
            this.txtPointsRequired.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPointsRequired.DefaultText = "";
            this.txtPointsRequired.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPointsRequired.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPointsRequired.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPointsRequired.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPointsRequired.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPointsRequired.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPointsRequired.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPointsRequired.Location = new System.Drawing.Point(720, 243);
            this.txtPointsRequired.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPointsRequired.Name = "txtPointsRequired";
            this.txtPointsRequired.PlaceholderText = "";
            this.txtPointsRequired.SelectedText = "";
            this.txtPointsRequired.Size = new System.Drawing.Size(115, 28);
            this.txtPointsRequired.TabIndex = 10;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(716, 219);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(122, 20);
            this.label21.TabIndex = 9;
            this.label21.Text = "Điểm cần để đổi:";
            // 
            // txtGiftName
            // 
            this.txtGiftName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiftName.DefaultText = "";
            this.txtGiftName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGiftName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGiftName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiftName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiftName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiftName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGiftName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiftName.Location = new System.Drawing.Point(720, 172);
            this.txtGiftName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiftName.Name = "txtGiftName";
            this.txtGiftName.PlaceholderText = "";
            this.txtGiftName.SelectedText = "";
            this.txtGiftName.Size = new System.Drawing.Size(115, 28);
            this.txtGiftName.TabIndex = 8;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(715, 148);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(98, 20);
            this.label18.TabIndex = 6;
            this.label18.Text = "Tên quà tặng:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(716, 79);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 20);
            this.label16.TabIndex = 2;
            this.label16.Text = "Mã quà tặng:";
            // 
            // txtGiftID
            // 
            this.txtGiftID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiftID.DefaultText = "";
            this.txtGiftID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGiftID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGiftID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiftID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiftID.Enabled = false;
            this.txtGiftID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiftID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGiftID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiftID.Location = new System.Drawing.Point(719, 106);
            this.txtGiftID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiftID.Name = "txtGiftID";
            this.txtGiftID.PlaceholderText = "";
            this.txtGiftID.SelectedText = "";
            this.txtGiftID.Size = new System.Drawing.Size(115, 28);
            this.txtGiftID.TabIndex = 3;
            // 
            // tabInvoice
            // 
            this.tabInvoice.Controls.Add(this.guna2GroupBox2);
            this.tabInvoice.Controls.Add(this.guna2GroupBox1);
            this.tabInvoice.Location = new System.Drawing.Point(184, 4);
            this.tabInvoice.Name = "tabInvoice";
            this.tabInvoice.Padding = new System.Windows.Forms.Padding(3);
            this.tabInvoice.Size = new System.Drawing.Size(1094, 667);
            this.tabInvoice.TabIndex = 3;
            this.tabInvoice.Text = "Hóa đơn ";
            this.tabInvoice.UseVisualStyleBackColor = true;
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Controls.Add(this.btnLoadTrans);
            this.guna2GroupBox2.Controls.Add(this.label27);
            this.guna2GroupBox2.Controls.Add(this.dgvTrans);
            this.guna2GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox2.Location = new System.Drawing.Point(3, 346);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(1088, 318);
            this.guna2GroupBox2.TabIndex = 7;
            this.guna2GroupBox2.Text = "Lịch sử giao dịch";
            // 
            // btnLoadTrans
            // 
            this.btnLoadTrans.BorderRadius = 10;
            this.btnLoadTrans.BorderThickness = 1;
            this.btnLoadTrans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadTrans.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoadTrans.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoadTrans.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoadTrans.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoadTrans.FillColor = System.Drawing.Color.White;
            this.btnLoadTrans.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLoadTrans.ForeColor = System.Drawing.Color.Black;
            this.btnLoadTrans.Location = new System.Drawing.Point(726, 247);
            this.btnLoadTrans.Name = "btnLoadTrans";
            this.btnLoadTrans.Size = new System.Drawing.Size(136, 45);
            this.btnLoadTrans.TabIndex = 30;
            this.btnLoadTrans.Text = "Xem lịch sử";
            this.btnLoadTrans.Click += new System.EventHandler(this.btnLoadTrans_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.label27.Location = new System.Drawing.Point(30, 83);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(127, 20);
            this.label27.TabIndex = 30;
            this.label27.Text = "Lịch sử tích điểm";
            // 
            // dgvTrans
            // 
            this.dgvTrans.AllowUserToAddRows = false;
            this.dgvTrans.AllowUserToDeleteRows = false;
            this.dgvTrans.AllowUserToResizeColumns = false;
            this.dgvTrans.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dgvTrans.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvTrans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTrans.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTrans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvTrans.ColumnHeadersHeight = 20;
            this.dgvTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTrans.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvTrans.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvTrans.Location = new System.Drawing.Point(33, 106);
            this.dgvTrans.Name = "dgvTrans";
            this.dgvTrans.ReadOnly = true;
            this.dgvTrans.RowHeadersVisible = false;
            this.dgvTrans.RowHeadersWidth = 51;
            this.dgvTrans.RowTemplate.Height = 24;
            this.dgvTrans.Size = new System.Drawing.Size(629, 186);
            this.dgvTrans.TabIndex = 10;
            this.dgvTrans.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvTrans.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTrans.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTrans.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTrans.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTrans.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTrans.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvTrans.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvTrans.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvTrans.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTrans.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvTrans.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTrans.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTrans.ThemeStyle.HeaderStyle.Height = 20;
            this.dgvTrans.ThemeStyle.ReadOnly = true;
            this.dgvTrans.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTrans.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTrans.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvTrans.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.dgvTrans.ThemeStyle.RowsStyle.Height = 24;
            this.dgvTrans.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvTrans.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.label40);
            this.guna2GroupBox1.Controls.Add(this.txtInvoiceID);
            this.guna2GroupBox1.Controls.Add(this.label26);
            this.guna2GroupBox1.Controls.Add(this.label25);
            this.guna2GroupBox1.Controls.Add(this.dgvThongTinHoaDon);
            this.guna2GroupBox1.Controls.Add(this.btnTimHoaDon);
            this.guna2GroupBox1.Controls.Add(this.label14);
            this.guna2GroupBox1.Controls.Add(this.txtCustomerID_HoaDon);
            this.guna2GroupBox1.Controls.Add(this.btnDoiDiem);
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(3, 3);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1088, 337);
            this.guna2GroupBox1.TabIndex = 6;
            this.guna2GroupBox1.Text = "Quy đổi điểm";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label40.Location = new System.Drawing.Point(607, 148);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(87, 20);
            this.label40.TabIndex = 31;
            this.label40.Text = "ID Hóa đơn";
            // 
            // txtInvoiceID
            // 
            this.txtInvoiceID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInvoiceID.DefaultText = "";
            this.txtInvoiceID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInvoiceID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInvoiceID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInvoiceID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInvoiceID.Enabled = false;
            this.txtInvoiceID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInvoiceID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtInvoiceID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInvoiceID.Location = new System.Drawing.Point(610, 172);
            this.txtInvoiceID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInvoiceID.Name = "txtInvoiceID";
            this.txtInvoiceID.PlaceholderText = "";
            this.txtInvoiceID.SelectedText = "";
            this.txtInvoiceID.Size = new System.Drawing.Size(103, 28);
            this.txtInvoiceID.TabIndex = 30;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.label26.Location = new System.Drawing.Point(36, 51);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(142, 20);
            this.label26.TabIndex = 29;
            this.label26.Text = "Thông tin hóa đơn";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.label25.Location = new System.Drawing.Point(30, 51);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(0, 19);
            this.label25.TabIndex = 28;
            // 
            // dgvThongTinHoaDon
            // 
            this.dgvThongTinHoaDon.AllowUserToAddRows = false;
            this.dgvThongTinHoaDon.AllowUserToDeleteRows = false;
            this.dgvThongTinHoaDon.AllowUserToResizeColumns = false;
            this.dgvThongTinHoaDon.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.dgvThongTinHoaDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvThongTinHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongTinHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvThongTinHoaDon.ColumnHeadersHeight = 20;
            this.dgvThongTinHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThongTinHoaDon.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvThongTinHoaDon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvThongTinHoaDon.Location = new System.Drawing.Point(34, 73);
            this.dgvThongTinHoaDon.Name = "dgvThongTinHoaDon";
            this.dgvThongTinHoaDon.RowHeadersVisible = false;
            this.dgvThongTinHoaDon.RowHeadersWidth = 51;
            this.dgvThongTinHoaDon.RowTemplate.Height = 24;
            this.dgvThongTinHoaDon.Size = new System.Drawing.Size(544, 192);
            this.dgvThongTinHoaDon.TabIndex = 27;
            this.dgvThongTinHoaDon.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvThongTinHoaDon.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvThongTinHoaDon.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvThongTinHoaDon.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvThongTinHoaDon.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvThongTinHoaDon.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvThongTinHoaDon.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvThongTinHoaDon.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvThongTinHoaDon.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvThongTinHoaDon.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvThongTinHoaDon.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvThongTinHoaDon.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvThongTinHoaDon.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvThongTinHoaDon.ThemeStyle.HeaderStyle.Height = 20;
            this.dgvThongTinHoaDon.ThemeStyle.ReadOnly = false;
            this.dgvThongTinHoaDon.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvThongTinHoaDon.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvThongTinHoaDon.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvThongTinHoaDon.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.dgvThongTinHoaDon.ThemeStyle.RowsStyle.Height = 24;
            this.dgvThongTinHoaDon.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvThongTinHoaDon.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvThongTinHoaDon.SelectionChanged += new System.EventHandler(this.dgvThongTinHoaDon_SelectionChanged);
            // 
            // btnTimHoaDon
            // 
            this.btnTimHoaDon.BorderRadius = 10;
            this.btnTimHoaDon.BorderThickness = 1;
            this.btnTimHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimHoaDon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimHoaDon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimHoaDon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimHoaDon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimHoaDon.FillColor = System.Drawing.Color.White;
            this.btnTimHoaDon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTimHoaDon.ForeColor = System.Drawing.Color.Black;
            this.btnTimHoaDon.Location = new System.Drawing.Point(833, 80);
            this.btnTimHoaDon.Name = "btnTimHoaDon";
            this.btnTimHoaDon.Size = new System.Drawing.Size(137, 45);
            this.btnTimHoaDon.TabIndex = 26;
            this.btnTimHoaDon.Text = "Tìm hóa đơn";
            this.btnTimHoaDon.Click += new System.EventHandler(this.btnTimHoaDon_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(607, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 20);
            this.label14.TabIndex = 21;
            this.label14.Text = "ID Khách hàng";
            // 
            // txtCustomerID_HoaDon
            // 
            this.txtCustomerID_HoaDon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerID_HoaDon.DefaultText = "";
            this.txtCustomerID_HoaDon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCustomerID_HoaDon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCustomerID_HoaDon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerID_HoaDon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerID_HoaDon.Enabled = false;
            this.txtCustomerID_HoaDon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerID_HoaDon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCustomerID_HoaDon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerID_HoaDon.Location = new System.Drawing.Point(610, 97);
            this.txtCustomerID_HoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCustomerID_HoaDon.Name = "txtCustomerID_HoaDon";
            this.txtCustomerID_HoaDon.PlaceholderText = "";
            this.txtCustomerID_HoaDon.SelectedText = "";
            this.txtCustomerID_HoaDon.Size = new System.Drawing.Size(103, 28);
            this.txtCustomerID_HoaDon.TabIndex = 0;
            // 
            // btnDoiDiem
            // 
            this.btnDoiDiem.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnDoiDiem.BorderRadius = 10;
            this.btnDoiDiem.BorderThickness = 1;
            this.btnDoiDiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoiDiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDoiDiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDoiDiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDoiDiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDoiDiem.FillColor = System.Drawing.Color.ForestGreen;
            this.btnDoiDiem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiDiem.ForeColor = System.Drawing.Color.White;
            this.btnDoiDiem.Location = new System.Drawing.Point(833, 154);
            this.btnDoiDiem.Name = "btnDoiDiem";
            this.btnDoiDiem.Size = new System.Drawing.Size(137, 46);
            this.btnDoiDiem.TabIndex = 5;
            this.btnDoiDiem.Text = "Tích điểm";
            this.btnDoiDiem.Click += new System.EventHandler(this.btnDoiDiem_Click);
            // 
            // tabStatistics
            // 
            this.tabStatistics.Controls.Add(this.chartStatsVip);
            this.tabStatistics.Controls.Add(this.guna2Button4);
            this.tabStatistics.Location = new System.Drawing.Point(184, 4);
            this.tabStatistics.Name = "tabStatistics";
            this.tabStatistics.Size = new System.Drawing.Size(1094, 667);
            this.tabStatistics.TabIndex = 8;
            this.tabStatistics.Text = "Thống kê";
            this.tabStatistics.UseVisualStyleBackColor = true;
            // 
            // guna2Button4
            // 
            this.guna2Button4.BorderRadius = 5;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Location = new System.Drawing.Point(0, 0);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(1094, 65);
            this.guna2Button4.TabIndex = 16;
            this.guna2Button4.Text = "MiniMart";
            // 
            // tabChat
            // 
            this.tabChat.Controls.Add(this.guna2GroupBox9);
            this.tabChat.Location = new System.Drawing.Point(184, 4);
            this.tabChat.Name = "tabChat";
            this.tabChat.Size = new System.Drawing.Size(1094, 667);
            this.tabChat.TabIndex = 7;
            this.tabChat.Text = "Chat";
            this.tabChat.UseVisualStyleBackColor = true;
            // 
            // guna2GroupBox9
            // 
            this.guna2GroupBox9.Controls.Add(this.label39);
            this.guna2GroupBox9.Controls.Add(this.lblKhachHang);
            this.guna2GroupBox9.Controls.Add(this.cbbCustomers);
            this.guna2GroupBox9.Controls.Add(this.lstConversation);
            this.guna2GroupBox9.Controls.Add(this.label42);
            this.guna2GroupBox9.Controls.Add(this.txtMessage);
            this.guna2GroupBox9.Controls.Add(this.btnSend);
            this.guna2GroupBox9.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GroupBox9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox9.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox9.Name = "guna2GroupBox9";
            this.guna2GroupBox9.Size = new System.Drawing.Size(1094, 620);
            this.guna2GroupBox9.TabIndex = 0;
            this.guna2GroupBox9.Text = "Nhắn tin";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.BackColor = System.Drawing.Color.Transparent;
            this.label39.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.label39.Location = new System.Drawing.Point(91, 47);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(91, 20);
            this.label39.TabIndex = 47;
            this.label39.Text = "Khung chat";
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.lblKhachHang.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lblKhachHang.Location = new System.Drawing.Point(675, 509);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(132, 20);
            this.lblKhachHang.TabIndex = 46;
            this.lblKhachHang.Text = "Chọn khách hàng";
            // 
            // cbbCustomers
            // 
            this.cbbCustomers.BackColor = System.Drawing.Color.Transparent;
            this.cbbCustomers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbCustomers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCustomers.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbCustomers.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbCustomers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbCustomers.ItemHeight = 30;
            this.cbbCustomers.Location = new System.Drawing.Point(679, 532);
            this.cbbCustomers.Name = "cbbCustomers";
            this.cbbCustomers.Size = new System.Drawing.Size(338, 36);
            this.cbbCustomers.TabIndex = 45;
            this.cbbCustomers.SelectedIndexChanged += new System.EventHandler(this.cbbCustomer_SelectedIndexChanged);
            // 
            // lstConversation
            // 
            this.lstConversation.FormattingEnabled = true;
            this.lstConversation.ItemHeight = 20;
            this.lstConversation.Items.AddRange(new object[] {
            "Hello",
            "Im here "});
            this.lstConversation.Location = new System.Drawing.Point(69, 70);
            this.lstConversation.Name = "lstConversation";
            this.lstConversation.Size = new System.Drawing.Size(599, 424);
            this.lstConversation.TabIndex = 44;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.BackColor = System.Drawing.Color.Transparent;
            this.label42.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.label42.Location = new System.Drawing.Point(91, 509);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(138, 20);
            this.label42.TabIndex = 43;
            this.label42.Text = "Nội dung tin nhắn";
            // 
            // txtMessage
            // 
            this.txtMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMessage.DefaultText = "";
            this.txtMessage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMessage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMessage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMessage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMessage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMessage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMessage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMessage.Location = new System.Drawing.Point(69, 533);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.PlaceholderText = "";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.SelectedText = "";
            this.txtMessage.Size = new System.Drawing.Size(508, 45);
            this.txtMessage.TabIndex = 40;
            // 
            // btnSend
            // 
            this.btnSend.BackgroundImage = global::MiniMart.Properties.Resources.send;
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSend.BorderColor = System.Drawing.Color.Transparent;
            this.btnSend.BorderRadius = 10;
            this.btnSend.BorderThickness = 1;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSend.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSend.FillColor = System.Drawing.Color.Transparent;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSend.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSend.Location = new System.Drawing.Point(583, 532);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(63, 45);
            this.btnSend.TabIndex = 39;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tabSystem
            // 
            this.tabSystem.Controls.Add(this.guna2GroupBox4);
            this.tabSystem.Controls.Add(this.guna2GroupBox3);
            this.tabSystem.Location = new System.Drawing.Point(184, 4);
            this.tabSystem.Name = "tabSystem";
            this.tabSystem.Size = new System.Drawing.Size(1094, 667);
            this.tabSystem.TabIndex = 4;
            this.tabSystem.Text = "Cài đặt";
            this.tabSystem.UseVisualStyleBackColor = true;
            // 
            // guna2GroupBox4
            // 
            this.guna2GroupBox4.Controls.Add(this.txtPosition_ad);
            this.guna2GroupBox4.Controls.Add(this.dtpHireDate_ad);
            this.guna2GroupBox4.Controls.Add(this.label51);
            this.guna2GroupBox4.Controls.Add(this.guna2GroupBox10);
            this.guna2GroupBox4.Controls.Add(this.dtpBirthDate_ad);
            this.guna2GroupBox4.Controls.Add(this.cbbGender_ad);
            this.guna2GroupBox4.Controls.Add(this.txtAddress_ad);
            this.guna2GroupBox4.Controls.Add(this.txtEmail_ad);
            this.guna2GroupBox4.Controls.Add(this.txtPhone_ad);
            this.guna2GroupBox4.Controls.Add(this.txtFullname_ad);
            this.guna2GroupBox4.Controls.Add(this.label41);
            this.guna2GroupBox4.Controls.Add(this.label43);
            this.guna2GroupBox4.Controls.Add(this.label44);
            this.guna2GroupBox4.Controls.Add(this.label45);
            this.guna2GroupBox4.Controls.Add(this.label46);
            this.guna2GroupBox4.Controls.Add(this.label47);
            this.guna2GroupBox4.Controls.Add(this.label48);
            this.guna2GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox4.Location = new System.Drawing.Point(0, 194);
            this.guna2GroupBox4.Name = "guna2GroupBox4";
            this.guna2GroupBox4.Size = new System.Drawing.Size(1094, 473);
            this.guna2GroupBox4.TabIndex = 1;
            this.guna2GroupBox4.Text = "Thông tin cá nhân";
            // 
            // txtPosition_ad
            // 
            this.txtPosition_ad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPosition_ad.DefaultText = "";
            this.txtPosition_ad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPosition_ad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPosition_ad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPosition_ad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPosition_ad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPosition_ad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPosition_ad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPosition_ad.Location = new System.Drawing.Point(647, 187);
            this.txtPosition_ad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPosition_ad.Name = "txtPosition_ad";
            this.txtPosition_ad.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPosition_ad.PlaceholderText = "Position..";
            this.txtPosition_ad.SelectedText = "";
            this.txtPosition_ad.Size = new System.Drawing.Size(140, 36);
            this.txtPosition_ad.TabIndex = 77;
            // 
            // dtpHireDate_ad
            // 
            this.dtpHireDate_ad.Checked = true;
            this.dtpHireDate_ad.FillColor = System.Drawing.Color.White;
            this.dtpHireDate_ad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpHireDate_ad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHireDate_ad.Location = new System.Drawing.Point(838, 187);
            this.dtpHireDate_ad.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpHireDate_ad.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpHireDate_ad.Name = "dtpHireDate_ad";
            this.dtpHireDate_ad.Size = new System.Drawing.Size(162, 36);
            this.dtpHireDate_ad.TabIndex = 76;
            this.dtpHireDate_ad.Value = new System.DateTime(2025, 9, 14, 23, 13, 57, 878);
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.ForeColor = System.Drawing.Color.Black;
            this.label51.Location = new System.Drawing.Point(835, 163);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(73, 20);
            this.label51.TabIndex = 75;
            this.label51.Text = "Ngày làm";
            // 
            // guna2GroupBox10
            // 
            this.guna2GroupBox10.Controls.Add(this.guna2Button3);
            this.guna2GroupBox10.Controls.Add(this.txtPassword_ad);
            this.guna2GroupBox10.Controls.Add(this.label50);
            this.guna2GroupBox10.Controls.Add(this.txtUsername_ad);
            this.guna2GroupBox10.Controls.Add(this.label49);
            this.guna2GroupBox10.Controls.Add(this.btnLuuQuyDoi);
            this.guna2GroupBox10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2GroupBox10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox10.Location = new System.Drawing.Point(0, 273);
            this.guna2GroupBox10.Name = "guna2GroupBox10";
            this.guna2GroupBox10.Size = new System.Drawing.Size(1094, 200);
            this.guna2GroupBox10.TabIndex = 74;
            this.guna2GroupBox10.Text = "Tài khoản";
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderRadius = 2;
            this.guna2Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.Red;
            this.guna2Button3.FocusedColor = System.Drawing.Color.Red;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Button3.Location = new System.Drawing.Point(839, 148);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(106, 33);
            this.guna2Button3.TabIndex = 41;
            this.guna2Button3.Text = "Exit";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // txtPassword_ad
            // 
            this.txtPassword_ad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword_ad.DefaultText = "";
            this.txtPassword_ad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword_ad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword_ad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword_ad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword_ad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword_ad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword_ad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword_ad.Location = new System.Drawing.Point(335, 95);
            this.txtPassword_ad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword_ad.Name = "txtPassword_ad";
            this.txtPassword_ad.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPassword_ad.PlaceholderText = "Email..";
            this.txtPassword_ad.SelectedText = "";
            this.txtPassword_ad.Size = new System.Drawing.Size(229, 36);
            this.txtPassword_ad.TabIndex = 72;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.ForeColor = System.Drawing.Color.Black;
            this.label50.Location = new System.Drawing.Point(32, 58);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(78, 20);
            this.label50.TabIndex = 71;
            this.label50.Text = "Username:";
            // 
            // txtUsername_ad
            // 
            this.txtUsername_ad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername_ad.DefaultText = "";
            this.txtUsername_ad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername_ad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername_ad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername_ad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername_ad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername_ad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsername_ad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername_ad.Location = new System.Drawing.Point(36, 88);
            this.txtUsername_ad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername_ad.Name = "txtUsername_ad";
            this.txtUsername_ad.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtUsername_ad.PlaceholderText = "Họ tên..";
            this.txtUsername_ad.SelectedText = "";
            this.txtUsername_ad.Size = new System.Drawing.Size(229, 36);
            this.txtUsername_ad.TabIndex = 73;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.ForeColor = System.Drawing.Color.Black;
            this.label49.Location = new System.Drawing.Point(336, 71);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(73, 20);
            this.label49.TabIndex = 70;
            this.label49.Text = "Password:";
            // 
            // btnLuuQuyDoi
            // 
            this.btnLuuQuyDoi.BorderRadius = 2;
            this.btnLuuQuyDoi.BorderThickness = 1;
            this.btnLuuQuyDoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuuQuyDoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuuQuyDoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuuQuyDoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuuQuyDoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuuQuyDoi.FillColor = System.Drawing.Color.White;
            this.btnLuuQuyDoi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuQuyDoi.ForeColor = System.Drawing.Color.Black;
            this.btnLuuQuyDoi.Location = new System.Drawing.Point(36, 148);
            this.btnLuuQuyDoi.Name = "btnLuuQuyDoi";
            this.btnLuuQuyDoi.Size = new System.Drawing.Size(101, 33);
            this.btnLuuQuyDoi.TabIndex = 40;
            this.btnLuuQuyDoi.Text = "Lưu";
            this.btnLuuQuyDoi.Click += new System.EventHandler(this.btnLuuQuyDoi_Click);
            // 
            // dtpBirthDate_ad
            // 
            this.dtpBirthDate_ad.Checked = true;
            this.dtpBirthDate_ad.FillColor = System.Drawing.Color.White;
            this.dtpBirthDate_ad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpBirthDate_ad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate_ad.Location = new System.Drawing.Point(838, 103);
            this.dtpBirthDate_ad.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpBirthDate_ad.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpBirthDate_ad.Name = "dtpBirthDate_ad";
            this.dtpBirthDate_ad.Size = new System.Drawing.Size(162, 36);
            this.dtpBirthDate_ad.TabIndex = 69;
            this.dtpBirthDate_ad.Value = new System.DateTime(2025, 9, 14, 23, 13, 57, 878);
            // 
            // cbbGender_ad
            // 
            this.cbbGender_ad.BackColor = System.Drawing.Color.Transparent;
            this.cbbGender_ad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbGender_ad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGender_ad.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbGender_ad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbGender_ad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbGender_ad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbGender_ad.ItemHeight = 30;
            this.cbbGender_ad.Items.AddRange(new object[] {
            "Nam ",
            "Nữ",
            "Khác"});
            this.cbbGender_ad.Location = new System.Drawing.Point(647, 103);
            this.cbbGender_ad.Name = "cbbGender_ad";
            this.cbbGender_ad.Size = new System.Drawing.Size(140, 36);
            this.cbbGender_ad.TabIndex = 67;
            // 
            // txtAddress_ad
            // 
            this.txtAddress_ad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress_ad.DefaultText = "";
            this.txtAddress_ad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress_ad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress_ad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress_ad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress_ad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress_ad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddress_ad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress_ad.Location = new System.Drawing.Point(331, 104);
            this.txtAddress_ad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress_ad.Name = "txtAddress_ad";
            this.txtAddress_ad.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtAddress_ad.PlaceholderText = "Địa chỉ..";
            this.txtAddress_ad.SelectedText = "";
            this.txtAddress_ad.Size = new System.Drawing.Size(229, 36);
            this.txtAddress_ad.TabIndex = 66;
            // 
            // txtEmail_ad
            // 
            this.txtEmail_ad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail_ad.DefaultText = "";
            this.txtEmail_ad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail_ad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail_ad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail_ad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail_ad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail_ad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail_ad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail_ad.Location = new System.Drawing.Point(331, 187);
            this.txtEmail_ad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail_ad.Name = "txtEmail_ad";
            this.txtEmail_ad.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtEmail_ad.PlaceholderText = "Email..";
            this.txtEmail_ad.SelectedText = "";
            this.txtEmail_ad.Size = new System.Drawing.Size(229, 36);
            this.txtEmail_ad.TabIndex = 65;
            // 
            // txtPhone_ad
            // 
            this.txtPhone_ad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone_ad.DefaultText = "";
            this.txtPhone_ad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhone_ad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhone_ad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone_ad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone_ad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone_ad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhone_ad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone_ad.Location = new System.Drawing.Point(36, 187);
            this.txtPhone_ad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone_ad.Name = "txtPhone_ad";
            this.txtPhone_ad.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPhone_ad.PlaceholderText = "SDT..";
            this.txtPhone_ad.SelectedText = "";
            this.txtPhone_ad.Size = new System.Drawing.Size(229, 36);
            this.txtPhone_ad.TabIndex = 64;
            // 
            // txtFullname_ad
            // 
            this.txtFullname_ad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullname_ad.DefaultText = "";
            this.txtFullname_ad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFullname_ad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFullname_ad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullname_ad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullname_ad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFullname_ad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFullname_ad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFullname_ad.Location = new System.Drawing.Point(36, 104);
            this.txtFullname_ad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFullname_ad.Name = "txtFullname_ad";
            this.txtFullname_ad.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtFullname_ad.PlaceholderText = "Họ tên..";
            this.txtFullname_ad.SelectedText = "";
            this.txtFullname_ad.Size = new System.Drawing.Size(229, 36);
            this.txtFullname_ad.TabIndex = 63;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.ForeColor = System.Drawing.Color.Black;
            this.label41.Location = new System.Drawing.Point(643, 80);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(65, 20);
            this.label41.TabIndex = 62;
            this.label41.Text = "Giới tính";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.ForeColor = System.Drawing.Color.Black;
            this.label43.Location = new System.Drawing.Point(834, 80);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(74, 20);
            this.label43.TabIndex = 61;
            this.label43.Text = "Ngày sinh";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.ForeColor = System.Drawing.Color.Black;
            this.label44.Location = new System.Drawing.Point(655, 163);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(40, 20);
            this.label44.TabIndex = 60;
            this.label44.Text = "Vị trí";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.ForeColor = System.Drawing.Color.Black;
            this.label45.Location = new System.Drawing.Point(327, 80);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(58, 20);
            this.label45.TabIndex = 59;
            this.label45.Text = "Địa chỉ:";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.ForeColor = System.Drawing.Color.Black;
            this.label46.Location = new System.Drawing.Point(32, 163);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(100, 20);
            this.label46.TabIndex = 58;
            this.label46.Text = "Số điện thoại:";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.ForeColor = System.Drawing.Color.Black;
            this.label47.Location = new System.Drawing.Point(336, 163);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(49, 20);
            this.label47.TabIndex = 57;
            this.label47.Text = "Email:";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.ForeColor = System.Drawing.Color.Black;
            this.label48.Location = new System.Drawing.Point(32, 80);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(76, 20);
            this.label48.TabIndex = 56;
            this.label48.Text = "Họ và tên:";
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.Controls.Add(this.label17);
            this.guna2GroupBox3.Controls.Add(this.cbbRoleRate);
            this.guna2GroupBox3.Controls.Add(this.lblDatabase);
            this.guna2GroupBox3.Controls.Add(this.txtTiLeQuyDoi);
            this.guna2GroupBox3.Controls.Add(this.lblServer);
            this.guna2GroupBox3.Controls.Add(this.label15);
            this.guna2GroupBox3.Controls.Add(this.lblRole);
            this.guna2GroupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox3.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Size = new System.Drawing.Size(1094, 194);
            this.guna2GroupBox3.TabIndex = 0;
            this.guna2GroupBox3.Text = "Hệ thống";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(567, 74);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(141, 20);
            this.label17.TabIndex = 43;
            this.label17.Text = "Chọn quyền quy đổi";
            // 
            // cbbRoleRate
            // 
            this.cbbRoleRate.BackColor = System.Drawing.Color.Transparent;
            this.cbbRoleRate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbRoleRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRoleRate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbRoleRate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbRoleRate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbRoleRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbRoleRate.ItemHeight = 30;
            this.cbbRoleRate.Items.AddRange(new object[] {
            "Normal",
            "VIP"});
            this.cbbRoleRate.Location = new System.Drawing.Point(571, 107);
            this.cbbRoleRate.Name = "cbbRoleRate";
            this.cbbRoleRate.Size = new System.Drawing.Size(140, 36);
            this.cbbRoleRate.TabIndex = 42;
            this.cbbRoleRate.SelectedIndexChanged += new System.EventHandler(this.cbbRoleRate_SelectedIndexChanged);
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.ForeColor = System.Drawing.Color.Black;
            this.lblDatabase.Location = new System.Drawing.Point(32, 144);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(72, 20);
            this.lblDatabase.TabIndex = 3;
            this.lblDatabase.Text = "Thông tin";
            // 
            // txtTiLeQuyDoi
            // 
            this.txtTiLeQuyDoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTiLeQuyDoi.DefaultText = "1:1";
            this.txtTiLeQuyDoi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTiLeQuyDoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTiLeQuyDoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTiLeQuyDoi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTiLeQuyDoi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTiLeQuyDoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTiLeQuyDoi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTiLeQuyDoi.Location = new System.Drawing.Point(786, 107);
            this.txtTiLeQuyDoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTiLeQuyDoi.Name = "txtTiLeQuyDoi";
            this.txtTiLeQuyDoi.PlaceholderText = "";
            this.txtTiLeQuyDoi.SelectedText = "";
            this.txtTiLeQuyDoi.Size = new System.Drawing.Size(101, 33);
            this.txtTiLeQuyDoi.TabIndex = 3;
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.ForeColor = System.Drawing.Color.Black;
            this.lblServer.Location = new System.Drawing.Point(32, 107);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(72, 20);
            this.lblServer.TabIndex = 4;
            this.lblServer.Text = "Thông tin";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(782, 74);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(195, 20);
            this.label15.TabIndex = 2;
            this.label15.Text = " Hệ số quy đổi (VND:POINT)";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.ForeColor = System.Drawing.Color.Black;
            this.lblRole.Location = new System.Drawing.Point(32, 74);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(115, 20);
            this.lblRole.TabIndex = 1;
            this.lblRole.Text = "Chọn quyền hạn";
            // 
            // SettingUser
            // 
            this.SettingUser.Controls.Add(this.guna2GroupBox8);
            this.SettingUser.Controls.Add(this.guna2GroupBox7);
            this.SettingUser.Location = new System.Drawing.Point(184, 4);
            this.SettingUser.Name = "SettingUser";
            this.SettingUser.Size = new System.Drawing.Size(1094, 667);
            this.SettingUser.TabIndex = 6;
            this.SettingUser.Text = "Cài đặt";
            this.SettingUser.UseVisualStyleBackColor = true;
            // 
            // guna2GroupBox8
            // 
            this.guna2GroupBox8.Controls.Add(this.dtpNgaySinh_cus);
            this.guna2GroupBox8.Controls.Add(this.cbbTrangThai_cus);
            this.guna2GroupBox8.Controls.Add(this.cbbGioiTinh_cus);
            this.guna2GroupBox8.Controls.Add(this.txtDiaChi_cus);
            this.guna2GroupBox8.Controls.Add(this.TxtEmail_cus);
            this.guna2GroupBox8.Controls.Add(this.txtSdt_cus);
            this.guna2GroupBox8.Controls.Add(this.txtHoten_cus);
            this.guna2GroupBox8.Controls.Add(this.label37);
            this.guna2GroupBox8.Controls.Add(this.label36);
            this.guna2GroupBox8.Controls.Add(this.label35);
            this.guna2GroupBox8.Controls.Add(this.label34);
            this.guna2GroupBox8.Controls.Add(this.label33);
            this.guna2GroupBox8.Controls.Add(this.label32);
            this.guna2GroupBox8.Controls.Add(this.label31);
            this.guna2GroupBox8.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GroupBox8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox8.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox8.Name = "guna2GroupBox8";
            this.guna2GroupBox8.Size = new System.Drawing.Size(1094, 295);
            this.guna2GroupBox8.TabIndex = 42;
            this.guna2GroupBox8.Text = "Thông tin cá nhân";
            // 
            // dtpNgaySinh_cus
            // 
            this.dtpNgaySinh_cus.Checked = true;
            this.dtpNgaySinh_cus.FillColor = System.Drawing.Color.White;
            this.dtpNgaySinh_cus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgaySinh_cus.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh_cus.Location = new System.Drawing.Point(838, 111);
            this.dtpNgaySinh_cus.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgaySinh_cus.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgaySinh_cus.Name = "dtpNgaySinh_cus";
            this.dtpNgaySinh_cus.Size = new System.Drawing.Size(200, 36);
            this.dtpNgaySinh_cus.TabIndex = 55;
            this.dtpNgaySinh_cus.Value = new System.DateTime(2025, 9, 14, 23, 13, 57, 878);
            // 
            // cbbTrangThai_cus
            // 
            this.cbbTrangThai_cus.BackColor = System.Drawing.Color.Transparent;
            this.cbbTrangThai_cus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTrangThai_cus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTrangThai_cus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbTrangThai_cus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbTrangThai_cus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbTrangThai_cus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbTrangThai_cus.ItemHeight = 30;
            this.cbbTrangThai_cus.Items.AddRange(new object[] {
            "Active",
            "Disactive"});
            this.cbbTrangThai_cus.Location = new System.Drawing.Point(647, 197);
            this.cbbTrangThai_cus.Name = "cbbTrangThai_cus";
            this.cbbTrangThai_cus.Size = new System.Drawing.Size(140, 36);
            this.cbbTrangThai_cus.TabIndex = 54;
            // 
            // cbbGioiTinh_cus
            // 
            this.cbbGioiTinh_cus.BackColor = System.Drawing.Color.Transparent;
            this.cbbGioiTinh_cus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbGioiTinh_cus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGioiTinh_cus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbGioiTinh_cus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbGioiTinh_cus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbGioiTinh_cus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbGioiTinh_cus.ItemHeight = 30;
            this.cbbGioiTinh_cus.Items.AddRange(new object[] {
            "Nam ",
            "Nữ",
            "Khác"});
            this.cbbGioiTinh_cus.Location = new System.Drawing.Point(647, 111);
            this.cbbGioiTinh_cus.Name = "cbbGioiTinh_cus";
            this.cbbGioiTinh_cus.Size = new System.Drawing.Size(140, 36);
            this.cbbGioiTinh_cus.TabIndex = 53;
            // 
            // txtDiaChi_cus
            // 
            this.txtDiaChi_cus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChi_cus.DefaultText = "";
            this.txtDiaChi_cus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiaChi_cus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiaChi_cus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi_cus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi_cus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi_cus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiaChi_cus.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi_cus.Location = new System.Drawing.Point(331, 112);
            this.txtDiaChi_cus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiaChi_cus.Name = "txtDiaChi_cus";
            this.txtDiaChi_cus.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtDiaChi_cus.PlaceholderText = "Địa chỉ..";
            this.txtDiaChi_cus.SelectedText = "";
            this.txtDiaChi_cus.Size = new System.Drawing.Size(229, 36);
            this.txtDiaChi_cus.TabIndex = 52;
            // 
            // TxtEmail_cus
            // 
            this.TxtEmail_cus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtEmail_cus.DefaultText = "";
            this.TxtEmail_cus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtEmail_cus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtEmail_cus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtEmail_cus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtEmail_cus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtEmail_cus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtEmail_cus.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtEmail_cus.Location = new System.Drawing.Point(331, 195);
            this.TxtEmail_cus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtEmail_cus.Name = "TxtEmail_cus";
            this.TxtEmail_cus.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.TxtEmail_cus.PlaceholderText = "Email..";
            this.TxtEmail_cus.SelectedText = "";
            this.TxtEmail_cus.Size = new System.Drawing.Size(229, 36);
            this.TxtEmail_cus.TabIndex = 51;
            // 
            // txtSdt_cus
            // 
            this.txtSdt_cus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSdt_cus.DefaultText = "";
            this.txtSdt_cus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSdt_cus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSdt_cus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSdt_cus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSdt_cus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSdt_cus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSdt_cus.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSdt_cus.Location = new System.Drawing.Point(36, 195);
            this.txtSdt_cus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSdt_cus.Name = "txtSdt_cus";
            this.txtSdt_cus.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSdt_cus.PlaceholderText = "SDT..";
            this.txtSdt_cus.SelectedText = "";
            this.txtSdt_cus.Size = new System.Drawing.Size(229, 36);
            this.txtSdt_cus.TabIndex = 50;
            // 
            // txtHoten_cus
            // 
            this.txtHoten_cus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoten_cus.DefaultText = "";
            this.txtHoten_cus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHoten_cus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHoten_cus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoten_cus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoten_cus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoten_cus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHoten_cus.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoten_cus.Location = new System.Drawing.Point(36, 112);
            this.txtHoten_cus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHoten_cus.Name = "txtHoten_cus";
            this.txtHoten_cus.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtHoten_cus.PlaceholderText = "Họ tên..";
            this.txtHoten_cus.SelectedText = "";
            this.txtHoten_cus.Size = new System.Drawing.Size(229, 36);
            this.txtHoten_cus.TabIndex = 49;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.ForeColor = System.Drawing.Color.Black;
            this.label37.Location = new System.Drawing.Point(643, 88);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(65, 20);
            this.label37.TabIndex = 48;
            this.label37.Text = "Giới tính";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.ForeColor = System.Drawing.Color.Black;
            this.label36.Location = new System.Drawing.Point(834, 88);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(74, 20);
            this.label36.TabIndex = 47;
            this.label36.Text = "Ngày sinh";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.ForeColor = System.Drawing.Color.Black;
            this.label35.Location = new System.Drawing.Point(643, 173);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(75, 20);
            this.label35.TabIndex = 46;
            this.label35.Text = "Trạng thái";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.ForeColor = System.Drawing.Color.Black;
            this.label34.Location = new System.Drawing.Point(327, 88);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(58, 20);
            this.label34.TabIndex = 45;
            this.label34.Text = "Địa chỉ:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.ForeColor = System.Drawing.Color.Black;
            this.label33.Location = new System.Drawing.Point(32, 171);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(100, 20);
            this.label33.TabIndex = 44;
            this.label33.Text = "Số điện thoại:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.ForeColor = System.Drawing.Color.Black;
            this.label32.Location = new System.Drawing.Point(336, 171);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(49, 20);
            this.label32.TabIndex = 43;
            this.label32.Text = "Email:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.ForeColor = System.Drawing.Color.Black;
            this.label31.Location = new System.Drawing.Point(32, 88);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(76, 20);
            this.label31.TabIndex = 42;
            this.label31.Text = "Họ và tên:";
            // 
            // guna2GroupBox7
            // 
            this.guna2GroupBox7.Controls.Add(this.lblCapDo_cus);
            this.guna2GroupBox7.Controls.Add(this.lblPoints_cus);
            this.guna2GroupBox7.Controls.Add(this.txtPass_cus);
            this.guna2GroupBox7.Controls.Add(this.txtUsername_cus);
            this.guna2GroupBox7.Controls.Add(this.label38);
            this.guna2GroupBox7.Controls.Add(this.btnLogout);
            this.guna2GroupBox7.Controls.Add(this.btnLuuThayDoi_cus);
            this.guna2GroupBox7.Controls.Add(this.label28);
            this.guna2GroupBox7.Controls.Add(this.label29);
            this.guna2GroupBox7.Controls.Add(this.label30);
            this.guna2GroupBox7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2GroupBox7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox7.Location = new System.Drawing.Point(0, 301);
            this.guna2GroupBox7.Name = "guna2GroupBox7";
            this.guna2GroupBox7.Size = new System.Drawing.Size(1094, 366);
            this.guna2GroupBox7.TabIndex = 2;
            this.guna2GroupBox7.Text = "Thông tin tài khoản";
            // 
            // lblCapDo_cus
            // 
            this.lblCapDo_cus.AutoSize = true;
            this.lblCapDo_cus.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapDo_cus.ForeColor = System.Drawing.Color.Black;
            this.lblCapDo_cus.Location = new System.Drawing.Point(526, 164);
            this.lblCapDo_cus.Name = "lblCapDo_cus";
            this.lblCapDo_cus.Size = new System.Drawing.Size(172, 25);
            this.lblCapDo_cus.TabIndex = 58;
            this.lblCapDo_cus.Text = "Cấp độ thành viên:";
            // 
            // lblPoints_cus
            // 
            this.lblPoints_cus.AutoSize = true;
            this.lblPoints_cus.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints_cus.ForeColor = System.Drawing.Color.Black;
            this.lblPoints_cus.Location = new System.Drawing.Point(486, 72);
            this.lblPoints_cus.Name = "lblPoints_cus";
            this.lblPoints_cus.Size = new System.Drawing.Size(108, 25);
            this.lblPoints_cus.TabIndex = 57;
            this.lblPoints_cus.Text = "Tổng điểm:";
            // 
            // txtPass_cus
            // 
            this.txtPass_cus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass_cus.DefaultText = "";
            this.txtPass_cus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPass_cus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPass_cus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPass_cus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPass_cus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPass_cus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPass_cus.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPass_cus.Location = new System.Drawing.Point(36, 193);
            this.txtPass_cus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPass_cus.Name = "txtPass_cus";
            this.txtPass_cus.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPass_cus.PlaceholderText = "Email..";
            this.txtPass_cus.SelectedText = "";
            this.txtPass_cus.Size = new System.Drawing.Size(229, 36);
            this.txtPass_cus.TabIndex = 56;
            // 
            // txtUsername_cus
            // 
            this.txtUsername_cus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername_cus.DefaultText = "";
            this.txtUsername_cus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername_cus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername_cus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername_cus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername_cus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername_cus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsername_cus.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername_cus.Location = new System.Drawing.Point(36, 107);
            this.txtUsername_cus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername_cus.Name = "txtUsername_cus";
            this.txtUsername_cus.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtUsername_cus.PlaceholderText = "Họ tên..";
            this.txtUsername_cus.SelectedText = "";
            this.txtUsername_cus.Size = new System.Drawing.Size(229, 36);
            this.txtUsername_cus.TabIndex = 56;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.ForeColor = System.Drawing.Color.Black;
            this.label38.Location = new System.Drawing.Point(368, 77);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(84, 20);
            this.label38.TabIndex = 42;
            this.label38.Text = "Tổng điểm:";
            // 
            // btnLogout
            // 
            this.btnLogout.BorderRadius = 2;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.Red;
            this.btnLogout.FocusedColor = System.Drawing.Color.Red;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogout.Location = new System.Drawing.Point(892, 273);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(115, 41);
            this.btnLogout.TabIndex = 41;
            this.btnLogout.Text = "Exit";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnLuuThayDoi_cus
            // 
            this.btnLuuThayDoi_cus.BorderRadius = 2;
            this.btnLuuThayDoi_cus.BorderThickness = 1;
            this.btnLuuThayDoi_cus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuuThayDoi_cus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuuThayDoi_cus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuuThayDoi_cus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuuThayDoi_cus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuuThayDoi_cus.FillColor = System.Drawing.Color.White;
            this.btnLuuThayDoi_cus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuThayDoi_cus.ForeColor = System.Drawing.Color.Black;
            this.btnLuuThayDoi_cus.Location = new System.Drawing.Point(36, 273);
            this.btnLuuThayDoi_cus.Name = "btnLuuThayDoi_cus";
            this.btnLuuThayDoi_cus.Size = new System.Drawing.Size(132, 41);
            this.btnLuuThayDoi_cus.TabIndex = 40;
            this.btnLuuThayDoi_cus.Text = "Lưu thay đổi";
            this.btnLuuThayDoi_cus.Click += new System.EventHandler(this.btnLuuThayDoi_cus_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.ForeColor = System.Drawing.Color.Black;
            this.label28.Location = new System.Drawing.Point(368, 169);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(132, 20);
            this.label28.TabIndex = 2;
            this.label28.Text = "Cấp độ thành viên:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.ForeColor = System.Drawing.Color.Black;
            this.label29.Location = new System.Drawing.Point(37, 169);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(73, 20);
            this.label29.TabIndex = 3;
            this.label29.Text = "Password:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.ForeColor = System.Drawing.Color.Black;
            this.label30.Location = new System.Drawing.Point(32, 77);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(78, 20);
            this.label30.TabIndex = 4;
            this.label30.Text = "Username:";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.BorderRadius = 12;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2BorderlessForm2
            // 
            this.guna2BorderlessForm2.ContainerControl = this;
            this.guna2BorderlessForm2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm2.TransparentWhileDrag = true;
            // 
            // chartStatsVip
            // 
            chartArea1.Name = "ChartArea1";
            this.chartStatsVip.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartStatsVip.Legends.Add(legend1);
            this.chartStatsVip.Location = new System.Drawing.Point(80, 105);
            this.chartStatsVip.Name = "chartStatsVip";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartStatsVip.Series.Add(series1);
            this.chartStatsVip.Size = new System.Drawing.Size(948, 533);
            this.chartStatsVip.TabIndex = 23;
            this.chartStatsVip.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 675);
            this.Controls.Add(this.tabMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabMain.ResumeLayout(false);
            this.tabCustomers.ResumeLayout(false);
            this.tabCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.tabAccount.ResumeLayout(false);
            this.tabAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.tabQuaTang.ResumeLayout(false);
            this.guna2GroupBox6.ResumeLayout(false);
            this.guna2GroupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiftHistory)).EndInit();
            this.guna2GroupBox5.ResumeLayout(false);
            this.guna2GroupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGifts)).EndInit();
            this.tabInvoice.ResumeLayout(false);
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrans)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinHoaDon)).EndInit();
            this.tabStatistics.ResumeLayout(false);
            this.tabChat.ResumeLayout(false);
            this.guna2GroupBox9.ResumeLayout(false);
            this.guna2GroupBox9.PerformLayout();
            this.tabSystem.ResumeLayout(false);
            this.guna2GroupBox4.ResumeLayout(false);
            this.guna2GroupBox4.PerformLayout();
            this.guna2GroupBox10.ResumeLayout(false);
            this.guna2GroupBox10.PerformLayout();
            this.guna2GroupBox3.ResumeLayout(false);
            this.guna2GroupBox3.PerformLayout();
            this.SettingUser.ResumeLayout(false);
            this.guna2GroupBox8.ResumeLayout(false);
            this.guna2GroupBox8.PerformLayout();
            this.guna2GroupBox7.ResumeLayout(false);
            this.guna2GroupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatsVip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Guna.UI2.WinForms.Guna2TabControl tabMain;
        private System.Windows.Forms.TabPage tabAccount;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.TabPage tabCustomers;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cboStatus;
        private Guna.UI2.WinForms.Guna2ComboBox cboGender;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpBirthDate;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone;
        private Guna.UI2.WinForms.Guna2TextBox txtFullName;
        private System.Windows.Forms.TabPage tabInvoice;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtCustomerID_Acc;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2ComboBox cboMemberLevel;
        private System.Windows.Forms.Label lblPoints;
        private Guna.UI2.WinForms.Guna2Button btnDoiDiem;
        private Guna.UI2.WinForms.Guna2TextBox txtCustomerID_HoaDon;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleShowPass;
        private Guna.UI2.WinForms.Guna2Button btnTimHoaDon;
        private Guna.UI2.WinForms.Guna2DataGridView dgvThongTinHoaDon;
        private System.Windows.Forms.TabPage tabSystem;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox4;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Label lblRole;
        private Guna.UI2.WinForms.Guna2TextBox txtTiLeQuyDoi;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm2;
        private System.Windows.Forms.TabPage tabQuaTang;
        private System.Windows.Forms.Label lblPoint_gift;
        private Guna.UI2.WinForms.Guna2TextBox txtGiftID;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox6;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox5;
        private Guna.UI2.WinForms.Guna2TextBox txtGiftName;
        private System.Windows.Forms.Label label18;
        private Guna.UI2.WinForms.Guna2CheckBox chkIsActive;
        private Guna.UI2.WinForms.Guna2TextBox txtPointsRequired;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private Guna.UI2.WinForms.Guna2TextBox txtIdCustomer_gift;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCustomers;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button btnViewAccount;
        private Guna.UI2.WinForms.Guna2Button btnUpdateAcc;
        private Guna.UI2.WinForms.Guna2Button btnCreateAccount;
        private Guna.UI2.WinForms.Guna2Button btnLoadAllAccounts;
        private Guna.UI2.WinForms.Guna2Button btnDelAcc;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private Guna.UI2.WinForms.Guna2Button btnLoadGiftHistory;
        private Guna.UI2.WinForms.Guna2Button btnRedeemGift;
        private System.Windows.Forms.Label label20;
        private Guna.UI2.WinForms.Guna2Button btnLuuQuyDoi;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnAddGift;
        private Guna.UI2.WinForms.Guna2Button btnDeleteGift;
        private Guna.UI2.WinForms.Guna2Button btnEditGift;
        private Guna.UI2.WinForms.Guna2Button btnLoadGifts;
        private System.Windows.Forms.TabPage SettingUser;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox8;
        private Guna.UI2.WinForms.Guna2ComboBox cbbTrangThai_cus;
        private Guna.UI2.WinForms.Guna2ComboBox cbbGioiTinh_cus;
        private Guna.UI2.WinForms.Guna2TextBox txtDiaChi_cus;
        private Guna.UI2.WinForms.Guna2TextBox TxtEmail_cus;
        private Guna.UI2.WinForms.Guna2TextBox txtSdt_cus;
        private Guna.UI2.WinForms.Guna2TextBox txtHoten_cus;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox7;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnLuuThayDoi_cus;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgaySinh_cus;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label lblCapDo_cus;
        private System.Windows.Forms.Label lblPoints_cus;
        private Guna.UI2.WinForms.Guna2TextBox txtPass_cus;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername_cus;
        private System.Windows.Forms.TabPage tabChat;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox9;
        private Guna.UI2.WinForms.Guna2Button btnSend;
        private System.Windows.Forms.Label label42;
        private Guna.UI2.WinForms.Guna2TextBox txtMessage;
        private System.Windows.Forms.ListBox lstConversation;
        private Guna.UI2.WinForms.Guna2ComboBox cbbCustomers;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.Label label17;
        private Guna.UI2.WinForms.Guna2ComboBox cbbRoleRate;
        private Guna.UI2.WinForms.Guna2DataGridView dgvGiftHistory;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTaiKhoan;
        private Guna.UI2.WinForms.Guna2DataGridView dgvGifts;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2Button btnLoadTrans;
        private System.Windows.Forms.Label label27;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTrans;
        private System.Windows.Forms.Label label40;
        private Guna.UI2.WinForms.Guna2TextBox txtInvoiceID;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpHireDate_ad;
        private System.Windows.Forms.Label label51;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox10;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword_ad;
        private System.Windows.Forms.Label label50;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername_ad;
        private System.Windows.Forms.Label label49;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpBirthDate_ad;
        private Guna.UI2.WinForms.Guna2ComboBox cbbGender_ad;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress_ad;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail_ad;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone_ad;
        private Guna.UI2.WinForms.Guna2TextBox txtFullname_ad;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private Guna.UI2.WinForms.Guna2TextBox txtPosition_ad;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TabPage tabStatistics;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatsVip;
    }
}

