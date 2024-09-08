using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Nukkua
{
    public partial class Form1 : Form
    {
        // Diccionario para almacenar líquidos y sus viscosidades (mPa.s a 25°C)
        Dictionary<string, double> liquidos;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            InicializarLiquidos();
        }

        // Inicializar la lista de líquidos con sus viscosidades aproximadas
        private void InicializarLiquidos()
        {
            liquidos = new Dictionary<string, double>()
            {
                { "Agua", 0.89 },
                { "Aceite vegetal", 100 },
                { "Glicerina", 945 },
                { "Alcohol etílico", 1.2 },
                { "Mercurio", 1.55 },
                { "Miel", 2000 },
                { "Leche", 2.0 },
                { "Gasolina", 0.5 },
                { "Acetona", 0.3 },
                { "Jabón líquido", 350 },
                { "Jarabe de maíz", 3000 },
                { "Sangre", 3.5 },
                { "Vinagre", 1.0 },
                { "Aceite de motor", 250 },
                { "Chocolate líquido", 5000 }
            };

            // Cargar los líquidos en el ComboBox
            foreach (var liquido in liquidos.Keys)
            {
                comboBoxLiquidos.Items.Add(liquido);
            }
        }

        // Evento que se ejecuta al presionar el botón "Simular Viscosidad"
        private void btnSimular_Click(object sender, EventArgs e)
        {
            if (comboBoxLiquidos.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un líquido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string liquidoSeleccionado = comboBoxLiquidos.SelectedItem.ToString();
            double viscosidadBase = liquidos[liquidoSeleccionado];

            // Obtener la temperatura seleccionada y ajustar la viscosidad
            int temperatura = trackBarTemperatura.Value;
            double viscosidadAjustada = CalcularViscosidadPorTemperatura(viscosidadBase, temperatura);

            // Mostrar el resultado en el Label
            lblResultado.Text = $"La viscosidad de {liquidoSeleccionado} a {temperatura}°C es aproximadamente {viscosidadAjustada:N2} mPa.s.";

            // Dibujar la simulación visual
            panelSimulacion.Invalidate();
        }

        // Método para calcular la viscosidad ajustada por temperatura (simulación simple)
        private double CalcularViscosidadPorTemperatura(double viscosidadBase, int temperatura)
        {
            // Ecuación simulada: viscosidad disminuye con el aumento de temperatura (aproximación)
            double factor = 1 - (0.02 * (temperatura - 25)); // Baja un 2% por cada grado sobre 25°C
            return viscosidadBase * Math.Max(factor, 0.1); // Factor mínimo para evitar viscosidades negativas
        }

        // Evento que se dispara cuando se necesita redibujar el panel
        private void panelSimulacion_Paint(object sender, PaintEventArgs e)
        {
            // Obtener el gráfico y las dimensiones del panel
            Graphics g = e.Graphics;
            int ancho = panelSimulacion.Width;
            int alto = panelSimulacion.Height;

            // Simulación simple de partículas (representación gráfica de la viscosidad)
            for (int i = 0; i < 20; i++)
            {
                int size = random.Next(5, 20); // Tamaño de la partícula
                int x = random.Next(0, ancho - size);
                int y = random.Next(0, alto - size);
                g.FillEllipse(Brushes.Blue, x, y, size, size);
            }
        }
    }
}
