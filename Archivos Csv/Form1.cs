using System.Windows.Forms;
using System;
using System.IO;

namespace Archivos_Csv
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var resultado = openFileDialogcsv.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                string ruta = openFileDialogcsv.FileName;
                string contenido = File.ReadAllText(ruta);
                string[] lineas = contenido.Split('\n');

                dtvcsv.Columns.Clear();
                string[] encabezados = lineas[0].Split(',');

                for (int j = 0; j < encabezados.Length; j++)
                {
                    string titulo = encabezados[j].Trim();
                    dtvcsv.Columns.Add(titulo, titulo);
                }

                for (int i = 1; i < lineas.Length; i++)
                {
                    string[] valores = lineas[i].Split(',');
                    if (valores.Length == encabezados.Length)
                    {
                        dtvcsv.Rows.Add(valores);
                    }
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dtvcsv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrnVarios fechas = new FrnVarios();
            fechas.Show();
        }
    }
}
    

