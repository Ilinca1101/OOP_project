using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace joc2_oop
{
    public class Hexagon
    {

        
        public int Rand { get; set; }
        public int Coloana { get; set; }
        public Image Imagine { get; set; } //pt imagine
        



        public Hexagon( int rand, int coloana)
        {
            
            Rand = rand;
            Coloana = coloana;
            
        }
    }
    public class HexMap
    {
        private List<Hexagon> hexagoane;
        private int latura;

        public HexMap(int latura)
        {
            hexagoane = new List<Hexagon>();
            this.latura = latura;
        }

        public void Deseneaza(Graphics g)
        {
            foreach (Hexagon hexagon in hexagoane)
            {
                int x = CalculCoordonataX(hexagon.Rand, hexagon.Coloana, latura);
                int y = CalculCoordonataY(hexagon.Rand, latura);
                if (hexagon.Rand == 5 && hexagon.Coloana == 2)
                {
                    // Hexagonul de pe poziția (5, 2)
                    DeseneazaHexagon(g, x, y, hexagon);

                    // Adăugăm textul "Start" pe hexagon
                    Font font = new Font("Arial", 12, FontStyle.Bold);
                    Brush brush = Brushes.White;
                    PointF textLocation = new PointF(x + latura / 2 - 50, y + latura / 2 - 40);
                    g.DrawString("Start", font, brush, textLocation);
                }
               
                
                else
                {
                    DeseneazaHexagon(g, x, y, hexagon);
                }
                if (hexagon.Rand == 5 && hexagon.Coloana == 10)
                {
                    // Hexagonul de pe poziția (5, 10)
                    DeseneazaHexagon(g, x, y, hexagon);

                    // Adăugăm textul "Stop" pe hexagon
                    Font font = new Font("Arial", 12, FontStyle.Bold);
                    Brush brush = Brushes.White;
                    PointF textLocation = new PointF(x + latura / 2 - 50, y + latura / 2 - 40);
                    g.DrawString("Stop", font, brush, textLocation);
                }
                if (hexagon.Rand == 5 && hexagon.Coloana == 3)
                {
                    // Hexagonul de pe poziția (5, 3)
                    DeseneazaHexagon(g, x, y, hexagon);

                    // Adăugăm textul "+10" pe hexagon
                    Font font = new Font("Arial", 18, FontStyle.Bold);
                    Brush brush = Brushes.Green;
                    
                    PointF textLocation = new PointF(x + latura / 2 - 50, y + latura / 2 - 40);
                    g.DrawString("+10", font, brush, textLocation);
                }
                if (hexagon.Rand == 6 && hexagon.Coloana == 4)
                {
                    // Hexagonul de pe poziția (6, 4)
                    DeseneazaHexagon(g, x, y, hexagon);

                    // Adăugăm textul "+5" pe hexagon
                    Font font = new Font("Arial", 18, FontStyle.Bold);
                    Brush brush = Brushes.Green;

                    PointF textLocation = new PointF(x + latura / 2 - 50, y + latura / 2 - 40);
                    g.DrawString("+5", font, brush, textLocation);
                }
                if (hexagon.Rand == 6 && hexagon.Coloana == 10)
                {
                    // Hexagonul de pe poziția (6, 10)
                    DeseneazaHexagon(g, x, y, hexagon);

                    // Adăugăm textul "+5" pe hexagon
                    Font font = new Font("Arial", 18, FontStyle.Bold);
                    Brush brush = Brushes.Green;

                    PointF textLocation = new PointF(x + latura / 2 - 50, y + latura / 2 - 40);
                    g.DrawString("+5", font, brush, textLocation);
                }
                if (hexagon.Rand == 1 && hexagon.Coloana == 5)
                {
                    
                    DeseneazaHexagon(g, x, y, hexagon);

                    
                    Font font = new Font("Arial", 18, FontStyle.Bold);
                    Brush brush = Brushes.Green;

                    PointF textLocation = new PointF(x + latura / 2 - 50, y + latura / 2 - 40);
                    g.DrawString("+5", font, brush, textLocation);
                }
                if (hexagon.Rand == 1 && hexagon.Coloana == 7)
                {

                    DeseneazaHexagon(g, x, y, hexagon);


                    Font font = new Font("Arial", 18, FontStyle.Bold);
                    Brush brush = Brushes.Green;

                    PointF textLocation = new PointF(x + latura / 2 - 50, y + latura / 2 - 40);
                    g.DrawString("-10", font, brush, textLocation);
                }
                if (hexagon.Rand == 2 && hexagon.Coloana == 6)
                {

                    DeseneazaHexagon(g, x, y, hexagon);


                    Font font = new Font("Arial", 18, FontStyle.Bold);
                    Brush brush = Brushes.Green;

                    PointF textLocation = new PointF(x + latura / 2 - 50, y + latura / 2 - 40);
                    g.DrawString("+10", font, brush, textLocation);
                }
                if (hexagon.Rand == 3 && hexagon.Coloana == 3)
                {

                    DeseneazaHexagon(g, x, y, hexagon);


                    Font font = new Font("Arial", 18, FontStyle.Bold);
                    Brush brush = Brushes.Green;

                    PointF textLocation = new PointF(x + latura / 2 - 50, y + latura / 2 - 40);
                    g.DrawString("-10", font, brush, textLocation);
                }
                if (hexagon.Rand == 3 && hexagon.Coloana == 8)
                {

                    DeseneazaHexagon(g, x, y, hexagon);


                    Font font = new Font("Arial", 18, FontStyle.Bold);
                    Brush brush = Brushes.Green;

                    PointF textLocation = new PointF(x + latura / 2 - 50, y + latura / 2 - 40);
                    g.DrawString("-15", font, brush, textLocation);
                }
                if (hexagon.Rand == 3 && hexagon.Coloana == 9)
                {

                    DeseneazaHexagon(g, x, y, hexagon);


                    Font font = new Font("Arial", 18, FontStyle.Bold);
                    Brush brush = Brushes.Green;

                    PointF textLocation = new PointF(x + latura / 2 - 50, y + latura / 2 - 40);
                    g.DrawString("+5", font, brush, textLocation);
                }
                if (hexagon.Rand == 4 && hexagon.Coloana == 3)
                {

                    DeseneazaHexagon(g, x, y, hexagon);


                    Font font = new Font("Arial", 18, FontStyle.Bold);
                    Brush brush = Brushes.Green;

                    PointF textLocation = new PointF(x + latura / 2 - 50, y + latura / 2 - 40);
                    g.DrawString("+5", font, brush, textLocation);
                }
                if (hexagon.Rand == 4 && hexagon.Coloana == 9)
                {

                    DeseneazaHexagon(g, x, y, hexagon);


                    Font font = new Font("Arial", 18, FontStyle.Bold);
                    Brush brush = Brushes.Green;

                    PointF textLocation = new PointF(x + latura / 2 - 50, y + latura / 2 - 40);
                    g.DrawString("+5", font, brush, textLocation);
                }
                if (hexagon.Rand == 7 && hexagon.Coloana == 3)
                {

                    DeseneazaHexagon(g, x, y, hexagon);


                    Font font = new Font("Arial", 18, FontStyle.Bold);
                    Brush brush = Brushes.Green;

                    PointF textLocation = new PointF(x + latura / 2 - 50, y + latura / 2 - 40);
                    g.DrawString("-10", font, brush, textLocation);
                }
                if (hexagon.Rand == 7 && hexagon.Coloana == 5)
                {

                    DeseneazaHexagon(g, x, y, hexagon);


                    Font font = new Font("Arial", 18, FontStyle.Bold);
                    Brush brush = Brushes.Green;

                    PointF textLocation = new PointF(x + latura / 2 - 50, y + latura / 2 - 40);
                    g.DrawString("-15", font, brush, textLocation);
                }
                if (hexagon.Rand == 7 && hexagon.Coloana == 6)
                {

                    DeseneazaHexagon(g, x, y, hexagon);


                    Font font = new Font("Arial", 18, FontStyle.Bold);
                    Brush brush = Brushes.Green;

                    PointF textLocation = new PointF(x + latura / 2 - 50, y + latura / 2 - 40);
                    g.DrawString("+5", font, brush, textLocation);
                }
                if (hexagon.Rand == 7 && hexagon.Coloana == 7)
                {

                    DeseneazaHexagon(g, x, y, hexagon);


                    Font font = new Font("Arial", 18, FontStyle.Bold);
                    Brush brush = Brushes.Green;

                    PointF textLocation = new PointF(x + latura / 2 - 50, y + latura / 2 - 40);
                    g.DrawString("+15", font, brush, textLocation);
                }
                if (hexagon.Rand == 8 && hexagon.Coloana == 8)
                {

                    DeseneazaHexagon(g, x, y, hexagon);


                    Font font = new Font("Arial", 18, FontStyle.Bold);
                    Brush brush = Brushes.Green;

                    PointF textLocation = new PointF(x + latura / 2 - 50, y + latura / 2 - 40);
                    g.DrawString("+5", font, brush, textLocation);
                }
                if (hexagon.Rand == 8 && hexagon.Coloana == 9)
                {

                    DeseneazaHexagon(g, x, y, hexagon);


                    Font font = new Font("Arial", 18, FontStyle.Bold);
                    Brush brush = Brushes.Green;

                    PointF textLocation = new PointF(x + latura / 2 - 50, y + latura / 2 - 40);
                    g.DrawString("-10", font, brush, textLocation);
                }
                if (hexagon.Rand == 9 && hexagon.Coloana == 4)
                {

                    DeseneazaHexagon(g, x, y, hexagon);


                    Font font = new Font("Arial", 18, FontStyle.Bold);
                    Brush brush = Brushes.Green;

                    PointF textLocation = new PointF(x + latura / 2 - 50, y + latura / 2 - 40);
                    g.DrawString("-10", font, brush, textLocation);
                }
                if (hexagon.Rand == 9 && hexagon.Coloana == 5)
                {

                    DeseneazaHexagon(g, x, y, hexagon);


                    Font font = new Font("Arial", 18, FontStyle.Bold);
                    Brush brush = Brushes.Green;

                    PointF textLocation = new PointF(x + latura / 2 - 50, y + latura / 2 - 40);
                    g.DrawString("+15", font, brush, textLocation);
                }
                if (hexagon.Rand == 9 && hexagon.Coloana == 7)
                {

                    DeseneazaHexagon(g, x, y, hexagon);


                    Font font = new Font("Arial", 18, FontStyle.Bold);
                    Brush brush = Brushes.Green;

                    PointF textLocation = new PointF(x + latura / 2 - 50, y + latura / 2 - 40);
                    g.DrawString("+10", font, brush, textLocation);
                }




            }
        }

        private int CalculCoordonataX(int rand, int coloana, int latura)
        {
            int offsetX = (int)(latura * Math.Sqrt(3)); // Offset pe axa X pentru fiecare coloană

            if (rand % 2 == 0) // Rand par
                return coloana * offsetX;
            else // Rand impar
                return coloana * offsetX + offsetX / 2;
        }

        private int CalculCoordonataY(int rand, int latura)
        {
            int offsetY = latura * 3 / 2; // Offset pe axa Y pentru fiecare rand

            return rand * offsetY;
        }

        private void DeseneazaHexagon(Graphics g, int x, int y, Hexagon hexagon)
        {
            float innerRadius = latura * (float)Math.Sqrt(3) / 2; // Calculează raza interioară a hexagonului
            float outerRadius = latura;

            PointF[] puncte = new PointF[6];
            puncte[0] = new PointF(x, y - outerRadius);
            puncte[1] = new PointF(x + innerRadius, y - outerRadius / 2);
            puncte[2] = new PointF(x + innerRadius, y + outerRadius / 2);
            puncte[3] = new PointF(x, y + outerRadius);
            puncte[4] = new PointF(x - innerRadius, y + outerRadius / 2);
            puncte[5] = new PointF(x - innerRadius, y - outerRadius / 2);

            g.DrawPolygon(Pens.Black, puncte);
            if (hexagon.Rand == 5 && hexagon.Coloana == 2)
            {
                Brush brush = Brushes.Red;
                g.FillPolygon(brush, puncte);
            }
            if (hexagon.Rand == 5 && hexagon.Coloana == 10)
            {
                Brush brush = Brushes.Blue;
                g.FillPolygon(brush, puncte);
            }
            
            if(hexagon.Imagine!=null)
            {
                int imageX = x - latura / 2;
                int imageY = y - latura / 2;
                g.DrawImage(hexagon.Imagine, imageX, imageY, latura, latura);   
            }



        }

        public void AdaugaHexagon(Hexagon hexagon)
        {
            hexagoane.Add(hexagon);
        }
        
    }
}


