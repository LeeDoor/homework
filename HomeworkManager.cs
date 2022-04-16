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

        public bool SomeTestHomeworkFunc()
        {
            Console.WriteLine("Some staff happens here");
            return true;
        }

        /// <summary>
        /// сдесь все созданные задачи добавляются в список в классе Homework и программа запускается
        /// </summary>
        public void Start()
        {
            homework.addTask("test task", "kakoe to uslovie dla zadachi", SomeTestHomeworkFunc);
            homework.Start();
        }
    }
}
