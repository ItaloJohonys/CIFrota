using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User("Italo Johonnys", "johonnysitalo@gmail.com");

            try
            {
                user.SetPassword("", "italo");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);           
            }

            

            Console.WriteLine(user.Name);
            Console.WriteLine(user.Password);
            var password = user.ResetPassword();
            Console.WriteLine(password);
            Console.WriteLine(user.Password);
            Console.ReadKey();
        }
    }
}
