namespace FigurasPolimorfismo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCoordenadaX = new System.Windows.Forms.TextBox();
            this.txtCoordenadaY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.plDibujar = new System.Windows.Forms.Panel();
            this.btnColorFigura = new System.Windows.Forms.Button();
            this.btnDibujar = new System.Windows.Forms.Button();
            this.cmbFigura = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblContador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCoordenadaX
            // 
            this.txtCoordenadaX.Location = new System.Drawing.Point(12, 46);
            this.txtCoordenadaX.Name = "txtCoordenadaX";
            this.txtCoordenadaX.Size = new System.Drawing.Size(100, 20);
            this.txtCoordenadaX.TabIndex = 0;
            // 
            // txtCoordenadaY
            // 
            this.txtCoordenadaY.Location = new System.Drawing.Point(138, 46);
            this.txtCoordenadaY.Name = "txtCoordenadaY";
            this.txtCoordenadaY.Size = new System.Drawing.Size(100, 20);
            this.txtCoordenadaY.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Coordenada 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Coordenada 2";
            // 
            // plDibujar
            // 
            this.plDibujar.Location = new System.Drawing.Point(0, 90);
            this.plDibujar.Name = "plDibujar";
            this.plDibujar.Size = new System.Drawing.Size(807, 364);
            this.plDibujar.TabIndex = 4;
            this.plDibujar.Paint += new System.Windows.Forms.PaintEventHandler(this.plDibujar_Paint);
            // 
            // btnColorFigura
            // 
            this.btnColorFigura.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnColorFigura.Location = new System.Drawing.Point(582, 40);
            this.btnColorFigura.Name = "btnColorFigura";
            this.btnColorFigura.Size = new System.Drawing.Size(25, 23);
            this.btnColorFigura.TabIndex = 5;
            this.btnColorFigura.UseVisualStyleBackColor = true;
            // 
            // btnDibujar
            // 
            this.btnDibujar.Location = new System.Drawing.Point(687, 43);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(89, 23);
            this.btnDibujar.TabIndex = 6;
            this.btnDibujar.Text = "Dibujar";
            this.btnDibujar.UseVisualStyleBackColor = true;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // cmbFigura
            // 
            this.cmbFigura.FormattingEnabled = true;
            this.cmbFigura.Location = new System.Drawing.Point(262, 45);
            this.cmbFigura.Name = "cmbFigura";
            this.cmbFigura.Size = new System.Drawing.Size(121, 21);
            this.cmbFigura.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Figura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Contador";
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(435, 49);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(35, 13);
            this.lblContador.TabIndex = 10;
            this.lblContador.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbFigura);
            this.Controls.Add(this.btnDibujar);
            this.Controls.Add(this.btnColorFigura);
            this.Controls.Add(this.plDibujar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCoordenadaY);
            this.Controls.Add(this.txtCoordenadaX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCoordenadaX;
        private System.Windows.Forms.TextBox txtCoordenadaY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel plDibujar;
        private System.Windows.Forms.Button btnColorFigura;
        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.ComboBox cmbFigura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblContador;
    }
}

