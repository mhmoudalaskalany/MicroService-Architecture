using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BackendCore.Common.Core;

namespace Employee.Service.Services.Base
{
    public interface IBaseService<T, TDto>
    {
        Task<IFinalResult> GetAllAsync();
        Task<IFinalResult> AddAsync(TDto model);
        Task<IFinalResult> AddListAsync(List<TDto> model);
        Task<IFinalResult> UpdateAsync(TDto model);
        Task<IFinalResult> DeleteAsync(Guid id);
        Task<IFinalResult> GetByIdAsync(Guid id);
    }
}