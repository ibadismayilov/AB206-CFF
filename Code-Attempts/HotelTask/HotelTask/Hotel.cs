using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelTask;

class Hotel
{
    private int _id =(int) Math.Floor(8.75);

    public int ID
    {
        get
        {
            return _id;
        }
        set
        {
            _id = value;
        }
    }

    public string Name { get; set; }

    private Room[] _roomsList;

    public Hotel( string name)
    {
        _roomsList = new Room[0];

        if (name is null)
        {
            throw new Exception("Name olmadan Hotel yaratmaq olmaz");
        }

        Name = name;
    }

    public Room[] RoomsList
    {
        get
        {
            return _roomsList;
        }
        set
        {
            _roomsList = value;
        }
    }

    public void AddRoom(Room room)
    {
        Array.Resize(ref _roomsList, _roomsList.Length + 1);
        _roomsList[_roomsList.Length - 1] = room;
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

    public Room[] FindAllRoom()
    {

        return RoomsList;
    }

    public void MakeReservation(int roomID, int customerCount)
    {

        Room room = GetRoomID(roomID);

        if (roomID== null)
            throw new Exception("roomID null ola bilməz.");

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
