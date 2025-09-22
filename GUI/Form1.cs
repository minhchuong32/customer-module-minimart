using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MiniMart.BUS;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;

namespace MiniMart.GUI
{
    public partial class Form1 : Form
    {
        private Guna.UI2.WinForms.Guna2MessageDialog gunaMsg;


        private string connStr;
        private string role;
        private int currentId;

        private CustomerBUS customerBus;
        private AccountBUS accountBus;
        private InvoiceBUS invoiceBus;
        private GiftBUS giftBus;
        private MessageBUS messageBus;
        private ExchangeRateBUS exchangeRateBus;
        private StatisticsBUS statisticsBus;


        public Form1(string connStr, string role, int currentId)
        {
            InitializeComponent();
            // Khởi tạo Guna2MessageDialog
            gunaMsg = new Guna.UI2.WinForms.Guna2MessageDialog
            {
                Buttons = MessageDialogButtons.OK,
                Style = MessageDialogStyle.Dark,   // Light, Default, Dark
                Parent = this
            };

            this.connStr = connStr;
            this.role = role;
            this.currentId = currentId;

            customerBus = new CustomerBUS(connStr);
            accountBus = new AccountBUS(connStr);
            invoiceBus = new InvoiceBUS(connStr);
            giftBus = new GiftBUS(connStr);
            messageBus = new MessageBUS(connStr);
            exchangeRateBus = new ExchangeRateBUS(connStr);
            statisticsBus = new StatisticsBUS(connStr);

            lblRole.Text = "Quyền hạn: " + role;

            // Áp dụng quyền
            ApplyRoleUI();
        }

        // Controller show 
        private void ShowMessage(string caption, string text, MessageDialogIcon icon)
        {
            gunaMsg.Caption = caption;
            gunaMsg.Text = text;
            gunaMsg.Icon = icon;
            gunaMsg.Show();
        }

        private void ShowTab(TabPage tab, bool visible)
        {
            if (visible)
            {
                if (!tabMain.TabPages.Contains(tab))
                    tabMain.TabPages.Add(tab);
            }
            else
            {
                if (tabMain.TabPages.Contains(tab))
                    tabMain.TabPages.Remove(tab);
            }
        }


        private void ApplyRoleUI()
        {

            // Mặc định bật chế độ Normal
            txtTiLeQuyDoi.Text = "1:2";

            if (role == "Normal")
            {
                // disable txtbox quà tặng 
                txtIdCustomer_gift.Text = currentId.ToString();
                txtGiftName.Enabled = false;
                txtPointsRequired.Enabled = false;
                chkIsActive.Enabled = false;

                // Load thông tin cá nhân vs tài khoản
                LoadCustomerProfile(currentId);
                // Quyền Normal: chỉ thao tác cơ bản
                btnAddGift.Visible = false;
                btnEditGift.Visible = false;
                btnDeleteGift.Visible = false;



                // Ẩn tab Khách hàng
                ShowTab(tabCustomers, false);
                // Ẩn tab tài khoản 
                ShowTab(tabAccount, false);
                // Ẩn tab hệ thống 
                ShowTab(tabSystem, false);
                // Ân tab hóa đơn
                ShowTab(tabInvoice, false);
                // Ẩn tab thông kê 
                ShowTab(tabStatistics, false);

                // Ẩn tab chat
                ShowTab(tabChat, false);
            }
            else if (role == "VIP")
            {
                // disable txtbox quà tặng 
                txtIdCustomer_gift.Text = currentId.ToString();
                txtGiftName.Enabled = false;
                txtPointsRequired.Enabled = false;
                chkIsActive.Enabled = false;
                // Ẩn label 
                lblKhachHang.Visible = false;
                // Ẩn cbb chat 
                cbbCustomers.Visible = false;

                // Ẩn btn đổi điểm 
                btnDoiDiem.Visible = false;
                // Load thông tin cá nhân vs tài khoản
                LoadCustomerProfile(currentId);
                // Quyền VIP: có thể đổi quà, xem báo cáo, nhưng không quản lý quà
                txtTiLeQuyDoi.Text = "1:5";

                btnAddGift.Visible = false;
                btnEditGift.Visible = false;
                btnDeleteGift.Visible = false;


                // Ẩn tab Khách hàng
                ShowTab(tabCustomers, false);
                // Ẩn tab tài khoản 
                ShowTab(tabAccount, false);
                // Ẩn tab hệ thống 
                ShowTab(tabSystem, false);
                // Ân tab hóa đơn
                ShowTab(tabInvoice, false);

                // Hiện tab chat
                ShowTab(tabChat, true);

                loadStatsVip(currentId);

                LoadConversationForCustomer(currentId);


            }
            else if (role == "Manager")
            {
                loadInfoManagerAndAcc(currentId);

                // Ẩn tab settinh user 
                ShowTab(SettingUser, false);
                // Ẩn tab thông kê 
                ShowTab(tabStatistics, false);
                // Hiện tab Khách hàng
                ShowTab(tabCustomers, true);
                // Hiện tab chat
                ShowTab(tabChat, true);

                //  Hiện cbb chat cho admin liên hệ
                cbbCustomers.Visible = true;

                // Load danh sách khách hàng
                LoadCustomersToComboBox();

                LoadConversationForAdmin(-1); // Chưa chọn khách nào
            }

            // Cập nhật thông tin hệ thống
            UpdateSystemInfo();
        }



