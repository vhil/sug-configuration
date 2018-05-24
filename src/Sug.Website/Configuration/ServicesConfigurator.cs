using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using Sug.Controllers;

namespace Sug.Configuration
{
	public class ServicesConfigurator : IServicesConfigurator
	{
		public void Configure(IServiceCollection serviceCollection)
		{
			serviceCollection.AddScoped<TestController>();
		}
	}
}