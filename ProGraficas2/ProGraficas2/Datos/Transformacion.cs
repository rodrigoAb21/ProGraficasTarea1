using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProGraficas2.Datos
{
    class Transformacion
    {
        private Matriz matrix;

        public Matriz Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }


        public Transformacion()
        {
            matrix = new Matriz();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j)
                    {
                        matrix.setData(1, i, j);
                    }
                    else
                    {
                        matrix.setData(0, i, j);
                    }
                }
            }
        }

        public Punto multPunto(Punto p, Matriz m)
        {
            Matriz mPunto = new Matriz(1, 3);
            mPunto.setData(p.X, 0, 0);
            mPunto.setData(p.Y, 0, 1);
            mPunto.setData(p.H, 0, 2);

            Matriz solucion = new Matriz(1, 3);
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        solucion.setData(solucion.getData(i, j) + mPunto.getData(i, k) * m.getData(k, j), i, j);
                    }
                }
            }

            p.X = solucion.getData(0, 0);
            p.Y = solucion.getData(0, 1);
            p.H = solucion.getData(0, 2);

            return p;
        }

        public Poligono multPoligono(Poligono p, Matriz m)
        {
            Poligono res = new Poligono(p.CentroPol);
            for (int i = 0; i < p.ListaPuntos.Count; i++)
            {
                res.addPunto(multPunto(p.ListaPuntos[i], m));
            }
            return res;
        }

        public Objeto multObjeto(Objeto o, Matriz m)
        {
            Objeto res = new Objeto(o.CentroObj);
            for (int i = 0; i < o.ListaPoligonos.Count; i++)
            {
                res.addPoligono(multPoligono(o.ListaPoligonos[i], m));
            }
            return res;
        }

        public Escenario multEscenario(Escenario e, Matriz m)
        {
            Escenario res = new Escenario(e.CentroEsc);
            for (int i = 0; i < e.ListaObjetos.Count; i++)
            {
                res.addObj(multObjeto(e.ListaObjetos[i], m));
            }
            return res;
        }

        public Matriz multMatriz(Matriz a, Matriz b)
        {
            Matriz res = new Matriz();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        res.setData(res.getData(i, j) + a.getData(i, k) * b.getData(k, j), i, j);
                    }
                }
            }

            return res;
        }

        public Matriz identidad()
        {
            Matriz m = new Matriz();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j)
                    {
                        m.setData(1, i, j);
                    }
                    else
                    {
                        m.setData(0, i, j);
                    }
                }
            }
            return m;
        }

        public Matriz traslacion(float x, float y)
        {
            Matriz m = identidad();
            m.setData(x, 2, 0);
            m.setData(y, 2, 1);
            return m;
        }

        public Matriz escalacion(float x, float y)
        {
            Matriz m = identidad();
            m.setData(x, 0, 0);
            m.setData(y, 1, 1);
            return m;
        }

        public Matriz rotacion(float angulo)
        {
            Matriz m = identidad();
            angulo = angulo * ((float)Math.PI / 180);
            m.setData((float)Math.Cos(angulo), 0, 0);
            m.setData((float)Math.Sin(angulo), 0, 1);
            m.setData(-(float)Math.Sin(angulo), 1, 0);
            m.setData((float)Math.Cos(angulo), 1, 1);
            return m;
        }

        public void trasladar(float x, float y)
        {
            matrix = multMatriz(matrix, traslacion(x, y));
        }

        public void escalar(float x, float y)
        {
            matrix = multMatriz(matrix, escalacion(x, y));
        }

        public void rotar(float angulo)
        {
            matrix = multMatriz(matrix, rotacion(angulo));
        }





    }
}
