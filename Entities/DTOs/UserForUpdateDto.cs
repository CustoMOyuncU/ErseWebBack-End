using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class UserForUpdateDto : UserForRegisterDto
    {
        public int UserId { get; set; }
        public string OldEmail { get; set; }
    }
}
