namespace Sug.Feature.ServiceBus.MessageHandlers
{
	using System.Threading.Tasks;
	using Sitecore.Framework.Messaging;
	using Messages;

	public class TestMessageHandler : IMessageHandler<TestMessage>, IMessageHandler
	{
		public async Task Handle(TestMessage message, IMessageReceiveContext receiveContext, IMessageReplyContext replyContext)
		{
			var messageBody = message.MessageBody;
		}
	}
}