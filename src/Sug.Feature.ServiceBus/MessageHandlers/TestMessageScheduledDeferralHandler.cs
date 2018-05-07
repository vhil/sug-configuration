namespace Sug.Feature.ServiceBus.MessageHandlers
{
	using System.Threading.Tasks;
	using Sitecore.Framework.Messaging;
	using Sitecore.Framework.Messaging.DeferStrategies;
	using Messages;
	using System;

	public class TestMessageScheduledDeferralHandler : IMessageHandler<TestMessage>, IMessageHandler
	{
		private readonly IDeferStrategy<DeferDetectionByResultBase<HandlerResult>> deferStrategy;
		private readonly IMessageBus<TestMessagesBus> bus;

		public TestMessageScheduledDeferralHandler(
			IDeferStrategy<DeferDetectionByResultBase<HandlerResult>> deferStrategy, 
			IMessageBus<TestMessagesBus> bus)
		{
			this.deferStrategy = deferStrategy;
			this.bus = bus;
		}

		public async Task Handle(TestMessage message, IMessageReceiveContext receiveContext, IMessageReplyContext replyContext)
		{
			var deferResult = await this.deferStrategy
				.ExecuteAsync(this.bus, message, receiveContext, () => this.ProcessMessage(message))
				.ConfigureAwait(false);

			if (deferResult.Deferred)
			{
				// deferred;
			}
			else
			{
				// handled
			}
		}

		protected HandlerResult ProcessMessage(TestMessage message)
		{
			try
			{
				// TODO: handling logic implementation.

				var random = new Random((int) DateTime.Now.Ticks).Next(1, 11);

				if (random % 2 == 0)
				{
					return new HandlerResult {HandlerResultType = HandlerResultType.Success};
				}

				throw new ApplicationException();
			}
			catch
			{
				return new HandlerResult {HandlerResultType = HandlerResultType.Error};
			}
		}
	}
}