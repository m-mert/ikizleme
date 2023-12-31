﻿using HR.Application.Features.EnumViewModels;
using HR.Application.Features.Permission.ViewModels;
using MediatR;

namespace HR.Application.Features.Permission.Command.CreatePermissionRequest;

public class CreatePermissionRequestCommand : IRequest<CreatePermissionRequestCommand>
{
    public Guid PersonnelId { get; set; }
    public DateTime StartDate { get; set; }
    public float Days { get; set; } = 0; 
    public Guid PermissionTypeId { get; set; }
}
