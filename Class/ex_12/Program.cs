using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_12
{
    class Manager
    {
        private Dictionary<string, string> loginData = new Dictionary<string, string>();
        public void Add(string username, string password)
        {
            if (loginData.ContainsKey(username))
            {
                Console.WriteLine("Sorry, user with that name already exists :(");
            }
            else
            {
                loginData.Add(username, password);
            }
        }
        public void Remove(string username, string password)
        {
            if (loginData.ContainsKey(username) && loginData[username] == password)
            {
                loginData.Remove(username);
            }
            else
            {
                Console.WriteLine("Wrong username or password");
            }
        }
        public void Update(string username, string password, string newpassword)
        {
            if (loginData.ContainsKey(username) && loginData[username] == password)
            {
                loginData[username] = newpassword;
            }
            else
            {
                Console.WriteLine("Wrong username or password");
            }
        }
        public void GetDataByLogin(string username)
        {
            if (loginData.ContainsKey(username)) Console.WriteLine($"Username: {username}\tPassword: {loginData[username]}");
        }
        public void Display()
        {
            Console.WriteLine();
            foreach (var key in loginData)
            {
                Console.WriteLine($"Username: {key.Key}\tPassword: {key.Value}");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            manager.Add("Bob", "1234");
            manager.Add("Bob2", "124");
            manager.Add("Bob3", "124");
            manager.Add("Bob4", "124");
            manager.Add("Bob5", "124");
            manager.Add("Bob6", "124");
            manager.Display();
            manager.Remove("Bob", "1234");
            manager.Update("Bob4", "124", "4444");
            manager.Display();
            manager.GetDataByLogin("Bob6");
        }
    }
}
