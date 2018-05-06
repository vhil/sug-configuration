namespace Sug.Feature.ServiceBus.Configuration
{
	using Microsoft.Extensions.DependencyInjection;
	using Sitecore.DependencyInjection;
	using Sitecore.Framework.Messaging;
	using Sitecore.Framework.Messaging.DeferStrategies;
	using MessageHandlers;
	using Messages;
	using System;

	public class ServicesConfiguratorCm : IServicesConfigurator
	{
		public void Configure(IServiceCollection serviceCollection)
		{
			serviceCollection.AddTransient<IMessageHandler<TestMessage>, TestMessageHandler>();
			//serviceCollection.AddTransient<IMessageHandler<TestMessage>, TestMessageScheduledDeferralHandler>();

			//int maxDeferralAttempts = 5;
			//var minBackoff = TimeSpan.FromSeconds(5);
			//var maxBackoff = TimeSpan.FromMinutes(1);
			//var deltaBackoff = TimeSpan.FromSeconds(5);


			//serviceCollection.AddSingleton(provider => (IDeferStrategy<DeferDetectionByResultBase<HandlerResult>>)
			//	new DeferStrategy<DeferDetectionByResultBase<HandlerResult>>(
			//		new TestMessageDeferDetection(),
			//		new ExponentialDeferalScheduler(maxDeferralAttempts, minBackoff, maxBackoff, deltaBackoff)));
		}
	}
}

