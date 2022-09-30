using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class bitacora_movimientos_caso
    {
        public int id_bitacora { get; set; }
        public int id_caso { get; set; }
        public int movimiento { get; set; }
        public int id_ubicacion { get; set; }
        public string usuario_registra { get; set; }
        public DateTime fecha_registro { get; set; }
    }
}
