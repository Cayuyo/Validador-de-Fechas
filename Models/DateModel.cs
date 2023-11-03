using System;
using System.ComponentModel.DataAnnotations;
namespace Validador_de_Fechas.Models;
public class DateModel
{
    [FutureDate(ErrorMessage = "The date cannot be future.")]
    [Display(Name = "Date")]
    public DateTime Date { get; set; }
}