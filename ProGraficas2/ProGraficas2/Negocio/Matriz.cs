using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProGraficas2.Negocio
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

        public float getData(int posX, int posY)
        {
            return m[posX, posY];
        }

        public void setData(float data, int posX, int posY)
        {
            m[posX, posY] = data;
        }

        public static void Main()
        {
            Matriz m1 = new Matriz();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    m1.setData(1, i, j);
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    System.Console.Write(m1.getData(i,j) + " ");
                }
                System.Console.WriteLine(" ");
            }

        }
        

    }


}
