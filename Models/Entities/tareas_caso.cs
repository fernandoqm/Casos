using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class tareas_caso
    {
        public int id_caso { get; set; }
        public int id_tarea { get; set; }
        public string descripcion_tarea { get; set; }
        public int ubicacion_registra { get; set; }
        public string usuario_registra { get; set; }
        public DateTime fecha_registro { get; set; }
        public string estado { get; set; }

    }
}
