using System;

namespace AnonymousMethods
{
    delegate void RestaurantTask(string taskDetail);

    class Program
    {
        static void Main()
        {
            // Anonymous method for taking orders
            RestaurantTask takeOrder = delegate (string orderName)
            {
                Console.WriteLine("Waiter: Taking order for " + orderName);
            };

            // Anonymous method for preparing food
            RestaurantTask prepareFood = delegate (string orderName)
            {
                Console.WriteLine("Kitchen: Preparing " + orderName);
            };

            // Anonymous method for serving food
            RestaurantTask serveFood = delegate (string orderName)
            {
                Console.WriteLine("Waiter: Serving " + orderName);
            };

            string order = "Pista";
            takeOrder(order);
            prepareFood(order);
            serveFood(order);
        }
    }
}