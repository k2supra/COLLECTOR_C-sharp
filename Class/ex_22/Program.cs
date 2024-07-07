using Bogus;
using log4net;
using log4net.Config;
using Serilog;
using System;

namespace ex_22
{
    public class FakeUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }

    public class FakeUserGenerator
    {
        public FakeUser GenerateFakeUser()
        {
            var faker = new Faker<FakeUser>()
                .RuleFor(u => u.FirstName, f => f.Name.FirstName())
                .RuleFor(u => u.LastName, f => f.Name.LastName())
                .RuleFor(u => u.PhoneNumber, f => f.Phone.PhoneNumber())
                .RuleFor(u => u.Email, f => f.Internet.Email())
                .RuleFor(u => u.Address, f => f.Address.FullAddress());

            return faker.Generate();
        }
    }
    class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            BasicConfigurator.Configure();

            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();

            Log.Information("Start");
            var userGenerator = new FakeUserGenerator();
            for (int i = 0; i < 10; i++)
            {
                var user = userGenerator.GenerateFakeUser();
                Log.Information("Generated user: {User}", user);
                Console.WriteLine($"Name: {user.FirstName} {user.LastName}");
                Console.WriteLine($"Phone: {user.PhoneNumber}");
                Console.WriteLine($"Email: {user.Email}");
                Console.WriteLine($"Address: {user.Address}");
                Console.WriteLine();
            }

            Log.Information("Application finished");

            log.Info("\n\nLog4net start"); 

            var userGenerator2 = new FakeUserGenerator();
            for (int i = 0; i < 3; i++)
            {
                var user = userGenerator.GenerateFakeUser(); 
                log.Info("Generated user:");
                Console.WriteLine($"Name: {user.FirstName} {user.LastName}");
                Console.WriteLine($"Phone: {user.PhoneNumber}");
                Console.WriteLine($"Email: {user.Email}");
                Console.WriteLine($"Address: {user.Address}");
                Console.WriteLine();
            }
            log.Info("Log4net finished");
        }
    }
}
