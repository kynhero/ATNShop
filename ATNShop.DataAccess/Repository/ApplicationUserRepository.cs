using ATNShop.DataAccess.Data;
using ATNShop.DataAccess.Repository.IRepository;
using ATNShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATNShop.DataAccess.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private readonly ApplicationDbContext _db;

        public ApplicationUserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

    }
}
