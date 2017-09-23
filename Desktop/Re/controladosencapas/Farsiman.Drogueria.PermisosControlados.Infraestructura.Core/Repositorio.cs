using Farsiman.Drogueria.PermisosControlados.Dominio.Core.Entidades_Bases;
using Farsiman.Drogueria.PermisosControlados.Dominio.Core.Entidades_Bases.Repositorios;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.Drogueria.PermisosControlados.Infraestructura.Core
{
    public class Repositorio<TEntidad> : IRepositorio<TEntidad> where TEntidad : Entidad
    {

        private readonly IEntityUnitOfWork _unitOfWork;
        protected DbSet<TEntidad> Tabla;

        public IUnitOfWork UnitOfWork
        {
            get
            {
                return _unitOfWork;
            }
        }

        public Repositorio(IEntityUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            Tabla = unitOfWork.ObtenerDbSet<TEntidad>();
        }

        public void Agregar(TEntidad dato)
        {
            Tabla.Add(dato);
        }

        //public void Eliminar(int id)
        //{
        //    var dato = ObtenerPorID(id);
        //    dato.Activo = false;
        //}


        //public TEntidad ObtenerPorID(int id)
        //{
        //    return Tabla.FirstOrDefault(x => x.Id == id);
        //}

        public List<TEntidad> ObtenerTodos()
        {
            return Tabla.ToList();
        }

        public void Agregar(List<TEntidad> datos)
        {
            Tabla.AddRange(datos);
        }

        //public void Eliminar(TEntidad dato)
        //{
        //    dato.Activo = false;
        //}

        public TEntidad FirstOrDefault(Expression<Func<TEntidad, bool>> query)
        {
            return Tabla.FirstOrDefault(query);
        }

        public List<TEntidad> Where(Expression<Func<TEntidad, bool>> query)
        {
            return Tabla.Where(query).ToList();
        }

        public IQueryable<TEntidad> AsQueryable()
        {
            return Tabla.AsQueryable();
        }
    }
}
