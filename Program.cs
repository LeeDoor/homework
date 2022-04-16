
/// <summary>
/// как пользоваться программой
/// в классе HomeworkManager пишутся решения задач в качестве функций класса
/// в функции Start с помощью homework.addTask() добавляются задачи в программу. 
/// функция addTask получает три аргумента: название задачи, условие задачи и указатель на функцию ее решения
/// и так повторить с каждой задачей
/// ...
/// </summary>

using learn;
public static class Program
{
	private static void Main()
	{
		HomeworkManager a = new HomeworkManager();
		a.Start();
	}
}