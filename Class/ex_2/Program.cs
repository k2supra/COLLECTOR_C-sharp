using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_2
{
    class Magazine
    {
        private string name;
        private int year;
        private string description;
        private string phone;
        private string gmail;
        public Magazine(string name, int year, string description, string phone, string gmail) 
        {
            this.name = name;
            this.year = year;
            this.description = description;
            this.phone = phone;
            this.gmail = gmail;
        }

        public void setName(string name) { this.name = name;}
        public void setYear(int year) {  this.year = year;}
        public void setDescription(string description) {  this.description = description;}
        public void setPhone(string phone) {  this.phone = phone;}
        public void setGmail(string gmail) {  this.gmail = gmail;}

        public string getName() { return name;}
        public int getYear() { return year;}
        public string getDescription() { return description;}
        public string getPhone() { return phone;}
        public string getGmail() {  return gmail;}

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Gmail
        {
            get { return gmail; }
            set { gmail = value; }
        }

        public static Magazine operator+(Magazine mag, string new_gmail)
        {
            mag.Gmail = mag.Gmail + " " + new_gmail;
            return mag;
        }
        public static Magazine operator -(Magazine mag, int index)
        {
            string[] part = mag.Gmail.Split(' ');
            mag.Gmail = null;
            for (int i = 0; i < part.Length; i++)
            {
                if (i == index)
                {
                    continue;
                }
                else
                {
                    mag.Gmail += part[i] + " ";
                }
                
            }
            return mag;
        }
        public static bool operator ==(Magazine mag1, Magazine mag2)
        {
            return mag1.Gmail.Equals(mag2.Gmail);
        }
        public static bool operator !=(Magazine mag1, Magazine mag2)
        {
            return !(mag1.Gmail.Equals(mag2.Gmail));
        }
        public static bool operator >(Magazine mag1, Magazine mag2)
        {
            return mag1.Year > mag2.Year;
        }
        public static bool operator <(Magazine mag1, Magazine mag2)
        {
            return mag1.Year < mag2.Year;
        }

        public void display()
        {
            Console.WriteLine();
            Console.WriteLine($"Name: {getName()}");
            Console.WriteLine($"Year: {getYear()}");
            Console.WriteLine($"Description: {getDescription()}");
            Console.WriteLine($"Phone: {getPhone()}");
            Console.WriteLine($"Gmail: {getGmail()}");
            Console.WriteLine();
        }
    }

    class Shop
    {
        private string shop_name;
        private string shop_address;
        private string shop_description;
        private string shop_phone;
        private string shop_gmail;
        private int size;
        protected List<Magazine> magazines = new List<Magazine>();

        public Shop(string shop_name, string shop_address, string shop_description, string shop_phone, string shop_gmail)
        {
            this.shop_name = shop_name;
            this.shop_address = shop_address;
            this.shop_description = shop_description;
            this.shop_phone = shop_phone;
            this.shop_gmail = shop_gmail;
            this.size = 100;
        }

        public void addMagazine(Magazine magazine) { this.magazines.Add(magazine); }
        public void delMagazine(Magazine magazine) { this.magazines.Remove(magazine); }
        public void displayMagazines()
        {
            Console.WriteLine();
            Console.WriteLine("Magazines: ");
            Console.WriteLine("----------");
            foreach (Magazine item in magazines)
            {
                item.display();
            }
            Console.WriteLine("----------");
            Console.WriteLine();
        }

        public void displayShop()
        {
            Console.WriteLine();
            Console.WriteLine("Name: " + getShopName());
            Console.WriteLine("Address: " + getShopAddress());
            Console.WriteLine("Description: " + getShopDescription());
            Console.WriteLine("Phone: " + getShopPhone());
            Console.WriteLine("Gmail: " + getShopGmail());
            Console.WriteLine("Size: " + getSize() + " m^2");
            Console.WriteLine();
        }

        public void setShopName(string shop_name) { this.shop_name = shop_name; }
        public void setShopAddress(string shop_address) { this.shop_address = shop_address; }
        public void setShopDescription(string shop_description) { this.shop_description = shop_description; }
        public void setShopPhone(string shop_phone) { this.shop_phone = shop_phone; }
        public void setShopGmail(string shop_gmail) { this.shop_gmail = shop_gmail; }
        public void setSize(int size) { this.size = size; }

        public string getShopName() { return this.shop_name; }
        public string getShopDescription() { return this.shop_description; }
        public string getShopAddress() { return this.shop_address; }
        public string getShopGmail() { return this.shop_gmail; }
        public string getShopPhone() { return this.shop_phone; }
        public int getSize() { return this.size; }

        public string ShopName
        {
            get { return this.shop_name; }
            set { this.shop_name = value; }
        }
        public string ShopDescription
        {
            get { return this.shop_description; }
            set { this.shop_description = value; }
        }
        public string ShopAddress
        {
            get { return this.shop_address; }
            set { this.shop_address = value; }
        }
        public string ShopGmail
        {
            get { return this.shop_gmail; }
            set { this.shop_gmail = value; }
        }
        public string ShopPhone
        {
            get { return this.shop_phone; }
            set { this.shop_phone = value; }
        }
        public int Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

        public static Shop operator +(Shop shop, Magazine magazine)
        {
            shop.addMagazine(magazine);
            return shop;
        }
        public static Shop operator -(Shop shop, Magazine magazine)
        {
            shop.delMagazine(magazine);
            return shop;
        }
        public static Shop operator +(Shop shop, int add_size)
        {
            shop.Size += add_size;
            return shop;
        }
        public static Shop operator -(Shop shop, int dec_size)
        {
            shop.Size -= dec_size; ;
            return shop;
        }
        public static bool operator ==(Shop shop1, Shop shop2)
        {
            return shop1.Size.Equals(shop2.Size);
        }
        public static bool operator !=(Shop shop1, Shop shop2)
        {
            return !(shop1.Size.Equals(shop2.Size));
        }
        public static bool operator>(Shop shop1, Shop shop2)
        {
            return shop1.Size > shop2.Size;
        }
        public static bool operator <(Shop shop1, Shop shop2)
        {
            return shop1.Size < shop2.Size;
        }
    }

    class MagazineToRead
    {
        private List<Magazine> wish_list;
        public MagazineToRead() 
        { 
            this.wish_list = new List<Magazine>(); 
        }
        public static MagazineToRead operator +(MagazineToRead mg, Magazine mag)
        {
            mg.wish_list.Add(mag);
            return mg;
        }
        public static MagazineToRead operator -(MagazineToRead mg, Magazine mag)
        {
            mg.wish_list.Remove(mag);
            return mg;
        }
        public bool isInList(Magazine magazine) 
        {
            foreach (var item in wish_list)
            {
                if (item == magazine)
                {
                    Console.WriteLine("In your wish list");
                    return true;
                }
            }
            Console.WriteLine("Is not in your wish list");
            return false;
        }
        public void display()
        {
            foreach (var item in wish_list)
            {
                item.display();
            }
        }

        public Magazine this[int index] 
        {
            get { return wish_list[index]; }
            set { wish_list[index] = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Magazine magazine1 = new Magazine("Bibigaga", 2025, "About IT", "+380987423004", "bibi@gmail.com");
            Magazine magazine2 = new Magazine("Bibigaga2", 2026, "About AI", "+380987423004", "bibi@gmail.com");
            Magazine magazine3 = new Magazine("Bibigaga3", 2026, "About something", "+380987423004", "bubu@gmail.com");
            magazine1 += "bibi1@gmail.com";
            magazine1 += "bibi2@gmail.com";
            magazine1 += "bibi3@gmail.com";
            magazine1 -= 2;
            magazine1.display();

            Shop shop1 = new Shop("Aboba shop", "Booklad, gravy 48", "Sell magazines", "0453627710", "ggg@gmailpook.cob");
            magazine2.display();
            shop1 += 25;
            shop1.displayShop();
            shop1.addMagazine(magazine2);
            shop1.addMagazine(magazine2);
            shop1.addMagazine(magazine1);
            shop1.delMagazine(magazine2);
            shop1 += magazine3;
            shop1.displayMagazines();
            Shop shop2 = new Shop("Aboba2 shop", "Mg Uka, gravy 48", "Sell magazines", "0453627710", "ggg@gmailpook.cob");
            shop2.addMagazine(magazine1);
            shop2.addMagazine(magazine2);
            shop2.displayMagazines();

            MagazineToRead mtr = new MagazineToRead();
            mtr += magazine1;
            mtr += magazine2;
            mtr.isInList(magazine1);
            mtr[1] = magazine3;
            mtr.display();
        }
    }
}
