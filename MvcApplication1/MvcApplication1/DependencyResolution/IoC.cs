using eManager.Domain;
using MvcApplication1.Infrastructure;
using StructureMap;
namespace MvcApplication1 {
    public static class IoC {
        public static IContainer Initialize() {
            ObjectFactory.Initialize(x =>
                        {
                            x.Scan(scan =>
                                    {
                                        scan.TheCallingAssembly();
                                        scan.WithDefaultConventions();
                                    });
                            x.For<IDepartmentDataSource>().HttpContextScoped().Use<DepartmentDb>();
                        });
            return ObjectFactory.Container;
        }
    }
}