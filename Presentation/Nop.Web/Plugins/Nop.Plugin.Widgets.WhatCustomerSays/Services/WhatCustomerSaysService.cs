using Nop.Core;
using Nop.Data;
using Nop.Plugin.Widgets.WhatCustomerSays.Domain.Entities;
using System.Threading.Tasks;
using System.Linq;

namespace Nop.Plugin.Widgets.WhatCustomerSays.Services;

public class WhatCustomerSaysService : IWhatCustomerSaysService
{
    private readonly IRepository<WhatCustomerSay> _repository;

    public WhatCustomerSaysService(IRepository<WhatCustomerSay> repository)
    {
        _repository = repository;
    }

    public async Task InsertAsync(WhatCustomerSay entity)
        => await _repository.InsertAsync(entity);

    public async Task UpdateAsync(WhatCustomerSay entity)
        => await _repository.UpdateAsync(entity);

    public async Task DeleteAsync(WhatCustomerSay entity)
        => await _repository.DeleteAsync(entity);

    public async Task<WhatCustomerSay> GetByIdAsync(int id)
        => await _repository.GetByIdAsync(id);

    public async Task<IPagedList<WhatCustomerSay>> GetAllAsync(int pageIndex, int pageSize)
    {
        var query = _repository.Table.OrderBy(x => x.DisplayOrder);
        return await query.ToPagedListAsync(pageIndex, pageSize);
    }
}
