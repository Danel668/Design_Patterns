namespace Template_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Week week = new Sunday();
            //Week week = new Monday();
            //Week week = new Tuesday();
            //Week week = new Wednesday();
            //Week week = new Thursday();
            //Week week = new Friday();
            //Week week = new Saturday();
            week.MyLifestyle();
        }
    }
}