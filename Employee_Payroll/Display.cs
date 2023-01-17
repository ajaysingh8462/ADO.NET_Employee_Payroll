using Employee_Payroll.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Payroll
{
    public class Display
    {
        public static string connection = @"Data Source=DESKTOP-P65PD0V;Initial catalog=Employee_Payroll;Integrated Security=true";
        SqlConnection sqlConnection = new SqlConnection(connection);

        public void DisplayEmployeeDetails()
        {
            EmployeeModel model = new EmployeeModel();


            try
            {
                using (sqlConnection)
                {
                    string query = @"select * from EmployepayrollTable";
                    SqlCommand cmd = new SqlCommand(query, sqlConnection);
                    sqlConnection.Open();
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            model.Name = dataReader.GetString(1);
                            model.StartDate = dataReader.GetDateTime(2);
                            model.phone = dataReader.GetInt64(3);
                            model.Emp_Address = dataReader.GetString(4);
                            model.Department = dataReader.GetString(5);
                            model.Gender = dataReader.GetString(6);
                            model.Basic_Pay = dataReader.GetInt64(7); 
                            model.Deductions = dataReader.GetInt64(8);
                            model.Taxable_Pay = dataReader.GetInt64(9);
                            model.Income_Tax = dataReader.GetInt64(10);
                            model.Net_Pay = dataReader.GetInt64(11);

                            Console.WriteLine(model.Name + " " + model.StartDate + " " + model.phone + " " + model.Emp_Address + " "
                                + model.Department + " " + model.Gender + " " + model.Basic_Pay + " " + model.Deductions + " " + model.Taxable_Pay + " " + model.Income_Tax + " " + model.Net_Pay);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
