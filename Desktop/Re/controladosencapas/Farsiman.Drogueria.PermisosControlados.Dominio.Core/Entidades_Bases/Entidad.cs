using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.Drogueria.PermisosControlados.Dominio.Core.Entidades_Bases
{
    public class Entidad 
    {        
        public DateTime FechaAgrega { get; set; }
        public int UsuarioAgregaId { get; set; }

        public Entidad(int usuarioAgregaId)
        {
            FechaAgrega = DateTime.Now.Date;
            UsuarioAgregaId = usuarioAgregaId; 
        }
    }
}
