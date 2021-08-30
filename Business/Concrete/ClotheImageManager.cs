using Business.Abstract;
using Business.Constants;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ClotheImageManager : IClotheImageService
    {
        IClotheImageDal _clotheImageDal;

        public ClotheImageManager(IClotheImageDal clotheImageDal)
        {
            _clotheImageDal = clotheImageDal;
        }

        public IResult Add(IFormFile file, ClotheImage clotheImage)
        {
            clotheImage.ImagePath = FileHelper.Add(file);
            clotheImage.Date = DateTime.Now;
            _clotheImageDal.Add(clotheImage);
            return new SuccessResult(Messages.ClotheImageAdded);
        }

        public IResult Delete(ClotheImage clotheImage)
        {
            _clotheImageDal.Delete(clotheImage);
            return new SuccessResult(Messages.ClotheImageDeleted);
        }

        public IDataResult<List<ClotheImage>> GetAll()
        {
            return new SuccessDataResult<List<ClotheImage>>(_clotheImageDal.GetAll());
        }

        public IDataResult<List<ClotheImage>> GetByClotheId(int id)
        {
            return new SuccessDataResult<List<ClotheImage>>(_clotheImageDal.GetAll(c => c.ClotheId == id));
        }

        public IDataResult<ClotheImage> GetById(int id)
        {
            return new SuccessDataResult<ClotheImage>(_clotheImageDal.Get(c => c.ClotheId == id));
        }

        public IResult Update(ClotheImage clotheImage)
        {
            _clotheImageDal.Update(clotheImage);
            return new SuccessResult(Messages.ClotheImageUpdated);
        }
    }
}
