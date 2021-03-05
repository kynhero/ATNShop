using ATNShop.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATNShop.DataAccess.Repository.IRepository
{
    public interface ICoverTypeRepository : IRepository<CoverType>
    {
        void Update(CoverType coverType);
    }
}
