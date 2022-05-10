namespace Calculadora
{
    partial class frmCalculadora
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
            this.txtNombre1 = new System.Windows.Forms.TextBox();
            this.txtNombre2 = new System.Windows.Forms.TextBox();
            this.lblNombre1 = new System.Windows.Forms.Label();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.btnSumar = new System.Windows.Forms.Button();
            this.btnRestar = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.txtResultat = new System.Windows.Forms.TextBox();
            this.lblResultat = new System.Windows.Forms.Label();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnPotencia = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombre1
            // 
            this.txtNombre1.Location = new System.Drawing.Point(149, 57);
            this.txtNombre1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre1.Name = "txtNombre1";
            this.txtNombre1.Size = new System.Drawing.Size(132, 22);
            this.txtNombre1.TabIndex = 0;
            this.txtNombre1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNombre2
            // 
            this.txtNombre2.Location = new System.Drawing.Point(149, 107);
            this.txtNombre2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre2.Name = "txtNombre2";
            this.txtNombre2.Size = new System.Drawing.Size(132, 22);
            this.txtNombre2.TabIndex = 1;
            this.txtNombre2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblNombre1
            // 
            this.lblNombre1.AutoSize = true;
            this.lblNombre1.Location = new System.Drawing.Point(71, 57);
            this.lblNombre1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre1.Name = "lblNombre1";
            this.lblNombre1.Size = new System.Drawing.Size(66, 16);
            this.lblNombre1.TabIndex = 2;
            this.lblNombre1.Text = "Nombre1:";
            // 
            // lblNombre2
            // 
            this.lblNombre2.AutoSize = true;
            this.lblNombre2.Location = new System.Drawing.Point(71, 107);
            this.lblNombre2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(66, 16);
            this.lblNombre2.TabIndex = 3;
            this.lblNombre2.Text = "Nombre2:";
            // 
            // btnSumar
            // 
            this.btnSumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumar.Location = new System.Drawing.Point(376, 71);
            this.btnSumar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(59, 50);
            this.btnSumar.TabIndex = 4;
            this.btnSumar.Text = "+";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // btnRestar
            // 
            this.btnRestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestar.Location = new System.Drawing.Point(376, 13);
            this.btnRestar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(59, 50);
            this.btnRestar.TabIndex = 5;
            this.btnRestar.Text = "-";
            this.btnRestar.UseVisualStyleBackColor = true;
            this.btnRestar.Click += new System.EventHandler(this.btnRestar_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicar.Location = new System.Drawing.Point(376, 187);
            this.btnMultiplicar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(59, 50);
            this.btnMultiplicar.TabIndex = 6;
            this.btnMultiplicar.Text = "*";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDividir.Location = new System.Drawing.Point(376, 129);
            this.btnDividir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(59, 50);
            this.btnDividir.TabIndex = 7;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // txtResultat
            // 
            this.txtResultat.Location = new System.Drawing.Point(149, 246);
            this.txtResultat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtResultat.Name = "txtResultat";
            this.txtResultat.ReadOnly = true;
            this.txtResultat.Size = new System.Drawing.Size(132, 22);
            this.txtResultat.TabIndex = 8;
            this.txtResultat.TabStop = false;
            this.txtResultat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.Location = new System.Drawing.Point(71, 246);
            this.lblResultat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(59, 16);
            this.lblResultat.TabIndex = 9;
            this.lblResultat.Text = "Resultat:";
            // 
            // btnMod
            // 
            this.btnMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMod.Location = new System.Drawing.Point(376, 303);
            this.btnMod.Margin = new System.Windows.Forms.Padding(4);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(59, 50);
            this.btnMod.TabIndex = 11;
            this.btnMod.Text = "MOD";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPotencia
            // 
            this.btnPotencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotencia.Location = new System.Drawing.Point(376, 245);
            this.btnPotencia.Margin = new System.Windows.Forms.Padding(4);
            this.btnPotencia.Name = "btnPotencia";
            this.btnPotencia.Size = new System.Drawing.Size(59, 50);
            this.btnPotencia.TabIndex = 12;
            this.btnPotencia.Text = "^";
            this.btnPotencia.UseVisualStyleBackColor = true;
            // 
            // btnIgual
            // 
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.Location = new System.Drawing.Point(293, 377);
            this.btnIgual.Margin = new System.Windows.Forms.Padding(4);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(142, 57);
            this.btnIgual.TabIndex = 13;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 447);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnPotencia);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.txtResultat);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnRestar);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.lblNombre2);
            this.Controls.Add(this.lblNombre1);
            this.Controls.Add(this.txtNombre2);
            this.Controls.Add(this.txtNombre1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCalculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.frmCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre1;
        private System.Windows.Forms.TextBox txtNombre2;
        private System.Windows.Forms.Label lblNombre1;
        private System.Windows.Forms.Label lblNombre2;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.TextBox txtResultat;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnPotencia;
        private System.Windows.Forms.Button btnIgual;
    }
}

