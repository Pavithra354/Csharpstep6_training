using System;

namespace AnonymousToLambdaNamespace
{
    delegate void RestaurantTask(string taskDetail);

    class Program
    {
        static void Main()
        {
            RestaurantTask takeOrder = orderName =>
                Console.WriteLine("Waiter: Taking order for " + orderName);

            RestaurantTask prepareFood = orderName =>
                Console.WriteLine("Kitchen: Preparing " + orderName);

            RestaurantTask serveFood = orderName =>
                Console.WriteLine("Waiter: Serving " + orderName);

            string order = "Pista";
            takeOrder(order);
            prepareFood(order);
            serveFood(order);
        }
    }
}