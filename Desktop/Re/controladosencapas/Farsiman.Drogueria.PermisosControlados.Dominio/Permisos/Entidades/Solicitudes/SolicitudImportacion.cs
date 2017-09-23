using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Farsiman.Drogueria.PermisosControlados.Dominio.Core;
using Farsiman.Drogueria.PermisosControlados.Dominio.Core.Entidades_Bases;

namespace Farsiman.Drogueria.PermisosControlados.Dominio.Permisos.Entidades.Solicitudes
{
  public class SolicitudImportacion:BaseEntidadSolicitud
    {

      public SolicitudImportacion(int usuarioAgregaId) : base(usuarioAgregaId)
      {

      }
      
      public string IngredienteActivo { get; set; }
      public int FormatoId { get; set; }
      public string Descripcion { get; set; }
      public string ProductoId { get; set; }
      public bool TieneLeyenda { get; set; }
      public string Leyenda { get; set; }
      public int MesIngresoId { get; set; }
      public int AnioIngreso { get; set; }
      public string NumeroPermisoMinisterio { get; set; }
      public string FechaPermisoMinisterio { get; set; }
      public int CourierId1 { get; set; }
      public int CourierId2 { get; set; }
      public int ViaImportacionId1 { get; set; }
      public int ViaImportacionId2 { get; set; }
      public int AduanaEntraId { get; set; }
      public int AduanaDeclaraId { get; set; }
      public DateTime FechaIngreso { get; set; }
      public int Cajas { get; set; }
      public int InstitucionLicitacionId { get; set; }
      public int EmpresaId { get; set; }
      
    }


}
