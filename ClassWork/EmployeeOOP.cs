using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class EmployeeOOP
    {
        public int EmpId;
        public string EmpName;
        public double GrossPay;    // 25000 + // house rent - 5000, convence allowence - 4000,
        double TaxDeduction = 0.1; //10%
        double netSalary;

        public EmployeeOOP(int Eid, string Ename, double Egrosspay)
        {
            this.EmpId = Eid;
            this.EmpName = Ename;
            this.GrossPay = Egrosspay;

        }

        void CalculateSalary()      //abstraction  //bydefault private 
        {
            if (GrossPay >= 30000)
            {
                netSalary = GrossPay - (TaxDeduction * GrossPay);  //gives netsalary with 10% taxdeduction
                Console.WriteLine($"Your Salary is : {netSalary} After Tax Deduction.");
            }
            else
            {
                Console.WriteLine("Your salary is : {0}", GrossPay);
            }
        }
        public void ShowEmployeeDetails()
        {
            Console.WriteLine("Employee Id : "+ EmpId);
            Console.WriteLine("Employee Name : "+ EmpName);
            this.CalculateSalary();
        }


    
    
        static void Main(string[] args)
        {

            EmployeeOOP obj = new EmployeeOOP(1, "prathamesh", 45000);
            obj.ShowEmployeeDetails();
        }
    }
}
