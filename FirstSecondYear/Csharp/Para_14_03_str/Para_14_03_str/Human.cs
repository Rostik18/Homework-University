using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Para_14_03_str
{
    interface IWorcker
    {
        void About();
        void Work();
        void getMoney();
    }
    
    interface IFather
    {
        void About();
        void MySun();
        void EducateSun();
    }

    class Human : IWorcker, IFather
    {
        public string name;
        public string age;

        public Human(string name = "Tom", string age = "30")
        {
            this.name = name;
            this.age = age;
        }

        public void About()
        {
            Console.WriteLine($"Я {name}, менi {age} рокiв");
        }

        public void EducateSun()
        {
            Console.WriteLine("Вчися, сину!");
        }

        public void getMoney()
        {
            Console.WriteLine("Я отримую зарплату!");
        }

        public void MySun()
        {
            Console.WriteLine("Це мiй син!");
        }

        public void Work()
        {
            Console.WriteLine("Я працюю!");
        }
    }


}
