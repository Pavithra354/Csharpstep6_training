using System;

namespace NSLambdasWithPredicateDelegates
{
    class Customer
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    class Program
    {
        static void Main()
        {
            // Simple Predicate that always returns true
            Predicate<string> alwaysTrue = orderName => true;

            // Predicate to check if an order item is available
            Predicate<string> isOrderAvailable = orderName =>
            {
                string[] availableItems = { "Pasta", "Pizza", "Salad" };
                foreach (string item in availableItems)
                {
                    if (item == orderName)
                        return true;
                }
                return false;
            };

            Console.WriteLine("Is 'Pizza' available? " + isOrderAvailable("Pizza"));

            // Predicate to check staff availability
            Predicate<string> isStaffAvailable = staffName =>
            {
                string[] availableStaff = { "John", "Doe", "Smith" };
                foreach (string staff in availableStaff)
                {
                    if (staff == staffName)
                        return true;
                }
                return false;
            };

            Console.WriteLine("Is 'Madan' available? " + isStaffAvailable("Madan"));
        }
    }
}
