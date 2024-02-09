using System;

namespace Figuras
{
    public partial class Figura2D : Form
    {
        private bool dibujarRectangulo = false;
        private int x = 210;
        private int y = 180;
        private int ancho = 300;
        private int alto = 150;

        public Figura2D()
        {
            InitializeComponent();

            this.Paint += Pintar2D_Paint;
        }

        private void btnPintar2D_Click(object sender, EventArgs e)
        {
            dibujarRectangulo = true;
            this.Invalidate();
        }

        private void Pintar2D_Paint(object sender, PaintEventArgs e)
        {
            if (dibujarRectangulo)
            {
                Graphics g = e.Graphics;

                //Pen pen = new Pen(Color.Black);
                Brush brush = new SolidBrush(Color.Red);

                // Dibujar el rectángulo
                //g.DrawRectangle(pen, x, y, ancho, alto);
                g.FillRectangle(brush, x, y, ancho, alto);

            }
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            // Ocultar el Formulario1 (en lugar de cerrarlo)
            this.Hide();

            // Crear una instancia del segundo formulario
            Figura3D segundoFormulario = new Figura3D();

            // Mostrar el segundo formulario
            segundoFormulario.Show();
        }
    }
}
