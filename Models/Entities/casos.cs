using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class casos
    {
        public int id_caso { get; set; }
        public string titulo { get; set; }
        public string branch_padre { get; set; }
        public int tipo_caso { get; set; }
        public string link { get; set; }
        public string id_ubicacion { get; set; }
        public string git { get; set; } 
        public int cantidad_rechazos { get; set; }
        public string aprobado { get; set; }
        public string aprobado_cliente { get; set; }
        public string estado { get; set; }
        public string? notas { get; set; }
        public string branch { get; set; }
        public string img_url { get; set; }
        public string usuario_asignado { get; set; }
        public string usuario_crea { get; set; }
        public string fecha_registro { get; set; }
        public string fecha_asignacion { get; set; }



    }
}
