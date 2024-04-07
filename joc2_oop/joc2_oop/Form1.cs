using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace joc2_oop
{
    public partial class Form1 : Form
    {
        private HexMap hexMap;
        private int laturaHexagon = 50;
        public Form1()
        {
            InitializeComponent();
            hexMap = new HexMap(laturaHexagon);
            p.Paint += p_Paint;
            p.Click += p_Click;
            
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void despreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor: Ilinca Temneanu", "Despre");
        }

        private void p_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            hexMap.Deseneaza(g);
        }

        private void p_Click(object sender, EventArgs e)
        {
            Graphics g = p.CreateGraphics();
            hexMap.AdaugaHexagon(new Hexagon(1, 4) { Imagine=Image.FromFile(@"tree.png") });
            hexMap.AdaugaHexagon(new Hexagon(1, 5));
            hexMap.AdaugaHexagon(new Hexagon(1, 6) { Imagine = Image.FromFile(@"tree.png") });
            hexMap.AdaugaHexagon(new Hexagon(1, 7));
            hexMap.AdaugaHexagon(new Hexagon(1, 8) { Imagine = Image.FromFile(@"tree.png") });
            hexMap.AdaugaHexagon(new Hexagon(2, 4) { Imagine = Image.FromFile(@"tree.png") });
            hexMap.AdaugaHexagon(new Hexagon(2, 5) { Imagine = Image.FromFile(@"treasure_o.png") });
            hexMap.AdaugaHexagon(new Hexagon(2, 7) { Imagine = Image.FromFile(@"chest.png") });
            hexMap.AdaugaHexagon(new Hexagon(2, 8) { Imagine = Image.FromFile(@"tree.png") });
            hexMap.AdaugaHexagon(new Hexagon(2, 9) { Imagine = Image.FromFile(@"chest.png") });
            hexMap.AdaugaHexagon(new Hexagon(3, 3));
            hexMap.AdaugaHexagon(new Hexagon(3, 4) { Imagine = Image.FromFile(@"chest.png") });
            hexMap.AdaugaHexagon(new Hexagon(3, 5) { Imagine = Image.FromFile(@"tree.png") });
            hexMap.AdaugaHexagon(new Hexagon(3, 6) { Imagine = Image.FromFile(@"tree.png") });
            hexMap.AdaugaHexagon(new Hexagon(3, 7) { Imagine = Image.FromFile(@"tree.png") });
            hexMap.AdaugaHexagon(new Hexagon(3, 8));
            hexMap.AdaugaHexagon(new Hexagon(3, 9));
            hexMap.AdaugaHexagon(new Hexagon(4, 3));
            hexMap.AdaugaHexagon(new Hexagon(4, 4) { Imagine = Image.FromFile(@"tree.png") });
            hexMap.AdaugaHexagon(new Hexagon(4, 5) { Imagine = Image.FromFile(@"tree.png") });
            hexMap.AdaugaHexagon(new Hexagon(4, 6) { Imagine = Image.FromFile(@"treasure_o.png") });
            hexMap.AdaugaHexagon(new Hexagon(4, 7) { Imagine = Image.FromFile(@"chest.png") });
            hexMap.AdaugaHexagon(new Hexagon(4, 8) { Imagine = Image.FromFile(@"portal.png") });
            hexMap.AdaugaHexagon(new Hexagon(4, 9));
            hexMap.AdaugaHexagon(new Hexagon(4, 10) { Imagine = Image.FromFile(@"chest.png") });
            hexMap.AdaugaHexagon(new Hexagon(5, 2));
            hexMap.AdaugaHexagon(new Hexagon(5, 3));
            hexMap.AdaugaHexagon(new Hexagon(5, 4) { Imagine = Image.FromFile(@"treasure_o.png") });
            hexMap.AdaugaHexagon(new Hexagon(5, 5) { Imagine = Image.FromFile(@"tree.png") });
            hexMap.AdaugaHexagon(new Hexagon(5, 6) { Imagine = Image.FromFile(@"tree.png") });
            hexMap.AdaugaHexagon(new Hexagon(5, 7) { Imagine = Image.FromFile(@"treasure_o.png") });
            hexMap.AdaugaHexagon(new Hexagon(5, 8) { Imagine = Image.FromFile(@"chest.png") });
            hexMap.AdaugaHexagon(new Hexagon(5, 9) { Imagine = Image.FromFile(@"tree.png") });
            hexMap.AdaugaHexagon(new Hexagon(5, 10));
            hexMap.AdaugaHexagon(new Hexagon(6, 3) { Imagine = Image.FromFile(@"tree.png") });
            hexMap.AdaugaHexagon(new Hexagon(6, 4));
            hexMap.AdaugaHexagon(new Hexagon(6, 5) { Imagine = Image.FromFile(@"tree.png") });
            hexMap.AdaugaHexagon(new Hexagon(6, 6) { Imagine = Image.FromFile(@"treasure_o.png") });
            hexMap.AdaugaHexagon(new Hexagon(6, 7) { Imagine = Image.FromFile(@"tree.png") });
            hexMap.AdaugaHexagon(new Hexagon(6, 8) { Imagine = Image.FromFile(@"tree.png") });
            hexMap.AdaugaHexagon(new Hexagon(6, 9) { Imagine = Image.FromFile(@"tree.png") });
            hexMap.AdaugaHexagon(new Hexagon(6, 10));
            hexMap.AdaugaHexagon(new Hexagon(7, 3));
            hexMap.AdaugaHexagon(new Hexagon(7, 4) { Imagine = Image.FromFile(@"tree.png") });
            hexMap.AdaugaHexagon(new Hexagon(7, 5));
            hexMap.AdaugaHexagon(new Hexagon(7, 6));
            hexMap.AdaugaHexagon(new Hexagon(7, 7));
            hexMap.AdaugaHexagon(new Hexagon(7, 8) { Imagine = Image.FromFile(@"tree.png") });
            hexMap.AdaugaHexagon(new Hexagon(7, 9) { Imagine = Image.FromFile(@"treasure_o.png") });
            hexMap.AdaugaHexagon(new Hexagon(8, 4) { Imagine = Image.FromFile(@"treasure_o.png") });
            hexMap.AdaugaHexagon(new Hexagon(8, 5) { Imagine = Image.FromFile(@"portal.png") });
            hexMap.AdaugaHexagon(new Hexagon(8, 6) { Imagine = Image.FromFile(@"tree.png") });
            hexMap.AdaugaHexagon(new Hexagon(8, 7) { Imagine = Image.FromFile(@"tree.png") });
            hexMap.AdaugaHexagon(new Hexagon(8, 8));
            hexMap.AdaugaHexagon(new Hexagon(8, 9));
            hexMap.AdaugaHexagon(new Hexagon(9, 4));
            hexMap.AdaugaHexagon(new Hexagon(9, 5));
            hexMap.AdaugaHexagon(new Hexagon(9, 6) { Imagine = Image.FromFile(@"chest.png") });
            hexMap.AdaugaHexagon(new Hexagon(9, 7));
            hexMap.AdaugaHexagon(new Hexagon(9, 8) { Imagine = Image.FromFile(@"tree.png") });

            hexMap.Deseneaza(g);
            p.Invalidate();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            p.Refresh();
        }
    }
}