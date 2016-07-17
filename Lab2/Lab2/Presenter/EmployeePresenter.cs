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
    
    public class EmployeePresenter
    {
        private IEmployeeView view;
        private EmployeeModel model;
        private const string OPTION_1 = "1. Last Name Ascending";
        private const string OPTION_2 = "2. Earned Descending";
        private const string OPTION_3 = "3. SSN Ascending";

        public EmployeePresenter(IEmployeeView view)
        {
            this.view = view;
            this.model = new EmployeeModel();

            PrintEmployeeList(this.model.Employees);
        }

        private void PrintEmployeeList(Employee[] emp)
        {
            this.view.List.Items.Clear();
            foreach (Employee e in emp)
            {
                string[] arr = { e.LastName, e.FirstName, e.SocialSecurityNumber, e.GetPaymentAmount().ToString("C", CultureInfo.CurrentCulture) };
                this.view.List.Items.Add(new ListViewItem(arr));
            }
        }

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
