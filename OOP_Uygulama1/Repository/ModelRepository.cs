using OOP_Uygulama1.Models;

namespace OOP_Uygulama1.Repository;

public class ModelRepository
{
    private static List<Model> _models;

    public ModelRepository()
    {
       
    }

    public List<Model> GetAllModels()
    {
        return _models;
    }

    public void Add(Model model)
    {
        _models.Add(model);
    }

    public Model GetById(int id)
    {
        return _models.Find(model => model.Id == id);
    }

    public void Delete(int id)
    {
        _models.RemoveAll(model => model.Id == id);
    }
}