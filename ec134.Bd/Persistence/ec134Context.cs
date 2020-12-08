using Newtonsoft.Json;
using NLog;
using System;
using System.Data.Entity;
using System.Threading.Tasks;

namespace ec134.Bd.Persistence
{
 
    //public partial class ec134Context : CriptoDBContext
    //{
    //    protected static Logger _logger = LogManager.GetCurrentClassLogger();

    //    public ec134Context()
    //        : base("name=ec134Context")
    //    {
    //        //Configuration.LazyLoadingEnabled = false;
    //        Configuration.ProxyCreationEnabled = false;
    //    }

    //    public override int SaveChanges()
    //    {
    //        _logger.Debug(JsonConvert.SerializeObject(new
    //        {
    //            Accion = "ec134Context: SaveChanges"
    //        }));
    //        return base.SaveChanges();
    //    }

    //    public override DbSet Set(Type entityType)
    //    {
    //        _logger.Debug(JsonConvert.SerializeObject(new{
    //           Accion = "ec134Context: Actualizacion de elemento",
    //           Elemento = entityType.Name
    //        }));
    //        return base.Set(entityType);
    //    }
    //}
}
