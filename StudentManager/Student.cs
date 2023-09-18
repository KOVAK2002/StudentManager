using System;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient;

namespace StudentManager
{
    internal class Student
    {
   
        // Definiranje dlegata
        public delegate void StudentOperationEventHandler(object sender, StudentEventArgs e);

        // Delegati za metode
        public event StudentOperationEventHandler StudentInserted;
        public event StudentOperationEventHandler StudentUpdated;
        public event StudentOperationEventHandler StudentDeleted;

        MY_DB db = new MY_DB();

        public bool InsertStudent(string fname, string lname, DateTime bdate, string phone, string gender, string address, MemoryStream picture)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `students`(`FirstName`, `LastName`, `BirthDate`, `Gender`, `Phone`, `Address`, `Image`) VALUES (@fn,@ln,@bd,@gdr,@phn,@addr,@img)", db.GetConnection);

            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bd", MySqlDbType.Date).Value = bdate;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@addr", MySqlDbType.Text).Value = address;
            command.Parameters.Add("@gdr", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = picture.ToArray();

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                // provjera inserta
                OnStudentInserted(new StudentEventArgs(fname, lname, bdate, phone, gender, address, picture));
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }

        public DataTable getStudents(MySqlCommand command)
        {
            command.Connection = db.GetConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool updateStudent(int id, string fname, string lname, DateTime bdate, string phone, string gender, string address, MemoryStream picture)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `students` SET `FirstName`=@fn,`LastName`=@ln,`BirthDate`=@bd,`Gender`=@gdr,`Phone`=@phn,`Address`=@addr,`Image`=@img WHERE `Id`=@ID", db.GetConnection);

            command.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bd", MySqlDbType.Date).Value = bdate;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@addr", MySqlDbType.Text).Value = address;
            command.Parameters.Add("@gdr", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = picture.ToArray();

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                // provjera update
                OnStudentUpdated(new StudentEventArgs(fname, lname, bdate, phone, gender, address, picture));
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }

        public bool deleteStudent(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `students` WHERE `Id`=@studentId", db.GetConnection);

            command.Parameters.Add("@studentID", MySqlDbType.Int32).Value = id;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                // provjera update
                OnStudentDeleted(new StudentEventArgs(null, null, DateTime.MinValue, null, null, null, null));
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }

        protected virtual void OnStudentInserted(StudentEventArgs e)
        {
            StudentInserted?.Invoke(this, e);
        }

        protected virtual void OnStudentUpdated(StudentEventArgs e)
        {
            StudentUpdated?.Invoke(this, e);
        }

        protected virtual void OnStudentDeleted(StudentEventArgs e)
        {
            StudentDeleted?.Invoke(this, e);
        }
    }

    public class StudentEventArgs : EventArgs
    {
        public string FirstName { get; }
        public string LastName { get; }
        public DateTime BirthDate { get; }
        public string Phone { get; }
        public string Gender { get; }
        public string Address { get; }
        public MemoryStream Picture { get; }

        public StudentEventArgs(string fname, string lname, DateTime bdate, string phone, string gender, string address, MemoryStream picture)
        {
            FirstName = fname;
            LastName = lname;
            BirthDate = bdate;
            Phone = phone;
            Gender = gender;
            Address = address;
            Picture = picture;
        }

        public override string ToString()
        {
            return $"Student: {FirstName} {LastName}, BirthDate: {BirthDate}, Phone: {Phone}, Gender: {Gender}, Address: {Address}";
        }
    }
}


