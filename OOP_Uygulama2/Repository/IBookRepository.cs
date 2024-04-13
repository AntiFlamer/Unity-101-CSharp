using OOP_Uygulama2.Models;
namespace OOP_Uygulama2.Repository;

public interface IBookRepository
{
    void Add();
    List<Book> GetAll();
    Book GetById(int id);
    void DeleteById(int id);
}
