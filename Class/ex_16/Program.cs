using Quiz;
using System;
using System.Linq;
using System.Text;
using User;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Welcome to the Quiz App!");
            while (true)
            {
                Console.WriteLine("\n1. Register\n2. Login\n3. Exit");
                Console.Write("Select an option: ");
                var choice = Console.ReadLine();

                if (choice == "1")
                {
                    Register();
                }
                else if (choice == "2")
                {
                    var user = Login();
                    if (user != null)
                    {
                        UserMenu(user);
                    }
                }
                else if (choice == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option. Please try again.");
                }
            }
        }

        static void Register()
        {
            Console.Write("Enter username: ");
            var username = Console.ReadLine();
            Console.Write("Enter password: ");
            var password = Console.ReadLine();
            Console.Write("Enter date of birth (yyyy-mm-dd): ");
            try
            {
                var dob = DateTime.Parse(Console.ReadLine());
                if (UserManager.Register(username, password, dob))
                {
                    Console.WriteLine("Registration successful!");
                }
                else
                {
                    Console.WriteLine("Username already exists. Please try again.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong date format");
            }
        }

        static User.User Login()
        {
            Console.Write("Enter username: ");
            var username = Console.ReadLine();
            Console.Write("Enter password: ");
            var password = Console.ReadLine();

            var user = UserManager.Login(username, password);
            if (user != null)
            {
                Console.WriteLine("Login successful!");
                return user;
            }
            else
            {
                Console.WriteLine("Invalid username or password. Please try again.");
                return null;
            }
        }

        static void UserMenu(User.User user)
        {
            while (true)
            {
                Console.WriteLine($"\nWelcome, {user.Login}!");
                Console.WriteLine("1. Start new quiz\n2. View quiz results\n3. View top 20 results\n4. Add new quiz\n5. Change password\n6. Change date of birth\n7. Logout");
                Console.Write("Select an option: ");
                var choice = Console.ReadLine();

                if (choice == "1")
                {
                    StartQuiz(user);
                }
                else if (choice == "2")
                {
                    ViewResults(user);
                }
                else if (choice == "3")
                {
                    ViewTop20Results();
                }
                else if (choice == "4")
                {
                    AddQuiz();
                }
                else if (choice == "5")
                {
                    ChangePassword(user);
                }
                else if (choice == "6")
                {
                    ChangeDateOfBirth(user);
                }
                else if (choice == "7")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option. Please try again.");
                }
            }
        }

        static void StartQuiz(User.User user)
        {
            var quizzes = QuizManager.GetQuizzes();
            if (quizzes.Count == 0)
            {
                Console.WriteLine("There are no quizzes :(");
                return;
            }

            Console.WriteLine($"Available {quizzes.Count} quizzes: ");
            for (int i = 0; i < quizzes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {quizzes[i].Name}");
            }
            Console.Write("Select a quiz: ");
            int ch = int.Parse(Console.ReadLine()) - 1;
            if (ch < 0 || ch >= quizzes.Count)
            {
                Console.WriteLine("Wrong choice");
                return;
            }
            var quiz = quizzes[ch];
            int correctAnswers = 0;

            foreach (var question in quiz.Questions)
            {
                Console.WriteLine(question.Text);
                for (int i = 0; i < question.Options.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {question.Options[i]}");
                }

                Console.Write("Enter your answer(s) as comma-separated numbers (e.g., 1,3): ");
                var userAnswers = Console.ReadLine().Split(',').Select(int.Parse).ToList();

                if (userAnswers.SequenceEqual(question.Answers))
                {
                    correctAnswers++;
                }
            }

            Console.WriteLine($"You answered {correctAnswers} out of {quiz.Questions.Count} questions correctly.");
            QuizManager.SaveResult(user.Login, quiz.Name, correctAnswers, quiz.Questions.Count);
        }

        static void ViewResults(User.User user)
        {
            var results = QuizManager.GetResultsForUser(user.Login);
            if (results.Count == 0)
            {
                Console.WriteLine("You have no quiz results.");
                return;
            }

            foreach (var result in results)
            {
                Console.WriteLine($"Quiz: {result.QuizName}, Correct Answers: {result.CorrectAnswers}/{result.TotalQuestions}, Date: {result.Date}");
            }
        }

        static void ViewTop20Results()
        {
            Console.Write("Enter quiz name to view top 20 results: ");
            var quizName = Console.ReadLine();
            var topResults = QuizManager.GetTop20Results(quizName);

            if (topResults.Count == 0)
            {
                Console.WriteLine("No results found for this quiz.");
                return;
            }

            foreach (var result in topResults)
            {
                Console.WriteLine($"User: {result.Username}, Correct Answers: {result.CorrectAnswers}/{result.TotalQuestions}, Date: {result.Date}");
            }
        }

        static void AddQuiz()
        {
            Console.Write("Enter quiz name: ");
            var quizName = Console.ReadLine();
            var quiz = new Quiz.Quiz(quizName);

            while (true)
            {
                Console.Write("Enter question text: ");
                var questionText = Console.ReadLine();

                Console.Write("Enter options separated by commas: ");
                var options = Console.ReadLine().Split(',').ToList();

                Console.Write("Enter correct answer indices separated by commas (e.g., 1,3): ");
                var correctAnswers = Console.ReadLine().Split(',').Select(int.Parse).ToList();

                var question = new Question(questionText, options, correctAnswers);
                quiz.Questions.Add(question);

                Console.Write("Do you want to add another question? (yes/no): ");
                if (Console.ReadLine().ToLower() != "yes")
                {
                    break;
                }
            }

            QuizManager.AddQuiz(quiz);
            Console.WriteLine("Quiz added successfully!");
        }

        static void ChangePassword(User.User user)
        {
            Console.Write("Enter current password: ");
            var currentPassword = Console.ReadLine();
            Console.Write("Enter new password: ");
            var newPassword = Console.ReadLine();

            if (UserManager.ChangePassword(user.Login, currentPassword, newPassword))
            {
                Console.WriteLine("Password changed successfully!");
            }
            else
            {
                Console.WriteLine("Error changing password. Please try again.");
            }
        }

        static void ChangeDateOfBirth(User.User user)
        {
            Console.Write("Enter current password: ");
            var currentPassword = Console.ReadLine();
            Console.Write("Enter new date of birth (yyyy-mm-dd): ");
            try
            {
                var newDob = DateTime.Parse(Console.ReadLine());
                if (UserManager.ChangeDateOfBirth(user.Login, newDob))
                {
                    Console.WriteLine("Date of birth changed successfully!");
                }
                else
                {
                    Console.WriteLine("Error changing date of birth. Please try again.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong date format");
            }
        }
    }
}
