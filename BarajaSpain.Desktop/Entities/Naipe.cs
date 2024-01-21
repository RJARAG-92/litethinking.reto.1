using BarajaSpain.Desktop.Enums;

namespace BarajaSpain.Desktop.Entities
{
    public class Naipe
    {

        public int Numero { get; set; }
        public EnumPalo Palo { get; set; }
        public string? Figura { get; set; } = null;

    }
}
