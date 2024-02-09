using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Figuras
{
    public partial class Figura3D : Form
    {
        private List<Triangulo3D> triangulos3D;

        public Figura3D()
        {
            InitializeComponent();
            triangulos3D = new List<Triangulo3D>();
        }

        private void btnPintar3D_Click(object sender, EventArgs e)
        {
            // Agregar un cubo 3D
            AgregarCubo3D();
        }

        private void AgregarCubo3D()
        {
            Cubo3D nuevoCubo3D = new Cubo3D();
            triangulos3D.AddRange(nuevoCubo3D.ObtenerTriangulos());

            // Dibujar el cubo 3D
            DibujarTriangulos3D();
        }

        private void DibujarTriangulos3D()
        {
            // Crear un objeto Graphics para dibujar en el formulario
            using (Graphics g = this.CreateGraphics())
            {
                // Limpiar el fondo
                g.Clear(BackColor);

                // Dibujar cada triángulo 3D
                foreach (Triangulo3D triangulo3D in triangulos3D)
                {
                    // Proyectar y dibujar el triángulo 3D
                    triangulo3D.Dibujar(g, ClientSize.Width, ClientSize.Height);
                }
            }
        }

        // Clase que representa un triángulo 3D
        private class Triangulo3D
        {
            protected Point3D[] vertices;

            public Triangulo3D(Point3D v1, Point3D v2, Point3D v3)
            {
                // Definir los vértices del triángulo en el espacio 3D
                vertices = new Point3D[] { v1, v2, v3 };
            }

            // Función para proyectar y dibujar el triángulo en el formulario
            public void Dibujar(Graphics g, int anchoFormulario, int altoFormulario)
            {
                // Proyectar cada vértice en el espacio 3D a la pantalla 2D
                Point[] puntosProyectados = new Point[vertices.Length];
                for (int i = 0; i < vertices.Length; i++)
                {
                    puntosProyectados[i] = Proyectar(vertices[i], anchoFormulario, altoFormulario);
                }

                // Dibujar el triángulo en la pantalla 2D
                g.FillPolygon(Brushes.Green, puntosProyectados);
            }

            // Función para proyectar un punto 3D a la pantalla 2D
            private Point Proyectar(Point3D punto3D, int anchoFormulario, int altoFormulario)
            {
                // Puedes ajustar estos valores según tus necesidades
                double distanciaCamara = 400;
                double factorEscala = distanciaCamara / (distanciaCamara + punto3D.Z);

                int xProyectado = (int)(punto3D.X * factorEscala) + anchoFormulario / 2;
                int yProyectado = (int)(punto3D.Y * factorEscala) + altoFormulario / 2;

                return new Point(xProyectado, yProyectado);
            }
        }

        // Clase que representa un punto en el espacio 3D
        private class Point3D
        {
            public double X { get; set; }
            public double Y { get; set; }
            public double Z { get; set; }

            public Point3D(double x, double y, double z)
            {
                X = x;
                Y = y;
                Z = z;
            }
        }

        // Clase que representa un cubo 3D
        private class Cubo3D
        {
            private Point3D[] vertices;

            public Cubo3D()
            {
                // Definir los vértices del cubo en el espacio 3D
                vertices = new Point3D[]
                {
                    new Point3D(100, 100, 0),
                    new Point3D(200, 100, 0),
                    new Point3D(200, 200, 0),
                    new Point3D(100, 200, 0),
                    new Point3D(100, 100, 100),
                    new Point3D(200, 100, 100),
                    new Point3D(200, 200, 100),
                    new Point3D(100, 200, 100),
                };
            }

            // Función para obtener los triángulos que forman el cubo
            public List<Triangulo3D> ObtenerTriangulos()
            {
                List<Triangulo3D> triangulos = new List<Triangulo3D>
                {
                    // Cara frontal
                    new Triangulo3D(vertices[0], vertices[1], vertices[2]),
                    new Triangulo3D(vertices[0], vertices[2], vertices[3]),
                    // Cara trasera
                    new Triangulo3D(vertices[4], vertices[5], vertices[6]),
                    new Triangulo3D(vertices[4], vertices[6], vertices[7]),
                    // Lados laterales
                    new Triangulo3D(vertices[0], vertices[4], vertices[7]),
                    new Triangulo3D(vertices[0], vertices[7], vertices[3]),
                    new Triangulo3D(vertices[1], vertices[5], vertices[6]),
                    new Triangulo3D(vertices[1], vertices[6], vertices[2]),
                    // Otros lados
                    new Triangulo3D(vertices[3], vertices[2], vertices[6]),
                    new Triangulo3D(vertices[3], vertices[6], vertices[7]),
                    new Triangulo3D(vertices[0], vertices[1], vertices[5]),
                    new Triangulo3D(vertices[0], vertices[5], vertices[4]),
                };

                return triangulos;
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Animacion2D segundoFormulario = new Animacion2D();
            segundoFormulario.Show();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Figura2D figura2D = new Figura2D();
            figura2D.Show();
            this.Hide();
        }
    }
}
