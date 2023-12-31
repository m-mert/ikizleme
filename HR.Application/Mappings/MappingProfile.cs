﻿using AutoMapper;
using HR.Application.Features.AdvancePayments.Commands.CreateAdvancePayment;
using HR.Application.Features.AdvancePayments.Commands.DeleteByIdAdvancePayment;
using HR.Application.Features.AdvancePayments.ViewModels;
using HR.Application.Features.Departments.ViewModels;
using HR.Application.Features.Expenditures.Commands.CreateExpenditure;
using HR.Application.Features.EnumViewModels;
using HR.Application.Features.Expenditures.ViewModels;
using HR.Application.Features.Jobs.ViewModels;
using HR.Application.Features.People.Commands.PersonUpdate;
using HR.Application.Features.People.ViewModels;
using HR.Domain.Concrete;
using HR.Domain.Enum;
using HR.Application.Features.Permission.ViewModels;
using HR.Application.Features.Permission.Command.CreatePermissionRequest;
using HR.Application.Features.Permission.Command.DeleteByIdPermissionRequest;
using HR.Application.Features.People.Commands.PersonCreate;
using HR.Application.Features.Expenditures.Commands.DeleteByIdExpenditure;
using HR.Application.Features.People.Commands.PersonUpdateByManager;
using HR.Application.Features.Permission.Command.ApprovePermissionRequest;
using HR.Application.Features.Permission.Command.RejectPermissionRequest;
using HR.Application.Features.Expenditures.Commands.ApproveExpenditureRequest;
using HR.Application.Features.Expenditures.Commands.RejectExpenditureRequest;
using HR.Application.Features.AdvancePayments.Commands.ApproveAdvancePayment;
using HR.Application.Features.AdvancePayments.Commands.RejectAdvancePayment;
using HR.Application.Features.Companies.ViewModels;
using HR.Application.Features.Companies.Commands.CreateCompany;
using HR.Application.Features.Companies.Commands.UpdateCompany;

namespace HR.Application.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Personnel, PersonDetailVM>().ReverseMap();
        CreateMap<Personnel, PersonUpdateCommand>().ReverseMap();
        CreateMap<PersonDetailVM, PersonUpdateCommand>().ReverseMap();
        CreateMap<Personnel, PersonVM>().ReverseMap();
        
        CreateMap<Department, DepartmentVM>().ReverseMap();
        CreateMap<Job, JobVM>().ReverseMap();

        CreateMap<AdvancePayment, CreateAdvancePaymentCommand>().ReverseMap();
        CreateMap<AdvancePayment, DeleteByIdAdvancePaymentCommand>().ReverseMap();
        CreateMap<AdvancePaymentCreateVM, CreateAdvancePaymentCommand>().ReverseMap();
        CreateMap<AdvancePayment, AdvancePaymentListVM>().ReverseMap();
        CreateMap<AdvancePayment, ApproveAdvancePaymentCommand>().ReverseMap();
        CreateMap<AdvancePayment, RejectAdvancePaymentCommand>().ReverseMap();
        CreateMap<AdvancePayment, AdvancePaymentApproveListVM>().ReverseMap();


        CreateMap<ExpenditureCreateVM, CreateExpenditureCommand>().ReverseMap();
        CreateMap<Expenditure, CreateExpenditureCommand>().ReverseMap();
        CreateMap<Expenditure, ExpenditureCreateVM>().ReverseMap();
        CreateMap<Expenditure, ExpenditureListVM>().ReverseMap();
        CreateMap<Expenditure, DeleteByIdExpenditureCommand>().ReverseMap();
        CreateMap<Expenditure, ApproveExpenditureRequestCommand>().ReverseMap();
        CreateMap<Expenditure, RejectExpenditureRequestCommand>().ReverseMap();
        CreateMap<Expenditure, ExpenditureApproveListVM>().ReverseMap();


        CreateMap<PermissionRequest, PermissionRequestListVM>().ReverseMap();
        CreateMap<PermissionRequestCreateVM, CreatePermissionRequestCommand>().ReverseMap();
        CreateMap<PermissionRequest, CreatePermissionRequestCommand>().ReverseMap();
        CreateMap<Permissions, PermissionTypeVM>().ReverseMap();
        CreateMap<PermissionRequest, DeleteByIdPermissionRequestCommand>().ReverseMap();
        CreateMap<PermissionRequest, ApprovePermissionRequestCommand>().ReverseMap();
        CreateMap<PermissionRequest, RejectPermissionRequestCommand>().ReverseMap();
        CreateMap<PermissionRequest, PermissionRequestApproveListVM>().ReverseMap();


        CreateMap<PersonCreateVM, PersonCreateCommand>().ReverseMap();
        CreateMap<Personnel, PersonCreateCommand>().ReverseMap();
        CreateMap<PersonDetailVM, PersonUpdateByManagerVM>().ReverseMap();
        CreateMap<PersonUpdateByManagerCommand, PersonUpdateByManagerVM>().ReverseMap();
        CreateMap<PersonUpdateByManagerCommand, Personnel>().ReverseMap();
        CreateMap<Personnel, ManagerInCompaniesVM>().ReverseMap();


        CreateMap<Company, CompanyVM>().ReverseMap();
        CreateMap<Company, CompanyListVM>().ReverseMap();
        CreateMap<Company, CompanyCreateVM>().ReverseMap();
        CreateMap<CreateCompanyCommand, CompanyCreateVM>().ReverseMap();
        CreateMap<CreateCompanyCommand, Company>().ReverseMap();
        CreateMap<CompanyVM, CompanyUpdateVM>().ReverseMap();

        CreateMap<Company, UpdateCompanyCommand>().ReverseMap();
        CreateMap<CompanyUpdateVM, UpdateCompanyCommand>().ReverseMap();




        //ViewModel Mappings
        CreateMap<ApprovalStatus, ApprovalStatusVM>().ReverseMap();
        CreateMap<CurrencyType, CurrencyTypeVM>().ReverseMap();
        CreateMap<AdvanceType, AdvanceTypeVM>().ReverseMap();



    }
}
