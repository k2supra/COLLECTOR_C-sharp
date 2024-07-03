using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace Quiz
{
    [Serializable]
    public class Question
    {
        public string Text { get; set; }
        public List<string> Options { get; set; }
        public List<int> Answers { get; set; }
        public Question() { }
        public Question(string text, List<string> options, List<int> answers)
        {
            Text = text;
            Options = options;
            Answers = answers;
        }
    }
    [Serializable]
    public class Quiz
    {
        public string Name { get; set; }
        public List<Question> Questions { get; set; }
        public Quiz() { }
        public Quiz(string name)
        {
            Name = name;
            Questions = new List<Question>();
        }
    }
    [Serializable]
    public class QuizResult
    {
        public string Username { get; set; }
        public string QuizName { get; set; }
        public int CorrectAnswers { get; set; }
        public int TotalQuestions { get; set; }
        public DateTime Date { get; set; }
    }
    public static class QuizManager
    {
        private static readonly string filename = "quizmanager.xml";
        private static readonly string resultsFilename = "quizresults.xml";
        private static List<Quiz> _quizzes = new List<Quiz>();
        private static List<QuizResult> _results = new List<QuizResult>();
        static QuizManager() { LoadQuizzes(); LoadResults(); }
        private static void SaveQuizzes()
        {
            using (var writer = File.OpenWrite(filename))
            {
                var serializer = new XmlSerializer(typeof(List<Quiz>));
                serializer.Serialize(writer, _quizzes);
            }
        }
        private static void LoadQuizzes()
        {
            if (File.Exists(filename))
            {
                using (var reader = File.OpenRead(filename))
                {
                    var serializer = new XmlSerializer(typeof(List<Quiz>));
                    _quizzes = (List<Quiz>)serializer.Deserialize(reader);
                }
            }
        }
        private static void SaveResults()
        {
            using (var writer = File.OpenWrite(resultsFilename))
            {
                var serializer = new XmlSerializer(typeof(List<QuizResult>));
                serializer.Serialize(writer, _results);
            }
        }
        private static void LoadResults()
        {
            if (File.Exists(resultsFilename))
            {
                using (var reader = File.OpenRead(resultsFilename))
                {
                    var serializer = new XmlSerializer(typeof(List<QuizResult>));
                    _results = (List<QuizResult>)serializer.Deserialize(reader);
                }
            }
        }
        public static void AddQuiz(Quiz quiz)
        {
            _quizzes.Add(quiz);
            SaveQuizzes();
        }
        public static List<Quiz> GetQuizzes()
        {
            return _quizzes;
        }
        public static Quiz GetQuizByName(string name)
        {
            return _quizzes.First(q =>  q.Name == name);
        }
        public static List<Question> GetRandomQuestions(int count)
        {
            Random random = new Random();
            return _quizzes.SelectMany(q => q.Questions)
                           .OrderBy(q => random.Next())
                           .Take(count)
                           .ToList();
        }
        public static void EditQuizName(string oldname, string newname)
        {
            var quiz = _quizzes.FirstOrDefault(q => q.Name == oldname);
            if (quiz != null) { quiz.Name = newname; SaveQuizzes(); }
        }
        public static void EditQuestion(string quizName, int questionIndex, string newText, List<string> newOptions, List<int> newAnswers)
        {
            var quiz = _quizzes.FirstOrDefault(q => q.Name == quizName);
            if (quiz != null && questionIndex >= 0 && questionIndex < quiz.Questions.Count)
            {
                quiz.Questions[questionIndex].Text = newText;
                quiz.Questions[questionIndex].Options = newOptions;
                quiz.Questions[questionIndex].Answers = newAnswers;
                SaveQuizzes();
            }
        }
        public static void SaveResult(string username, string quizName, int correctAnswers, int totalQuestions)
        {
            _results.Add(new QuizResult
            {
                Username = username,
                QuizName = quizName,
                CorrectAnswers = correctAnswers,
                TotalQuestions = totalQuestions,
                Date = DateTime.Now
            });
            SaveResults();
        }
        public static List<QuizResult> GetResultsForUser(string username)
        {
            return _results.Where(r => r.Username == username).ToList();
        }

        public static List<QuizResult> GetTop20Results(string quizName)
        {
            return _results
                .Where(r => r.QuizName == quizName)
                .OrderByDescending(r => (double)r.CorrectAnswers / r.TotalQuestions)
                .ThenBy(r => r.Date)
                .Take(20)
                .ToList();
        }
    }
}
