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
    public partial class Dashboard : Form 
    {
        [DllImport("Gdi32.dll",EntryPoint ="CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRect
        (
            int nLeft,
            int nTop,
            int nRight,
            int nBotton,
            int nWidthEllipse,
            int nHeighEllipse
        );
        public Dashboard()
        {
            InitializeComponent();

            this.Region = Region.FromHrgn(CreateRoundRect(0, 0, this.Width, this.Height, 30, 30));
            panel2.Region = Region.FromHrgn(CreateRoundRect(0, 0, panel2.Width, panel2.Height, 30, 30));
            btn_place_order.Region = Region.FromHrgn(CreateRoundRect(0, 0, btn_place_order.Width+5, btn_place_order.Height, 30, 30));
            btn_add_item.Region = Region.FromHrgn(CreateRoundRect(0, 0, btn_add_item.Width+5, btn_add_item.Height, 30, 30));
            btn_item_update.Region = Region.FromHrgn(CreateRoundRect(0, 0, btn_item_update.Width+5, btn_item_update.Height, 30, 30));
            btn_remove_item.Region =  Region.FromHrgn(CreateRoundRect(0, 0, btn_remove_item.Width+5, btn_remove_item.Height, 30, 30));
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do u want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_place_order_MouseHover(object sender, EventArgs e)
        {
            btn_place_order.ForeColor = System.Drawing.Color.White;
            btn_place_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(230)))));
        }

        private void btn_add_item_MouseHover(object sender, EventArgs e)
        {
            btn_add_item.ForeColor = System.Drawing.Color.White;
            btn_add_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(230)))));
        }

        private void btn_update_item_MouseHover(object sender, EventArgs e)
        {
            btn_item_update.ForeColor = System.Drawing.Color.White;
            btn_item_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(230)))));
        }

        private void btn_remove_item_MouseHover(object sender, EventArgs e)
        {
            btn_remove_item.ForeColor = System.Drawing.Color.White;
            btn_remove_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(230)))));
        }

        private void lbl_log_out_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Do u want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Login_page lp = new Login_page();
                lp.Show();
            }
        }
        
        private void btn_place_order_Click(object sender, EventArgs e)
        {
            btn_place_order.BackColor = System.Drawing.Color.White;
            btn_place_order.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));

            btn_add_item.ForeColor = System.Drawing.Color.White;
            btn_add_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));

            btn_item_update.ForeColor = System.Drawing.Color.White;
            btn_item_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));

            btn_remove_item.ForeColor = System.Drawing.Color.White;
            btn_remove_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));

            panel2.Controls.Clear();
            Place_order po = new Place_order() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel2.Controls.Add(po);
            po.Show();
        }

        private void btn_add_item_Click(object sender, EventArgs e)
        {
            btn_add_item.BackColor = System.Drawing.Color.White;
            btn_add_item.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));

            btn_place_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            btn_place_order.ForeColor = System.Drawing.Color.White;

            btn_item_update.ForeColor = System.Drawing.Color.White;
            btn_item_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));

            btn_remove_item.ForeColor = System.Drawing.Color.White;
            btn_remove_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));

            panel2.Controls.Clear();

            Add_item ai = new Add_item() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel2.Controls.Add(ai);
            ai.Show();
        }

        private void btn_update_item_Click(object sender, EventArgs e)
        {
            btn_item_update.BackColor = System.Drawing.Color.White;
            btn_item_update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));

            btn_place_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            btn_place_order.ForeColor = System.Drawing.Color.White;

            btn_add_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            btn_add_item.ForeColor = System.Drawing.Color.White;

            btn_remove_item.ForeColor = System.Drawing.Color.White;
            btn_remove_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));

            panel2.Controls.Clear();

            Update_item ui = new Update_item() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel2.Controls.Add(ui);
            ui.Show();

        }

        private void btn_remove_item_Click(object sender, EventArgs e)
        {
            btn_remove_item.BackColor = System.Drawing.Color.White;
            btn_remove_item.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));

            btn_place_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            btn_place_order.ForeColor = System.Drawing.Color.White;

            btn_add_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            btn_add_item.ForeColor = System.Drawing.Color.White;

            btn_item_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            btn_item_update.ForeColor = System.Drawing.Color.White;

            panel2.Controls.Clear();

            Remove_item ri = new Remove_item() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true } ;
            panel2.Controls.Add(ri);
            ri.Show();
        }
    }
}