        // ========================= TAB chat =========================

        private void cbbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Bỏ qua nếu SelectedValue chưa sẵn sàng hoặc đang là DataRowView
            if (cbbCustomers.SelectedValue == null || cbbCustomers.SelectedValue is DataRowView)
                return;

            try
            {
                int customerId = Convert.ToInt32(cbbCustomers.SelectedValue);
                LoadConversationForAdmin(customerId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load hội thoại: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadConversationForAdmin(int customerId)
        {
            DataTable dt = messageBus.GetConversation(customerId, role);

            lstConversation.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                bool isFromAdmin = Convert.ToBoolean(row["IsFromAdmin"]);
                string sender = isFromAdmin ? "Admin" : "Khách";
                string content = row["Content"].ToString();
                string time = Convert.ToDateTime(row["SentDate"]).ToString("HH:mm dd/MM");

                lstConversation.Items.Add($"[{time}] {sender}: {content}");
            }
        }

        private void LoadConversationForCustomer(int customerId)
        {

            DataTable dt = messageBus.GetConversation(customerId, role);

            lstConversation.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                bool isFromAdmin = Convert.ToBoolean(row["IsFromAdmin"]);
                string sender = isFromAdmin ? "Admin" : "Bạn";
                string content = row["Content"].ToString();
                string time = Convert.ToDateTime(row["SentDate"]).ToString("HH:mm dd/MM");

                lstConversation.Items.Add($"[{time}] {sender}: {content}");
            }
        }


        private void LoadCustomersToComboBox()
        {
            DataTable dt = customerBus.GetAllCustomers();

            cbbCustomers.DisplayMember = "FullName";   // Hiển thị tên khách hàng
            cbbCustomers.ValueMember = "CustomerID";   // Lấy ID khi cần
            cbbCustomers.DataSource = dt;
        }



        // ========================= TAB Cài đặt - USER =========================
        private void LoadCustomerProfile(int customerId)
        {
            var row = customerBus.GetCustomerProfile(customerId);
            if (row != null)
            {
                // Gán dữ liệu vào textbox
                txtHoten_cus.Text = row["FullName"].ToString();
                txtSdt_cus.Text = row["Phone"].ToString();
                TxtEmail_cus.Text = row["Email"].ToString();
                txtDiaChi_cus.Text = row["Address"].ToString();
                cbbGioiTinh_cus.SelectedItem = row["Gender"].ToString();
                dtpNgaySinh_cus.Value = Convert.ToDateTime(row["BirthDate"]);
                cbbTrangThai_cus.SelectedItem = row["Status"].ToString();

                txtUsername_cus.Text = row["Username"].ToString();
                txtPass_cus.Text = row["Password"].ToString();

                lblCapDo_cus.Text = row["MemberLevel"].ToString();
                lblPoints_cus.Text = row["Points"].ToString();
            }
        }

        // ========================= TAB KHÁCH HÀNG =========================

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFullName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            cboGender.SelectedIndex = 0;
            cboStatus.SelectedIndex = 0;
            dtpBirthDate.Value = DateTime.Today;

            txtCustomerID_Acc.Clear();
            txtCustomerID_HoaDon.Clear();
            txtIdCustomer_gift.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvCustomers.DataSource = customerBus.Search(txtSearch.Text.Trim());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string email = txtEmail.Text.Trim();
            string address = txtAddress.Text.Trim();
            string gender = cboGender.Text;
            DateTime birthDate = dtpBirthDate.Value;
            string status = cboStatus.Text;

            // 1. Kiểm tra bỏ trống
            if (string.IsNullOrWhiteSpace(fullName) ||
                string.IsNullOrWhiteSpace(phone) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(address) ||
                string.IsNullOrWhiteSpace(gender) ||
                string.IsNullOrWhiteSpace(status))
            {
                ShowMessage("Lỗi",
                    "Vui lòng nhập đầy đủ thông tin khách hàng.",
                    MessageDialogIcon.Error);
                return;
            }

            // 2. Kiểm tra số điện thoại (chỉ số, 9-11 số)
            if (!System.Text.RegularExpressions.Regex.IsMatch(phone, @"^\d{9,11}$"))
            {
                ShowMessage("Lỗi",
                    "Số điện thoại không hợp lệ (chỉ chứa số, từ 9-11 số).",
                    MessageDialogIcon.Error);
                return;
            }

            // 3. Kiểm tra email
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
            }
            catch
            {
                ShowMessage("Lỗi",
                    "Địa chỉ email không hợp lệ.",
                    MessageDialogIcon.Error);
                return;
            }

            // 4. Thực hiện Insert nếu hợp lệ
            try
            {
                var newId = customerBus.Insert(fullName, phone, email, address, gender, birthDate, status);

                ShowMessage("Thành công",
                    "Đã thêm khách hàng mới. ID = " + newId,
                    MessageDialogIcon.Information);

                dgvCustomers.DataSource = customerBus.Search(txtSearch.Text.Trim());
            }
            catch (Exception ex)
            {
                ShowMessage("Lỗi",
                    "Không thể thêm khách hàng: " + ex.Message,
                    MessageDialogIcon.Error);
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow == null)
            {
                ShowMessage("Lỗi",
                    "Vui lòng chọn khách hàng cần cập nhật.",
                    MessageDialogIcon.Error);
                return;
            }

            int id = Convert.ToInt32(dgvCustomers.CurrentRow.Cells["CustomerID"].Value);

