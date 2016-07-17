using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Model
{
    public class EmployeeModel
    {
        private IPayable[] payableObjects;

        public EmployeeModel()
        {
            payableObjects = new IPayable[8];
            payableObjects[0] = new SalariedEmployee("John", "Smith", "111-11-1111", 700M);
            payableObjects[1] = new SalariedEmployee("Antonio", "Smith", "555-55-5555", 800M);
            payableObjects[2] = new SalariedEmployee("Victor", "Smith", "444-44-4444", 600M);
            payableObjects[3] = new HourlyEmployee("Karen", "Price", "222-22-2222", 16.75M, 40M);
            payableObjects[4] = new HourlyEmployee("Ruben", "Zamora", "666-66-6666", 20.00M, 40M);
            payableObjects[5] = new CommissionEmployee("Sue", "Jones", "333-33-3333", 10000M, .06M);
            payableObjects[6] = new BasePlusCommissionEmployee("Bob", "Lewis", "777-77-7777", 5000M, .04M, 300M);
            payableObjects[7] = new BasePlusCommissionEmployee("Lee", "Duarte", "888-88-888", 5000M, .04M, 300M);
            
        }
        
        public Employee[] Employees
        {
            get
            {
                return Array.ConvertAll<IPayable, Employee>(payableObjects, pay => pay as Employee);
            }
        }

        public Employee[] SortOption1()
        {
            Employee[] emp = Array.ConvertAll<IPayable, Employee>(payableObjects, pay => pay as Employee);
            Array.Sort<Employee>(emp);
            payableObjects = emp;
            return emp;
        }

        public Employee[] SortOption2()
        {
            Employee[] emp = Array.ConvertAll<IPayable, Employee>(payableObjects, pay => pay as Employee);
            Array.Sort<Employee>(emp, Employee.sortPaymentAscending());
            payableObjects = emp;
            return emp;
        }

        public Employee[] SortOption3()
        {
            SortSSNAscending.Sort(payableObjects, SortSSNAscending.LesserThan);
            return Array.ConvertAll<IPayable, Employee>(payableObjects, pay => pay as Employee);
        }
    }
}
