using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProGraficas2.Datos
{
    class Objeto
    {
        private List<Poligono> listaPoligonos;
        private Punto centroObj;


        public Objeto()
        {
            listaPoligonos = new List<Poligono>();
            centroObj = new Punto(0,0);
        }

        public Objeto(Punto p)
        {
            listaPoligonos = new List<Poligono>();
            centroObj = p;
        }

        public Punto CentroObj
        {
            get { return centroObj; }
            set { centroObj = value; }
        }

        public List<Poligono> ListaPoligonos
        {
            get { return listaPoligonos; }
            set { listaPoligonos = value; }
        }

        public void addPoligono(Poligono pol)
        {
            listaPoligonos.Add(pol);
        }

        public Poligono getPol(int index)
        {
            return listaPoligonos[index];
        }

        public void removeIndexOf(int index)
        {
            listaPoligonos.RemoveAt(index);
        }



    }
}
