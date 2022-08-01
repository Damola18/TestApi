using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cores.Models.ValidationAttributes
{
    public class Ticket_EnsureDueDateAfterReportDateAttribute: ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var ticket = validationContext.ObjectInstance as Ticket;

            if (!ticket.ValidateDueDateAfterReportDate())
                return new ValidationResult("Due date has to be later than Report Date");
            return ValidationResult.Success;
        }
    }
}
