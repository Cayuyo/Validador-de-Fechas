using System.ComponentModel.DataAnnotations;

namespace Validador_de_Fechas.Models;

public class ErrorViewModel
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}

public class FutureDateAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value is DateTime date)
        {
            if (date > DateTime.Now)
            {
                return new ValidationResult(ErrorMessage ?? "The date cannot be future.");
            }
        }
        return ValidationResult.Success;
    }
}