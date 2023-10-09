﻿namespace VebTech.UserManagement.WebApi.Models;

using System.ComponentModel.DataAnnotations;

public class LoginRequest
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }
}