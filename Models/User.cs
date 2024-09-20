using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UserApplication.Models;

public partial class User
{
    public int Id { get; set; }

    [Required(ErrorMessage = "El nombre es obligatorio")]
    [StringLength(50, ErrorMessage = "El nombre no puede tener más de 50 caracteres")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "El apellido es obligatorio")]
    [StringLength(50, ErrorMessage = "El apellido no puede tener más de 50 caracteres")]
    public string? LastName { get; set; }

    [Required(ErrorMessage = "El DNI es obligatorio")]
    [RegularExpression(@"^\d{8}$", ErrorMessage = "El DNI debe ser un número de 8 dígitos")]
    public string? Dni { get; set; }
}
