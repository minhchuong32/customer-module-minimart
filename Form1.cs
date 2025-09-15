using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MiniMart
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        //helper
        private void LoadCustomers(string keyword)
        {
            DataTable dt = MiniMart.Db.ExecDataTable("dbo.usp_Customer_Search",
                delegate (SqlParameterCollection p)
                {
                    p.AddWithValue("@Keyword", keyword == null ? "" : keyword);
                }, false);
            dgvCustomers.DataSource = dt;
        }

        private int? GetSelectedCustomerId()
        {
            if (dgvCustomers.CurrentRow == null) return null;
            object v = dgvCustomers.CurrentRow.Cells["CustomerID"].Value;
            if (v == null || v == DBNull.Value) return null;
            return Convert.ToInt32(v);
        }

        // (chỉ dùng cho nút tải lịch sử giao dịch)
        private string GetNormalCs()
        {
            return @"Data Source=MINH-CHUONG;Initial Catalog=MiniMartDB;User ID=normal_login;Password=Normal@123;TrustServerCertificate=True";
        }



        //Tab KHÁCH HÀNG
        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadCustomers(txtSearch.Text.Trim());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên.");
                return;
            }

            object newId = MiniMart.Db.ExecScalar("dbo.usp_Customer_Insert",
                delegate (SqlParameterCollection p)
                {
                    p.AddWithValue("@FullName", txtFullName.Text.Trim());
                    p.AddWithValue("@Phone", txtPhone.Text.Trim());
                    p.AddWithValue("@Email", txtEmail.Text.Trim());
                    p.AddWithValue("@Address", txtAddress.Text.Trim());
                    p.AddWithValue("@Gender", cboGender.Text);
                    p.AddWithValue("@BirthDate", dtpBirthDate.Value.Date);
                    p.AddWithValue("@Status", cboStatus.Text);
                }, false);

            MessageBox.Show("Đã thêm KH. ID = " + newId);
            LoadCustomers(txtSearch.Text.Trim());

            if (newId != null)
            {
                // tiện điền sẵn qua các tab khác
                string s = newId.ToString();
                txtCustomerID_Acc.Text = s;
                txtCustomerID_Inv.Text = s;

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int? id = GetSelectedCustomerId();
            if (id == null)
            {
                MessageBox.Show("Chưa chọn khách hàng.");
                return;
            }

            MiniMart.Db.ExecNonQuery("dbo.usp_Customer_Update",
                delegate (SqlParameterCollection p)
                {
                    p.AddWithValue("@CustomerID", id.Value);
                    p.AddWithValue("@FullName", txtFullName.Text.Trim());
                    p.AddWithValue("@Phone", txtPhone.Text.Trim());
                    p.AddWithValue("@Email", txtEmail.Text.Trim());
                    p.AddWithValue("@Address", txtAddress.Text.Trim());
                    p.AddWithValue("@Gender", cboGender.Text);
                    p.AddWithValue("@BirthDate", dtpBirthDate.Value.Date);
                    p.AddWithValue("@Status", cboStatus.Text);
                }, false);

            MessageBox.Show("Đã cập nhật.");
            LoadCustomers(txtSearch.Text.Trim());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int? id = GetSelectedCustomerId();
            if (id == null)
            {
                MessageBox.Show("Chưa chọn khách hàng.");
                return;
            }

            DialogResult dr = MessageBox.Show("Xoá khách hàng đang chọn?", "Xác nhận",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr != DialogResult.Yes) return;

            MiniMart.Db.ExecNonQuery("dbo.usp_Customer_Delete",
                delegate (SqlParameterCollection p)
                {
                    p.AddWithValue("@CustomerID", id.Value);
                }, false);

            MessageBox.Show("Đã xoá.");
            LoadCustomers(txtSearch.Text.Trim());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFullName.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            cboGender.SelectedIndex = 0;
            cboStatus.SelectedIndex = 0;
            dtpBirthDate.Value = DateTime.Today;
        }

        private void dgvCustomers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow == null) return;
            DataGridViewRow r = dgvCustomers.CurrentRow;

            txtFullName.Text = Convert.ToString(r.Cells["FullName"].Value);
            txtPhone.Text = Convert.ToString(r.Cells["Phone"].Value);
            txtEmail.Text = Convert.ToString(r.Cells["Email"].Value);
            txtAddress.Text = Convert.ToString(r.Cells["Address"].Value);

            object g = r.Cells["Gender"].Value; if (g != null) cboGender.Text = Convert.ToString(g);
            object s = r.Cells["Status"].Value; if (s != null) cboStatus.Text = Convert.ToString(s);

            object bd = r.Cells["BirthDate"].Value;
            DateTime d;
            if (bd != null && DateTime.TryParse(Convert.ToString(bd), out d)) dtpBirthDate.Value = d;

            object cid = r.Cells["CustomerID"].Value;
            if (cid != null && cid != DBNull.Value)
            {
                string v = cid.ToString();
                txtCustomerID_Acc.Text = v;
                txtCustomerID_Inv.Text = v;

            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        //Tab TÀI KHOẢN
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            int customerId;
            if (!int.TryParse(txtCustomerID_Acc.Text.Trim(), out customerId))
            {
                MessageBox.Show("CustomerID không hợp lệ.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Nhập Username/Password.");
                return;
            }

            object accId = MiniMart.Db.ExecScalar("dbo.usp_Account_Create",
                delegate (SqlParameterCollection p)
                {
                    p.AddWithValue("@CustomerID", customerId);
                    p.AddWithValue("@Username", txtUsername.Text.Trim());
                    p.AddWithValue("@Password", txtPassword.Text.Trim());
                    p.AddWithValue("@MemberLevel", cboMemberLevel.Text);
                }, false);

            MessageBox.Show("Đã tạo tài khoản. ID = " + accId);
        }

        private void btnViewAccount_Click(object sender, EventArgs e)
        {
            int customerId;
            if (!int.TryParse(txtCustomerID_Acc.Text.Trim(), out customerId))
            {
                MessageBox.Show("CustomerID không hợp lệ.");
                return;
            }

            DataTable dt = MiniMart.Db.ExecDataTable("dbo.usp_Account_GetByCustomer",
                delegate (SqlParameterCollection p)
                {
                    p.AddWithValue("@CustomerID", customerId);
                }, false);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có tài khoản cho khách này.");
                lblPoints.Text = "Điểm hiện có: -";
                return;
            }

            DataRow r = dt.Rows[0];
            txtUsername.Text = Convert.ToString(r["Username"]);
            cboMemberLevel.Text = Convert.ToString(r["MemberLevel"]);
            txtPassword.Text = Convert.ToString(r["Password"]);
            lblPoints.Text = "Điểm hiện có: " + Convert.ToString(r["Points"]);

        }


        //Tab HÓA ĐƠN & ĐIỂM
        private void btnCreateInvoiceEarn_Click(object sender, EventArgs e)
        {
            int customerId, employeeId;
            decimal total;

            if (!int.TryParse(txtCustomerID_Inv.Text.Trim(), out customerId))
            {
                MessageBox.Show("CustomerID không hợp lệ."); return;
            }
            if (!int.TryParse(txtEmployeeID.Text.Trim(), out employeeId))
            {
                MessageBox.Show("EmployeeID không hợp lệ."); return;
            }
            if (!decimal.TryParse(txtTotalAmount.Text.Trim(), out total))
            {
                MessageBox.Show("TotalAmount không hợp lệ."); return;
            }

            DataTable dt = MiniMart.Db.ExecDataTable("dbo.usp_Invoice_AddAndEarnPoints",
                delegate (SqlParameterCollection p)
                {
                    p.AddWithValue("@CustomerID", customerId);
                    p.AddWithValue("@EmployeeID", employeeId);
                    p.AddWithValue("@InvoiceDate", dtpInvoiceDate.Value.Date);
                    p.AddWithValue("@TotalAmount", total);
                    p.AddWithValue("@Status", cboInvoiceStatus.Text);
                }, false);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Tạo hoá đơn #" + dt.Rows[0]["InvoiceID"] +
                                " – Earn " + dt.Rows[0]["PointsEarned"] + " điểm");
            }
            else
            {
                MessageBox.Show("Không nhận được kết quả từ thủ tục.");
            }
        }


        private void btnLoadTrans_Click(object sender, EventArgs e)
        {
            int cid;
            if (!int.TryParse(txtCustomerID_Inv.Text.Trim(), out cid))
            {
                MessageBox.Show("Nhập CustomerID ở mục hóa đơn trước.");
                return;
            }

            try
            {
                DataTable dt = MiniMart.Db.ExecDataTable("dbo.usp_LoyaltyHistory_Get",
                    delegate (SqlParameterCollection p)
                    {
                        p.AddWithValue("@CustomerID", cid);
                        p.AddWithValue("@StartDate", DBNull.Value);
                        p.AddWithValue("@EndDate", DBNull.Value);
                        p.AddWithValue("@InvoiceID", DBNull.Value);
                    },
                    false  // dùng user normal
                );

                dgvTrans.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải lịch sử: " + ex.Message);
            }
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            // Bật = hiện; Tắt = ẩn
            txtPassword.UseSystemPasswordChar = !guna2ToggleShowPass.Checked;
            if (guna2ToggleShowPass.Checked)
                txtPassword.PasswordChar = '\0';
            else
                txtPassword.PasswordChar = '•';
        }
    }
}
