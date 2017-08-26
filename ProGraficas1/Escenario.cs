using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProGraficas1
{
    class Escenario
    {
        private List<Objeto> listaObjetos;
        private Punto centroEsc;
        private Pen lapiz = new Pen(Color.Blue, 1);

        public Escenario(int x, int y)
        {
            listaObjetos = new List<Objeto>();
            centroEsc = new Punto(x, y);
        }

        public Escenario(Punto centro)
        {
            listaObjetos = new List<Objeto>();
            centroEsc = new Punto(centro.getX(), centro.getY());
        }

        public Escenario()
        {
            listaObjetos = new List<Objeto>();
            centroEsc = new Punto(0, 0);
        }

        public void setCentroEsc(int x, int y)
        {
            centroEsc.setX(x);
            centroEsc.setY(y);
        }

        public void setCentroEsc(Punto Centro)
        {
            centroEsc = new Punto(Centro.getX(), Centro.getY());
        }

        public Punto getCentroEsc()
        {
            return centroEsc;
        }

        public Objeto getObjIndexOf(int index)
        {
            return listaObjetos[index];
        }

        public void addObj(Objeto obj)
        {
            listaObjetos.Add(obj);
        }

        public void removeObjIndexOf(int index)
        {
            listaObjetos.RemoveAt(index);
        }

        public void removeLastObj()
        {
            listaObjetos.RemoveAt(listaObjetos.Count - 1);
        }

        public void drawEsc(Graphics lugar)
        {
            for (int i = 0; i < listaObjetos.Count; i++)
            {
                listaObjetos[i].drawObjeto(lugar, centroEsc);
            }
        }



    }
}
