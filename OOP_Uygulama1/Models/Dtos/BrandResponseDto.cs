namespace OOP_Uygulama1.Models.Dtos;

public class BrandResponseDto:BaseModel
{
    public string Name { get; set; }

    public override string ToString()
    {
        return $"Brand [ Id: {Id}, Olusturma Tarihi: {CreatedTime}, Model Adi: {Name} ]";
    }
}