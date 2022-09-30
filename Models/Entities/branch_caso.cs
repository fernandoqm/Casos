using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class branch_caso
    {
        public int id_caso { get; set; }
        public string branch { get; set; }
        public int id_tegnologia { get; set; }
        public string branch_padre { get; set; }
        public string usuario_crea_branch { get; set; }
        public DateTime fecha_branch { get; set; }
        public string estado { get; set; }
    }
}
