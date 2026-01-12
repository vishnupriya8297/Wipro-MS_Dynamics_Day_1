using System;

namespace OrderManagementSystem
{
    //  Enum – Predefined order statuses
    enum OrderStatus
    {
        Pending,
        Confirmed,
        Shipped,
        Delivered,
        Cancelled
    }

    //  Struct – Lightweight delivery location data
    struct DeliveryLocation
    {
        public double Latitude;
        public double Longitude;

        public DeliveryLocation(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
    }

    //  Interface – Payment contract
    interface IPayment
    {
        void ProcessPayment();
    }

    // Credit card payment implementation
    class CreditCardPayment : IPayment
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Credit card payment processed.");
        }
    }

    // UPI payment implementation
    class UpiPayment : IPayment
    {
        public void ProcessPayment()
        {
            Console.WriteLine("UPI payment processed.");
        }
    }
    class Order
    {
        public int OrderId { get; set; }
        public OrderStatus Status { get; set; }
        public IPayment PaymentMethod { get; set; }
        public DeliveryLocation Location { get; set; }

        public void PlaceOrder()
        {
            Console.WriteLine($"Placing Order ID: {OrderId}");
            PaymentMethod.ProcessPayment();
            Status = OrderStatus.Confirmed;
            Console.WriteLine($"Order Status: {Status}");
        }
    }

    // Main Program
    class Program
    {
        static void Main(string[] args)
        {
            // Create payment method
            IPayment payment = new CreditCardPayment();

            // Create delivery location
            DeliveryLocation location = new DeliveryLocation(12.9716, 77.5946);

            // Create order
            Order order = new Order
            {
                OrderId = 1001,
                Status = OrderStatus.Pending,
                PaymentMethod = payment,
                Location = location
            };

            // Place order
            order.PlaceOrder();

            Console.WriteLine(
                "Delivery Location: {order.Location.Latitude}, {order.Location.Longitude}"
            );
        }
    }
}
