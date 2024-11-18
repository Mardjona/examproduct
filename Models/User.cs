using System;
using System.Collections.Generic;

namespace productex1.Models;

public partial class User
{
    public int UserId { get; set; }

    public string? Usersurname { get; set; }

    public string? Username { get; set; }

    public string? Userpatronymic { get; set; }

    public string? Userlogin { get; set; }

    public string? Userpassword { get; set; }

    public int? RoleId { get; set; }

    public virtual Role? Role { get; set; }
}
