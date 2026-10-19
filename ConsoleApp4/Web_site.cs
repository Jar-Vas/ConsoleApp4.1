using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    internal class WebSite
    {
        private string name;
        private string url;
        private string description;
        private string ip;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Url
        {
            get
            {
                return url;
            }
            set
            {
                url = value;
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        public string Ip
        {
            get
            {
                return ip;
            }
            set
            {
                ip = value;
            }
        }

        public void dataOut()
        {
            Console.WriteLine("Web-Site: " + name + ", url: " + url + ", description: " + description + ", IP: " + ip);
        }
    }
}
