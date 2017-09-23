using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.Drogueria.PermisosControlados.Dominio.Core.Entidades_Bases.Repositorios
{
    public interface IRepositorio<TEntidad>
    {
        void Agregar(List<TEntidad> datos); //agregar una lista (varias al mismo tiempo)
        void Agregar(TEntidad dato);
        //void Eliminar(int id);
        //void Eliminar(TEntidad dato);
        //TEntidad ObtenerPorID(int id);
        List<TEntidad> ObtenerTodos();
        IUnitOfWork UnitOfWork { get; }
        TEntidad FirstOrDefault(Expression<Func<TEntidad, bool>> query);
        List<TEntidad> Where(Expression<Func<TEntidad, bool>> query);
        IQueryable<TEntidad> AsQueryable();
    }
}

//el repositorio tiene los metodos en comun de las entidades 
