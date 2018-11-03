
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Owin;
using Owin;
using AutoMapper;
using majig.db;

[assembly: OwinStartupAttribute(typeof(majig.web.Startup))]
namespace majig.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            Mapper.Initialize(c => {
                c.CreateMap<db.ef.vItems, db.model.Item>();
                c.CreateMap<db.ef.Item, db.model.Item>();
            });
        }
    }
}
