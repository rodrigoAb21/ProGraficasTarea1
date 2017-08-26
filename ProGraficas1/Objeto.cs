using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProGraficas1
{
    class Objeto
    {
        List<Poligono> listaPoligonos;
        Punto centroObj;
        Pen lapiz = new Pen(Color.DarkRed, 1);

        public Objeto()
        {
            listaPoligonos = new List<Poligono>();
            centroObj = new Punto(0, 0);
        }

        public Objeto(Punto Centro)
        {
            listaPoligonos = new List<Poligono>();
            centroObj = new Punto(Centro.getX(), Centro.getY());
        }

        public Objeto(int x, int y)
        {
            listaPoligonos = new List<Poligono>();
            centroObj = new Punto(x, y); 
        }

        public void setCentroObj(int x, int y)
        {
            centroObj.setX(x);
            centroObj.setY(y);
        }

        public void setCentroObj(Punto Centro)
        {
            centroObj = Centro;
        }

        public Punto getCentroObj()
        {
            return centroObj;
        }

        public void addPoligono(Poligono pol)
        {
            listaPoligonos.Add(pol);
        }

        public void removePolIndexOf(int index)
        {
            listaPoligonos.RemoveAt(index);
        }

        public void removeLastPol()
        {
            listaPoligonos.RemoveAt(listaPoligonos.Count - 1);
        }
        public Poligono getPolIndexOf(int index)
        {
            return listaPoligonos[index];
        }

        public void drawObjeto(Graphics lugar, Punto centroEsc)
        {
            for (int i = 0; i < listaPoligonos.Count; i++)
            {
                listaPoligonos[i].drawPol(lugar, centroEsc, centroObj);
            }
        }













    }
}
