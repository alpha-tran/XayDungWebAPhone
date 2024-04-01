using System;
using System.Collections.Generic;

namespace XayDungWebAphone.Models;

public partial class Product
{
    public int IdProduct { get; set; }

    public string NameProduct { get; set; } = null!;

    public string Description { get; set; } = null!;

    public double Price { get; set; }

    public int IdCategory { get; set; }

    public virtual Category IdCategoryNavigation { get; set; } = null!;

    public virtual ICollection<OrderDetal> OrderDetals { get; set; } = new List<OrderDetal>();
}
