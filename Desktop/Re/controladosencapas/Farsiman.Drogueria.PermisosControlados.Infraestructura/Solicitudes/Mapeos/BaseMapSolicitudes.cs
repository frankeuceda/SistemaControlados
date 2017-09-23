using Farsiman.Drogueria.PermisosControlados.Dominio.Core;
using Farsiman.Drogueria.PermisosControlados.Dominio.Core.Entidades_Bases;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.Drogueria.PermisosControlados.Infraestructura.Solicitudes.Mapeos
{
    public class BaseMapSolicitudes<TEntidad> : EntityTypeConfiguration<TEntidad> where TEntidad : Entidad 
    {
        public BaseMapSolicitudes(string tablaNombre, string columnaIdNombre)
        {
            ToTable(tablaNombre);

            Property(x => x.FechaAgrega).HasColumnName("Fecha_Agrega").IsRequired();
            Property(x => x.UsuarioAgregaId).HasColumnName("Usuario_Agrega_ID").IsRequired();
        }
    }
}
