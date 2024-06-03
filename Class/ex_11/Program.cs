using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_11
{
    struct RGB
    {
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
        public RGB(int red, int green, int blue) {  Red = red; Green = green; Blue = blue; }

        public string ToHex()
        {
            return $"#{Red:X2}{Green:X2}{Blue:X2}";
        }
        public string ToHSL()
        {
            double r = this.Red / 255.0;
            double g = this.Green / 255.0;
            double b = this.Blue / 255.0;

            double max = Math.Max(r, Math.Max(g, b));
            double min = Math.Min(r, Math.Min(g, b));
            double delta = max - min;

            double h = 0;
            if (delta != 0)
            {
                if (max == r)
                {
                    h = (g - b) / delta;
                }
                else if (max == g)
                {
                    h = 2 + (b - r) / delta;
                }
                else
                {
                    h = 4 + (r - g) / delta;
                }
                h *= 60;
                if (h < 0) { h += 360; }
            }
            double l = (max + min) / 2;
            double s = (delta == 0) ? 0 : delta / (1 - Math.Abs(2 * l - 1));

            return $"H ={h:F2}°, S ={s * 100:F2}%, L ={l * 100:F2}%";
        }
        public string ToCMYK()
        {
            double r = Red / 255.0;
            double g = Green / 255.0;
            double b = Blue / 255.0;

            double k = 1 - Math.Max(r, Math.Max(g, b));
            double c = (1 - r - k) / (1 - k);
            double m = (1 - g - k) / (1 - k);
            double y = (1 - b - k) / (1 - k);

            if (k == 1)
            {
                c = 0;
                m = 0;
                y = 0;
            }

            return $"C ={c * 100:F2}%, M ={m * 100:F2}%, Y ={y * 100:F2}%, K ={k * 100:F2}% ";
        }

        public override string ToString()
        {
            return $"RGB({Red}, {Green}, {Blue})";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            RGB color = new RGB(255, 99, 71);

            string hex = color.ToHex();
            var hsl = color.ToHSL();
            var cmyk = color.ToCMYK();

            Console.WriteLine($"RGB: {color}");
            Console.WriteLine($"HEX: {hex}");
            Console.WriteLine($"HSL: {hsl}");
            Console.WriteLine($"CMYK: {cmyk}");
        }
    }
}
