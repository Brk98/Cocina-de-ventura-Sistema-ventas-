namespace La_Cocina_de_Ventura2.Menu
{
    partial class EspecialesMenu
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
            this.ChileRelleno = new System.Windows.Forms.NumericUpDown();
            this.EspecialesB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ChileRelleno)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 40);
            this.label4.TabIndex = 18;
            this.label4.Text = "Chile Relleno";
            // 
            // ChileRelleno
            // 
            this.ChileRelleno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChileRelleno.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChileRelleno.Location = new System.Drawing.Point(332, 26);
            this.ChileRelleno.Name = "ChileRelleno";
            this.ChileRelleno.Size = new System.Drawing.Size(68, 40);
            this.ChileRelleno.TabIndex = 17;
            this.ChileRelleno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EspecialesB
            // 
            this.EspecialesB.BackColor = System.Drawing.Color.Transparent;
            this.EspecialesB.BackgroundImage = global::La_Cocina_de_Ventura2.Properties.Resources.Rectángulo_19;
            this.EspecialesB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EspecialesB.FlatAppearance.BorderSize = 0;
            this.EspecialesB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EspecialesB.Font = new System.Drawing.Font("Bahnschrift", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EspecialesB.ForeColor = System.Drawing.Color.White;
            this.EspecialesB.Location = new System.Drawing.Point(664, 577);
            this.EspecialesB.Name = "EspecialesB";
            this.EspecialesB.Size = new System.Drawing.Size(193, 79);
            this.EspecialesB.TabIndex = 16;
            this.EspecialesB.Text = "Añadir";
            this.EspecialesB.UseVisualStyleBackColor = false;
            this.EspecialesB.Click += new System.EventHandler(this.EspecialesB_Click);
            // 
            // EspecialesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ChileRelleno);
            this.Controls.Add(this.EspecialesB);
            this.Name = "EspecialesMenu";
            this.Size = new System.Drawing.Size(860, 659);
            ((System.ComponentModel.ISupportInitialize)(this.ChileRelleno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown ChileRelleno;
        private System.Windows.Forms.Button EspecialesB;
    }
}
