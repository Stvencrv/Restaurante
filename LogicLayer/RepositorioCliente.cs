using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLayer.Entidad;

namespace LogicLayer
{
    public sealed class RepositorioCliente
    {
        public List<Cliente> Cliente1 { get; set; } = new List<Cliente>();
        public static RepositorioCliente Instancia { get; } = new RepositorioCliente();

        private RepositorioCliente()
        {

        }
    }
}
