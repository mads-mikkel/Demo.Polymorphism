using System;
using System.Collections.Generic;

namespace Demo.Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseSalariedEmployee baseEmployee = new();
            baseEmployee.Salary = 10_000m;
            Employee e = baseEmployee as Employee;
            Console.WriteLine($"Base emplyee: {e.Earnings()}");

            SalesRepresentative salesRepresentative = new();
            salesRepresentative.Salary = 10_000m;
            salesRepresentative.CommisionRate = 0.1;
            salesRepresentative.WeeklySales = 1_000m;
            e = salesRepresentative as Employee;
            Console.WriteLine($"Sales emplyee: {e.Earnings()}");

            e = baseEmployee as Employee;
            Console.WriteLine($"Base emplyee GetPaymentAmount: {e.GetPaymentAmount()}");
            e = salesRepresentative as Employee;
            Console.WriteLine($"Base emplyee GetPaymentAmount: {e.GetPaymentAmount()}");

            Product p1 = new() { Name = "Øl", Price = 10m, Qty = 100 };
            Product p2 = new() { Name = "Portvin", Price = 100m, Qty = 25 };
            Invoice invoice = new() { Products = new() { p1, p2 } };

            List<IPayable> payables = new()
            {
                baseEmployee,   // 8.500
                invoice,        // 3.500
                salesRepresentative // 8.585
            };

            Console.WriteLine($"Total: {GetTotalPaymentAmpount(payables)}");
        }

        static decimal GetTotalPaymentAmpount(List<IPayable> payables)
        {
            decimal sum = default;
            foreach(IPayable payable in payables)
            {
                sum += payable.GetPaymentAmount();
            }
            return sum;
        }
    }
}
