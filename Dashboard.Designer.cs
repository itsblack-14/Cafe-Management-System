
namespace Cafe_management_system
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exit_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_log_out = new System.Windows.Forms.LinkLabel();
            this.btn_add_item = new System.Windows.Forms.Button();
            this.btn_item_update = new System.Windows.Forms.Button();
            this.btn_remove_item = new System.Windows.Forms.Button();
            this.btn_place_order = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.exit_btn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.ForeColor = System.Drawing.Color.Black;
            this.exit_btn.Location = new System.Drawing.Point(3, 3);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(23, 24);
            this.exit_btn.TabIndex = 14;
            this.exit_btn.Text = "X";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_log_out);
            this.panel1.Controls.Add(this.btn_add_item);
            this.panel1.Controls.Add(this.btn_item_update);
            this.panel1.Controls.Add(this.btn_remove_item);
            this.panel1.Controls.Add(this.btn_place_order);
            this.panel1.Controls.Add(this.exit_btn);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 596);
            this.panel1.TabIndex = 15;
            // 
            // lbl_log_out
            // 
            this.lbl_log_out.ActiveLinkColor = System.Drawing.Color.Lime;
            this.lbl_log_out.AutoSize = true;
            this.lbl_log_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_log_out.LinkColor = System.Drawing.Color.White;
            this.lbl_log_out.Location = new System.Drawing.Point(59, 563);
            this.lbl_log_out.Name = "lbl_log_out";
            this.lbl_log_out.Size = new System.Drawing.Size(60, 20);
            this.lbl_log_out.TabIndex = 19;
            this.lbl_log_out.TabStop = true;
            this.lbl_log_out.Text = "Logout";
            this.lbl_log_out.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_log_out_LinkClicked);
            // 
            // btn_add_item
            // 
            this.btn_add_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            this.btn_add_item.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_add_item.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            this.btn_add_item.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_item.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_item.ForeColor = System.Drawing.Color.White;
            this.btn_add_item.Location = new System.Drawing.Point(0, 102);
            this.btn_add_item.Name = "btn_add_item";
            this.btn_add_item.Size = new System.Drawing.Size(207, 51);
            this.btn_add_item.TabIndex = 18;
            this.btn_add_item.Text = "Add Item";
            this.btn_add_item.UseVisualStyleBackColor = false;
            this.btn_add_item.Click += new System.EventHandler(this.btn_add_item_Click);
            this.btn_add_item.MouseHover += new System.EventHandler(this.btn_add_item_MouseHover);
            // 
            // btn_item_update
            // 
            this.btn_item_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            this.btn_item_update.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_item_update.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            this.btn_item_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_item_update.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_item_update.ForeColor = System.Drawing.Color.White;
            this.btn_item_update.Location = new System.Drawing.Point(0, 159);
            this.btn_item_update.Name = "btn_item_update";
            this.btn_item_update.Size = new System.Drawing.Size(207, 51);
            this.btn_item_update.TabIndex = 17;
            this.btn_item_update.Text = "Update Item";
            this.btn_item_update.UseVisualStyleBackColor = false;
            this.btn_item_update.Click += new System.EventHandler(this.btn_update_item_Click);
            this.btn_item_update.MouseHover += new System.EventHandler(this.btn_update_item_MouseHover);
            // 
            // btn_remove_item
            // 
            this.btn_remove_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            this.btn_remove_item.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_remove_item.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            this.btn_remove_item.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove_item.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove_item.ForeColor = System.Drawing.Color.White;
            this.btn_remove_item.Location = new System.Drawing.Point(0, 216);
            this.btn_remove_item.Name = "btn_remove_item";
            this.btn_remove_item.Size = new System.Drawing.Size(207, 51);
            this.btn_remove_item.TabIndex = 16;
            this.btn_remove_item.Text = "Remove Item";
            this.btn_remove_item.UseVisualStyleBackColor = false;
            this.btn_remove_item.Click += new System.EventHandler(this.btn_remove_item_Click);
            this.btn_remove_item.MouseHover += new System.EventHandler(this.btn_remove_item_MouseHover);
            // 
            // btn_place_order
            // 
            this.btn_place_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            this.btn_place_order.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_place_order.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            this.btn_place_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_place_order.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_place_order.ForeColor = System.Drawing.Color.White;
            this.btn_place_order.Location = new System.Drawing.Point(0, 45);
            this.btn_place_order.Name = "btn_place_order";
            this.btn_place_order.Size = new System.Drawing.Size(207, 51);
            this.btn_place_order.TabIndex = 15;
            this.btn_place_order.Text = "Place Order";
            this.btn_place_order.UseVisualStyleBackColor = false;
            this.btn_place_order.Click += new System.EventHandler(this.btn_place_order_Click);
            this.btn_place_order.MouseHover += new System.EventHandler(this.btn_place_order_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(211, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1019, 596);
            this.panel2.TabIndex = 16;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1242, 620);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_place_order;
        private System.Windows.Forms.Button btn_add_item;
        private System.Windows.Forms.Button btn_item_update;
        private System.Windows.Forms.Button btn_remove_item;
        private System.Windows.Forms.LinkLabel lbl_log_out;
    }
}