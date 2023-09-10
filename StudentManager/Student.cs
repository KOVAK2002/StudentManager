using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace StudentManager
{
    internal class Student
    {
        MY_DB db = new MY_DB();
        public bool InsertStudent(string fname, string lname, DateTime bdate, string phone, string gender, string address, MemoryStream picture)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `students`(`FirstName`, `LastName`, `BirthDate`, `Gender`, `Phone`, `Address`, `Image`) VALUES (@fn,@ln,@bd,@gdr,@phn,@addr,@img)", db.GetConnection);
            
            //@fn,@ln,@bd,@gdr,@phn,@addr,@img
            command.Parameters.Add("@fn",MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bd", MySqlDbType.Date).Value = bdate;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@addr", MySqlDbType.Text).Value = address;
            command.Parameters.Add("@gdr", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = picture.ToArray();


            db.openConnection();
                if(command.ExecuteNonQuery()==1) {
                db.closeConnection();
                return true;

            }
            else
            {
                db.closeConnection();
                return false;
            }

            return true;
        }


        //stvoriti funkciju za dodavanje studenta u refresh listu
        public DataTable getStudents(MySqlCommand command)
        {
            command.Connection = db.GetConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;


        }

    }
}
