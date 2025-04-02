using FigurasPolimorfismo.Factory;
using FigurasPolimorfismo.Figuras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasPolimorfismo
{
    public partial class Form1 : Form
    {
        private List<Figura> figuras = new List<Figura>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region
            cmbFigura.Items.Add("Rectangulo");
            cmbFigura.Items.Add("Circulo");
            cmbFigura.Items.Add("Triangulo");
            cmbFigura.Items.Add("Linea");
            cmbFigura.SelectedIndex = 0;
            #endregion
        }
        private void btnDibujar_Click(object sender, EventArgs e)
        {
            CrearDibujo();
        }

        private void CrearDibujo()
        {
            int coordenadaX, coordenadaY, tipo;
            string figuraNombre;
            Color color;
            try
            {
                if(!int.TryParse(txtCoordenadaX.Text,out coordenadaX) || !int.TryParse(txtCoordenadaY.Text, out coordenadaY)
                   || coordenadaY <=0 || coordenadaX <=0)
                {
                    MessageBox.Show("Por favor ingrese valores válidos");
                    return;
                }
                if (colorDialog1.ShowDialog() != DialogResult.OK)
                {
                    MessageBox.Show("Por favor seleccione un color");
                    return;
                }
                figuraNombre = cmbFigura.SelectedItem.ToString();
                if (!Enum.TryParse(figuraNombre, true, out NombresFiguras parsedFigura))
                {
                    MessageBox.Show("Figura no válida");
                    return;
                }
                color = colorDialog1.Color;
                btnColorFigura.BackColor = color;
                tipo = (int)parsedFigura; 
                coordenadaX = int.Parse(txtCoordenadaX.Text);
                coordenadaY = int.Parse(txtCoordenadaY.Text);

                Figura figura = FiguraFactory.CrearFigura(coordenadaX, coordenadaY,color,tipo);

                figuras.Add(figura);
                lblContador.Text = figuras.Count.ToString();
                plDibujar.Invalidate();

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Ocurrió un error al crear el dibujo "+ex);
            }
        }

        private void plDibujar_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            foreach (Figura figura in figuras)
            {
                figura.Dibujar(e.Graphics);
            }
        }
    }
}
