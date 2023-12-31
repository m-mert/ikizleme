﻿using HR.Application.Features.Permission.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.Permission.Queries.GetPermissionRequestListByPersonId;

public class GetPermissionRequestListByPersonIdQuery :IRequest<IEnumerable<PermissionRequestListVM>>
{
    public Guid PersonnelId { get; set; }
}
