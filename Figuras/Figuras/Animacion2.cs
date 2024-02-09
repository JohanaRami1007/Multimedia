using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Figuras
{
    public partial class Animacion3D : Form
    {
        private List<Triangulo3D> triangulos3D;
        private Timer timer;
        private double anguloRotacion = 0; // Ángulo de rotación inicial
        private double velocidadRotacion = 0.001; // Velocidad de rotación más lenta

        public Animacion3D()
        {
            InitializeComponent();
            triangulos3D = new List<Triangulo3D>();

            timer = new Timer();
            timer.Interval = 50; // Intervalo en milisegundos, ajusta según lo necesites
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Incrementa el ángulo de rotación para hacer que la figura rote
            anguloRotacion += velocidadRotacion; // Incremento más lento

            // Actualiza las coordenadas de los vértices de la figura rotada
            foreach (Triangulo3D triangulo3D in triangulos3D)
            {
                triangulo3D.Rotar(anguloRotacion);
            }

            // Vuelve a dibujar la figura
            DibujarTriangulos3D();
        }

        private void btnReproducir3D_Click(object sender, EventArgs e)
        {
            AgregarCubo3D();
        }

        private void AgregarCubo3D()
        {
            Cubo3D nuevoCubo3D = new Cubo3D();
            triangulos3D.AddRange(nuevoCubo3D.ObtenerTriangulos());
            DibujarTriangulos3D();
        }

        private void DibujarTriangulos3D()
        {
            using (Graphics g = this.CreateGraphics())
            {
                g.Clear(BackColor);
                foreach (Triangulo3D triangulo3D in triangulos3D)
                {
                    triangulo3D.Dibujar(g, ClientSize.Width, ClientSize.Height);
                }
            }
        }

        private class Triangulo3D
        {
            protected Point3D[] vertices;

            public Triangulo3D(Point3D v1, Point3D v2, Point3D v3)
            {
                vertices = new Point3D[] { v1, v2, v3 };
            }

            public void Dibujar(Graphics g, int anchoFormulario, int altoFormulario)
            {
                Point[] puntosProyectados = new Point[vertices.Length];
                for (int i = 0; i < vertices.Length; i++)
                {
                    puntosProyectados[i] = Proyectar(vertices[i], anchoFormulario, altoFormulario);
                }

                g.FillPolygon(Brushes.Green, puntosProyectados);
            }

            private Point Proyectar(Point3D punto3D, int anchoFormulario, int altoFormulario)
            {
                double distanciaCamara = 400;
                double factorEscala = distanciaCamara / (distanciaCamara + punto3D.Z);

                int xProyectado = (int)(punto3D.X * factorEscala) + anchoFormulario / 2;
                int yProyectado = (int)(punto3D.Y * factorEscala) + altoFormulario / 2;

                return new Point(xProyectado, yProyectado);
            }

            public void Rotar(double angulo)
            {
                // Rotación en el eje Y
                for (int i = 0; i < vertices.Length; i++)
                {
                    double x = vertices[i].X;
                    double z = vertices[i].Z;

                    vertices[i].X = x * Math.Cos(angulo) + z * Math.Sin(angulo);
                    vertices[i].Z = -x * Math.Sin(angulo) + z * Math.Cos(angulo);
                }
            }
        }

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

        private class Cubo3D
        {
            private Point3D[] vertices;

            public Cubo3D()
            {
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

            public List<Triangulo3D> ObtenerTriangulos()
            {
                List<Triangulo3D> triangulos = new List<Triangulo3D>
                {
                    new Triangulo3D(vertices[0], vertices[1], vertices[2]),
                    new Triangulo3D(vertices[0], vertices[2], vertices[3]),
                    new Triangulo3D(vertices[4], vertices[5], vertices[6]),
                    new Triangulo3D(vertices[4], vertices[6], vertices[7]),
                    new Triangulo3D(vertices[0], vertices[4], vertices[7]),
                    new Triangulo3D(vertices[0], vertices[7], vertices[3]),
                    new Triangulo3D(vertices[1], vertices[5], vertices[6]),
                    new Triangulo3D(vertices[1], vertices[6], vertices[2]),
                    new Triangulo3D(vertices[3], vertices[2], vertices[6]),
                    new Triangulo3D(vertices[3], vertices[6], vertices[7]),
                    new Triangulo3D(vertices[0], vertices[1], vertices[5]),
                    new Triangulo3D(vertices[0], vertices[5], vertices[4]),
                };

                return triangulos;
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Animacion3D animacion3D = new Animacion3D();
            animacion3D.Show();
            this.Hide();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}