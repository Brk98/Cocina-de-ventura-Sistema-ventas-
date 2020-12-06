namespace La_Cocina_de_Ventura2.Gerente
{
    partial class Reportes
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
            this.CFechaInicial = new System.Windows.Forms.MonthCalendar();
            this.CFechaFinal = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FechaInicial = new System.Windows.Forms.Label();
            this.FechaFinal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CFechaInicial
            // 
            this.CFechaInicial.Location = new System.Drawing.Point(139, 165);
            this.CFechaInicial.Name = "CFechaInicial";
            this.CFechaInicial.TabIndex = 2;
            this.CFechaInicial.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.CFechaInicial_DateChanged);
            // 
            // CFechaFinal
            // 
            this.CFechaFinal.Location = new System.Drawing.Point(562, 165);
            this.CFechaFinal.Name = "CFechaFinal";
            this.CFechaFinal.TabIndex = 3;
            this.CFechaFinal.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.CFechaFinal_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha Inicial";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(612, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 48);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha Final";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FechaInicial
            // 
            this.FechaInicial.AutoSize = true;
            this.FechaInicial.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaInicial.Location = new System.Drawing.Point(180, 381);
            this.FechaInicial.Name = "FechaInicial";
            this.FechaInicial.Size = new System.Drawing.Size(0, 29);
            this.FechaInicial.TabIndex = 6;
            this.FechaInicial.Click += new System.EventHandler(this.FechaInicial_Click);
            // 
            // FechaFinal
            // 
            this.FechaFinal.AutoSize = true;
            this.FechaFinal.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaFinal.Location = new System.Drawing.Point(615, 381);
            this.FechaFinal.Name = "FechaFinal";
            this.FechaFinal.Size = new System.Drawing.Size(0, 29);
            this.FechaFinal.TabIndex = 7;
            this.FechaFinal.Click += new System.EventHandler(this.FechaFinal_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(361, 497);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(295, 115);
            this.button1.TabIndex = 8;
            this.button1.Text = "Gererar Reporte en Excel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::La_Cocina_de_Ventura2.Properties.Resources.excel;
            this.pictureBox1.Location = new System.Drawing.Point(469, 629);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FechaFinal);
            this.Controls.Add(this.FechaInicial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CFechaFinal);
            this.Controls.Add(this.CFechaInicial);
            this.Name = "Reportes";
            this.Size = new System.Drawing.Size(994, 722);
            this.Load += new System.EventHandler(this.Reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar CFechaInicial;
        private System.Windows.Forms.MonthCalendar CFechaFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label FechaInicial;
        private System.Windows.Forms.Label FechaFinal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
