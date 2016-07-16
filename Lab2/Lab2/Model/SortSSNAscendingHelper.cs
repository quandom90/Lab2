using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Model
{
    public static class SortSSNAscending
    {
        public delegate bool ComparisonHandler(Employee first, Employee second);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ssn"></param>
        /// <param name="compare"></param>
        public static void Sort(IPayable[] ssn, ComparisonHandler compare)
        {

            for(int i = 0; i < ssn.Length; i++)
            {
                Employee emp = ssn[i] as Employee;
                int index = i;

                if (i < (ssn.Length - 1))
                {

                    for(int j = i + 1; j < ssn.Length; j++)
                    {
                        Employee emp2 = ssn[j] as Employee;

                        if (compare(emp2, emp))
                        {
                            emp = emp2;
                            index = j;
                        }
                    }
                }

                Employee temp = ssn[i] as Employee;
                ssn[i] = emp;
                ssn[index] = temp;

            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static bool LesserThan(Employee first, Employee second)
        {
            return (String.Compare(first.SocialSecurityNumber, second.SocialSecurityNumber) < 0);
        }
    }
}
