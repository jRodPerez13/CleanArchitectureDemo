namespace NorthWind.Sales.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddNorthWindSAlesseServices(
            this IServiceCollection services,
            IConfiguration configuration,
            string connectionStringName)
        {
            /* A fluent interface. */
            services.AddRepositories(configuration, connectionStringName)
                .AddUseCasesServices()
                .AddPresenters()
                .AddNorthWindSAlesControllers();
            return services;
        }
    }
}
