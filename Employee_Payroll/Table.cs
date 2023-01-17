using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Employee_Payroll  
{
    internal class Table
    {
        public static void CreateTable()
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-P65PD0V;Initial catalog=Employee_Payroll;Integrated Security=true");
                connection.Open();
                SqlCommand cmd = new SqlCommand("Create Table EmployepayrollTable(id int primary key identity(1,1),Name varchar(200),Startdate date,phone bigint," +
                    "Emp_Address varchar(200),Department varchar(200),Gender varchar(10), Basic_Pay bigint," +
                    "Deductions bigint,Taxable_Pay bigint,Income_Tax bigint,Net_Pay bigint )", connection);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Table created");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
