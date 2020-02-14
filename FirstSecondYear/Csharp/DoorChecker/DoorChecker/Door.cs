using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorChecker
{
    class Door
    {
        public int h { get; set; }
        public int w { get; set; }

        public Door(int h = 0, int w = 0)
        {
            this.h = h;
            this.w = w;
        }
    }
}
