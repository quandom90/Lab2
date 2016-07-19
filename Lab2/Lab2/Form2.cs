using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab2.Presenter;
using Lab2.View;

namespace Lab2
{
    public partial class Form2 : Form, IEmployeeView
    {
        private EmployeePresenter presenter;
        public Form2()
        {
            InitializeComponent();
            presenter = new EmployeePresenter(this);
        }

        public ListView List
        {
            get
            {
                return lvwEmployee;
            }

            set
            {
                lvwEmployee = value;
            }
        }

        public string Option
        {
            get
            {
                return cboOption.Text;
            }

            set
            {
                cboOption.Text = value;
            }

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            presenter.Sort();   
        }
    }
}
