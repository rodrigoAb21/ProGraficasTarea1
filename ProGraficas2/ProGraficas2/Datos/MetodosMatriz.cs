using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProGraficas2.Datos
{
    class MetodosMatriz
    {
        public MetodosMatriz()
        {

        }

        public Punto multiplicacion(Punto p, Matriz m)
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
                        solucion.setData(solucion.getData(i,j) + mPunto.getData(i,k) * m.getData(k,j), i, j);
                    }
                }
            }

            p.X = solucion.getData(0, 0);
            p.Y = solucion.getData(0, 1);
            p.H = solucion.getData(0, 2);

            return p;
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
            angulo = angulo * ((float) Math.PI / 180);
            m.setData( (float) Math.Cos(angulo), 0, 0);
            m.setData( (float) Math.Sin(angulo), 0, 1);
            m.setData( - (float) Math.Sin(angulo), 1, 0);
            m.setData( (float) Math.Cos(angulo), 1, 1);
            return m;
        }

        //-------------------------------LISTA PUNTOS------------------------------

        public List<Punto> trasLista(List<Punto> l, float x, float y)
        {
            List<Punto> res = new List<Punto>();
            for (int i = 0; i < l.Count; i++)
            {
                res.Add(multiplicacion(l[i], traslacion(x, y)));
            }
            return res;
        }


        public List<Punto> escaLista(List<Punto> l, float x, float y)
        {
            List<Punto> res = new List<Punto>();
            for (int i = 0; i < l.Count; i++)
            {
                res.Add(multiplicacion(l[i], escalacion(x, y)));
            }
            return res;
        }

        public List<Punto> rotLista(List<Punto> l, float angulo)
        {
            List<Punto> res = new List<Punto>();
            for (int i = 0; i < l.Count; i++)
            {
                res.Add(multiplicacion(l[i], rotacion(angulo)));
            }
            return res;
        }

        //------------------------------POLIGONO-----------------------------------

        public Poligono traslPol(Poligono p, float x, float y)
        {
            Poligono res = new Poligono();
            res.CentroPol = p.CentroPol;
            res.ListaPuntos = trasLista(p.ListaPuntos, x, y);
            return res;
        }

        public Poligono escaPol(Poligono p, float x, float y)
        {
            Poligono res = new Poligono();
            res.CentroPol = p.CentroPol;
            res.ListaPuntos = escaLista(p.ListaPuntos, x, y);
            return res;
        }

        public Poligono rotPol(Poligono p, float angulo)
        {
            Poligono res = new Poligono();
            res.CentroPol = p.CentroPol;
            res.ListaPuntos = rotLista(p.ListaPuntos, angulo);
            return res;
        }

        //--------------------------------OBJETO----------------------------------------

        public Objeto trasObj(Objeto o, float x, float y)
        {
            Objeto res = new Objeto();
            res.CentroObj = o.CentroObj;
            for (int i = 0; i < o.ListaPoligonos.Count; i++)
            {
                res.addPoligono(traslPol(o.ListaPoligonos[i], x, y));
            }
            return res;
        }

        public Objeto escaObj(Objeto o, float x, float y)
        {
            Objeto res = new Objeto();
            res.CentroObj = o.CentroObj;
            for (int i = 0; i < o.ListaPoligonos.Count; i++)
            {
                res.addPoligono(escaPol(o.ListaPoligonos[i], x, y));
            }
            return res;
        }

        public Objeto rotObj(Objeto o, float angulo)
        {
            Objeto res = new Objeto();
            res.CentroObj = o.CentroObj;
            for (int i = 0; i < o.ListaPoligonos.Count; i++)
            {
                res.addPoligono(rotPol(o.ListaPoligonos[i], angulo));
            }
            return res;
        }

        //-------------------------------ESCENARIO--------------------------------------------

        public Escenario traslEsce(Escenario e, float x, float y)
        {
            Escenario res = new Escenario();
            res.CentroEsc = e.CentroEsc;
            for (int i = 0; i < e.ListaObjetos.Count; i++)
            {
                res.addObj(trasObj(e.ListaObjetos[i], x, y));
            }
            return res;
        }

        public Escenario escaEsce(Escenario e, float x, float y)
        {
            Escenario res = new Escenario();
            res.CentroEsc = e.CentroEsc;
            for (int i = 0; i < e.ListaObjetos.Count; i++)
            {
                res.addObj(escaObj(e.ListaObjetos[i], x, y));
            }
            return res;
        }

        public Escenario rotEsce(Escenario e, float angulo)
        {
            Escenario res = new Escenario();
            res.CentroEsc = e.CentroEsc;
            for (int i = 0; i < e.ListaObjetos.Count; i++)
            {
                res.addObj(rotObj(e.ListaObjetos[i], angulo));
            }
            return res;
        }
































    }
}
