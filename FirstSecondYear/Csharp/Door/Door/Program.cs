using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Door
{
    class MyBase
    {
        public int h { get; set; }
        public int w { get; set; }
    }
    class Door : MyBase
    {
        public Door(int h = 0, int w = 0)
        {
            this.h = h;
            this.w = w;
        }
    }

    class Wardrobe : MyBase
    {
        public int l { get; set; }
        public Wardrobe(int h = 0, int w = 0, int l = 0)
        {
            this.h = h;
            this.w = w;
            this.l = l;
        }
    }

    class MainClass
    {
        Door door;
        Wardrobe wardrobe;
        public MainClass()
        {
            door = new Door(0, 0);
            wardrobe = new Wardrobe(0, 0, 0);
        }

        public void Run()
        {
            Console.WriteLine(Check(door, wardrobe));
        }

        public void inputData()
        {
            door.h = inp("Door.h");
            door.w = inp("Door.w");
            wardrobe.h = inp("Wardrobe.h");
            wardrobe.w = inp("Wardrobe.w");
            wardrobe.l = inp("Wardrobe.l");
        }
        int inp(string arg) {
            Console.Write($"{arg}: ");
            int rez = Convert.ToInt32(Console.ReadLine());
            return rez;
        }
    
        bool Check(Door door, Wardrobe wardrobe)
        {
            //Існує 6 можливостей покрутити шафу щоб вона влізла в двері.
            if ((door.h >= wardrobe.h && door.w >= wardrobe.w) ||
                (door.h >= wardrobe.h && door.w >= wardrobe.l) ||
                (door.h >= wardrobe.l && door.w >= wardrobe.w) ||
                (door.w >= wardrobe.h && door.h >= wardrobe.w) ||
                (door.w >= wardrobe.h && door.h >= wardrobe.l) ||
                (door.w >= wardrobe.l && door.h >= wardrobe.w)) return true;

            else return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MainClass program = new MainClass();
            program.inputData();
            program.Run();




            Console.ReadKey();
        }
    }
}
