﻿using System.ComponentModel.DataAnnotations;

namespace _360AdsNG.Application.Dtos.AuthDtos;

public class ResetPasswordDto
{
    [Required][EmailAddress] public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string NewPassword { get; set; }

    [Required] public string Token { get; set; }
}