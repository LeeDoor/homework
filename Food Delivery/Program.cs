namespace Delivery
{
    public static class Program
    {
        private static void Main()
        {
            Order order = DeliveryApp.CreateOrder();
            order.Show();
        }
    }
}