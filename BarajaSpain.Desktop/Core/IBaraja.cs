using BarajaSpain.Desktop.Entities;

namespace BarajaSpain.Desktop.Core
{
    public interface IBaraja
    {
        public void Initial();
        public string GetFigura(int numero);
        public void Ordenar();
        public void Barajar();
        public List<Naipe>? Imprimir();
    }
}
