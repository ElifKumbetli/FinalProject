using Entities.Abstact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{

    //Çıplak Class Kalmasın

    public class Category:IEntity
    {
        public int CategoryId { get; set; }

        public int CategoryName { get; set; }
    }
}
