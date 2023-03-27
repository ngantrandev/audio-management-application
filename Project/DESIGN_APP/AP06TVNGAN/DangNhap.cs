using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP06TVNGAN
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            // Đọc chuỗi kết nối từ tệp cấu hình
            string connectionString = ConfigurationManager.ConnectionStrings["AP06TVNGAN.Properties.Settings.AP06TVNGANConnectionString1"].ConnectionString;

            // Tạo một đối tượng SqlConnectionStringBuilder để phân tích chuỗi kết nối
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connectionString);

            // Điền giá trị vào các trường nhập liệu
            textBox1.Text = builder.DataSource;
            textBox4.Text = builder.UserID;
            textBox2.Text = builder.Password;
            textBox3.Text = builder.InitialCatalog;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // Lấy giá trị từ các trường nhập liệu
            string serverName = textBox1.Text;
            string databaseName = textBox3.Text;
            string userName = textBox4.Text;
            string password = textBox2.Text;

            // Tạo chuỗi kết nối mới
            string newConnectionString = $"Data Source={serverName};Initial Catalog={databaseName};Persist Security Info=True;User ID={userName};Password={password}";

            // Thực hiện kết nối thử nghiệm đến cơ sở dữ liệu
            try
            {
                label7.Text = "Đang đăng nhập";
                using (SqlConnection connection = new SqlConnection(newConnectionString))
                {
                    connection.Open();

                    // Thay đổi thông tin chuỗi kết nối trong tệp cấu hình
                    config.ConnectionStrings.ConnectionStrings["AP06TVNGAN.Properties.Settings.AP06TVNGANConnectionString1"].ConnectionString = newConnectionString;
                    config.Save(ConfigurationSaveMode.Modified, true);
                    ConfigurationManager.RefreshSection("connectionStrings");
                    label7.Text = "Đăng nhập thành công!";
                    //this.Close();
                    this.Visible= false;
                }

                // mở form main
                try
                {
                    FormMain06 obj = new FormMain06();
                    obj.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi khi mo form");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối đến server. Vui lòng kiểm tra lại thông tin đăng nhập.");
                label7.Text = "Sai thông tin";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar= '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
