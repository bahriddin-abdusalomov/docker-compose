﻿using System.ComponentModel.DataAnnotations;

namespace Education.API.Dtos.Students;

public class StudentUpdateDto
{
    public long Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public DateTime Birtday { get; set; }

    [RegularExpression("^[A-Za-z0-9](([_\\.\\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\\.\\-]?[a-zA-Z0-9]+)*)\\.([A-Za-z]{2,})$")]
    public string Email { get; set; }

    public string Password { get; set; }

    public string PhoneNumber { get; set; }

    public string Course { get; set; }

    public string Group { get; set; }
}
