using System;

namespace UserTypeCaseStudy
{
    // Step 1: Enum to represent OrderStatus
    enum OrderStatus
    {
        Pending,
        Processing,
        Shipped,
        Delivered,
        Cancelled
    }

    // Step 2: Structure to represent Location
    struct Location
    {
        public double Latitude;
        public double Longitude;

        public Location(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
    }

    // Step 3: Interface for payment contract
    interface IPayment
    {
        void ProcessPayment(double amount);
        void RefundPayment(double amount);
        bool MakePayment(double amount);
    }

    // Credit Card Payment Implementation
    class CreditCardPayment : IPayment
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Credit Card payment processed for ₹{amount}");
        }

        public void RefundPayment(double amount)
        {
            Console.WriteLine($"Credit Card refund issued for ₹{amount}");
        }

        public bool MakePayment(double amount)
        {
            Console.WriteLine("Credit Card payment successful");
            return true;
        }
    }

    // Debit Card Payment Implementation
    class DebitCardPayment : IPayment
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Debit Card payment processed for ₹{amount}");
        }

        public void RefundPayment(double amount)
        {
            Console.WriteLine($"Debit Card refund issued for ₹{amount}");
        }

        public bool MakePayment(double amount)
        {
            Console.WriteLine("Debit Card payment successful");
            return true;
        }
    }

    // Step 4: Class Order implementing payment interface
    class Order : IPayment
    {
        public int OrderId { get; set; }
        public OrderStatus Status { get; set; }
        public Location ShippingLocation { get; set; }

        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Order {OrderId}: Payment processed for ₹{amount}");
            Status = OrderStatus.Processing;
        }

        public void RefundPayment(double amount)
        {
            Console.WriteLine($"Order {OrderId}: Refund processed for ₹{amount}");
            Status = OrderStatus.Cancelled;
        }

        public bool MakePayment(double amount)
        {
            Console.WriteLine($"Order {OrderId}: Payment successful");
            return true;
        }
    }

    // Main Program
    class Program
    {
        static void Main(string[] args)
        {
            Location location = new Location(12.9716, 77.5946);

            Order order = new Order
            {
                OrderId = 1001,
                Status = OrderStatus.Pending,
                ShippingLocation = location
            };

            order.ProcessPayment(2500);
            order.MakePayment(2500);

            Console.WriteLine($"Order Status: {order.Status}");
            Console.WriteLine($"Shipping Location: {order.ShippingLocation.Latitude}, {order.ShippingLocation.Longitude}");
        }
    }
}
