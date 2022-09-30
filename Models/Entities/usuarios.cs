using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class usuarios
    {
        public int id_usuario { get; set; }
        public string nombre { get; set; }
        public string correo { get; set; }
        public int ubicacion_activa { get; set; }
        public string clave { get; set; }
        public DateTime fecha_ultimo_cambio_clave { get; set; }
        public string estado { get; set; }
        public string usuario { get; set; }
    }
}
