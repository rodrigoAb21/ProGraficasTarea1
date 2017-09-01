using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProGraficas2.Datos
{
    class Poligono
    {
        public enum TiposPol :byte { CERRADO, ABIERTO }

        private List<Punto> listaPuntos;
        private byte tipo;
        private Punto centroPol;

        
        
        public Poligono()
        {
            listaPuntos = new List<Punto>();
            tipo = (byte)TiposPol.CERRADO;
            centroPol = new Punto(0, 0);
        }

        public Poligono(Punto Centro, byte Tipo)
        {
            listaPuntos = new List<Punto>();
            tipo = Tipo;
            centroPol = Centro;
        }
        

        public void addPunto(Punto p)
        {
            listaPuntos.Add(p);
        }

        public Punto getPunto(int index)
        {
            return listaPuntos[index];
        }

        public void removeIndexOf(int index)
        {
            listaPuntos.RemoveAt(index);
        }

        public byte Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public Punto CentroPol
        {
            get { return centroPol; }
            set { centroPol = value; }
        }

        










    }
}
