using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorChecker
{
    class Wardrobe
    {
        public int h { get; set; }
        public int w { get; set; }
        public int l { get; set; }
        public Wardrobe(int h = 0, int w = 0, int l = 0)
        {
            this.h = h;
            this.w = w;
            this.l = l;
        }
    }
}
