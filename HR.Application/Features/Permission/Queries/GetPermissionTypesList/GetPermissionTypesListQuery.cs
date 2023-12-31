﻿using HR.Application.Features.Permission.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.Permission.Queries.GetPermissionTypesList;

public class GetPermissionTypesListQuery: IRequest<IEnumerable<PermissionTypeVM>>
{
    public Guid PersonnelId { get; set; }

}
