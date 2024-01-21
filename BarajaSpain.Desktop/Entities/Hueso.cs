using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarajaSpain.Desktop.Entities
{
    public class Hueso
    {
        public string Nombre { get; set; } = string.Empty;
        public double Peso { get; set; }
        public double Densidad { get; set; }
        public double Longitud { get; set; }
        public double Diametro { get; set; }
    }
}
