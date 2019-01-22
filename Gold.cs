using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verstak
{
   public class Gold
    {
        public static PickaxesFirstPart operator +(Gold gold, Gold gold1)
        {
            PickaxesFirstPart pickaxesFirstPart = new PickaxesFirstPart();
            return pickaxesFirstPart;
        }

        public static Sword operator *(Gold gold, Gold gold1)
        {
            Sword sword = new Sword();
            return sword;
        }

        public static Shovel operator /(Gold gold, Gold gold1)
        {
            Shovel shovel = new Shovel();
            return shovel;
        }
    }
}
