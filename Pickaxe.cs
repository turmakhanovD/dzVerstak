using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verstak
{
    public class Pickaxe
    {
        public int ItemId { get; set; }


        public static string  operator +(Pickaxe pickaxe, Handle handle)
            {
            return "You have successfully crafted pickaxe";
            }

    }
}
