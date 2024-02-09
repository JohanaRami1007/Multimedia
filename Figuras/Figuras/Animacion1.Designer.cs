namespace Figuras
{
    partial class Animacion2D
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
            btnReproducir2D = new Button();
            btnFinal = new Button();
            btnAtras = new Button();
            SuspendLayout();
            // 
            // btnReproducir2D
            // 
            btnReproducir2D.Location = new Point(296, 40);
            btnReproducir2D.Name = "btnReproducir2D";
            btnReproducir2D.Size = new Size(150, 54);
            btnReproducir2D.TabIndex = 0;
            btnReproducir2D.Text = "Reproducir Animacion";
            btnReproducir2D.UseVisualStyleBackColor = true;
            btnReproducir2D.Click += btnReproducir2D_Click;
            // 
            // btnFinal
            // 
            btnFinal.Location = new Point(654, 359);
            btnFinal.Name = "btnFinal";
            btnFinal.Size = new Size(113, 52);
            btnFinal.TabIndex = 1;
            btnFinal.Text = "Finalizar";
            btnFinal.UseVisualStyleBackColor = true;
            btnFinal.Click += btnFinal_Click;
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(22, 359);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(113, 52);
            btnAtras.TabIndex = 2;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // Animacion2D
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAtras);
            Controls.Add(btnFinal);
            Controls.Add(btnReproducir2D);
            Name = "Animacion2D";
            Text = "Animacion ";
            ResumeLayout(false);
        }

        #endregion

        private Button btnReproducir2D;
        private Button btnFinal;
        private Button btnAtras;
    }
}