using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProGraficas2.Datos
{
    class Matriz
    {
        private float[,] m;

        public Matriz()
        {
            m = new float[3, 3];
        }

        public Matriz(int x,int y)
        {
            m = new float[x, y];
        }

        public float[,] M
        {
            get { return M; }
            set { M = value; }
        }

        public float getData(int posX, int posY)
        {
            return m[posX, posY];
        }


        public void setData(float data, int posX, int posY)
        {
            m[posX, posY] = data;
        }        

    }


}
