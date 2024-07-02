using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace User
{
    [Serializable]
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public User() { }
        public User(string login, string password, DateTime dateOfBirth)
        {
            Login = login;
            Password = password;
            DateOfBirth = dateOfBirth;
        }
    }

    public static class UserManager
    {
        private static string filename = "userdata.xml";
        private static List<User> _users = new List<User>();
        static UserManager() { LoadUsers(); }
        private static void LoadUsers()
        {
            if (File.Exists(filename))
            {
                using (var reader = new StreamReader(filename, Encoding.UTF8))
                {
                    var serialiser = new XmlSerializer(typeof(List<User>));
                    _users = (List<User>)serialiser.Deserialize(reader);
                }
            }
        }
        private static void SaveUsers()
        {
            using (var stream = new StreamWriter(filename, false, Encoding.UTF8))
            {
                var serializer = new XmlSerializer(typeof(List<User>));
                serializer.Serialize(stream, _users);
            }
        }
        public static bool Register(string login, string password, DateTime dayofbirth)
        {
            try
            {
                if (_users.Any(u => u.Login == login)) return false;
                _users.Add(new User { Login = login, Password = password, DateOfBirth = dayofbirth });
                SaveUsers();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + ex.Source);
                throw;
            }

        }
        public static User Login(string login, string password)
        {
            return _users.FirstOrDefault(u => u.Login == login && u.Password == password);
        }
        public static bool ChangePassword(string login, string password, string new_password)
        {
            var user = _users.FirstOrDefault(u => u.Login == login && u.Password == password);
            if (user != null) { user.Password = new_password; SaveUsers(); return true; }
            return false;
        }
        public static bool ChangeDateOfBirth(string login, DateTime newdayofbirth)
        {
            var user = _users.FirstOrDefault(u => u.Login == login);
            if (user != null) { user.DateOfBirth = newdayofbirth; SaveUsers(); return true; }
            return false;
        }
    }
}
