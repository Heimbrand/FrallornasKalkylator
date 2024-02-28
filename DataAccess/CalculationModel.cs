using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;

namespace DataAccess;

public class CalculationModel
{
    [Required]
    public DateTime CalculationTime { get; set; }
    [Required]
    public decimal NumberOne { get; set; }
    [Required]
    public decimal NumberTwo { get; set; }
    [Required]
    [StringLength(1)]
    [RegularExpression(@"[+-/*]")]
    [Display(Name = "Operator")]
    public string Operator { get; set; }
    public decimal Result { get; set; }
}