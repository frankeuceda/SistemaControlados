using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Farsiman.Drogueria.PermisosControlados.Dominio.Core;
using Farsiman.Drogueria.PermisosControlados.Dominio.Core.Entidades_Bases;

namespace Farsiman.Drogueria.PermisosControlados.Dominio.Permisos.Entidades.Solicitudes
{
  public class SolicitudPrevisionDetalle:BaseEntidadSolicitud
    {

      public SolicitudPrevisionDetalle(int usuarioAgregaId) : base( usuarioAgregaId)
      {

      }

      public virtual SolicitudPrevision Solicitud { get; set; }
      public int AutoId { get; set; }     
      public int SolicitudId { get; set; }
      public string ProductoId { get; set; }
      public int Cajas { get; set; }
      public double SalAutorizadaEnGramos { get; set; }
      public double BaseAutorizadaEnGramos { get; set; }
      public double GramosPorCaja { get; set; }
      public string IngredienteActivo{get;set;}
      public double SalAutorizada { get; set; }
    }


}
