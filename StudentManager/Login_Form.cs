using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudentManager
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\KOV1\\source\\repos\\StudentManager\\StudentManager\\Images\\icon.png");
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            MY_DB db=new MY_DB();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            MySqlCommand command =new MySqlCommand("SELECT * FROM `users` WHERE `Username`=@usn AND`Password`=@pass", db.GetConnection);

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = tbUsername.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = tbPassword.Text;

            adapter.SelectCommand=command;
            adapter.Fill(table);
            if(table.Rows.Count >0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Invalid username or password","Login error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
