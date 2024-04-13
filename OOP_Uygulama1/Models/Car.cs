namespace OOP_Uygulama1.Models;
public class Car : BaseModel
{
    public Model Model { get; set; }
    public Brand Brand { get; set; }
    public string ColorName { get; set; }
    public double DailyPrice { get; set; }

    public override string ToString()
    {
        return $"Araba [ Id: {Id}, Olusturma Tarihi: {CreatedTime} \n Markasi: {Brand} \n Model Adi: {Model} \n Rengi: {ColorName}, Gunluk Fiyati: {DailyPrice} ]";
    }
}
