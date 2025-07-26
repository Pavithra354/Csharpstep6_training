using System;

namespace DelegatesWithReturns
{
    // Delegates
    public delegate string OrderPreparation(string order);
    public delegate void OrderConfirmation(string order);
    public delegate bool OrderAvailability(string order);

    public class Restaurant
    {
        public string PrepareMainCourse(string order)
        {
            return $"Main Course Chef is preparing: {order}";
        }

        public void ConfirmOrder(string order)
        {
            Console.WriteLine($"Order confirmed: {order}");
        }

        public bool CheckOrderAvailability(string order)
        {
            string[] availableItems = { "Pasta", "Ice Cream", "Mojito" };
            foreach (string item in availableItems)
            {
                if (item.Equals(order, StringComparison.OrdinalIgnoreCase))
                    return true;
            }
            return false;
        }
    }

    class ExecuteRestaurant
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant();

            // Delegate registration
            OrderPreparation preparation = restaurant.PrepareMainCourse;
            OrderConfirmation confirmation = restaurant.ConfirmOrder;
            OrderAvailability availability = restaurant.CheckOrderAvailability;

            // Order 1
            string order1 = "Pasta";
            Console.WriteLine("Customer places order for: " + order1);

            if (availability(order1))
            {
                Console.WriteLine(preparation(order1));
                confirmation(order1);
            }
            else
            {
                Console.WriteLine($"Sorry, {order1} is not available.");
            }

            Console.WriteLine("\n--------------------------------------------------");

            // Order 2
            string order2 = "Chicken Biryani";
            Console.WriteLine("Customer places order for: " + order2);

            if (availability(order2))
            {
                Console.WriteLine(preparation(order2));
                confirmation(order2);
            }
            else
            {
                Console.WriteLine($"Sorry, {order2} is not available.");
            }
        }
    }
}