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
    public partial class Student_List_Form : Form
    {
        Student student = new Student();
        public Student_List_Form()
        {
            InitializeComponent();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `students`");
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn piccol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(cmd);
            // colum 7, 7 je index u zablici za slike
            piccol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            piccol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;

        }

        private void dataGridView1_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
        private void studentsListForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
