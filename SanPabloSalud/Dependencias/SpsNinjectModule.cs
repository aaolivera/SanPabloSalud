using Ninject.Modules;
using Repositorio;
using Servicios;
using System.Data.Entity;
using System.ServiceModel;

namespace Dependencias
{
    public class SpsNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<DbContext>().To<SpsDbContext>().InScope(ctx => OperationContext.Current);
            Bind<IRepositorio>().To<RepositorioEF>().InScope(ctx => OperationContext.Current);
            Bind<IServicioRepositorio>().To<ServicioRepositorio>().InScope(ctx => OperationContext.Current);

        }
    }
}
