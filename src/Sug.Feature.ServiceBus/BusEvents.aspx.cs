namespace Sug.Feature.ServiceBus
{
	using System;
	using System.Web.UI;
	using Microsoft.Extensions.DependencyInjection;
	using Sitecore.DependencyInjection;
	using Sitecore.Framework.Messaging;
	using Messages;

	public partial class BusEvents : Page
	{
		protected void OnFireTestMessage(object sender, EventArgs e)
		{
			var tbus = ServiceLocator.ServiceProvider.GetService<IMessageBus<TestMessagesBus>>();
			tbus.SendAsync(new TestMessage { MessageBody = "test message body" });
		}
	}
}