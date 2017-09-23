namespace Farsiman.Drogueria.PermisosControlados.Infraestructura.Core
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    
    public class BaseUnitOfWork : DbContext, IEntityUnitOfWork
    {
        public BaseUnitOfWork(string cadenaConexion)
            : base(cadenaConexion)
        {
        }

        public virtual void Commit()
        {
            var transaccion = Database.BeginTransaction();
            try
            {
                SaveChanges();
                transaccion.Commit();
                transaccion.Dispose();
            }
            catch (Exception ex)
            {
                transaccion.Rollback();
                transaccion.Dispose();
                throw ex;
            }
        }

        public DbSet<TEntidad> ObtenerDbSet<TEntidad>() where TEntidad : class
        {
            return Set<TEntidad>();
        }
    }
}
