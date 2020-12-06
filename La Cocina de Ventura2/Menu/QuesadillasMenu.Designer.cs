namespace La_Cocina_de_Ventura2.Menu
{
    partial class QuesadillasMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.QuesadillaDorada = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.QuesadillaComal = new System.Windows.Forms.NumericUpDown();
            this.QuesadillaB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.QuesadillaDorada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuesadillaComal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 40);
            this.label1.TabIndex = 12;
            this.label1.Text = "Quesadillas Dorada";
            // 
            // QuesadillaDorada
            // 
            this.QuesadillaDorada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuesadillaDorada.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuesadillaDorada.Location = new System.Drawing.Point(364, 81);
            this.QuesadillaDorada.Name = "QuesadillaDorada";
            this.QuesadillaDorada.Size = new System.Drawing.Size(68, 40);
            this.QuesadillaDorada.TabIndex = 11;
            this.QuesadillaDorada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(339, 40);
            this.label4.TabIndex = 10;
            this.label4.Text = "Quesadillas de Comal";
            // 
            // QuesadillaComal
            // 
            this.QuesadillaComal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuesadillaComal.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuesadillaComal.Location = new System.Drawing.Point(364, 26);
            this.QuesadillaComal.Name = "QuesadillaComal";
            this.QuesadillaComal.Size = new System.Drawing.Size(68, 40);
            this.QuesadillaComal.TabIndex = 9;
            this.QuesadillaComal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.QuesadillaComal.ValueChanged += new System.EventHandler(this.QuesadillaComal_ValueChanged);
            // 
            // QuesadillaB
            // 
            this.QuesadillaB.BackColor = System.Drawing.Color.Transparent;
            this.QuesadillaB.BackgroundImage = global::La_Cocina_de_Ventura2.Properties.Resources.Rectángulo_19;
            this.QuesadillaB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.QuesadillaB.FlatAppearance.BorderSize = 0;
            this.QuesadillaB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuesadillaB.Font = new System.Drawing.Font("Bahnschrift", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuesadillaB.ForeColor = System.Drawing.Color.White;
            this.QuesadillaB.Location = new System.Drawing.Point(664, 577);
            this.QuesadillaB.Name = "QuesadillaB";
            this.QuesadillaB.Size = new System.Drawing.Size(193, 79);
            this.QuesadillaB.TabIndex = 8;
            this.QuesadillaB.Text = "Añadir";
            this.QuesadillaB.UseVisualStyleBackColor = false;
            this.QuesadillaB.Click += new System.EventHandler(this.QuesadillaB_Click);
            // 
            // QuesadillasMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QuesadillaDorada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.QuesadillaComal);
            this.Controls.Add(this.QuesadillaB);
            this.Name = "QuesadillasMenu";
            this.Size = new System.Drawing.Size(860, 659);
            ((System.ComponentModel.ISupportInitialize)(this.QuesadillaDorada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuesadillaComal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown QuesadillaDorada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown QuesadillaComal;
        private System.Windows.Forms.Button QuesadillaB;
    }
}
