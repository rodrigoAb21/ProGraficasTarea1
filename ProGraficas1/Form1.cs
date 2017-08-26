using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace ProGraficas1
{
    public partial class Form1 : Form
    {
        private Escenario e;

        private Objeto o;

        private Poligono p1;
        private Poligono p2;
        private Poligono p3;
        private Poligono p4;
        private Poligono p5;
        private Poligono p6;

        
        private Punto centroEsc;
        private Punto centroObj;
        private Punto centroPol1;
        private Punto centroPol2;
        private Punto centroPol3;
        private Punto centroPol4;
        private Punto centroPol5;
        private Punto centroPol6;

        public Form1()
        {
            centroEsc = new Punto(0, 0);
            centroObj = new Punto(0, 0);
            centroPol1 = new Punto(0, 0);
            centroPol2 = new Punto(0, 0);
            centroPol3 = new Punto(0, 0);
            centroPol4 = new Punto(0, 0);
            centroPol5 = new Punto(0, 0);
            centroPol6 = new Punto(0, 0);

            e = new Escenario(centroEsc);

            p1 = new Poligono(centroPol1);
            p2 = new Poligono(centroPol2);
            p3 = new Poligono(centroPol3);
            p4 = new Poligono(centroPol4);
            p5 = new Poligono(centroPol5);
            p6 = new Poligono(centroPol6);

            o = new Objeto(centroObj);

            /*Techo Izq*/
            p1.addPunto(200, 200);
            p1.addPunto(300, 100);
            p1.addPunto(400, 200);
            p1.addPunto(200, 200);

            /*Pared Izq*/
            p2.addPunto(200, 200);
            p2.addPunto(200, 400);
            p2.addPunto(400, 400);
            p2.addPunto(400, 200);

            /*Pared Der*/
            p3.addPunto(400, 200);
            p3.addPunto(700, 200);
            p3.addPunto(700, 400);
            p3.addPunto(400, 400);

            /*Techo Der*/
            p4.addPunto(300, 100);
            p4.addPunto(600, 100);
            p4.addPunto(700, 200);

            /*Ventana Pared Izq*/
            p5.addPunto(250, 250);
            p5.addPunto(350, 250);
            p5.addPunto(350, 300);
            p5.addPunto(250, 300);
            p5.addPunto(250, 250);

            /*Puerta Pared Der*/
            p6.addPunto(500, 400);
            p6.addPunto(500, 250);
            p6.addPunto(600, 250);
            p6.addPunto(600, 400);

            o.addPoligono(p1);
            o.addPoligono(p2);
            o.addPoligono(p3);
            o.addPoligono(p4);
            o.addPoligono(p5);
            o.addPoligono(p6);

            e.addObj(o);

            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.e.drawEsc(pictureBox1.CreateGraphics());
        }
    }
}
