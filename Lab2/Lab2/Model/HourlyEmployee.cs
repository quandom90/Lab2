using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Model
{
    public class HourlyEmployee : Employee
    {
        private decimal wage; // wage per hour
        private decimal hours; // hours worked for the week

        // five-parameter constructor
        public HourlyEmployee(string first, string last, string ssn,
           decimal hourlyWage, decimal hoursWorked)
           : base(first, last, ssn)
        {
            Wage = hourlyWage; // validate hourly wage via property
            Hours = hoursWorked; // validate hours worked via property
        } // end five-parameter HourlyEmployee constructor

        // property that gets and sets hourly employee's wage
        public decimal Wage
        {
            get
            {
                return wage;
            } // end get
            set
            {
                if (value >= 0) // validation
                    wage = value;
                else
                    throw new ArgumentOutOfRangeException("Wage",
                       value, "Wage must be >= 0");
            } // end set
        } // end property Wage

        // property that gets and sets hourly employee's hours
        public decimal Hours
        {
            get
            {
                return hours;
            } // end get
            set
            {
                if (value >= 0 && value <= 168) // validation
                    hours = value;
                else
                    throw new ArgumentOutOfRangeException("Hours",
                       value, "Hours must be >= 0 and <= 168");
            } // end set
        } // end property Hours

        // calculate earnings; override Employee’s abstract method Earnings
        public override decimal GetPaymentAmount()
        {
            if (Hours <= 40) // no overtime                          
                return Wage * Hours;
            else
                return (40 * Wage) + ((Hours - 40) * Wage * 1.5M);
        } // end method Earnings                                      

        // return string representation of HourlyEmployee object
        public override string ToString()
        {
            return string.Format(
               "hourly employee: {0}\n{1}: {2:C}; {3}: {4:F2}",
               base.ToString(), "hourly wage", Wage, "hours worked", Hours);
        } // end method ToString                                            
    } // end class HourlyEmployee
}
