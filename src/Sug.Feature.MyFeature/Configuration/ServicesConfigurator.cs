namespace Sug.Feature.MyFeature.Configuration
{
	using Microsoft.Extensions.DependencyInjection;
	using Sitecore.DependencyInjection;
	using Sitecore.Configuration;
	using Examples;

	public class ServicesConfigurator : IServicesConfigurator
	{
		public void Configure(IServiceCollection serviceCollection)
		{
			serviceCollection.AddTransient<MyClass8>(provider => Factory.CreateObject("feature/myfeature/myclass8", false) as MyClass8);
		}
	}
}

