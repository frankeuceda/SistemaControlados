using Farsiman.Drogueria.PermisosControlados.Dominio.Permisos.Entidades.Solicitudes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.Drogueria.PermisosControlados.Infraestructura.Solicitudes.Mapeos
{
    public class PrevisionesMap : BaseMapSolicitudes<SolicitudPrevision>
    {

        public PrevisionesMap() : base("Solicitud_Prevision", "Solicitud_ID")
            {
                Property(x => x.IngredienteActivo).HasColumnName("Ingrediente_Activo").HasColumnType("nvarchar").HasMaxLength(30).IsRequired();
                Property(x => x.Descripcion).HasColumnName("Descripcion").HasColumnType("varchar").IsRequired();
                Property(x => x.GramosSalSolicitada).HasColumnName("gr_Total_Solicitado_Sal").HasColumnType("decimal").IsRequired();
                Property(x => x.GramosSalAutorizada).HasColumnName("Gr_Sal_Autorizado").HasColumnType("decimal").IsRequired();
                Property(x => x.FormatoId).HasColumnName("Formato_id").HasColumnType("int").IsRequired();
            }
        
    }
}
