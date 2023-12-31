﻿using HR.Application.Features.AdvancePayments.ViewModels;
using HR.Application.Features.EnumViewModels;
using MediatR;

namespace HR.Application.Features.AdvancePayments.Commands.CreateAdvancePayment;

public class CreateAdvancePaymentCommand : IRequest<CreateAdvancePaymentCommand>
{
    public Guid PersonnelId { get; set; }
    public AdvanceTypeVM AdvanceType { get; set; }
    public decimal Amount { get; set; }
    public CurrencyTypeVM CurrencyType { get; set; }
    public ApprovalStatusVM ApprovalStatus { get; set; } = ApprovalStatusVM.ApprovalWaiting;
    public string Description { get; set; } = null!;
}
