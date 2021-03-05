using ATNShop.DataAccess.Data;
using ATNShop.DataAccess.Repository.IRepository;
using ATNShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATNShop.DataAccess.Repository
{
    public class OrderDetailsRepository : Repository<OrderDetails>, IOrderDetailsRepository
    {
        private readonly ApplicationDbContext _db;

        public OrderDetailsRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(OrderDetails obj)
        {
            _db.Update(obj);
        }
    }
}
