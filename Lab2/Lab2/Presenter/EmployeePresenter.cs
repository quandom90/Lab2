using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Lab2.Model;
using Lab2.View;

namespace Lab2.Presenter
{
    /// <summary>
    /// View class named EmployeePresenter
    /// </summary>
    public class EmployeePresenter
    {
        private IEmployeeView view;
        private EmployeeModel model;
        private const string OPTION_1 = "1. Last Name Ascending";
        private const string OPTION_2 = "2. Earned Descending";
        private const string OPTION_3 = "3. SSN Ascending";

        /// <summary>
        /// Presenter IEmployee view
        /// </summary>
        /// <param name="view"></param>
        public EmployeePresenter(IEmployeeView view)
        {
            this.view = view;
            this.model = new EmployeeModel();

            PrintEmployeeList(this.model.Employees);
        }

        /// <summary>
        /// Method to print an employee list that takes in param of Employee array
        /// </summary>
        /// <param name="emp"></param>
        private void PrintEmployeeList(Employee[] emp)
        {
            this.view.List.Items.Clear();
            foreach (Employee e in emp)
            {
                string[] arr = { e.LastName, e.FirstName, e.SocialSecurityNumber, e.GetPaymentAmount().ToString("C", CultureInfo.CurrentCulture) };
                this.view.List.Items.Add(new ListViewItem(arr));
            }
        }

        /// <summary>
        /// Sorting method to implement the 3 different sorting options
        /// </summary>
        public void Sort()
        {
            if (view.Option == OPTION_1)
            {
                PrintEmployeeList(model.SortOption1());
            }
            else if (view.Option == OPTION_2)
            {
                PrintEmployeeList(model.SortOption2());
            }
            else if (view.Option == OPTION_3)
            {
                PrintEmployeeList(model.SortOption3());
            }
        }
    }
}
