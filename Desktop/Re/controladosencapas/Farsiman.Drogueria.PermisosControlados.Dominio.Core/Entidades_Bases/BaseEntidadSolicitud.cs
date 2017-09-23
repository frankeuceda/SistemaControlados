using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Farsiman.Drogueria.PermisosControlados.Dominio.Core;
using Farsiman.Drogueria.PermisosControlados.Dominio.Core.Entidades_Bases;

namespace Farsiman.Drogueria.PermisosControlados.Dominio.Core
{
    public class BaseEntidadSolicitud : Entidad
    {
        public int SolicitudId { get; set; }
        public DateTime FechaImpresion { get; set; }
        public string Anulado { get; set; }
        public int Anio { get; set; }
        public int UsuarioAutoriza { get; set; }
        public int FechaAutoriza { get; set; }
        public double GramosSolicitudos { get; set; }
        public double GramosAutorizados { get; set; }
        
        public BaseEntidadSolicitud(int usuarioAgregaId)  : base(usuarioAgregaId)
        {
        }

    }
}
