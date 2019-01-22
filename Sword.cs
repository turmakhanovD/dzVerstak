using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verstak
{
    public class Sword
    {
        public int ItemID { get; set; }


        public static string operator + (Sword sword, Stick stick)
        {
            return "You've successfully crafted sword!";
        }
    }
}
