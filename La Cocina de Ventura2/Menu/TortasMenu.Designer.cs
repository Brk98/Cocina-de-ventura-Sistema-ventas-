namespace La_Cocina_de_Ventura2.Menu
{
    partial class TortasMenu
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.BolilloGuisado = new System.Windows.Forms.NumericUpDown();
            this.TortasB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BolilloGuisado)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 40);
            this.label4.TabIndex = 15;
            this.label4.Text = "Bolillo con Guisado";
            // 
            // BolilloGuisado
            // 
            this.BolilloGuisado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BolilloGuisado.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BolilloGuisado.Location = new System.Drawing.Point(332, 26);
            this.BolilloGuisado.Name = "BolilloGuisado";
            this.BolilloGuisado.Size = new System.Drawing.Size(68, 40);
            this.BolilloGuisado.TabIndex = 14;
            this.BolilloGuisado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TortasB
            // 
            this.TortasB.BackColor = System.Drawing.Color.Transparent;
            this.TortasB.BackgroundImage = global::La_Cocina_de_Ventura2.Properties.Resources.Rectángulo_19;
            this.TortasB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TortasB.FlatAppearance.BorderSize = 0;
            this.TortasB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TortasB.Font = new System.Drawing.Font("Bahnschrift", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TortasB.ForeColor = System.Drawing.Color.White;
            this.TortasB.Location = new System.Drawing.Point(664, 577);
            this.TortasB.Name = "TortasB";
            this.TortasB.Size = new System.Drawing.Size(193, 79);
            this.TortasB.TabIndex = 13;
            this.TortasB.Text = "Añadir";
            this.TortasB.UseVisualStyleBackColor = false;
            this.TortasB.Click += new System.EventHandler(this.TortasB_Click);
            // 
            // TortasMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BolilloGuisado);
            this.Controls.Add(this.TortasB);
            this.Name = "TortasMenu";
            this.Size = new System.Drawing.Size(860, 659);
            ((System.ComponentModel.ISupportInitialize)(this.BolilloGuisado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown BolilloGuisado;
        private System.Windows.Forms.Button TortasB;
    }
}
