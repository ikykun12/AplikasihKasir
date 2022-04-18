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
    public partial class Lupa_Pass : Form
    {
        public Lupa_Pass()
        {
            InitializeComponent();
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            if (Txt_User_Name.Text == "")
            {
                MessageBox.Show("Masukkan Username");

            }
            else
            {
                SqlConnection con = Connection.GetConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Login WHERE  UserID = @Id ");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@Id", Txt_User_Name.Text);
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                if(rd.HasRows)
                {
                    MessageBox.Show("Username        = " + rd["UserId"] + "\nPassword         = " + rd["Password"]);
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Username tidak di temukan");
                }
            }
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Hide();
            var a = new Login();
            a.Closed += (s, args) => this.Close();
            a.Show();
            
        }
    }
}
