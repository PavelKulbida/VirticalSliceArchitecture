using SimpleInjector;
using SimpleInjector.Packaging;
using ViennaNET.Mediator.DefaultConfiguration;
using ViennaNET.Orm.DefaultConfiguration;
using ViennaNET.Orm.SQLite.DefaultConfiguration;
using ViennaNET.SimpleInjector.Extensions;

namespace Example
{
  public class ProgramPackage : IPackage
  {
    public void RegisterServices(Container container)
    {
      container
        .AddPackage(new OrmPackage())
        .AddPackage(new SQLiteOrmPackage())
        .AddPackage(new MediatorPackage());
    }
  }
}
