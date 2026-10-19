using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    internal class Shop
    {

        private string name;
        private string adress;
        private string description;
        private string e_mail;
        private string phoneNumber;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string E_mail
        {
            get { return e_mail; }
            set { e_mail = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public void dataOut()
        {
            Console.WriteLine("Shop: " + name + ", adress year: " + adress + ", description: " + description + ", e-mail: " + E_mail + ", phone number: " + phoneNumber);
        }
    }
}
