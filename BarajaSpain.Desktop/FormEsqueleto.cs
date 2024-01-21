

using BarajaSpain.Desktop.Core;
using BarajaSpain.Desktop.Entities;

namespace BarajaSpain.Desktop
{
    public partial class FormEsqueleto : Form
    {
        public Esqueleto Esqueleto = new Esqueleto();

        public FormEsqueleto()
        {
            InitializeComponent();
            listBox1.Items.Clear();
            label_status.Text = "Se ha cargado los datos";
        }

        private void button_Iniciar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label_status.Text = "Se ha cargado los datos";
        }

        private void button_Ordenar_Click(object sender, EventArgs e)
        {
            Esqueleto.Ordenar($"{comboBox1.SelectedItem}_{comboBox2.SelectedItem}");
            label_status.Text = $"Se ha ordenado los datos por {comboBox1.SelectedItem} y {comboBox2.SelectedItem}";
            listBox1.Items.Clear();
        }

        private void button_Imprimir_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            var esqueleto = Esqueleto.Imprimir();

            if (esqueleto == null)
                return;

            foreach (Hueso value in esqueleto)
            {
                listBox1.Items.Add($"Nombre: {value.Nombre}, Peso: {value.Peso.ToString()}, Densidad: {value.Densidad.ToString()}, Longitud: {value.Longitud.ToString()}, Diametro: {value.Diametro.ToString()}");
            }
            label_status.Text = "Se ha impreso los huesos";
        }

        private void FormEsqueleto_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }
    }
}
