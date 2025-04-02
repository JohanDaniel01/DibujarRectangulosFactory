using System;
using System.Drawing;
using System.Windows.Forms;

namespace DibujarRectangulosFactory
{
    public partial class Form1 : Form
    {
        private Color colorSeleccionado = Color.Black; // Color predeterminado
        public Form1()
        {
            InitializeComponent();
            txtRectangulosCreados.Text = "0";
        }

        public Boolean isValid( string value)
        {
            if (value == null || value == "") return false;
            return true;
        }

        private void DibujarButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Cordenadas numericas
                int x;
                int y;
                string cordenadaX = txtCordenadaX.Text;
                string cordenadaY = txtCordenadaY.Text;

                if (!isValid(cordenadaX) || !isValid(cordenadaY))
                {
                    MessageBox.Show($"Por favor rellene todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(cordenadaX, out x) || !int.TryParse(cordenadaY, out y))
                {
                    MessageBox.Show($"Por favor rellene todos los campos con valores numericos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int contador = 0;
                FiguraFactory figuraFactory = new FiguraFactory();
                Rectangulo rectangulo = (Rectangulo)figuraFactory.CrearFigura(x, y, colorSeleccionado, contador);

                using (Graphics g = this.CreateGraphics())
                {
                    rectangulo.Dibujar(g);
                }

                txtRectangulosCreados.Text = rectangulo.IncrementarContador().ToString(); // Actualizar contador
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
