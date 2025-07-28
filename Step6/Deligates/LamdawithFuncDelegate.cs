using System;

using System;

namespace NSLambdasWithFuncDelegates
{
    class Program
    {
        static void Main()
        {
            // Func with 1 input, 1 return
            Func<string, string> prepareFood = orderName =>
                $"{orderName} preparation completed.";
            Console.WriteLine(prepareFood("Pista"));

            // Func with 1 input, 1 return
            Func<int, string> getEmployeeName = empId =>
                $"Employee Name: John (ID: {empId})";
            Console.WriteLine(getEmployeeName(1));

            // Func with 2 inputs, 1 return
            Func<int, int, int> add = (a, b) => a + b;
            Console.WriteLine("Sum: " + add(1, 2));

            // Func with 2 inputs, 1 return (float)
            Func<int, string, float> getPrice = (productId, productName) =>
                100000.15f;
            Console.WriteLine("Product Price: ₹" + getPrice(12, "Lenovo Laptop"));

            // Func with no input, 1 return
            Func<string> getRestaurantName = () => "Pizza Hut";
            Console.WriteLine("Restaurant: " + getRestaurantName());
        }
    }
}