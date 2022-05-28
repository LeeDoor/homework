using System;
namespace learn
{
    class GroupManager
    {
        private static Group group; // operated group

        static GroupManager()
        {
            group = new Group();
        }
        

        /// <summary>
        /// starts dialog menu
        /// </summary>
        public static void StartDialogMenu()
        {
            char choice = 'M';
            string? enter;
            do
            {
                switch (choice)
                {
                    case 'M':
                    case 'm':
                        Console.WriteLine("M - view options\n" +
                                          "T - show group scores as table\n" +
                                          "S - show average scores with students\n" +
                                          "O - show average scores with subjects\n" +
                                          "G - show average score with whole group\n" +
                                          "L - show least and max scores by subjects\n" +
                                          "Q - leave");
                        break;

                    case 'T':
                    case 't':
                        group.showTable();
                        break;

                    case 'S':
                    case 's':
                        group.showAverageScoreStudents();
                        break;

                    case 'O':
                    case 'o':
                        group.showAverageScoreSubjects();
                        break;

                    case 'G':
                    case 'g':
                        group.showAverageScoreGroup();
                        break;

                    case 'L':
                    case 'l':
                        group.showLessMaxStudents();
                        break;

                    case '\0':
                        break;

                    default:
                        Console.Write("wrong data. try again\n");
                        break;
                }

                Console.Write("enter > ");
                enter = Console.ReadLine();
                choice = enter == null ? 'M' : enter[0];
            } while (choice != 'Q' && choice != 'q');
            Console.WriteLine("see you next time");
        }
    }
}
