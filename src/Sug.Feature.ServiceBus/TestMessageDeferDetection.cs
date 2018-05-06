namespace Sug.Feature.ServiceBus
{
	using System;
	using Sitecore.Framework.Messaging.DeferStrategies;

	public class TestMessageDeferDetection : DeferDetectionByResultBase<HandlerResult>
	{
		protected override bool ShouldDefer<TMessage>(TMessage message, HandlerResult result)
		{
			switch (result.HandlerResultType)
			{
				case HandlerResultType.Success:
					return false;
				case HandlerResultType.Error:
					return true;
				default:
					throw new InvalidOperationException("Unknown defer response");
			}
		}

		protected override bool ShouldDefer<TMessage>(TMessage message, Exception exception)
		{
			return true;
		}
	}
}