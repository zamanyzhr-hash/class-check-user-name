using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @class
{
    class user 
    {
        public string Username = "admin";
        public string Password = "1234";
        public bool iscorect(string username, string password)
        {
            return (username == Username && password == Password);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter user name");
            string username = Console.ReadLine();
            Console.WriteLine("enter password");
            string password = Console.ReadLine();
            user us = new user();
            if(us.iscorect(username,password)==true)
                Console.WriteLine("corect");
            else
                Console.WriteLine("not correct");

            Console.ReadKey();
        }
    }
}
