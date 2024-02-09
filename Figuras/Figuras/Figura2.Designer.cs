namespace Figuras
{
    partial class Figura3D
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
            btnPintar3D = new Button();
            btnSiguiente = new Button();
            btnAtras = new Button();
            SuspendLayout();
            // 
            // btnPintar3D
            // 
            btnPintar3D.Location = new Point(298, 51);
            btnPintar3D.Name = "btnPintar3D";
            btnPintar3D.Size = new Size(125, 48);
            btnPintar3D.TabIndex = 0;
            btnPintar3D.Text = "Pintar Figura 3D";
            btnPintar3D.UseVisualStyleBackColor = true;
            btnPintar3D.Click += btnPintar3D_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(646, 368);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(128, 53);
            btnSiguiente.TabIndex = 1;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(24, 368);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(128, 53);
            btnAtras.TabIndex = 2;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // Figura3D
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAtras);
            Controls.Add(btnSiguiente);
            Controls.Add(btnPintar3D);
            Name = "Figura3D";
            Text = "Figura 3D";
            ResumeLayout(false);
        }

        #endregion

        private Button btnPintar3D;
        private Button btnSiguiente;
        private Button btnAtras;
    }
}