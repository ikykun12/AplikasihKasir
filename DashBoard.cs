using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatihanKasir
{
    public partial class DashBoard : Form
    {
        
        
        public DashBoard(string user)
        {
            
            InitializeComponent();
            if (user == "Admin")
            {
                Btn_Edit_Barang.Show();
                Btn_Hapus_Barang.Show();
                Btn_Tambah_Barang.Show();
                Btn_EditUser.Show();
                

            }
            else
            {
                Btn_Edit_Barang.Hide();
                Btn_Hapus_Barang.Hide();
                Btn_Tambah_Barang.Hide();
                Btn_EditUser.Hide();

            }
        }
        private void Btn_Keluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            hapus1.Visible = false;
            pembayarann1.Visible = false;
            addItems1.Visible = false;
            editBarang1.Visible = false;
            editUser1.Visible = false;
            
        }

        private void Btn_Pembayaran_Click(object sender, EventArgs e)
        {
            pembayarann1.Visible = true;
            pembayarann1.BringToFront();
        }

        private void Btn_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var a = new Login();
            a.Closed+=(s,args)=>this.Close();
            a.Show();
        }

        private void Btn_Tambah_Barang_Click(object sender, EventArgs e)
        {
            addItems1.Visible = true;
            addItems1.BringToFront();
        }

        private void Btn_Edit_Barang_Click(object sender, EventArgs e)
        {
            editBarang1.Visible = true;
            editBarang1.BringToFront();
        }

        private void Btn_Hapus_Barang_Click(object sender, EventArgs e)
        {
            hapus1.Visible = true;
            hapus1.BringToFront();
        }

        private void Btn_EditUser_Click(object sender, EventArgs e)
        {
            editUser1.Visible = true;
            editUser1.BringToFront();
        }
    }
}
