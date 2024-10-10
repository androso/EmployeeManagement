using CommonLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Validations
{
    public class PositionValidator : AbstractValidator<Position>
    {
        public PositionValidator() 
        {
            RuleLevelCascadeMode = CascadeMode.Stop;

            RuleFor(position => position.PositionName)
                .NotEmpty().WithMessage("El nombre de la posición es requerido")
                .MinimumLength(4).WithMessage("El nombre de la posición debe tener al menos 4 caracteres")
                .MaximumLength(80).WithMessage("El nombre de la posición no puede tener más de 80 caracteres");

            RuleFor(pos => pos.BaseSalary)
                .NotEmpty().WithMessage("El salario base es requerido")
                .GreaterThan(0).WithMessage("El salario base debe ser mayor a 0");

        }
    }
}
