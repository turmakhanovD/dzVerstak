using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verstak
{
    public class Wood
    {
        public static Stick operator + (Wood wood, Wood wood1)
        {
            Stick stick = new Stick();
            return stick;
        }
        public static PickaxesFirstPart operator *(Wood wood, Wood wood1)
        {
            PickaxesFirstPart pickaxesFirstPart = new PickaxesFirstPart();
            return pickaxesFirstPart;
        }

        public static Sword operator / (Wood wood, Wood wood1)
        {
            Sword sword = new Sword();
            return sword;
        }

        public static Shovel operator %(Wood wood, Wood wood1)
        {
            Shovel shovel = new Shovel();
            return shovel;
        }

    }
}
