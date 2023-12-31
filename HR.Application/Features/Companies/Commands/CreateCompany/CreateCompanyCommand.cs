﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.Companies.Commands.CreateCompany;

public class CreateCompanyCommand :IRequest<CreateCompanyCommand>
{
    public string Name { get; set; }
    public string Type { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public DateTime ContractStartDate { get; set; }
    public DateTime ContractEndDate { get; set; }
    public string MersisNo { get; set; }
    public string TaxNo { get; set; }
    public string TaxOffice { get; set; }
    public string LogoUrl { get; set; }
    public string Address { get; set; }
    public int EmployeesCount { get; set; }
    public int EstablishmentYear { get; set; }

}
