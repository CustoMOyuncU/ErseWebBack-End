﻿using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.Jwt;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IResult UpdateUserExists(UserForUpdateDto userForUpdateDto);
        IDataResult<User> UpdateUser(UserForUpdateDto userForUpdateDto, string password);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
