namespace ClassDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello, World!");
        }

        public bool Login(string username, string password)
        {
            if (username == "InigoMontoya" && password == "goodpassword")
            {
                return true;
            }
            else if (username == "admin" && password == "goodpassword")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
