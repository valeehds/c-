using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace juegoNums
{
    public partial class Form1 : Form
    {
        int numeroRandom;
        int intentosRestantes;
        List<string> numerosIngresados; // Lista para almacenar los números ingresados

        public Form1()
        {
            InitializeComponent();
            ReiniciarJuego();
            panelNumeros.BackColor = Color.FromArgb(224, 242, 229 );
            intentos.BackColor = Color.FromArgb(224, 242, 229);
            //BtnComprobar.BackColor = Color.FromArgb(117, 233, 153);
            CenterToScreen();
        }

        private void BtnComprobar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(numero.Text, out int intento) && intento >= 1 && intento <= 100) // Intentar convertir el texto a un número y verificar que esté en el rango
            {
                if (numerosIngresados.Contains(intento.ToString())) // Verificar si el número ya ha sido ingresado
                {
                    labelResultado.ForeColor = Color.Red;
                    labelResultado.Text = "Este número ya ha sido ingresado. Intenta con otro.";
                    numero.Text = "";
                    return;
                }

                numerosIngresados.Add(intento.ToString()); // Agregar el número ingresado a la lista
                intentosRestantes--; // Reducir el número de intentos restantes

                if (intento == numeroRandom) // Si el número es correcto
                {
                    labelResultado.ForeColor = Color.Green;
                    labelResultado.Text = "Correcto, el número sí era " + $"{numeroRandom}";
                    MostrarMensajeNuevoJuego();
                }
                else
                {
                    if (intento < numeroRandom)
                    {
                        labelResultado.ForeColor = Color.DarkGreen;
                        labelResultado.Text = "El número es mayor. Intenta de nuevo.";
                    }
                    else
                    {
                        labelResultado.ForeColor = Color.Green;
                        labelResultado.Text = "El número es menor. Intenta de nuevo.";
                    }

                    if (intentosRestantes == 0) // Si se quedan sin intentos
                    {
                        labelResultado.ForeColor = Color.Blue;
                        labelResultado.Text = $"Se acabaron los intentos. El número era: {numeroRandom}";
                        MostrarMensajeNuevoJuego();
                    }
                }

                intentos.Text = intentosRestantes.ToString();
                MostrarNumerosIngresados();
                numero.Text = ""; // Limpiar el TextBox de entrada para el próximo número
            }
            else
            {
                labelResultado.ForeColor = Color.Red;
                if (intento < 1 || intento > 100)
                {
                    labelResultado.Text = "Por favor, introduce un número válido entre 1 y 100.";
                    numero.Text = "";
                }
            }
        }

        private void ReiniciarJuego()
        {
            numeroRandom = new Random().Next(1, 100);
            intentosRestantes = 10;
            intentos.Text = $"{intentosRestantes}";
            numerosIngresados = new List<string>();
            labelResultado.Text = "";
        }

        private void MostrarMensajeNuevoJuego()
        {
            DialogResult resultado = MessageBox.Show("¿Quieres jugar de nuevo?", "Nuevo juego", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                ReiniciarJuego();
            }
            else
            {
                Close();
            }
        }

        private void MostrarNumerosIngresados()
        {
            // Limpiar el panel antes de mostrar los números
            panelNumeros.Controls.Clear();

            int panelWidth = panelNumeros.Width;
            int totalLabelWidth = 0;

            foreach (string num in numerosIngresados)
            {
                Label labelNumero = new Label();
                labelNumero.Text = num;
                labelNumero.AutoSize = true;
                labelNumero.Font = new Font("Century Gothic", 10); // Establecer la fuente
                if (num == numeroRandom.ToString())
                {
                    labelNumero.ForeColor = Color.Red; // Si el número ingresado es correcto, colorearlo de verde
                }
                else
                {
                    labelNumero.ForeColor = Color.Green; // Si el número ingresado no es correcto, colorearlo de rojo
                }
                panelNumeros.Controls.Add(labelNumero); // Agregar el label al panel

                totalLabelWidth += labelNumero.Width;
            }

            int offsetX = (panelWidth - totalLabelWidth) / 2;
            int posX = offsetX;

            foreach (Control control in panelNumeros.Controls)
            {
                control.Location = new Point(posX, 10); // Posición del label
                posX += control.Width; // Incrementar la posición X para el próximo label
            }
        }

    }
}
