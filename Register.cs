using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LatihanKasir
{
    public partial class Register : Form
    {
        Connection con = new Connection();
        string query, query1;
        public Register()
        {
            InitializeComponent();
        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            if (Txt_Password.Text != Txt_CPassword.Text)
            {
                MessageBox.Show("Password Tidak Sama");
            }
            else
            {
                query = "INSERT INTO Register(Nama_Depan,Nama_Belakang,No_HP,Alamat,Agama,Jenis_Kelamin,Tanggal_lahir) " +
                    "VALUES('" + Txt_NamaD.Text + "','" + Txt_NamaB.Text + "','" + Txt_NOHP.Text + "','" + Txt_Alamat.Text + "'," +
                    "'" + Txt_Agama.Text + "','" + Txt_Kelamin.Text + "','" + Txt_TTL.Text + "')";
                query1 = "INSERT INTO Login (UserID,Password) VALUES ('" + Txt_User_Name.Text + "','" + Txt_Password.Text + "')";
                con.Setdata(query);
                con.Setdata(query1);
                
                Txt_NamaD.Text = "";
                Txt_NamaB.Text = "";
                Txt_NOHP.Text = "";
                Txt_Alamat.Text = "";
                Txt_Agama.SelectedIndex = -1;
                Txt_Kelamin.SelectedIndex = -1;
                Txt_TTL.Text = "";
                Txt_User_Name.Text = "";
                Txt_Password.Text = "";
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            var a = new Login();
            a.Closed += (s, args) => this.Close();
            a.Show();
        }
    }
}
