using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelTask;

class Hotel
{
    private static int _hotelCounter = 1;
    public int ID { get; private set; }
    public string Name { get; set; }
    private Room[] _roomsList;

    public Hotel(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new Exception("Name olmadan Hotel yaratmaq olmaz");
        }

        ID = _hotelCounter++;
        Name = name;
        _roomsList = new Room[0];
    }

    public Room[] RoomsList => _roomsList;

    public void AddRoom(Room room)
    {
        Array.Resize(ref _roomsList, _roomsList.Length + 1);
        _roomsList[^1] = room;
    }

    public Room GetRoomID(int id)
    {
        foreach (var item in RoomsList)
        {
            if (item.ID == id)
            {
                return item;
            }
        }
        return null;
    }

    public Room[] FindAllRoom() => RoomsList;

    public void MakeReservation(int roomID, int customerCount)
    {
        Room room = GetRoomID(roomID);

        if (room == null)
            throw new Exception("Otaq tapılmadı.");

        if (!room.IsAvailable)
            throw new NotAvailableException("Bu otaq artıq rezervasiya olunub.");

        if (customerCount > room.PersonCapacity)
            throw new Exception("Müştəri sayı otağın tutumundan çoxdur.");

        room.IsAvailable = false;
        Console.WriteLine($"Rezervasiya uğurla edildi. Room ID: {room.ID}");
    }
}
