namespace HotelTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result;

            Hotel hotel = null;

            do
            {
                Console.WriteLine("1. Sisteme giris");
                Console.WriteLine("0. Çıxış");

                bool check = int.TryParse(Console.ReadLine(), out result);

                if (check)
                {
                    switch (result)
                    {
                        case 1:
                            Console.WriteLine("1. Hotel yarat");
                            Console.WriteLine("2. Butun Hotelleri gor");
                            Console.WriteLine("3. Hotel sec");
                            Console.WriteLine("0. Çıxış");

                            int hotelOption = int.Parse(Console.ReadLine());

                            if (hotelOption == 1)
                            {
                                if (hotel == null)
                                {
                                    Console.Write("Hotelin adını daxil edin: ");
                                    string hotelName = Console.ReadLine();
                                    hotel = new Hotel(hotelName);
                                    Console.WriteLine("Hotel yaradildi");
                                    Console.WriteLine("=======================================================");
                                }
                                else
                                {
                                    Console.WriteLine($"Hotel artıq yaradılıb: {hotel.Name}");
                                }
                            }

                            //if (hotelOption == 2)
                            //{
                                
                            //}

                            //if (hotelOption == 3)
                            //{
                                
                            //}

                            //if (hotelOption == 4)
                            //{
                            //    Console.WriteLine("Çıxış edildi");
                            //}

                            bool roomCheck = int.TryParse(Console.ReadLine(), out result);

                            do
                            {
                                Console.WriteLine("1. Room yarat");
                                Console.WriteLine("2. Butun Roomlari  gor");
                                Console.WriteLine("3. Rezervasya et");
                                Console.WriteLine("4. Evvelki menuya qayit.");
                                Console.WriteLine("0. Çıxış");

                                if (roomCheck)
                                {
                                    switch (result)
                                    {
                                        case 1:
                                            Console.WriteLine("Room yaratmaq üçün qiyməti, otağın adı və adam sayini daxil edin");
                                            Console.Write("Room name: ");
                                            string roomName = Console.ReadLine();

                                            Console.Write("Qiymət: ");
                                            double roomPrice = Convert.ToDouble(Console.ReadLine());

                                            Console.Write("Adam sayı: ");
                                            int capacity = Convert.ToInt32(Console.ReadLine());

                                            Room room = new Room(roomName, roomPrice, capacity);
                                            hotel.AddRoom(room);
                                            break;

                                        case 2:
                                            hotel.FindAllRoom();
                                            break;

                                        case 3:
                                            Console.Write("Qiymət: ");
                                            int roomID = Convert.ToInt32(Console.ReadLine());

                                            Console.Write("Adam sayı: ");
                                            int customerCount = Convert.ToInt32(Console.ReadLine());
                                            hotel.MakeReservation(roomID, customerCount);

                                            break;
                                    }

                                }
                            }
                            while (result != 0);

                            Console.WriteLine("0. Exit");
                            break;
                    }
                }

            }
            while (result != 0);
        }
    }
}
