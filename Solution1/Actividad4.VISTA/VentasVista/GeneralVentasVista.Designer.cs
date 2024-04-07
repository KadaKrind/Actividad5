namespace Actividad4.VISTA.VentasVista
{
    partial class GeneralVentasVista
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(100, 177);
            button1.Name = "button1";
            button1.Size = new Size(146, 75);
            button1.TabIndex = 0;
            button1.Text = "Agregar Venta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(290, 177);
            button2.Name = "button2";
            button2.Size = new Size(134, 75);
            button2.TabIndex = 1;
            button2.Text = "Ver ventas";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(460, 177);
            button3.Name = "button3";
            button3.Size = new Size(125, 75);
            button3.TabIndex = 2;
            button3.Text = "Ver DetalleVenta";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // GeneralVentasVista
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "GeneralVentasVista";
            Text = "GeneralVentasVista";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
    }
}