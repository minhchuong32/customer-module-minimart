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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle58 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle59 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle60 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle55 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle56 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle57 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle61 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle62 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle63 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle64 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle65 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle66 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle67 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle68 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle69 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle70 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle71 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle72 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label19 = new System.Windows.Forms.Label();
            this.btnViewAccount = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.dgvTaiKhoan = new Guna.UI2.WinForms.Guna2DataGridView();
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
            this.btnUpdateAcc = new Guna.UI2.WinForms.Guna2Button();
            this.btnCreateAccount = new Guna.UI2.WinForms.Guna2Button();
            this.btnLoadAllAccounts = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelAcc = new Guna.UI2.WinForms.Guna2Button();
            this.tabInvoice = new System.Windows.Forms.TabPage();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnLoadTrans = new Guna.UI2.WinForms.Guna2Button();
            this.label27 = new System.Windows.Forms.Label();
            this.dgvTrans = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.dgvThongTinHoaDon = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnTimHoaDon = new Guna.UI2.WinForms.Guna2Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCustomerID_HoaDon = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnDoiDiem = new Guna.UI2.WinForms.Guna2Button();
            this.tabQuaTang = new System.Windows.Forms.TabPage();
            this.guna2GroupBox6 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.btnLoadGiftHistory = new Guna.UI2.WinForms.Guna2Button();
            this.dgvGiftHistory = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label17 = new System.Windows.Forms.Label();
            this.lblPoint_gift = new System.Windows.Forms.Label();
            this.guna2GroupBox5 = new Guna.UI2.WinForms.Guna2GroupBox();
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
            this.dgvGifts = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.txtGiftID = new Guna.UI2.WinForms.Guna2TextBox();
            this.tabSetting = new System.Windows.Forms.TabPage();
            this.guna2GroupBox4 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.btnLuuQuyDoi = new Guna.UI2.WinForms.Guna2Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtTiLeQuyDoi = new Guna.UI2.WinForms.Guna2TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.toggleSwitchRole = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2BorderlessForm2 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.tabMain.SuspendLayout();
            this.tabCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.tabAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.tabInvoice.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrans)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinHoaDon)).BeginInit();
            this.tabQuaTang.SuspendLayout();
            this.guna2GroupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiftHistory)).BeginInit();
            this.guna2GroupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGifts)).BeginInit();
            this.tabSetting.SuspendLayout();
            this.guna2GroupBox4.SuspendLayout();
            this.guna2GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabMain.Controls.Add(this.tabCustomers);
            this.tabMain.Controls.Add(this.tabAccount);
            this.tabMain.Controls.Add(this.tabInvoice);
            this.tabMain.Controls.Add(this.tabQuaTang);
            this.tabMain.Controls.Add(this.tabSetting);
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
            dataGridViewCellStyle58.BackColor = System.Drawing.Color.White;
            this.dgvCustomers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle58;
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCustomers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle59.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle59.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle59.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle59.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle59.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle59.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle59.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle59;
            this.dgvCustomers.ColumnHeadersHeight = 20;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle60.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle60.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle60.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle60.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle60.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle60.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle60.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomers.DefaultCellStyle = dataGridViewCellStyle60;
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
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(853, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Ngày sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(385, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "SDT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(385, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(118, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(118, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(662, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Trạng thái";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(662, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
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
            this.tabAccount.Controls.Add(this.label19);
            this.tabAccount.Controls.Add(this.btnViewAccount);
            this.tabAccount.Controls.Add(this.guna2Button2);
            this.tabAccount.Controls.Add(this.dgvTaiKhoan);
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
            // btnViewAccount
            // 
            this.btnViewAccount.BorderRadius = 10;
            this.btnViewAccount.BorderThickness = 1;
            this.btnViewAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewAccount.FillColor = System.Drawing.Color.White;
            this.btnViewAccount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnViewAccount.ForeColor = System.Drawing.Color.Black;
            this.btnViewAccount.Location = new System.Drawing.Point(159, 130);
            this.btnViewAccount.Name = "btnViewAccount";
            this.btnViewAccount.Size = new System.Drawing.Size(136, 45);
            this.btnViewAccount.TabIndex = 36;
            this.btnViewAccount.Text = "Xem tài khoản";
            this.btnViewAccount.Click += new System.EventHandler(this.btnViewAccount_Click);
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
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.AllowUserToAddRows = false;
            this.dgvTaiKhoan.AllowUserToDeleteRows = false;
            this.dgvTaiKhoan.AllowUserToResizeColumns = false;
            this.dgvTaiKhoan.AllowUserToResizeRows = false;
            dataGridViewCellStyle55.BackColor = System.Drawing.Color.White;
            this.dgvTaiKhoan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle55;
            this.dgvTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle56.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle56.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle56.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle56.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle56.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle56.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle56.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle56;
            this.dgvTaiKhoan.ColumnHeadersHeight = 22;
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle57.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle57.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle57.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle57.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle57.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle57.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle57.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTaiKhoan.DefaultCellStyle = dataGridViewCellStyle57;
            this.dgvTaiKhoan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvTaiKhoan.Location = new System.Drawing.Point(66, 339);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.ReadOnly = true;
            this.dgvTaiKhoan.RowHeadersVisible = false;
            this.dgvTaiKhoan.RowHeadersWidth = 51;
            this.dgvTaiKhoan.RowTemplate.Height = 24;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(799, 293);
            this.dgvTaiKhoan.TabIndex = 26;
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
            this.dgvTaiKhoan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTaiKhoan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTaiKhoan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTaiKhoan.ThemeStyle.HeaderStyle.Height = 22;
            this.dgvTaiKhoan.ThemeStyle.ReadOnly = true;
            this.dgvTaiKhoan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTaiKhoan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTaiKhoan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTaiKhoan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvTaiKhoan.ThemeStyle.RowsStyle.Height = 24;
            this.dgvTaiKhoan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvTaiKhoan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTaiKhoan.SelectionChanged += new System.EventHandler(this.dgvTaiKhoan_SelectionChanged);
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
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(686, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "Tổng điểm:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(388, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "Cấp độ thành viên";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(63, 201);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "Tên đăng nhập";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(388, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "Mật khẩu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(74, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "ID";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblPoints.Location = new System.Drawing.Point(684, 143);
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
            this.txtCustomerID_Acc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerID_Acc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCustomerID_Acc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerID_Acc.Location = new System.Drawing.Point(66, 142);
            this.txtCustomerID_Acc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCustomerID_Acc.Name = "txtCustomerID_Acc";
            this.txtCustomerID_Acc.PlaceholderText = "ID";
            this.txtCustomerID_Acc.SelectedText = "";
            this.txtCustomerID_Acc.Size = new System.Drawing.Size(72, 33);
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
            this.btnUpdateAcc.Location = new System.Drawing.Point(914, 466);
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
            this.btnCreateAccount.Location = new System.Drawing.Point(914, 352);
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
            this.btnLoadAllAccounts.Location = new System.Drawing.Point(627, 296);
            this.btnLoadAllAccounts.Name = "btnLoadAllAccounts";
            this.btnLoadAllAccounts.Size = new System.Drawing.Size(238, 37);
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
            this.btnDelAcc.Location = new System.Drawing.Point(914, 587);
            this.btnDelAcc.Name = "btnDelAcc";
            this.btnDelAcc.Size = new System.Drawing.Size(84, 45);
            this.btnDelAcc.TabIndex = 32;
            this.btnDelAcc.Click += new System.EventHandler(this.btnDelAcc_Click);
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
            this.btnLoadTrans.Location = new System.Drawing.Point(749, 150);
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
            this.label27.Size = new System.Drawing.Size(126, 20);
            this.label27.TabIndex = 30;
            this.label27.Text = "Lịch sử giao dịch";
            // 
            // dgvTrans
            // 
            this.dgvTrans.AllowUserToAddRows = false;
            this.dgvTrans.AllowUserToDeleteRows = false;
            this.dgvTrans.AllowUserToResizeColumns = false;
            this.dgvTrans.AllowUserToResizeRows = false;
            dataGridViewCellStyle61.BackColor = System.Drawing.Color.White;
            this.dgvTrans.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle61;
            this.dgvTrans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTrans.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle62.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle62.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle62.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle62.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle62.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle62.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle62.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTrans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle62;
            this.dgvTrans.ColumnHeadersHeight = 20;
            this.dgvTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle63.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle63.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle63.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle63.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle63.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle63.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle63.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTrans.DefaultCellStyle = dataGridViewCellStyle63;
            this.dgvTrans.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvTrans.Location = new System.Drawing.Point(33, 106);
            this.dgvTrans.Name = "dgvTrans";
            this.dgvTrans.ReadOnly = true;
            this.dgvTrans.RowHeadersVisible = false;
            this.dgvTrans.RowHeadersWidth = 51;
            this.dgvTrans.RowTemplate.Height = 24;
            this.dgvTrans.Size = new System.Drawing.Size(656, 133);
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
            dataGridViewCellStyle64.BackColor = System.Drawing.Color.White;
            this.dgvThongTinHoaDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle64;
            this.dgvThongTinHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle65.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle65.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle65.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle65.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle65.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle65.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle65.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongTinHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle65;
            this.dgvThongTinHoaDon.ColumnHeadersHeight = 20;
            this.dgvThongTinHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle66.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle66.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle66.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle66.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle66.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle66.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle66.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThongTinHoaDon.DefaultCellStyle = dataGridViewCellStyle66;
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
            this.btnTimHoaDon.Location = new System.Drawing.Point(610, 138);
            this.btnTimHoaDon.Name = "btnTimHoaDon";
            this.btnTimHoaDon.Size = new System.Drawing.Size(136, 45);
            this.btnTimHoaDon.TabIndex = 26;
            this.btnTimHoaDon.Text = "Tìm hóa đơn";
            this.btnTimHoaDon.Click += new System.EventHandler(this.btnTimHoaDon_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(607, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 16);
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
            this.txtCustomerID_HoaDon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerID_HoaDon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCustomerID_HoaDon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerID_HoaDon.Location = new System.Drawing.Point(610, 93);
            this.txtCustomerID_HoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCustomerID_HoaDon.Name = "txtCustomerID_HoaDon";
            this.txtCustomerID_HoaDon.PlaceholderText = "";
            this.txtCustomerID_HoaDon.SelectedText = "";
            this.txtCustomerID_HoaDon.Size = new System.Drawing.Size(103, 28);
            this.txtCustomerID_HoaDon.TabIndex = 0;
            // 
            // btnDoiDiem
            // 
            this.btnDoiDiem.BorderRadius = 10;
            this.btnDoiDiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoiDiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDoiDiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDoiDiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDoiDiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDoiDiem.FillColor = System.Drawing.Color.ForestGreen;
            this.btnDoiDiem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiDiem.ForeColor = System.Drawing.Color.White;
            this.btnDoiDiem.Location = new System.Drawing.Point(610, 219);
            this.btnDoiDiem.Name = "btnDoiDiem";
            this.btnDoiDiem.Size = new System.Drawing.Size(137, 46);
            this.btnDoiDiem.TabIndex = 5;
            this.btnDoiDiem.Text = "Tích điểm";
            this.btnDoiDiem.Click += new System.EventHandler(this.btnDoiDiem_Click);
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
            this.guna2GroupBox6.Controls.Add(this.label22);
            this.guna2GroupBox6.Controls.Add(this.label24);
            this.guna2GroupBox6.Controls.Add(this.btnLoadGiftHistory);
            this.guna2GroupBox6.Controls.Add(this.dgvGiftHistory);
            this.guna2GroupBox6.Controls.Add(this.label17);
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
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.label22.Location = new System.Drawing.Point(307, 58);
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
            this.btnLoadGiftHistory.Location = new System.Drawing.Point(85, 149);
            this.btnLoadGiftHistory.Name = "btnLoadGiftHistory";
            this.btnLoadGiftHistory.Size = new System.Drawing.Size(136, 45);
            this.btnLoadGiftHistory.TabIndex = 39;
            this.btnLoadGiftHistory.Text = "Xem lịch sử";
            this.btnLoadGiftHistory.Click += new System.EventHandler(this.btnLoadGiftHistory_Click);
            // 
            // dgvGiftHistory
            // 
            this.dgvGiftHistory.AllowUserToAddRows = false;
            this.dgvGiftHistory.AllowUserToDeleteRows = false;
            this.dgvGiftHistory.AllowUserToResizeColumns = false;
            this.dgvGiftHistory.AllowUserToResizeRows = false;
            dataGridViewCellStyle67.BackColor = System.Drawing.Color.White;
            this.dgvGiftHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle67;
            this.dgvGiftHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle68.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle68.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle68.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle68.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle68.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle68.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle68.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGiftHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle68;
            this.dgvGiftHistory.ColumnHeadersHeight = 22;
            this.dgvGiftHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle69.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle69.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle69.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle69.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle69.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle69.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle69.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGiftHistory.DefaultCellStyle = dataGridViewCellStyle69;
            this.dgvGiftHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvGiftHistory.Location = new System.Drawing.Point(305, 81);
            this.dgvGiftHistory.Name = "dgvGiftHistory";
            this.dgvGiftHistory.ReadOnly = true;
            this.dgvGiftHistory.RowHeadersVisible = false;
            this.dgvGiftHistory.RowHeadersWidth = 51;
            this.dgvGiftHistory.RowTemplate.Height = 24;
            this.dgvGiftHistory.Size = new System.Drawing.Size(725, 181);
            this.dgvGiftHistory.TabIndex = 8;
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
            this.dgvGiftHistory.ThemeStyle.HeaderStyle.Height = 22;
            this.dgvGiftHistory.ThemeStyle.ReadOnly = true;
            this.dgvGiftHistory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvGiftHistory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvGiftHistory.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvGiftHistory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.dgvGiftHistory.ThemeStyle.RowsStyle.Height = 24;
            this.dgvGiftHistory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvGiftHistory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label17.Location = new System.Drawing.Point(23, 58);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(156, 31);
            this.label17.TabIndex = 5;
            this.label17.Text = "Điểm hiện có:";
            // 
            // lblPoint_gift
            // 
            this.lblPoint_gift.AutoSize = true;
            this.lblPoint_gift.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoint_gift.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPoint_gift.Location = new System.Drawing.Point(25, 100);
            this.lblPoint_gift.Name = "lblPoint_gift";
            this.lblPoint_gift.Size = new System.Drawing.Size(69, 23);
            this.lblPoint_gift.TabIndex = 6;
            this.lblPoint_gift.Text = "label18";
            // 
            // guna2GroupBox5
            // 
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
            this.guna2GroupBox5.Controls.Add(this.dgvGifts);
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
            this.btnAddGift.Location = new System.Drawing.Point(588, 172);
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
            this.btnDeleteGift.Location = new System.Drawing.Point(588, 294);
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
            this.btnEditGift.Location = new System.Drawing.Point(588, 234);
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
            this.btnLoadGifts.Location = new System.Drawing.Point(565, 97);
            this.btnLoadGifts.Name = "btnLoadGifts";
            this.btnLoadGifts.Size = new System.Drawing.Size(113, 37);
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
            this.btnRedeemGift.Location = new System.Drawing.Point(873, 106);
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
            this.label20.Location = new System.Drawing.Point(29, 67);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(150, 20);
            this.label20.TabIndex = 38;
            this.label20.Text = "Danh sách quà tặng";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(869, 251);
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
            this.txtIdCustomer_gift.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdCustomer_gift.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdCustomer_gift.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdCustomer_gift.Location = new System.Drawing.Point(973, 247);
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
            this.chkIsActive.Location = new System.Drawing.Point(719, 296);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(93, 24);
            this.chkIsActive.TabIndex = 11;
            this.chkIsActive.Text = "Mở/Khóa";
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
            // dgvGifts
            // 
            this.dgvGifts.AllowUserToAddRows = false;
            this.dgvGifts.AllowUserToDeleteRows = false;
            this.dgvGifts.AllowUserToResizeColumns = false;
            this.dgvGifts.AllowUserToResizeRows = false;
            dataGridViewCellStyle70.BackColor = System.Drawing.Color.White;
            this.dgvGifts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle70;
            this.dgvGifts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle71.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle71.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle71.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle71.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle71.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle71.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle71.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGifts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle71;
            this.dgvGifts.ColumnHeadersHeight = 20;
            this.dgvGifts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle72.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle72.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle72.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle72.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle72.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle72.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle72.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGifts.DefaultCellStyle = dataGridViewCellStyle72;
            this.dgvGifts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvGifts.Location = new System.Drawing.Point(29, 90);
            this.dgvGifts.Name = "dgvGifts";
            this.dgvGifts.ReadOnly = true;
            this.dgvGifts.RowHeadersVisible = false;
            this.dgvGifts.RowHeadersWidth = 51;
            this.dgvGifts.RowTemplate.Height = 24;
            this.dgvGifts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvGifts.Size = new System.Drawing.Size(518, 241);
            this.dgvGifts.TabIndex = 1;
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
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(716, 79);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(134, 20);
            this.label16.TabIndex = 2;
            this.label16.Text = "Chọn mã quà tặng:";
            // 
            // txtGiftID
            // 
            this.txtGiftID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiftID.DefaultText = "";
            this.txtGiftID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGiftID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGiftID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiftID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
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
            // tabSetting
            // 
            this.tabSetting.Controls.Add(this.guna2GroupBox4);
            this.tabSetting.Controls.Add(this.guna2GroupBox3);
            this.tabSetting.Location = new System.Drawing.Point(184, 4);
            this.tabSetting.Name = "tabSetting";
            this.tabSetting.Size = new System.Drawing.Size(1094, 667);
            this.tabSetting.TabIndex = 4;
            this.tabSetting.Text = "Cài đặt";
            this.tabSetting.UseVisualStyleBackColor = true;
            // 
            // guna2GroupBox4
            // 
            this.guna2GroupBox4.Controls.Add(this.guna2Button3);
            this.guna2GroupBox4.Controls.Add(this.btnLuuQuyDoi);
            this.guna2GroupBox4.Controls.Add(this.lblUser);
            this.guna2GroupBox4.Controls.Add(this.lblDatabase);
            this.guna2GroupBox4.Controls.Add(this.lblServer);
            this.guna2GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox4.Location = new System.Drawing.Point(0, 194);
            this.guna2GroupBox4.Name = "guna2GroupBox4";
            this.guna2GroupBox4.Size = new System.Drawing.Size(1094, 473);
            this.guna2GroupBox4.TabIndex = 1;
            this.guna2GroupBox4.Text = "Thông tin hệ thống";
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
            this.guna2Button3.Location = new System.Drawing.Point(944, 404);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(101, 33);
            this.guna2Button3.TabIndex = 41;
            this.guna2Button3.Text = "Exit";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
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
            this.btnLuuQuyDoi.Location = new System.Drawing.Point(36, 404);
            this.btnLuuQuyDoi.Name = "btnLuuQuyDoi";
            this.btnLuuQuyDoi.Size = new System.Drawing.Size(101, 33);
            this.btnLuuQuyDoi.TabIndex = 40;
            this.btnLuuQuyDoi.Text = "Lưu";
            this.btnLuuQuyDoi.Click += new System.EventHandler(this.btnLuuQuyDoi_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.ForeColor = System.Drawing.Color.Black;
            this.lblUser.Location = new System.Drawing.Point(32, 195);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(72, 20);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Thông tin";
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.ForeColor = System.Drawing.Color.Black;
            this.lblDatabase.Location = new System.Drawing.Point(32, 134);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(72, 20);
            this.lblDatabase.TabIndex = 3;
            this.lblDatabase.Text = "Thông tin";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.ForeColor = System.Drawing.Color.Black;
            this.lblServer.Location = new System.Drawing.Point(32, 81);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(72, 20);
            this.lblServer.TabIndex = 4;
            this.lblServer.Text = "Thông tin";
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.Controls.Add(this.txtTiLeQuyDoi);
            this.guna2GroupBox3.Controls.Add(this.label15);
            this.guna2GroupBox3.Controls.Add(this.lblRole);
            this.guna2GroupBox3.Controls.Add(this.toggleSwitchRole);
            this.guna2GroupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox3.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Size = new System.Drawing.Size(1094, 194);
            this.guna2GroupBox3.TabIndex = 0;
            this.guna2GroupBox3.Text = "Quản lý quyền";
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
            this.txtTiLeQuyDoi.Location = new System.Drawing.Point(244, 88);
            this.txtTiLeQuyDoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTiLeQuyDoi.Name = "txtTiLeQuyDoi";
            this.txtTiLeQuyDoi.PlaceholderText = "";
            this.txtTiLeQuyDoi.SelectedText = "";
            this.txtTiLeQuyDoi.Size = new System.Drawing.Size(101, 33);
            this.txtTiLeQuyDoi.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(240, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(195, 20);
            this.label15.TabIndex = 2;
            this.label15.Text = " Hệ số quy đổi (VND:POINT)";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.ForeColor = System.Drawing.Color.Black;
            this.lblRole.Location = new System.Drawing.Point(32, 55);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(59, 20);
            this.lblRole.TabIndex = 1;
            this.lblRole.Text = "Normal";
            // 
            // toggleSwitchRole
            // 
            this.toggleSwitchRole.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleSwitchRole.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleSwitchRole.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleSwitchRole.CheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleSwitchRole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleSwitchRole.Location = new System.Drawing.Point(36, 88);
            this.toggleSwitchRole.Name = "toggleSwitchRole";
            this.toggleSwitchRole.Size = new System.Drawing.Size(45, 30);
            this.toggleSwitchRole.TabIndex = 0;
            this.toggleSwitchRole.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toggleSwitchRole.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toggleSwitchRole.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleSwitchRole.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleSwitchRole.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch1_CheckedChanged_1);
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
            this.tabInvoice.ResumeLayout(false);
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrans)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinHoaDon)).EndInit();
            this.tabQuaTang.ResumeLayout(false);
            this.guna2GroupBox6.ResumeLayout(false);
            this.guna2GroupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiftHistory)).EndInit();
            this.guna2GroupBox5.ResumeLayout(false);
            this.guna2GroupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGifts)).EndInit();
            this.tabSetting.ResumeLayout(false);
            this.guna2GroupBox4.ResumeLayout(false);
            this.guna2GroupBox4.PerformLayout();
            this.guna2GroupBox3.ResumeLayout(false);
            this.guna2GroupBox3.PerformLayout();
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
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTrans;
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
        private Guna.UI2.WinForms.Guna2DataGridView dgvTaiKhoan;
        private Guna.UI2.WinForms.Guna2Button btnTimHoaDon;
        private Guna.UI2.WinForms.Guna2DataGridView dgvThongTinHoaDon;
        private System.Windows.Forms.TabPage tabSetting;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox4;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Label lblRole;
        private Guna.UI2.WinForms.Guna2ToggleSwitch toggleSwitchRole;
        private Guna.UI2.WinForms.Guna2TextBox txtTiLeQuyDoi;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm2;
        private System.Windows.Forms.TabPage tabQuaTang;
        private System.Windows.Forms.Label lblPoint_gift;
        private System.Windows.Forms.Label label17;
        private Guna.UI2.WinForms.Guna2TextBox txtGiftID;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2DataGridView dgvGifts;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox6;
        private Guna.UI2.WinForms.Guna2DataGridView dgvGiftHistory;
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
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button btnLoadTrans;
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
    }
}

