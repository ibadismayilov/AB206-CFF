using ListForHotel.Exceptions;
using ListForHotel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ListForHotel.Services;

public class RoomsServices
{
    private static List<Room> rooms = new List<Room>();

    public void AddRoom(Room room)
    {
        if (rooms is null)
        {
            throw new RoomException("Something went wrong");
        } else
        {
            rooms.Add(room);
        }
    }

    public Room FindAllRoom(int id)
    { 
        List<Room> newRoomList = new List<Room>();

        foreach (var item in rooms)
        {
            if (item.Id == id)
            {
                newRoomList.Add(item);
                Console.WriteLine($"{item.Name} | {item.Price} | {item.IsAvialable} | {item.PersonCapacity}");
            }
        }

        return null;
    }

    public void MakeReservation(int? roomId, int? countPerson)
    {
        foreach (Room item in rooms)
        {
            if (item.IsAvialable == true && item.PersonCapacity == countPerson)
            {
                Console.WriteLine("otaq rez olunub yeri get isinnen mesgul ol");
            } else
            {
                
            }
        }

        throw new RoomException("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
    }
}
