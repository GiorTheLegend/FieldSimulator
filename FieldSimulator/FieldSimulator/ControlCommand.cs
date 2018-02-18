using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldSimulator
{
    class ControlCommand
    {
        public int StartX { get; set; }
        public int StartY { get; set; }
        public int EndX { get; set; }
        public int EndY { get; set; }
        public string Display { get; set; }

        public ControlCommand(int StartX, int StartY, int EndX, int EndY)
        {
            this.StartX = StartX;
            this.StartY = StartY;
            this.EndX = EndX;
            this.EndY = EndY;

            this.Display = "Start: (" + StartX + ", " + StartY + ") End: (" + EndX + ", " + EndY + ")";
        }
    }
}
