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

namespace Heroe
{
    public partial class Register : MetroFramework.Forms.MetroForm
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConfirmPass.Text)
            {
                MessageBox.Show("Please make sure your password are same!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtFirstName.Text == null || txtUsername.Text == null || txtPassword.Text == null)
                {
                    MessageBox.Show("Please enter all needed rows!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\sdfko\Userinfo.mdf"";Integrated Security=True");
                    SqlDataAdapter sda = new SqlDataAdapter("Select * From UserInfo where Username='" + txtUsername.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        MessageBox.Show("This username is already exsisting! Please enter another username. ", "Username already exsisting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\sdfko\Userinfo.mdf"";Integrated Security=True");
                        con1.Open();
                        string s = "0";
                        SqlCommand sda1 = new SqlCommand("INSERT INTO UserInfo(Username,First_Name,Last_Name,Password) VALUES ('" + txtUsername.Text + "','" + txtFirstName.Text + "','" + txtLastName.Text + "','" + txtPassword.Text + "')", con1);
                        sda1.ExecuteNonQuery();
                        MessageBox.Show("Sucseflull registration!", "Sucsesfull registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //this.Close();
                        //LoginForm login = new LoginForm();
                        //login.Show();
                    }
                }
            }
        }
    }
}
