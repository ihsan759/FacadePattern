namespace Facade;

public class Program
{
    public static void Main(string[] args)
    {
        LibrarySystemFacade libraryFacade = new LibrarySystemFacade();
        libraryFacade.SearchAndOrderBook("programming", "12345", 1);
    }
}

public class Catalog
{
    public void Search(string keyword)
    {
        Console.WriteLine($"Mencari buku dengan kata kunci: {keyword}");
    }
}

public class Inventory
{
    public void CheckAvailability(string bookId)
    {
        Console.WriteLine($"Memeriksa ketersediaan buku dengan ID: {bookId}");
    }
}

public class Order
{
    public void PlaceOrder(string bookId, int quantity)
    {
        Console.WriteLine($"Memesan buku dengan ID: {bookId}, jumlah: {quantity}");
    }
}

// Fasad
public class LibrarySystemFacade
{
    private Catalog catalog;
    private Inventory inventory;
    private Order order;

    public LibrarySystemFacade()
    {
        catalog = new Catalog();
        inventory = new Inventory();
        order = new Order();
    }

    public void SearchAndOrderBook(string keyword, string bookId, int quantity)
    {
        catalog.Search(keyword);
        inventory.CheckAvailability(bookId);
        order.PlaceOrder(bookId, quantity);
    }
}