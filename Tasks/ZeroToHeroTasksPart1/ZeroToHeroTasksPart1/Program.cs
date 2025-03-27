using System.Diagnostics.Metrics;
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
            //Console.WriteLine("Please enter price.");
            //double price = Convert.ToDouble(Console.ReadLine());  

            //double discount = 0;
            //double result = price;

            //if (price >= 100)
            //{
            //    discount = (price * 10) / 100;
            //    result = price - discount;
            //    Console.WriteLine($"Sizə tətbiq olunacaq endirim həcmi: {discount} AZN. \nEndirim tətbiq olunandan sonraki məbləğ isə {result} AZN");
            //}
            //else if (price >= 50 && price <= 99)
            //{
            //    discount = (price * 5) / 100;
            //    result = price - discount;
            //    Console.WriteLine($"Sizə tətbiq olunacaq endirim həcmi: {discount} AZN. \nEndirim tətbiq olunandan sonraki məbləğ isə {result} AZN");
            //}
            //else if (price < 50)
            //{
            //    Console.WriteLine("Endirim yoxdur");
            //} else
            //{
            //    Console.WriteLine(price);
            //}


            //            Tapşırıq 16:
            //Console.WriteLine("Please enter your name and password.");
            //string name = Console.ReadLine();
            //string password = Console.ReadLine();

            //var admin__information = new
            //{
            //    admin__name = "admin",
            //    admin__password = "222"
            //};

            //if (name == admin__information.admin__name && password == admin__information.admin__password)
            //{
            //    Console.WriteLine("->Access was granted");
            //}
            //else
            //{
            //    Console.WriteLine("\n->Invalid name or password. Please enter correct information.\n");

            //    Console.WriteLine("->Please enter your name and password again.");
            //    name = Console.ReadLine();
            //    password = Console.ReadLine();

            //    if (name == admin__information.admin__name && password == admin__information.admin__password)
            //    {
            //        Console.WriteLine("Access was granted");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Access denied. Invalid credentials.");
            //    }
            //}

            //            Tapşırıq 17:
            //AZN - dən USD və ya USD-dən AZN - ə məzənnə çevrilməsi həyata keçirən və nəticəni çap edən proqram yazın. (sabit məzənnə təyin edin).
            //string current__rate = "";

            //while (current__rate != "azn" && current__rate != "usd")
            //{
            //    Console.WriteLine("Please select rate azn or usd.");
            //    current__rate = Console.ReadLine();

            //    if (current__rate != "azn" && current__rate != "usd")
            //    {
            //        Console.WriteLine("Please only select azn or usd.");
            //    }
            //}

            //Console.WriteLine("Please enter price.");
            //double price = Convert.ToDouble(Console.ReadLine());

            //double value = 1.70;
            //double result = 0;

            //if (current__rate == "usd")
            //{
            //    result = price / value;
            //    Console.WriteLine(result);
            //}
            //else if (current__rate == "azn")
            //{
            //    result = price * value;
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine(price);
            //}

            //            Tapşırıq 18: 
            //Console.WriteLine("Please enter Height and Weight.");
            //double height = Convert.ToDouble(Console.ReadLine());
            //double weight = Convert.ToDouble(Console.ReadLine());

            //double result = weight / (height * height);

            //if (result < 18.5)
            //{
            //    Console.WriteLine("Çəki azlığı");
            //}
            //else if (result >= 18.5 && result < 24.9)
            //{
            //    Console.WriteLine("Normal çəki");
            //}
            //else if (result >= 25 && result < 29.9)
            //{
            //    Console.WriteLine("Artıq çəki");
            //}
            //else
            //{
            //    Console.WriteLine("Piylənmə");
            //}

            //            Tapşırıq 19:  
            //Console.WriteLine("Please create balance");
            //double create__balance = Convert.ToDouble(Console.ReadLine());

            //while (create__balance <= 0)
            //{
            //    Console.WriteLine("Please enter a real price");
            //    create__balance = Convert.ToDouble(Console.ReadLine());
            //}

            //double current__balance = create__balance;

            //Console.WriteLine("Do you just want to check the balance?? (yes(y) or no(n))");
            //string just_check__balance = Console.ReadLine();

            //if (just_check__balance == "yes" || just_check__balance == "y")
            //{
            //    Console.WriteLine($"Your current balance: {current__balance}");
            //    return;
            //}
            //else if (just_check__balance == "no" || just_check__balance == "n")
            //{
            //    Console.WriteLine("\nOkay, let's continue :)");

            //    Console.WriteLine("Do you want to check your balance? (yes(y) or no(n))");
            //    string check__balance = Console.ReadLine();

            //    if (check__balance == "yes" || check__balance == "y")
            //    {
            //        Console.WriteLine($"Your current balance: {current__balance}");
            //    }
            //    else if (check__balance == "no" || check__balance == "n")
            //    {
            //        Console.WriteLine("\nOkay, let's continue :)");
            //    }
            //    else
            //    {
            //        Console.WriteLine("-1");
            //    }

            //    Console.WriteLine("Want to increase your balance? (yes(y) or no(n))");
            //    string decision__increase = Console.ReadLine();

            //    if (decision__increase == "yes" || decision__increase == "y")
            //    {
            //        Console.WriteLine("\nPlease enter a price");
            //        double price = Convert.ToDouble(Console.ReadLine());

            //        while (price <= 0)
            //        {
            //            Console.WriteLine("Please enter a valid amount");
            //            price = Convert.ToDouble(Console.ReadLine());
            //        }

            //        current__balance += price;
            //        Console.WriteLine($"\nUpdated balance: {current__balance}");
            //        return;
            //    }

            //    Console.WriteLine("\nDo you want to withdraw money from your balance? (yes(y) or no(n))");
            //    string decision__decrement = Console.ReadLine();

            //    if (decision__decrement == "yes" || decision__decrement == "y")
            //    {
            //        Console.WriteLine("\nPlease enter a price");
            //        double price = Convert.ToDouble(Console.ReadLine());

            //        double decrement = 0;

            //        while (price <= 0 || price > current__balance)
            //        {
            //            Console.WriteLine("Invalid amount. The issued capital cannot be more than the current capital. Enter a valid withdrawal amount:");
            //            price = Convert.ToDouble(Console.ReadLine());
            //        }

            //        decrement = current__balance - price;
            //        Console.WriteLine($"\nUpdated balance: {decrement}");
            //    }
            //    else if (decision__decrement == "no" || decision__decrement == "n")
            //    {
            //        Console.WriteLine($"Your current balance: {current__balance}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("-1");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("-1");
            //}

            //            Tapşırıq 20:
            //int[] number = new int[3] { 1, 2, 3 };

            //for (int i = 0; i < number.Length; i++)
            //{
            //    Console.WriteLine(number[i]);
            //}

            //            Tapşırıq 21:
            //int[] number = new int[3] { 1, 2, 3 };
            //int sum = 0;

            //for (int i = 0; i < number.Length; i++)
            //{
            //    sum += number[i];
            //}
            //Console.WriteLine(sum);

            //            Tapşırıq 22:
            //int[] number = new int[3] { 1, 2, 3 };
            //int sum = 0;
            //int count = 0;

            //for (int i = 0; i < number.Length; i++)
            //{
            //    sum += number[i];
            //    count++;
            //}
            //int average = sum / count;

            //Console.WriteLine(average);

            //            Tapşırıq 23:
            //int[] number = new int[3] { 1, 2, 3 };
            //int min = number[0];
            //int max = number[0];
            //int minIndex = 0;
            //int maxIndex = 0;

            //for (int i = 0; i < number.Length; i++) 
            //{
            //    if (number[i] > max)
            //    {
            //        max = number[i];
            //        maxIndex = i;
            //    }

            //    if (number[i] < min) 
            //    {
            //        min = number[i];
            //        minIndex = i;
            //    }
            //}

            //Console.WriteLine($"Max: {max}, Index: {maxIndex}");
            //Console.WriteLine($"Min: {min}, Index: {minIndex}");


            //            Tapşırıq 24:
            //int[] number = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int odd = 0;
            //int even = 0;

            //for (int i = 0; i < number.Length; i++)
            //{
            //    if (number[i] % 2 == 0) 
            //    {
            //        even++;
            //        Console.WriteLine($"Even: {number[i]}");
            //    }
            //    else 
            //    {
            //        odd++;
            //    }
            //}

            //Console.WriteLine($"\nTotal Odd: {odd}");
            //Console.WriteLine($"Total Even: {even}");

            //            Tapşırıq 25:
            //int[] number = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int[] newArray = new int[10];

            //for (int i = 0; i < number.Length; i++)
            //{
            //    newArray[i] = number[i];
            //}

            //for (int i = number.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(newArray[i]);
            //}

            //            Tapşırıq 26:
            //double[] number = new double[5] { 1, 2.1, 3.4, 4, 5.7 };
            //int index = 0;

            //for (int i = 0; i < number.Length; i++)
            //{
            //    if (number[i] % 1 == 0)
            //    {
            //        index = i;
            //        Console.WriteLine(number[i]);
            //        Console.WriteLine($"Index: {index}");
            //    }
            //}

            //            Tapşırıq 27:
            //int[] number = new int[10] { 1, 2, 3, 4, 5, 5, 4, 8, 9, 10 };
            //int[] newArry = new int[number.Length];

            //for (int i = 0; i < number.Length; i++)
            //{
            //    newArry[i] = number[i];

            //    for (int j = 0; j < i; j++)
            //    {
            //        if (number[i] == number[j])
            //        {
            //            Console.WriteLine(newArry[j]);
            //        }
            //    }
            //}


            //            Tapşırıq 28:
            //int[] number = new int[10] { 1, 2, 3, 4, 5, 5, 4, 8, 9, 10 };
            //int[] newArry = new int[number.Length];

            //int max = number[0];
            //int secondMaxNumber = number[0];

            //for (int i = 0; i < number.Length; i++)
            //{
            //    if (number[i] > max)
            //    {
            //        max = number[i];
            //    }
            //}

            //for (int i = 0; i < number.Length; i++)
            //{
            //    newArry[i] = number[i];

            //    if ( number[i] != max)
            //    {
            //        secondMaxNumber = number[i];
            //    }
            //}

            //Console.WriteLine(secondMaxNumber);
        }
    }
}
