using ProGraficas2.Datos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProGraficas2.Vista
{
    class Lapiz
    {
        private Pen lapiz;

        public Lapiz()
        {
            lapiz = new Pen(Color.Black, 3);
        }

        public void dibujar(Graphics g, Escenario e, int factor)
        {
            lapiz.Color = Color.Black;
            for (int i = 0; i < e.ListaObjetos.Count; i++)
            {
                Objeto o = e.ListaObjetos[i];
                for (int j = 0; j < o.ListaPoligonos.Count; j++)
                {
                    Poligono p = o.ListaPoligonos[j];
                    for (int k = 0; k < p.ListaPuntos.Count - 1; k++)
                    {
                        g.DrawLine(lapiz, 
                            p.ListaPuntos[k].EjeX * factor + p.CentroPol.EjeX * factor + o.CentroObj.EjeX * factor + e.CentroEsc.EjeX * factor,
                            p.ListaPuntos[k].EjeY * factor + p.CentroPol.EjeY * factor + o.CentroObj.EjeY * factor + e.CentroEsc.EjeY * factor,
                            p.ListaPuntos[k + 1].EjeX * factor + p.CentroPol.EjeX * factor + o.CentroObj.EjeX * factor + e.CentroEsc.EjeX * factor,
                            p.ListaPuntos[k + 1].EjeY * factor + p.CentroPol.EjeY * factor + o.CentroObj.EjeY * factor + e.CentroEsc.EjeY * factor);
                    }
                }
            }
        }


        public void ejes(Graphics g, int w, int h)
        {
            lapiz.Color = Color.Red;
            lapiz.Width = 1;
            g.DrawLine(lapiz, 0, h/2, 0, -h/2);
            g.DrawLine(lapiz, w / 2, 0, -w / 2, 0);
        }

    }
}
