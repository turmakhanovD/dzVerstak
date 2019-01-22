using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verstak
{
   public class Iron
    {
        public static PickaxesFirstPart operator +(Iron iron, Iron iron1)
        {
            PickaxesFirstPart pickaxesFirstPart = new PickaxesFirstPart();
            return pickaxesFirstPart;
        }

        public static Sword operator *(Iron iron, Iron iron1)
        {
             Sword sword = new Sword();
            return sword;
        }


        public static Shovel operator /(Iron iron, Iron iron1)
        {
            Shovel shovel = new Shovel();
            return shovel;
        }
    }
}
