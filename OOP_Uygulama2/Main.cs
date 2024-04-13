/* Kutuphane otomasyonu sisteminde;
 * Kitap, Yazar ve Kategori tablolariyla iliski kuran ve gerekli crud(Olusturma,Okuma,Guncelleme,Silme) operasyonlarini yapiniz
 */
//Kitap -> Id, Title, AuthorId, CategoryId, Price, Stock, Color
//Author -> Id, Name, Surname
//Category -> Id, Name

using OOP_Uygulama2.Models;
using OOP_Uygulama2.Repository;
using System.Threading.Channels;

IBookRepository bookRepository=new BookRepository();
IAuthorRepository authorRepository=new AuthorRepository();
ICategoryRepository categoryRepository=new CategoryRepository();

List<Book> books = bookRepository.GetAll();
List<Author> authorList = authorRepository.GetAll();
List<Category> categoryList = categoryRepository.GetAll();

//Kitaplari listeleyen kodu ekran ciktisi olarak veriniz
Console.WriteLine("Kitaplari listeleyiniz.");
foreach (Book book in books)
{
    Console.WriteLine(book);
}

//Kitaplarin Kategori Kimligi 2 olan kitaplari listeleyiniz.
Console.WriteLine("\nKategori kimligi 2 olan kitaplarin listesi:");

//1. Yontem
//foreach(Book book in books)
//{
//    if (book.CategoryId == 2)
//    {
//        Console.WriteLine(book);
//    }
//}

//2. Yontem
List<Book> filteredBooks = books
    .Where(x => x.CategoryId == 2)
    .ToList();
filteredBooks.ForEach(x =>Console.WriteLine(x));

//Yazar Kimligi 2 olan butun kitaplari listeleyen kodu yaziniz.
Console.WriteLine("\nYazar kimligi 2 olan kitaplar");
foreach(Book book in books)
{
    if(book.AuthorId == 2)
        Console.WriteLine(book);
}

//Kitaplar listesinde kitap isimleri icerisinde "Suc" kelimesi gecen kitaplari listeleyiniz.
Console.WriteLine("\nIcerisinde 'Suc' bulunan kitaplar");
foreach (Book book in books)
{
    if (book.Title.Contains("Suc"))
    {
        Console.WriteLine(book);
    }
}

//Kitaplarin fiyatlarinin toplamini ekrana bastiran kodu yaziniz
double top = 0;
foreach(Book book in books)
{
    top += book.Price;
}
double average = top/books.Count;
Console.WriteLine($"Kitaplarin fiyatlarinin toplami: {top}");
Console.WriteLine($"\nKitaplarin fiyatlarinin ortalamasi {average}");

//Yazar Kimligi 2 olan kitaplarin fiyat toplami ve ortalamasini yazdiran kodu yaziniz.
double total = books.Where(x => x.AuthorId == 2).Sum(b=>b.Price);
double average1 = books.Where(x => x.AuthorId == 2).Average(b=>b.Price);
Console.WriteLine($"\nYazar kimligi 2 olan kitaplarin fiyatlarinin toplami: {total}");
Console.WriteLine($"\nYazar kimligi 2 olan kitaplarin fiyatlarinin ortalamasi {average1}");

//Kitaplar listesini azalan fiyata gore siralama
Console.WriteLine("Fiyat durumuna gore azalan siralama:");
books.OrderByDescending(x => x.Price)
    .ToList()
    .ForEach(x=>Console.WriteLine(x));

