using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreOrderSystem;

public interface IOrderMethodsInterface
{
    void PlaceOrder(string bookTitle);
    void TrackOrder(string title);
    void CancelOrder(int id);
}
