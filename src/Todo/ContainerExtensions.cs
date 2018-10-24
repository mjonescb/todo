using Microsoft.AspNetCore.Http;
using SimpleInjector;

namespace Todo
{
    public static class ContainerExtensions
    {
        public static void Register<TService, TDevelopment, TReal>(
            this Container container)
            where TService : class
            where TDevelopment : class, TService
            where TReal : class, TService
        {
            container.Register<TService>(() =>
            {
                var contextFactory = container.GetInstance<IHttpContextAccessor>();
                var context = contextFactory.HttpContext;

                if(context != null && context.Request.Headers.ContainsKey("X-Is-Development"))
                {
                    return container.GetInstance<TDevelopment>();
                }

                return container.GetInstance<TReal>();
            });
        }
    }
}
