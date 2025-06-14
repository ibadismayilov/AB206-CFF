using StoreTask.Models;
using static StoreTask.Models.Product;

namespace StoreTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result;

            Product product = new Product();
            Store store = new Store();

            do
            {
                Console.WriteLine("1. Məhsul əlavə etmək");
                Console.WriteLine("2. Məhsul axtarmq");
                Console.WriteLine("3. Type uyğun axtarış");
                Console.WriteLine("4. Məhsul silmək");



                bool check = int.TryParse(Console.ReadLine(),out result);

                if (check)
                {
                    switch (result) {

                        case 0:
                            Console.WriteLine("Proqramdan çıxılır...");
                            break;

                        case 1:

                            Console.Write("Məhsulun adını daxil edin: ");
                            product.Name = Console.ReadLine();

                            Console.Write("Məhsulun price daxil edin: ");
                            product.Price = Convert.ToInt32(Console.ReadLine());


                            store.AddProduct(product);
                            break;

                        case 2:
                            Console.Write("Axtarmaq istədiyiniz məhsulun ID-i daxil edin: ");
                            int searchItemID = Convert.ToInt32(Console.ReadLine());

                            store.GetProduct(searchItemID);
                            break;


                        case 3:
                            Console.Write("Axtarmaq istədiyiniz məhsulun tipini daxil edin: Baker, Drink, Meat, Diary: ");
                            string filterItemWidthType = Console.ReadLine();

                            Enum.TryParse(filterItemWidthType, out ProductType type);


                            store.FilterProductsByType(type);
                            break;


                        case 4:
                            Console.Write("Axtarmaq istədiyiniz məhsulun ID-i daxil edin: ");
                            int removeItemID = Convert.ToInt32(Console.ReadLine());

                            store.RemoveProductByNo(removeItemID);
                            break;
                    }
                }
            }
            while (result != 0);
        }
    }
}
