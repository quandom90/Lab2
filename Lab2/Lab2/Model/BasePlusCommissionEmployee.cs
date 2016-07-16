using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Model
{
    public class BasePlusCommissionEmployee : CommissionEmployee
    {
        private decimal baseSalary; // base salary per week

        // six-parameter constructor
        public BasePlusCommissionEmployee(string first, string last,
           string ssn, decimal sales, decimal rate, decimal salary) : base(first, last, ssn, sales, rate)

        {
            BaseSalary = salary; // validate base salary via property
        } // end six-parameter BasePlusCommissionEmployee constructor

        // property that gets and sets 
        // base-salaried commission employee's base salary
        public decimal BaseSalary
        {
            get
            {
                return baseSalary;
            } // end get
            set
            {
                if (value >= 0)
                    baseSalary = value;
                else
                    throw new ArgumentOutOfRangeException("BaseSalary",
                       value, "BaseSalary must be >= 0");
            } // end set
        } // end property BaseSalary

        // calculate earnings; override method Earnings in CommissionEmployee
        public override decimal GetPaymentAmount()
        {
            return BaseSalary + base.GetPaymentAmount();
        } // end method Earnings               

        // return string representation of BasePlusCommissionEmployee object
        public override string ToString()
        {
            return string.Format("base-salaried {0}; base salary: {1:C}",
               base.ToString(), BaseSalary);
        } // end method ToString                                            
    } // end class BasePlusCommissionEmployee
}
