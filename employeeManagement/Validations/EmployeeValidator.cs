using CommonLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Validations
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {

            RuleLevelCascadeMode = CascadeMode.Stop;

            RuleFor(employee => employee.FullName)
                .NotEmpty().WithMessage("El nombre es requerido")
                .MinimumLength(4).WithMessage("El nombre debe tener al menos 4 caracteres")
                .MaximumLength(80).WithMessage("El nombre no puede tener más de 80 caracteres");

            RuleFor(employee => employee.Phone)
                .NotEmpty().WithMessage("El teléfono es requerido")
                .Must(phone => int.TryParse(phone, out _)).WithMessage("El teléfono debe ser un número válido")
                .Length(8).WithMessage("El teléfono debe tener 8 caracteres");

            RuleFor(employee => employee.DateOfBirth)
                .NotEmpty().WithMessage("La fecha de nacimiento es requerida")
                .LessThan(DateTime.Now).WithMessage("La fecha de nacimiento no puede ser mayor a la fecha actual");

            RuleFor(employee => employee.HireDate)
                .NotEmpty().WithMessage("La fecha de contratación es requerida")
                .LessThan(DateTime.Now).WithMessage("La fecha de contratación no puede ser mayor a la fecha actual");

        }
    }
}
