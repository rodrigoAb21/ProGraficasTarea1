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
        private Poligono p1;
        private Poligono p2;
        private Poligono p3;
        private Poligono p4;
        
        private Dibujo l;

        private Graphics pb;
        

        public Form1()
        {
            p1 = new Poligono(new Punto(0, 0));
            p1.addPunto(new Punto(-30, 10));
            p1.addPunto(new Punto(-10, 10));
            p1.addPunto(new Punto(-10, -10));
            p1.addPunto(new Punto(-30, -10));
            p1.addPunto(new Punto(-30, 10));

            p2 = new Poligono(new Punto(0, 0));
            p2.addPunto(new Punto(-30, 10));
            p2.addPunto(new Punto(-20, 20));
            p2.addPunto(new Punto(-10, 10));

            p3 = new Poligono(new Punto(0, 0));
            p3.addPunto(new Punto(-20, 20));
            p3.addPunto(new Punto(10, 20));
            p3.addPunto(new Punto(20, 10));
            p3.addPunto(new Punto(-20, 10));

            p4 = new Poligono(new Punto(0, 0));
            p4.addPunto(new Punto(20, 10));
            p4.addPunto(new Punto(20, -10));
            p4.addPunto(new Punto(-30, -10));



            o = new Objeto(new Punto(0, 0));
            o.addPoligono(p1);
            o.addPoligono(p2);
            o.addPoligono(p3);
            o.addPoligono(p4);

            esc = new Escenario(new Punto(0, 0));
            esc.addObj(o);
            l = new Dibujo();
            InitializeComponent();
        }

        //g.ScaleTransform(1, 1); y+ hacia abajo; x+ derecha
        //g.ScaleTransform(-1, 1); y+ hacia abajo; x+ izquierda
        //g.ScaleTransform(-1, -1); y+ hacia arriba; x+ izquierda
        //g.ScaleTransform(1, -1); y+ hacia arriba; x+ derecha

        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            if (pb != null)
            {
                pb.Clear(Color.White);
                pb = pictureBox1.CreateGraphics();
                pb.TranslateTransform(pictureBox1.Width / 2, pictureBox1.Height / 2);
                pb.ScaleTransform(1, -1);
                l.dibujar2(pb, esc, pictureBox1.Height, pictureBox1.Width);
                l.ejes(pb, pictureBox1.Width, pictureBox1.Height);
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (pb != null)
            {
                pb.Clear(Color.White);
            }
                Punto centro = new Punto(e.X * 100 / pictureBox1.Width, e.Y * 100 / pictureBox1.Height);
                centro.X = centro.X - 50;
                centro.Y = -centro.Y + 50;
                esc.CentroEsc = centro;
                pb = pictureBox1.CreateGraphics();
                pb.TranslateTransform(pictureBox1.Width / 2, pictureBox1.Height / 2);
                pb.ScaleTransform(1, -1);
                l.dibujar2(pb, esc, pictureBox1.Height, pictureBox1.Width);
                l.ejes(pb, pictureBox1.Width, pictureBox1.Height);
        }
    }
}
