using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Farsiman.Drogueria.PermisosControlados.Dominio.Core;
using Farsiman.Drogueria.PermisosControlados.Dominio.Core.Entidades_Bases;

namespace Farsiman.Drogueria.PermisosControlados.Dominio.Permisos.Entidades.Solicitudes
{
  public class SolicitudPrevision:BaseEntidadSolicitud
    {

      public SolicitudPrevision(int usuarioAgregaId) : base( usuarioAgregaId)
      {

      }

      public virtual List<SolicitudPrevisionDetalle> Solicitudes { get; set; }
      public string IngredienteActivo { get; set; }
      public string Descripcion { get; set; }
      public double GramosSalSolicitada { get; set; }
      public double GramosSalAutorizada { get; set; }
      public int FormatoId { get; set; }


    }


}
