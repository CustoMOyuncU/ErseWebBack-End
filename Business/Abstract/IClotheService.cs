using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IClotheService
    {
        IDataResult<List<Clothe>> GetAll();
        IDataResult<Clothe> GetById(int id);
        IResult Add(Clothe color);
        IResult Update(Clothe color);
        IResult Delete(Clothe color);
    }
}
