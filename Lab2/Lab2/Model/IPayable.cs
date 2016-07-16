using System;

namespace Lab2.Model
{
    public interface IPayable : IComparable
    {
        decimal GetPaymentAmount(); // calculate payment; no implementation
        new int CompareTo(object obj);
    } // end interface IPayable
}