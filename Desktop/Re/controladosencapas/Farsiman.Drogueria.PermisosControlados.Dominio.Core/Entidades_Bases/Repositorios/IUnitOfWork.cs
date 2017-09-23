using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.Drogueria.PermisosControlados.Dominio.Core.Entidades_Bases.Repositorios
{
    public interface IUnitOfWork:IDisposable
    {
        void Commit();
    }
}
