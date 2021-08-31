using Business.Abstract;
using Business.Constants;
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

        public IResult Add(Clothe clothe)
        {
            _clotheDal.Add(clothe);
            return new SuccessResult(Messages.ClotheAdded);
        }

        public IResult Delete(Clothe clothe)
        {
            _clotheDal.Delete(clothe);
            return new SuccessResult(Messages.ClotheDeleted);
        }

        public IDataResult<List<Clothe>> GetAll()
        {
            return new SuccessDataResult<List<Clothe>>(_clotheDal.GetAll());
        }

        public IDataResult<List<Clothe>> GetByCategoryId(int id)
        {
            return new SuccessDataResult<List<Clothe>>(_clotheDal.GetAll(c=> c.CategoryId==id));
        }

        public IDataResult<Clothe> GetById(int id)
        {
            return new SuccessDataResult<Clothe>(_clotheDal.Get(c => c.ClotheId == id));
        }

        public IResult Update(Clothe clothe)
        {
            _clotheDal.Update(clothe);
            return new SuccessResult(Messages.ClotheUpdated);
        }
    }
}
