namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IReading reading = new ReadFromStdin();

            //IReading reading = new ReadFromFile();

            var doc = new MyDocument("ForWork", "json", reading);
            doc.Reading();
        }
    }

    public interface IReading
    {
        public string? Condition { get; set; }
    }

    public class ReadFromStdin :  IReading
    {
        public string? Condition { get; set; } = "Stdin";
        
    }

    public class ReadFromFile : IReading
    {
        public string? Condition { get; set; } = "File";
    }

    public class MyDocument
    {
        public MyDocument(string name, string type, IReading mode)
        {
            Name = name;
            Type = type;
            Mode = mode;
        }
        public string Name { get; set; }
        public string Type { get; set; }
        public IReading Mode {private get; set; }
        public string? Body { get; set; }

        public void Reading()
        {
            if (Mode.Condition == "File")
                Console.WriteLine("Заполняем Body из файла");
            else
                Console.WriteLine("Открываем чтения из консоли");
        }
    }
}