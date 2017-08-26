using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProGraficas1
{
    class Punto
    {
        private int x;
        private int y;

        public Punto(int ejeX, int ejeY)
        {
            x = ejeX;
            y = ejeY;
        }

        public int getX()
        {
            return x;
        }

        public int getY()
        {
            return y;
        }

        public void setX(int ejeX)
        {
            x = ejeX;
        }

        public void setY(int ejeY)
        {
            y = ejeY;
        }

    }
}
