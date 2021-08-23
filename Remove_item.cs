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
    public partial class Remove_item : Form
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
        public Remove_item()
        {
            InitializeComponent();

            btn_remove.Region = Region.FromHrgn(CreateRoundRect(0, 0, btn_remove.Width, btn_remove.Height, 30, 30));
        }

        private void Remove_item_Load(object sender, EventArgs e)
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

            remove_dataGridView.DataSource = dt.DefaultView;
            conn.Close();
        }

        private void item_name_txt_TextChanged(object sender, EventArgs e)
        {
            string item_name = item_name_txt.Text;
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost;uid=root;pwd=;database=cafe;port=3307";
            conn.Open();

            string query = "select * from item where item_name like '%"+item_name+"%'";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            remove_dataGridView.DataSource = dt.DefaultView;
            conn.Close();

        }
        int item_id;
        private void remove_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (remove_dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    item_id = int.Parse(remove_dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
            }
            catch
            {
                MessageBox.Show("Cant get row id","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
           try
           {
                if(MessageBox.Show("Are u sure u want to remove this item?","Remove",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    MySqlConnection conn = new MySqlConnection();
                    conn.ConnectionString = "server=localhost;uid=root;pwd=;database=cafe;port=3307";
                    conn.Open();

                    string query = "delete from item where id='" + item_id + "'";

                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.DeleteCommand = new MySqlCommand(query, conn);
                    da.DeleteCommand.ExecuteNonQuery();

                    MessageBox.Show("Item Removed Successfully", "Remove", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    conn.Close();
                }
                
           }
            catch
            {

            }
        }
    }
}
