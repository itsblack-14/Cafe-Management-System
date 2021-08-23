using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Cafe_management_system
{
    public partial class Login_page : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable dt;

        public Login_page()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are u sure u want to exit", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
            
        }

        private void username_txt_MouseClick(object sender, MouseEventArgs e)
        {
            if(username_txt.Text == "Username")
            {
                username_txt.Clear();
            }
        }

        private void password_txt_MouseClick(object sender, MouseEventArgs e)
        {
            if(password_txt.Text == "Password")
            {
                password_txt.Clear();
                password_txt.PasswordChar = '*';
            }
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string username = username_txt.Text;
            string password = password_txt.Text;

            conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost;uid=root;password=;database=cafe;port=3307";
            conn.Open();

            string query = "select * from login_table where user_name='"+username+"' and password='"+password+"'";
            cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            
            if(dt.Rows.Count != 0)
            {
                conn.Close();
                this.Hide();
                Dashboard db = new Dashboard();
                db.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
