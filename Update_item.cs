using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Cafe_management_system
{
    public partial class Update_item : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRect
        (
            int nLeft,
            int nTop,
            int nRight,
            int nBotton,
            int nWidthEllipse,
            int nHeighEllipse
        );
        public Update_item()
        {
            InitializeComponent();

            btn_update.Region = Region.FromHrgn(CreateRoundRect(0, 0, btn_update.Width, btn_update.Height, 30, 30));
            btn_refresh.Region = Region.FromHrgn(CreateRoundRect(0, 0, btn_refresh.Width, btn_refresh.Height, 30, 30));
        }

        private void search_name_txt_TextChanged(object sender, EventArgs e)
        {
            string name = search_name_txt.Text;

            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost;uid=root;pwd=;database=cafe;port=3307";
            conn.Open();

            string query = "select * from item where item_name like '%" + name + "%'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            update_dataGridView.DataSource = dt.DefaultView;
            conn.Close();
        }

        private void Update_item_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost;uid=root;pwd=;database=cafe;port=3307";
            conn.Open();

            string query = "select * from item";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            update_dataGridView.DataSource = dt.DefaultView;
            conn.Close();
        }

        int item_id;
        private void update_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (update_dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    item_id = int.Parse(update_dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                }

                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = "server=localhost;uid=root;pwd=;database=cafe;port=3307";
                conn.Open();

                string query = "select * from item where id='" + item_id + "'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                show_name_txt.Text = dt.Rows[0][1].ToString();
                cb_catagory.Text = dt.Rows[0][2].ToString();
                price_txt.Text = dt.Rows[0][3].ToString();
                conn.Close();
            }
            catch
            {

            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string category = cb_catagory.Text;
            string item_name = show_name_txt.Text;
            double price = double.Parse(price_txt.Text);

            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = "server=localhost;uid=root;pwd=;database=cafe;port=3307";
                conn.Open();

                string query = "update item set item_name='" + item_name + "',category='" + category + "',price='" + price + "' where id='"+item_id+"'";
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.UpdateCommand = new MySqlCommand(query, conn);
                da.UpdateCommand.ExecuteNonQuery();
                MessageBox.Show("Item Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();

                cb_catagory.Text = "";
                show_name_txt.Clear();
                price_txt.Clear();
            }
            catch
            {
                MessageBox.Show("Item Update Failed", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            search_name_txt.Clear();
            cb_catagory.Text = "";
            show_name_txt.Clear();
            price_txt.Clear();
            update_dataGridView.Refresh();
        }
    }
}