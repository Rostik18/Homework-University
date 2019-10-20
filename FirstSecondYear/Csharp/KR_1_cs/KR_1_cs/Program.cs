using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR_1_cs
{
    class Program
    {
        static void A()
        {
            Console.WriteLine("Enter namber of meters: ");
            int n = Convert.ToInt32(Console.ReadLine());

            ElectricityMeter[] meters = new ElectricityMeter[n];
            for (int i = 0; i < n; i++)
            {
                meters[i] = new ElectricityMeter(i + 100 + (i % 3), (Type)(i % 2), 100 + i * 10);
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (meters[i] < meters[j])
                    {
                        ElectricityMeter tmp_meter = new ElectricityMeter(meters[i]);
                        meters[i] = meters[j];
                        meters[j] = tmp_meter;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                meters[i].Show();
            }

            int Elect_meters = 0;
            int Meh_meters = 0;

            for (int i = 0; i < n; i++)
            {
                if (meters[i].Type == Type.electronic)
                    Elect_meters += meters[i].MeterDisplay;
                else
                    Meh_meters += meters[i].MeterDisplay;
            }

            Console.WriteLine($"Sum of electric: {Elect_meters}");
            Console.WriteLine($"Sum of mehanic: {Meh_meters}");
        }

        static void B()
        {
            Console.WriteLine("Enter namber of meters: ");
            int n = Convert.ToInt32(Console.ReadLine());

            ElectricityMeter[] meters = new ElectricityMeter[n];
            for (int i = 0; i < n; i++)
            {
                meters[i] = new ElectricityMeter(i + 100 + (i % 3), (Type)(i % 2), 100 + i * 10);
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (meters[i].MeterDisplay > meters[j].MeterDisplay)
                    {
                        ElectricityMeter tmp_meter = new ElectricityMeter(meters[i]);
                        meters[i] = meters[j];
                        meters[j] = tmp_meter;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                meters[i].Show();
            }

            int Meters_count = 0;

            Console.WriteLine("Enter type (0 if electronic or 1 else) for output: ");
            Type _type = (Type)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter const meter: ");
            int m = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                if (meters[i].Type == _type && meters[i].MeterDisplay <= m)
                    Meters_count++;
            }

            Console.WriteLine($"Sum of your meters: {Meters_count}");
        }

        static void Main(string[] args)
        {
            A();
            //B();
            
            Console.ReadKey();
        }
    }
}
