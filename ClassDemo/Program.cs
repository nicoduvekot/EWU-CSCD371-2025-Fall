using System;

namespace ClassDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello, World!");
        }

        public void Login(string username, string password)
        {
            if (!TryLogin(username, password))
            {
                throw new InvalidOperationException("Invalid username or password");
            }
        }

        public bool TryLogin(string username, string password)
        {
            if (password == "goodpassword")
            {
                return true;
            }
            return false;
        }
    }
}
