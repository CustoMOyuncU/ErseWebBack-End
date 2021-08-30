using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IClotheImageService
    {
        IDataResult<List<ClotheImage>> GetAll();
        IResult Delete(ClotheImage clotheImage);
        IResult Update(ClotheImage clotheImage);
        IResult Add(IFormFile file, ClotheImage clotheImage);
        IDataResult<ClotheImage> GetById(int id);
        IDataResult<List<ClotheImage>> GetByClotheId(int id);
    }
}
