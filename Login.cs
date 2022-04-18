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
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            this.Hide();
            var a = new Register();
            a.Closed += (s, args) => this.Close();
            a.Show();
        }

        private void Label_Lupaspass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var a = new Lupa_Pass();
            a.Closed += (s, args) => this.Close();
            a.Show();

        }
        private void Btn_Login_Click_1(object sender, EventArgs e)
        {

            SqlConnection con = Connection.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Login where UserID ='" + Txt_User_Name.Text + "'and Password='" + Txt_Password.Text + "'",con);
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {

                if(Txt_User_Name.Text=="Arasan"&&Txt_Password.Text=="San")
                {
                    this.Hide();
                    var b = new DashBoard("Admin");
                    b.Closed += (s, args) => this.Close();
                    b.Show();
                    con.Close();
                }
                else
                {
                    this.Hide();
                    var a = new DashBoard("Others");
                    a.Closed += (s, args) => this.Close();
                    a.Show();
                    con.Close();
                }
                  
            }
            else
            {
                MessageBox.Show("Username atau password anda salah");
            }
        }
   
    }
}
