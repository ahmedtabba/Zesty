using Nop.Core;
using System.Threading.Tasks;

using Nop.Plugin.Widgets.WhatCustomerSays.Domain.Entities;
namespace Nop.Plugin.Widgets.WhatCustomerSays.Services;

public interface IWhatCustomerSaysService
{
    Task InsertAsync(WhatCustomerSay entity);
    Task UpdateAsync(WhatCustomerSay entity);
    Task DeleteAsync(WhatCustomerSay entity);
    Task<WhatCustomerSay> GetByIdAsync(int id);
    Task<IPagedList<WhatCustomerSay>> GetAllAsync(int pageIndex, int pageSize);
}
