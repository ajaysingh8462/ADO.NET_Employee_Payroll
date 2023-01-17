using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Payroll
{
    public class InsertcEmployeeDetails
    {
        public static string connection = @"Data Source=DESKTOP-P65PD0V;Initial catalog=Employee_Payroll;Integrated Security=true";
        SqlConnection sqlConnection = new SqlConnection(connection);
        public void InsertIntoTable(string Name, DateTime StartDate, long phone, string Emp_Address, string Department, string Gender, double Basic_Pay, double Deductions, double Taxable_Pay, double Income_Tax, double Net_Pay)
        {

            int result = 0;
            try
            {
                using (sqlConnection)
                {
                    SqlCommand sqlCommand = new SqlCommand("InsertEmployee_Details", this.sqlConnection);

                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("Name", Name);
                    sqlCommand.Parameters.AddWithValue("@StartDate", StartDate);
                    sqlCommand.Parameters.AddWithValue("@phone", phone);
                    sqlCommand.Parameters.AddWithValue("@Emp_Address", Emp_Address);
                    sqlCommand.Parameters.AddWithValue("@Department", Department);
                    sqlCommand.Parameters.AddWithValue("@Gender", Gender);
                    sqlCommand.Parameters.AddWithValue("@Basic_Pay", Basic_Pay);
                    sqlCommand.Parameters.AddWithValue("@Deductions", Deductions);
                    sqlCommand.Parameters.AddWithValue("@Taxable_Pay", Taxable_Pay);
                    sqlCommand.Parameters.AddWithValue("@Income_Tax", Income_Tax);
                    sqlCommand.Parameters.AddWithValue("@Net_Pay", Net_Pay);
                    sqlConnection.Open();
                    result = sqlCommand.ExecuteNonQuery();
                    if (result != 0)
                    {
                        Console.WriteLine("Employee Details Inserted");
                    }
                    else
                    {
                        Console.WriteLine("Not Updated");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
