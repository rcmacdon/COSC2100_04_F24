using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using Demo_w13b_UnitTesting.Properties;

namespace Demo_w13b_UnitTesting
{
    public class Trainer
    {
        public static List<Trainer> trainers = new List<Trainer>();

        public int TrainerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Region { get; set; }

        public Trainer() { }

        public Trainer(int trainerID, string firstName, string lastName, int age, string region)
        {
            TrainerID = trainerID;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Region = region;
        }

        public static void PopulateTrainers()
        {
            SqlConnection db = new SqlConnection(Settings.Default.dbConn);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Trainer", db);
            db.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Trainer t = new Trainer();
                t.TrainerID = (int)rdr["TrainerID"];
                t.FirstName = (string)rdr["FirstName"];
                t.LastName = (string)rdr["LastName"];
                t.Age = (int)rdr["Age"];
                t.Region = (string)rdr["Region"];
                trainers.Add(t);
            }
        }

        public static Boolean AddTrainer(Trainer t)
        {
            Boolean isSuccess = false;

            SqlConnection db = new SqlConnection(Settings.Default.dbConn);
            SqlCommand cmd = new SqlCommand("INSERT INTO Trainer (FirstName, LastName, Age, Region) VALUES (@FirstName, @LastName, @Age, @Region)", db);
            cmd.Parameters.AddWithValue("@FirstName", t.FirstName);
            cmd.Parameters.AddWithValue("@LastName", t.LastName);
            cmd.Parameters.AddWithValue("@Age", t.Age);
            cmd.Parameters.AddWithValue("@Region", t.Region);
            db.Open();
            if (cmd.ExecuteNonQuery() == 1) isSuccess = true;
            db.Close();
            return isSuccess;
        }

        public static Boolean AddTrainer(string firstName, string lastName, int age, string region)
        {
            Trainer t = new Trainer();
            t.FirstName = firstName;
            t.LastName = lastName;
            t.Age = age;
            t.Region = region;
            return AddTrainer(t);
        }

        public Boolean AddTrainer()
        {
            return AddTrainer(this);
        }





    }
}
