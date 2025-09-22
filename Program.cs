using System.Collections.Generic;
using System.ComponentModel;

namespace Morozova_ISP_231_Lab5_ClassWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //void SayHello()
            //{
            //    Console.WriteLine("Hello");
            //}
            //void SayHello() => Console.WriteLine("Hello");


            //Console.Write("Введите ваше имя: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Введите ваш язык (русский, немецкий или английский): ");
            //string language = Console.ReadLine().ToLower();

            //void SayHelloRu() => Console.WriteLine($"Привет, {name}");
            //void SayHelloEn() => Console.WriteLine($"Hello, {name}");
            //void SayHelloDe() => Console.WriteLine($"Gutten tag, {name}");

            //switch (language)
            //{
            //    case "русский":
            //        SayHelloRu();
            //        break;
            //    case "немецкий":
            //        SayHelloDe();
            //        break;
            //    case "английский":
            //        SayHelloEn();
            //        break;
            //    default:
            //        Console.WriteLine("Язык не найден");
            //        break;
            //}


            //static string Game()
            //{
            //    string fav_game = "HSR";
            //    return fav_game;
            //}
            //Console.WriteLine($"Любимая игра: {Game()}");


            //void Print(string message)
            //{
            //    Console.WriteLine(message);
            //}
            //Print("Hello");

            //void Sum(int x, int y)
            //{
            //    int result = x + y;
            //    Console.WriteLine(result);
            //}
            //Sum(5, 7);
            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            //Sum(x, y);

            //void PrintPersone(string personName = "Неведимка", int age = 11, string vuz = "Неизвестно")
            //{
            //    Console.WriteLine($"Имя: {personName}, возраст: {age}, ВУЗ: {vuz}");
            //}
            //PrintPersone("Ray", 18, "ВФ Волгу");
            //PrintPersone(vuz: "ВФ Волгу", age: 18, personName: "Ray");
            //PrintPersone();

            //string GetMessage() {
            //    return "Hello";
            //}
            //int GetNumber() => 4;
            //var result = GetMessage();
            //Console.WriteLine(result);

            //int Sum(int a, int b) => a + b;
            //Console.WriteLine(Sum(5, 5));

            //void CheckValue(int num)
            //{
            //    if (num < 0)
            //    {
            //        Console.WriteLine("Число отрицательное");
            //        //return;
            //    } 
            //    Console.WriteLine("Число положительное");

            //}
            //CheckValue(5);
            //CheckValue(-5);

            //Random random = new Random();
            //int number1 = random.Next();
            //int number2 = random.Next(1, 100);
            //Console.WriteLine(number1);
            //Console.WriteLine(number2);


            //void ShowWelcomeMessage() => Console.WriteLine("Здарвствуйте");
            //void ShowGoodByeMessage() => Console.WriteLine("Хорошего дня");

            //string GetWeather()
            //{
            //    string[] weathers = ["солнечная", "пасмурная", "дождливая", "снежная", "уроган"];
            //    Random random = new();
            //    int index = random.Next(weathers.Length);
            //    return weathers[index];
            //}

            //ShowWelcomeMessage();
            //Console.WriteLine($"Погода на сегодня {GetWeather()}");
            //ShowGoodByeMessage();

            //int Factorial(int n)
            //{
            //    if (n == 1) return 1;
            //    return n * Factorial(n - 1);
            //}
            //Console.WriteLine(Factorial(5));

            //void Compare(int[] numbers1, int[] numbers2)
            //{
            //    int numbers1Sum = 0;
            //    int numbers2Sum = 0;
            //    foreach (int number in numbers1)
            //        numbers1Sum += number;
            //    foreach (int number in numbers2)
            //        numbers2Sum += number;
            //    if (numbers1Sum > numbers2Sum)
            //        Console.WriteLine("Сумма чисел первого массива больше");
            //    else if (numbers1Sum < numbers2Sum)
            //        Console.WriteLine("Сумма чисел второго массива больше");
            //    else
            //        Console.WriteLine("Суммы чисел равны");
            //}

            //int[] numbers1 = [1, 2, 3];
            //int[] numbers2 = [3, 4, 5, 6, 7];
            //Compare(numbers1, numbers2);


            //void Compare(int[] numbers1, int[] numbers2)
            //{
            //    int numbers1Sum = Sum(numbers1);
            //    int numbers2Sum = Sum(numbers2);
            //    if (numbers1Sum > numbers2Sum)
            //        Console.WriteLine("Сумма чисел первого массива больше");
            //    else if (numbers1Sum < numbers2Sum)
            //        Console.WriteLine("Сумма чисел второго массива больше");
            //    else
            //        Console.WriteLine("Суммы чисел равны");

            //    int Sum(int[] numbers)
            //    {
            //        int result = 0;
            //        foreach (int number in numbers)
            //            result += number;
            //        return result;
            //    }
            //}

            //int[] numbers1 = [1, 2, 3];
            //int[] numbers2 = [3, 4, 5, 6, 7];
            //Compare(numbers1, numbers2);

            //int Sum(int[] numbers)
            //{
            //    int limit = 0;
            //    int result = 0;
            //    foreach (int number in numbers)
            //    {
            //        if (IsPassed(number, limit)) result += number;
            //    }
            //    return result;
            //    bool IsPassed(int number)
            //    {
            //        return number > limit;
            //    }
            //}

            int Sum(int[] numbers)
            {
                int limit = 0;
                int result = 0;
                foreach (int number in numbers)
                {
                    if (IsPassed(number, limit)) result += number;
                }
                return result;
                static bool IsPassed(int number, int lim)
                {
                    return number > lim;
                }
            }

            int[] numbers1 = [-3, -2];
            int[] numbers2 = [3, 2];
            Console.WriteLine(Sum(numbers1));
            Console.WriteLine(Sum(numbers2));

            // 1. Ответ: Ничего
            // 2. Ответ: void ShowWelcomeMessage()
            // 3. Ответ: Метод вызовет ошибку компиляции
            // 4. Ответ: void PrintNumber(int number)
            // 5. Ответ: PrintMessage('Hello, World!')
        }

    }
}
