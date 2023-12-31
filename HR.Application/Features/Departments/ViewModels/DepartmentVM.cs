﻿using HR.Application.Features.People.ViewModels;
using HR.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.Departments.ViewModels;

public class DepartmentVM
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public IEnumerable<PersonVM>? People { get; set; }
}
