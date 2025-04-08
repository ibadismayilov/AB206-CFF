using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreOrderSystem;

public class Order : IOrderMethodsInterface
{
    public string BookTitle { get; set; }
    public DateTime OrderDate { get; set; }
    public bool OrderStatus { get; set; }
    public int OrderId { get; set; }
    private static int _nextId = 1;

    public Order()
    {
        OrderId = _nextId++;
    }

    Order[] orders = new Order[0];

    public void PlaceOrder(string bookTitle)
    {
        bool check = false;

        foreach (var item in orders)
        {
            if (item.BookTitle == bookTitle)
            {
                check = true;
                break;
            }
        }

        Order newOrder = new Order();

        newOrder.BookTitle = bookTitle;
        newOrder.OrderDate = DateTime.Now;
        newOrder.OrderStatus = true;

        if (!check)
        {
            Array.Resize(ref orders, orders.Length + 1);
            orders[orders.Length - 1] = newOrder;

            Console.WriteLine("Sifariş yaradıldı");
            Console.WriteLine($"Order ID: {newOrder.OrderId}\nBook Title: {newOrder.BookTitle}\nOrder Date: {newOrder.OrderDate}\nOrder Status: {newOrder.OrderStatus}");
        }
        else
        {
            Console.WriteLine("Bu kitab artıq mövcuddur.");
        }
    }


    public void TrackOrder(string title)
    {
        bool check = false;

        foreach (var item in orders)
        {
            if (item.BookTitle == title)
            {
                check = true;
                Console.WriteLine($"Order ID: {item.OrderId}\nBook Title: {item.BookTitle}\nOrder Date: {item.OrderDate}\nOrder Status: {item.OrderStatus}");
                Console.WriteLine("=============================");

                break;
            }
        }

        if (!check)
        {
            Console.WriteLine("=============================");
            Console.WriteLine("Bu ada sahib sifariş yoxdur.");
            Console.WriteLine("=============================");
        }
    }

    public void CancelOrder(int id)
    {

        if (orders.Length == 0)
        {
            Console.WriteLine("Silinecek sifaris yoxdur");
            return;
        }

        Order[] removeItemArray = new Order[orders.Length - 1];

        bool orderFound = false;
        int index = 0;

        foreach (var item in orders)
        {
            if (item.OrderId != id)
            {
                removeItemArray[index] = item;
                index++;

            }
            else
            {
                orderFound = true;
            }
        }

        if (orderFound)
        {
            orders = removeItemArray;
            Console.WriteLine("Sifariş silindi");
        }
        else
        {
            Console.WriteLine("Belə bir sifariş tapılmadı.");
        }
    }

}
