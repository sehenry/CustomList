using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    class Program
    {

        static void Main(string[] args)
        {
            CustomList<int> foo = new CustomList<int>();
            foo.Add(3);
            Console.ReadLine();
        }
    }
}
