using ProGraficas2.Datos;
using ProGraficas2.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProGraficas2
{
    public partial class Form1 : Form
    {
        private Escenario esc;

        private Objeto o;

        private Poligono p1; /*Techo Izq*/
        private Poligono p2; /*Pared Izq*/
        private Poligono p3; /*Pared Der*/
        private Poligono p4; /*Techo Der*/
        private Poligono p5; /*Ventana Pared Izq*/
        private Poligono p6; /*Puerta Pared Der*/

        
        private Punto centroEsc;
        private Punto centroObj;
        private Punto centroPol1;
        private Punto centroPol2;
        private Punto centroPol3;
        private Punto centroPol4;
        private Punto centroPol5;
        private Punto centroPol6;

        private Lapiz l;
        private Graphics g;

        public Form1()
        {
            l = new Lapiz();
            

            centroObj = new Punto(0, 0);
            centroEsc = new Punto(0, 0);
            setCentrosPol();
            setPol();
            cargarPuntos();

            o = new Objeto(centroObj);
            cargarPol();

            esc = new Escenario(centroEsc);            
            esc.addObj(o);

            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //g.ScaleTransform(1, 1); y+ hacia abajo; x+ derecha
            //g.ScaleTransform(-1, 1); y+ hacia abajo; x+ izquierda
            //g.ScaleTransform(-1, -1); y+ hacia arriba; x+ izquierda
            //g.ScaleTransform(1, -1); y+ hacia arriba; x+ derecha
            g = pictureBox1.CreateGraphics();
            g.TranslateTransform(pictureBox1.Width / 2, pictureBox1.Height / 2);
            g.ScaleTransform(1, -1);
            l.dibujar(g, esc, 75);
            l.ejes(g, pictureBox1.Width, pictureBox1.Height);
            
        }

        private void configPBox(Graphics g)
        {
        }

        private void cargarPuntos()
        {
            //Techo Izq
            p1.addPunto(new Punto(-1, 1));
            p1.addPunto(new Punto(0, 2));
            p1.addPunto(new Punto(1, 1));
            p1.addPunto(new Punto(-1, 1));

            //Pared Izq
            p2.addPunto(new Punto(1, 1));
            p2.addPunto(new Punto(1, -1));
            p2.addPunto(new Punto(-1, -1));
            p2.addPunto(new Punto(-1, 1));

            /*Pared Der*/
            p3.addPunto(new Punto(1, 1));
            p3.addPunto(new Punto(4, 1));
            p3.addPunto(new Punto(4, -1));
            p3.addPunto(new Punto(1, -1));

            /*Techo Der*/
            p4.addPunto(new Punto(0, 2));
            p4.addPunto(new Punto(3, 2));
            p4.addPunto(new Punto(4, 1));

            /*Ventana Pared Izq*/
            p5.addPunto(new Punto(-0.5f, 0.5f));
            p5.addPunto(new Punto(0.5f, 0.5f));
            p5.addPunto(new Punto(0.5f, -0.5f));
            p5.addPunto(new Punto(-0.5f, -0.5f));
            p5.addPunto(new Punto(-0.5f, 0.5f));

            /*Puerta Pared Der*/
            p6.addPunto(new Punto(2, -1));
            p6.addPunto(new Punto(2, 0.5f));
            p6.addPunto(new Punto(3, 0.5f));
            p6.addPunto(new Punto(3, -1));
        }

        private void setCentrosPol()
        {
            centroPol1 = new Punto(0, 0);
            centroPol2 = new Punto(0, 0);
            centroPol3 = new Punto(0, 0);
            centroPol4 = new Punto(0, 0);
            centroPol5 = new Punto(0, 0);
            centroPol6 = new Punto(0, 0);
        }

        private void setPol()
        {
            p1 = new Poligono(centroPol1, (byte)Poligono.TiposPol.CERRADO);
            p2 = new Poligono(centroPol2, (byte)Poligono.TiposPol.CERRADO);
            p3 = new Poligono(centroPol3, (byte)Poligono.TiposPol.CERRADO);
            p4 = new Poligono(centroPol4, (byte)Poligono.TiposPol.CERRADO);
            p5 = new Poligono(centroPol5, (byte)Poligono.TiposPol.CERRADO);
            p6 = new Poligono(centroPol6, (byte)Poligono.TiposPol.CERRADO);
        }

        private void cargarPol()
        {
            o.addPoligono(p1);
            o.addPoligono(p2);
            o.addPoligono(p3);
            o.addPoligono(p4);
            o.addPoligono(p5);
            o.addPoligono(p6);
        }


    }
}
