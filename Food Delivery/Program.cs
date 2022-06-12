namespace Food_Delivery
{
    public static class Program
    {
        private static void Main()
        {
            OrderBuilder builder = new();
            Order order = builder.BuildOrder();
            order.Show();
        }
    }
}