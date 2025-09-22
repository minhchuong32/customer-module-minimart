using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MiniMart.GUI
{
    public partial class LoginForm : Form
    {
        public static string ConnectionString = "";
        public static string CurrentRole = "";
        public static int currentId = -1; // -1 mặc định chưa đăng nhập

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text.Trim();
            string username = txtUsername.Text.Trim();

            // Kết nối tới DB bằng account kỹ thuật có quyền chạy SP
            string baseConnStr = @"Data Source=MINH-CHUONG;Initial Catalog=MiniMartDB;
                                   Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(baseConnStr))
            using (SqlCommand cmd = new SqlCommand("usp_CheckLogin", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Login", username);
                cmd.Parameters.AddWithValue("@Password", password);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Sai thông tin đăng nhập!");
                    return;
                }

                // Lấy role
                string role = dt.Rows[0]["Role"].ToString();

                if (role == "Manager") // Admin/Manager
                {
                    ConnectionString = @"Data Source=MINH-CHUONG;Initial Catalog=MiniMartDB;
                         User ID=manager_login;Password=Manager@123;TrustServerCertificate=True";
                    CurrentRole = "Manager";
                    int accountId = Convert.ToInt32(dt.Rows[0]["EmployeeID"]);
                    currentId = accountId;
                }
                else if (role == "Normal" || role == "VIP") // Customer
                {
                    int customerId = Convert.ToInt32(dt.Rows[0]["CustomerID"]);
                    currentId = customerId;

                    if (role == "Normal")
                    {
                        ConnectionString = @"Data Source=MINH-CHUONG;Initial Catalog=MiniMartDB;
                                             User ID=normal_login;Password=Normal@123;TrustServerCertificate=True";
                        CurrentRole = "Normal";
                    }
                    else
                    {
                        ConnectionString = @"Data Source=MINH-CHUONG;Initial Catalog=MiniMartDB;
                                             User ID=vip_login;Password=Vip@123;TrustServerCertificate=True";
                        CurrentRole = "VIP";
                    }
                }
            }

            // Nếu tới đây nghĩa là login thành công → mở Form1
            Form1 f = new Form1(ConnectionString, CurrentRole, currentId);
            f.Show();
            this.Hide();
        }
    }
}
