using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    /// <summary>
    /// counts down the time from the moment of launch
    /// </summary>
    public class Timer
    {
        /// <summary>
        /// stores the startup time
        /// </summary>
        private DateTime start;

        /// <summary>
        /// is timer launched
        /// </summary>
        private bool isRunning = false;

        /// <summary>
        /// timer start function
        /// </summary>
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

        /// <summary>
        /// starting the timer
        /// </summary>
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

            // split into two threads
            Thread charReading = new Thread(Asking); // additional thread waits for user's type
            charReading.Start();

            //main thread shows timer info
            show();
        }


        /// <summary>
        /// function draws timer info
        /// </summary>
        public void show()
        {

            while (isRunning)
            {
                var timerBuff = DateTime.Now.Subtract(start);
                if (timerBuff.Milliseconds == 0)
                {
                    Console.Clear();
                    Console.Write(timerBuff.Hours + "h : " + 
                        timerBuff.Minutes + "m : " + 
                        timerBuff.Seconds + "s" +
                        "1 - stop");
                }
            }
            Console.Clear();
            Console.WriteLine(DateTime.Now.Subtract(start));
        }

        /// <summary>
        /// function waiting for user's choice
        /// </summary>
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
