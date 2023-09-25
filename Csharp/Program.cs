
namespace Lesson {

    class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue;
            string action;

            Console.WriteLine("Введите число 1");
            firstValue = int.Parse(Console.ReadLine());

            Console.WriteLine("ВВедите число 2");
            secondValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Выберите операцию '+' '- '*' '/' ");
            action = Console.ReadLine();

            switch (action) 
            {
                case "+":
                    Console.WriteLine(firstValue + secondValue);
                    break;
                case "-":
                    Console.WriteLine(firstValue - secondValue);
                    break;
                case "*":
                    Console.WriteLine(firstValue / secondValue);
                    break;
                    case "/":
                        Console.WriteLine(firstValue / secondValue);
                    break;
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }
        }

    }

}



