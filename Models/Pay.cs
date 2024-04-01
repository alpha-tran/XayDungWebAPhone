using System;
using System.Collections.Generic;

namespace XayDungWebAphone.Models;

public partial class Pay
{
    public int IdPay { get; set; }

    public string Method { get; set; } = null!;

    public string? TotalAmount { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
