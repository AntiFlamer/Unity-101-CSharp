namespace OOP_Uygulama1.Models.Dtos;

public class CarResponseDto
{
    public string BrandName { get; set; }
    public string ModelName { get; set; }
    public int ModelYear { get; set; }
    public string ColorName { get; set; }
    public double DailyPrice { get; set; }

    public override string ToString()
    {
        return $"Marka Adi {BrandName}, Model adi {ModelName}, Model yili {ModelYear}, Rengi {ColorName}, Gunluk ucreti {DailyPrice}";
    }
}