            string fullName = txtFullName.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string email = txtEmail.Text.Trim();
            string address = txtAddress.Text.Trim();
            string gender = cboGender.Text;
            DateTime birthDate = dtpBirthDate.Value;
            string status = cboStatus.Text;

            // 1. Kiểm tra bỏ trống
            if (string.IsNullOrWhiteSpace(fullName) ||
                string.IsNullOrWhiteSpace(phone) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(address) ||
                string.IsNullOrWhiteSpace(gender) ||
                string.IsNullOrWhiteSpace(status))
            {
                ShowMessage("Lỗi",
                    "Không được bỏ trống thông tin khi cập nhật.",
                    MessageDialogIcon.Error);
                return;
            }

            // 2. Kiểm tra số điện thoại (chỉ số, 9–11 ký tự)
            if (!System.Text.RegularExpressions.Regex.IsMatch(phone, @"^\d{9,11}$"))
            {
                ShowMessage("Lỗi",
                    "Số điện thoại không hợp lệ (chỉ chứa số, 9–11 số).",
                    MessageDialogIcon.Error);
                return;
            }

            // 3. Kiểm tra email
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
            }
            catch
            {
                ShowMessage("Lỗi",
                    "Email không hợp lệ.",
                    MessageDialogIcon.Error);
                return;
            }

            // 4. Update nếu dữ liệu hợp lệ
            try
            {
                customerBus.Update(id, fullName, phone, email, address, gender, birthDate, status);

                ShowMessage("Thành công",
                    "Đã cập nhật khách hàng.",
                    MessageDialogIcon.Information);

                dgvCustomers.DataSource = customerBus.Search(txtSearch.Text.Trim());
            }
            catch (Exception ex)
            {
                ShowMessage("Lỗi",
                    "Không thể cập nhật: " + ex.Message,
                    MessageDialogIcon.Error);
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow == null)
            {
                ShowMessage("Lỗi",
                    "Vui lòng chọn khách hàng cần xóa.",
                    MessageDialogIcon.Error);
                return;
            }

            int id = Convert.ToInt32(dgvCustomers.CurrentRow.Cells["CustomerID"].Value);

            // Hộp thoại xác nhận
            DialogResult confirm = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa khách hàng này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.No)
                return;

            try
            {
                bool success = customerBus.Delete(id);

                if (success)
                {
                    ShowMessage("Thành công",
                        "Đã xóa khách hàng.",
                        MessageDialogIcon.Information);
                    dgvCustomers.DataSource = customerBus.Search(txtSearch.Text.Trim());
                }
                else
                {
                    ShowMessage("Thông báo",
                        "Không tìm thấy khách hàng hoặc không thể xóa.",
                        MessageDialogIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                ShowMessage("Lỗi",
                    "Không thể xóa khách hàng: " + ex.Message,
                    MessageDialogIcon.Error);
            }
        }


        private void dgvCustomers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow == null) return;

            DataGridViewRow r = dgvCustomers.CurrentRow;
            txtFullName.Text = r.Cells["FullName"].Value.ToString();
            txtPhone.Text = r.Cells["Phone"].Value.ToString();
            txtEmail.Text = r.Cells["Email"].Value.ToString();
            txtAddress.Text = r.Cells["Address"].Value.ToString();
            cboGender.Text = r.Cells["Gender"].Value.ToString();
            cboStatus.Text = r.Cells["Status"].Value.ToString();

            if (r.Cells["BirthDate"].Value != DBNull.Value)
                dtpBirthDate.Value = Convert.ToDateTime(r.Cells["BirthDate"].Value);

            if (r.Cells["CustomerID"].Value != DBNull.Value)
            {
                string id = r.Cells["CustomerID"].Value.ToString();
                txtCustomerID_Acc.Text = id;
                txtCustomerID_HoaDon.Text = id;
                txtIdCustomer_gift.Text = id;
            }
        }

        // ========================= TAB TÀI KHOẢN =========================

        private void guna2ToggleSwitch1_CheckedChanged_1(object sender, EventArgs e)
        {

        }
        private void UpdateSystemInfo()
        {
            lblServer.Text = "Server: MINH-CHUONG";
            lblDatabase.Text = "Database: MiniMartDB";
        }
        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            // Nếu checkbox đang được bật, hiển thị mật khẩu
            if (guna2ToggleShowPass.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.PasswordChar = '\0'; // hiển thị ký tự thật
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.PasswordChar = '•'; // ẩn bằng chấm tròn
            }
        }


        private void dgvTaiKhoan_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.CurrentRow == null) return;

            DataGridViewRow r = dgvTaiKhoan.CurrentRow;

            txtUsername.Text = Convert.ToString(r.Cells["Username"].Value);
            txtPassword.Text = Convert.ToString(r.Cells["Password"].Value);
            cboMemberLevel.Text = Convert.ToString(r.Cells["MemberLevel"].Value);

            object pointValue = r.Cells["Points"].Value;
            if (pointValue != null && pointValue != DBNull.Value)
            {
                lblPoints.Text = pointValue.ToString();
            }
            else
            {
                lblPoints.Text = ": -";
            }

            // Gán CustomerID nếu có cột này trong dgv
            object cid = r.Cells["CustomerID"].Value;
            if (cid != null && cid != DBNull.Value)
            {
                txtCustomerID_Acc.Text = cid.ToString();
            }
        }
        private void btnLuuQuyDoi_Click(object sender, EventArgs e)
        {
            if (cbbRoleRate.SelectedItem == null)
            {
                gunaMsg.Caption = "Lỗi";
                gunaMsg.Text = "Vui lòng chọn quyền hạn để cập nhật tỉ lệ.";
                gunaMsg.Icon = MessageDialogIcon.Error;
                gunaMsg.Show();
                return;
            }

            string roleSelected = cbbRoleRate.SelectedItem.ToString();
            string newRate = txtTiLeQuyDoi.Text.Trim();

            if (string.IsNullOrWhiteSpace(newRate))
            {
                gunaMsg.Caption = "Lỗi";
                gunaMsg.Text = "Vui lòng nhập tỉ lệ quy đổi.";
                gunaMsg.Icon = MessageDialogIcon.Error;
                gunaMsg.Show();
                return;
            }

            // Lấy dữ liệu từ form nhân viên
            string fullName = txtFullname_ad.Text.Trim();
            string phone = txtPhone_ad.Text.Trim();
            string email = txtEmail_ad.Text.Trim();
            string pos = txtPosition_ad.Text.Trim();
            string gender = cbbGender_ad.Text;
            string address = txtAddress_ad.Text.Trim();
            DateTime birthDate = dtpBirthDate_ad.Value;
            DateTime hireDate = dtpHireDate_ad.Value;

            string newUsername = txtUsername_ad.Text.Trim();
            string newPassword = txtPassword_ad.Text.Trim();

            accountBus.UpdateEmployeeAndAccount(currentId, fullName, phone, email,
                pos, gender, address, birthDate, hireDate, newUsername, newPassword);

            // Cập nhật tỉ lệ quy đổi
            exchangeRateBus.UpdateRate(roleSelected, newRate);

            gunaMsg.Caption = "Thông báo";
            gunaMsg.Text = $"Đã cập nhật nhân viên và tỉ lệ quy đổi cho {roleSelected}: {newRate}";
            gunaMsg.Icon = MessageDialogIcon.Information;
            gunaMsg.Show();

            UpdateSystemInfo();

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra CustomerID
            if (string.IsNullOrWhiteSpace(txtCustomerID_Acc.Text))
            {
                gunaMsg.Caption = "Lỗi";
                gunaMsg.Text = "ID Khách hàng không được trống!";
                gunaMsg.Icon = MessageDialogIcon.Error;
                gunaMsg.Show();
                return;
            }

            if (!int.TryParse(txtCustomerID_Acc.Text.Trim(), out int customerId))
            {
                gunaMsg.Caption = "Lỗi";
                gunaMsg.Text = "ID Khách hàng phải là số hợp lệ!";
                gunaMsg.Icon = MessageDialogIcon.Error;
                gunaMsg.Show();
                return;
            }

            // 2. Kiểm tra Username, Password
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string memberLevel = cboMemberLevel.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                gunaMsg.Caption = "Lỗi";
                gunaMsg.Text = "Tên đăng nhập và mật khẩu không được bỏ trống!";
                gunaMsg.Icon = MessageDialogIcon.Error;
                gunaMsg.Show();
                return;
            }

            if (string.IsNullOrWhiteSpace(memberLevel))
            {
                gunaMsg.Caption = "Lỗi";
                gunaMsg.Text = "Vui lòng chọn quyền hạn (Normal / VIP).";
                gunaMsg.Icon = MessageDialogIcon.Error;
                gunaMsg.Show();
                return;
            }

            try
            {
                // 3. Gọi sang BUS
                var accId = accountBus.Create(customerId, username, password, memberLevel);

                ShowMessage("Thành công",
                    "Tạo tài khoản thành công. ID = " + accId,
                    MessageDialogIcon.Information);

                dgvTaiKhoan.DataSource = accountBus.GetAll();
            }
            catch (Exception ex)
            {
                ShowMessage("Lỗi",
                    "Không thể tạo tài khoản: " + ex.Message,
                    MessageDialogIcon.Error);
            }
        }


        private void btnViewAccount_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerID_Acc.Text))
            {
                gunaMsg.Caption = "Lỗi";
                gunaMsg.Text = "ID Khách hàng không được trống!";
                gunaMsg.Icon = MessageDialogIcon.Error;
                gunaMsg.Show();
                return;
            }
            int customerId = int.Parse(txtCustomerID_Acc.Text.Trim());

            DataTable dt = accountBus.GetByCustomer(customerId);

            if (dt.Rows.Count == 0)
            {
                lblPoints.Text = "0";
                gunaMsg.Caption = "Thông báo";
                gunaMsg.Text = "Chưa có tài khoản cho khách này!";
                gunaMsg.Icon = MessageDialogIcon.Information;
                gunaMsg.Show();
                return;
            }

            DataRow row = dt.Rows[0];
            txtUsername.Text = row["Username"].ToString();
            txtPassword.Text = row["Password"].ToString();
            cboMemberLevel.Text = row["MemberLevel"].ToString();
            lblPoints.Text = row["Points"].ToString();
        }

        private void btnUpdateAcc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerID_Acc.Text))
            {
                gunaMsg.Caption = "Lỗi";
                gunaMsg.Text = "ID Khách hàng không được trống!";
                gunaMsg.Icon = MessageDialogIcon.Error;
                gunaMsg.Show();
                return;
            }
            int customerId = int.Parse(txtCustomerID_Acc.Text.Trim());

            accountBus.Update(customerId,
                txtUsername.Text.Trim(),
                txtPassword.Text.Trim(),
                cboMemberLevel.Text,
                lblPoints.Text
            );
            ShowMessage("Thành công",
         "Cập nhật tài khoản thành công",
          MessageDialogIcon.Information);
            dgvTaiKhoan.DataSource = accountBus.GetAll();
        }

        private void btnDelAcc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerID_Acc.Text))
            {
                gunaMsg.Caption = "Lỗi";
                gunaMsg.Text = "ID Khách hàng không được trống!";
                gunaMsg.Icon = MessageDialogIcon.Error;
                gunaMsg.Show();
                return;
            }
            int customerId = int.Parse(txtCustomerID_Acc.Text.Trim());
            accountBus.Delete(customerId);
            ShowMessage("Thành công",
        "Đã xóa tài khoản.",
         MessageDialogIcon.Information);
            txtUsername.Clear();
            txtPassword.Clear();
            cboMemberLevel.SelectedIndex = 0;
            lblPoints.Text = "-";
            dgvTaiKhoan.DataSource = accountBus.GetAll();
        }

        private void btnLoadAllAccounts_Click(object sender, EventArgs e)
        {

            dgvTaiKhoan.DataSource = accountBus.GetAll();
        }

        // ========================= TAB HÓA ĐƠN =========================

        private void btnTimHoaDon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerID_HoaDon.Text))
            {
                gunaMsg.Caption = "Lỗi";
                gunaMsg.Text = "Vui lòng nhập ID khách hàng.";
                gunaMsg.Icon = MessageDialogIcon.Error;
                gunaMsg.Show();
                return;
            }

            if (!int.TryParse(txtCustomerID_HoaDon.Text.Trim(), out int customerId))
            {
                gunaMsg.Caption = "Lỗi";
                gunaMsg.Text = "ID khách hàng phải là số hợp lệ.";
                gunaMsg.Icon = MessageDialogIcon.Error;
                gunaMsg.Show();
                return;
            }

            try
            {
                dgvThongTinHoaDon.DataSource = invoiceBus.GetByCustomer(customerId);

                if (dgvThongTinHoaDon.Rows.Count == 0)
                {
                    gunaMsg.Caption = "Thông báo";
                    gunaMsg.Text = "Khách hàng này chưa có hóa đơn nào.";
                    gunaMsg.Icon = MessageDialogIcon.Information;
                    gunaMsg.Show();
                }
            }
            catch (Exception ex)
            {
                gunaMsg.Caption = "Lỗi";
                gunaMsg.Text = "Không thể tải hóa đơn: " + ex.Message;
                gunaMsg.Icon = MessageDialogIcon.Error;
                gunaMsg.Show();
            }
        }

        private void btnLoadTrans_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerID_HoaDon.Text))
            {
                gunaMsg.Caption = "Lỗi";
                gunaMsg.Text = "Vui lòng nhập ID khách hàng.";
                gunaMsg.Icon = MessageDialogIcon.Error;
                gunaMsg.Show();
                return;
            }

            if (!int.TryParse(txtCustomerID_HoaDon.Text.Trim(), out int customerId))
            {
                gunaMsg.Caption = "Lỗi";
                gunaMsg.Text = "ID khách hàng phải là số hợp lệ.";
                gunaMsg.Icon = MessageDialogIcon.Error;
                gunaMsg.Show();
                return;
            }

            try
            {

                dgvTrans.DataSource = invoiceBus.GetTransactions(customerId);

                if (dgvTrans.Rows.Count == 0)
                {
                    gunaMsg.Caption = "Thông báo";
                    gunaMsg.Text = "Không có giao dịch nào trong khoảng thời gian đã chọn.";
                    gunaMsg.Icon = MessageDialogIcon.Information;
                    gunaMsg.Show();
                }
            }
            catch (Exception ex)
            {
                gunaMsg.Caption = "Lỗi";
                gunaMsg.Text = "Không thể tải giao dịch: " + ex.Message;
                gunaMsg.Icon = MessageDialogIcon.Error;
                gunaMsg.Show();
            }
        }

        private void btnDoiDiem_Click(object sender, EventArgs e)
        {
            try
            {
                int customerId = int.Parse(txtCustomerID_Acc.Text.Trim());
                int invoiceId = int.Parse(txtInvoiceID.Text.Trim());

                dgvTrans.DataSource = invoiceBus.ConvertToPoints(customerId, invoiceId);

                gunaMsg.Caption = "Thành công";
                gunaMsg.Text = "Quy đổi điểm thành công!";
                gunaMsg.Icon = MessageDialogIcon.Information;
                gunaMsg.Show();
            }
            catch (SqlException ex)
            {
                gunaMsg.Caption = "Cảnh báo";
                gunaMsg.Text = ex.Message; // sẽ hiện: "Hóa đơn này đã được quy đổi điểm trước đó."
                gunaMsg.Icon = MessageDialogIcon.Warning;
                gunaMsg.Show();
            }
        }




        // ========================= TAB QUÀ TẶNG =========================




        private void btnLoadGifts_Click(object sender, EventArgs e)
        {
            dgvGifts.DataSource = giftBus.GetAll();
        }

        private void dgvGifts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGifts.CurrentRow == null) return;

            txtGiftID.Text = dgvGifts.CurrentRow.Cells["GiftID"].Value.ToString();
            txtGiftName.Text = dgvGifts.CurrentRow.Cells["GiftName"].Value.ToString();
            txtPointsRequired.Text = dgvGifts.CurrentRow.Cells["PointsRequired"].Value.ToString();
            object value = dgvGifts.CurrentRow.Cells["IsActive"].Value;

            if (value != DBNull.Value)
            {
                bool isActive = Convert.ToBoolean(value);
                chkIsActive.Checked = isActive;
                chkIsActive.Text = isActive ? "Còn hàng" : "Hết hàng";
            }
            else
            {
                chkIsActive.Checked = false;
                chkIsActive.Text = "Hết hàng";
            }

        }

        private void btnRedeemGift_Click(object sender, EventArgs e)
        {
            // Kiểm tra CustomerID
            if (string.IsNullOrWhiteSpace(txtIdCustomer_gift.Text))
            {
                gunaMsg.Caption = "Lỗi";
                gunaMsg.Text = "Vui lòng nhập ID khách hàng.";
                gunaMsg.Icon = MessageDialogIcon.Error;
                gunaMsg.Show();
                return;
            }

            int customerId;
            if (!int.TryParse(txtIdCustomer_gift.Text.Trim(), out customerId))
            {
                gunaMsg.Caption = "Lỗi";
                gunaMsg.Text = "ID khách hàng phải là số hợp lệ.";
                gunaMsg.Icon = MessageDialogIcon.Error;
                gunaMsg.Show();
                return;
            }

            // Kiểm tra GiftID
            if (string.IsNullOrWhiteSpace(txtGiftID.Text))
            {
                gunaMsg.Caption = "Lỗi";
                gunaMsg.Text = "Vui lòng nhập ID quà.";
                gunaMsg.Icon = MessageDialogIcon.Error;
                gunaMsg.Show();
                return;
            }

            int giftId;
            if (!int.TryParse(txtGiftID.Text.Trim(), out giftId))
            {
                gunaMsg.Caption = "Lỗi";
                gunaMsg.Text = "ID quà phải là số hợp lệ.";
                gunaMsg.Icon = MessageDialogIcon.Error;
                gunaMsg.Show();
                return;
            }

            // Thực hiện Redeem
            try
            {
                dgvGiftHistory.DataSource = giftBus.Redeem(customerId, giftId);

                gunaMsg.Caption = "Thông báo";
                gunaMsg.Text = "Đổi quà thành công!";
                gunaMsg.Icon = MessageDialogIcon.Information;
                gunaMsg.Show();
            }
            catch (Exception ex)
            {
                gunaMsg.Caption = "Lỗi";
                gunaMsg.Text = "Đổi quà thất bại: " + ex.Message;
                gunaMsg.Icon = MessageDialogIcon.Error;
                gunaMsg.Show();
            }

        }

        private void btnAddGift_Click(object sender, EventArgs e)
        {
            // Kiểm tra ID
            if (string.IsNullOrWhiteSpace(txtGiftID.Text))
            {
                gunaMsg.Caption = "Lỗi";
                gunaMsg.Text = "Vui lòng nhập ID quà.";
                gunaMsg.Icon = MessageDialogIcon.Error;
                gunaMsg.Show();
                return;
            }

            int giftId;
            if (!int.TryParse(txtGiftID.Text.Trim(), out giftId))
            {
                gunaMsg.Caption = "Lỗi";
                gunaMsg.Text = "ID phải là số hợp lệ.";
                gunaMsg.Icon = MessageDialogIcon.Error;
                gunaMsg.Show();
                return;
            }

            // Kiểm tra tên quà
            if (string.IsNullOrWhiteSpace(txtGiftName.Text))
            {
                gunaMsg.Caption = "Lỗi";
                gunaMsg.Text = "Vui lòng nhập tên quà.";
                gunaMsg.Icon = MessageDialogIcon.Error;
                gunaMsg.Show();
                return;
            }

            // Kiểm tra điểm
            int pointsRequired;
            if (!int.TryParse(txtPointsRequired.Text.Trim(), out pointsRequired))
            {
                gunaMsg.Caption = "Lỗi";
                gunaMsg.Text = "Điểm phải là số hợp lệ.";
                gunaMsg.Icon = MessageDialogIcon.Error;
                gunaMsg.Show();
                return;
            }

            // Nếu tất cả hợp lệ thì Insert
            giftBus.Insert(
                           txtGiftName.Text.Trim(),
                           pointsRequired,
                           chkIsActive.Checked);

            gunaMsg.Caption = "Thông báo";
            gunaMsg.Text = "Đã thêm quà.";
            gunaMsg.Icon = MessageDialogIcon.Information;
            gunaMsg.Show();

            // Refresh lại DataGridView
            dgvGifts.DataSource = giftBus.GetAll();

        }

        private void btnEditGift_Click(object sender, EventArgs e)
        {
            // Kiểm tra ID
            if (string.IsNullOrWhiteSpace(txtGiftID.Text))
            {
                gunaMsg.Caption = "Lỗi";
                gunaMsg.Text = "Vui lòng nhập ID quà để cập nhật.";
                gunaMsg.Icon = MessageDialogIcon.Error;
                gunaMsg.Show();
                return;
            }

            int giftId;
            if (!int.TryParse(txtGiftID.Text.Trim(), out giftId))
            {
                gunaMsg.Caption = "Lỗi";
                gunaMsg.Text = "ID quà phải là số hợp lệ.";
                gunaMsg.Icon = MessageDialogIcon.Error;
                gunaMsg.Show();
                return;
            }

            // Kiểm tra tên quà
            if (string.IsNullOrWhiteSpace(txtGiftName.Text))
            {
                gunaMsg.Caption = "Lỗi";
                gunaMsg.Text = "Tên quà không được để trống.";
                gunaMsg.Icon = MessageDialogIcon.Error;
                gunaMsg.Show();
                return;
            }

            // Kiểm tra điểm yêu cầu
            int pointsRequired;
            if (!int.TryParse(txtPointsRequired.Text.Trim(), out pointsRequired))
            {
                gunaMsg.Caption = "Lỗi";
                gunaMsg.Text = "Điểm phải là số hợp lệ.";
                gunaMsg.Icon = MessageDialogIcon.Error;
                gunaMsg.Show();
                return;
            }

            // Gọi Update nếu dữ liệu hợp lệ
            giftBus.Update(
                giftId,
                txtGiftName.Text.Trim(),
                pointsRequired,
                chkIsActive.Checked
            );

            gunaMsg.Caption = "Thông báo";
            gunaMsg.Text = "Đã cập nhật quà!";
            gunaMsg.Icon = MessageDialogIcon.Information;
            gunaMsg.Show();

            // Refresh lại DataGridView
            dgvGifts.DataSource = giftBus.GetAll();

        }

        private void btnDeleteGift_Click(object sender, EventArgs e)
        {
            // Kiểm tra ID trước khi xóa
            if (string.IsNullOrWhiteSpace(txtGiftID.Text))
            {
                gunaMsg.Caption = "Lỗi";
                gunaMsg.Text = "Vui lòng nhập ID quà để xóa.";
                gunaMsg.Icon = MessageDialogIcon.Error;
                gunaMsg.Show();
                return;
            }

            int giftId;
            if (!int.TryParse(txtGiftID.Text.Trim(), out giftId))
            {
                gunaMsg.Caption = "Lỗi";
                gunaMsg.Text = "ID quà phải là số hợp lệ.";
                gunaMsg.Icon = MessageDialogIcon.Error;
                gunaMsg.Show();
                return;
            }

            // Xác nhận trước khi xóa
            DialogResult confirm = MessageBox.Show(
                "Bạn có chắc muốn xóa quà này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.No)
            {
                return;
            }

            // Gọi Delete
            giftBus.Delete(giftId);

            gunaMsg.Caption = "Thông báo";
            gunaMsg.Text = "Đã xóa quà.";
            gunaMsg.Icon = MessageDialogIcon.Information;
            gunaMsg.Show();

            // Refresh DataGridView
            dgvGifts.DataSource = giftBus.GetAll();

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnLuuThayDoi_cus_Click(object sender, EventArgs e)
        {
            int customerId = currentId;

            string fullName = txtHoten_cus.Text;
            string phone = txtSdt_cus.Text;
            string email = TxtEmail_cus.Text;
            string address = txtDiaChi_cus.Text;
            string gender = cbbGioiTinh_cus.SelectedItem?.ToString();
            DateTime birthDate = dtpNgaySinh_cus.Value;
            string status = cbbTrangThai_cus.SelectedItem?.ToString();

            string username = txtUsername_cus.Text;
            string password = txtPass_cus.Text;
            string points = lblPoints_cus.Text; // không cho khách sửa điểm
            string memberLevel = lblCapDo_cus.Text; // không cho khách sửa cấp độ

            // Gọi BUS để cập nhật cả Customer + Account
            bool result = customerBus.UpdateCustomerAndAccount(
                customerId,
                username, password, memberLevel, points,
                fullName, phone, email,
                address, gender, birthDate, status
            );

            if (result)
            {
                gunaMsg.Caption = "Thông báo";
                gunaMsg.Text = "Cập nhật thành công!";
                gunaMsg.Icon = MessageDialogIcon.Information;
                gunaMsg.Show();
            }
            else
            {
                gunaMsg.Caption = "Lỗi";
                gunaMsg.Text = "Cập nhật thất bại!";
                gunaMsg.Icon = MessageDialogIcon.Error;
                gunaMsg.Show();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (role == "Normal")
            {
                gunaMsg.Caption = "Thông báo";
                gunaMsg.Text = "Chức năng này chỉ dành cho khách VIP và Admin.";
                gunaMsg.Icon = MessageDialogIcon.Warning;
                gunaMsg.Show();
                return;
            }
            else if (role == "Manager")
            {
                if (cbbCustomers.SelectedValue == null)
                {
                    gunaMsg.Caption = "Lỗi";
                    gunaMsg.Text = "Vui lòng chọn khách hàng để gửi tin nhắn.";
                    gunaMsg.Icon = MessageDialogIcon.Error;
                    gunaMsg.Show();
                    return;
                }
                string content = txtMessage.Text.Trim();
                if (string.IsNullOrEmpty(content))
                {
                    gunaMsg.Caption = "Lỗi";
                    gunaMsg.Text = "Vui lòng nhập tin nhắn!";
                    gunaMsg.Icon = MessageDialogIcon.Error;
                    gunaMsg.Show();
                    return;
                }
                messageBus.Send(currentId, true, content);
                int customerId = Convert.ToInt32(cbbCustomers.SelectedValue);
                LoadConversationForAdmin(customerId);
            }
            else
            {
                string content = txtMessage.Text.Trim();
                if (string.IsNullOrEmpty(content))
                {
                    gunaMsg.Caption = "Lỗi";
                    gunaMsg.Text = "Vui lòng nhập tin nhắn!";
                    gunaMsg.Icon = MessageDialogIcon.Error;
                    gunaMsg.Show();
                    return;
                }
                messageBus.Send(currentId, false, content);
                int customerId = currentId;
                LoadConversationForCustomer(customerId);
            }
            txtMessage.Clear();
        }


        private void btnLoadGiftHistory_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdCustomer_gift.Text))
            {
                gunaMsg.Caption = "Lỗi";
                gunaMsg.Text = "Vui lòng nhập ID khách hàng.";
                gunaMsg.Icon = MessageDialogIcon.Error;
                gunaMsg.Show();
                return;
            }

            if (!int.TryParse(txtIdCustomer_gift.Text.Trim(), out int customerId))
            {
                gunaMsg.Caption = "Lỗi";
                gunaMsg.Text = "ID khách hàng phải là số.";
                gunaMsg.Icon = MessageDialogIcon.Error;
                gunaMsg.Show();
                return;
            }

            // Gọi BUS → DAO → Proc (trả về 2 result set)
            var (history, points) = giftBus.GetGiftHistoryByCustomer(customerId);

            // Hiển thị lịch sử đổi quà
            dgvGiftHistory.DataSource = history;

            // Hiển thị điểm còn lại
            lblPoint_gift.Text = "Điểm còn lại: " + points;
        }


        private void cbbRoleRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbRoleRate.SelectedItem == null) return;

            string roleSelected = cbbRoleRate.SelectedItem.ToString();

            // Gọi BUS để lấy tỉ lệ từ DB
            string rate = exchangeRateBus.GetRate(roleSelected);

            txtTiLeQuyDoi.Text = rate;
        }

        private void dgvThongTinHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvThongTinHoaDon.CurrentRow != null &&
       dgvThongTinHoaDon.CurrentRow.Cells["InvoiceID"].Value != null)
            {
                txtInvoiceID.Text = dgvThongTinHoaDon.CurrentRow.Cells["InvoiceID"].Value.ToString();
            }
        }

        private void loadInfoManagerAndAcc(int currentId)
        {
            var row = accountBus.GetEmployeeAndAccountById(currentId);

            if (row != null)
            {
                txtFullname_ad.Text = row["FullName"].ToString();
                txtPhone_ad.Text = row["Phone"].ToString();
                txtEmail_ad.Text = row["Email"].ToString();
                txtPosition_ad.Text = row["Position"].ToString();
                cbbGender_ad.Text = row["Gender"].ToString();
                txtAddress_ad.Text = row["Address"].ToString();
                dtpBirthDate_ad.Value = Convert.ToDateTime(row["BirthDate"]);
                dtpHireDate_ad.Value = Convert.ToDateTime(row["HireDate"]);

                txtUsername_ad.Text = row["Username"].ToString();
                txtPassword_ad.Text = row["Password"].ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void loadStatsVip(int currentId)
        {
            var ds = statisticsBus.GetVIPStatistics(currentId);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                DataRow r = ds.Tables[0].Rows[0];

                // Xóa series cũ nếu cólabel1
                chartStatsVip.Series.Clear();
                chartStatsVip.ChartAreas.Clear();

                // Tạo chart area
                ChartArea area = new ChartArea("StatsArea");
                chartStatsVip.ChartAreas.Add(area);

                Series series = new Series("Thống kê VIP");
                series.ChartType = SeriesChartType.Bar;
                series.IsValueShownAsLabel = true;
                series.LabelForeColor = Color.Black;
                series.Font = new Font("Segoe UI", 9, FontStyle.Bold);

                // Tăng độ dày thanh
                series["PointWidth"] = "0.6";

                // Hiển thị label ngoài cột
                series.SmartLabelStyle.Enabled = true;
                series.SmartLabelStyle.MovingDirection = LabelAlignmentStyles.Right;

                // Thêm dữ liệu
                series.Points.AddXY("Số quà đã đổi", Convert.ToInt32(r["TotalGiftsRedeemed"]));
                series.Points.AddXY("Tổng hóa đơn", Convert.ToInt32(r["TotalInvoices"]));
                series.Points.AddXY("Tổng điểm đã dùng", Convert.ToInt32(r["TotalPointsUsed"]));
                series.Points.AddXY("Tổng điểm tích lũy", Convert.ToInt32(r["TotalPointsEarned"]));
                series.Points.AddXY("Điểm hiện có", Convert.ToInt32(r["CurrentPoints"]));

                // Trục X (giá trị) hiển thị chuẩn
                chartStatsVip.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
                chartStatsVip.ChartAreas[0].AxisX.LabelStyle.Angle = 0;
                chartStatsVip.ChartAreas[0].AxisX.Title = "Giá trị";

                // Trục Y (chỉ số) hiển thị thẳng
                chartStatsVip.ChartAreas[0].AxisY.LabelStyle.Angle = 0;
                chartStatsVip.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                chartStatsVip.ChartAreas[0].AxisY.Title = "Chỉ số";

                // Nếu số liệu chênh lệch quá lớn thì dùng thang log
                // chartStatsVip.ChartAreas[0].AxisX.IsLogarithmic = true;

                chartStatsVip.Series.Add(series);

            }

        }
    }
}
