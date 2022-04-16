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

        public bool PochesatPisu()
        {
            Console.WriteLine("vi pochesali pisu");
            return true;
        }

        public void Start()
        {
            homework.addTask("piska", "otobrazite pisku", PochesatPisu);
            homework.Start();
        }
    }
}
