//Bir rent a car projesi yapilmasi istendi.
//Araba, Model, Marka tablolari olacak.
//bu tablolar icin veri tabani oldugu varsayilarak (listeleri kullanarak) listeleme, ekleme, idye gore getirme ve silme operasyonlarini simule ediniz.

//Araba -> Id, MadeDate, Model, Brand, ColorName, DailyPrice
//Model -> Id, MadeDate, Name, Year
//Brand -> Id, MadeDate, Name


using OOP_Uygulama1.Models;
using OOP_Uygulama1.Services;

Model model1 = new Model()
{
    Id = 1,
    CreatedTime = DateTime.Now,
    Name = "m5",
    Year = 2022
};

Brand brand1 = new Brand()
{
    Id = 1,
    CreatedTime = DateTime.Now,
    Name = "BMW"
};

Car car1 = new Car()
{
    Id = 1,
    CreatedTime = DateTime.Now,
    Brand = brand1,
    Model = model1,
    ColorName = "Siyah",
    DailyPrice = 2000
};


CarService carService = new CarService();

carService.Add(car1);

//carService.GetAll();

carService.GetById(1);