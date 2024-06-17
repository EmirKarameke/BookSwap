using BookSwap.Application.Contract.Employees;
using BookSwap.Application.Contract.Employees.Dtos;
using BookSwap.Application.Contract.ServiceTypes;
using BookSwap.Domain.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSwap.Application.Employees
{
    public class EmployeeAppService : IEmployeeAppService
    {
        IEmployeeRepository employeeRepository;

        public EmployeeAppService(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public Task<ServiceResponse<EmployeeDto>> Create(EmployeeDto employee)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<string>> Login(EmployeeLoginRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<string>> Logout()
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<EmployeeDto>> Update(EmployeeDto employee)
        {
            throw new NotImplementedException();
        }
    }
}
