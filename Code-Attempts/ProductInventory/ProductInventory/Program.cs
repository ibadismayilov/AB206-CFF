namespace ProductInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Warehouse warehouse = new Warehouse();

            InputValue inputValue = new InputValue();
            inputValue.Value(warehouse);

            warehouse.ShowInfo();
        }
    }
}
