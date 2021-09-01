using Business.Abstract;
using Business.BusinsessAspects.Autofac;
using Business.Constants;
using Core.Aspects.Autofac.Caching;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ClotheManager : IClotheService
    {
        IClotheDal _clotheDal;

        public ClotheManager(IClotheDal clotheDal)
        {
            _clotheDal = clotheDal;
        }

        [SecuredOperation("admin")]
        public IResult Add(Clothe clothe)
        {
            _clotheDal.Add(clothe);
            return new SuccessResult(Messages.ClotheAdded);
        }

        [SecuredOperation("admin")]
        public IResult Delete(Clothe clothe)
        {
            _clotheDal.Delete(clothe);
            return new SuccessResult(Messages.ClotheDeleted);
        }

        [CacheAspect]
        public IDataResult<List<Clothe>> GetAll()
        {
            return new SuccessDataResult<List<Clothe>>(_clotheDal.GetAll());
        }

        [CacheAspect]
        public IDataResult<List<Clothe>> GetByCategoryId(int id)
        {
            return new SuccessDataResult<List<Clothe>>(_clotheDal.GetAll(c=> c.CategoryId==id));
        }

        public IDataResult<Clothe> GetById(int id)
        {
            return new SuccessDataResult<Clothe>(_clotheDal.Get(c => c.ClotheId == id));
        }

        [SecuredOperation("admin")]
        public IResult Update(Clothe clothe)
        {
            _clotheDal.Update(clothe);
            return new SuccessResult(Messages.ClotheUpdated);
        }
    }
}
