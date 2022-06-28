namespace NorthWind.Sales.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddNorthWindSAlesseServices(
            this IServiceCollection services,
            IConfiguration configuration,
            string connectionStringName)
        {
            services.AddRepositories(configuration, connectionStringName)
                .AddUseCasesServices()
                .AddPresenters()
                .AddNorthWindSAlesControllers();
            return services;
        }
    }
}
