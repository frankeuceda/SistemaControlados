using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Farsiman.Drogueria.PermisosControlados.Dominio.Core;
using Farsiman.Drogueria.PermisosControlados.Dominio.Core.Entidades_Bases;

namespace Farsiman.Drogueria.PermisosControlados.Dominio.Permisos.Entidades.Solicitudes
{
    public class SolicitudAmpliacion : BaseEntidadSolicitud
    {

        public SolicitudAmpliacion(int usuarioAgregaId): base(usuarioAgregaId)
      {

      }
      
      public string IngredienteActivo { get; set; }
      public int FormatoId { get; set; }
      public string Descripcion { get; set; }
      public string Laboratorio1 { get; set; }
      public string Laboratorio2 { get; set; }
    }


}
