using System;
using System.Collections.Generic;

namespace XayDungWebAphone.Models;

public partial class OrderDetal
{
    public int IdOrderDetals { get; set; }

    public int Quantity { get; set; }

    public double Price { get; set; }

    public int IdBill { get; set; }

    public int IdProduct { get; set; }

    public virtual Bill IdBillNavigation { get; set; } = null!;

    public virtual Product IdProductNavigation { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
