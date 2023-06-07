namespace escalaGrises
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pb_color = new System.Windows.Forms.PictureBox();
            this.pb_blancoNegro = new System.Windows.Forms.PictureBox();
            this.btn_cargar = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pb_bordes = new System.Windows.Forms.PictureBox();
            this.pb_binaria = new System.Windows.Forms.PictureBox();
            this.btn_grises = new System.Windows.Forms.Button();
            this.btn_binaria = new System.Windows.Forms.Button();
            this.btn_bordes = new System.Windows.Forms.Button();
            this.btn_histograma = new System.Windows.Forms.Button();
            this.btn_etiquetar = new System.Windows.Forms.Button();
            this.btn_reetiquetar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_color)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_blancoNegro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bordes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_binaria)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_color
            // 
            this.pb_color.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pb_color.Location = new System.Drawing.Point(15, 16);
            this.pb_color.Name = "pb_color";
            this.pb_color.Size = new System.Drawing.Size(369, 265);
            this.pb_color.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_color.TabIndex = 0;
            this.pb_color.TabStop = false;
            // 
            // pb_blancoNegro
            // 
            this.pb_blancoNegro.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pb_blancoNegro.Location = new System.Drawing.Point(409, 16);
            this.pb_blancoNegro.Name = "pb_blancoNegro";
            this.pb_blancoNegro.Size = new System.Drawing.Size(369, 265);
            this.pb_blancoNegro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_blancoNegro.TabIndex = 0;
            this.pb_blancoNegro.TabStop = false;
            // 
            // btn_cargar
            // 
            this.btn_cargar.Location = new System.Drawing.Point(87, 287);
            this.btn_cargar.Name = "btn_cargar";
            this.btn_cargar.Size = new System.Drawing.Size(185, 61);
            this.btn_cargar.TabIndex = 3;
            this.btn_cargar.Text = "Imagen Original";
            this.btn_cargar.UseVisualStyleBackColor = true;
            this.btn_cargar.Click += new System.EventHandler(this.btn_cargar_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 359);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1542, 265);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // pb_bordes
            // 
            this.pb_bordes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pb_bordes.Location = new System.Drawing.Point(1188, 16);
            this.pb_bordes.Name = "pb_bordes";
            this.pb_bordes.Size = new System.Drawing.Size(369, 265);
            this.pb_bordes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_bordes.TabIndex = 5;
            this.pb_bordes.TabStop = false;
            // 
            // pb_binaria
            // 
            this.pb_binaria.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pb_binaria.Location = new System.Drawing.Point(800, 16);
            this.pb_binaria.Name = "pb_binaria";
            this.pb_binaria.Size = new System.Drawing.Size(369, 265);
            this.pb_binaria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_binaria.TabIndex = 6;
            this.pb_binaria.TabStop = false;
            // 
            // btn_grises
            // 
            this.btn_grises.Location = new System.Drawing.Point(480, 287);
            this.btn_grises.Name = "btn_grises";
            this.btn_grises.Size = new System.Drawing.Size(209, 60);
            this.btn_grises.TabIndex = 7;
            this.btn_grises.Text = "Escala Grises";
            this.btn_grises.UseVisualStyleBackColor = true;
            this.btn_grises.Click += new System.EventHandler(this.btn_grises_Click);
            // 
            // btn_binaria
            // 
            this.btn_binaria.Location = new System.Drawing.Point(875, 287);
            this.btn_binaria.Name = "btn_binaria";
            this.btn_binaria.Size = new System.Drawing.Size(209, 60);
            this.btn_binaria.TabIndex = 7;
            this.btn_binaria.Text = "Binaria";
            this.btn_binaria.UseVisualStyleBackColor = true;
            this.btn_binaria.Click += new System.EventHandler(this.btn_binaria_Click);
            // 
            // btn_bordes
            // 
            this.btn_bordes.Location = new System.Drawing.Point(1270, 287);
            this.btn_bordes.Name = "btn_bordes";
            this.btn_bordes.Size = new System.Drawing.Size(209, 60);
            this.btn_bordes.TabIndex = 7;
            this.btn_bordes.Text = "Bordes";
            this.btn_bordes.UseVisualStyleBackColor = true;
            this.btn_bordes.Click += new System.EventHandler(this.btn_bordes_Click);
            // 
            // btn_histograma
            // 
            this.btn_histograma.Location = new System.Drawing.Point(112, 630);
            this.btn_histograma.Name = "btn_histograma";
            this.btn_histograma.Size = new System.Drawing.Size(160, 56);
            this.btn_histograma.TabIndex = 8;
            this.btn_histograma.Text = "Histograma";
            this.btn_histograma.UseVisualStyleBackColor = true;
            this.btn_histograma.Click += new System.EventHandler(this.btn_histograma_Click);
            // 
            // btn_etiquetar
            // 
            this.btn_etiquetar.Location = new System.Drawing.Point(387, 626);
            this.btn_etiquetar.Name = "btn_etiquetar";
            this.btn_etiquetar.Size = new System.Drawing.Size(209, 60);
            this.btn_etiquetar.TabIndex = 9;
            this.btn_etiquetar.Text = "Etiquetar";
            this.btn_etiquetar.UseVisualStyleBackColor = true;
            this.btn_etiquetar.Click += new System.EventHandler(this.btn_etiquetar_Click_1);
            // 
            // btn_reetiquetar
            // 
            this.btn_reetiquetar.Location = new System.Drawing.Point(626, 626);
            this.btn_reetiquetar.Name = "btn_reetiquetar";
            this.btn_reetiquetar.Size = new System.Drawing.Size(209, 60);
            this.btn_reetiquetar.TabIndex = 10;
            this.btn_reetiquetar.Text = "Reetiquetar";
            this.btn_reetiquetar.UseVisualStyleBackColor = true;
            this.btn_reetiquetar.Click += new System.EventHandler(this.btn_reetiquetar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1585, 741);
            this.Controls.Add(this.btn_reetiquetar);
            this.Controls.Add(this.btn_etiquetar);
            this.Controls.Add(this.btn_histograma);
            this.Controls.Add(this.btn_bordes);
            this.Controls.Add(this.btn_binaria);
            this.Controls.Add(this.btn_grises);
            this.Controls.Add(this.pb_binaria);
            this.Controls.Add(this.pb_bordes);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btn_cargar);
            this.Controls.Add(this.pb_blancoNegro);
            this.Controls.Add(this.pb_color);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb_color)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_blancoNegro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bordes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_binaria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_color;
        private System.Windows.Forms.PictureBox pb_blancoNegro;
        private System.Windows.Forms.Button btn_cargar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox pb_bordes;
        private System.Windows.Forms.PictureBox pb_binaria;
        private System.Windows.Forms.Button btn_grises;
        private System.Windows.Forms.Button btn_binaria;
        private System.Windows.Forms.Button btn_bordes;
        private System.Windows.Forms.Button btn_histograma;
        private System.Windows.Forms.Button btn_etiquetar;
        private System.Windows.Forms.Button btn_reetiquetar;
    }
}

