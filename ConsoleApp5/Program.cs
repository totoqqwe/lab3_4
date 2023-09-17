using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("john_doe", "John", "Doe", 30);

            user.WriteUserInfo();
        }
    }
}
