namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите прибытие поезда в часах: ");
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите прибытие поезда в минутах: ");
            var b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите отправление поезда в часах: ");
            var c = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите отправление поезда в минутах: ");
            var d = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите прибытие пассажира в часах: ");
            var m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите прибытие пассажира в минутах: ");
            var n = int.Parse(Console.ReadLine());
            if (a < m && b < n && c > m && d > n)
            {
                Console.WriteLine("Поезд стоит на перроне");
            }
            else
            {
                Console.WriteLine("Поезд уехал");
            }
        }
    }
}
