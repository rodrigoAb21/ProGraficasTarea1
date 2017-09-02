using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProGraficas2.Datos
{
    class Escenario
    {
        private List<Objeto> listaObjetos;
        private Punto centroEsc;

        public Escenario()
        {
            listaObjetos = new List<Objeto>();
            centroEsc = new Punto(0, 0);
        }

        public Escenario(Punto Centro)
        {
            listaObjetos = new List<Objeto>();
            centroEsc = Centro;
        }

        public Punto CentroEsc
        {
            get { return centroEsc; }
            set { centroEsc = value; }
        }

        public List<Objeto> ListaObjetos
        {
            get { return listaObjetos; }
            set { listaObjetos = value; }
        }

        public void addObj(Objeto o)
        {
            listaObjetos.Add(o);
        }

        public Objeto getObj(int index)
        {
            return listaObjetos[index];
        }

        public void removeIndexOf(int index)
        {
            listaObjetos.RemoveAt(index);
        }

    }
}
