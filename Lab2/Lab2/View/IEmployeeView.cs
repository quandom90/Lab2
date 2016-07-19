using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2.Model;
using System.Windows.Forms;

namespace Lab2.View
{
    /// <summary>
    /// interface IEmployee view with List and String properties
    /// </summary>
    public interface IEmployeeView 
    {
        ListView List { get; set; }

        string Option { get; set; }
    }
}
