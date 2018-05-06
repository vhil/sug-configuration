namespace Sug.Feature.ServiceBus.Pipelines.Initialize
{
	using System;
	using Sitecore.Framework.Messaging;
	using Sitecore.Pipelines;

	public class InitializeMessageBus
	{
		private readonly IServiceProvider serviceProvider;

		public InitializeMessageBus(IServiceProvider serviceProvider)
		{
			this.serviceProvider = serviceProvider;
		}

		public void Process(PipelineArgs args)
		{
			this.serviceProvider.StartMessageBus<TestMessagesBus>();
		}
	}
}