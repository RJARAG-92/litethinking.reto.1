using BarajaSpain.Desktop.Core;
using BarajaSpain.Desktop.Entities;

namespace BarajaSpain.Desktop
{
    public partial class FormBaraja : Form
    {
        public Baraja Baraja = new Baraja();
        public FormBaraja()
        {
            InitializeComponent();
        }

        private void FormBaraja_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label_status.Text = "Se ha inicializada la Baraja";
        }

        private void button_Iniciar_Click(object sender, EventArgs e)
        {
            Baraja.Initial();
            listBox1.Items.Clear();
            label_status.Text = "Se ha inicializada la Baraja";
        }

      
        private void button_Ordenar_Click(object sender, EventArgs e)
        {
            Baraja.Ordenar();
            label_status.Text = "Se ha ordenado la Baraja";
        }

        private void button_Barajar_Click(object sender, EventArgs e)
        {
            Baraja.Barajar();
            label_status.Text = "Se ha barajado con éxito";
        }

        private void button_Imprimir_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            var naipes = Baraja.Imprimir();

            if (naipes == null)
                return;
            
            foreach (Naipe value in naipes)
            {
                listBox1.Items.Add($"Naipe: {value.Numero}, Palo: {value.Palo.ToString()}, Figura: {value.Figura}");
                //Console.WriteLine($"Naipe: {value.Numero}, Palo: {value.Palo.ToString()}, Figura: {value.Figura}");
            }
            label_status.Text = "Se ha impreso la baraja";

        }
    }
}
