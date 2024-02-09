namespace Figuras
{
    partial class Figura2D
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPintar2D = new Button();
            btnSiguiente = new Button();
            SuspendLayout();
            // 
            // btnPintar2D
            // 
            btnPintar2D.Location = new Point(290, 50);
            btnPintar2D.Name = "btnPintar2D";
            btnPintar2D.Size = new Size(142, 54);
            btnPintar2D.TabIndex = 0;
            btnPintar2D.Text = "Pintar Figura 2D";
            btnPintar2D.UseVisualStyleBackColor = true;
            btnPintar2D.Click += btnPintar2D_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(619, 368);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(147, 52);
            btnSiguiente.TabIndex = 1;
            btnSiguiente.Text = "Siguente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += this.btnSiguiente_Click;
            // 
            // Figura2D
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSiguiente);
            Controls.Add(btnPintar2D);
            Name = "Figura2D";
            Text = "Figura 2D";
            ResumeLayout(false);
        }

        #endregion

        private Button btnPintar2D;
        private Button btnSiguiente;
    }
}
