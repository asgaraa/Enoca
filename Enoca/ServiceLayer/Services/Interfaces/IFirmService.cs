using ServiceLayer.DTOs.Firma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IFirmService
    {
        Task CreateAsync(FirmaDto firmaDto);
        Task<List<FirmaDto>> GetAllAsync();
        Task UpdateAsync(string id, FirmaEditDto firmaEditDto);
        Task<FirmaDto> GetAsync(string id);
        Task DeleteAsync(string id);
    }
}
