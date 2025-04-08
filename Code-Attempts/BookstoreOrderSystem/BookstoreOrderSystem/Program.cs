namespace BookstoreOrderSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result;
            Books books = new Books();

            do
            {
                Console.WriteLine("1. Yeni kitab əlavə et");
                Console.WriteLine("2. Bütün kitabları gör");
                Console.WriteLine("3. Kitab sifaris et");
                Console.WriteLine("4. Sifariş haqqında məlumat ver");
                Console.WriteLine("5. Sifarisi sil");
                Console.WriteLine("0. Programdan çıx");


                bool check = int.TryParse(Console.ReadLine(), out result);

                if (check)
                {

                    Order order = new Order();
                    switch (result)
                    {
                        case 0:
                            Console.WriteLine("Təşəkkürlər");
                            break;

                        case 1:
                            Console.Write("Kitabın adı: ");
                            books.Title = Console.ReadLine();

                            Console.Write("Author: ");
                            books.Author = Console.ReadLine();

                            Console.Write("Qiyməti: ");
                            books.Price = Convert.ToInt32(Console.ReadLine());

                            break;

                        case 2:
                            books.DisplayBookInfo();
                            break;

                        case 3:

                            Console.Write("Sifaris etmek istediyiniz kitabın adını daxil edin: ");
                            string bookTitle = Console.ReadLine();
                            order.PlaceOrder(bookTitle);

                            break;
                        case 4:
                            Console.Write("Sifariş etdiyiniz kitabın adını daxil edin: ");
                            string orderBookTitle = Console.ReadLine();
                            order.TrackOrder(orderBookTitle);

                            break;

                        case 5:
                            Console.Write("Silmek istediyiniz kitabın ID daxil edin: ");
                            int orderBookID = Convert.ToInt32(Console.ReadLine());
                            order.CancelOrder(orderBookID);

                            break;
                    }
                }


            }
            while (result != 0);
        }
    }
}
