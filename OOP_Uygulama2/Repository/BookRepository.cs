using OOP_Uygulama2.Models;

namespace OOP_Uygulama2.Repository;

public class BookRepository : IBookRepository
{
    private List<Book> books;
    private Book book;

    public BookRepository()
    {
        books = new List<Book>()
        {
            new Book(1,"Kasagi",1,1,120,300,"Siyah"),
            new Book(2, "Kumarbaz", 2, 2, 80, 1000, "Kirmizi"),
            new Book(3, "Suc ve Ceza-1", 2, 2, 150, 500, "Yesil"),
            new Book(4, "Suc ve Ceza-2", 2, 2, 180, 650, "Siyah"),
            new Book(5, "Suc ve Ceza-3", 2, 2, 200, 600, "Sari"),
            new Book(6, "Yer Altindan Notlar", 2, 2, 65, 1200, "Beyaz"),
            new Book(7, "Harry Potter", 3, 3, 250, 1500, "Gri"),

        };
    }


    public void Add()
    {
        books.Add(book);
    }

    public void DeleteById(int id)
    {
        Book? book = books.SingleOrDefault(x=>x.Id==id);  //Null gelebilir bu yuzden yanina ? koyuldu.
        books.Remove(book);
    }

    public List<Book> GetAll()
    {
        return books.ToList();
    }

    public Book GetById(int id)
    {
        Book? book = books.SingleOrDefault(x=>x.Id==id);
        return book;
    }
}
