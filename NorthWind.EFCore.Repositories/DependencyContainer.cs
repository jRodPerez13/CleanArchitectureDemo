namespace NorthWind.EFCore.Repositories
{
    public static class DependencyContainer
    {
       /// <summary>
       /// This function adds a DbContext to the service collection, and then adds a scoped instance of
       /// the NorthWindSalesCommandsRepository to the service collection
       /// </summary>
       /// <param name="IServiceCollection">This is the collection of services that will be used by the
       /// application.</param>
       /// <param name="IConfiguration">This is the configuration object that is injected into the
       /// Startup class.</param>
       /// <param name="connectionStringName">The name of the connection string in the appsettings.json
       /// file.</param>
       /// <returns>
       /// The services collection.
       /// </returns>
        public static IServiceCollection AddRepositories(
            this IServiceCollection services,
            IConfiguration configuration,
            string connectionStringName)
        {
            /* Adding a DbContext to the service collection. */
            services.AddDbContext<NorthWindSalesContext>(
                options => options.UseSqlServer(
                    configuration.GetConnectionString(
                        connectionStringName)));
            services.AddScoped<INorthWindSalesCommandsRepository,
                INorthWindSalesCommandsRepository>();
            return services;
        }
    }
}
