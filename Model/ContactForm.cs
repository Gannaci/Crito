﻿using System.ComponentModel.DataAnnotations;

namespace Crito.Model;

public class ContactForm
{
    [Required]
    public string Name { get; set; } = null!;

    [Required]
    public string Email { get; set; } = null!;

    [Required]
    public string Message { get; set; } = null!;

}
