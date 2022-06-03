using learn;
public static class Program
{
	private static void Main()
	{
		OrderDirector director = new OrderDirector();
		OrderBuilder builder = new OrderBuilder();
		director.Builder = builder;
		

		director.ShowCreatingMenu();


	}
}