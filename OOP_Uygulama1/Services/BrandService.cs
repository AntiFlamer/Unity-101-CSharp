using OOP_Uygulama1.Models;
using OOP_Uygulama1.Repository;

namespace OOP_Uygulama1.Services;

public class BrandService
{
    private BrandRepository _brandRepository;
    private object _brandGet;

    public BrandService()
    {
        _brandRepository = new BrandRepository();
    }

    public void Add(Brand brand)
    {
        _brandRepository.Add(brand);
    }


    public Brand GetById(int id)
    {
        return _brandRepository.GetById(id);
    }

    public void Delete(int id)
    {
        _brandRepository.Delete(id);
    }
}