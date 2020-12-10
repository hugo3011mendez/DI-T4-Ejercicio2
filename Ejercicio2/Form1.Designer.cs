namespace Ejercicio2
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtG = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnImagen = new System.Windows.Forms.Button();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.lblErrorColor = new System.Windows.Forms.Label();
            this.lblErrorImagen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSalir.Location = new System.Drawing.Point(12, 406);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(79, 31);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.MouseEnter += new System.EventHandler(this.pasarPorBoton);
            this.btnSalir.MouseLeave += new System.EventHandler(this.salirBoton);
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(68, 12);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(107, 20);
            this.txtR.TabIndex = 0;
            this.txtR.Click += new System.EventHandler(this.cambiarAcceptButton);
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(252, 12);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(107, 20);
            this.txtG.TabIndex = 1;
            this.txtG.Click += new System.EventHandler(this.cambiarAcceptButton);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(443, 12);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(107, 20);
            this.txtB.TabIndex = 2;
            this.txtB.Click += new System.EventHandler(this.cambiarAcceptButton);
            // 
            // btnColor
            // 
            this.btnColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnColor.Location = new System.Drawing.Point(252, 69);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(92, 52);
            this.btnColor.TabIndex = 3;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            this.btnColor.MouseEnter += new System.EventHandler(this.pasarPorBoton);
            this.btnColor.MouseLeave += new System.EventHandler(this.salirBoton);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(61, 265);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(200, 20);
            this.txtPath.TabIndex = 5;
            this.txtPath.Click += new System.EventHandler(this.cambiarAcceptButton);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPath.Location = new System.Drawing.Point(9, 268);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(46, 17);
            this.lblPath.TabIndex = 6;
            this.lblPath.Text = "Ruta :";
            // 
            // btnImagen
            // 
            this.btnImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnImagen.Location = new System.Drawing.Point(267, 250);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(85, 47);
            this.btnImagen.TabIndex = 6;
            this.btnImagen.Text = "Cargar Imagen";
            this.btnImagen.UseVisualStyleBackColor = true;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            this.btnImagen.MouseEnter += new System.EventHandler(this.pasarPorBoton);
            this.btnImagen.MouseLeave += new System.EventHandler(this.salirBoton);
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(358, 174);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(254, 158);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 7;
            this.pbImagen.TabStop = false;
            // 
            // lblErrorColor
            // 
            this.lblErrorColor.AutoSize = true;
            this.lblErrorColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblErrorColor.ForeColor = System.Drawing.Color.Red;
            this.lblErrorColor.Location = new System.Drawing.Point(8, 140);
            this.lblErrorColor.Name = "lblErrorColor";
            this.lblErrorColor.Size = new System.Drawing.Size(153, 24);
            this.lblErrorColor.TabIndex = 4;
            this.lblErrorColor.Text = "Label Error Color";
            // 
            // lblErrorImagen
            // 
            this.lblErrorImagen.AutoSize = true;
            this.lblErrorImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblErrorImagen.ForeColor = System.Drawing.Color.Red;
            this.lblErrorImagen.Location = new System.Drawing.Point(12, 355);
            this.lblErrorImagen.Name = "lblErrorImagen";
            this.lblErrorImagen.Size = new System.Drawing.Size(165, 24);
            this.lblErrorImagen.TabIndex = 7;
            this.lblErrorImagen.Text = "Label Eror Imagen";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnColor;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(631, 449);
            this.Controls.Add(this.lblErrorImagen);
            this.Controls.Add(this.lblErrorColor);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.btnImagen);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.btnSalir);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Label lblErrorColor;
        private System.Windows.Forms.Label lblErrorImagen;
    }
}

