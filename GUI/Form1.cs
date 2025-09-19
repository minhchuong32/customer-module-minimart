using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MiniMart.BUS;

namespace MiniMart.GUI
{
    public partial class Form1 : Form
    {
        private CustomerBUS customerBus;
        private AccountBUS accountBus;
        private InvoiceBUS invoiceBus;
        private GiftBUS giftBus;

        private bool isVipMode = false;

        public Form1()
        {
            InitializeComponent();

            string connStr = GetConnectionString();
            customerBus = new CustomerBUS(connStr);
            accountBus = new AccountBUS(connStr);
            invoiceBus = new InvoiceBUS(connStr);
            giftBus = new GiftBUS(connStr);
        }

        // Lấy chuỗi kết nối dựa trên quyền
        private string GetConnectionString()
        {
            if (isVipMode)
            {
                txtTiLeQuyDoi.Text = "1:5"; // VIP
                return @"Data Source=MINH-CHUONG;Initial Catalog=MiniMartDB;
                         User ID=vip_login;Password=Vip@123;TrustServerCertificate=True";
            }
            else
            {
                txtTiLeQuyDoi.Text = "1:2"; // Normal
                return @"Data Source=MINH-CHUONG;Initial Catalog=MiniMartDB;
                         User ID=normal_login;Password=Normal@123;TrustServerCertificate=True";
            }
        }

        // ========================= TAB KHÁCH HÀNG =========================
        private void LoadCustomers(string keyword)
        {
            SqlConnection conn = new SqlConnection(GetConnectionString());
            SqlCommand cmd = new SqlCommand("dbo.usp_Customer_Search", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Keyword", string.IsNullOrEmpty(keyword) ? "" : keyword);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvCustomers.DataSource = dt;
        }
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
            var newId = customerBus.Insert(
                txtFullName.Text.Trim(),
                txtPhone.Text.Trim(),
                txtEmail.Text.Trim(),
                txtAddress.Text.Trim(),
                cboGender.Text,
                dtpBirthDate.Value,
                cboStatus.Text
            );

            MessageBox.Show("Đã thêm KH. ID = " + newId);
            dgvCustomers.DataSource = customerBus.Search(txtSearch.Text.Trim());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvCustomers.CurrentRow.Cells["CustomerID"].Value);

            customerBus.Update(id,
                txtFullName.Text.Trim(),
                txtPhone.Text.Trim(),
                txtEmail.Text.Trim(),
                txtAddress.Text.Trim(),
                cboGender.Text,
                dtpBirthDate.Value,
                cboStatus.Text
            );

            MessageBox.Show("Đã cập nhật KH.");
            dgvCustomers.DataSource = customerBus.Search(txtSearch.Text.Trim());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvCustomers.CurrentRow.Cells["CustomerID"].Value);

            customerBus.Delete(id);

            MessageBox.Show("Đã xóa KH.");
            dgvCustomers.DataSource = customerBus.Search(txtSearch.Text.Trim());
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
            if (toggleSwitchRole.Checked)
            {
                isVipMode = true;
                lblRole.Text = "Quyền hiện tại: VIP";
            }
            else
            {
                isVipMode = false;
                lblRole.Text = "Quyền hiện tại: Normal";
            }

            // Cập nhật thông tin user hiển thị
            UpdateSystemInfo();

