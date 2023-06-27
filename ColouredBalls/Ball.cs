using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColouredBalls
{
    public class Ball
    {
        private Colour colour;
        private float size;
        private int timesThrown;

        public Ball(Colour colour, float size)
        {
            this.colour = colour;
            this.size = size;
            this.timesThrown = 0;
        }

        public void Pop()
        {
            size = 0;
        }

        public void Throw()
        {
            if (size > 0)
            {
                timesThrown++;
            }
        }

        public int GetTimesThrown()
        {
            return timesThrown;
        }
    }
}
