using System;
using System.Collections.Generic;

namespace XayDungWebAphone.Models;

public partial class Category
{
    public int IdCate { get; set; }

    public string NameCate { get; set; } = null!;

    public string LinkCate { get; set; } = null!;

    public int? NumberCate { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Menu> Menus { get; set; } = new List<Menu>();

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
