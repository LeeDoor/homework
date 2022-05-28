using System;
namespace learn
{
    public class Group
    {// list of group titles for random generation
        private static readonly string[] NAMES = new string[] {
            "BV-111", "AG-100", "EpicGroup Name", "ULTRARARE GROUP NAME", "bad name"
        };
        public string _name;
        public Student[] _students;
        public Subject[] _subjects;

        /// <summary>
        /// default constructor
        /// </summary>
        public Group()
        {
            _name = getRandomTitle();
            _subjects = getRandomSubjects();
            _students = getRandomStudents(_subjects);
        }

        /// <summary>
        /// gets random title from list
        /// </summary>
        /// <returns></returns>
        public string getRandomTitle()
        {
            int size = NAMES.Length;
            Random random = new Random();
            return NAMES[random.Next(size)];
        }

        /// <summary>
        /// creates random subjects
        /// </summary>
        /// <returns></returns>
        public Subject[] getRandomSubjects()
        {
            Random random = new Random();
            int subjectsSize = random.Next(1, 6);
            Subject[] subjects = new Subject[subjectsSize];


            for (int i = 0; i < subjectsSize; i++)
            {
                subjects[i] = new Subject();
            }

            return subjects;
        }

        /// <summary>
        /// creates random students
        /// </summary>
        /// <param name="subjects">created subjects</param>
        /// <returns></returns>
        public Student[] getRandomStudents(Subject[] subjects)
        {
            Random random = new Random();
            int studentSize = random.Next(3, 5);
            Student[] students = new Student[studentSize];
            for (int i = 0; i < studentSize; i++)
            {
                students[i] = new Student(subjects);
            }
            return students;
        }

        /// <summary>
        /// shows data as a table
        /// </summary>
        public void showTable()
        {
            int SubjectSize, studentSize;
            SubjectSize = _subjects.Length;
            studentSize = _students.Length;
            Console.Write("\t");
            foreach (var subject in _subjects)
            {
                Console.Write($"\t{subject._name}");
            }

            for (int stud = 0; stud < studentSize; stud++)
            {
                Console.Write($"\n{_students[stud]._name}\t\t");
                for (int subj = 0; subj < SubjectSize; subj++)
                {
                    Console.Write($"{_students[stud].getScore(_subjects[subj])}\t");
                }
            }
            Console.WriteLine();
        }

        /// <summary>
        /// shows average scores of students
        /// </summary>
        public void showAverageScoreStudents()
        {
            foreach(var student in _students)
            {
                Console.WriteLine($"{student._name}'s average score: {student.getAverageScore()}");
            }
        }

        /// <summary>
        /// shows average scores of subjects
        /// </summary>
        public void showAverageScoreSubjects()
        {
            foreach (var subject in _subjects)
            {
                Console.WriteLine($"average score in {subject._name}: {getAverageScoreOfSubject(subject)}");
            }
        }

        /// <summary>
        /// shows average score of subject
        /// </summary>
        /// <param name="subject">subject we want to see</param>
        /// <returns>average score of given subject</returns>
        public float getAverageScoreOfSubject(Subject subject)
        {
            float sum = 0;
            int amount = 0;

            foreach(var student in _students)
            {
                sum += student.getScore(subject);
                amount++;
            }
            return sum / amount;
        }

        /// <summary>
        /// shows average score of whole group on every subject
        /// </summary>
        public void showAverageScoreGroup()
        {
            float sum = 0;
            int amount = 0;
            foreach(var student in _students)
            {
                sum += student.getAverageScore();
                amount++;
            }

            Console.WriteLine($"average score of {_name} group is: {sum/amount}");
        }

        /// <summary>
        /// shows students with least and best scores in subjects
        /// </summary>
        public void showLessMaxStudents()
        {
            foreach(var subject in _subjects)
            {
                Student loh = getStudentWithLeastScore(subject);
                Student krasava = getStudentWithMaxScore(subject);
                Console.WriteLine($"student with lowest score in {subject._name} is {loh._name} with {loh.getScore(subject)}");
                Console.WriteLine($"student with highest score in {subject._name} is {krasava._name} with {krasava.getScore(subject)}\n\n");
            }
        }

        /// <summary>
        /// get student with worst score in subject
        /// </summary>
        /// <param name="subject">given subject</param>
        /// <returns>returns student with worst score</returns>
        public Student getStudentWithLeastScore(Subject subject)
        {
            Student min = _students[0];
            foreach(var student in _students)
            {
                if (student.getScore(subject) < min.getScore(subject))
                    min = student;
            }
            return min;
        }

        /// <summary>
        /// get student with best score in subject
        /// </summary>
        /// <param name="subject">given subject</param>
        /// <returns>returns student with best score</returns>
        public Student getStudentWithMaxScore(Subject subject)
        {
            Student max = _students[0];
            foreach (var student in _students)
            {
                if (student.getScore(subject) > max.getScore(subject))
                    max = student;
            }
            return max;
        }
    }
}
