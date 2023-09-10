using Org.BouncyCastle.Crypto.Agreement.JPake;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager
{
    public partial class Add_Student_Form : Form
    {
        public Add_Student_Form()
        {
            InitializeComponent();
        }

        private void lbBirth_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddPict_Click(object sender, EventArgs e)
        {
            //slika
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Select Image(*.jpg; *.png;*.gif)|*.jpg; *.png;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            string fname = textBox1.Text;
            string lname = textBox2.Text;
            DateTime bdate = dateTimePicker1.Value;
            string phone =textBox3.Text;
            string adrress=textBox4.Text;
            string gender = "Male";
            if(rbFemale.Checked)
            {
                gender = "Female";
            }
            MemoryStream img=new MemoryStream();

            if (provijeri())
            {
                //provjeriti starost studenta
                 
                if (student.InsertStudent(fname, lname, bdate, phone, gender, adrress, img))
                {
                    MessageBox.Show("New student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Error", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Emtpy Fields", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        bool provijeri()
        {
                if((textBox1.Text.Trim()=="")||
                    (textBox2.Text.Trim()=="")||
                    (textBox3.Text.Trim()=="")||
                    (textBox4.Text.Trim()=="")||
                    (pictureBox1.Image == null))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
