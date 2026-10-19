using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    internal class Magazine
    {


        private string name;
        private string foundationYear;
        private string description;
        private string e_mail;
        private string phoneNumber;

        public string Name
        {
            get{ return name; }
            set{ name = value; }
        }
        public string FoundationYear
        {
            get { return foundationYear; }
            set { foundationYear = value; }
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
            Console.WriteLine("Magazine: " + name + ", foundation year: " + foundationYear + ", description: " + description + ", e-mail: " + E_mail + ", phone number: " + phoneNumber);
        }
    }
}
