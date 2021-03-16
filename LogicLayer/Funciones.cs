using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLayer.Entidad;

namespace LogicLayer
{
    public class Funciones
    {

        public void Añadir(Cliente Item)
        {
            RepositorioCliente.Instancia.Cliente1.Add(Item);
        }

        public Cliente GetCliente(int Index)
        {
            return RepositorioCliente.Instancia.Cliente1[Index];
        }

        public List<Cliente> GetAll(Cliente Item)
        {
            return RepositorioCliente.Instancia.Cliente1;
        }

    }
}
