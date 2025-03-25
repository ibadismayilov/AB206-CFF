using System.Runtime.ConstrainedExecution;

namespace ZeroToHeroTasksPart1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //          Tapşırıq 1:
            //int number__first = 10;
            //int number__second = 20;
            //int sum = number__first + number__second;
            //Console.WriteLine(sum);

            //            Tapşırıq 2:
            //int number = 10;
            //int square = number * number;
            //Console.WriteLine(square);


            //            Tapşırıq 3:
            //string name = "Ibad";
            //int age = 19;
            //Console.WriteLine($"Salam mənim adım {name}dır və mənim {age} yaşım var");

            //            Tapşırıq 4:
            //int number__first = 10;
            //int number__second = 20;

            //int temp = number__first;
            //number__first = number__second;
            //number__second = temp;

            //Console.WriteLine($"First number: {number__first}, Second number: {number__second}");

            //            Tapşırıq 5:
            //Console.WriteLine("Please enter numbers");

            //int sum = 0;
            //int count = 0;

            //for (int i = 0; i < 3; i++)
            //{
            //    sum += Convert.ToInt32(Console.ReadLine());
            //    count++;
            //}

            //Console.WriteLine($"\nCount: {count}");
            //Console.WriteLine($"Sum: {sum}");

            //            Tapşırıq 6:
            //int number = 1234;
            //int sum = 0;

            //while(number > 0)
            //{
            //    sum += number % 10;

            //    number = number / 10;
            //}

            //Console.WriteLine(sum);

            //            Tapşırıq 7:
            //Console.WriteLine("Please enter a number");
            //int number = Convert.ToInt32(Console.ReadLine());

            //bool check = false;

            //for (int i = 0; i < number; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        check = true;
            //    } else
            //    {
            //        check = false;

            //    }
            //}

            //if(!check)
            //{
            //    Console.WriteLine("Number is even");
            //} else
            //{
            //    Console.WriteLine("Number is odd");
            //}

            //            Tapşırıq 8:
            //Console.WriteLine("Please enter two number");
            //int max = 0;

            //for (int i = 0; i < 2; i++)
            //{
            //    int input = Convert.ToInt32(Console.ReadLine());
            //    if (input > max)
            //    {
            //        max = input;
            //    }
            //}

            //Console.WriteLine($"\nLarge number: {max}");

            //            Tapşırıq 9:
            //Console.WriteLine("Please enter a number");
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (number < 0)
            //{
            //    Console.WriteLine("Number is negative");
            //}
            //else if (number > 0)
            //{
            //    Console.WriteLine("Number is positive");
            //}
            //else
            //{
            //    Console.WriteLine("Number is equal zero");
            //}

            //            Tapşırıq 10:
            //Console.WriteLine("Please enter a number");
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (number % 5 == 0 && number % 3 == 0)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}

            //            Tapşırıq 11:
            //Console.WriteLine("Please enter a number");
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (number % 2 == 0 || number % 3 == 0)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}

            //            Tapşırıq 12:
            //Console.WriteLine("Please enter the number month");
            //int month__number = Convert.ToInt32(Console.ReadLine());

            //switch (month__number) {
            //    case 1:
            //        Console.WriteLine("January");
            //        break;
            //    case 2:
            //        Console.WriteLine("February");
            //        break;
            //    case 3:
            //        Console.WriteLine("March");
            //        break;
            //    case 4:
            //        Console.WriteLine("April");
            //        break;
            //    case 5:
            //        Console.WriteLine("May");
            //        break;
            //    case 6:
            //        Console.WriteLine("June");
            //        break;
            //    case 7:
            //        Console.WriteLine("July");
            //        break;
            //    case 8:
            //        Console.WriteLine("August");
            //        break;
            //    case 9:
            //        Console.WriteLine("September");
            //        break;
            //    case 10:
            //        Console.WriteLine("October");
            //        break;
            //    case 11:
            //        Console.WriteLine("November");
            //        break;
            //    case 12:
            //        Console.WriteLine("December");
            //        break;

            //    default:
            //        Console.WriteLine("Wrong number");
            //        break;
            //}

            //            Tapşırıq 13:
            //Console.WriteLine("Please enter your exam score.");
            //int score = Convert.ToInt32(Console.ReadLine());

            //if (score >= 91 && score <= 100)
            //{
            //    Console.WriteLine("A");
            //}
            //else if (score >= 81 && score < 90)
            //{
            //    Console.WriteLine("B");
            //}
            //else if (score >= 71 && score < 80)
            //{
            //    Console.WriteLine("C");
            //}
            //else if (score >= 61 && score < 70)
            //{
            //    Console.WriteLine("D");
            //}
            //else if (score >= 51 && score < 60)
            //{
            //    Console.WriteLine("F");
            //}
            //else if (score >= 0 && score < 50)
            //{
            //    Console.WriteLine("Congratulations: 25%. Prepare the money");
            //}
            //else
            //{
            //    Console.WriteLine("Please enter range  between 0 and 100");
            //}

            //            Tapşırıq 14:
            //Console.WriteLine("Enter an operator. Example: +, -, *, / ");
            //int operations = Convert.ToChar(Console.ReadLine());

            //int result = 0;

            //Console.WriteLine("Please enter two number");
            //for (int i = 0; i < 2; i++)
            //{
            //    int numbers = Convert.ToInt32(Console.ReadLine());
            //    if (operations == '+')
            //    {
            //        result += numbers;
            //    }
            //    else if (operations == '-')
            //    {
            //        result -= numbers;
            //    }
            //    else if (operations == '*')
            //    {
            //        result = 1;
            //        result = numbers * numbers;

            //    }
            //    else if (operations == '/')
            //    {
            //        result /= numbers;
            //    }
            //    else
            //    {
            //        Console.WriteLine("False");
            //    }
            //}

            //Console.WriteLine($"Result of numbers: {result}");

            //            Tapşırıq 15: 
            //İstifadəçinin daxil etdiyi məbləğə əsasən endirim edən və aşağıdaki şəkildə nəticəni çap edən proqramı yazın.

            //Məbləğ 100 AZN və ya daha çoxdursa, 10 % endirim.

            //Məbləğ 50 - 99 AZN arasında olsa, 5 % endirim.

            //Məbləğ 50 AZN - dən aşağıdırsa, endirim yoxdur.

            //Endirimli qiymət: Alınan məhsulun dəyəri 120 AZN.Ödəyəcəyiniz məbləğ 108 AZN(10 % endirim tətbiq edildi)
        }
    }
}
