﻿using HR.Domain.Base;
using HR.Domain.Concrete.Identity;
using HR.Domain.Enum;

namespace HR.Domain.Concrete;

public class Personnel : BaseEntity
{
    public string IdentityNumber { get; set; }
    public string Name { get; set; }
    public string? SecondName { get; set; }
    public string Surname { get; set; }
    public string? SecondSurname { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public Gender Gender { get; set; }
    public decimal Salary { get; set; }
    public string Photo { get; set; }
    public DateTime BirthDate { get; set; }
    public string PlaceofBirth { get; set; }
    public DateTime HireDate { get; set; }
    public DateTime? FireDate { get; set; }
    public Guid JobId { get; set; }
    public Job? Job { get; set; }
    public Guid DepartmentId { get; set; }
    public Department? Department { get; set; }
    public string CompanyName { get; set; }
    public Guid CompanyId { get; set; }
    public Company Company { get; set; }
    public float? AnnualPermissionDays { get; set; }

    public  Guid UserId { get; set; }
    public  User User { get; set; }

    // Navigation Properties
    public ICollection<AdvancePayment>? AdvancePayments { get; set; }
    public ICollection<PermissionRequest>? PermissonRequests { get; set; }
}