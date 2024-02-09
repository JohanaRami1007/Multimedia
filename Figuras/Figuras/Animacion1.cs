using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using Timer = System.Windows.Forms.Timer;

namespace Figuras
{
    public partial class Animacion2D : Form
    {
        private List<Pelota> pelotas;
        private Timer timer;
        private SoundPlayer soundPlayer;
        public Animacion2D()
        {
            InitializeComponent();

            pelotas = new List<Pelota>();
            timer = new Timer();
            timer.Interval = 50;
            timer.Tick += new EventHandler(MoverPelotas);

            soundPlayer = new SoundPlayer(Path.Combine(Application.StartupPath, "Sonidos", "rebote.wav"));

            // Agregar dos pelotas al inicio
            AgregarPelota(100, 100, 8, 4, Brushes.Blue, this);
            AgregarPelota(200, 200, -6, 5, Brushes.Red, this);
        }

        private void btnReproducir2D_Click(object sender, EventArgs e)
        {
            // Iniciar el temporizador para el movimiento
            timer.Start();
        }

        private void AgregarPelota(int x, int y, int velocidadX, int velocidadY, Brush color, Animacion2D animacion)
        {
            Pelota nuevaPelota = new Pelota(x, y, velocidadX, velocidadY, color, animacion);
            pelotas.Add(nuevaPelota);
        }

        private void MoverPelotas(object sender, EventArgs e)
        {
            // Mover cada pelota y manejar el rebote en los bordes
            foreach (Pelota pelota in pelotas)
            {
                pelota.Mover();
                pelota.RebotarEnBordes(ClientSize.Width, ClientSize.Height);
            }

            // Llamar al método para dibujar todas las pelotas
            DibujarPelotas();
        }

        private void DibujarPelotas()
        {
            // Crear un objeto Graphics para dibujar en el formulario
            using (Graphics g = this.CreateGraphics())
            {
                g.Clear(BackColor);

                // Dibujar cada pelota
                foreach (Pelota pelota in pelotas)
                {
                    g.FillEllipse(pelota.Color, pelota.X - pelota.Radio, pelota.Y - pelota.Radio, 2 * pelota.Radio, 2 * pelota.Radio);
                }
            }
        }

        // Clase que representa una pelota
        private class Pelota
        {
            private Animacion2D animacion;
            public int X { get; set; }
            public int Y { get; set; }
            public int Radio { get; private set; }
            private int VelocidadX { get; set; }
            private int VelocidadY { get; set; }
            public Brush Color { get; private set; }


            public Pelota(int x, int y, int velocidadX, int velocidadY, Brush color, Animacion2D animacion)
            {
                X = x;
                Y = y;
                Radio = 40;
                VelocidadX = velocidadX;
                VelocidadY = velocidadY;
                Color = color;
                this.animacion = animacion;
            }

            public void Mover()
            {
                // Actualizar las coordenadas para simular el movimiento
                X += VelocidadX;
                Y += VelocidadY;
            }

            public void RebotarEnBordes(int anchoFormulario, int altoFormulario)
            {
                bool rebote = false;

                // Verificar y ajustar el rebote en los bordes horizontales
                if (X - Radio < 0 || X + Radio > anchoFormulario)
                {
                    VelocidadX = -VelocidadX; // Invertir la dirección
                    rebote = true;
                }

                // Verificar y ajustar el rebote en los bordes verticales
                if (Y - Radio < 0 || Y + Radio > altoFormulario)
                {
                    VelocidadY = -VelocidadY; // Invertir la dirección
                    rebote = true;
                }

                // Si hay rebote, reproducir el sonido
                if (rebote)
                {
                    animacion.soundPlayer.Play();
                }
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Figura3D figura3D = new Figura3D();
            figura3D.Show();
            this.Hide();
        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            this.Hide();
            Animacion3D animacion3D = new Animacion3D();
            animacion3D.Show();
        }
    }
}
