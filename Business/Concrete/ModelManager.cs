using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EfMemoryDal;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemoryDal;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ModelManager : IModelService
    {
        IModelDal _modelDal; 

        public ModelManager(IModelDal modelDal)
        {
            _modelDal = modelDal;
        }

         

        public void Add(Model model)
        {
            _modelDal.Add(model);
        }

        void IModelService.Delete(Model model)
        {
            throw new NotImplementedException();
        }

        List<Model> IModelService.GetAll()
        {
            return _modelDal.GetAll();
        }
    }
}
