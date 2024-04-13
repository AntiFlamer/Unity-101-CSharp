using System.Collections.Generic;
using OOP_Uygulama1.Models;
using OOP_Uygulama1.Models.Dtos;
using OOP_Uygulama1.Repository;
using OOP_Uygulama1.Services.Converter;

namespace OOP_Uygulama1.Services
{
    public class ModelService
    {
        private ModelRepository _modelRepository;
        

        public ModelService()
        {
            _modelRepository = new ModelRepository();
            
        }

        public void Add(Model model)
        {
            _modelRepository.Add(model);
        }

        public Model GetById(int id)
        {
            return _modelRepository.GetById(id);
        }

        public void Delete(int id)
        {
            _modelRepository.Delete(id);
        }
    }
}