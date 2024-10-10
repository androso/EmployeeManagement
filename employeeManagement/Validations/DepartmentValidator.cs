using CommonLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Validations
{
    public class DepartmentValidator : AbstractValidator<Department>
    {
        public DepartmentValidator()
        {
            RuleLevelCascadeMode = CascadeMode.Stop;

            RuleFor(department => department.DepartmentName)
                .NotEmpty().WithMessage("El nombre es requerido")
                .MinimumLength(2).WithMessage("El nombre debe tener al menos 2 caracteres")
                .MaximumLength(50).WithMessage("El nombre no puede tener más de 50 caracteres");
            
            RuleFor(department => department.Description)
                .NotEmpty().WithMessage("La descripción es requerida")
                .MinimumLength(5).WithMessage("La descripción debe tener al menos 5 caracteres")
                .MaximumLength(150).WithMessage("La descripción no puede tener más de 100 caracteres");
        }
    }
}
