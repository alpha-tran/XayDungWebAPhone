using System;
using System.Collections.Generic;

namespace XayDungWebAphone.Models;

public partial class Product
{
    public int IdProduct { get; set; }

    public string NameProduct { get; set; } = null!;

    public string? Description { get; set; }

    public double Price { get; set; }

    public int IdCategory { get; set; }

    public string? Img1 { get; set; }

    public string? Img2 { get; set; }

    public string? Img3 { get; set; }

    public int NumberPro { get; set; }

    public string? LinkPro { get; set; }

    public virtual Category IdCategoryNavigation { get; set; } = null!;

    public virtual ICollection<OrderDetal> OrderDetals { get; set; } = new List<OrderDetal>();
}
