using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProGraficas1
{
    class Poligono
    {
        private List<Punto> listaPuntos;
        private Punto centroPol;
        private Pen lapiz = new Pen(Color.Black,4);

        public Poligono()
        {
            listaPuntos = new List<Punto>();
            centroPol = new Punto(0,0);
        }

        public Poligono(Punto Centro)
        {
            listaPuntos = new List<Punto>();
            centroPol = new Punto(Centro.getX(), Centro.getY());
        }

        public Poligono(int ejeX, int ejeY)
        {
            listaPuntos = new List<Punto>();
            centroPol = new Punto(ejeX, ejeY);
        }

        public void setCentroPol(int ejeX, int ejeY)
        {
            centroPol.setX(ejeX);
            centroPol.setY(ejeY);
        }

        public Punto getCentroPol()
        {
            return centroPol;
        }

        public void addPunto(int x, int y)
        {
            listaPuntos.Add(new Punto(x, y));
        }

        public void addPunto(Punto punto)
        {
            listaPuntos.Add(punto);
        }

        public void removePuntoIndexOf(int index)
        {
            listaPuntos.RemoveAt(index);
        }

        public void removeLastPunto()
        {
            listaPuntos.RemoveAt(listaPuntos.Count - 1);
        }

        public void drawPol(Graphics lugar, Punto centroEsc, Punto centroObj)
        {
            for (int i = 0; i < listaPuntos.Count - 1; i++)
            {
                lugar.DrawLine(lapiz, listaPuntos[i].getX() + centroEsc.getX() + centroObj.getX(), listaPuntos[i].getY() + centroEsc.getY()
                    + centroObj.getY(), listaPuntos[i + 1].getX() + centroEsc.getX() + centroObj.getX()
                    , listaPuntos[i + 1].getY() + centroEsc.getY() + centroObj.getY());
            }
        }



    }
}
