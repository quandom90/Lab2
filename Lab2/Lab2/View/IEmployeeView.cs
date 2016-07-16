using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2.Model;
using System.Windows.Forms;

namespace Lab2.View
{
    interface IEmployeeView 
    {
        ListView List { get; set; }

        string Option { get; set; }
    }
}
