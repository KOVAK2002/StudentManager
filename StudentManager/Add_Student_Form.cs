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
            ofd.Filter = "Select image(*.jpg; *.png;*.gif)|*.jpg; *.png;*.gif";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                    pictureBox1.Image=Image.FromFile(ofd.FileName); 
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
