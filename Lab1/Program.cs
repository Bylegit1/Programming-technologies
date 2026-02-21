namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите прибытие поезда в часах: ");
            var a = int.Parse(Console.ReadLine());
            if (a > 23 || a < 0)
            {
                Console.WriteLine("Вы не вошли в диапазон!");
                Environment.Exit(0);
            }
            Console.WriteLine("Введите прибытие поезда в минутах: ");
            var b = int.Parse(Console.ReadLine());
            if (b > 59 || b < 0)
            {
                Console.WriteLine("Вы не вошли в диапазон!");
                Environment.Exit(0);
            }
            Console.WriteLine("Введите отправление поезда в часах: ");
            var c = int.Parse(Console.ReadLine());
            if (c > 23 || c < 0)
            {
                Console.WriteLine("Вы не вошли в диапазон!");
                Environment.Exit(0);
            }
            Console.WriteLine("Введите отправление поезда в минутах: ");
            var d = int.Parse(Console.ReadLine());
            if (d > 59 || d < 0)
            {
                Console.WriteLine("Вы не вошли в диапазон!");
                Environment.Exit(0);
            }
            Console.WriteLine("Введите прибытие пассажира в часах: ");
            var m = int.Parse(Console.ReadLine());
            if (m > 23 || m < 0)
            {
                Console.WriteLine("Вы не вошли в диапазон!");
                Environment.Exit(0);
            }
            Console.WriteLine("Введите прибытие пассажира в минутах: ");
            var n = int.Parse(Console.ReadLine());
            if (n > 59 || n < 0)
            {
                Console.WriteLine("Вы не вошли в диапазон!");
                Environment.Exit(0);
            }
            int countMinutesArrive = a * 60 + b;
            int countMinutesDeparture = c * 60 + d;
            int countMinutesPassenger = m * 60 + n;
            if (countMinutesArrive < countMinutesPassenger && countMinutesArrive < countMinutesDeparture && countMinutesPassenger < countMinutesDeparture)
            {
                Console.WriteLine("Поезд стоит на платформе");
            }
            else
            {
                Console.WriteLine("Поезд не стоит на платформе");
            }
        }
    }
}