using BarajaSpain.Desktop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarajaSpain.Desktop.Core
{
    public interface IEsqueleto
    {
        public void Cargar();
        public void Ordenar(string cadenaOrden);
        public List<Hueso>? Imprimir();


    }
}
