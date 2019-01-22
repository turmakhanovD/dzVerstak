using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verstak
{
   public class Stone
    {
        public static PickaxesFirstPart operator + (Stone stone1, Stone stone2)
        {
            PickaxesFirstPart pickaxesFirstPart = new PickaxesFirstPart();
            return pickaxesFirstPart;
        }

        public static Sword operator *(Stone stone, Stone stone1)
        {
            Sword sword = new Sword();
            return sword;
        }


        public static Shovel operator /(Stone stone, Stone stone1)
        {
            Shovel shovel = new Shovel();
            return shovel;
        }

    }
}
