﻿using HR.Application.Contracts.Persistence.Repositories;
using HR.Domain.Concrete;
using HR.Infrastructure.Persistence;
using HR.Persistence.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Persistence.Repositories;

public class ExpenditureRepository : BaseRepository<Expenditure>, IExpenditureRepository
{
    public ExpenditureRepository(HRContext context) : base(context) { }

    public async Task<IEnumerable<Expenditure>> GetAllByPersonIdAsync(Guid personId, CancellationToken token)
        => await base.GetAllAsync(g => g.PersonnelId == personId, token);

}