            // Load lại danh sách khách hàng
            LoadCustomers(txtSearch.Text.Trim());
        }
        private void UpdateSystemInfo()
        {
            lblServer.Text = "Server: MINH-CHUONG";
            lblDatabase.Text = "Database: MiniMartDB";
            lblUser.Text = "User: " + (isVipMode ? "vip_login" : "normal_login");
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
                lblPoints.Text = "Điểm hiện có: " + pointValue.ToString();
            }
            else
            {
                lblPoints.Text = "Điểm hiện có: -";
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
            txtTiLeQuyDoi.Text = txtTiLeQuyDoi.Text.Trim();
            MessageBox.Show("Đã lưu tỉ lệ quy đổi.");
        }
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            int customerId = int.Parse(txtCustomerID_Acc.Text.Trim());

            var accId = accountBus.Create(customerId,
                txtUsername.Text.Trim(),
                txtPassword.Text.Trim(),
                cboMemberLevel.Text
            );

            MessageBox.Show("Tạo tài khoản thành công. ID = " + accId);
        }

        private void btnViewAccount_Click(object sender, EventArgs e)
        {
            int customerId = int.Parse(txtCustomerID_Acc.Text.Trim());

            DataTable dt = accountBus.GetByCustomer(customerId);

            if (dt.Rows.Count == 0)
            {
                lblPoints.Text = "Điểm hiện có: -";
                MessageBox.Show("Chưa có tài khoản cho khách này.");
                return;
            }

            DataRow row = dt.Rows[0];
            txtUsername.Text = row["Username"].ToString();
            txtPassword.Text = row["Password"].ToString();
            cboMemberLevel.Text = row["MemberLevel"].ToString();
            lblPoints.Text = "Điểm hiện có: " + row["Points"].ToString();
        }

        private void btnUpdateAcc_Click(object sender, EventArgs e)
        {
            int customerId = int.Parse(txtCustomerID_Acc.Text.Trim());

            accountBus.Update(customerId,
                txtUsername.Text.Trim(),
                txtPassword.Text.Trim(),
                cboMemberLevel.Text
            );

            MessageBox.Show("Cập nhật tài khoản thành công.");
        }

        private void btnDelAcc_Click(object sender, EventArgs e)
        {
            int customerId = int.Parse(txtCustomerID_Acc.Text.Trim());

            accountBus.Delete(customerId);

            MessageBox.Show("Đã xóa tài khoản.");
            txtUsername.Clear();
            txtPassword.Clear();
            cboMemberLevel.SelectedIndex = 0;
            lblPoints.Text = "-";
        }

        private void btnLoadAllAccounts_Click(object sender, EventArgs e)
        {
            dgvTaiKhoan.DataSource = accountBus.GetAll();
        }

        // ========================= TAB HÓA ĐƠN =========================

        private void btnTimHoaDon_Click(object sender, EventArgs e)
        {
            int customerId = int.Parse(txtCustomerID_HoaDon.Text.Trim());
            dgvThongTinHoaDon.DataSource = invoiceBus.GetByCustomer(customerId);
        }

        private void btnLoadTrans_Click(object sender, EventArgs e)
        {
            int customerId = int.Parse(txtCustomerID_HoaDon.Text.Trim());
            dgvTrans.DataSource = invoiceBus.GetTransactions(customerId);
        }

        private void btnDoiDiem_Click(object sender, EventArgs e)
        {
            int customerId = int.Parse(txtCustomerID_Acc.Text.Trim());
            var (vnd, point) = ParseRate(txtTiLeQuyDoi.Text);

            dgvTrans.DataSource = invoiceBus.ConvertToPoints(customerId, vnd, point);
            MessageBox.Show("Đã quy đổi điểm.");
        }

        private (int, int) ParseRate(string text)
        {
            string[] parts = text.Split(':');
            if (parts.Length == 2 &&
                int.TryParse(parts[0], out int vnd) &&
                int.TryParse(parts[1], out int point))
            {
                return (vnd, point);
            }
            return (1, 1);
        }

        // ========================= TAB QUÀ TẶNG =========================

        private void btnLoadGiftHistory_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(GetConnectionString());
            SqlCommand cmd = new SqlCommand("dbo.usp_Gift_GetHistoryByCustomer", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CustomerID", txtIdCustomer_gift.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvGiftHistory.DataSource = dt;
        }


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
        }

        private void btnRedeemGift_Click(object sender, EventArgs e)
        {
            int customerId = int.Parse(txtCustomerID_Acc.Text.Trim());
            int giftId = int.Parse(txtGiftID.Text.Trim());

            dgvGiftHistory.DataSource = giftBus.Redeem(customerId, giftId);
            MessageBox.Show("Đổi quà thành công!");
        }

        private void btnAddGift_Click(object sender, EventArgs e)
        {
            giftBus.Insert(txtGiftName.Text.Trim(),
                int.Parse(txtPointsRequired.Text.Trim()),
                chkIsActive.Checked);

            MessageBox.Show("Đã thêm quà.");
            dgvGifts.DataSource = giftBus.GetAll();
        }

        private void btnEditGift_Click(object sender, EventArgs e)
        {
            giftBus.Update(
                int.Parse(txtGiftID.Text.Trim()),
                txtGiftName.Text.Trim(),
                int.Parse(txtPointsRequired.Text.Trim()),
                chkIsActive.Checked
            );

            MessageBox.Show("Đã cập nhật quà.");
            dgvGifts.DataSource = giftBus.GetAll();
        }

        private void btnDeleteGift_Click(object sender, EventArgs e)
        {
            giftBus.Delete(int.Parse(txtGiftID.Text.Trim()));
            MessageBox.Show("Đã xóa quà.");
            dgvGifts.DataSource = giftBus.GetAll();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
