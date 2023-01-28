
namespace Builder
{
    public abstract class MessageBuilder
    {
        public abstract void FromUser(string text, string to);
        public abstract void ByDefault();
        public abstract void FromServer();
    }

    public class ConcreteMessageBuilder : MessageBuilder
    {
        Message message = new Message();

        public override void ByDefault()
        {
            message.From = "You";
            message.Date = "Now";
        }

        public override void FromServer()
        {
            message.Departure_time = "Now";
        }

        public override void FromUser(string text, string to)
        {
            message.Text = text;
            message.To = to;
        }
    }

    public class Director
    {
        MessageBuilder messageBuilder;
        public Director(MessageBuilder _messageBuilder)
        {
            messageBuilder = _messageBuilder;
        }

        public void Create(string text, string to)
        {
            messageBuilder.FromUser(text, to);
            messageBuilder.ByDefault();
            messageBuilder.FromServer();
        }
    }
}
