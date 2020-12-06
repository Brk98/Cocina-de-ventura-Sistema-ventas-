namespace La_Cocina_de_Ventura2
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dvgTotal = new System.Windows.Forms.DataGridView();
            this.ListaProductos = new System.Windows.Forms.DataGridView();
            this.orden = new System.Windows.Forms.Button();
            this.TotalL = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.BebidasI = new System.Windows.Forms.PictureBox();
            this.EspecialesI = new System.Windows.Forms.PictureBox();
            this.TortasI = new System.Windows.Forms.PictureBox();
            this.SopesTacosI = new System.Windows.Forms.PictureBox();
            this.QuesadillasI = new System.Windows.Forms.PictureBox();
            this.GorditasI = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BebidasI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EspecialesI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TortasI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SopesTacosI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuesadillasI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GorditasI)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.dvgTotal);
            this.panel1.Controls.Add(this.ListaProductos);
            this.panel1.Controls.Add(this.orden);
            this.panel1.Controls.Add(this.TotalL);
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Controls.Add(this.salir);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(869, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 820);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dvgTotal
            // 
            this.dvgTotal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvgTotal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvgTotal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(67)))), ((int)(((byte)(41)))));
            this.dvgTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgTotal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dvgTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgTotal.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgTotal.DefaultCellStyle = dataGridViewCellStyle1;
            this.dvgTotal.Location = new System.Drawing.Point(194, 600);
            this.dvgTotal.Name = "dvgTotal";
            this.dvgTotal.RowHeadersVisible = false;
            this.dvgTotal.RowHeadersWidth = 51;
            this.dvgTotal.RowTemplate.Height = 24;
            this.dvgTotal.Size = new System.Drawing.Size(190, 50);
            this.dvgTotal.TabIndex = 12;
            // 
            // ListaProductos
            // 
            this.ListaProductos.BackgroundColor = System.Drawing.Color.White;
            this.ListaProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListaProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaProductos.Location = new System.Drawing.Point(35, 158);
            this.ListaProductos.Name = "ListaProductos";
            this.ListaProductos.RowHeadersVisible = false;
            this.ListaProductos.RowHeadersWidth = 51;
            this.ListaProductos.RowTemplate.Height = 24;
            this.ListaProductos.Size = new System.Drawing.Size(352, 439);
            this.ListaProductos.TabIndex = 0;
            this.ListaProductos.DataSourceChanged += new System.EventHandler(this.ListaProductos_DataSourceChanged);
            this.ListaProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.ListaProductos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaProductos_CellEndEdit);
            this.ListaProductos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaProductos_CellValueChanged);
            // 
            // orden
            // 
            this.orden.BackColor = System.Drawing.Color.Transparent;
            this.orden.BackgroundImage = global::La_Cocina_de_Ventura2.Properties.Resources.Rectángulo_3;
            this.orden.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.orden.FlatAppearance.BorderSize = 0;
            this.orden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orden.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orden.Location = new System.Drawing.Point(35, 729);
            this.orden.Name = "orden";
            this.orden.Size = new System.Drawing.Size(352, 77);
            this.orden.TabIndex = 11;
            this.orden.Text = "Realizar Orden";
            this.orden.UseVisualStyleBackColor = false;
            this.orden.Click += new System.EventHandler(this.orden_Click);
            // 
            // TotalL
            // 
            this.TotalL.AutoSize = true;
            this.TotalL.BackColor = System.Drawing.Color.Transparent;
            this.TotalL.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalL.ForeColor = System.Drawing.Color.White;
            this.TotalL.Image = global::La_Cocina_de_Ventura2.Properties.Resources.Rectángulo_62;
            this.TotalL.Location = new System.Drawing.Point(51, 605);
            this.TotalL.Name = "TotalL";
            this.TotalL.Size = new System.Drawing.Size(128, 40);
            this.TotalL.TabIndex = 9;
            this.TotalL.Text = "Total   $ ";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Silver;
            this.pictureBox8.BackgroundImage = global::La_Cocina_de_Ventura2.Properties.Resources.Rectángulo_62;
            this.pictureBox8.Image = global::La_Cocina_de_Ventura2.Properties.Resources.Rectángulo_62;
            this.pictureBox8.Location = new System.Drawing.Point(35, 590);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(352, 63);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox8.TabIndex = 7;
            this.pictureBox8.TabStop = false;
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.Red;
            this.salir.FlatAppearance.BorderSize = 0;
            this.salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.ForeColor = System.Drawing.Color.White;
            this.salir.Location = new System.Drawing.Point(368, 0);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(51, 48);
            this.salir.TabIndex = 7;
            this.salir.Text = "X";
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(116, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ventas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Contenedor
            // 
            this.Contenedor.Location = new System.Drawing.Point(3, 158);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(860, 659);
            this.Contenedor.TabIndex = 7;
            this.Contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.Contenedor_Paint);
            // 
            // BebidasI
            // 
            this.BebidasI.Image = global::La_Cocina_de_Ventura2.Properties.Resources.Grupo_5;
            this.BebidasI.Location = new System.Drawing.Point(436, -4);
            this.BebidasI.Name = "BebidasI";
            this.BebidasI.Size = new System.Drawing.Size(151, 158);
            this.BebidasI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BebidasI.TabIndex = 4;
            this.BebidasI.TabStop = false;
            this.BebidasI.Click += new System.EventHandler(this.BebidasI_Click);
            // 
            // EspecialesI
            // 
            this.EspecialesI.Image = global::La_Cocina_de_Ventura2.Properties.Resources.Grupo_6;
            this.EspecialesI.Location = new System.Drawing.Point(716, -3);
            this.EspecialesI.Name = "EspecialesI";
            this.EspecialesI.Size = new System.Drawing.Size(151, 158);
            this.EspecialesI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EspecialesI.TabIndex = 6;
            this.EspecialesI.TabStop = false;
            this.EspecialesI.Click += new System.EventHandler(this.EspecialesI_Click);
            // 
            // TortasI
            // 
            this.TortasI.Image = global::La_Cocina_de_Ventura2.Properties.Resources.Grupo_8;
            this.TortasI.Location = new System.Drawing.Point(579, -4);
            this.TortasI.Name = "TortasI";
            this.TortasI.Size = new System.Drawing.Size(151, 158);
            this.TortasI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TortasI.TabIndex = 5;
            this.TortasI.TabStop = false;
            this.TortasI.Click += new System.EventHandler(this.TortasI_Click);
            // 
            // SopesTacosI
            // 
            this.SopesTacosI.Image = global::La_Cocina_de_Ventura2.Properties.Resources.Grupo_4;
            this.SopesTacosI.Location = new System.Drawing.Point(289, -4);
            this.SopesTacosI.Name = "SopesTacosI";
            this.SopesTacosI.Size = new System.Drawing.Size(151, 158);
            this.SopesTacosI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SopesTacosI.TabIndex = 3;
            this.SopesTacosI.TabStop = false;
            this.SopesTacosI.Click += new System.EventHandler(this.SopesTacosI_Click);
            // 
            // QuesadillasI
            // 
            this.QuesadillasI.Image = global::La_Cocina_de_Ventura2.Properties.Resources.Grupo_3;
            this.QuesadillasI.Location = new System.Drawing.Point(142, -4);
            this.QuesadillasI.Name = "QuesadillasI";
            this.QuesadillasI.Size = new System.Drawing.Size(151, 158);
            this.QuesadillasI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.QuesadillasI.TabIndex = 2;
            this.QuesadillasI.TabStop = false;
            this.QuesadillasI.Click += new System.EventHandler(this.QuesadillasI_Click);
            // 
            // GorditasI
            // 
            this.GorditasI.Image = global::La_Cocina_de_Ventura2.Properties.Resources.Grupo_2;
            this.GorditasI.Location = new System.Drawing.Point(-5, -4);
            this.GorditasI.Name = "GorditasI";
            this.GorditasI.Size = new System.Drawing.Size(151, 158);
            this.GorditasI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GorditasI.TabIndex = 1;
            this.GorditasI.TabStop = false;
            this.GorditasI.Click += new System.EventHandler(this.GorditasI_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1284, 818);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.BebidasI);
            this.Controls.Add(this.EspecialesI);
            this.Controls.Add(this.TortasI);
            this.Controls.Add(this.SopesTacosI);
            this.Controls.Add(this.QuesadillasI);
            this.Controls.Add(this.GorditasI);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BebidasI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EspecialesI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TortasI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SopesTacosI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuesadillasI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GorditasI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox GorditasI;
        private System.Windows.Forms.PictureBox QuesadillasI;
        private System.Windows.Forms.PictureBox SopesTacosI;
        private System.Windows.Forms.PictureBox BebidasI;
        private System.Windows.Forms.PictureBox TortasI;
        private System.Windows.Forms.PictureBox EspecialesI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label TotalL;
        private System.Windows.Forms.Button orden;
        private System.Windows.Forms.Panel Contenedor;
        private System.Windows.Forms.DataGridView ListaProductos;
        private System.Windows.Forms.DataGridView dvgTotal;
    }
}