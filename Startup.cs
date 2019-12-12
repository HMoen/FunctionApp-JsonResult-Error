using Microsoft.Azure.Functions.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(FunctionAppJsonError.Startup))]

namespace FunctionAppJsonError
{
    using Microsoft.Azure.Functions.Extensions.DependencyInjection;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>Function startup.</summary>
    public class Startup : FunctionsStartup
    {
        /// <summary>Configure the startup.</summary>
        /// <param name="builder"><see cref="IFunctionsHostBuilder"/> derived object.</param>
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services
                .AddControllers()
                .AddNewtonsoftJson();
        }
    }
}