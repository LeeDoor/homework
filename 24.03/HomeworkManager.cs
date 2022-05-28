namespace learn
{
    /// <summary>
    /// в этом классе реализуются решения задач и работа с классом Homework
    /// </summary>
    class HomeworkManager
    {
        Homework homework;

        public HomeworkManager()
        {
            homework = new Homework();
        }
        /// <summary>
        /// сдесь пишутся функции для решения задач
        /// </summary>
        /// <returns></returns>

<<<<<<< HEAD


        public bool Integer24()
        {
            Console.WriteLine("введите день >");
            int K = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"день {K} имеет {K % 7} номер дня недели.");
            return true;
        }
        public bool Integer29()
        {
            Console.WriteLine("введите 3 числа >");
            int A, B, C, squadsIn, freeSpace;
            Console.Write("первая сторона прямоугольника: ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.Write("вторая сторона прямоугольника: ");
            B = Convert.ToInt32(Console.ReadLine());
            Console.Write("сторона квадрата: ");
            C = Convert.ToInt32(Console.ReadLine());

            squadsIn = (A / C) * (B / C);
            if (squadsIn == 0)
                freeSpace = A * B;
            else
                freeSpace = A * B - squadsIn * C * C;

            Console.WriteLine($"вы можете поместить в квадрат {A}x{B} столько квадратов: {squadsIn}. останется {freeSpace}.");
            return true;
        }
        public bool Boolean25()
        {
            Console.WriteLine("введите 2 координаты >");
            int x, y;
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write($"точка А({x};{y}) ");
            if (x < 0 && y > 0)
                Console.Write("лежит");
            else
                Console.Write("не лежит");
            Console.WriteLine(" во второй четверти.");
            return true;
        }
        public bool Boolean30()
        {
            Console.WriteLine("введите 3 стороны треугольника >");
            int a, b, c;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if (a == b && b == c)
                Console.WriteLine("треугольник со сторонами {a},{b},{c} - равносторонний.");
            else
                Console.WriteLine("треугольник со сторонами {a},{b},{c} - не равносторонний.");
            return true;
        }
        public bool Boolean35()
        {
            Console.WriteLine("введите x1,y1,x2,y2 >");
            int x1, y1, x2, y2;
            Console.Write("x1: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y1: ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("x2: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y2: ");
            y2 = Convert.ToInt32(Console.ReadLine());
            if ((x1 + y1 % 2) % 2 == (x2 + y2 % 2) % 2)
            {
                Console.WriteLine("клетка с позициями {x1}и{y1} имеет такой же цвет что и клетка {x2},{y2}.");
            }
            else
                Console.WriteLine("клетка с позициями {x1}и{y1} не имеет такой же цвет что и клетка {x2},{y2}.");
            return true;
        }
        public bool If20()
        {
            Console.WriteLine("введите позиции трех точек на плоскости >");

            Console.Write("Ax: ");
            int Ax = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ay: ");
            int Ay = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bx: ");
            int Bx = Convert.ToInt32(Console.ReadLine());
            Console.Write("By: ");
            int By = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cx: ");
            int Cx = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cy: ");
            int Cy = Convert.ToInt32(Console.ReadLine());
            float sqrLenToC, sqrLenToB;
            sqrLenToC = ((Ax - Cx) * 2 + (Ay - Cy) * 2);
            sqrLenToB = ((Ax - Bx) * 2 + (Ay - By) * 2);
            if (sqrLenToC < sqrLenToB) Console.WriteLine($"length from A({Ax}, {Ay}) to C ({Cx}, {Cy}) is less than to B ({Bx}, {By}). length is {Math.Sqrt(sqrLenToC)}");
            else if (sqrLenToC > sqrLenToB) Console.WriteLine($"length from A({Ax}, {Ay}) to B ({Bx}, {By}) is less than to C ({Cx}, {Cy}). length is {Math.Sqrt(sqrLenToB)}");
            else Console.WriteLine($"length from A({Ax}, {Ay}) to B ({Bx}, {By}) is same as to C ({Cx}, {Cy}). length is {Math.Sqrt(sqrLenToC)}");
            return true;
        }
        public bool If23()
        {

            Console.WriteLine("введите позиции трех вершин прямоугольника на плоскости >");
            Console.Write("Ax: ");
            int Ax = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ay: ");
            int Ay = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bx: ");
            int Bx = Convert.ToInt32(Console.ReadLine());
            Console.Write("By: ");
            int By = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cx: ");
            int Cx = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cy: ");
            int Cy = Convert.ToInt32(Console.ReadLine());
            int Dx = 0, Dy = 0;
            bool isFound = false;

            //находим противоположную точку от искомой
            //if a
            if ((Ax == Bx || Ax == Cx) && (Ay == By || Ay == Cy))
            {
                // a is protivopolojnaya iskomoy
                //sassmotr B
                if (Bx == Ax)
                {
                    Dy = By;
                    Dx = Cx;
                }
                else
                {
                    Dy = Cy;
                    Dx = Bx;
                }
                isFound = true;
            }
            else if ((Bx == Ax || Bx == Cx) && (By == Ay || By == Cy))
            {
                // a is protivopolojnaya iskomoy
                //sassmotr B
                if (Ax == Bx)
                {
                    Dy = Ay;
                    Dx = Cx;
                }
                else
                {
                    Dy = Cy;
                    Dx = Ax;
                }
                isFound = true;
            }
            else if ((Cx == Bx || Cx == Ax) && (Cy == By || Cy == Ay))
            {
                // a is protivopolojnaya iskomoy
                //sassmotr B
                if (Bx == Cx)
                {
                    Dy = By;
                    Dx = Ax;
                }
                else
                {
                    Dy = Ay;
                    Dx = Bx;
                }
                isFound = true;
            }
            if (isFound) Console.WriteLine($"третья вершина: D({Dx}, {Dy})");
            else Console.WriteLine($"проверьте введенные данные");
            return true;
        }
        public bool If26()
        {
            Console.WriteLine("введите х >");
            int Ax = Convert.ToInt32(Console.ReadLine()), Ay;
            if (Ax <= 0)
            {
                Ay = -Ax;
            }
            else if (Ax > 0 && Ax < 2)
            {
                Ay = Ax * Ax;
            }
            else Ay = 4;

            Console.WriteLine($"функция f({Ax}) = {Ay}");
            return true;
        }


        /// <summary>
        /// сдесь все созданные задачи добавляются в список в классе Homework и программа запускается
        /// </summary>
        public void Start()
        {
            homework.addTask("Integer 24", "Дни недели пронумерованы следующим образом: 0 — воскресенье, 1  —  понедельник,  2  —  вторник,  . . . , 6  —  суббота.Дано  целое  число  K, лежащее в диапазоне 1–365.Определитьномер дня недели для K - го дня года, если известно, что в этом году 1 января было понедельником.", 
                Integer24);
            homework.addTask("Integer 29", "Даны целые положительные числа A, B, C. На прямоугольнике размера A B размещено максимально возможное количество квадратов со стороной C(без наложений).Найти количество квадратов, размещенных на прямоугольнике, а также площадь незанятой частипрямоугольника.", 
                Integer29);
            homework.addTask("Boolean 25", "Даны числа x, y. Проверить истинность высказывания: «Точка с координатами(x, y) лежит во второй координатной четверти».", 
                Boolean25); 
            homework.addTask("Boolean 30", "Даны целые числа a, b, c, являющиеся сторонами некоторого тре- угольника. Проверить истинность высказывания: «Треугольник со сторо - нами a, b, c является равносторонним».",
                Boolean30); 
            homework.addTask("Boolean 35", "Даны  координаты  двух  различных  полей  шахматной  доски  x₁, y₁, x₂, y₂ (целые числа, лежащие в диапазоне 1–8).Проверить истинность высказывания: «Данные поля имеют одинаковыйцвет».",
                Boolean35); 
            homework.addTask("If 20", "На числовой оси расположены три точки: A, B, C. Определить, какая из двух  последних  точек  (B  или  C)  расположена  ближе  к  A, и  вывести  эту точку и ее расстояние от точки A.",
                If20); 
            homework.addTask("If 23", "Даны целочисленные координаты трех вершин прямоугольника, стороны которого параллельны координатным осям. Найти координаты его четвертой вершины.",
                If23); 
            homework.addTask("If 26", "Для  данного  вещественного  x  найти  значение  следующей  функции  f, принимающей вещественные значения: -x, если x <= 0,\nx², если 0 < x < 2,\n4, если x ≥ 2.",
                 If26);
=======
		public static bool Case10()
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

			return true;
		}
		public static bool Case15()
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
			return true;
		}
		public static bool For17()
		{
			int A, N;
			double result = 0;
			Console.WriteLine("введите складываемое число и максимальную степень");
			A = Convert.ToInt32(Console.ReadLine());
			N = Convert.ToInt32(Console.ReadLine());

			for (int i = 0; i < N + 1; i++)
			{
				result += Math.Pow(A, i);
				Console.Write($"{Math.Pow(A, i)} + ");
			}
			Console.WriteLine($"0 =\n= {result}");
			return true;
		}
		public static bool For38()
		{
			int N;
			double result = 0;
			Console.WriteLine("введите целое число");
			N = Convert.ToInt32(Console.ReadLine());
			for (int i = 1; i < N + 1; i++, Console.Write(" + "))
			{
				result += Math.Pow(i, N - i);
				Console.Write($"{Math.Pow(i, N - i)}");
			}
			Console.WriteLine($"= {result}");
			return true;
		}
		public static bool While26()
		{
			int N, buff, a = 1, b = 1;
			Console.WriteLine("введите целое число");
			N = Convert.ToInt32(Console.ReadLine());

			//ноль и единица не проверяются
			switch (N)
			{
				case 0:
					Console.WriteLine($"число стоящее: до числа {N} в ряде чисел Фибоначчи - {0}; после числа {N} в ряде чисел Фибоначчи - {1}");
					return false;
				case 1:
					Console.WriteLine($"число стоящее: до числа {N} в ряде чисел Фибоначчи - {0}; после числа {N} в ряде чисел Фибоначчи - {1}");
					return false;
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
				return false;
			}
			Console.WriteLine($"число стоящее: до числа {N} в ряде чисел Фибоначчи - {a}; после числа {N} в ряде чисел Фибоначчи - {a + b}");
			return true;
		}
		public static bool While28()
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
			return true;
		}
		public static bool Minmax25()
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
			return true;
		}
		public static bool Array16()
		{
			int[] mass;
			Console.WriteLine("введите размер массива, а затем его элементы поочередно");
			int size = Convert.ToInt32(Console.ReadLine());
			mass = new int[size];
			for (int i = 0; i < size; i++)
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

			for (int i = 0; i < size; i++)
			{
				Console.Write($"{mass[Math.Abs((size - 1) * (i % 2) - i / 2)]}\t");
			}
			return true;
		}
		public static bool Array41()
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
			return true;
		}

		public void Start()
        {
            homework.addTask("Case 10", "Робот  может  перемещаться  в  четырех  направлениях  («С»  —  север, «З»  —  запад,  «Ю»  —  юг,  «В»  —  восток)  и принимать  три цифровые  ко - манды:  0  —  продолжать движение,  1  —  поворот налево,     1  —  поворот направо. Дан символ C — исходноенаправление робота и целое число N— посланная ему команда.Вывести направление робота после выполне - ния полученной команды.", 
				Case10);
            homework.addTask("Case 15", "Мастям  игральных  карт  присвоены  порядковые  номера:  1  —  пики, 2  —  трефы,  3  —  бубны, 4  —  червы.Достоинству  карт, старших  десятки, присвоены номера: 11 — валет, 12 — дама, 13 — король, 14 — туз.Даны два  целых  числа: N  —  достоинство(6       N       14)  и  M  —  масть  карты(1      M      4).Вывести название соответствующей карты вида «шестерка бубен»,«дама червей», «туз треф» и т.п.", 
				Case15);
            homework.addTask("For 17", "Дано  вещественное  число  A  и  целое  число  N  (> 0).  Используя  один цикл, найти сумму 1 + A + A² +A³ + . . . + AN.", 
				For17);
            homework.addTask("For 38", "Дано целое число N  (> 0). Найти сумму 1N + 2N−¹ + . . . + N ¹.Чтобы  избежать  целочисленного  переполнения, вычислять  слагаемые этой  суммы  с  помощьювещественной  переменной  и  выводить  резуль - тат как вещественное число.", 
				For38);
            homework.addTask("While 26", "Дано целое число N  (> 1), являющееся числом Фибоначчи: N  = FK (определение  чисел   Фибоначчи  дано  в  задании  While24).Найти  целые числа FK−₁ и FK₊₁ — предыдущее и последующее числа Фибоначчи. ", 
				While26);
            homework.addTask("While 28", "Дано вещественное число ε (> 0). Последовательность вещественных чисел AK определяется  следующим образом: A₁  = 2, AK = 2 + 1 / AK−₁, K = 2, 3, . . . . Найти   первый   из   номеров   K, для   которых   выполняется   условие | AK − AK−₁| < ε, и вывести этот номер, а также числа AK−₁  и AK. ", 
				While28);
            homework.addTask("Minmax 25", "Дано  целое  число  N  (> 1)  и  набор  из  N  чисел.  Найти  номера двух соседних чисел из данного набора, произведение которых является минимальным, и вывести вначале меньший, а затем больший номер. ", 
				Minmax25);
            homework.addTask("Array 16", "Дан массив A размера N. Вывести его элементы в следующем порядке: A₁, AN, A₂, AN−₁, A₃, AN−₂,    . . . .", 
				Array16);
            homework.addTask("Array 41", "Дан массив размера N.Найти два соседних элемента, сумма которых максимальна, и вывести эти элементы в порядке возрастания их индексов. ", 
				Array41);
>>>>>>> 03.04
            homework.Start();
        }
    }
}
