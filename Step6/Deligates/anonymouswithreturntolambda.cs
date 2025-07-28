using System;

namespace AnonymousMethodsWithReturntypes1
{
    // Delegates with different return types
    delegate void TakeOrderTask(string taskDetail);
    delegate string PreparationFoodTask(string taskDetail);
    delegate bool ServeFoodTask(string taskDetail);

    class Program
    {
        static void Main()
        {
            // Lambda expression for taking orders
            TakeOrderTask takeOrder = orderName =>
                Console.WriteLine("Waiter: Taking order for " + orderName);

            takeOrder("Pista");

            // Lambda expression for preparing food
            PreparationFoodTask prepareFood = orderName =>
                $"{orderName} preparation completed.";

            string status = prepareFood("Pista");
            Console.WriteLine(status);

            // Lambda expression for serving food
            ServeFoodTask serveFood = orderName =>
            {
                Console.WriteLine("Serving: " + orderName);
                return true; // Assume serving was successful
            };

            bool isCompleted = serveFood("Dosa");
            Console.WriteLine("Serving completed: " + isCompleted);
        }
    }
}

