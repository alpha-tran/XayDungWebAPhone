using System;
using System.Collections.Generic;

namespace XayDungWebAphone.Models;

public partial class Menu
{
    public int IdMenu { get; set; }

    public string TitleMenu { get; set; } = null!;

    public int NumberMenu { get; set; }

    public string? LinkMenu { get; set; }

    public string? Description { get; set; }

    public int? IdCate { get; set; }

    public virtual Category? IdCateNavigation { get; set; }
}
