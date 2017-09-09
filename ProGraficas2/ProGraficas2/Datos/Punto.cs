using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProGraficas2.Datos
{
    class Punto
    {
        private float x;
        private float y;
        private float h;

        public Punto()
        {
            X = 0;
            Y = 0;
            H = 1;
        }

        public Punto(float x, float y)
        {
            X = x;
            Y = y;
            H = 1;
        }


        public float X
        {
            get { return x ; }
            set { x = value; }
        }

        

        public float Y
        {
            get { return y ; }
            set { y = value; }
        }

        

        public float H
        {
            get { return h; }
            set { h = value; }
        }




    }
}
