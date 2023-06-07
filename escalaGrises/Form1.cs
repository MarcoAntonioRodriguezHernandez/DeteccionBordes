using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace escalaGrises
{
    public partial class Form1 : Form
    {
        Bitmap bitmap, final;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            //Ventana para cargar archivos
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "JPG(*.jpg)|*.jpg|PNG (*.png)|*.png|Todos los archivos (*.*)|*.*";
            //Archivo valido
            if (o.ShowDialog() == DialogResult.OK)
            {
                //Cargar imagen
                bitmap = new Bitmap(Image.FromFile(o.FileName));
                //Mostrar imagen a color
                pb_color.Image = bitmap;
            }
        }
        private void btn_grises_Click(object sender, EventArgs e)
        {
            int w = bitmap.Width;
            int h = bitmap.Height;
            int pixelGris = 0;
            Color actual, nuevoColor;
            //Crear nuevo bitmap
            final = new Bitmap(w, h);
            //Recorrer pixel de imagen
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    actual = bitmap.GetPixel(i, j);
                    //Color base para sacar gris (Rojo)
                    //int pixelGris = 255 - (int)(0.3 * actual.R + 0.59 * actual.G + 0.11 * actual.B);
                    pixelGris = (int)(0.3 * actual.R + 0.59 * actual.G + 0.11 * actual.B);

                    nuevoColor = Color.FromArgb(pixelGris, pixelGris, pixelGris);
                    //Guardar pixel con nuevo color
                    final.SetPixel(i, j, nuevoColor);
                }
            }
            pb_blancoNegro.Image = final;
        }

        private void btn_binaria_Click(object sender, EventArgs e)
        {
            int w = bitmap.Width;
            int h = bitmap.Height;
            int umbral = 128; // umbral de binarización
            Color actual, nuevoColor;
            //Crear nuevo bitmap
            final = new Bitmap(w, h);
            //Recorrer pixel de imagen
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    actual = bitmap.GetPixel(i, j);
                    int pixelGris = (int)(0.3 * actual.R + 0.59 * actual.G + 0.11 * actual.B);
                    // Convertir a blanco o negro dependiendo del umbral
                    if (pixelGris >= umbral)
                    {
                        nuevoColor = Color.White;
                    }
                    else
                    {
                        nuevoColor = Color.Black;
                    }
                    //Guardar pixel con nuevo color
                    final.SetPixel(i, j, nuevoColor);
                }
            }
            pb_binaria.Image = final;
        }
        private void btn_bordes_Click(object sender, EventArgs e)
        {
            /*
             CONCEPTOS UTILIZADOS:
            El gradiente es una medida de la intensidad de cambio en una imagen. En el contexto de detección de bordes, el gradiente representa la magnitud de la diferencia de intensidad entre dos píxeles vecinos en la dirección perpendicular al borde.

            El kernel que utilicé es un filtro de convolución que se utiliza para calcular el gradiente de la imagen. Específicamente, utilicé el kernel de Sobel, que consiste en dos matrices de 3x3 que se utilizan para calcular las derivadas parciales horizontales y verticales de la imagen:

            Kernel horizontal:

            |-1 0 1|
            |-2 0 2|
            |-1 0 1|

            Kernel vertical:

            |1 2 1|
            |0 0 0|
            |-1 -2 -1|

            El kernel horizontal se utiliza para detectar bordes verticales en la imagen, mientras que el kernel vertical se utiliza para detectar bordes horizontales. Al combinar los resultados de ambos kernels, se puede obtener una imagen que destaque los bordes de la imagen original.             
             */
            int w = bitmap.Width;
            int h = bitmap.Height;
            int[,] kernelHorizontal = { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };
            int[,] kernelVertical = { { 1, 2, 1 }, { 0, 0, 0 }, { -1, -2, -1 } };
            Color actual, nuevoColor;
            //Crear nuevo bitmap
            final = new Bitmap(w, h);
            //Recorrer pixel de imagen
            for (int i = 1; i < w - 1; i++)
            {
                for (int j = 1; j < h - 1; j++)
                {
                    int pixelGrisHorizontal = 0;
                    int pixelGrisVertical = 0;
                    for (int ki = 0; ki < 3; ki++)
                    {
                        for (int kj = 0; kj < 3; kj++)
                        {
                            actual = bitmap.GetPixel(i + ki - 1, j + kj - 1);
                            int pixelGris = (int)(0.3 * actual.R + 0.59 * actual.G + 0.11 * actual.B);
                            pixelGrisHorizontal += pixelGris * kernelHorizontal[ki, kj];
                            pixelGrisVertical += pixelGris * kernelVertical[ki, kj];
                        }
                    }
                    // Calcular el gradiente
                    int gradiente = (int)Math.Sqrt(pixelGrisHorizontal * pixelGrisHorizontal + pixelGrisVertical * pixelGrisVertical);
                    gradiente = Math.Min(255, gradiente); // Limitar a 255
                    nuevoColor = Color.FromArgb(gradiente, gradiente, gradiente);
                    //Guardar pixel con nuevo color
                    final.SetPixel(i, j, nuevoColor);
                }
            }
            pb_bordes.Image = final;
        }

        private void btn_etiquetar_Click_1(object sender, EventArgs e) { 

            int w = bitmap.Width;
            int h = bitmap.Height;
            long etiqueta1 = 1;
            long[,] etiquetas = new long[w, h];

            // Etiquetado de regiones utilizando el algoritmo iterativo
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    if (final.GetPixel(i, j).ToArgb() == Color.White.ToArgb())
                    {
                        if (i > 0 && j > 0 && etiquetas[i - 1, j] != 0)
                        {
                            etiquetas[j, i] = etiquetas[i - 1, j];
                        }
                        else if (i > 0 && j > 0 && etiquetas[i, j - 1] != 0)
                        {
                            etiquetas[j, i] = etiquetas[i, j - 1];
                        }
                        else
                        {
                            etiquetas[j, i] = etiqueta1;
                            if (etiqueta1 == etiquetas[j, i])
                            {

                            }
                            else {
                                etiqueta1++;
                            }
                            
                        }
                    }
                }
            }

            // Exportar etiquetas a un archivo de texto
            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "Archivo de texto (*.txt)|*.txt";

            if (s.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < h; i++)
                {
                    for (int j = 0; j < w; j++)
                    {
                        sb.Append(etiquetas[i, j] + " ");
                    }
                    sb.AppendLine();
                }

                File.WriteAllText(s.FileName, sb.ToString());
            }
        
    }

        private void btn_reetiquetar_Click(object sender, EventArgs e)
        {
            int w = bitmap.Width;
            int h = bitmap.Height;
            int etiqueta = 1;
            int[,] etiquetas = new int[w, h];

            // Etiquetado de regiones utilizando el algoritmo iterativo de derecha a izquierda y de abajo hacia arriba
            for (int j = h - 1; j >= 0; j--)
            {
                for (int i = w - 1; i >= 0; i--)
                {
                    if (final.GetPixel(i, j).ToArgb() == Color.White.ToArgb())
                    {
                        if (i < w - 1 && etiquetas[i + 1, j] != 0)
                        {
                            etiquetas[i, j] = etiquetas[i + 1, j];
                        }
                        else if (j < h - 1 && etiquetas[i, j + 1] != 0)
                        {
                            etiquetas[i, j] = etiquetas[i, j + 1];
                        }
                        else
                        {
                            etiquetas[i, j] = etiqueta;
                            etiqueta++;
                        }
                    }
                }
            }

            // Exportar etiquetas a un archivo de texto
            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "Archivo de texto (*.txt)|*.txt";

            if (s.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();

                for (int j = 0; j < h; j++)
                {
                    for (int i = 0; i < w; i++)
                    {
                        sb.Append(etiquetas[i, j] + " ");
                    }
                    sb.AppendLine();
                }

                File.WriteAllText(s.FileName, sb.ToString());
            }
        }

        private void btn_histograma_Click(object sender, EventArgs e)
        {
            int w = bitmap.Width;
            int h = bitmap.Height;
            int[,] kernelHorizontal = { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };
            int[,] kernelVertical = { { 1, 2, 1 }, { 0, 0, 0 }, { -1, -2, -1 } };
            Color actual, nuevoColor;
            //Crear nuevo bitmap
            final = new Bitmap(w, h);
            //Recorrer pixel de imagen y calcular el histograma
            int[] histogramaRojo = new int[256];
            int[] histogramaVerde = new int[256];
            int[] histogramaAzul = new int[256];
            for (int i = 1; i < w - 1; i++)
            {
                for (int j = 1; j < h - 1; j++)
                {
                    actual = bitmap.GetPixel(i, j);
                    int pixelGris = (int)(0.3 * actual.R + 0.59 * actual.G + 0.11 * actual.B);
                    histogramaRojo[actual.R]++;
                    histogramaVerde[actual.G]++;
                    histogramaAzul[actual.B]++;
                    //...
                }
            }
            //Crear el chart y agregar los datos del histograma
            chart1.Series.Add("Rojo");
            chart1.Series.Add("Verde");
            chart1.Series.Add("Azul");
            for (int i = 0; i < 256; i++)
            {
                chart1.Series["Rojo"].Points.AddXY(i, histogramaRojo[i]);
                chart1.Series["Verde"].Points.AddXY(i, histogramaVerde[i]);
                chart1.Series["Azul"].Points.AddXY(i, histogramaAzul[i]);
            }
            chart1.ChartAreas.Add("Histograma");
            chart1.ChartAreas["Histograma"].AxisX.Title = "Intensidad";
            chart1.ChartAreas["Histograma"].AxisY.Title = "Cantidad de píxeles";
        }
    }
}
