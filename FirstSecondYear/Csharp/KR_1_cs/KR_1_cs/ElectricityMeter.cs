using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR_1_cs
{
    enum Type
    {
        electronic,
        mechanical
    }

    class ElectricityMeter
    {
        private int namber;
        private Type type;
        private int meterDisplay;

        public int MeterDisplay
        {
            get { return meterDisplay; }
        }
        public Type Type
        {
            get { return  type; }
        }

        public ElectricityMeter()
        {
            namber = 0;
            type = Type.electronic;
            meterDisplay = 0;
        }

        public ElectricityMeter(int namber, Type type, int meterDisplay)
        {
            this.namber = namber;
            this.type = type;
            this.meterDisplay = meterDisplay;
        }

        public ElectricityMeter(ElectricityMeter meter)
        {
            this.namber = meter.namber;
            this.type = meter.type;
            this.meterDisplay = meter.meterDisplay;
        }

        public void Show()
        {
            if (type == Type.electronic)
                Console.WriteLine($"Electronic meter number {namber} has {meterDisplay} meters.");
            else
                Console.WriteLine($"Mechanical meter number {namber} has {meterDisplay} meters.");
        }

        public void Input()
        {
            Console.WriteLine("Enter name of electricity meter: ");
            namber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter type (0 if electronic or 1 else): ");
            type = (Type)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter meters: ");
            meterDisplay = Convert.ToInt32(Console.ReadLine());
        }

        public override bool Equals(object obj)
        {
            var meter = obj as ElectricityMeter;
            return meter != null &&
                   namber == meter.namber &&
                   type == meter.type &&
                   meterDisplay == meter.meterDisplay;
        }

        public static bool operator <(ElectricityMeter meter1, ElectricityMeter meter2)
        {
            return meter1.namber < meter2.namber;
        }
        public static bool operator >(ElectricityMeter meter1, ElectricityMeter meter2)
        {
           return meter1.namber > meter2.namber;
        }



    }
}
