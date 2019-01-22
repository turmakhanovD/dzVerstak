using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verstak
{
    public class Shovel
    {
        public static string operator + (Shovel shovel, Handle handle)
        {
            return "You've successfully crafted shovel!";
        }
    }
}
