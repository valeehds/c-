namespace juegoNums
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.numero = new System.Windows.Forms.TextBox();
            this.BtnComprobar = new System.Windows.Forms.Button();
            this.intentos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.panelNumeros = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // numero
            // 
            this.numero.BackColor = System.Drawing.Color.White;
            this.numero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numero.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero.ForeColor = System.Drawing.Color.LimeGreen;
            this.numero.Location = new System.Drawing.Point(46, 172);
            this.numero.Multiline = true;
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(329, 31);
            this.numero.TabIndex = 0;
            this.numero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnComprobar
            // 
            this.BtnComprobar.BackColor = System.Drawing.Color.LightGreen;
            this.BtnComprobar.CausesValidation = false;
            this.BtnComprobar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnComprobar.FlatAppearance.BorderSize = 0;
            this.BtnComprobar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnComprobar.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnComprobar.Location = new System.Drawing.Point(381, 172);
            this.BtnComprobar.Name = "BtnComprobar";
            this.BtnComprobar.Size = new System.Drawing.Size(136, 31);
            this.BtnComprobar.TabIndex = 1;
            this.BtnComprobar.Text = "Comprobar";
            this.BtnComprobar.UseVisualStyleBackColor = false;
            this.BtnComprobar.Click += new System.EventHandler(this.BtnComprobar_Click);
            // 
            // intentos
            // 
            this.intentos.BackColor = System.Drawing.Color.Honeydew;
            this.intentos.Cursor = System.Windows.Forms.Cursors.No;
            this.intentos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intentos.ForeColor = System.Drawing.Color.LimeGreen;
            this.intentos.Location = new System.Drawing.Point(451, 50);
            this.intentos.Name = "intentos";
            this.intentos.Size = new System.Drawing.Size(66, 65);
            this.intentos.TabIndex = 2;
            this.intentos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Intento número";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingresa un número";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Números ingresados";
            // 
            // labelResultado
            // 
            this.labelResultado.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.labelResultado.Location = new System.Drawing.Point(42, 235);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(475, 26);
            this.labelResultado.TabIndex = 7;
            this.labelResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelNumeros
            // 
            this.panelNumeros.BackColor = System.Drawing.Color.Honeydew;
            this.panelNumeros.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panelNumeros.Location = new System.Drawing.Point(46, 304);
            this.panelNumeros.Name = "panelNumeros";
            this.panelNumeros.Size = new System.Drawing.Size(471, 56);
            this.panelNumeros.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(151, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.BtnComprobar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(557, 408);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelNumeros);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.intentos);
            this.Controls.Add(this.BtnComprobar);
            this.Controls.Add(this.numero);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Adivinar números";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numero;
        private System.Windows.Forms.Button BtnComprobar;
        private System.Windows.Forms.Label intentos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Panel panelNumeros;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

