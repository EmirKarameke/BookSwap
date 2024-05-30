﻿using BookSwap.Common.Entities;

namespace BookSwap.Domain.Users;

public class User : IEntity<Guid>, ICreatedAudited<Guid>
{
    public string UserName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string NationalId { get; set; }
    public string Adress { get; set; }
    public int RightToSwap { get; set; }
    public DateTime CreateTime { get; set; }
    public Guid CreatorUser { get; set ; }
    public Guid Id { get; set ; }
}
