using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class pruebas_caso
    {
        public int id_caso { get; set; }
        public int id_prueba { get; set; }
        public string descripcion_prueba { get; set; }
        public string resultado { get; set; }
        public string usuario_prueba { get; set; }
        public DateTime fecha_prueba { get; set; }
    }
}
