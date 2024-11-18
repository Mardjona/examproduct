using System;
using System.Collections.Generic;

namespace productex1.Models;

public partial class Product
{
    public int Productid { get; set; }

    public string? Productarticle { get; set; }

    public string? Productdescription { get; set; }

    public string? Productcategory { get; set; }

    public string? Productmanufacturer { get; set; }

    public decimal? Productcost { get; set; }

    public int? Productdiscountamount { get; set; }

    public int? Productquantityinstock { get; set; }

    public string? Productstatus { get; set; }

    public string? Img { get; set; }

    public int? SuplaiersId { get; set; }

    public string? Productname { get; set; }

    public decimal? Currentdiscouint { get; set; }

    public virtual Suplaier? Suplaiers { get; set; }

    public string GetCost => Productcost + " руб.";
    public string GetDiscount => Currentdiscouint + "%";
}
