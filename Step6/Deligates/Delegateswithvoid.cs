using System;

namespace RestaurantDelegate_Void_Example
{
    // Declare delegate
    public delegate void KitchenSection(string order);

    public class Restaurant
    {
        public void MainCourseSection(string order)
        {
            Console.WriteLine($"Main Course Chef is preparing: {order}");
        }

        public void DessertSection(string order)
        {
            Console.WriteLine($"Dessert Chef is preparing: {order}");
        }

        public void DrinksSection(string order)
        {
            Console.WriteLine($"Drinks Section is preparing: {order}");
        }
    }

    class ExecuteRestaurant
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant();

            // Waiter acts as the delegate to route orders
            KitchenSection waiter;

            Console.WriteLine("Customer places order for Pasta...");
            waiter = restaurant.MainCourseSection;
            waiter("Pasta");

            Console.WriteLine("\nCustomer places order for Ice Cream...");
            waiter = restaurant.DessertSection;
            waiter("IceCream");

            Console.WriteLine("\nCustomer places order for a Mojito...");
            waiter = restaurant.DrinksSection;
            waiter("Mojito");
        }
    }
}