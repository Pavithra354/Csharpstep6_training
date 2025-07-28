using System;

namespace NSLambdasWithActionDelegates
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
            // Action with one parameter
            Action<string> confirmOrder = orderName =>
                Console.WriteLine($"Your order ID: {orderName}");

            confirmOrder("Pasta");

            // Action with two parameters
            Action<string, string> confirmOrderWithDetails = (orderName, orderDetails) =>
                Console.WriteLine($"Your order ID: {orderName} with details: {orderDetails}");

            confirmOrderWithDetails("Pasta", "Extra Cheese");

            // Action with three parameters
            Action<string, string, int> confirmOrderWithQuantity = (orderName, orderDetails, quantity) =>
            {
                Console.WriteLine($"Waiter: Order for {orderName} confirmed.");
                Console.WriteLine($"Details: {orderDetails}, Quantity: {quantity}");
                Console.WriteLine($"Total Price: ₹{quantity * 100}");
                Console.WriteLine("Order Confirmed");
            };

            confirmOrderWithQuantity("Pasta", "Extra Cheese", 2);

            // Action with no parameters
            Action notifyCustomer = () =>
            {
                Console.WriteLine("Order Confirmed");
                Console.WriteLine("Please wait for the order.");
            };

            notifyCustomer();
        }
    }
}