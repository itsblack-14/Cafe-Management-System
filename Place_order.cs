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
    public partial class Place_order : Form
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
        
        public Place_order()
        {
            InitializeComponent();
            btn_add_to_cart.Region = Region.FromHrgn(CreateRoundRect(0, 0, btn_add_to_cart.Width, btn_add_to_cart.Height, 30, 30));
            btn_refresh.Region = Region.FromHrgn(CreateRoundRect(0, 0, btn_refresh.Width, btn_refresh.Height, 30, 30));
            btn_print.Region = Region.FromHrgn(CreateRoundRect(0, 0, btn_print.Width, btn_print.Height, 30, 30));
        }
        MySqlConnection conn;
        public void connection()
        {
            conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost;uid=root;pwd=;database=cafe;port=3307";
            conn.Open();
        }

        private void cb_catagory_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            string category = cb_catagory.Text;
            try
            {
                connection();

                string query = "select item_name from item where category='" + category + "' order by id desc";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string item_name = reader.GetString("item_name");
                    listBox.Items.Add(item_name);
                }
                conn.Close();
            }
            catch(Exception m)
            {
                MessageBox.Show(m.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = listBox.Text;
            numericUpDown1.Value = 1;
            try
            {
                connection();

                string query = "select price from item where item_name='" + item + "'";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                price_txt.Text = reader.GetString("price");
                item_name_txt.Text = item;
                int j = int.Parse(price_txt.Text);
                total_txt.Text = j.ToString();
            }
            catch(Exception m)
            {
                MessageBox.Show(m.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                int j = int.Parse(price_txt.Text);
                int i = int.Parse(numericUpDown1.Value.ToString()) * j;

                total_txt.Text = i.ToString();
            }
            catch 
            {
                
            }
        }
        int i;
        private void btn_add_to_cart_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            dataGridView1.Rows[i].Cells[0].Value = item_name_txt.Text;
            dataGridView1.Rows[i].Cells[1].Value = price_txt.Text;
            dataGridView1.Rows[i].Cells[2].Value = numericUpDown1.Value;
            dataGridView1.Rows[i].Cells[3].Value = total_txt.Text;
            
            i++;
            //grand_total_txt.Text = total_txt.Text;
            int pz = int.Parse(total_txt.Text) + int.Parse(grand_total_txt.Text.ToString());
            grand_total_txt.Text = pz.ToString(); 
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            grand_total_txt.Clear();
            item_name_txt.Clear();
            price_txt.Clear();
            total_txt.Clear();
            numericUpDown1.Value = 1;
        }
    }
}
