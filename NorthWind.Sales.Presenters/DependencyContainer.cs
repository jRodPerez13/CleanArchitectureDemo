namespace NorthWind.Sales.Presenters
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPresenters(
            this IServiceCollection services)
        {
            /* Registering the interface and the class in the DI container. */
            services.AddScoped<CreateOrderPresenter>();

            services.AddScoped<ICreateOrderPresenter>(
                provider => provider.GetService<CreateOrderPresenter>());
            services.AddScoped<ICreateOrderOutputPort>(
                provider => provider.GetService<CreateOrderPresenter>());
            return services;
        }
    }
}
