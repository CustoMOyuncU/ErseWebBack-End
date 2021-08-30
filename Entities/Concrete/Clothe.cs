using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Clothe: IEntity
    {
        public int ClotheId { get; set; }
        public int ColorId { get; set; }
        public int CategoryId { get; set; }
    }
}
