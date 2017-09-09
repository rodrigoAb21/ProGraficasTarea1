using ProGraficas2.Datos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProGraficas2.Vista
{
    class Dibujo
    {
        private Pen lapiz;

        public Dibujo()
        {
            lapiz = new Pen(Color.Black, 3);
        }

        public void dibujar(Graphics g, Escenario e)
        {
            lapiz.Width = 3;
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
                            p.ListaPuntos[k].X  + p.CentroPol.X  + o.CentroObj.X  + e.CentroEsc.X,
                            p.ListaPuntos[k].Y  + p.CentroPol.Y  + o.CentroObj.Y  + e.CentroEsc.Y,
                            p.ListaPuntos[k + 1].X  + p.CentroPol.X  + o.CentroObj.X  + e.CentroEsc.X,
                            p.ListaPuntos[k + 1].Y  + p.CentroPol.Y  + o.CentroObj.Y  + e.CentroEsc.Y);
                    }
                }
            }
        }



        public void dibujar2(Graphics g, Escenario e, float alto, float ancho)
        {
            lapiz.Width = 3;
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
                            (p.ListaPuntos[k].X + p.CentroPol.X + o.CentroObj.X + e.CentroEsc.X)/ 100 * ancho,
                            (p.ListaPuntos[k].Y + p.CentroPol.Y + o.CentroObj.Y + e.CentroEsc.Y) / 100 * alto,
                            (p.ListaPuntos[k + 1].X+ p.CentroPol.X + o.CentroObj.X + e.CentroEsc.X) / 100 * ancho,
                            (p.ListaPuntos[k + 1].Y + p.CentroPol.Y + o.CentroObj.Y + e.CentroEsc.Y) / 100 * alto);
                    }
                }
            }
        }



        public void ejes(Graphics g, int w, int h)
        {
            lapiz.Width = 1;
            lapiz.Color = Color.Red;
            g.DrawLine(lapiz, 0, h/2, 0, -h/2);
            g.DrawLine(lapiz, w / 2, 0, -w / 2, 0);
        }

        public float mayorXEsc(Escenario e)
        {
            float mayor = float.MinValue;
            float actual;
            for (int i = 0; i < e.ListaObjetos.Count; i++)
            {
                Objeto o = e.ListaObjetos[i];
                for (int j = 0; j < o.ListaPoligonos.Count; j++)
                {
                    Poligono p = o.ListaPoligonos[j];
                    for (int k = 0; k < p.ListaPuntos.Count; k++)
                    {
                        actual = p.ListaPuntos[k].X + p.CentroPol.X + o.CentroObj.X + e.CentroEsc.X;
                        if (actual > mayor)
                        {
                            mayor = actual;
                        }
                    }
                }
            }
            return mayor;
        }

        public float mayorYEsc(Escenario e)
        {
            float mayor = float.MinValue;
            float actual;
            for (int i = 0; i < e.ListaObjetos.Count; i++)
            {
                Objeto o = e.ListaObjetos[i];
                for (int j = 0; j < o.ListaPoligonos.Count; j++)
                {
                    Poligono p = o.ListaPoligonos[j];
                    for (int k = 0; k < p.ListaPuntos.Count; k++)
                    {
                        actual = p.ListaPuntos[k].Y + p.CentroPol.Y + o.CentroObj.Y + e.CentroEsc.Y;
                        if (actual > mayor)
                        {
                            mayor = actual;
                        }
                    }
                }
            }
            return mayor;
        }

        public float menorXEsc(Escenario e)
        {
            float menor = float.MaxValue;
            float actual;
            for (int i = 0; i < e.ListaObjetos.Count; i++)
            {
                Objeto o = e.ListaObjetos[i];
                for (int j = 0; j < o.ListaPoligonos.Count; j++)
                {
                    Poligono p = o.ListaPoligonos[j];
                    for (int k = 0; k < p.ListaPuntos.Count; k++)
                    {
                        actual = p.ListaPuntos[k].X + p.CentroPol.X + o.CentroObj.X + e.CentroEsc.X;
                        if (actual < menor)
                        {
                            menor = actual;
                        }
                    }
                }
            }
            return menor;
        }

        public float menorYEsc(Escenario e)
        {
            float menor = float.MaxValue;
            float actual;
            for (int i = 0; i < e.ListaObjetos.Count; i++)
            {
                Objeto o = e.ListaObjetos[i];
                for (int j = 0; j < o.ListaPoligonos.Count; j++)
                {
                    Poligono p = o.ListaPoligonos[j];
                    for (int k = 0; k < p.ListaPuntos.Count; k++)
                    {
                        actual = p.ListaPuntos[k].Y + p.CentroPol.Y + o.CentroObj.Y + e.CentroEsc.Y;
                        if (actual < menor)
                        {
                            menor = actual;
                        }
                    }
                }
            }
            return menor;
        }

        public float mayorX(Objeto o)
        {
            float mayor = float.MinValue;
            float actual;
            for (int j = 0; j < o.ListaPoligonos.Count; j++)
            {
                Poligono p = o.ListaPoligonos[j];
                for (int k = 0; k < p.ListaPuntos.Count; k++)
                {
                    actual = p.ListaPuntos[k].X + p.CentroPol.X + o.CentroObj.X;
                    if (actual > mayor)
                    {
                        mayor = actual;
                    }
                }
            }
            return mayor;
        }

        public float mayorY(Objeto o)
        {
            float mayor = float.MinValue;
            float actual;
            for (int j = 0; j < o.ListaPoligonos.Count; j++)
            {
                Poligono p = o.ListaPoligonos[j];
                for (int k = 0; k < p.ListaPuntos.Count; k++)
                {
                    actual = p.ListaPuntos[k].Y + p.CentroPol.Y + o.CentroObj.Y;
                    if (actual > mayor)
                    {
                        mayor = actual;
                    }
                }
            }
            return mayor;
        }

        public float menorX(Objeto o)
        {
            float menor = float.MaxValue;
            float actual;
            for (int j = 0; j < o.ListaPoligonos.Count; j++)
            {
                Poligono p = o.ListaPoligonos[j];
                for (int k = 0; k < p.ListaPuntos.Count; k++)
                {
                    actual = p.ListaPuntos[k].X + p.CentroPol.X + o.CentroObj.X;
                    if (actual < menor)
                    {
                        menor = actual;
                    }
                }
            }
            return menor;
        }

        public float menorY(Objeto o)
        {
            float menor = float.MaxValue;
            float actual;
            for (int j = 0; j < o.ListaPoligonos.Count; j++)
            {
                Poligono p = o.ListaPoligonos[j];
                for (int k = 0; k < p.ListaPuntos.Count; k++)
                {
                    actual = p.ListaPuntos[k].Y + p.CentroPol.Y + o.CentroObj.Y;
                    if (actual < menor)
                    {
                        menor = actual;
                    }
                }
            }
            return menor;
        }

    }
}
