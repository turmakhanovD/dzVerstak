


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verstak
{
    class Program
    {
        static void Main(string[] args)
        {

            CraftTable craftTable = new CraftTable();
            craftTable.DrawTable();
            craftTable.Logic();

            craftTable.Check();



            Console.ReadLine(); Console.ReadLine();
            
            Console.ReadLine();
        }
    }
}
