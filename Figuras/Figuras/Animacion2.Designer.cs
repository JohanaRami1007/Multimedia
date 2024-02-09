namespace Figuras
{
    partial class Animacion3D
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnReproducir3D = new Button();
            btnFinalizar = new Button();
            btnAtras = new Button();
            SuspendLayout();
            // 
            // btnReproducir3D
            // 
            btnReproducir3D.Location = new Point(302, 52);
            btnReproducir3D.Name = "btnReproducir3D";
            btnReproducir3D.Size = new Size(137, 54);
            btnReproducir3D.TabIndex = 0;
            btnReproducir3D.Text = "Reproducir animacion";
            btnReproducir3D.UseVisualStyleBackColor = true;
            btnReproducir3D.Click += btnReproducir3D_Click;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(611, 353);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(154, 47);
            btnFinalizar.TabIndex = 1;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(23, 351);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(154, 49);
            btnAtras.TabIndex = 2;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // Animacion3D
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAtras);
            Controls.Add(btnFinalizar);
            Controls.Add(btnReproducir3D);
            Name = "Animacion3D";
            Text = "Animacion";
            ResumeLayout(false);
        }

        #endregion

        private Button btnReproducir3D;
        private Button btnFinalizar;
        private Button btnAtras;
    }
}