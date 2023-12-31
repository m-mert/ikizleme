﻿using FluentValidation;

namespace HR.Application.Features.Permission.Command.CreatePermissionRequest;

public class CreatePermissionRequestValidator : AbstractValidator<CreatePermissionRequestCommand>
{
    public CreatePermissionRequestValidator() 
    {
        RuleFor(x => x.StartDate)
                                .NotEmpty()
                                .WithMessage("Başlangıç tarihi girilmek zorundadır.")
                                .GreaterThanOrEqualTo(DateTime.Now.AddDays(1).Date)
                                .WithMessage("Başlangıç tarihi en erken yarın olabilir.");
        RuleFor(x => x.Days)
            .NotEmpty()
            .GreaterThan(0);
    }
}
