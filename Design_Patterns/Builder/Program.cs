namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MessageBuilder messageBuilder = new ConcreteMessageBuilder();
            Director director = new Director(messageBuilder);
            director.Create("Hi, How are you?", "danil@gmail.com");
        }
    }
}