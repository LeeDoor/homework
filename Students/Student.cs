using System;

namespace learn
{
    /// <summary>
    /// describes a score
    /// </summary>
    public struct Score
    {
        public int value; // score
        public Subject subject; // subject

        public Score(int value, Subject subject) : this()
        {
            this.value = value;
            this.subject = subject;
        }
    }

    /// <summary>
    /// this class describes the student
    /// </summary>
    public class Student
    {
        // list of names for random generation
        private static readonly string[] NAMES = new string[] { 
            "Anton", "Serega", "Volodya", "Ivan", "Andrey", 
            "Nastya", "Anya", "Vika", "Alexa" 
        };
        public string _name; // student's name
        public Score[] _scores; // list of scores

        /// <summary>
        /// random constructor
        /// </summary>
        /// <param name="subjects">list of subjects</param>
        public Student(Subject[] subjects)
        {
            randomFill(subjects);
        }

        public Student(string name, Subject[] subjects)
        {
            _name = name;
            _scores = getRandomScores(subjects);
        }
        public Student (string name, Score[] scores)
        {
            _name = name;
            _scores = scores;
        }

        /// <summary>
        /// function to randomly fill name and scores
        /// </summary>
        /// <param name="subjects">list of subjects</param>
        public void randomFill(Subject[] subjects)
        {
            _name = getRandomName();

            _scores = getRandomScores(subjects);
        }

        /// <summary>
        /// get random name from list
        /// </summary>
        /// <returns></returns>
        private string getRandomName()
        {
            int NamesSize = NAMES.Length; // size of names list

            Random random = new Random();
            return NAMES[random.Next(NamesSize)]; // setting random name
        }


        /// </summary>
        /// <param name="subjects"></param>
        /// <returns></returns>
        private Score[] getRandomScores(Subject[] subjects)
        {
            Random random = new Random(); // random module
            int subjectsSize = subjects.Length; // amount of subjects
            Score[] score = new Score[subjectsSize]; // new list of student's scores
            for(int i = 0; i < subjectsSize; i++)
            {
                score[i] = new Score(random.Next(4)+2, subjects[i]); // for every subject we are creating a score
            }
            return score;
        }

        /// <summary>
        /// get a score based on subject name
        /// </summary>
        /// <param name="subject">name of subject</param>
        /// <returns>score of given subject</returns>
        public int getScore(Subject subject)
        {
            foreach (var score in _scores)
            {
                if (score.subject == subject)
                {
                    return score.value;
                }
            }
            throw new NullReferenceException();
        }

        /// <summary>
        /// get average score of student
        /// </summary>
        /// <returns>returns average score</returns>
        public float getAverageScore()
        {
            float sum = 0;
            int amount = 0;
            foreach (var score in _scores)
            {
                sum += score.value;
                amount++;
            }
            return sum / amount;
        }
    }
}
