using System;
using System.Collections.Generic;

namespace XayDungWebAphone.Models;

public partial class Client
{
    public int IdClient { get; set; }

    public string Sdt { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Country { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
