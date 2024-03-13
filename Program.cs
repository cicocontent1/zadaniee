using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string k = "Server=DESKTOP-L4K06VF;Database=EmployeesZadanie111;integrated security=true";
            SqlConnection con = new SqlConnection(k);
            con.Open();
            using (con)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                // cmd.CommandText = "create table JobTitle( jobId int primary key, jobName varchar(50))";
                // cmd.ExecuteNonQuery();
                // cmd.CommandText = "Create table Employees( Id int primary key, Name varchar(50),jobId int, foreign key (jobId) references JobTitle(jobId)) ";
                // cmd.ExecuteNonQuery();
                //  cmd.CommandText = "Insert into JobTitle values (1,'itspecialist'), (2,'lekar'), (3,'policaj');";
                //  cmd.ExecuteNonQuery();
                // cmd.CommandText = "Insert into Employees values (1,'Ivan',1), (2,'maria',2), (3,'gosho',3);";
                // cmd.ExecuteNonQuery();


                Console.WriteLine(cmd.CommandText = "Select * from Employees");
                cmd.ExecuteNonQuery();

                cmd.CommandText = @"Insert into Employees (Name) values (@Name);";
                cmd.Parameters.AddWithValue("Name", "Jony");
                cmd.ExecuteNonQuery();





            }


        }
    }
}
