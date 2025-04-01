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
                string cordenadaX = txtCordenadaX.Text;
                string cordenadaY = txtCordenadaY.Text;

                if (!isValid(cordenadaX) && !isValid(cordenadaY))
                {
                    MessageBox.Show($"Por favor rellene todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                int x = int.Parse(txtCordenadaX.Text);
                int y = int.Parse(txtCordenadaY.Text);

                if (x < 0 || y < 0 || x > this.ClientSize.Width || y > this.ClientSize.Height)
                {
                    MessageBox.Show("Las coordenadas están fuera del rango permitido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Figura rectangulo = FiguraFactory.CrearFigura("Rectangulo", x, y, colorSeleccionado);

                using (Graphics g = this.CreateGraphics())
                {
                    rectangulo.Dibujar(g);
                }

                txtContador.Text = Rectangulo.Contador.ToString(); // Actualizar contador
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
