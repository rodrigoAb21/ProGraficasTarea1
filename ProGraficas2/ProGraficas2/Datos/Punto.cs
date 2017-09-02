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
            EjeX = 0;
            EjeY = 0;
            EjeH = 1;
        }

        public Punto(float x, float y)
        {
            EjeX = x;
            EjeY = y;
            EjeH = 1;
        }


        public float EjeX
        {
            get { return x ; }
            set { x = value; }
        }

        

        public float EjeY
        {
            get { return y ; }
            set { y = value; }
        }

        

        public float EjeH
        {
            get { return h; }
            set { h = value; }
        }




    }
}
