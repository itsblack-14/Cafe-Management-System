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
    public partial class Add_item : Form
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
        public Add_item()
        {
            InitializeComponent();

            btn_add.Region = Region.FromHrgn(CreateRoundRect(0, 0, btn_add.Width, btn_add.Height, 30, 30));

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string category = cb_catagory.Text;
            string item_name = item_name_txt.Text;
            double price = double.Parse(price_txt.Text);

            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = "server=localhost;uid=root;pwd=;database=cafe;port=3307";
                conn.Open();

                string query = "insert into item(item_name,category,price) values('" + item_name + "','" + category + "','" + price + "')";
                /*MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();*/

                MySqlDataAdapter da = new MySqlDataAdapter();
                da.InsertCommand = new MySqlCommand(query, conn);
                da.InsertCommand.ExecuteNonQuery();

                MessageBox.Show("Item Added Successfully", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cb_catagory.Text = "";
                item_name_txt.Clear();
                price_txt.Clear();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Item can't be added", "Add Item", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
