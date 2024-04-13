using OOP_Uygulama1.Models;

namespace OOP_Uygulama1.Repository;

public class BrandRepository
{
    private static List<Brand> _brands;

    public BrandRepository()
    {
        
    }

    public List<Brand> GetAllBrands()
    {
        return _brands;
    }

    public void Add(Brand brand)
    {
        _brands.Add(brand);
    }

    public Brand GetById(int id)
    {
        return _brands.Find(brand => brand.Id == id);
    }

    public void Delete(int id)
    {
        _brands.RemoveAll(brand => brand.Id == id);
    }
}