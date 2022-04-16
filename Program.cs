
/// <summary>
/// вадать зопрос
/// 1. как записать с консоли в чар чтобы он не жаловался
/// 2. while28 в чем прикол задачи
/// </summary>

using learn;
public static class Program
{
	public static void Case10()
	{
		int rotate;
		char startRotation;
		Console.WriteLine($"введите сначала стартовое направление СВЮЗ, потом поворот 0, 1 или -1");
		startRotation = Console.ReadLine()[0]; // как
		rotate = Convert.ToInt32(Console.ReadLine());
		char endRotation = startRotation;
		string rotations = "СВЮЗ";
		switch (startRotation)
		{
			case 'С':
				endRotation = rotations[(rotate + 4) % 4];
				break;

			case 'В':
				endRotation = rotations[(rotate + 5) % 4];
				break;

			case 'Ю':
				endRotation = rotations[(rotate + 6) % 4];
				break;

			case 'З':
				endRotation = rotations[(rotate + 7) % 4];
				break;

			default:
				Console.WriteLine("ошибка. неправильное исходное направление.");
				break;
		}
		Console.WriteLine($"робот с поворота на {startRotation} повернулся на {endRotation}");

	}
	public static void Case15()
	{
		int N, M;
		Console.WriteLine($"введите достоинство и масть карты");
		N = Convert.ToInt32(Console.ReadLine());
		M = Convert.ToInt32(Console.ReadLine());
		string outcome = "";
        switch (N)
        {
			case 6:
				outcome += "шестерка "; // навального )))))))
				break;

			case 7:
				outcome += "семерка ";
				break;

			case 8:
				outcome += "восьмерка ";
				break;

			case 9:
				outcome += "девятка ";
				break;

			case 10:
				outcome += "десятка ";
				break;

			case 11:
				outcome += "валет ";
				break;

			case 12:
				outcome += "дама ";
				break;

			case 13:
				outcome += "король ";
				break;

			case 14:
				outcome += "туз ";
				break;

			default:
				Console.WriteLine("неверное достоинство карты");
				outcome += "что-то ";
				break;
		}
        switch (M)
        {
			case 1:
				outcome += "пик";
				break;

			case 2:
				outcome += "кресте";
				break;

			case 3:
				outcome += "буба";
				break;

			case 4:
				outcome += "черва";
				break;

			default:
				Console.WriteLine("неверная масть карты");
				outcome += "какое-то ";
				break;

		}
		Console.WriteLine($"ваша карта {N}, {M} - {outcome}");
	}
	public static void For17()
    {
		int A, N;
		double result = 0;
		Console.WriteLine("введите складываемое число и максимальную степень");
		A = Convert.ToInt32(Console.ReadLine());
		N = Convert.ToInt32(Console.ReadLine());

		for(int i = 0; i < N+1; i++)
        {
			result += Math.Pow(A, i);
			Console.Write($"{Math.Pow(A, i)} + ");
		}
		Console.WriteLine($"0 =\n= {result}");
	}
	public static void For38()
    {
		int N;
		double result = 0;
		Console.WriteLine("введите целое число");
		N = Convert.ToInt32(Console.ReadLine());
		for(int i = 1; i < N+1; i++,Console.Write(" + "))
        {
			result += Math.Pow(i, N - i);
			Console.Write($"{Math.Pow(i, N - i)}");
		}
		Console.WriteLine($"= {result}");
	}
	public static void While26()
    {
		int N, buff, a = 1, b = 1;
		Console.WriteLine("введите целое число");
		N = Convert.ToInt32(Console.ReadLine());

		//ноль и единица не проверяются
        switch (N)
        {
			case 0:
				Console.WriteLine($"число стоящее: до числа {N} в ряде чисел Фибоначчи - {0}; после числа {N} в ряде чисел Фибоначчи - {1}");
				return;
			case 1:
				Console.WriteLine($"число стоящее: до числа {N} в ряде чисел Фибоначчи - {0}; после числа {N} в ряде чисел Фибоначчи - {1}");
				return;
		}

		do
        {
			buff = a + b;
			a = b;
			b = buff;
        } while (buff < N);

		// если не нашли совпадений
		if (buff != N)
        {
			Console.WriteLine("N - не число фибоначчи");
			return;
        }
		Console.WriteLine($"число стоящее: до числа {N} в ряде чисел Фибоначчи - {a}; после числа {N} в ряде чисел Фибоначчи - {a + b}");
	}
	public static void While28()
    {
		// удобнее через фор имхо но в задании написано вайл ...
		int N, i = 0;
		double buff = 2, a;
		Console.WriteLine("введите целое число");
		N = Convert.ToInt32(Console.ReadLine());
		do
		{
			i++;
			a = buff;
			buff = 2 + 1 / a;
		} while (Math.Abs(buff - a) >= N);
		Console.WriteLine($"|{buff} - {a}| < {N}. number of it is {i}");
	}
	public static void Minmax25()
	{
		int N;
		Console.WriteLine("введите размер массива");
		N = Convert.ToInt32(Console.ReadLine());
		int[] mass = new int[N];
		for (int i = 0; i < N; i++)
		{
			Console.Write($"введите {i}е число : ");
			mass[i] = Convert.ToInt32(Console.ReadLine());
		}
		int min = 0;
		for (int i = 0; i < N - 1; i++)
		{
			if (mass[min] * mass[min + 1] > mass[i] * mass[i + 1])
			{
				min = i;
			}
		}
		Console.WriteLine($"В вашем ряду числа под номерами {min} и {min + 1} имеют наименьшее произведение");
	}
	public static void Array16()
    {
		int[] mass;
		Console.WriteLine("введите размер массива, а затем его элементы поочередно");
		int size = Convert.ToInt32(Console.ReadLine());
		mass = new int[size];
		for(int i = 0; i < size; i++)
        {
			Console.Write($"введите {i}й элемент: ");
			mass[i] = Convert.ToInt32(Console.ReadLine());
		}
		Console.Write("ваш массив: ");
		for (int i = 0; i < size; i++)
		{
			Console.Write($"{mass[i]}\t");
		}
		Console.WriteLine("\nмассив в указанном порядке: ");

		for(int i = 0; i < size; i++)
        {
			Console.Write($"{mass[Math.Abs((size - 1) * (i % 2) - i / 2)]}\t");
        }
	}
	public static void Array41()
    {
		int size;
		Console.WriteLine("введите размер массива");
		size = Convert.ToInt32(Console.ReadLine());
		int[] mass = new int[size];
		for (int i = 0; i < size; i++)
		{
			Console.Write($"введите {i}е число : ");
			mass[i] = Convert.ToInt32(Console.ReadLine());
		}
		int max = 0;
		for (int i = 0; i < size - 1; i++)
		{
			if (mass[max] + mass[max + 1] > mass[i] + mass[i + 1])
			{
				max = i;
			}
		}
		Console.WriteLine($"В вашем ряду числа под номерами {max} и {max + 1} имеют наименьшее произведение");
	}
	private static void Main()
	{
		HomeworkManager a = new HomeworkManager();
		a.Start();
		//while (true)
		//{
		//	Console.WriteLine("\n\n\n\n");
		//	Console.WriteLine("Леонид Самощенко.\nздрасьте.это моя домашка. весь код зациклен, " +
		//		"чтобы вы не перезапускали программу каждый раз." +
		//		"\nвыберите тип задания:" +
		//		"\n1 - case" +
		//		"\n2 - for" +
		//		"\n3 - while" +
		//		"\n4 - minmax" +
		//		"\n5 - array\n");

		//	int chooseType = Convert.ToInt32(Console.ReadLine());
		//	switch (chooseType)
		//	{
		//		case 1:
		//			//case
		//			Console.WriteLine("теперь выберите номер задания (вы задавали номера 10 и 15):");
		//			chooseType = Convert.ToInt32(Console.ReadLine());
		//			switch (chooseType)
		//			{
		//				case 10:
		//					Case10();
		//					break;

		//				case 15:
		//					Case15();
		//					break;

		//				default:
		//					Console.WriteLine("непонял перезапустите");
		//					break;
		//			}
		//			break;

		//		case 2:
		//			Console.WriteLine("теперь выберите номер задания (вы задавали 17, 38):");
		//			chooseType = Convert.ToInt32(Console.ReadLine());
		//			switch (chooseType)
		//			{
		//				case 17:
		//					For17();
		//					break;

		//				case 38:
		//					For38();
		//					break;

		//				default:
		//					Console.WriteLine("непонял перезапустите");
		//					break;
		//			}
		//			break;

		//		case 3:
		//			Console.WriteLine("теперь выберите номер задания (вы задавали номера 26, 28):");
		//			chooseType = Convert.ToInt32(Console.ReadLine());
		//			switch (chooseType)
		//			{
		//				case 26:
		//					While26();
		//					break;

		//				case 28:
		//					While28();
		//					break;

		//				default:
		//					Console.WriteLine("непонял перезапустите");
		//					break;
		//			}
		//			break;
		//		case 4:
		//			Console.WriteLine("вы задавали номер 25:");
		//			Minmax25();
		//			break;

		//		case 5:
		//			Console.WriteLine("теперь выберите номер задания (вы задавали номера 16, 41):");
		//			chooseType = Convert.ToInt32(Console.ReadLine());
		//			switch (chooseType)
		//			{
		//				case 16:
		//					Array16();
		//					break;

		//				case 41:
		//					Array41();
		//					break;

		//				default:
		//					Console.WriteLine("непонял перезапустите");
		//					break;
		//			}
		//			break;
		//		default:
		//			Console.WriteLine("непонял перезапустите");
		//			break;
		//	}
		//}
	}
}