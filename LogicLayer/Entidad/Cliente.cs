using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Entidad
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Entrada { get; set; }
        public string PlatoFuerte { get; set; }
        public string Bebida { get; set; }
        public string Postre { get; set; }

        public string Retorna
        {
            get { return Nombre + " " + Entrada + " " + PlatoFuerte + " " + Bebida + " " + Postre; }
        }
    }
}
