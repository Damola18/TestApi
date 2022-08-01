using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cores.Models.ValidationAttributes
{
    public class Ticket_EnsureReportDatePresenceAttribute: ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var ticket = validationContext.ObjectInstance as Ticket;

            if (!ticket.ValidateReportDatePresence())
                return new ValidationResult("Report date is required");
            return ValidationResult.Success;
        }
    }
}
