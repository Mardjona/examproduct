using System;
using System.Collections.Generic;

namespace productex1.Models;

public partial class Suplaier
{
    public int SumpaiersId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
