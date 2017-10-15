using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using tz.saas.Authorization;

namespace tz.saas
{
    [DependsOn(
        typeof(saasCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class saasApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<saasAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(saasApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(cfg =>
            {
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg.AddProfiles(thisAssembly);
            });
        }
    }
}
