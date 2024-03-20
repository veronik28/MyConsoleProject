namespace MyConsoleProject;

class Program
{
     static void Main(string[] args)
    {
        // работу выполнили Кушеварова и Суслинников

        Console.WriteLine("Введите значение x:");
        double x = Convert.ToDouble(Console.ReadLine());

        double result = 5 * Math.Cos(2 * x);

        Console.WriteLine($"Результат вычисления функции 5Cos(2x) для x = {x}: {result}");
    }

}
