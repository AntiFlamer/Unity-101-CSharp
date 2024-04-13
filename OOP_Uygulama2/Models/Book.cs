namespace OOP_Uygulama2.Models;

//record : sadece data tasiyan immutable (degistirlemez) siniflar
public record Book(int Id,
                   string Title,
                   int AuthorId,
                   int CategoryId,
                   double Price,
                   int Stock,
                   string Color);


