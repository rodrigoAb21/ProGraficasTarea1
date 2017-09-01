using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProGraficas2.Datos
{
    class Punto
    {
        private int x;
        private int y;
        private int h;

        public Punto()
        {
            EjeX = 0;
            EjeY = 0;
            EjeH = 1;
        }

        public Punto(int x, int y)
        {
            EjeX = x;
            EjeY = y;
            EjeH = 1;
        }


        public int EjeX
        {
            get { return x; }
            set { x = value; }
        }

        

        public int EjeY
        {
            get { return y; }
            set { y = value; }
        }

        

        public int EjeH
        {
            get { return h; }
            set { h = value; }
        }




    }
}
