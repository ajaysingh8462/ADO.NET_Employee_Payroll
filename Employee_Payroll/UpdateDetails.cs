using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Payroll
{
    public class UpdateDetails
    {
        public static string connection = @"Data Source=DESKTOP-P65PD0V;Initial catalog=Employee_Payroll;Integrated Security=true";
        SqlConnection sqlConnection = new SqlConnection(connection);

        public string UpdateBasicPay(string Name)
        {
            int result = 0;
            try
            {
                using (sqlConnection)
                {

                    SqlCommand sqlCommand = new SqlCommand("UpdateDetails", this.sqlConnection);

                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@Name", Name);
                    sqlConnection.Open();
                    result = sqlCommand.ExecuteNonQuery();
                    if (result != 0)
                    {
                        Console.WriteLine("Updated");
                        return "Updated!";
                        
                    }
                    else
                    {
                        Console.WriteLine("Not Updated");
                        return "Not Updated!";
                        
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return (e.Message);
            }
            finally { sqlConnection.Close(); }
        }
    }
}
