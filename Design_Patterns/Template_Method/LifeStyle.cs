
namespace Template_Method
{
    public abstract class Week
    {
        public void MyLifestyle()
        {
            WakeUp();
            HaveBreakfast();
            GoToTheGym();
            HaveLunch();
            DoStudy();
            HaveDinner();
            GoToSleep();
        }

        public abstract void WakeUp();
        public abstract void HaveBreakfast();
        public abstract void GoToTheGym();
        public abstract void HaveLunch();
        public abstract void DoStudy();
        public abstract void HaveDinner();
        public virtual void GoToSleep()
        {
            Console.WriteLine("Лечь спать в 2.00 am");
        }

    }

    public class Monday : Week
    {
        public override void DoStudy()
        {
            Console.WriteLine("Поучиться 4 часа");
        }

        public override void GoToTheGym()
        {
            Console.WriteLine("Позаниматься 30 минут");
        }

        public override void HaveBreakfast()
        {
            Console.WriteLine("Употребить 400 калорий");
        }

        public override void HaveDinner()
        {
            Console.WriteLine("Употребить 600 калорий");
        }

        public override void HaveLunch()
        {
            Console.WriteLine("Употребить 800 калорий");
        }

        public override void WakeUp()
        {
            Console.WriteLine("Встать в 9 часов");
        }
    }

    public class Tuesday : Week
    {
        public override void DoStudy()
        {
            Console.WriteLine("Поучиться 5 часа");
        }

        public override void GoToTheGym()
        {
            Console.WriteLine("Позаниматься 40 минут");
        }

        public override void HaveBreakfast()
        {
            Console.WriteLine("Употребить 450 калорий");
        }

        public override void HaveDinner()
        {
            Console.WriteLine("Употребить 500 калорий");
        }

        public override void HaveLunch()
        {
            Console.WriteLine("Употребить 700 калорий");
        }

        public override void WakeUp()
        {
            Console.WriteLine("Встать в 10 часов");
        }
    }

    public class Wednesday : Week
    {
        public override void DoStudy()
        {
            Console.WriteLine("Поучиться 6 часа");
        }

        public override void GoToTheGym()
        {
            Console.WriteLine("Позаниматься 20 минут");
        }

        public override void HaveBreakfast()
        {
            Console.WriteLine("Употребить 430 калорий");
        }

        public override void HaveDinner()
        {
            Console.WriteLine("Употребить 550 калорий");
        }

        public override void HaveLunch()
        {
            Console.WriteLine("Употребить 600 калорий");
        }

        public override void WakeUp()
        {
            Console.WriteLine("Встать в 9:30 часов");
        }
    }

    public class Thursday : Week
    {
        public override void DoStudy()
        {
            Console.WriteLine("Поучиться 5:40 часа");
        }

        public override void GoToTheGym()
        {
            Console.WriteLine("Позаниматься 45 минут");
        }

        public override void HaveBreakfast()
        {
            Console.WriteLine("Употребить 470 калорий");
        }

        public override void HaveDinner()
        {
            Console.WriteLine("Употребить 660 калорий");
        }

        public override void HaveLunch()
        {
            Console.WriteLine("Употребить 630 калорий");
        }

        public override void WakeUp()
        {
            Console.WriteLine("Встать в 8 часов");
        }
    }

    public class Friday : Week
    {
        public override void DoStudy()
        {
            Console.WriteLine("Поучиться 8 часов");
        }

        public override void GoToTheGym()
        {
            Console.WriteLine("Позаниматься 50 минут");
        }

        public override void HaveBreakfast()
        {
            Console.WriteLine("Употребить 300 калорий");
        }

        public override void HaveDinner()
        {
            Console.WriteLine("Употребить 690 калорий");
        }

        public override void HaveLunch()
        {
            Console.WriteLine("Употребить 700 калорий");
        }

        public override void WakeUp()
        {
            Console.WriteLine("Встать в 11 часов");
        }
    }

    public class Saturday : Week
    {
        public override void DoStudy()
        {
            Console.WriteLine("Поучиться 5:40 часов");
        }

        public override void GoToTheGym()
        {
            Console.WriteLine("Позаниматься 55 минут");
        }

        public override void HaveBreakfast()
        {
            Console.WriteLine("Употребить 390 калорий");
        }

        public override void HaveDinner()
        {
            Console.WriteLine("Употребить 600 калорий");
        }

        public override void HaveLunch()
        {
            Console.WriteLine("Употребить 810 калорий");
        }

        public override void WakeUp()
        {
            Console.WriteLine("Встать в 12 часов");
        }
    }

    public class Sunday : Week
    {
        public override void DoStudy()
        {
            Console.WriteLine("Поучиться 5:30 часов");
        }

        public override void GoToTheGym()
        {
            Console.WriteLine("Позаниматься 1 час");
        }

        public override void HaveBreakfast()
        {
            Console.WriteLine("Употребить 440 калорий");
        }

        public override void HaveDinner()
        {
            Console.WriteLine("Употребить 700 калорий");
        }

        public override void HaveLunch()
        {
            Console.WriteLine("Употребить 830 калорий");
        }

        public override void WakeUp()
        {
            Console.WriteLine("Встать в 12:30 часов");
        }
    }
}
