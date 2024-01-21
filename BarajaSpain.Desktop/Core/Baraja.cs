using BarajaSpain.Desktop.Entities;
using BarajaSpain.Desktop.Enums;
using System.Data;

namespace BarajaSpain.Desktop.Core
{
    public class Baraja: IBaraja
    {
        private List<Naipe>? Naipes { get; set; } = null;
        public Baraja()
        {
            Initial();
        }
        public void Initial()
        {
            Naipes = new List<Naipe>();
            foreach (int palo in Enum.GetValues(typeof(EnumPalo)))
            {
                for (var numero = 1; numero <= 12; numero++)
                {
                    Naipes.Add(new Naipe() { Numero = numero, Palo = (EnumPalo)palo, Figura = GetFigura(numero) });
                }
            }
        }
        public string GetFigura(int numero)
        {
            string[] figuras = new string[] { "N/A", "A", "Dos", "Tres", "Cuatro", "Cinco", "Seis", "Siete", "Ocho", "Nuevo", "Diez", "Sota", "Caballo", "Rey" };
            return numero > 0 && numero < figuras.Length ? figuras[numero] : "";
        }
        public void Ordenar()
        {
            Naipes = Naipes?.OrderBy(x => x.Palo).ThenBy(x => x.Numero).ToList();
        }
        public void Barajar()
        {
            Random rand = new Random();
            Naipes = Naipes?.OrderBy(item => rand.Next()).ToList();
        }
        public List<Naipe>? Imprimir()
        { 
            return Naipes;
        }
    }
}
