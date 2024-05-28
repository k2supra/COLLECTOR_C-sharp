using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_6
{
    class Device
    {
        public string Name {  get; set; }
        public virtual void sound() { }
        public virtual void show() { }
        public virtual void desc() { }
    }
    class Teapot : Device
    {
        public Teapot(string name) { Name = name; }
        public override void sound()
        {
            Console.WriteLine($"{this.Name} makes sound");
        }
        public override void show() { Console.WriteLine("Teapot is showing"); this.sound(); this.desc(); }
        public override void desc() { Console.WriteLine("Teapot made of steel"); }
    }
    class Microwave : Device
    {
        public Microwave(string name) { Name = name; }
        public override void sound()
        {
            Console.WriteLine($"{this.Name} makes sound");
        }
        public override void show() { Console.WriteLine("Microwave is showing"); this.sound(); this.desc(); }
        public override void desc() { Console.WriteLine("Microwave made of steel"); }
    }
    class Car : Device
    {
        public Car(string name) { Name = name; }
        public override void sound()
        {
            Console.WriteLine($"{this.Name} makes sound");
        }
        public override void show() { Console.WriteLine("Car is showing"); this.sound(); this.desc(); }
        public override void desc() { Console.WriteLine("Car made of steel"); }
    }
    class Boat : Device
    {
        public Boat(string name) { Name = name; }
        public override void sound()
        {
            Console.WriteLine($"{this.Name} makes sound");
        }
        public override void show() { Console.WriteLine("Car is showing"); this.sound(); this.desc(); }
        public override void desc() { Console.WriteLine("Car made of carbon"); }
    }

    class MusicInstrument
    {
        public string Sound { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string History {  get; set; }
        public MusicInstrument(string name, string desc, string sound, string hist) 
        {
            Name = name;
            Desc = desc;
            History = hist;
            Sound = sound;
        }
        private void sound() { Console.WriteLine(Sound); }
        private void desc() { Console.WriteLine(Desc); }
        public virtual void show() { Console.WriteLine(Name); this.sound(); this.desc(); Console.WriteLine(History + "\n"); }
    }
    class Violin : MusicInstrument
    {
        public Violin(string name, string desc, string sound, string hist) : base(name, desc, sound, hist) { }
        public override void show()
        {
            base.show();
        }
    }
    class Trombone : MusicInstrument
    {
        public Trombone(string name, string desc, string sound, string hist) : base(name, desc, sound, hist) { }
        public override void show()
        {
            base.show();
        }
    }
    class Triangle : MusicInstrument
    {
        public Triangle(string name, string desc, string sound, string hist) : base(name, desc, sound, hist) { }
        public override void show()
        {
            base.show();
        }
    }
    class Cello : MusicInstrument
    {
        public Cello(string name, string desc, string sound, string hist) : base(name, desc, sound, hist) { }
        public override void show()
        {
            base.show();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Device[] devices = new Device[4]
            {
                new Teapot("Bosch"),
                new Microwave("Omega"),
                new Car("Ford"),
                new Boat("Lamborghini")
            };
            foreach (var item in devices)
            {
                item.show();
                Console.WriteLine();
            }
            Violin violin = new Violin("Violin", "Wooden violin", "tututu", "History");
            violin.show();
            Trombone trombone = new Trombone("Trombone", "Desc of trombone", "TUTUTDUDUDU", "hist of tr");
            trombone.show();
            Triangle triangle = new Triangle("Triangle", "Steel Triangle", "ting ting", "History");
            triangle.show();
            Cello cello = new Cello("Cello", "Desc of Cello", "shink shink", "hist of cello");
            cello.show();
        }
    }
}
