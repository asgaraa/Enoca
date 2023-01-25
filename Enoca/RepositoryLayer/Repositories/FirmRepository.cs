using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories
{
    public class FirmRepository : Repository<Firm>, IFirmRepository
    {
        public FirmRepository(AppDbContext context) : base(context)
        {
        }

     
    }
}
