using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verstak
{
    public class CraftTable
    {

        int[,] craftTable = new int[3, 3];

        ConsoleKeyInfo key;
        ConsoleKeyInfo cell;


        public void DrawTable()
        {

            Console.SetCursorPosition(10, 3);
            Console.WriteLine("#####" + "#" + "#####" + "#" + "#####");
            Console.SetCursorPosition(10, 4);
            Console.WriteLine("#    " + "#" + "     " + "#" + "    #");
            Console.SetCursorPosition(10, 5);
            Console.WriteLine("#####" + "#" + "#####" + "#" + "#####");

            Console.SetCursorPosition(10, 6);
            Console.WriteLine("#    " + "#" + "     " + "#" + "    #");
            Console.SetCursorPosition(10, 7);
            Console.WriteLine("#####" + "#" + "#####" + "#" + "#####");
            Console.SetCursorPosition(10, 8);
            Console.WriteLine("#    " + "#" + "     " + "#" + "    #");
            Console.SetCursorPosition(10, 9);
            Console.WriteLine("#####" + "#" + "#####" + "#" + "#####");


            Console.SetCursorPosition(30, 3);
            Console.WriteLine("1. Wood");

            Console.SetCursorPosition(30, 4);
            Console.WriteLine("2. Stone");

            Console.SetCursorPosition(30, 5);
            Console.WriteLine("3. Iron");

            Console.SetCursorPosition(30, 6);
            Console.WriteLine("4. Gold");

            Console.SetCursorPosition(30, 7);
            Console.WriteLine("5. Stick");

        }

        public void Logic()
        {
            char key = '1';
            // key = (char)Console.Read();

            Console.SetCursorPosition(5, 10);
            Console.WriteLine("SELECT NUMBERS FIRST FOR MATERIAL SECOND FOR CELL AND PRESS 'c' TO CRAFT: ");
            // key = (char)Console.Read();


            while (!Char.IsLetter(key) || key != (char)99)
            {


                Console.SetCursorPosition(5, 11);
                key = (char)Console.Read();
                Console.WriteLine(" ");
                if (key == (char)99) break;
                while (!Char.IsNumber(key) || int.Parse(Char.ToString(key)) > 5)
                {

                    key = (char)Console.Read();
                    Console.WriteLine(" ");
                    if (key == (char)99) break;
                }
                if (key == (char)99) break;
                // Console.WriteLine("Select cell: ");
                cell = Console.ReadKey(true);
                if (key == (char)99) break;
                while (!Char.IsNumber(cell.KeyChar) || int.Parse(Char.ToString(key)) > 9)
                {
                    if (key == (char)99) break;

                    cell = Console.ReadKey(true);
                    Console.WriteLine(" ");
                }

                if (key == (char)99) break;
                switch (cell.KeyChar)
                {
                    case '1':
                        craftTable[0, 0] = int.Parse(Char.ToString(key));
                        Console.SetCursorPosition(12, 4);
                        Console.WriteLine(key);
                        break;
                    case '2':
                        craftTable[0, 1] = int.Parse(Char.ToString(key));
                        Console.SetCursorPosition(18, 4);
                        Console.WriteLine(key);
                        break;
                    case '3':
                        craftTable[0, 2] = int.Parse(Char.ToString(key));
                        Console.SetCursorPosition(24, 4);
                        Console.WriteLine(key);
                        break;
                    case '4':
                        craftTable[1, 0] = int.Parse(Char.ToString(key));
                        Console.SetCursorPosition(12, 6);
                        Console.WriteLine(key);
                        break;
                    case '5':
                        craftTable[1, 1] = int.Parse(Char.ToString(key));
                        Console.SetCursorPosition(18, 6);
                        Console.WriteLine(key);
                        break;
                    case '6':
                        craftTable[1, 2] = int.Parse(Char.ToString(key));
                        Console.SetCursorPosition(24, 6);
                        Console.WriteLine(key);
                        break;
                    case '7':
                        craftTable[2, 0] = int.Parse(Char.ToString(key));
                        Console.SetCursorPosition(12, 8);
                        Console.WriteLine(key);

                        break;
                    case '8':
                        craftTable[2, 1] = int.Parse(Char.ToString(key));
                        Console.SetCursorPosition(18, 8);
                        Console.WriteLine(key);
                        break;
                    case '9':
                        craftTable[2, 2] = int.Parse(Char.ToString(key));
                        Console.SetCursorPosition(24, 8);
                        Console.WriteLine(key);
                        break;
                }

                if (key == (char)99) break;
            }
        }

        public void Check()
        {

            if (craftTable[0, 0] == 2 && craftTable[0, 1] == 2 && craftTable[0, 2] == 2)
            {
                if (craftTable[1, 0] == 0 && craftTable[1, 1] == 5 && craftTable[1, 2] == 0 && craftTable[2, 0] == 0
              && craftTable[2, 1] == 5 && craftTable[2, 2] == 0)
                {
                    Stone stone = new Stone();
                    Stone stone1 = new Stone();
                    Stone stone2 = new Stone();
                    PickaxesFirstPart pix = stone + stone1;
                    Pickaxe pickaxe = pix + stone2;
                    Stick stick = new Stick();
                    Stick stick1 = new Stick();
                    Handle handle = stick + stick1;
                    Console.WriteLine(pickaxe + handle + "(stone)");
                }
            }

            if (craftTable[0, 0] == 1 && craftTable[0, 1] == 1 && craftTable[0, 2] == 1)
            {
                if (craftTable[1, 0] == 0 && craftTable[1, 1] == 5 && craftTable[1, 2] == 0 && craftTable[2, 0] == 0
              && craftTable[2, 1] == 5 && craftTable[2, 2] == 0)
                {
                    Wood wood = new Wood();
                    Wood wood1 = new Wood();
                    Wood wood2 = new Wood();
                    PickaxesFirstPart pix = wood * wood1;
                    Pickaxe pickaxe = pix + wood2;
                    Stick stick = new Stick();
                    Stick stick1 = new Stick();
                    Handle handle = stick + stick1;
                    Console.WriteLine(pickaxe + handle + "(wooden)");
                }
            }

            if (craftTable[0, 0] == 3 && craftTable[0, 1] == 3 && craftTable[0, 2] == 3)
            {
                if (craftTable[1, 0] == 0 && craftTable[1, 1] == 5 && craftTable[1, 2] == 0 && craftTable[2, 0] == 0
              && craftTable[2, 1] == 5 && craftTable[2, 2] == 0)
                {
                    Iron iron = new Iron();
                    Iron iron1 = new Iron();
                    Iron iron2 = new Iron();
                    PickaxesFirstPart pix = iron + iron1;
                    Pickaxe pickaxe = pix + iron2;
                    Stick stick = new Stick();
                    Stick stick1 = new Stick();
                    Handle handle = stick + stick1;
                    Console.WriteLine(pickaxe + handle + "(iron)");
                }
            }
            if (craftTable[0, 0] == 4 && craftTable[0, 1] == 4 && craftTable[0, 2] == 4)
            {
                if (craftTable[1, 0] == 0 && craftTable[1, 1] == 5 && craftTable[1, 2] == 0 && craftTable[2, 0] == 0
              && craftTable[2, 1] == 5 && craftTable[2, 2] == 0)
                {
                    Gold gold = new Gold();
                    Gold gold1 = new Gold();
                    Gold gold2 = new Gold();
                    PickaxesFirstPart pix = gold + gold1;
                    Pickaxe pickaxe = pix + gold2;
                    Stick stick = new Stick();
                    Stick stick1 = new Stick();
                    Handle handle = stick + stick1;
                    Console.WriteLine(pickaxe + handle + "(golden)");
                }
            }

            if (craftTable[0, 0] == 0 && craftTable[0, 1] == 1 && craftTable[0, 2] == 0
                && craftTable[1, 0] == 0 && craftTable[1, 1] == 1 && craftTable[1, 2] == 0)
            {
                if (craftTable[2, 0] == 0 && craftTable[2, 1] == 5 && craftTable[2, 2] == 0)
                {
                    Wood obj = new Wood();
                    Wood obj2 = new Wood();

                    Stick stick = new Stick();

                    Sword sword = obj / obj2;
                    Console.WriteLine(sword + stick + "(wooden)");
                }
            }

            if (craftTable[0, 0] == 0 && craftTable[0, 1] == 2 && craftTable[0, 2] == 0
                && craftTable[1, 0] == 0 && craftTable[1, 1] == 2 && craftTable[1, 2] == 0)
            {
                if (craftTable[2, 0] == 0 && craftTable[2, 1] == 5 && craftTable[2, 2] == 0)
                {
                    Stone obj = new Stone();
                    Stone obj2 = new Stone();

                    Stick stick = new Stick();

                    Sword sword = obj * obj2;
                    Console.WriteLine(sword + stick + "(stone)");
                }
            }


            if (craftTable[0, 0] == 0 && craftTable[0, 1] == 3 && craftTable[0, 2] == 0
                && craftTable[1, 0] == 0 && craftTable[1, 1] == 3 && craftTable[1, 2] == 0)
            {
                if (craftTable[2, 0] == 0 && craftTable[2, 1] == 5 && craftTable[2, 2] == 0)
                {
                    Iron obj = new Iron();
                    Iron obj2 = new Iron();

                    Stick stick = new Stick();

                    Sword sword = obj * obj2;
                    Console.WriteLine(sword + stick + "(iron)");
                }
            }


            if (craftTable[0, 0] == 0 && craftTable[0, 1] == 4 && craftTable[0, 2] == 0
                && craftTable[1, 0] == 0 && craftTable[1, 1] == 4 && craftTable[1, 2] == 0)
            {
                if (craftTable[2, 0] == 0 && craftTable[2, 1] == 5 && craftTable[2, 2] == 0)
                {
                    Gold obj = new Gold();
                    Gold obj2 = new Gold();

                    Stick stick = new Stick();

                    Sword sword = obj * obj2;
                    Console.WriteLine(sword + stick + "(golden)");
                }
            }



            if (craftTable[0, 0] == 0 && craftTable[0, 1] == 1 && craftTable[0, 2] == 0
                && craftTable[1, 0] == 0 && craftTable[1, 1] == 5 && craftTable[1, 2] == 0)
            {
                if (craftTable[2, 0] == 0 && craftTable[2, 1] == 5 && craftTable[2, 2] == 0)
                {
                    Wood wood = new Wood();

                    Stick stick = wood + wood;
                    Stick stick1 = wood + wood;

                    Handle handle = stick + stick1;

                    Shovel shovel = wood % wood;
                    Console.WriteLine(shovel + handle + "wooden");
                }
            }


            if (craftTable[0, 0] == 0 && craftTable[0, 1] == 2 && craftTable[0, 2] == 0
                && craftTable[1, 0] == 0 && craftTable[1, 1] == 5 && craftTable[1, 2] == 0)
            {
                if (craftTable[2, 0] == 0 && craftTable[2, 1] == 5 && craftTable[2, 2] == 0)
                {
                    Stone stone = new Stone();

                    Stick stick = new Stick();
                    Stick stick1 = new Stick();

                    Handle handle = stick + stick1;

                    Shovel shovel = stone / stone;
                    Console.WriteLine(shovel + handle + "stone");
                }
            }



            if (craftTable[0, 0] == 0 && craftTable[0, 1] == 3 && craftTable[0, 2] == 0
                && craftTable[1, 0] == 0 && craftTable[1, 1] == 5 && craftTable[1, 2] == 0)
            {
                if (craftTable[2, 0] == 0 && craftTable[2, 1] == 5 && craftTable[2, 2] == 0)
                {
                    Iron iron = new Iron();

                    Stick stick = new Stick();
                    Stick stick1 = new Stick();

                    Handle handle = stick + stick1;

                    Shovel shovel = iron / iron;
                    Console.WriteLine(shovel + handle + "iron");
                }
            }



            if (craftTable[0, 0] == 0 && craftTable[0, 1] == 4 && craftTable[0, 2] == 0
                && craftTable[1, 0] == 0 && craftTable[1, 1] == 5 && craftTable[1, 2] == 0)
            {
                if (craftTable[2, 0] == 0 && craftTable[2, 1] == 5 && craftTable[2, 2] == 0)
                {
                    Gold gold = new Gold();

                    Stick stick = new Stick();
                    Stick stick1 = new Stick();

                    Handle handle = stick + stick1;

                    Shovel shovel = gold / gold;
                    Console.WriteLine(shovel + handle + "golden");
                }
            }

            
        }
    }
}







//public static string HideRepeatCharacter(User user)
//{
//    ConsoleKeyInfo key;
//    string code = "";
//    do
//    {
//        key = Console.ReadKey(true);

//        if (Char.IsNumber(key.KeyChar)
//            || char.IsLetter(key.KeyChar)
//            || char.IsSymbol(key.KeyChar)
//            || char.IsPunctuation(key.KeyChar)
//            )
//        {
//            Console.Write("*");
//        }
//        code += key.KeyChar;
//    } while (key.Key != ConsoleKey.Enter);
//    user.RepeatPassword = code;
//    return code;






