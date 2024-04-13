using OOP_Uygulama1.Models;
using OOP_Uygulama1.Models.Dtos;
using OOP_Uygulama1.Repository;
using OOP_Uygulama1.Services.Converter;

namespace OOP_Uygulama1.Services;
//Car : ColorName alani minimum 2 karakterli olmali.
//Car : DailyPrice kolonuna kdv tutari da eklenmeli ve kdvli fiyati veritabanina yansitilmali

//Urunler : kullanicidan_alinan_komisyon, saticidan_alinan, toplam_ucret
public class CarService
{
    private CarRepository _carRepository;
    private CarConverter _carConverter;

    public CarService()
    {
        _carRepository = new CarRepository();
        _carConverter = new CarConverter();
    }

    public void Add(Car car)
    {
        ColorNameValidator(car.ColorName);

        car.DailyPrice = (car.DailyPrice * 1.2);


        _carRepository.Add(car);

        
    }

    //List<Car> -> List<CarResponseDto>
    //Car -> 

    public void GetAll()
    {
        List<Car> cars = _carRepository.GetAllCars();
        List<CarResponseDto> carResponseDtos = _carConverter.ConvertToResponseList(cars);

        foreach(CarResponseDto dto in carResponseDtos)
        {
            Console.WriteLine(dto);
        }
    }

    public void Delete(int id)
    {
        _carRepository.Delete(id);
    }

    public void GetById(int id)
    {
        Car car=_carRepository.GetById(id);
        CarResponseDto responseDto = new CarResponseDto()
        {
            BrandName = car.Brand.Name,
            ColorName = car.ColorName,
            DailyPrice = car.DailyPrice,
            ModelName = car.Model.Name,
            ModelYear = car.Model.Year,
        };
        Console.WriteLine(responseDto);
    }

    private void ColorNameValidator(string ColorName)
    {
        if (ColorName.Length<2)
        {
            Console.WriteLine("Aracin rengi minimum 2 karakterli olmalidir.");
        }
        return;
    }
}
