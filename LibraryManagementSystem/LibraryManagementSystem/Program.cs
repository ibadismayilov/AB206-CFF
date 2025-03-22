namespace LibraryManagementSystem;

internal class Program
{
    static void Main(string[] args)
    {
        InputFieldValue book = new InputFieldValue();
        book.GetInputValue();
        book.ShowInfo();
    }
}
