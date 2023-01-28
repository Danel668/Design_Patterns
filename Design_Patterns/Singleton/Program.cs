namespace Singleton
{
    public class Program
    {
        static void Main(string[] args)
        {
            Computer comp = new Computer();
            comp.Launch("Linux");

            comp.Os = OS.GetInstance("Windows"); // impossible

            Console.WriteLine(comp.Os.Name);
            Console.ReadKey();
        }
    }

    public class Computer
    {
        public OS? Os { get; set; }

        public void Launch(string OsName)
        {
            Os = OS.GetInstance(OsName);
        }
    }

    public class OS
    {
        private static OS? instance;

        public string? Name { get; set; }

        public OS(string name)
        {
            Name = name;
        }

        public static OS GetInstance(string name)
        {
            if (instance == null)
                instance = new OS(name);
            return instance;
        }
    }
}