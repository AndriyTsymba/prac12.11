//namespace prac12._11
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("It's easy to win forgiveness for being wrong; \nbeing right is what gets you ninto real trouble.\nBjarne Stroustrup");
//        }
//    }
//}

//2 
//namespace prac12._11
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Введіть п'ять чисел:");
//            int[] numbers = new int[5];
//            for (int i = 0; i < 5; i++)
//            {
//                numbers[i] = int.Parse(Console.ReadLine());
//            }
//            int sum = 0, product = 1, max = numbers[0], min = numbers[0];
//            foreach (int num in numbers)
//            {
//                sum += num;
//                product *= num;
//                if (num > max) max = num;
//                if (num < min) min = num;
//            }
//            Console.WriteLine($"Сума чисел: {sum}");
//            Console.WriteLine($"Максимум: {max}");
//            Console.WriteLine($"Мінімум: {min}");
//            Console.WriteLine($"Добуток чисел: {product}");
//        }
//    }
//}

///3
//namespace prac12._11
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Введіть шестизначне число:");
//            string input = Console.ReadLine();
//            char[] reversedArray = input.ToCharArray();
//            Array.Reverse(reversedArray);
//            string reversedNumber = new string(reversedArray);
//            Console.WriteLine($"Перевернуте число: {reversedNumber}");
//        }
//    }
//}

//4 

//namespace prac12._11
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Введіть межі числового діапазону:");
//            int start = int.Parse(Console.ReadLine());
//            int end = int.Parse(Console.ReadLine());
//            int a = 0, b = 1;
//            Console.WriteLine("Числа Фібоначчі в діапазоні:");
//            while (a <= end)
//            {
//                if (a >= start) Console.Write(a + " ");
//                int next = a + b;
//                a = b;
//                b = next;
//            }
//        }
//    }
//}

//5 


//namespace prac12._11
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Введіть числа A і B (A < B):");
//            int A = int.Parse(Console.ReadLine());
//            int B = int.Parse(Console.ReadLine());

//            for (int i = A; i <= B; i++)
//            {
//                for (int j = 0; j < i; j++)
//                {
//                    Console.Write(i + " ");
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}

//6

namespace prac12._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть довжину лінії:");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть символ заповнювач:");
            char filler = Console.ReadKey().KeyChar;
            Console.WriteLine("\nОберіть напрямок лінії (1 - горизонтальна, 2 - вертикальна):");
            int direction = int.Parse(Console.ReadLine());
            if (direction == 1)
            {
                for (int i = 0; i < length; i++)
                {
                    Console.Write(filler);
                }
            }
            else if (direction == 2)
            {
                for (int i = 0; i < length; i++)
                {
                    Console.WriteLine(filler);
                }
            }
            else
            {
                Console.WriteLine("Неправильний вибір напрямку.");
            }
        }
    }
}
