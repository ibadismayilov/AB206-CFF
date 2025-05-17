namespace HotelTask;

internal class Program
{
    static void Main(string[] args)
    {
        int result;
        List<Hotel> hotels = new List<Hotel>();
        Hotel selectedHotel = null;

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
                        ManageHotels(hotels, ref selectedHotel);
                        break;
                    case 0:
                        Console.WriteLine("Çıxış edildi.");
                        break;
                }
            }
        } while (result != 0);
    }

    static void ManageHotels(List<Hotel> hotels, ref Hotel selectedHotel)
    {
        int hotelOption;
        do
        {
            Console.WriteLine("1. Hotel yarat");
            Console.WriteLine("2. Bütün Hotelləri gör");
            Console.WriteLine("3. Hotel seç");
            Console.WriteLine("0. Əsas menyuya qayıt");

            bool check = int.TryParse(Console.ReadLine(), out hotelOption);
            if (check)
            {
                switch (hotelOption)
                {
                    case 1:
                        Console.Write("Hotelin adını daxil edin: ");
                        string hotelName = Console.ReadLine();
                        Hotel hotel = new Hotel(hotelName);
                        hotels.Add(hotel);
                        Console.WriteLine("Hotel yaradıldı");
                        break;
                    case 2:
                        foreach (var h in hotels)
                        {
                            Console.WriteLine($"ID: {h.ID} | Name: {h.Name}");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Mövcud Hotellər:");
                        for (int i = 0; i < hotels.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {hotels[i].Name}");
                        }
                        Console.Write("Seçmək istədiyiniz hotelin nömrəsini daxil edin: ");
                        int index = int.Parse(Console.ReadLine()) - 1;

                        if (index >= 0 && index < hotels.Count)
                        {
                            selectedHotel = hotels[index];
                            Console.WriteLine($"{selectedHotel.Name} hotel seçildi.");
                            ManageRooms(selectedHotel);
                        }
                        else
                        {
                            Console.WriteLine("Yanlış seçim.");
                        }
                        break;
                }
            }
        } while (hotelOption != 0);
    }

    static void ManageRooms(Hotel hotel)
    {
        int roomOption;
        do
        {
            Console.WriteLine("1. Room yarat");
            Console.WriteLine("2. Bütün Roomları gör");
            Console.WriteLine("3. Rezervasiya et");
            Console.WriteLine("0. Əvvəlki menyuya qayıt");

            bool roomCheck = int.TryParse(Console.ReadLine(), out roomOption);
            if (roomCheck)
            {
                try
                {
                    switch (roomOption)
                    {
                        case 1:
                            Console.Write("Room name: ");
                            string roomName = Console.ReadLine();

                            Console.Write("Qiymət: ");
                            double roomPrice = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Adam sayı: ");
                            int capacity = Convert.ToInt32(Console.ReadLine());

                            Room room = new Room(roomName, roomPrice, capacity);
                            hotel.AddRoom(room);
                            Console.WriteLine("Room əlavə edildi.");
                            break;

                        case 2:
                            var rooms = hotel.FindAllRoom();
                            if (rooms.Length == 0)
                                Console.WriteLine("Otaq tapılmadı.");
                            else
                                foreach (var r in rooms) r.ShowInfo();
                            break;

                        case 3:
                            Console.Write("Room ID daxil edin: ");
                            int roomID = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Adam sayı: ");
                            int customerCount = Convert.ToInt32(Console.ReadLine());

                            hotel.MakeReservation(roomID, customerCount);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Xəta baş verdi: {ex.Message}");
                }
            }
        } while (roomOption != 0);
    }
}