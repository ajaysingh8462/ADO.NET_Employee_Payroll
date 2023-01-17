using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Payroll
{
    class program
    {
        public static void Main(string[] args)
        {
            //Data_Base data= new Data_Base();
            //data.CreateDatabass();
            //Table.CreateTable();
            Console.WriteLine("Enter Option\n1.Insert Details\n2.Retrive data from database ");
            int op = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                switch (op)
                {
                    case 1:
                        InsertcEmployeeDetails insert = new InsertcEmployeeDetails();
                        Console.WriteLine("Enter Name");
                        string Name = Console.ReadLine();
                        Console.WriteLine("Enter Startdate");
                        var Startdate = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Enter PhoneNumber");
                        long phone = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("Enter Emp_Address");
                        string Emp_Address = Console.ReadLine();
                        Console.WriteLine("Enter Department");
                        string Department = Console.ReadLine();
                        Console.WriteLine("Enter Gender");
                        string Gender = Console.ReadLine();
                        Console.WriteLine("Enter Basic_Pay");
                        double Basic_Pay = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter Deductions");
                        double Deductions = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter Taxable_Pay");
                        double Taxable_Pay = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter Income_Tax");
                        double Income_Tax = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter Net_Pay");
                        double Net_Pay = Convert.ToDouble(Console.ReadLine());
                        insert.InsertIntoTable(Name, Startdate, phone, Emp_Address, Department, Gender, Basic_Pay, Deductions, Taxable_Pay, Income_Tax, Net_Pay);
                        break;
                    case 2:
                        Display ds = new Display();
                        ds.DisplayEmployeeDetails();
                        break;
                }
                break;

            }
        }
    }
}