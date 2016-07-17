using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Model
{
    public abstract class Employee : IPayable
    {
        
        private class SortPaymentDescendingHelper : IComparer<Employee>
        {
            public int Compare(Employee c1, Employee c2)
            {
            
                if (c1.GetPaymentAmount() < c2.GetPaymentAmount())
                {
                    return 1;
                }

                if (c1.GetPaymentAmount() > c2.GetPaymentAmount())
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }

          
        }

        public static IComparer<Employee> sortPaymentAscending()
        {
            return (IComparer<Employee>) new SortPaymentDescendingHelper();
        }

        // read-only property that gets employee's first name
        public string FirstName { get; private set; }

        // read-only property that gets employee's last name
        public string LastName { get; private set; }

        // read-only property that gets employee's social security number
        public string SocialSecurityNumber { get; private set; }

        // three-parameter constructor
        public Employee(string first, string last, string ssn)
        {
            FirstName = first;
            LastName = last;
            SocialSecurityNumber = ssn;
        } // end three-parameter Employee constructor

        // return string representation of Employee object, using properties
        public override string ToString()
        {
            return string.Format("{0} {1}\nsocial security number: {2}",
               FirstName, LastName, SocialSecurityNumber);
        } // end method ToString

        public abstract decimal GetPaymentAmount();

        public int CompareTo(object obj)
        {
            Employee e = obj as Employee;
            return String.Compare(this.LastName, e.LastName);
        }


    } // end abstract class Employee

}
