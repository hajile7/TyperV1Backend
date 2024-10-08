﻿namespace TyperV1API.Models
{
    public class putUserDTO
    {
        public string? FirstName { get; set; } = null!;

        public string? LastName { get; set; } = null!;
        public string? Email { get; set; } = null!;

        public string? UserName { get; set; } = null!;

        public virtual IFormFile? Image { get; set; }
    }
}
