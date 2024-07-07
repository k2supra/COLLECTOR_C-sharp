using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ex_19
{
    [Serializable]
    public class Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public Fraction() { }

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Fraction> fractions = new List<Fraction>();

            while (true)
            {
                Console.WriteLine("\n1. Enter array of fractions\n2. Serialization\n3. Saving to file\n4. Loading\n5. Exit");
                Console.Write("Choose option: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        fractions = InputFractions();
                        break;
                    case "2":
                        SerializeFractions(fractions);
                        break;
                    case "3":
                        SaveFractionsToFile(fractions);
                        break;
                    case "4":
                        fractions = LoadFractionsFromFile();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Wrong choice.");
                        break;
                }
            }
        }

        static List<Fraction> InputFractions()
        {
            List<Fraction> fractions = new List<Fraction>();

            Console.Write("Enter numner of fractions: ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.Write($"Enter numerator {i + 1}: ");
                int numerator = int.Parse(Console.ReadLine());

                Console.Write($"Enter denominator {i + 1}: ");
                int denominator = int.Parse(Console.ReadLine());

                fractions.Add(new Fraction(numerator, denominator));
            }

            return fractions;
        }

        static void SerializeFractions(List<Fraction> fractions)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Fraction>));
            using (StringWriter writer = new StringWriter())
            {
                serializer.Serialize(writer, fractions);
            }
        }

        static void SaveFractionsToFile(List<Fraction> fractions)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Fraction>));
            using (FileStream stream = new FileStream("fractions.xml", FileMode.Create))
            {
                serializer.Serialize(stream, fractions);
            }
            Console.WriteLine("Saved successfully.");
        }

        static List<Fraction> LoadFractionsFromFile()
        {
            if (!File.Exists("fractions.xml"))
            {
                Console.WriteLine("File not found.");
                return new List<Fraction>();
            }

            XmlSerializer serializer = new XmlSerializer(typeof(List<Fraction>));
            using (FileStream stream = new FileStream("fractions.xml", FileMode.Open))
            {
                return (List<Fraction>)serializer.Deserialize(stream);
            }
        }
    }

}
