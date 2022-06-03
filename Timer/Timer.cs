using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    public class Timer
    {
        private DateTime start;
        private bool isRunning = false;

        public void Start()
        {
            bool isWorking = true;

            while (isWorking)
            {
                Console.WriteLine(
                    "1 - start timer\n" +
                    "2 - quit");
                char choice = Console.ReadKey().KeyChar;
                switch (choice)
                {
                    case '1':
                        Run();
                        break;
                    case '2':
                        isWorking = false;
                        break;
                    default:
                        Console.WriteLine("wrong data. try again\n\n");
                        break;
                }
            }
        }

        private void Run()
        {
            DateTime current = DateTime.Now;
            start = new DateTime(
                current.Year,
                current.Month,
                current.Day,
                current.Hour,
                current.Minute,
                current.Second);
            isRunning = true;
            show();
        }

        public void show()
        {
            Thread charReading = new Thread(Asking);
            charReading.Start();

            while (isRunning)
            {
                var timerBuff = DateTime.Now.Subtract(start);
                if (timerBuff.Milliseconds == 0)
                {
                    Console.Clear();
                    Console.WriteLine(timerBuff.Hours + "h : " + timerBuff.Minutes + "m : " + timerBuff.Seconds + "s\n" +
                        "1 - stop");
                }
            }
            Console.Clear();
            Console.WriteLine(DateTime.Now.Subtract(start));
        }

        private void Asking()
        {
            while (isRunning)
            {
                char choice = Console.ReadKey().KeyChar;
                switch (choice)
                {
                    case '1':
                        isRunning = false;
                        break;
                }
            }
        }
    }
}
