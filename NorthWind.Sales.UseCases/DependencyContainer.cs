namespace NorthWind.Sales.UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddUseCasesServices(
            this IServiceCollection services)
        {
            /* Registering the CreateOrderInteractor as the implementation of the ICreateOrderInputPort
            interface. */
            services.AddScoped<ICreateOrderInputPort,
                CreateOrderInteractor>();
            return services;
        }
    }
}
