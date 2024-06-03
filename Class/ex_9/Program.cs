using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_9
{
    struct Vector3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public Vector3D(double x, double y, double z) {  X = x; Y = y; Z = z; }

        public static Vector3D Multiply(Vector3D v, double number) { return new Vector3D(v.X * number, v.Y * number, v.Z * number); }
        public static Vector3D Divide(Vector3D v, double number) { return new Vector3D(v.X / number, v.Y / number, v.Z / number); }
        public static Vector3D Add(Vector3D v1, Vector3D v2) { return new Vector3D(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z); }
        public static Vector3D Subtract(Vector3D v1, Vector3D v2) { return new Vector3D(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z); }
        public override string ToString()
        {
            return $"{this.X}   {this.Y}   {this.Z}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector3D v1 = new Vector3D(5.2, 3.1, 1.0);
            Vector3D v2 = new Vector3D(1.2, 5.2, 0.7);
            Vector3D v3 = Vector3D.Add(v1, v2);
            Vector3D v4 = Vector3D.Subtract(v1, v2);
            Vector3D v5 = Vector3D.Multiply(v1, 5);
            Vector3D v6 = Vector3D.Multiply(v1, 3);
            Console.WriteLine($"V1 + V2 = {v3}");
            Console.WriteLine($"V1 - V2 = {v4}");
            Console.WriteLine($"V1 * 5 = {v5}");
            Console.WriteLine($"V1 / 3 = {v6}");
        }
    }
}
