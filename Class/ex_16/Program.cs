using Quiz;
using System;
using System.Collections.Generic;
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

                switch (choice)
                {
                    case "1":
                        Register();
                        break;
                    case "2":
                        var user = Login();
                        if (user != null)
                        {
                            UserMenu(user);
                        }
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
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
                Console.WriteLine("1. Start new quiz\n2. Start mixed quiz\n3. View quiz results\n4. View top 20 results\n5. Change settings\n6. Edit quiz\n7. Logout");
                Console.Write("Select an option: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        StartQuiz(user);
                        break;
                    case "2":
                        StartMixedQuiz(user);
                        break;
                    case "3":
                        // Implement viewing quiz results
                        break;
                    case "4":
                        ViewTop20Results();
                        break;
                    case "5":
                        ChangeSettings(user);
                        break;
                    case "6":
                        EditQuizMenu();
                        break;
                    case "7":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void EditQuizMenu()
        {
            Console.WriteLine("1. Edit quiz name\n2. Edit quiz question");
            Console.Write("Select an option: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    EditQuizName();
                    break;
                case "2":
                    EditQuizQuestion();
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }

        static void EditQuizName()
        {
            Console.Write("Enter current quiz name: ");
            var currentName = Console.ReadLine();
            Console.Write("Enter new quiz name: ");
            var newName = Console.ReadLine();

            QuizManager.EditQuizName(currentName, newName);
            Console.WriteLine("Quiz name updated successfully.");
        }

        static void EditQuizQuestion()
        {
            Console.Write("Enter quiz name: ");
            var quizName = Console.ReadLine();
            var quiz = QuizManager.GetQuizByName(quizName);

            if (quiz == null)
            {
                Console.WriteLine("Quiz not found.");
                return;
            }

            Console.WriteLine($"There are {quiz.Questions.Count} questions in this quiz.");
            Console.Write("Enter the question index to edit (starting from 1): ");
            int questionIndex = int.Parse(Console.ReadLine()) - 1;

            if (questionIndex < 0 || questionIndex >= quiz.Questions.Count)
            {
                Console.WriteLine("Invalid question index.");
                return;
            }

            Console.Write("Enter new question text: ");
            var newText = Console.ReadLine();

            Console.Write("Enter new options separated by commas: ");
            var newOptions = Console.ReadLine().Split(',').ToList();

            Console.Write("Enter new correct answer indices separated by commas (e.g., 1,3): ");
            var newAnswers = Console.ReadLine().Split(',').Select(int.Parse).ToList();

            QuizManager.EditQuestion(quizName, questionIndex, newText, newOptions, newAnswers);
            Console.WriteLine("Question updated successfully.");
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
                var useranswers = Console.ReadLine().Split(',').Select(int.Parse).ToList();

                if (useranswers.SequenceEqual(question.Answers))
                {
                    correctAnswers++;
                }
            }
            Console.WriteLine($"You answered {correctAnswers} out of {quiz.Questions.Count} questions correctly.");
        }

        static void StartMixedQuiz(User.User user)
        {
            Console.Write("Enter the number of questions for the mixed quiz: ");
            int questionCount = int.Parse(Console.ReadLine());

            var questions = QuizManager.GetRandomQuestions(questionCount);
            if (questions.Count == 0)
            {
                Console.WriteLine("No questions available for the mixed quiz.");
                return;
            }

            int correctAnswers = 0;
            foreach (var question in questions)
            {
                Console.WriteLine(question.Text);
                for (int i = 0; i < question.Options.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {question.Options[i]}");
                }

                Console.Write("Enter your answer(s) as comma-separated numbers (e.g., 1,3): ");
                var useranswers = Console.ReadLine().Split(',').Select(int.Parse).ToList();

                if (useranswers.SequenceEqual(question.Answers))
                {
                    correctAnswers++;
                }
            }
            Console.WriteLine($"You answered {correctAnswers} out of {questions.Count} questions correctly.");
        }

        static void ViewTop20Results()
        {
            Console.Write("Enter quiz name to view top 20 results: ");
            var quizName = Console.ReadLine();
            var topResults = QuizManager.GetTop20Results(quizName);

            if (topResults == null)
            {
                Console.WriteLine("No results found for this quiz.");
                return;
            }

            Console.WriteLine("Top 20 Results:");
            for (int i = 0; i < topResults.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {topResults[i].Username} - {topResults[i].CorrectAnswers}");
            }
        }

        static void ChangeSettings(User.User user)
        {
            while (true)
            {
                Console.WriteLine("1. Change password\n2. Change date of birth\n3. Back");
                Console.Write("Select an option: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ChangePassword(user);
                        break;
                    case "2":
                        ChangeDateOfBirth(user);
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void ChangePassword(User.User user)
        {
            Console.Write("Enter current password: ");
            var currentPassword = Console.ReadLine();

            if (currentPassword != user.Password)
            {
                Console.WriteLine("Incorrect current password.");
                return;
            }

            Console.Write("Enter old password: ");
            var oldPassword = Console.ReadLine();
            Console.Write("Enter new password: ");
            var newPassword = Console.ReadLine();

            if (UserManager.ChangePassword(user.Login, oldPassword, newPassword))
            {
                Console.WriteLine("Password changed successfully.");
            }
            else
            {
                Console.WriteLine("Failed to change password.");
            }
        }

        static void ChangeDateOfBirth(User.User user)
        {
            Console.Write("Enter new date of birth (yyyy-mm-dd): ");
            try
            {
                var newDob = DateTime.Parse(Console.ReadLine());
                if (UserManager.ChangeDateOfBirth(user.Login, newDob))
                {
                    Console.WriteLine("Date of birth changed successfully.");
                }
                else
                {
                    Console.WriteLine("Failed to change date of birth.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid date format.");
            }
        }
    }
}
