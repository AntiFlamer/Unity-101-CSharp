namespace OOP_Uygulama1.Models.Dtos;

public class ModelResponseDto:BaseModel
{
    public string Name { get; set; }
    public int Year { get; set; }

    public override string ToString()
    {
        return $"Model [ Id: {Id}, Olusturma Tarihi: {CreatedTime}, Model Adi: {Name}, Model Yili: {Year} ]";
    }
}