using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivos_Csv
{
    public partial class FrnVarios : Form
    {
        public FrnVarios()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            DateTime nacimiento = dtpfechanac.Value;
            DateTime calculo = dtpfechacal.Value;

            int edad = calculo.Year - nacimiento.Year;
            int meses = calculo.Month - nacimiento.Month;
            int dias = calculo.Day - nacimiento.Day;


            if (meses < 0)
            {
                edad--;
                meses += 12;
            }


            if (dias < 0)
            {
                meses--;

                DateTime mesAnterior = calculo.AddMonths(-1);
                TimeSpan diferencia = calculo - mesAnterior;
                dias += diferencia.Days;

            }

            MessageBox.Show("Años: " + edad + " Meses: " + meses + " Días: " + dias, "Resultado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dtpfechanac_ValueChanged(object sender, EventArgs e)
        {
            string curp = txtCurp.Text.Trim(); // Obtener nuevamente la CURP

            if (curp.Length < 18)
            {
                return; // No hacer nada si la CURP es incorrecta
            }

            // Extraer los valores al inicio
            string fecha = curp.Substring(4, 6); // AAMMDD
            string sexo = curp.Substring(10, 1);
            string estado = curp.Substring(11, 2);

            // Convertir la fecha de nacimiento al formato DD/MM/AAAA
            string anio = fecha.Substring(0, 2);
            string mes = fecha.Substring(2, 2);
            string dia = fecha.Substring(4, 2);

            // Determinar el siglo (19XX o 20XX)
            int anioInt = int.Parse(anio);
            string anioCompleto = anioInt >= 30 ? "19" + anio : "20" + anio;

            // Formatear la fecha correctamente
            string fechaNacimiento = $"{dia}/{mes}/{anioCompleto}";

            // Determinar el género sin usar .ToUpper()
            string genero = (sexo == "H" || sexo == "h") ? "Hombre" : "Mujer";

            // Mostrar los datos extraídos
            MessageBox.Show($"Fecha de nacimiento: {fechaNacimiento}\nSexo: {genero}\nEstado: {estado}",
                "Información de la CURP", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btncurp_Click(object sender, EventArgs e)
        {
            string curp = txtCurp.Text.Trim(); // Elimina espacios en blanco

            // Validar que la CURP tenga al menos 18 caracteres
            if (curp.Length < 18)
            {
                MessageBox.Show("La CURP ingresada es incorrecta o incompleta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Extraer datos de la CURP
                string fecha = curp.Substring(4, 6); // AAMMDD
                string sexo = curp.Substring(10, 1);
                string estado = curp.Substring(11, 2);

                // Convertir la fecha de nacimiento al formato DD/MM/AAAA
                string anio = fecha.Substring(0, 2);
                string mes = fecha.Substring(2, 2);
                string dia = fecha.Substring(4, 2);

                // Determinar el siglo (19XX o 20XX)
                int anioInt = int.Parse(anio);
                string anioCompleto = anioInt >= 30 ? "19" + anio : "20" + anio;

                // Establecer la fecha de nacimiento en el DateTimePicker (esto dispara ValueChanged)
                dtpfechanac.Value = new DateTime(int.Parse(anioCompleto), int.Parse(mes), int.Parse(dia));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al procesar la CURP: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

