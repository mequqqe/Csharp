
namespace Lesson {

    class Program
    {
        static void Main(string[] args)
        {
            string str;

            int a, b;

            Console.WriteLine("Введите первое число");

            str = Console.ReadLine();

            a=Convert.ToInt32(str);

            Console.WriteLine("ВВедите второе число");

            str=Console.ReadLine();

            b = Convert.ToInt32(str);

            int result = a + b;

            Console.WriteLine("Сумма чисел" + result);
        }

    }

}



