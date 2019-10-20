using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Para2_28_02
{
    class Arrey
    {
        private int[] arr;
        private int n;

        public Arrey(int n)
        {
            arr = new int[n];
            this.n = n;
        }
        public Arrey(int[] arr)
        {
            n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                this.arr[i] = arr[i];
            }
        }
        public int this[int i]
        {
            get
            {
                if (i >= 0 && i < n)
                    return arr[i];
                else
                {
                    Console.WriteLine("Такого елементу не існує.");
                    throw new Exception("get exct");
                }
            }
            set
            {
                if (i >= 0 && i < n && value >= 100)
                    arr[i] = value;
                else
                {
                    Console.WriteLine("Введiть бiльше значення.");
                }
            }
        }
        public static Arrey operator +(Arrey arr1, Arrey arr2)
        {
            if (arr1.n != arr2.n)
                throw new Exception("Масиви рiзних розмiрiв.");
            Arrey arrey = new Arrey(arr1.n);

            for (int i = 0; i < arr1.n; i++)
            {
                arrey[i] = arr1[i] + arr2[i];
            }
            return arrey;
        }
        public static Arrey operator +(Arrey arr1, int k)
        {
            Arrey arrey = new Arrey(arr1.n);
            for (int i = 0; i < arr1.n; i++)
            {
                arrey[i] = arr1[i] + k;
            }
            return arrey;
        }
        public void Print()
        {
            foreach(int a in arr)
            {
                Console.Write("{a} ");
            }
        }
    }
}

