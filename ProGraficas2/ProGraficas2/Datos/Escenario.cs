using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProGraficas2.Datos
{
    class Escenario
    {
        private List<Objeto> listaObj;
        private Punto centroEsc;

        public Escenario()
        {
            listaObj = new List<Objeto>();
            centroEsc = new Punto(0, 0);
        }

        public Escenario(Punto Centro)
        {
            listaObj = new List<Objeto>();
            centroEsc = Centro;
        }

        public Punto CentroEsc
        {
            get { return centroEsc; }
            set { centroEsc = value; }
        }

        public void addObj(Objeto o)
        {
            listaObj.Add(o);
        }

        public Objeto getObj(int index)
        {
            return listaObj[index];
        }

        public void removeIndexOf(int index)
        {
            listaObj.RemoveAt(index);
        }

    }
}
