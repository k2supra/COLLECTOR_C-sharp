using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1
{
    class Web_site
    {
        private string name;
        private string url;
        private string description;
        private string ipAddress;

        public Web_site(string name, string url, string description, string ipAddress) 
        {
            this.name = name;
            this.url = url;
            this.description = description;
            this.ipAddress = ipAddress;
        }
        public void setName(string name) { this.name = name; }
        public void setUrl(string url) { this.url = url;}
        public void setDescription(string description) {  this.description = description;}
        public void setIpAddress(string ipAddress) {  this.ipAddress = ipAddress;}

        public string getName() { return this.name;}
        public string getUrl() { return this.url;}
        public string getDescription() { return this.description;}
        public string getIpAddress() { return this.ipAddress;}

        public string Name
        {
            get { return this.name;}
            set { this.name = value;}
        }
        public string Url
        {
            get { return this.url; }
            set { this.url = value; }
        }
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
        public string IPAddress
        {
            get { return this.ipAddress; }
            set { this.ipAddress = value; }
        }

        public void display()
        {
            Console.WriteLine($"Name: {getName()}");
            Console.WriteLine($"Url: {getUrl()}");
            Console.WriteLine($"Description: {getDescription()}");
            Console.WriteLine($"IP Address: {getIpAddress()}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Web_site wb_st = new Web_site("Solomon", "gta5\\solomon.com", "Better than Travor", "152.684.26.04");
            wb_st.IPAddress = "127.0.0.1";
            wb_st.setName("SOLOMON THE BEST");
            wb_st.display();
        }
    }
}
