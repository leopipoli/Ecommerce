using AutoMapper;

namespace CrossCutting.Mappings
{
    public static class AutoMapperConfiguration
    {
        public static void ConfigureProfiles(IMapperConfigurationExpression cfg)
        {
            cfg.AddProfile<UserProfile>();
            cfg.AddProfile<ProductProfile>();
            cfg.AddProfile<CityProfile>();
            cfg.AddProfile<PhotoProfile>();
        }
    }
}
